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

    Private Sub KidEvaluation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FindKidData()
        LoadKidData()

        Cb_Area.SelectedIndex = 0 ' Se inicia con la conducta "Adaptativa"
        AreaSelection.Add(Cb_Area.SelectedIndex) ' Agrega manualmente el índice del area seleccionada al HashSet
    End Sub

    Public Sub New(Name As String)
        InitializeComponent()
        NameKid = Name
    End Sub

    Private Sub Cb_Area_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cb_Area.SelectedIndexChanged
        'AreaID = Cb_Area.SelectedIndex + 1
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
        FindBehaviors()
        LoadBehaviors()

        If FoundKidRegister Then
            LoadStatusForm()
        End If
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

    Private Sub LoadBehaviors()
        If dt.Rows.Count > 0 Then
            Select Case AreaID
                Case 1
                    If Dgv_Adaptative.DataSource Is Nothing Then
                        Dgv_Adaptative.AutoGenerateColumns = False
                        Dgv_Adaptative.DataSource = dt
                        'Dgv_Adaptative.Columns("Conducta").HeaderText = "Conductas " + " (" + AgeKid + ")"
                        'Dgv_Adaptative.Columns("ID").Visible = False ' Oculta la columna ID
                        'Dgv_Adaptative.Columns.Insert(2, CheckBoxColumn)
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
        Dim result As Object = ExecuteScalar("SELECT 1 FROM Registers WHERE Kid_ID = @kidid AND AgeID = @ageid",
                                           New Dictionary(Of String, Object) From {{"@kidid", KidID},
                                                                                   {"@ageid", AgeID}})
        If result Then
            FoundKidRegister = True
        Else
            FoundKidRegister = False
        End If
    End Sub

    Private Sub LoadStatusForm()

    End Sub

    Private Sub KidEvaluationRegister()
        ' Verificar si todos los elementos han sido seleccionados
        'If AreaSelection.Count = Cb_Area.Items.Count Then
        RegisterAreaAdaptive()
        'If success Then
        '    MessageBox.Show("Se registraron las conductas del infante correctamente", "Evaluación guardada", MessageBoxButtons.OK, MessageBoxIcon.Information)
        'Else
        '    MessageBox.Show("No se han evaluado todas las areas de conductas del infante", "Evaluación incompleta", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        'End If
    End Sub

    Private Sub RegisterAreaAdaptive()
        FindAreaID("Adaptativa")
        For Each index As DataGridViewRow In Dgv_Adaptative.Rows
            ' Obtener el valor de la columna "ID"
            BehaviorID = index.Cells("ID_A").Value
            'Dim status As Integer = Convert.ToInt32(index.Cells(Dgv_Adaptative.Columns("Indicador").Index).Value)
            ''isChecked As Boolean = False
            'If index.Cells("Indicador").Value IsNot Nothing AndAlso index.Cells("Indicador").Value IsNot DBNull.Value Then
            '    isChecked = Convert.ToBoolean(index.Cells("Indicador").Value)
            'End If
            'Dim status As Integer = If(isChecked, 1, 0)

            Dim cellValue As Object = index.Cells("Indicador_A").Value
            Dim valor As Integer = 0 ' Valor predeterminado para desmarcado

            If cellValue IsNot Nothing AndAlso cellValue IsNot DBNull.Value Then
                valor = Convert.ToInt32(cellValue)
            End If

            Dim success As Boolean = WriteData("INSERT INTO Registers (Kid_ID, Age_ID, Area_ID, Behavior_ID, Status)
                                                VALUES (@kidid, @ageid, @areaid, @behaviorid, @status)",
                                           New Dictionary(Of String, Object) From {{"@kidid", KidID},
                                                                                   {"@ageid", AgeID},
                                                                                   {"@areaid", AreaID},
                                                                                   {"@behaviorid", BehaviorID},
                                                                                   {"@status", cellValue}})
        Next
    End Sub

    Private Sub RegisterAreaGrossMotor()
        FindAreaID("Motriz Gruesa")
        For Each index As DataGridViewRow In Dgv_GrossMotor.Rows
            ' Obtener el valor de la columna "ID"
            Dim BehaviorID As Integer = index.Cells(Dgv_GrossMotor.Columns("ID").Index).Value
            Dim status As Integer = Convert.ToInt32(index.Cells(Dgv_GrossMotor.Columns("Indicador").Index).Value)

            Dim success As Boolean = WriteData("INSERT INTO Registers (Kid_ID, Age_ID, Area_ID, Behavior_ID, Status)
                                                VALUES (@kidid, @ageid, @areaid, @behaviorid, @status)",
                                           New Dictionary(Of String, Object) From {{"@kidid", KidID},
                                                                                   {"@ageid", AgeID},
                                                                                   {"@areaid", AreaID},
                                                                                   {"@behaviorid", BehaviorID},
                                                                                   {"@status", status}})
        Next
    End Sub

    Private Sub RegisterAreaFineMotor()
        FindAreaID("Motriz Fina")
        For Each index As DataGridViewRow In Dgv_FineMotor.Rows
            ' Obtener el valor de la columna "ID"
            Dim BehaviorID As Integer = index.Cells(Dgv_FineMotor.Columns("ID").Index).Value
            Dim status As Integer = Convert.ToInt32(index.Cells(Dgv_FineMotor.Columns("Indicador").Index).Value)

            Dim success As Boolean = WriteData("INSERT INTO Registers (Kid_ID, Age_ID, Area_ID, Behavior_ID, Status)
                                                VALUES (@kidid, @ageid, @areaid, @behaviorid, @status)",
                                           New Dictionary(Of String, Object) From {{"@kidid", KidID},
                                                                                   {"@ageid", AgeID},
                                                                                   {"@areaid", AreaID},
                                                                                   {"@behaviorid", BehaviorID},
                                                                                   {"@status", status}})
        Next
    End Sub

    Private Sub RegisterAreaLanguage()
        FindAreaID("Lenguaje")
        For Each index As DataGridViewRow In Dgv_Language.Rows
            ' Obtener el valor de la columna "ID"
            Dim BehaviorID As Integer = index.Cells(Dgv_Language.Columns("ID").Index).Value
            Dim status As Integer = Convert.ToInt32(index.Cells(Dgv_Language.Columns("Indicador").Index).Value)

            Dim success As Boolean = WriteData("INSERT INTO Registers (Kid_ID, Age_ID, Area_ID, Behavior_ID, Status)
                                                VALUES (@kidid, @ageid, @areaid, @behaviorid, @status)",
                                           New Dictionary(Of String, Object) From {{"@kidid", KidID},
                                                                                   {"@ageid", AgeID},
                                                                                   {"@areaid", AreaID},
                                                                                   {"@behaviorid", BehaviorID},
                                                                                   {"@status", status}})
        Next
    End Sub

    Private Sub RegisterAreaSocialPerson()
        FindAreaID("Personal Social")
        For Each index As DataGridViewRow In Dgv_SocialPerson.Rows
            ' Obtener el valor de la columna "ID"
            Dim BehaviorID As Integer = index.Cells(Dgv_SocialPerson.Columns("ID").Index).Value
            Dim status As Integer = Convert.ToInt32(index.Cells(Dgv_SocialPerson.Columns("Indicador").Index).Value)

            Dim success As Boolean = WriteData("INSERT INTO Registers (Kid_ID, Age_ID, Area_ID, Behavior_ID, Status)
                                                VALUES (@kidid, @ageid, @areaid, @behaviorid, @status)",
                                           New Dictionary(Of String, Object) From {{"@kidid", KidID},
                                                                                   {"@ageid", AgeID},
                                                                                   {"@areaid", AreaID},
                                                                                   {"@behaviorid", BehaviorID},
                                                                                   {"@status", status}})
        Next
    End Sub

    Private Sub FindAreaID(Area As String)
        AreaID = ExecuteScalar("SELECT ID FROM Areas WHERE Name = @name",
                                           New Dictionary(Of String, Object) From {{"@name", Area}})
    End Sub

    Private Sub Cb_Area_DrawItem(sender As Object, e As DrawItemEventArgs) Handles Cb_Area.DrawItem
        'If e.Index < 0 Then Exit Sub

        '' Definir colores
        'Dim textColor As Color = Color.SkyBlue
        'Dim bgColor As Color = Color.White

        '' Si el ítem está seleccionado, mantiene el mismo color de texto
        'If (e.State And DrawItemState.Selected) = DrawItemState.Selected Then
        '    bgColor = Color.LightGray ' Color de fondo cuando se selecciona
        'End If

        '' Dibujar fondo del ítem
        'Using bgBrush As New SolidBrush(bgColor)
        '    e.Graphics.FillRectangle(bgBrush, e.Bounds)
        'End Using

        '' Obtener el texto y calcular su posición para centrarlo
        'Dim text As String = Cb_Area.Items(e.Index).ToString()
        'Dim textFont As Font = Cb_Area.Font
        'Dim textSize As SizeF = e.Graphics.MeasureString(text, textFont)

        '' Calcular la posición correcta para cada ítem
        'Dim x As Integer = e.Bounds.Left + (e.Bounds.Width - textSize.Width) / 2
        'Dim y As Integer = e.Bounds.Top + (e.Bounds.Height - textSize.Height) / 2

        '' Dibujar el texto centrado en su ítem correspondiente
        'Using textBrush As New SolidBrush(textColor)
        '    e.Graphics.DrawString(text, textFont, textBrush, New PointF(x, y))
        'End Using

        'e.DrawFocusRectangle() ' Dibuja el rectángulo de selección si es necesario

        If e.Index < 0 Then Return ' Evita errores si el ComboBox está vacío

        e.DrawBackground()

        Dim text As String = Cb_Area.Items(e.Index).ToString()
        Dim ColorText As Brush = If(AreaSelection.Contains(e.Index), Brushes.Green, Brushes.Black)

        e.Graphics.DrawString(text, e.Font, ColorText, e.Bounds)
        e.DrawFocusRectangle()
    End Sub

End Class