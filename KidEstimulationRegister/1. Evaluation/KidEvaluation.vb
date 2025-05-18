Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports DataAccess

Public Class KidEvaluation
    Private NameKid As String
    Private AgeKid As String
    Private KidID As Integer
    Private AgeID As Integer
    Private AreaID As Integer
    Private BehaviorID As Integer
    Private FoundKidRegister As Boolean
    Private isChecked As Boolean
    Private AreaSelection As New HashSet(Of Integer)() ' Almacenar los índices de las areas seleccionadas

    ' Variables para almacenar la cantidad de conductas que cumplió el infante
    Private EvaluationID As Integer
    Private Session As Integer
    Private MaxSession As Integer
    Private Adaptative As Integer
    Private GrossMotor As Integer
    Private FineMotor As Integer
    Private Language As Integer
    Private SocialPerson As Integer

    Private Sub KidEvaluation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FindKidPersonalData() ' Busca la informacion personal del infante
        FindKidEvaluationData() ' Busca si el infante ya cuenta con una evaluacion registrada segun su edad actual
        Cb_Area.SelectedIndex = 0 ' Se inicia con la conducta "Adaptativa"
        AreaSelection.Add(Cb_Area.SelectedIndex) ' Agrega manualmente el índice del area seleccionada al HashSet
    End Sub

    Public Sub New(Name As String)
        InitializeComponent()
        NameKid = Name
    End Sub

    Private Sub Cb_Area_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cb_Area.SelectedIndexChanged
        FindAreaID(Cb_Area.Text)
        LoadFormRegister()
    End Sub

    Private Sub Cb_Area_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles Cb_Area.SelectionChangeCommitted
        AreaSelection.Add(Cb_Area.SelectedIndex) ' Agrega el índice del area seleccionada al HashSet
        Cb_Area.Invalidate() ' Fuerza el redibujado del ComboBox
        Me.ActiveControl = Nothing ' Le quita el focus al ComboBox
    End Sub

    Private Sub Btn_Save_Click(sender As Object, e As EventArgs) Handles Btn_Save.Click
        Dim confirmation As DialogResult

        confirmation = MessageBox.Show("¿Está seguro de que desea registrar las conductas realizadas por el infante?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If confirmation = DialogResult.Yes Then
            ' Verifica si todos las areas de conductas han sido seleccionadas
            If AreaSelection.Count = Cb_Area.Items.Count Then
                Try
                    RegisterEvaluationHeader() ' Se registra el encabezado de la evaluación

                    If success Then ' Si se registro el encabezado exitosamente
                        FindKidEvaluationID()      ' Busca el ID de la Evaluacion que se esta registrando
                        RegisterEvaluationDetail() ' Se registra el detalle de la evaluación

                        If success Then ' Si se registro el detalle exitosamente
                            RegisterEvaluation() ' Se coloca en el encabezado de la evaluación las cantidades de conductas cumplidas por areas

                            If success Then ' Si se registro todo exitosamente
                                MessageBox.Show("Se registraron las conductas del infante correctamente", "Evaluación guardada", MessageBoxButtons.OK, MessageBoxIcon.Information)

                                ' Cierra esta pantalla de evaluacion
                                Dim frm As New ScreenEvaluation()
                                frm.Show()
                                Me.Close()
                            Else
                                MessageBox.Show($"Error en el proceso de guardado de la evaluación{Environment.NewLine}Reinicie el sistema e intente nuevamente{Environment.NewLine}{Environment.NewLine}En caso de continuar con el error contactarse con el soporte del sistema", "Error de sistema", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                                EvaluationDelete() ' Si algo falló borra todos los datos de la evaluacion 'guardada'
                            End If

                        Else
                            MessageBox.Show($"Ocurrió un error al guardar el detalle de la evaluación{Environment.NewLine}Reinicie el sistema e intente nuevamente{Environment.NewLine}{Environment.NewLine}En caso de continuar con el error contactarse con el soporte del sistema", "Error de sistema", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            EvaluationDelete() ' Si algo falló borra todos los datos de la evaluacion 'guardada'
                        End If

                    Else
                        MessageBox.Show($"Ocurrió un error al guardar el encabezado de la evaluación{Environment.NewLine}Reinicie el sistema e intente nuevamente{Environment.NewLine}{Environment.NewLine}En caso de continuar con el error contactarse con el soporte del sistema", "Error de sistema", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If

                Catch ex As Exception
                    MessageBox.Show("Se produjo el error: " & ex.Message)
                End Try
            Else
                MessageBox.Show("No se han evaluado todas las areas de conductas del infante", "Evaluación incompleta", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If
        Else
            Return
        End If
    End Sub

    Private Sub FindKidPersonalData() ' Busca los datos personales del infante
        where = New List(Of String)() ' Se vacian los filtros utilizados
        parameters = New Dictionary(Of String, Object)() ' Se vacian los parametros utilizados

        query = "SELECT K.ID AS Kid_ID, A.ID AS Age_ID, A.WeeksAge, A.Age, K.BloodType, CASE WHEN K.WhatAllergy = '' THEN 'No tiene' ELSE K.WhatAllergy END WhatAllergy
                 FROM Kids K
                 JOIN Ages A ON K.Age_ID = A.ID "

        where.Add("Name = @name")
        parameters.Add("@name", NameKid)

        query &= "WHERE " & String.Join("", where)

        dt = GetData(query, parameters)

        If dt IsNot Nothing Then ' Muestra en pantalla los datos personales del infante
            Lbl_Age.Text = dt.Rows(0)("Age").ToString().ToUpper
            Lbl_Allergy.Text = "Alergias: " & dt.Rows(0)("WhatAllergy").ToString()
            Lbl_BloodType.Text = dt.Rows(0)("BloodType").ToString()
            Lbl_Name.Text = NameKid
            KidID = dt.Rows(0)("Kid_ID")
            AgeID = dt.Rows(0)("Age_ID")
        Else
            MessageBox.Show("Error al consultar los datos del infante")
        End If
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

        ' Se busca el numero de sesion que lleva el infante
        Session = ExecuteScalar("SELECT COALESCE((SELECT MAX(Session) FROM Evaluations WHERE Kid_ID = @kidid AND Age_ID = @ageid), 0) + 1 AS Session",
                                           New Dictionary(Of String, Object) From {{"@kidid", KidID},
                                                                                   {"@ageid", AgeID}})
        MaxSession = ExecuteScalar("SELECT COALESCE((SELECT MAX(GeneralSession) FROM Evaluations WHERE Kid_ID = @kidid), 0) + 1 AS MaxSession",
                                           New Dictionary(Of String, Object) From {{"@kidid", KidID}})
    End Sub

    Private Sub FindAreaID(Area As String)
        AreaID = ExecuteScalar("SELECT ID FROM Areas WHERE Name = @name",
                                           New Dictionary(Of String, Object) From {{"@name", Area}})
    End Sub

    Private Sub LoadFormRegister() ' Carga el formulario completo donde se registran las conductas del infante
        If FoundKidRegister Then ' Si existe informacion del infante
            FindBehaviorsWithStatus() ' Busca los registros de las conductas evaluadas anteriormente
        Else
            FindBehaviors() ' Busca las conductas a evaluar
        End If

        LoadBehaviors() ' Carga el listado de las conductas
    End Sub

    Private Sub FindBehaviors()
        where = New List(Of String)() ' Se vacian los filtros utilizados
        parameters = New Dictionary(Of String, Object)() ' Se vacian los parametros utilizados

        query = "SELECT ID, Description AS Conducta FROM Behaviors "

        where.Add("Area_ID = @areaid")
        parameters.Add("@areaid", AreaID)

        where.Add("Age_ID = @ageid")
        parameters.Add("@ageid", AgeID)

        query &= "WHERE " & String.Join(" AND ", where)

        dt = GetData(query, parameters)
    End Sub

    Private Sub FindBehaviorsWithStatus()
        where = New List(Of String)() ' Se vacian los filtros utilizados
        parameters = New Dictionary(Of String, Object)() ' Se vacian los parametros utilizados

        query = "SELECT B.ID, B.Description AS Conducta, ED.Status AS Indicador FROM Behaviors B INNER JOIN EvaluationsDetail ED ON B.ID = ED.Behavior_ID INNER JOIN Evaluations E ON ED.Evaluation_ID = E.ID "

        where.Add("B.Area_ID = @areaid")
        parameters.Add("@areaid", AreaID)

        where.Add("B.Age_ID = @ageid")
        parameters.Add("@ageid", AgeID)

        where.Add("E.Kid_ID = @kidid")
        parameters.Add("@kidid", KidID)

        where.Add("E.ID = (SELECT MAX(ID) FROM Evaluations WHERE Kid_ID = @kidid AND Age_ID = @ageid)")

        query &= "WHERE " & String.Join(" AND ", where)

        dt = GetData(query, parameters)
    End Sub

    Private Sub LoadBehaviors()
        If dt IsNot Nothing Then
            Select Case AreaID
                Case 1
                    If Dgv_Adaptative.DataSource Is Nothing Then
                        Dgv_Adaptative.AutoGenerateColumns = False
                        Dgv_Adaptative.DataSource = dt
                    End If
                    Dgv_Adaptative.BringToFront()

                Case 2
                    If Dgv_GrossMotor.DataSource Is Nothing Then
                        Dgv_GrossMotor.AutoGenerateColumns = False
                        Dgv_GrossMotor.DataSource = dt
                    End If
                    Dgv_GrossMotor.BringToFront()

                Case 3
                    If Dgv_FineMotor.DataSource Is Nothing Then
                        Dgv_FineMotor.AutoGenerateColumns = False
                        Dgv_FineMotor.DataSource = dt
                    End If
                    Dgv_FineMotor.BringToFront()

                Case 4
                    If Dgv_Language.DataSource Is Nothing Then
                        Dgv_Language.AutoGenerateColumns = False
                        Dgv_Language.DataSource = dt
                    End If
                    Dgv_Language.BringToFront()

                Case 5
                    If Dgv_SocialPerson.DataSource Is Nothing Then
                        Dgv_SocialPerson.AutoGenerateColumns = False
                        Dgv_SocialPerson.DataSource = dt
                    End If
                    Dgv_SocialPerson.BringToFront()
            End Select
        Else
            MessageBox.Show("Error al consultar las conductas del sistema", "Error de sistema", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        End If
    End Sub

    Private Sub RegisterEvaluationHeader()
        success = WriteData("INSERT INTO Evaluations (Kid_ID, Age_ID, Adaptative, GrossMotor, FineMotor, Language, SocialPerson, Comments, Session, GeneralSession)
                                                VALUES (@kidid, @ageid, @adaptative, @grossmotor, @finemotor, @language, @socialperson, @comments, @session, @maxsession)",
                                           New Dictionary(Of String, Object) From {{"@kidid", KidID},
                                                                                   {"@ageid", AgeID},
                                                                                   {"@adaptative", Adaptative},
                                                                                   {"@grossmotor", GrossMotor},
                                                                                   {"@finemotor", FineMotor},
                                                                                   {"@language", Language},
                                                                                   {"@socialperson", SocialPerson},
                                                                                   {"@comments", Tb_Comments.Text},
                                                                                   {"@session", Session},
                                                                                   {"@maxsession", MaxSession}})
    End Sub
    Private Sub FindKidEvaluationID()
        EvaluationID = ExecuteScalar("SELECT COALESCE((SELECT ID FROM Evaluations WHERE Kid_ID = @kidid AND Age_ID = @ageid ORDER BY ID DESC LIMIT 1), 0) AS UltimoID",
                                     New Dictionary(Of String, Object) From {{"@kidid", KidID},
                                                                             {"@ageid", AgeID}})
    End Sub
    Private Sub RegisterEvaluationDetail()
        RegisterAreaAdaptive()     ' Se registran las conductas del area Adaptativa
        If success Then
            RegisterAreaGrossMotor()   ' Se registran las conductas del area Motor Grueso
            If success Then
                RegisterAreaFineMotor()    ' Se registran las conductas del area Motor Fino
                If success Then
                    RegisterAreaLanguage()     ' Se registran las conductas del area Lenguaje
                    If success Then
                        RegisterAreaSocialPerson() ' Se registran las conductas del area Persona Social
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub RegisterAreaAdaptive()
        FindAreaID("Adaptativa")
        Adaptative = 0 ' Se inicia en 0

        For Each index As DataGridViewRow In Dgv_Adaptative.Rows
            ' Obtener el valor de la columna "ID"
            BehaviorID = index.Cells("ID_A").Value

            ' Obtener el valor de la columna "Indicador"
            If (Convert.ToBoolean(index.Cells("Indicador_A").Value)) Then
                isChecked = 1
                Adaptative += 1 ' Se suma 1 el contador de conductas cumplidas
            Else
                isChecked = 0
            End If

            success = WriteData("INSERT INTO EvaluationsDetail (Evaluation_ID, Area_ID, Behavior_ID, Status)
                                 VALUES (@evaluationid, @areaid, @behaviorid, @status)",
                                New Dictionary(Of String, Object) From {{"@evaluationid", EvaluationID},
                                                                        {"@areaid", AreaID},
                                                                        {"@behaviorid", BehaviorID},
                                                                        {"@status", isChecked}})
        Next
    End Sub

    Private Sub RegisterAreaGrossMotor()
        FindAreaID("Motriz Gruesa")
        GrossMotor = 0 ' Se inicia en 0

        For Each index As DataGridViewRow In Dgv_GrossMotor.Rows
            ' Obtener el valor de la columna "ID"
            BehaviorID = index.Cells("ID_G").Value

            ' Obtener el valor de la columna "Indicador"
            If (Convert.ToBoolean(index.Cells("Indicador_G").Value)) Then
                isChecked = 1
                GrossMotor += 1 ' Se suma 1 el contador de conductas cumplidas
            Else
                isChecked = 0
            End If

            success = WriteData("INSERT INTO EvaluationsDetail (Evaluation_ID, Area_ID, Behavior_ID, Status)
                                 VALUES (@evaluationid, @areaid, @behaviorid, @status)",
                                New Dictionary(Of String, Object) From {{"@evaluationid", EvaluationID},
                                                                        {"@areaid", AreaID},
                                                                        {"@behaviorid", BehaviorID},
                                                                        {"@status", isChecked}})
        Next
    End Sub

    Private Sub RegisterAreaFineMotor()
        FindAreaID("Motriz Fina")
        FineMotor = 0 ' Se inicia en 0

        For Each index As DataGridViewRow In Dgv_FineMotor.Rows
            ' Obtener el valor de la columna "ID"
            BehaviorID = index.Cells("ID_F").Value

            ' Obtener el valor de la columna "Indicador"
            If (Convert.ToBoolean(index.Cells("Indicador_F").Value)) Then
                isChecked = 1
                FineMotor += 1 ' Se suma 1 el contador de conductas cumplidas
            Else
                isChecked = 0
            End If

            success = WriteData("INSERT INTO EvaluationsDetail (Evaluation_ID, Area_ID, Behavior_ID, Status)
                                 VALUES (@evaluationid, @areaid, @behaviorid, @status)",
                                New Dictionary(Of String, Object) From {{"@evaluationid", EvaluationID},
                                                                        {"@areaid", AreaID},
                                                                        {"@behaviorid", BehaviorID},
                                                                        {"@status", isChecked}})
        Next
    End Sub

    Private Sub RegisterAreaLanguage()
        FindAreaID("Lenguaje")
        Language = 0 ' Se inicia en 0

        For Each index As DataGridViewRow In Dgv_Language.Rows
            ' Obtener el valor de la columna "ID"
            BehaviorID = index.Cells("ID_L").Value

            ' Obtener el valor de la columna "Indicador"
            If (Convert.ToBoolean(index.Cells("Indicador_L").Value)) Then
                isChecked = 1
                Language += 1 ' Se suma 1 el contador de conductas cumplidas
            Else
                isChecked = 0
            End If

            success = WriteData("INSERT INTO EvaluationsDetail (Evaluation_ID, Area_ID, Behavior_ID, Status)
                                 VALUES (@evaluationid, @areaid, @behaviorid, @status)",
                                New Dictionary(Of String, Object) From {{"@evaluationid", EvaluationID},
                                                                        {"@areaid", AreaID},
                                                                        {"@behaviorid", BehaviorID},
                                                                        {"@status", isChecked}})
        Next
    End Sub

    Private Sub RegisterAreaSocialPerson()
        FindAreaID("Personal Social")
        SocialPerson = 0 ' Se inicia en 0

        For Each index As DataGridViewRow In Dgv_SocialPerson.Rows
            ' Obtener el valor de la columna "ID"
            BehaviorID = index.Cells("ID_S").Value

            ' Obtener el valor de la columna "Indicador"
            If (Convert.ToBoolean(index.Cells("Indicador_S").Value)) Then
                isChecked = 1
                SocialPerson += 1 ' Se suma 1 el contador de conductas cumplidas
            Else
                isChecked = 0
            End If

            success = WriteData("INSERT INTO EvaluationsDetail (Evaluation_ID, Area_ID, Behavior_ID, Status)
                                 VALUES (@evaluationid, @areaid, @behaviorid, @status)",
                                New Dictionary(Of String, Object) From {{"@evaluationid", EvaluationID},
                                                                        {"@areaid", AreaID},
                                                                        {"@behaviorid", BehaviorID},
                                                                        {"@status", isChecked}})
        Next
    End Sub

    Private Sub RegisterEvaluation()
        success = WriteData("UPDATE Evaluations SET Adaptative = @adaptative, GrossMotor = @grossmotor, FineMotor = @finemotor, Language = @language, SocialPerson = @socialperson
                             WHERE ID = @evaluationid",
                            New Dictionary(Of String, Object) From {{"@adaptative", Adaptative},
                                                                    {"@grossmotor", GrossMotor},
                                                                    {"@finemotor", FineMotor},
                                                                    {"@language", Language},
                                                                    {"@socialperson", SocialPerson},
                                                                    {"@evaluationid", EvaluationID}})
    End Sub

    Private Sub EvaluationDelete()
        success = WriteData("PRAGMA foreign_keys = OFF;

                             DELETE FROM Evaluations WHERE ID = @evaluationid;
                             DELETE FROM EvaluationsDetail WHERE Evaluation_ID = @evaluationid;

                             PRAGMA foreign_keys = ON;",
                            New Dictionary(Of String, Object) From {{"@evaluationid", EvaluationID}})
    End Sub

    Private Sub Cb_Area_DrawItem(sender As Object, e As DrawItemEventArgs) Handles Cb_Area.DrawItem
        If e.Index < 0 Then Return ' Evita errores si el ComboBox está vacío

        e.DrawBackground()

        Dim text As String = Cb_Area.Items(e.Index).ToString()
        Dim ColorText As Brush = If(AreaSelection.Contains(e.Index), Brushes.Green, Brushes.Black)

        e.Graphics.DrawString(text, e.Font, ColorText, e.Bounds) ' Colorea el texto de color verde a todos las conductas que ya fueron seleccionadas
        e.DrawFocusRectangle()
    End Sub

    Private Sub btn_Clean_Click(sender As Object, e As EventArgs) Handles btn_Clean.Click
        Dim confirmation As DialogResult

        confirmation = MessageBox.Show($"¿Está seguro de que desea limpiar las conductas evaluadas durante esta sesion?{Environment.NewLine}{Environment.NewLine}", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If confirmation = DialogResult.Yes Then
            Dim frm As New KidEvaluation(Lbl_Name.Text)
            frm.Show()
            Me.Close()
        End If
    End Sub

    Private Sub btn_Exit_Click(sender As Object, e As EventArgs) Handles btn_Exit.Click
        Dim confirmation As DialogResult

        confirmation = MessageBox.Show($"¿Está seguro de que desea salir?{Environment.NewLine}{Environment.NewLine}La evaluacion actual no se guardará", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If confirmation = DialogResult.Yes Then
            Dim frm As New ScreenEvaluation()
            frm.Show()
            Me.Close()
        End If
    End Sub

End Class