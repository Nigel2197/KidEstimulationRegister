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
    Private Adaptative As Integer
    Private GrossMotor As Integer
    Private FineMotor As Integer
    Private Language As Integer
    Private SocialPerson As Integer

    Private Sub KidEvaluation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FindKidData() ' Busca la informacion personal del infante
        LoadKidData() ' Carga la informacion y la muestra en pantalla
        FindKidRegister() ' Busca si el infante ya cuenta con una evaluacion registrada segun su edad actual
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

        confirmation = MessageBox.Show("¿Estás seguro de que deseas registrar las conductas realizadas por el infante?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If confirmation = DialogResult.Yes Then
            KidEvaluationRegister()
        Else
            Return
        End If

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
            Lbl_Allergy.Text = "Alergias: " & dt.Rows(0)("WhatAllergy").ToString()
            Lbl_BloodType.Text = dt.Rows(0)("BloodType").ToString()
            Lbl_Name.Text = NameKid
            KidID = dt.Rows(0)("Kid_ID")
            AgeID = dt.Rows(0)("Age_ID")
            'AgeKid = dt.Rows(0)("Age").ToString().ToUpper
        Else
            MessageBox.Show("Error al consultar los datos del infante")
        End If
    End Sub

    Private Sub LoadFormRegister() ' Carga el formulario completo donde se registran las conductas del infante
        If FoundKidRegister Then ' Si existe informacion del infante
            FindBehaviorsWithStatus() ' Busca los regristos de las conductas evaluadas anteriormente
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

        query = "SELECT B.ID, B.Description AS Conducta, R.Status AS Indicador FROM Behaviors B INNER JOIN Registers R ON B.ID = R.Behavior_ID "

        where.Add("B.Area_ID = @areaid")
        parameters.Add("@areaid", AreaID)

        where.Add("B.Age_ID = @ageid")
        parameters.Add("@ageid", AgeID)

        where.Add("R.Kid_ID = @kidid")
        parameters.Add("@kidid", KidID)

        query &= "WHERE " & String.Join(" AND ", where)

        dt = GetData(query, parameters)
    End Sub

    Private Sub LoadBehaviors()
        If dt.Rows.Count > 0 Then
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
            MessageBox.Show("Error al consultar las conductas del sistema")
        End If
    End Sub

    Private Sub FindKidRegister()
        Dim result As Object = ExecuteScalar("SELECT 1 FROM Evaluations WHERE Kid_ID = @kidid AND Age_ID = @ageid",
                                           New Dictionary(Of String, Object) From {{"@kidid", KidID},
                                                                                   {"@ageid", AgeID}})
        If result Then
            FoundKidRegister = True
        Else
            FoundKidRegister = False
        End If
    End Sub

    Private Sub KidEvaluationRegister()
        ' Verifica si todos las conductas han sido seleccionadas
        If AreaSelection.Count = Cb_Area.Items.Count Then
            Try
                RegisterAreaAdaptive()     ' Se registran las conductas del area Adaptativa
                RegisterAreaGrossMotor()   ' Se registran las conductas del area Motor Grueso
                RegisterAreaFineMotor()    ' Se registran las conductas del area Motor Fino
                RegisterAreaLanguage()     ' Se registran las conductas del area Lenguaje
                RegisterAreaSocialPerson() ' Se registran las conductas del area Persona Social
                RegisterEvaluation()       ' Se registra el encabezado de la evaluación
                MessageBox.Show("Se registraron las conductas del infante correctamente", "Evaluación guardada", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show("Se produjo el error: " & ex.Message)
            End Try
        Else
            MessageBox.Show("No se han evaluado todas las areas de conductas del infante", "Evaluación incompleta", MessageBoxButtons.OK, MessageBoxIcon.Warning)
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

            Dim success As Boolean = WriteData("INSERT INTO EvaluationsDetail (Kid_ID, Age_ID, Area_ID, Behavior_ID, Status)
                                                VALUES (@kidid, @ageid, @areaid, @behaviorid, @status)",
                                           New Dictionary(Of String, Object) From {{"@kidid", KidID},
                                                                                   {"@ageid", AgeID},
                                                                                   {"@areaid", AreaID},
                                                                                   {"@behaviorid", BehaviorID},
                                                                                   {"@status", isChecked}})
            If Not success Then
                MessageBox.Show($"Ocurrió un error al guardar la evaluación{Environment.NewLine}Reinicie el sistema e intente nuevamente{Environment.NewLine}{Environment.NewLine}En caso de continuar con el error contactarse con el soporte del sistema", "Error de sistema", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Next
    End Sub

    Private Sub RegisterAreaGrossMotor()
        FindAreaID("Motriz Gruesa")
        For Each index As DataGridViewRow In Dgv_GrossMotor.Rows
            ' Obtener el valor de la columna "ID"
            BehaviorID = index.Cells("ID_G").Value
            ' Obtener el valor de la columna "Indicador"
            isChecked = If(Convert.ToBoolean(index.Cells("Indicador_G").Value), 1, 0)

            Dim success As Boolean = WriteData("INSERT INTO Registers (Kid_ID, Age_ID, Area_ID, Behavior_ID, Status)
                                                VALUES (@kidid, @ageid, @areaid, @behaviorid, @status)",
                                           New Dictionary(Of String, Object) From {{"@kidid", KidID},
                                                                                   {"@ageid", AgeID},
                                                                                   {"@areaid", AreaID},
                                                                                   {"@behaviorid", BehaviorID},
                                                                                   {"@status", isChecked}})
            If Not success Then
                MessageBox.Show($"Ocurrió un error al guardar la evaluación{Environment.NewLine}Reinicie el sistema e intente nuevamente{Environment.NewLine}{Environment.NewLine}En caso de continuar con el error contactarse con el soporte del sistema", "Error de sistema", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Next
    End Sub

    Private Sub RegisterAreaFineMotor()
        FindAreaID("Motriz Fina")
        For Each index As DataGridViewRow In Dgv_FineMotor.Rows
            ' Obtener el valor de la columna "ID"
            BehaviorID = index.Cells("ID_F").Value
            ' Obtener el valor de la columna "Indicador"
            isChecked = If(Convert.ToBoolean(index.Cells("Indicador_F").Value), 1, 0)

            Dim success As Boolean = WriteData("INSERT INTO Registers (Kid_ID, Age_ID, Area_ID, Behavior_ID, Status)
                                                VALUES (@kidid, @ageid, @areaid, @behaviorid, @status)",
                                           New Dictionary(Of String, Object) From {{"@kidid", KidID},
                                                                                   {"@ageid", AgeID},
                                                                                   {"@areaid", AreaID},
                                                                                   {"@behaviorid", BehaviorID},
                                                                                   {"@status", isChecked}})
            If Not success Then
                MessageBox.Show($"Ocurrió un error al guardar la evaluación{Environment.NewLine}Reinicie el sistema e intente nuevamente{Environment.NewLine}{Environment.NewLine}En caso de continuar con el error contactarse con el soporte del sistema", "Error de sistema", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Next
    End Sub

    Private Sub RegisterAreaLanguage()
        FindAreaID("Lenguaje")
        For Each index As DataGridViewRow In Dgv_Language.Rows
            ' Obtener el valor de la columna "ID"
            BehaviorID = index.Cells("ID_L").Value
            ' Obtener el valor de la columna "Indicador"
            isChecked = If(Convert.ToBoolean(index.Cells("Indicador_L").Value), 1, 0)

            Dim success As Boolean = WriteData("INSERT INTO Registers (Kid_ID, Age_ID, Area_ID, Behavior_ID, Status)
                                                VALUES (@kidid, @ageid, @areaid, @behaviorid, @status)",
                                           New Dictionary(Of String, Object) From {{"@kidid", KidID},
                                                                                   {"@ageid", AgeID},
                                                                                   {"@areaid", AreaID},
                                                                                   {"@behaviorid", BehaviorID},
                                                                                   {"@status", isChecked}})
            If Not success Then
                MessageBox.Show($"Ocurrió un error al guardar la evaluación{Environment.NewLine}Reinicie el sistema e intente nuevamente{Environment.NewLine}{Environment.NewLine}En caso de continuar con el error contactarse con el soporte del sistema", "Error de sistema", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Next
    End Sub

    Private Sub RegisterAreaSocialPerson()
        FindAreaID("Personal Social")
        For Each index As DataGridViewRow In Dgv_SocialPerson.Rows
            ' Obtener el valor de la columna "ID"
            BehaviorID = index.Cells("ID_S").Value
            ' Obtener el valor de la columna "Indicador"
            isChecked = If(Convert.ToBoolean(index.Cells("Indicador_S").Value), 1, 0)

            Dim success As Boolean = WriteData("INSERT INTO Registers (Kid_ID, Age_ID, Area_ID, Behavior_ID, Status)
                                                VALUES (@kidid, @ageid, @areaid, @behaviorid, @status)",
                                           New Dictionary(Of String, Object) From {{"@kidid", KidID},
                                                                                   {"@ageid", AgeID},
                                                                                   {"@areaid", AreaID},
                                                                                   {"@behaviorid", BehaviorID},
                                                                                   {"@status", isChecked}})
            If Not success Then
                MessageBox.Show($"Ocurrió un error al guardar la evaluación{Environment.NewLine}Reinicie el sistema e intente nuevamente{Environment.NewLine}{Environment.NewLine}En caso de continuar con el error contactarse con el soporte del sistema", "Error de sistema", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Next
    End Sub

    Private Sub RegisterEvaluation()

        For Each index As DataGridViewRow In Dgv_Adaptative.Rows
            ' Obtener el valor de la columna "ID"
            BehaviorID = index.Cells("ID_A").Value
            ' Obtener el valor de la columna "Indicador"
            isChecked = If(Convert.ToBoolean(index.Cells("Indicador_A").Value), 1, 0)

            Dim success As Boolean = WriteData("INSERT INTO Evaluations (Kid_ID, Age_ID, Adaptative, GrossMotor, FineMotor, Language, SocialPerson, Comments, WeekAttention)
                                                VALUES (@kidid, @ageid, @adaptative, @grossmotor, @finemotor, @languague, @socialperson, @comments, @weekattention)",
                                           New Dictionary(Of String, Object) From {{"@kidid", KidID},
                                                                                   {"@ageid", AgeID},
                                                                                   {"@adaptative", AreaID},
                                                                                   {"@grossmotor", BehaviorID},
                                                                                   {"@finemotor", isChecked},
                                                                                   {"@languague", KidID},
                                                                                   {"@socialperson", AgeID},
                                                                                   {"@adaptative", AreaID},
                                                                                   {"@comments", Tb_Comments.Text},
                                                                                   {"@weekattention", isChecked}})

            Dim successdetail As Boolean = WriteData("INSERT INTO EvaluationsDetail (Kid_ID, Age_ID, Area_ID, Behavior_ID, Status)
                                                VALUES (@kidid, @ageid, @areaid, @behaviorid, @status)",
                                           New Dictionary(Of String, Object) From {{"@kidid", KidID},
                                                                                   {"@ageid", AgeID},
                                                                                   {"@areaid", AreaID},
                                                                                   {"@behaviorid", BehaviorID},
                                                                                   {"@status", isChecked}})
            If Not success And Not successdetail Then
                MessageBox.Show($"Ocurrió un error al guardar la evaluación{Environment.NewLine}Reinicie el sistema e intente nuevamente{Environment.NewLine}{Environment.NewLine}En caso de continuar con el error contactarse con el soporte del sistema", "Error de sistema", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Next
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

End Class