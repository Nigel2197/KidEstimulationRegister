<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ScreenList
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle7 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As DataGridViewCellStyle = New DataGridViewCellStyle()
        TableLayoutPanel1 = New TableLayoutPanel()
        Label8 = New Label()
        Cb_Gender = New ComboBox()
        Label2 = New Label()
        Label1 = New Label()
        Label3 = New Label()
        Cb_WeeksAge = New ComboBox()
        Cb_Name = New ComboBox()
        Btn_FindKids = New Button()
        TableLayoutPanel4 = New TableLayoutPanel()
        Dgv_KidList = New DataGridView()
        Nombre = New DataGridViewTextBoxColumn()
        Sexo = New DataGridViewTextBoxColumn()
        Años = New DataGridViewTextBoxColumn()
        Direccion = New DataGridViewTextBoxColumn()
        Sangre = New DataGridViewTextBoxColumn()
        Btn_Limpiar = New Button()
        btn_Exit = New Button()
        TableLayoutPanel1.SuspendLayout()
        TableLayoutPanel4.SuspendLayout()
        CType(Dgv_KidList, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.BackColor = Color.Transparent
        TableLayoutPanel1.ColumnCount = 1
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel1.Controls.Add(Label8, 0, 0)
        TableLayoutPanel1.Location = New Point(12, 80)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 1
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 51F))
        TableLayoutPanel1.Size = New Size(762, 50)
        TableLayoutPanel1.TabIndex = 65
        ' 
        ' Label8
        ' 
        Label8.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom
        Label8.AutoSize = True
        Label8.BackColor = Color.Transparent
        Label8.Font = New Font("Baloo", 23.9999981F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label8.ForeColor = Color.White
        Label8.Location = New Point(239, 0)
        Label8.Name = "Label8"
        Label8.Size = New Size(284, 50)
        Label8.TabIndex = 48
        Label8.Text = "Lista de Infantes"
        Label8.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Cb_Gender
        ' 
        Cb_Gender.BackColor = Color.LightSteelBlue
        Cb_Gender.Font = New Font("Baloo", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Cb_Gender.ForeColor = SystemColors.Window
        Cb_Gender.FormattingEnabled = True
        Cb_Gender.Items.AddRange(New Object() {"Masculino", "Femenino"})
        Cb_Gender.Location = New Point(385, 186)
        Cb_Gender.Name = "Cb_Gender"
        Cb_Gender.Size = New Size(138, 29)
        Cb_Gender.TabIndex = 3
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Baloo", 11.999999F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.White
        Label2.Location = New Point(55, 158)
        Label2.Name = "Label2"
        Label2.Size = New Size(75, 25)
        Label2.TabIndex = 69
        Label2.Text = "Nombre:"
        Label2.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Baloo", 11.999999F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = SystemColors.Window
        Label1.Location = New Point(385, 158)
        Label1.Name = "Label1"
        Label1.Size = New Size(51, 25)
        Label1.TabIndex = 71
        Label1.Text = "Sexo:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Baloo", 11.999999F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = SystemColors.Window
        Label3.Location = New Point(302, 158)
        Label3.Name = "Label3"
        Label3.Size = New Size(52, 25)
        Label3.TabIndex = 72
        Label3.Text = "Edad:"
        ' 
        ' Cb_WeeksAge
        ' 
        Cb_WeeksAge.AutoCompleteSource = AutoCompleteSource.ListItems
        Cb_WeeksAge.BackColor = Color.LightSteelBlue
        Cb_WeeksAge.Cursor = Cursors.Hand
        Cb_WeeksAge.DropDownStyle = ComboBoxStyle.DropDownList
        Cb_WeeksAge.Font = New Font("Baloo", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Cb_WeeksAge.ForeColor = SystemColors.Window
        Cb_WeeksAge.FormattingEnabled = True
        Cb_WeeksAge.Location = New Point(302, 186)
        Cb_WeeksAge.Name = "Cb_WeeksAge"
        Cb_WeeksAge.Size = New Size(77, 29)
        Cb_WeeksAge.TabIndex = 73
        ' 
        ' Cb_Name
        ' 
        Cb_Name.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        Cb_Name.AutoCompleteMode = AutoCompleteMode.Suggest
        Cb_Name.AutoCompleteSource = AutoCompleteSource.ListItems
        Cb_Name.BackColor = Color.LightSteelBlue
        Cb_Name.Cursor = Cursors.Hand
        Cb_Name.DrawMode = DrawMode.OwnerDrawVariable
        Cb_Name.Font = New Font("Baloo", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Cb_Name.ForeColor = SystemColors.Window
        Cb_Name.FormattingEnabled = True
        Cb_Name.Location = New Point(55, 186)
        Cb_Name.Name = "Cb_Name"
        Cb_Name.Size = New Size(241, 29)
        Cb_Name.TabIndex = 1
        ' 
        ' Btn_FindKids
        ' 
        Btn_FindKids.Anchor = AnchorStyles.None
        Btn_FindKids.BackColor = Color.SteelBlue
        Btn_FindKids.Cursor = Cursors.Hand
        Btn_FindKids.Font = New Font("Baloo", 11.999999F, FontStyle.Bold)
        Btn_FindKids.ForeColor = Color.White
        Btn_FindKids.Location = New Point(641, 179)
        Btn_FindKids.Name = "Btn_FindKids"
        Btn_FindKids.Size = New Size(90, 40)
        Btn_FindKids.TabIndex = 4
        Btn_FindKids.Text = "Buscar"
        Btn_FindKids.UseVisualStyleBackColor = False
        ' 
        ' TableLayoutPanel4
        ' 
        TableLayoutPanel4.BackColor = Color.LightSkyBlue
        TableLayoutPanel4.ColumnCount = 1
        TableLayoutPanel4.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel4.Controls.Add(Dgv_KidList, 0, 0)
        TableLayoutPanel4.Location = New Point(55, 225)
        TableLayoutPanel4.Name = "TableLayoutPanel4"
        TableLayoutPanel4.RowCount = 1
        TableLayoutPanel4.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel4.Size = New Size(676, 308)
        TableLayoutPanel4.TabIndex = 77
        ' 
        ' Dgv_KidList
        ' 
        Dgv_KidList.AllowUserToAddRows = False
        Dgv_KidList.AllowUserToDeleteRows = False
        Dgv_KidList.BackgroundColor = Color.AliceBlue
        Dgv_KidList.BorderStyle = BorderStyle.Fixed3D
        DataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle7.BackColor = Color.LightSkyBlue
        DataGridViewCellStyle7.Font = New Font("Baloo", 11.249999F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle7.ForeColor = SystemColors.Window
        DataGridViewCellStyle7.SelectionBackColor = Color.LightSkyBlue
        DataGridViewCellStyle7.SelectionForeColor = SystemColors.Window
        Dgv_KidList.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        Dgv_KidList.Columns.AddRange(New DataGridViewColumn() {Nombre, Sexo, Años, Direccion, Sangre})
        DataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = Color.AliceBlue
        DataGridViewCellStyle8.Font = New Font("Baloo", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle8.ForeColor = Color.SkyBlue
        DataGridViewCellStyle8.SelectionBackColor = Color.AliceBlue
        DataGridViewCellStyle8.SelectionForeColor = Color.SkyBlue
        DataGridViewCellStyle8.WrapMode = DataGridViewTriState.False
        Dgv_KidList.DefaultCellStyle = DataGridViewCellStyle8
        Dgv_KidList.EnableHeadersVisualStyles = False
        Dgv_KidList.GridColor = Color.Black
        Dgv_KidList.Location = New Point(3, 3)
        Dgv_KidList.Name = "Dgv_KidList"
        Dgv_KidList.ReadOnly = True
        DataGridViewCellStyle9.BackColor = SystemColors.Control
        DataGridViewCellStyle9.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle9.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle9.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle9.SelectionForeColor = SystemColors.HighlightText
        Dgv_KidList.RowHeadersDefaultCellStyle = DataGridViewCellStyle9
        Dgv_KidList.RowHeadersVisible = False
        Dgv_KidList.ShowEditingIcon = False
        Dgv_KidList.Size = New Size(670, 302)
        Dgv_KidList.TabIndex = 5
        ' 
        ' Nombre
        ' 
        Nombre.AutoSizeMode = DataGridViewAutoSizeColumnMode.None
        Nombre.DataPropertyName = "Nombre"
        Nombre.DividerWidth = 1
        Nombre.Frozen = True
        Nombre.HeaderText = "Nombre"
        Nombre.Name = "Nombre"
        Nombre.ReadOnly = True
        Nombre.Width = 215
        ' 
        ' Sexo
        ' 
        Sexo.AutoSizeMode = DataGridViewAutoSizeColumnMode.None
        Sexo.DataPropertyName = "Sexo"
        Sexo.DividerWidth = 1
        Sexo.Frozen = True
        Sexo.HeaderText = "Sexo"
        Sexo.MaxInputLength = 9
        Sexo.Name = "Sexo"
        Sexo.ReadOnly = True
        Sexo.Width = 77
        ' 
        ' Años
        ' 
        Años.AutoSizeMode = DataGridViewAutoSizeColumnMode.None
        Años.DataPropertyName = "Años"
        Años.DividerWidth = 1
        Años.Frozen = True
        Años.HeaderText = "Años"
        Años.Name = "Años"
        Años.ReadOnly = True
        Años.Width = 118
        ' 
        ' Direccion
        ' 
        Direccion.AutoSizeMode = DataGridViewAutoSizeColumnMode.None
        Direccion.DataPropertyName = "Direccion"
        Direccion.DividerWidth = 1
        Direccion.Frozen = True
        Direccion.HeaderText = "Dirección"
        Direccion.Name = "Direccion"
        Direccion.ReadOnly = True
        Direccion.Width = 175
        ' 
        ' Sangre
        ' 
        Sangre.AutoSizeMode = DataGridViewAutoSizeColumnMode.None
        Sangre.DataPropertyName = "Sangre"
        Sangre.DividerWidth = 1
        Sangre.Frozen = True
        Sangre.HeaderText = "Sangre"
        Sangre.MaxInputLength = 3
        Sangre.Name = "Sangre"
        Sangre.ReadOnly = True
        Sangre.Width = 65
        ' 
        ' Btn_Limpiar
        ' 
        Btn_Limpiar.Anchor = AnchorStyles.None
        Btn_Limpiar.BackColor = Color.SteelBlue
        Btn_Limpiar.Cursor = Cursors.Hand
        Btn_Limpiar.Font = New Font("Baloo", 11.999999F, FontStyle.Bold)
        Btn_Limpiar.ForeColor = Color.White
        Btn_Limpiar.Location = New Point(545, 179)
        Btn_Limpiar.Name = "Btn_Limpiar"
        Btn_Limpiar.Size = New Size(90, 40)
        Btn_Limpiar.TabIndex = 78
        Btn_Limpiar.Text = "Limpiar"
        Btn_Limpiar.UseVisualStyleBackColor = False
        ' 
        ' btn_Exit
        ' 
        btn_Exit.BackgroundImage = My.Resources.Resources.salir
        btn_Exit.BackgroundImageLayout = ImageLayout.Stretch
        btn_Exit.Cursor = Cursors.Hand
        btn_Exit.FlatStyle = FlatStyle.Flat
        btn_Exit.ForeColor = SystemColors.ControlText
        btn_Exit.Location = New Point(12, 678)
        btn_Exit.Name = "btn_Exit"
        btn_Exit.Size = New Size(97, 35)
        btn_Exit.TabIndex = 98
        btn_Exit.UseVisualStyleBackColor = True
        ' 
        ' ScreenList
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.fondo_de_pantalla
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(786, 719)
        Controls.Add(btn_Exit)
        Controls.Add(Btn_Limpiar)
        Controls.Add(Btn_FindKids)
        Controls.Add(Cb_Name)
        Controls.Add(Label2)
        Controls.Add(Cb_WeeksAge)
        Controls.Add(TableLayoutPanel4)
        Controls.Add(Label3)
        Controls.Add(Cb_Gender)
        Controls.Add(Label1)
        Controls.Add(TableLayoutPanel1)
        MaximizeBox = False
        Name = "ScreenList"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Kid Stimulation Register"
        TableLayoutPanel1.ResumeLayout(False)
        TableLayoutPanel1.PerformLayout()
        TableLayoutPanel4.ResumeLayout(False)
        CType(Dgv_KidList, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Label8 As Label
    Friend WithEvents Cb_Gender As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Btn_FindKids As Button
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents Cb_Name As ComboBox
    Friend WithEvents Cb_WeeksAge As ComboBox
    Friend WithEvents Btn_Limpiar As Button
    Friend WithEvents Dgv_KidList As DataGridView
    Friend WithEvents Nombre As DataGridViewTextBoxColumn
    Friend WithEvents Sexo As DataGridViewTextBoxColumn
    Friend WithEvents Años As DataGridViewTextBoxColumn
    Friend WithEvents Direccion As DataGridViewTextBoxColumn
    Friend WithEvents Sangre As DataGridViewTextBoxColumn
    Friend WithEvents btn_Exit As Button
End Class
