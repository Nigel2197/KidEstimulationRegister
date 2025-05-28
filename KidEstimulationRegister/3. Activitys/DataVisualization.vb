Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.Windows.Forms.DataVisualization.Charting
Imports DataAccess
Imports System.Collections.Specialized.BitVector32

Public Class DataVisualization
    Private NameKid As String
    Private AgeKid As String
    Private KidID As Integer
    Private AgeID As Integer
    Private FoundKidRegister As Boolean

    Private Sub DataVisualization_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FindKidEvaluationData() ' Busca si el infante ya cuenta con una evaluacion registrada
        FindKidData() ' Busca la informacion personal del infante
        GetListAge() ' Obtiene todas las edades que se evaluan
        Cb_Age.SelectedIndex = 0 ' Se inicia con TODOS las edades
    End Sub

    Public Sub New(Name As String)
        InitializeComponent()
        NameKid = Name
    End Sub

    Private Sub Cb_Age_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cb_Age.SelectedIndexChanged
        LoadKidProgress(Cb_Age.Text)
    End Sub

    Private Sub FindKidEvaluationData()
        Dim result As Object = ExecuteScalar("SELECT 1 FROM Evaluations WHERE Kid_ID = @kidid AND Age_ID = @ageid",
                                           New Dictionary(Of String, Object) From {{"@kidid", KidID},
                                                                                   {"@ageid", AgeID}})
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
        If dt IsNot Nothing Then
            Lbl_Age.Text = dt.Rows(0)("Age").ToString().ToUpper
            Lbl_Name.Text = NameKid
            KidID = dt.Rows(0)("Kid_ID")
            AgeID = dt.Rows(0)("Age_ID")
        Else
            MessageBox.Show("Error al consultar los datos del infante")
        End If
    End Sub

    Private Sub GetListAge()
        query = "SELECT Age FROM Ages"
        dt = GetData(query)

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

            If isTodos Then ' Se busca el numero de sesiones maxima que lleva el infante
                maxSessions = ExecuteScalar("SELECT COALESCE(MAX(GeneralSession), 0) FROM Evaluations WHERE Kid_ID = @kidid",
                                    New Dictionary(Of String, Object) From {{"@kidid", KidID}})
            Else ' Se busca el numero de sesion que lleva el infante para esa edad
                maxSessions = ExecuteScalar("SELECT COALESCE(MAX(Session), 0) FROM Evaluations WHERE Kid_ID = @kidid AND Age_ID = @ageid",
                                    New Dictionary(Of String, Object) From {{"@kidid", KidID}, {"@ageid", AgeID}})

            End If

            For NumSession As Integer = 1 To maxSessions ' Se recorre el numero de sesiones que se han realizado
                ' Ejecutar consulta
                where = New List(Of String)() ' Se vacian los filtros utilizados
                parameters = New Dictionary(Of String, Object)() ' Se vacian los parametros utilizados

                query = "SELECT ROUND((E.Adaptative * 100.0) / (SELECT COUNT(B.ID) FROM Behaviors B WHERE B.Age_ID = @ageid AND B.Area_ID = 1 AND E.Session = @session) / 5.0, 0) * 5 AS Adaptative,
                            ROUND((E.GrossMotor * 100.0) / (SELECT COUNT(B.ID) FROM Behaviors B WHERE B.Age_ID = @ageid AND B.Area_ID = 2 AND E.Session = @session) / 5.0, 0) * 5 AS GrossMotor,
                            ROUND((E.FineMotor * 100.0) / (SELECT COUNT(B.ID) FROM Behaviors B WHERE B.Age_ID = @ageid AND B.Area_ID = 3 AND E.Session = @session) / 5.0, 0) * 5 AS FineMotor,
                            ROUND((E.Language * 100.0) / (SELECT COUNT(B.ID) FROM Behaviors B WHERE B.Age_ID = @ageid AND B.Area_ID = 4 AND E.Session = @session) / 5.0, 0) * 5 AS Language,
                            ROUND((E.SocialPerson * 100.0) / (SELECT COUNT(B.ID) FROM Behaviors B WHERE B.Age_ID = @ageid AND B.Area_ID = 5 AND E.Session = @session) / 5.0, 0) * 5 AS SocialPerson
                     FROM Evaluations E"

                where.Add("Kid_ID = @kidid")
                parameters.Add("@kidid", KidID)

                where.Add("Age_ID = @ageid")
                parameters.Add("@ageid", AgeID)

                where.Add("Session = @session")
                parameters.Add("@session", NumSession)

                query &= "WHERE " & String.Join(" AND ", where)
            Next

            '    For NumSession As Integer = 1 To maxSessions
            '        Dim where = New List(Of String) From {"Kid_ID = @kidid", "Session = @session"}
            '        Dim parameters = New Dictionary(Of String, Object) From {
            '    {"@kidid", KidID},
            '    {"@session", NumSession}
            '}

            '        If Not isTodos Then
            '            where.Add("Age_ID = @ageid")
            '            parameters.Add("@ageid", AgeID)
            '        End If

            '        Dim query As String =
            '    "SELECT ROUND((E.Adaptative * 100.0) / (SELECT COUNT(B.ID) FROM Behaviors B WHERE B.Age_ID = @ageid AND B.Area_ID = 1 AND E.Session = @session) / 5.0, 0) * 5 AS Adaptative, " &
            '    "ROUND((E.GrossMotor * 100.0) / (SELECT COUNT(B.ID) FROM Behaviors B WHERE B.Age_ID = @ageid AND B.Area_ID = 2 AND E.Session = @session) / 5.0, 0) * 5 AS GrossMotor, " &
            '    "ROUND((E.FineMotor * 100.0) / (SELECT COUNT(B.ID) FROM Behaviors B WHERE B.Age_ID = @ageid AND B.Area_ID = 3 AND E.Session = @session) / 5.0, 0) * 5 AS FineMotor, " &
            '    "ROUND((E.Language * 100.0) / (SELECT COUNT(B.ID) FROM Behaviors B WHERE B.Age_ID = @ageid AND B.Area_ID = 4 AND E.Session = @session) / 5.0, 0) * 5 AS Language, " &
            '    "ROUND((E.SocialPerson * 100.0) / (SELECT COUNT(B.ID) FROM Behaviors B WHERE B.Age_ID = @ageid AND B.Area_ID = 5 AND E.Session = @session) / 5.0, 0) * 5 AS SocialPerson " &
            '    "FROM Evaluations E WHERE " & String.Join(" AND ", where)

            '        dt = GetData(query, parameters)
            '        ' Aquí puedes procesar dt para graficar, etc.
            '    Next


            dt = GetData(query, parameters)

            ' Título opcional
            'Ch_ProgressKid.Titles.Add("Desarrollo del Niño en Edad de " & Age)
        Else
            MessageBox.Show("No se encontró evaluaciones realizadas al infante", "Sin Datos", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub

    Private Sub btn_Exit_Click(sender As Object, e As EventArgs) Handles btn_Exit.Click
        Dim frm As New FindKidProgress()
        frm.Show()
        Me.Close()
    End Sub

End Class