Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports DataAccess

Public Class KidEvaluation
    Private NameKid As String
    Private KidID As Integer
    Private AgeID As Integer
    Private AreaID As Integer

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
        AreaID = Cb_Area.SelectedIndex + 1
        LoadFormRegister()
    End Sub

    Private Sub Cb_Area_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles Cb_Area.SelectionChangeCommitted
        AreaSelection.Add(Cb_Area.SelectedIndex) ' Agrega el índice del area seleccionada al HashSet
        Cb_Area.Invalidate() ' Fuerza el redibujado del ComboBox
        Me.ActiveControl = Nothing ' Le quita el focus al ComboBox
    End Sub

    Private Sub FindKidData() ' Busca los datos personales del infante
        where = New List(Of String)() ' Se vacian los filtros utilizados
        parameters = New Dictionary(Of String, Object)() ' Se vacian los parametros utilizados

        query = "SELECT K.ID AS Kid_ID, A.ID AS Age_ID, A.WeeksAge, A.Age, K.BloodType, K.WhatAllergy
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
            Lbl_WeeksAge.Text = dt.Rows(0)("WeeksAge").ToString() & " Semanas"
            Lbl_Allergy.Text = "Es alérgico a: " & dt.Rows(0)("WhatAllergy").ToString()
            Lbl_BloodType.Text = dt.Rows(0)("BloodType").ToString()
            Lbl_Name.Text = NameKid
            KidID = dt.Rows(0)("Kid_ID")
            AgeID = dt.Rows(0)("Age_ID")
        Else
            MessageBox.Show("Error al consultar los datos del infante")
        End If
    End Sub

    Private Sub LoadFormRegister() ' Carga el formulario completo donde se registran las actividades del infante
        'Select Case Cb_Behavior.SelectedIndex
        '    Case 1
        '        If Dgv_Adaptative.DataSource Is Nothing Then

        '        End If
        'End Select

        FindBehaviors()
        LoadBehaviors()
        LoadStatusForm()
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
        Dgv_Adaptative.DataSource = Nothing
        If dt.Rows.Count > 0 Then
            Dgv_Adaptative.DataSource = dt
            Dgv_Adaptative.Columns("ID").Visible = False ' Oculta la columna ID

            ' Crear una nueva columna de tipo CheckBox para guardar el registro del infante
            Dim CheckBoxColumn As New DataGridViewCheckBoxColumn()
            CheckBoxColumn.Name = "Indicador"
            CheckBoxColumn.HeaderText = "Indicador"
            'checkBoxColumn.TrueValue = True
            'checkBoxColumn.FalseValue = False
            'checkBoxColumn.ThreeState = False

            ' Insertar la columna en la posición deseada (por ejemplo, al inicio)
            Dgv_Adaptative.Columns.Insert(2, CheckBoxColumn)
        Else
            MessageBox.Show("Error al consultar las conductas del sistema")
        End If
    End Sub

    Private Sub FindKidRegister()
        Dim result As Object = ExecuteScalar("SELECT 1 FROM Registers WHERE Kid_ID = @kidid AND AgeID = @ageid",
                                           New Dictionary(Of String, Object) From {{"@kidid", KidID},
                                                                                   {"@ageid", AgeID}})
    End Sub

    Private Sub LoadStatusForm()

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

    Private Sub KidEvaluationRegister()

        RegisterAreaAdaptive()

        ' Verificar si todos los elementos han sido seleccionados
        If AreaSelection.Count = Cb_Area.Items.Count Then

            'If success Then
            MessageBox.Show("Se registraron las actividades del infante correctamente", "Registro aceptado", MessageBoxButtons.OK, MessageBoxIcon.Information)
            'Else
            '    MessageBox.Show("Error al ejecutar procedimiento.", "Registro rechazado", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End If

    End Sub

    Private Sub RegisterAreaAdaptive()
        AreaID = 1 ' El area Adaptativa su ID es 1 a nivel de base de datos
        For Each index As DataGridViewRow In Dgv_Adaptative.Rows
            ' Obtener el valor de la columna "ID"
            Dim BehaviorID As Integer = index.Cells("ID").Value
            Dim status As Integer = Convert.ToInt32(index.Cells("Indicador").Value)

            Dim success As Boolean = WriteData("INSERT INTO Registers (Kid_ID, Age_ID, Area_ID, Behavior_ID, Status)
                                                VALUES (@kidid, @ageid, @areaid, @behaviorid, @status)",
                                           New Dictionary(Of String, Object) From {{"@kidid", KidID},
                                                                                   {"@ageid", AgeID},
                                                                                   {"@areaid", AreaID},
                                                                                   {"@behaviorid", BehaviorID}, {"@status", status}})
        Next
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