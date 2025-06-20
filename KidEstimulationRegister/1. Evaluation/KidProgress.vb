Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.Windows.Forms.DataVisualization.Charting
Imports DataAccess
Imports System.Collections.Specialized.BitVector32

Public Class KidProgress
    Private NameKid As String
    Private AgeKid As String
    Private KidID As Integer
    Private AgeID As Integer
    Private FoundKidRegister As Boolean

    ' Variable para guardar el color y el grosor de las series
    Private Structure SerieEstiloOriginal
        Public Color As Color
        Public BorderWidth As Integer
    End Structure

    Private Sub KidProgress_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' En el constructor o en el Load del formulario:
        AddHandler Ch_ProgressKid.MouseClick, AddressOf Chart_MouseClick

        ' Guarda el color original de cada serie en la propiedad Tag
        For Each serie As Series In Ch_ProgressKid.Series
            Dim estilo As New SerieEstiloOriginal With {
                .Color = serie.Color,
                .BorderWidth = serie.BorderWidth
            }
            serie.Tag = estilo
        Next

        FindKidData() ' Busca la informacion personal del infante
        FindKidEvaluationData() ' Busca si el infante ya cuenta con una evaluacion registrada
        GetListAge() ' Obtiene todas las edades que se han evaluado del infante
        Cb_Age.SelectedIndex = 0 ' Se inicia con TODOS las edades
        RoundAllButtons(Me) ' Redondea los bordes de los botones inferiores del formulario
    End Sub

    Public Sub New(Name As String)
        InitializeComponent()
        NameKid = Name
    End Sub

    Private Sub Cb_Age_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cb_Age.SelectedIndexChanged
        LoadKidProgress(Cb_Age.Text)
    End Sub

    Private Sub FindKidEvaluationData()
        Dim result As Object = ExecuteScalar("SELECT 1 FROM Evaluations WHERE Kid_ID = @kidid",
                                           New Dictionary(Of String, Object) From {{"@kidid", KidID}})
        If result Then ' Si existe una evaluacion con su nombre y edad
            FoundKidRegister = True
        Else ' Si no existe una evaluacion con su nombre y edad
            FoundKidRegister = False
        End If
    End Sub

    Private Sub FindKidData() ' Busca los datos personales del infante
        where = New List(Of String)() ' Se vacian los filtros utilizados
        parameters = New Dictionary(Of String, Object)() ' Se vacian los parametros utilizados

        query = "SELECT K.ID AS Kid_ID, A.ID AS Age_ID, A.Age
                 FROM Kids K
                 JOIN Ages A ON K.Age_ID = A.ID "

        where.Add("Name = @name")
        parameters.Add("@name", NameKid)

        query &= "WHERE " & String.Join("", where)

        dt = GetData(query, parameters)

        ' Muestra en pantalla los datos personales del infante
        If dt.Rows.Count > 0 Then
            Lbl_Age.Text = dt.Rows(0)("Age").ToString().ToUpper
            Lbl_Name.Text = NameKid
            KidID = dt.Rows(0)("Kid_ID")
            AgeID = dt.Rows(0)("Age_ID")
        Else
            MessageBox.Show("Error al consultar los datos del infante")
        End If
    End Sub

    Private Sub GetListAge()
        where = New List(Of String)() ' Se vacian los filtros utilizados
        parameters = New Dictionary(Of String, Object)() ' Se vacian los parametros utilizados

        query = "SELECT A.ID, A.Age FROM Ages A INNER JOIN Evaluations E ON A.ID = E.Age_ID "

        where.Add("E.Kid_ID = @kidid")
        parameters.Add("@kidid", KidID)

        query &= "WHERE " & String.Join("", where) & " "

        query &= "GROUP BY A.Age"

        dt = GetData(query, parameters)

        Cb_Age.Items.Add("TODOS")
        For Each row As DataRow In dt.Rows
            Cb_Age.Items.Add(row("Age").ToString())
        Next
        Cb_Age.DisplayMember = "Age"

    End Sub

    Private Sub LoadKidProgress(Age As String)
        If FoundKidRegister Then

            Dim isTodos As Boolean = (Cb_Age.Text = "TODOS")
            Dim maxSessions As Integer

            ' Limpiar los puntos de cada serie existente
            For Each serie As Series In Ch_ProgressKid.Series
                serie.Points.Clear()
            Next

            If isTodos Then ' Se busca el numero de sesiones maxima que lleva el infante
                maxSessions = ExecuteScalar("SELECT COALESCE(MAX(GeneralSession), 0) FROM Evaluations WHERE Kid_ID = @kidid",
                                    New Dictionary(Of String, Object) From {{"@kidid", KidID}})
            Else ' Se busca el numero de sesion que lleva el infante para esa edad
                maxSessions = ExecuteScalar("SELECT COALESCE(MAX(Session), 0) FROM Evaluations E INNER JOIN Ages A ON E.Age_ID = A.ID WHERE E.Kid_ID = @kidid AND A.Age = @age",
                                    New Dictionary(Of String, Object) From {{"@kidid", KidID}, {"@age", Cb_Age.Text}})

            End If

            ' Agrega el punto (0,0) como punto inicial a cada serie
            For Each serie As Series In Ch_ProgressKid.Series
                serie.Points.Clear()
                serie.Points.AddXY(0, 0) ' Punto inicial en el origen
            Next

            For NumSession As Integer = 1 To maxSessions ' Se recorre el numero de sesiones que se han realizado
                ' Ejecutar consulta
                where = New List(Of String) From {"Kid_ID = @kidid"}
                parameters = New Dictionary(Of String, Object) From {{"@kidid", KidID}}

                If isTodos Then
                    where.Add("E.GeneralSession = @session")
                    parameters.Add("@session", NumSession)
                Else
                    where.Add("E.Session = @session")
                    parameters.Add("@session", NumSession)
                    where.Add("A.Age = @age")
                    parameters.Add("@age", Cb_Age.Text)
                End If

                query = "SELECT E.AdaptativePercent AS Adaptative,
                                E.GrossMotorPercent AS GrossMotor,
                                E.FineMotorPercent AS FineMotor,
                                E.LanguagePercent AS Language,
                                E.SocialPersonPercent AS SocialPerson
                         FROM Evaluations E 
                         INNER JOIN Ages A
					     ON E.Age_ID = A.ID "

                query &= "WHERE " & String.Join(" AND ", where)

                dt = GetData(query, parameters)
                ' Aquí puedes procesar dt para graficar, etc.
                If dt IsNot Nothing AndAlso dt.Rows.Count > 0 Then
                    Dim row = dt.Rows(0)
                    If Ch_ProgressKid.Series.IndexOf("Adaptative") >= 0 AndAlso Not IsDBNull(row("Adaptative")) Then
                        Ch_ProgressKid.Series("Adaptative").Points.AddXY(NumSession, Convert.ToDouble(row("Adaptative")))
                    End If
                    If Ch_ProgressKid.Series.IndexOf("GrossMotor") >= 0 AndAlso Not IsDBNull(row("GrossMotor")) Then
                        Ch_ProgressKid.Series("GrossMotor").Points.AddXY(NumSession, Convert.ToDouble(row("GrossMotor")))
                    End If
                    If Ch_ProgressKid.Series.IndexOf("FineMotor") >= 0 AndAlso Not IsDBNull(row("FineMotor")) Then
                        Ch_ProgressKid.Series("FineMotor").Points.AddXY(NumSession, Convert.ToDouble(row("FineMotor")))
                    End If
                    If Ch_ProgressKid.Series.IndexOf("Language") >= 0 AndAlso Not IsDBNull(row("Language")) Then
                        Ch_ProgressKid.Series("Language").Points.AddXY(NumSession, Convert.ToDouble(row("Language")))
                    End If
                    If Ch_ProgressKid.Series.IndexOf("SocialPerson") >= 0 AndAlso Not IsDBNull(row("SocialPerson")) Then
                        Ch_ProgressKid.Series("SocialPerson").Points.AddXY(NumSession, Convert.ToDouble(row("SocialPerson")))
                    End If
                End If
            Next

            ' Título opcional
            'Ch_ProgressKid.Titles.Add("Desarrollo del Niño en Edad de " & Age)
        Else
            MessageBox.Show("No se encontró evaluaciones realizadas al infante", "Sin Datos", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub

    Private Sub Chart_MouseClick(sender As Object, e As MouseEventArgs)
        Dim result = Ch_ProgressKid.HitTest(e.X, e.Y)
        If result.ChartElementType = ChartElementType.LegendItem Then
            Dim legendText As String = result.Series.Name

            For Each s As Series In Ch_ProgressKid.Series
                Dim estilo = CType(s.Tag, SerieEstiloOriginal)
                If s.Name = legendText Then
                    s.Color = estilo.Color
                    s.BorderWidth = 5 ' Resalta la seleccionada
                Else
                    s.Color = Color.LightGray
                    s.BorderWidth = 2
                End If
            Next
        Else
            For Each s As Series In Ch_ProgressKid.Series
                Dim estilo = CType(s.Tag, SerieEstiloOriginal)
                s.Color = estilo.Color
                s.BorderWidth = estilo.BorderWidth
            Next
        End If
    End Sub

    Private Sub btn_Back_Click(sender As Object, e As EventArgs) Handles btn_Back.Click
        Dim frm As New KidEvaluation(NameKid)
        frm.Show()
        Me.Dispose()
    End Sub

    Private Sub btn_Exit_Click(sender As Object, e As EventArgs) Handles btn_Exit.Click
        Dim confirmation As DialogResult

        Me.ActiveControl = Nothing ' Evita que se haga focus en el botón
        confirmation = MessageBox.Show($"¿Está seguro de que quiere cerrar el sistema?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If confirmation = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub
End Class