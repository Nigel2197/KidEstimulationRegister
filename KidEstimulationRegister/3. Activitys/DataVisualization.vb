Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.Windows.Forms.DataVisualization.Charting
Imports DataAccess

Public Class DataVisualization
    Private NameKid As String
    Private AgeKid As String
    Private KidID As Integer
    Private AgeID As Integer
    Private AreaID As Integer
    Private BehaviorID As Integer
    Private FoundKidRegister As Boolean
    Private isChecked As Boolean
    Private AreaSelection As New HashSet(Of Integer)() ' Almacenar los índices de las areas seleccionadas

    Private Sub DataVisualization_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FindKidData() ' Busca la informacion personal del infante
        FindKidEvaluation() ' Busca si el infante ya cuenta con una evaluacion registrada segun su edad actual
        GetListAge() ' Obtiene todas las edades que se evaluan
        'LoadKidEvaluation()
        Cb_Age.SelectedIndex = 0 ' Se inicia con la conducta "Adaptativa"
    End Sub

    Public Sub New(Name As String)
        InitializeComponent()
        NameKid = Name
    End Sub

    Private Sub Cb_Age_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cb_Age.SelectedIndexChanged
        LoadKidProgress(Cb_Age.Text)
    End Sub

    Private Sub FindKidData() ' Busca los datos personales del infante
        where = New List(Of String)() ' Se vacian los filtros utilizados
        parameters = New Dictionary(Of String, Object)() ' Se vacian los parametros utilizados

        query = "SELECT K.ID AS Kid_ID, A.ID AS Age_ID, A.WeeksAge, A.Age, K.BloodType, CASE WHEN K.WhatAllergy = '' THEN 'No tiene' ELSE K.WhatAllergy END WhatAllergy
                 FROM Kids K
                 JOIN Ages A ON K.Age_ID = A.ID "

        where.Add("Name = @name")
        parameters.Add("@name", NameKid)

        query &= "WHERE " & String.Join("", where)

        dt = GetData(query, parameters)

        ' Muestra en pantalla los datos personales del infante
        If dt IsNot Nothing Then
            Lbl_Age.Text = dt.Rows(0)("Age").ToString().ToUpper
            Lbl_Name.Text = NameKid
            KidID = dt.Rows(0)("Kid_ID")
            AgeID = dt.Rows(0)("Age_ID")
            'AgeKid = dt.Rows(0)("Age").ToString().ToUpper
        Else
            MessageBox.Show("Error al consultar los datos del infante")
        End If
    End Sub

    Private Sub FindKidEvaluation()
        where = New List(Of String)() ' Se vacian los filtros utilizados
        parameters = New Dictionary(Of String, Object)() ' Se vacian los parametros utilizados

        query = "SELECT Age_ID, Area_ID, SUM(Status) AS BehaviorsComplete FROM Evaluations "

        where.Add("Kid_ID = @kidid")
        parameters.Add("@areaid", KidID)

        'where.Add("Age_ID = @ageid")
        'parameters.Add("@ageid", AgeID)
        'query &= "WHERE " & String.Join(" AND ", where)

        query &= "WHERE " & String.Join("", where)
        query &= " GROUP BY Age_ID, Area_ID ORDER BY Age_ID"

        dt = GetData(query, parameters)
    End Sub

    Private Sub GetListAge()
        query = "SELECT Age FROM Ages"
        dt = GetData(query)

        Cb_Age.DataSource = dt
        Cb_Age.DisplayMember = "Age"
        Cb_Age.SelectedIndex = -1
    End Sub

    Private Sub LoadKidProgress(Age As String)
        ' Limpiar configuraciones anteriores
        Ch_ProgressKid.Series.Clear()
        Ch_ProgressKid.ChartAreas.Clear()
        Ch_ProgressKid.Titles.Clear()

        ' Crear área del gráfico
        Dim area As New ChartArea("Área")
        area.AxisY.Maximum = 100
        area.AxisY.Minimum = 0
        area.AxisY.Interval = 10
        area.AxisY.Title = "Porcentaje (%)"
        area.AxisX.Title = "Área de desarrollo"
        area.AxisX.Interval = 1
        area.AxisX.MajorGrid.Enabled = False
        area.AxisX.LabelStyle.Enabled = True
        area.AxisX.LabelStyle.Angle = 0
        Ch_ProgressKid.ChartAreas.Add(area)

        ' Crear la serie
        Dim serie As New Series("Avance")
        serie.ChartType = SeriesChartType.Line
        serie.BorderWidth = 2
        serie.MarkerStyle = MarkerStyle.Circle
        serie.MarkerSize = 8
        serie.Color = Color.SkyBlue
        serie.IsValueShownAsLabel = True ' Mostrar los valores en el gráfico
        serie.LabelForeColor = Color.DarkBlue

        ' Ejecutar consulta
        where = New List(Of String)() ' Se vacian los filtros utilizados
        parameters = New Dictionary(Of String, Object)() ' Se vacian los parametros utilizados

        query = "SELECT ROUND((Adaptative * 100.0) / (SELECT COUNT(ID) FROM Behaviors WHERE Age_ID = @ageid AND Area_ID = 1) / 5.0, 0) * 5 AS Adaptative,
                        ROUND((GrossMotor * 100.0) / (SELECT COUNT(ID) FROM Behaviors WHERE Age_ID = @ageid AND Area_ID = 2) / 5.0, 0) * 5 AS GrossMotor,
                        ROUND((FineMotor * 100.0) / (SELECT COUNT(ID) FROM Behaviors WHERE Age_ID = @ageid AND Area_ID = 3) / 5.0, 0) * 5 AS FineMotor,
                        ROUND((Language * 100.0) / (SELECT COUNT(ID) FROM Behaviors WHERE Age_ID = @ageid AND Area_ID = 4) / 5.0, 0) * 5 AS Language,
                        ROUND((SocialPerson * 100.0) / (SELECT COUNT(ID) FROM Behaviors WHERE Age_ID = @ageid AND Area_ID = 5) / 5.0, 0) * 5 AS SocialPerson
                 FROM Evaluations "

        where.Add("Kid_ID = @kidid")
        parameters.Add("@kidid", KidID)

        where.Add("Age_ID = @ageid")
        parameters.Add("@ageid", AgeID)

        query &= "WHERE " & String.Join(" AND ", where)

        dt = GetData(query, parameters)

        If dt.Rows.Count > 0 Then
            Dim row = dt.Rows(0)

            ' Verifica que cada valor no sea DBNull antes de convertirlo
            If Not IsDBNull(row("Adaptative")) Then
                serie.Points.AddXY("Adaptativa", Convert.ToDouble(row("Adaptative")))
            End If
            If Not IsDBNull(row("GrossMotor")) Then
                serie.Points.AddXY("Motriz Gruesa", Convert.ToDouble(row("GrossMotor")))
            End If
            If Not IsDBNull(row("FineMotor")) Then
                serie.Points.AddXY("Motriz Fina", Convert.ToDouble(row("FineMotor")))
            End If
            If Not IsDBNull(row("Language")) Then
                serie.Points.AddXY("Lenguaje", Convert.ToDouble(row("Language")))
            End If
            If Not IsDBNull(row("SocialPerson")) Then
                serie.Points.AddXY("Social", Convert.ToDouble(row("SocialPerson")))
            End If
        Else
            MessageBox.Show("No se encontró evaluaciones realizadas al infante", "Sin Datos", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

        ' Añadir la serie al gráfico
        Ch_ProgressKid.Series.Add(serie)

        ' Título opcional
        Ch_ProgressKid.Titles.Add("Desarrollo del Niño en Edad de " & Age)
    End Sub

    Private Sub Cb_Area_DrawItem(sender As Object, e As DrawItemEventArgs) Handles Cb_Age.DrawItem
        If e.Index < 0 Then Return ' Evita errores si el ComboBox está vacío

        e.DrawBackground()

        Dim text As String = Cb_Age.Items(e.Index).ToString()
        Dim ColorText As Brush = If(AreaSelection.Contains(e.Index), Brushes.Green, Brushes.Black)

        e.Graphics.DrawString(text, e.Font, ColorText, e.Bounds) ' Colorea el texto de color verde a todos las conductas que ya fueron seleccionadas
        e.DrawFocusRectangle()
    End Sub

    Private Sub btn_Exit_Click(sender As Object, e As EventArgs) Handles btn_Exit.Click
        Dim frm As New FindKidProgress()
        frm.Show()
        Me.Close()
    End Sub

End Class