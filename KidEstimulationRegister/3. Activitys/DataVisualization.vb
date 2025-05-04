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
        LoadKidData() ' Carga la informacion y la muestra en pantalla
        FindKidEvaluation() ' Busca si el infante ya cuenta con una evaluacion registrada segun su edad actual
        LoadKidEvaluation()
        Cb_Area.SelectedIndex = 0 ' Se inicia con la conducta "Adaptativa"
        AreaSelection.Add(Cb_Area.SelectedIndex) ' Agrega manualmente el índice del area seleccionada al HashSet
    End Sub

    Public Sub New(Name As String)
        InitializeComponent()
        NameKid = Name
    End Sub

    Private Sub Cb_Area_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cb_Area.SelectedIndexChanged
        FindAreaID(Cb_Area.Text)
    End Sub

    Private Sub Cb_Area_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles Cb_Area.SelectionChangeCommitted
        AreaSelection.Add(Cb_Area.SelectedIndex) ' Agrega el índice del area seleccionada al HashSet
        Cb_Area.Invalidate() ' Fuerza el redibujado del ComboBox
        Me.ActiveControl = Nothing ' Le quita el focus al ComboBox
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
    End Sub

    Private Sub LoadKidData() ' Muestra en pantalla los datos personales del infante
        If dt.Rows.Count > 0 Then
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

        query = "SELECT Age_ID, Area_ID, SUM(Status) AS BehaviorsComplete FROM Registers "

        where.Add("Kid_ID = @kidid")
        parameters.Add("@areaid", KidID)

        'where.Add("Age_ID = @ageid")
        'parameters.Add("@ageid", AgeID)
        'query &= "WHERE " & String.Join(" AND ", where)

        query &= "WHERE " & String.Join("", where)
        query &= " GROUP BY Age_ID, Area_ID ORDER BY Age_ID"

        dt = GetData(query, parameters)
    End Sub

    Private Sub LoadKidEvaluation()
        If dt.Rows.Count > 0 Then
            ' Limpiar el gráfico
            Ch_ProgressKid.Series.Clear()

            ' Crear una serie por cada área
            Dim areas = New Dictionary(Of Integer, String) From {
                {1, "Adaptativa"},
                {2, "Motriz Gruesa"},
                {3, "Motriz Fina"},
                {4, "Lenguaje"},
                {5, "Personal Social"}
            }

            For Each area In areas
                Dim serie = Ch_ProgressKid.Series.Add(area.Value)
                serie.ChartType = SeriesChartType.Line ' o Column
            Next

            ' Obtener los datos desde SQLite
            'Dim query As String = "SELECT Age_ID, Area_ID, SUM(Status) AS Cumplidas FROM Registers WHERE Kid_ID = @kidID GROUP BY Age_ID, Area_ID ORDER BY Age_ID"
            'Dim parameters = New Dictionary(Of String, Object) From {{"@kidID", 1}} ' o variable

            'Dim dt As DataTable = GetData(query, parameters)

            ' Llenar el gráfico
            For Each row As DataRow In dt.Rows
                Dim edad As Integer = Convert.ToInt32(row("Age_ID"))
                Dim area As Integer = Convert.ToInt32(row("Area_ID"))
                Dim valor As Integer = Convert.ToInt32(row("BehaviorsComplete"))
                Ch_ProgressKid.Series(areas(area)).Points.AddXY(edad, valor)
            Next
        Else
            MessageBox.Show("No se encontró evaluaciones realizadas al infante")
        End If
    End Sub

    Private Sub FindAreaID(Area As String)
        AreaID = ExecuteScalar("SELECT ID FROM Areas WHERE Name = @name",
                                           New Dictionary(Of String, Object) From {{"@name", Area}})
    End Sub

    Private Sub Cb_Area_DrawItem(sender As Object, e As DrawItemEventArgs) Handles Cb_Area.DrawItem
        If e.Index < 0 Then Return ' Evita errores si el ComboBox está vacío

        e.DrawBackground()

        Dim text As String = Cb_Area.Items(e.Index).ToString()
        Dim ColorText As Brush = If(AreaSelection.Contains(e.Index), Brushes.Green, Brushes.Black)

        e.Graphics.DrawString(text, e.Font, ColorText, e.Bounds) ' Colorea el texto de color verde a todos las conductas que ya fueron seleccionadas
        e.DrawFocusRectangle()
    End Sub

    Private Sub Tb_Name_TextChanged(sender As Object, e As EventArgs) Handles Tb_Name.TextChanged

    End Sub
End Class