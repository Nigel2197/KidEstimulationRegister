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
        FindKidData() ' Busca la informacion personal del infante
        FindKidEvaluationData() ' Busca si el infante ya cuenta con una evaluacion registrada
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

            ' Limpiar los puntos de cada serie existente
            For Each serie As Series In Ch_ProgressKid.Series
                serie.Points.Clear()
            Next

            If isTodos Then ' Se busca el numero de sesiones maxima que lleva el infante
                maxSessions = ExecuteScalar("SELECT COALESCE(MAX(GeneralSession), 0) FROM Evaluations WHERE Kid_ID = @kidid",
                                    New Dictionary(Of String, Object) From {{"@kidid", KidID}})
            Else ' Se busca el numero de sesion que lleva el infante para esa edad
                maxSessions = ExecuteScalar("SELECT COALESCE(MAX(Session), 0) FROM Evaluations WHERE Kid_ID = @kidid AND Age_ID = @ageid",
                                    New Dictionary(Of String, Object) From {{"@kidid", KidID}, {"@ageid", AgeID}})

            End If

            ' Agrega el punto (0,0) como punto inicial a cada serie
            For Each serie As Series In Ch_ProgressKid.Series
                serie.Points.Clear()
                serie.Points.AddXY(0, 0) ' Punto inicial en el origen
            Next

            For NumSession As Integer = 1 To maxSessions ' Se recorre el numero de sesiones que se han realizado
                ' Ejecutar consulta
                where = New List(Of String) From {"Kid_ID = @kidid", "Session = @session"}
                parameters = New Dictionary(Of String, Object) From {{"@kidid", KidID}, {"@session", NumSession}}

                If Not isTodos Then
                    where.Add("Age_ID = @ageid")
                    parameters.Add("@ageid", AgeID)
                End If

                query = "SELECT E.AdaptativePercent AS Adaptative,
                                E.GrossMotorPercent AS GrossMotor,
                                E.FineMotorPercent AS FineMotor,
                                E.LanguagePercent AS Language,
                                E.SocialPersonPercent AS SocialPerson
                     FROM Evaluations E "

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

    Private Sub btn_Exit_Click(sender As Object, e As EventArgs) Handles btn_Exit.Click
        Dim frm As New FindKidProgress()
        frm.Show()
        Me.Close()
    End Sub

End Class