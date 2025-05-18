<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class KidEvaluation
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
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As DataGridViewCellStyle = New DataGridViewCellStyle()
        TableLayoutPanel1 = New TableLayoutPanel()
        Label8 = New Label()
        Lbl_Age = New Label()
        Lbl_Allergy = New Label()
        Lbl_BloodType = New Label()
        Btn_Save = New Button()
        Cb_Area = New ComboBox()
        Lbl_Name = New Label()
        Label2 = New Label()
        Tb_Comments = New TextBox()
        Dgv_FineMotor = New DataGridView()
        ID_F = New DataGridViewTextBoxColumn()
        Conducta_F = New DataGridViewTextBoxColumn()
        Indicador_F = New DataGridViewCheckBoxColumn()
        Dgv_Language = New DataGridView()
        ID_L = New DataGridViewTextBoxColumn()
        Conducta_L = New DataGridViewTextBoxColumn()
        Indicador_L = New DataGridViewCheckBoxColumn()
        Dgv_SocialPerson = New DataGridView()
        ID_S = New DataGridViewTextBoxColumn()
        Conducta_S = New DataGridViewTextBoxColumn()
        Indicador_S = New DataGridViewCheckBoxColumn()
        Dgv_GrossMotor = New DataGridView()
        ID_G = New DataGridViewTextBoxColumn()
        Conducta_G = New DataGridViewTextBoxColumn()
        Indicador_G = New DataGridViewCheckBoxColumn()
        Dgv_Adaptative = New DataGridView()
        ID_A = New DataGridViewTextBoxColumn()
        Conducta_A = New DataGridViewTextBoxColumn()
        Indicador_A = New DataGridViewCheckBoxColumn()
        btn_Exit = New Button()
        btn_Clean = New Button()
        TableLayoutPanel1.SuspendLayout()
        CType(Dgv_FineMotor, ComponentModel.ISupportInitialize).BeginInit()
        CType(Dgv_Language, ComponentModel.ISupportInitialize).BeginInit()
        CType(Dgv_SocialPerson, ComponentModel.ISupportInitialize).BeginInit()
        CType(Dgv_GrossMotor, ComponentModel.ISupportInitialize).BeginInit()
        CType(Dgv_Adaptative, ComponentModel.ISupportInitialize).BeginInit()
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
        TableLayoutPanel1.TabIndex = 76
        ' 
        ' Label8
        ' 
        Label8.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom
        Label8.AutoSize = True
        Label8.BackColor = Color.Transparent
        Label8.Font = New Font("Baloo", 23.9999981F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label8.ForeColor = Color.White
        Label8.Location = New Point(119, 0)
        Label8.Name = "Label8"
        Label8.Size = New Size(524, 50)
        Label8.TabIndex = 48
        Label8.Text = "Escala de Desarrollo Psicomotor"
        Label8.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Lbl_Age
        ' 
        Lbl_Age.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom
        Lbl_Age.BackColor = Color.LightSteelBlue
        Lbl_Age.Font = New Font("Baloo", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Lbl_Age.ForeColor = Color.White
        Lbl_Age.Location = New Point(550, 147)
        Lbl_Age.Name = "Lbl_Age"
        Lbl_Age.Size = New Size(181, 34)
        Lbl_Age.TabIndex = 68
        Lbl_Age.Text = "3 AÑOS - 6 MESES"
        Lbl_Age.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Lbl_Allergy
        ' 
        Lbl_Allergy.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom
        Lbl_Allergy.BackColor = Color.LightSteelBlue
        Lbl_Allergy.Font = New Font("Baloo", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Lbl_Allergy.ForeColor = Color.White
        Lbl_Allergy.Location = New Point(456, 189)
        Lbl_Allergy.Name = "Lbl_Allergy"
        Lbl_Allergy.Size = New Size(216, 33)
        Lbl_Allergy.TabIndex = 80
        Lbl_Allergy.Text = "Alergico"
        Lbl_Allergy.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Lbl_BloodType
        ' 
        Lbl_BloodType.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom
        Lbl_BloodType.BackColor = Color.LightSteelBlue
        Lbl_BloodType.Font = New Font("Baloo", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Lbl_BloodType.ForeColor = Color.White
        Lbl_BloodType.Location = New Point(678, 189)
        Lbl_BloodType.Name = "Lbl_BloodType"
        Lbl_BloodType.Size = New Size(53, 33)
        Lbl_BloodType.TabIndex = 81
        Lbl_BloodType.Text = "AB+"
        Lbl_BloodType.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Btn_Save
        ' 
        Btn_Save.BackgroundImage = My.Resources.Resources.guardar
        Btn_Save.BackgroundImageLayout = ImageLayout.Stretch
        Btn_Save.Cursor = Cursors.Hand
        Btn_Save.FlatStyle = FlatStyle.Flat
        Btn_Save.ForeColor = SystemColors.ControlText
        Btn_Save.Location = New Point(677, 678)
        Btn_Save.Name = "Btn_Save"
        Btn_Save.Size = New Size(97, 35)
        Btn_Save.TabIndex = 83
        Btn_Save.UseVisualStyleBackColor = True
        ' 
        ' Cb_Area
        ' 
        Cb_Area.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        Cb_Area.BackColor = Color.LightSteelBlue
        Cb_Area.Cursor = Cursors.Hand
        Cb_Area.DrawMode = DrawMode.OwnerDrawVariable
        Cb_Area.DropDownStyle = ComboBoxStyle.DropDownList
        Cb_Area.Font = New Font("Segoe UI Semibold", 14.25F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Cb_Area.ForeColor = Color.SkyBlue
        Cb_Area.FormattingEnabled = True
        Cb_Area.Items.AddRange(New Object() {"Adaptativa", "Motriz Gruesa", "Motriz Fina", "Lenguaje", "Personal Social"})
        Cb_Area.Location = New Point(61, 148)
        Cb_Area.Name = "Cb_Area"
        Cb_Area.Size = New Size(166, 34)
        Cb_Area.TabIndex = 69
        ' 
        ' Lbl_Name
        ' 
        Lbl_Name.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom
        Lbl_Name.BackColor = Color.LightSteelBlue
        Lbl_Name.Font = New Font("Baloo", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Lbl_Name.ForeColor = Color.White
        Lbl_Name.Location = New Point(233, 148)
        Lbl_Name.Name = "Lbl_Name"
        Lbl_Name.Size = New Size(311, 34)
        Lbl_Name.TabIndex = 88
        Lbl_Name.Text = "Nombre"
        Lbl_Name.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Baloo", 11.999999F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.White
        Label2.Location = New Point(61, 193)
        Label2.Name = "Label2"
        Label2.Size = New Size(126, 25)
        Label2.TabIndex = 90
        Label2.Text = "Observaciones:"
        Label2.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Tb_Comments
        ' 
        Tb_Comments.BackColor = Color.LightSteelBlue
        Tb_Comments.Cursor = Cursors.Hand
        Tb_Comments.Font = New Font("Baloo", 11.999999F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Tb_Comments.ForeColor = Color.WhiteSmoke
        Tb_Comments.Location = New Point(193, 189)
        Tb_Comments.Name = "Tb_Comments"
        Tb_Comments.PlaceholderText = "       ¿Observó algo en el infante?"
        Tb_Comments.Size = New Size(255, 33)
        Tb_Comments.TabIndex = 91
        ' 
        ' Dgv_FineMotor
        ' 
        Dgv_FineMotor.AllowUserToAddRows = False
        Dgv_FineMotor.AllowUserToDeleteRows = False
        Dgv_FineMotor.AllowUserToResizeColumns = False
        Dgv_FineMotor.AllowUserToResizeRows = False
        Dgv_FineMotor.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        Dgv_FineMotor.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        Dgv_FineMotor.BackgroundColor = Color.AliceBlue
        Dgv_FineMotor.BorderStyle = BorderStyle.Fixed3D
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = Color.LightSkyBlue
        DataGridViewCellStyle1.Font = New Font("Baloo", 11.249999F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle1.ForeColor = SystemColors.Window
        DataGridViewCellStyle1.SelectionBackColor = Color.LightSkyBlue
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.Window
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        Dgv_FineMotor.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Dgv_FineMotor.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Dgv_FineMotor.Columns.AddRange(New DataGridViewColumn() {ID_F, Conducta_F, Indicador_F})
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = Color.AliceBlue
        DataGridViewCellStyle2.Font = New Font("Baloo", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle2.ForeColor = Color.SkyBlue
        DataGridViewCellStyle2.SelectionBackColor = Color.AliceBlue
        DataGridViewCellStyle2.SelectionForeColor = Color.SkyBlue
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.False
        Dgv_FineMotor.DefaultCellStyle = DataGridViewCellStyle2
        Dgv_FineMotor.EnableHeadersVisualStyles = False
        Dgv_FineMotor.GridColor = Color.Black
        Dgv_FineMotor.Location = New Point(61, 228)
        Dgv_FineMotor.Name = "Dgv_FineMotor"
        Dgv_FineMotor.RowHeadersVisible = False
        Dgv_FineMotor.ShowEditingIcon = False
        Dgv_FineMotor.Size = New Size(670, 306)
        Dgv_FineMotor.TabIndex = 92
        ' 
        ' ID_F
        ' 
        ID_F.AutoSizeMode = DataGridViewAutoSizeColumnMode.None
        ID_F.DataPropertyName = "ID"
        ID_F.Frozen = True
        ID_F.HeaderText = "ID"
        ID_F.Name = "ID_F"
        ID_F.Resizable = DataGridViewTriState.False
        ID_F.Visible = False
        ID_F.Width = 5
        ' 
        ' Conducta_F
        ' 
        Conducta_F.AutoSizeMode = DataGridViewAutoSizeColumnMode.None
        Conducta_F.DataPropertyName = "Conducta"
        Conducta_F.DividerWidth = 1
        Conducta_F.Frozen = True
        Conducta_F.HeaderText = "Conducta"
        Conducta_F.Name = "Conducta_F"
        Conducta_F.ReadOnly = True
        Conducta_F.Resizable = DataGridViewTriState.False
        Conducta_F.Width = 588
        ' 
        ' Indicador_F
        ' 
        Indicador_F.AutoSizeMode = DataGridViewAutoSizeColumnMode.None
        Indicador_F.DataPropertyName = "Indicador"
        Indicador_F.DividerWidth = 1
        Indicador_F.FalseValue = False
        Indicador_F.Frozen = True
        Indicador_F.HeaderText = "Indicador"
        Indicador_F.Name = "Indicador_F"
        Indicador_F.Resizable = DataGridViewTriState.False
        Indicador_F.TrueValue = True
        Indicador_F.Width = 80
        ' 
        ' Dgv_Language
        ' 
        Dgv_Language.AllowUserToAddRows = False
        Dgv_Language.AllowUserToDeleteRows = False
        Dgv_Language.AllowUserToResizeColumns = False
        Dgv_Language.AllowUserToResizeRows = False
        Dgv_Language.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        Dgv_Language.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        Dgv_Language.BackgroundColor = Color.AliceBlue
        Dgv_Language.BorderStyle = BorderStyle.Fixed3D
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = Color.LightSkyBlue
        DataGridViewCellStyle3.Font = New Font("Baloo", 11.249999F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle3.ForeColor = SystemColors.Window
        DataGridViewCellStyle3.SelectionBackColor = Color.LightSkyBlue
        DataGridViewCellStyle3.SelectionForeColor = SystemColors.Window
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.True
        Dgv_Language.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Dgv_Language.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Dgv_Language.Columns.AddRange(New DataGridViewColumn() {ID_L, Conducta_L, Indicador_L})
        DataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = Color.AliceBlue
        DataGridViewCellStyle4.Font = New Font("Baloo", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle4.ForeColor = Color.SkyBlue
        DataGridViewCellStyle4.SelectionBackColor = Color.AliceBlue
        DataGridViewCellStyle4.SelectionForeColor = Color.SkyBlue
        DataGridViewCellStyle4.WrapMode = DataGridViewTriState.False
        Dgv_Language.DefaultCellStyle = DataGridViewCellStyle4
        Dgv_Language.EnableHeadersVisualStyles = False
        Dgv_Language.GridColor = Color.Black
        Dgv_Language.Location = New Point(61, 228)
        Dgv_Language.Name = "Dgv_Language"
        Dgv_Language.RowHeadersVisible = False
        Dgv_Language.ShowEditingIcon = False
        Dgv_Language.Size = New Size(670, 306)
        Dgv_Language.TabIndex = 93
        ' 
        ' ID_L
        ' 
        ID_L.AutoSizeMode = DataGridViewAutoSizeColumnMode.None
        ID_L.DataPropertyName = "ID"
        ID_L.Frozen = True
        ID_L.HeaderText = "ID"
        ID_L.Name = "ID_L"
        ID_L.Resizable = DataGridViewTriState.False
        ID_L.Visible = False
        ID_L.Width = 5
        ' 
        ' Conducta_L
        ' 
        Conducta_L.AutoSizeMode = DataGridViewAutoSizeColumnMode.None
        Conducta_L.DataPropertyName = "Conducta"
        Conducta_L.DividerWidth = 1
        Conducta_L.Frozen = True
        Conducta_L.HeaderText = "Conducta"
        Conducta_L.Name = "Conducta_L"
        Conducta_L.ReadOnly = True
        Conducta_L.Resizable = DataGridViewTriState.False
        Conducta_L.Width = 588
        ' 
        ' Indicador_L
        ' 
        Indicador_L.AutoSizeMode = DataGridViewAutoSizeColumnMode.None
        Indicador_L.DataPropertyName = "Indicador"
        Indicador_L.DividerWidth = 1
        Indicador_L.FalseValue = False
        Indicador_L.Frozen = True
        Indicador_L.HeaderText = "Indicador"
        Indicador_L.Name = "Indicador_L"
        Indicador_L.Resizable = DataGridViewTriState.False
        Indicador_L.TrueValue = True
        Indicador_L.Width = 80
        ' 
        ' Dgv_SocialPerson
        ' 
        Dgv_SocialPerson.AllowUserToAddRows = False
        Dgv_SocialPerson.AllowUserToDeleteRows = False
        Dgv_SocialPerson.AllowUserToResizeColumns = False
        Dgv_SocialPerson.AllowUserToResizeRows = False
        Dgv_SocialPerson.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        Dgv_SocialPerson.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        Dgv_SocialPerson.BackgroundColor = Color.AliceBlue
        Dgv_SocialPerson.BorderStyle = BorderStyle.Fixed3D
        DataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.BackColor = Color.LightSkyBlue
        DataGridViewCellStyle5.Font = New Font("Baloo", 11.249999F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle5.ForeColor = SystemColors.Window
        DataGridViewCellStyle5.SelectionBackColor = Color.LightSkyBlue
        DataGridViewCellStyle5.SelectionForeColor = SystemColors.Window
        DataGridViewCellStyle5.WrapMode = DataGridViewTriState.True
        Dgv_SocialPerson.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Dgv_SocialPerson.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Dgv_SocialPerson.Columns.AddRange(New DataGridViewColumn() {ID_S, Conducta_S, Indicador_S})
        DataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = Color.AliceBlue
        DataGridViewCellStyle6.Font = New Font("Baloo", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle6.ForeColor = Color.SkyBlue
        DataGridViewCellStyle6.SelectionBackColor = Color.AliceBlue
        DataGridViewCellStyle6.SelectionForeColor = Color.SkyBlue
        DataGridViewCellStyle6.WrapMode = DataGridViewTriState.False
        Dgv_SocialPerson.DefaultCellStyle = DataGridViewCellStyle6
        Dgv_SocialPerson.EnableHeadersVisualStyles = False
        Dgv_SocialPerson.GridColor = Color.Black
        Dgv_SocialPerson.Location = New Point(61, 228)
        Dgv_SocialPerson.Name = "Dgv_SocialPerson"
        Dgv_SocialPerson.RowHeadersVisible = False
        Dgv_SocialPerson.ShowEditingIcon = False
        Dgv_SocialPerson.Size = New Size(670, 306)
        Dgv_SocialPerson.TabIndex = 94
        ' 
        ' ID_S
        ' 
        ID_S.AutoSizeMode = DataGridViewAutoSizeColumnMode.None
        ID_S.DataPropertyName = "ID"
        ID_S.Frozen = True
        ID_S.HeaderText = "ID"
        ID_S.Name = "ID_S"
        ID_S.Resizable = DataGridViewTriState.False
        ID_S.Visible = False
        ID_S.Width = 5
        ' 
        ' Conducta_S
        ' 
        Conducta_S.AutoSizeMode = DataGridViewAutoSizeColumnMode.None
        Conducta_S.DataPropertyName = "Conducta"
        Conducta_S.DividerWidth = 1
        Conducta_S.Frozen = True
        Conducta_S.HeaderText = "Conducta"
        Conducta_S.Name = "Conducta_S"
        Conducta_S.ReadOnly = True
        Conducta_S.Resizable = DataGridViewTriState.False
        Conducta_S.Width = 588
        ' 
        ' Indicador_S
        ' 
        Indicador_S.AutoSizeMode = DataGridViewAutoSizeColumnMode.None
        Indicador_S.DataPropertyName = "Indicador"
        Indicador_S.DividerWidth = 1
        Indicador_S.FalseValue = False
        Indicador_S.Frozen = True
        Indicador_S.HeaderText = "Indicador"
        Indicador_S.Name = "Indicador_S"
        Indicador_S.Resizable = DataGridViewTriState.False
        Indicador_S.TrueValue = True
        Indicador_S.Width = 80
        ' 
        ' Dgv_GrossMotor
        ' 
        Dgv_GrossMotor.AllowUserToAddRows = False
        Dgv_GrossMotor.AllowUserToDeleteRows = False
        Dgv_GrossMotor.AllowUserToResizeColumns = False
        Dgv_GrossMotor.AllowUserToResizeRows = False
        Dgv_GrossMotor.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        Dgv_GrossMotor.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        Dgv_GrossMotor.BackgroundColor = Color.AliceBlue
        Dgv_GrossMotor.BorderStyle = BorderStyle.Fixed3D
        DataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle7.BackColor = Color.LightSkyBlue
        DataGridViewCellStyle7.Font = New Font("Baloo", 11.249999F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle7.ForeColor = SystemColors.Window
        DataGridViewCellStyle7.SelectionBackColor = Color.LightSkyBlue
        DataGridViewCellStyle7.SelectionForeColor = SystemColors.Window
        DataGridViewCellStyle7.WrapMode = DataGridViewTriState.True
        Dgv_GrossMotor.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        Dgv_GrossMotor.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Dgv_GrossMotor.Columns.AddRange(New DataGridViewColumn() {ID_G, Conducta_G, Indicador_G})
        DataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = Color.AliceBlue
        DataGridViewCellStyle8.Font = New Font("Baloo", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle8.ForeColor = Color.SkyBlue
        DataGridViewCellStyle8.SelectionBackColor = Color.AliceBlue
        DataGridViewCellStyle8.SelectionForeColor = Color.SkyBlue
        DataGridViewCellStyle8.WrapMode = DataGridViewTriState.False
        Dgv_GrossMotor.DefaultCellStyle = DataGridViewCellStyle8
        Dgv_GrossMotor.EnableHeadersVisualStyles = False
        Dgv_GrossMotor.GridColor = Color.Black
        Dgv_GrossMotor.Location = New Point(61, 228)
        Dgv_GrossMotor.Name = "Dgv_GrossMotor"
        Dgv_GrossMotor.RowHeadersVisible = False
        Dgv_GrossMotor.ShowEditingIcon = False
        Dgv_GrossMotor.Size = New Size(670, 306)
        Dgv_GrossMotor.TabIndex = 95
        ' 
        ' ID_G
        ' 
        ID_G.AutoSizeMode = DataGridViewAutoSizeColumnMode.None
        ID_G.DataPropertyName = "ID"
        ID_G.Frozen = True
        ID_G.HeaderText = "ID"
        ID_G.Name = "ID_G"
        ID_G.Resizable = DataGridViewTriState.False
        ID_G.Visible = False
        ID_G.Width = 5
        ' 
        ' Conducta_G
        ' 
        Conducta_G.AutoSizeMode = DataGridViewAutoSizeColumnMode.None
        Conducta_G.DataPropertyName = "Conducta"
        Conducta_G.DividerWidth = 1
        Conducta_G.Frozen = True
        Conducta_G.HeaderText = "Conducta"
        Conducta_G.Name = "Conducta_G"
        Conducta_G.ReadOnly = True
        Conducta_G.Resizable = DataGridViewTriState.False
        Conducta_G.Width = 588
        ' 
        ' Indicador_G
        ' 
        Indicador_G.AutoSizeMode = DataGridViewAutoSizeColumnMode.None
        Indicador_G.DataPropertyName = "Indicador"
        Indicador_G.DividerWidth = 1
        Indicador_G.FalseValue = False
        Indicador_G.Frozen = True
        Indicador_G.HeaderText = "Indicador"
        Indicador_G.Name = "Indicador_G"
        Indicador_G.Resizable = DataGridViewTriState.False
        Indicador_G.TrueValue = True
        Indicador_G.Width = 80
        ' 
        ' Dgv_Adaptative
        ' 
        Dgv_Adaptative.AllowUserToAddRows = False
        Dgv_Adaptative.AllowUserToDeleteRows = False
        Dgv_Adaptative.AllowUserToResizeColumns = False
        Dgv_Adaptative.AllowUserToResizeRows = False
        Dgv_Adaptative.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        Dgv_Adaptative.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        Dgv_Adaptative.BackgroundColor = Color.AliceBlue
        Dgv_Adaptative.BorderStyle = BorderStyle.Fixed3D
        DataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle9.BackColor = Color.LightSkyBlue
        DataGridViewCellStyle9.Font = New Font("Baloo", 11.249999F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle9.ForeColor = SystemColors.Window
        DataGridViewCellStyle9.SelectionBackColor = Color.LightSkyBlue
        DataGridViewCellStyle9.SelectionForeColor = SystemColors.Window
        DataGridViewCellStyle9.WrapMode = DataGridViewTriState.True
        Dgv_Adaptative.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle9
        Dgv_Adaptative.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Dgv_Adaptative.Columns.AddRange(New DataGridViewColumn() {ID_A, Conducta_A, Indicador_A})
        DataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle10.BackColor = Color.AliceBlue
        DataGridViewCellStyle10.Font = New Font("Baloo", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle10.ForeColor = Color.SkyBlue
        DataGridViewCellStyle10.SelectionBackColor = Color.AliceBlue
        DataGridViewCellStyle10.SelectionForeColor = Color.SkyBlue
        DataGridViewCellStyle10.WrapMode = DataGridViewTriState.False
        Dgv_Adaptative.DefaultCellStyle = DataGridViewCellStyle10
        Dgv_Adaptative.EnableHeadersVisualStyles = False
        Dgv_Adaptative.GridColor = Color.Black
        Dgv_Adaptative.Location = New Point(61, 228)
        Dgv_Adaptative.Name = "Dgv_Adaptative"
        Dgv_Adaptative.RowHeadersVisible = False
        Dgv_Adaptative.ShowEditingIcon = False
        Dgv_Adaptative.Size = New Size(670, 306)
        Dgv_Adaptative.TabIndex = 96
        ' 
        ' ID_A
        ' 
        ID_A.AutoSizeMode = DataGridViewAutoSizeColumnMode.None
        ID_A.DataPropertyName = "ID"
        ID_A.Frozen = True
        ID_A.HeaderText = "ID"
        ID_A.Name = "ID_A"
        ID_A.Resizable = DataGridViewTriState.False
        ID_A.Visible = False
        ID_A.Width = 5
        ' 
        ' Conducta_A
        ' 
        Conducta_A.AutoSizeMode = DataGridViewAutoSizeColumnMode.None
        Conducta_A.DataPropertyName = "Conducta"
        Conducta_A.DividerWidth = 1
        Conducta_A.Frozen = True
        Conducta_A.HeaderText = "Conducta"
        Conducta_A.Name = "Conducta_A"
        Conducta_A.ReadOnly = True
        Conducta_A.Resizable = DataGridViewTriState.False
        Conducta_A.Width = 588
        ' 
        ' Indicador_A
        ' 
        Indicador_A.AutoSizeMode = DataGridViewAutoSizeColumnMode.None
        Indicador_A.DataPropertyName = "Indicador"
        Indicador_A.DividerWidth = 1
        Indicador_A.FalseValue = False
        Indicador_A.Frozen = True
        Indicador_A.HeaderText = "Indicador"
        Indicador_A.Name = "Indicador_A"
        Indicador_A.Resizable = DataGridViewTriState.False
        Indicador_A.TrueValue = True
        Indicador_A.Width = 80
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
        btn_Exit.TabIndex = 97
        btn_Exit.UseVisualStyleBackColor = True
        ' 
        ' btn_Clean
        ' 
        btn_Clean.BackgroundImage = My.Resources.Resources.limpiar
        btn_Clean.BackgroundImageLayout = ImageLayout.Stretch
        btn_Clean.Cursor = Cursors.Hand
        btn_Clean.FlatStyle = FlatStyle.Flat
        btn_Clean.ForeColor = SystemColors.ControlText
        btn_Clean.Location = New Point(574, 678)
        btn_Clean.Name = "btn_Clean"
        btn_Clean.Size = New Size(97, 35)
        btn_Clean.TabIndex = 98
        btn_Clean.UseVisualStyleBackColor = True
        ' 
        ' KidEvaluation
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.fondo_de_pantalla
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(786, 719)
        Controls.Add(btn_Clean)
        Controls.Add(btn_Exit)
        Controls.Add(Dgv_Adaptative)
        Controls.Add(Tb_Comments)
        Controls.Add(Label2)
        Controls.Add(Lbl_Name)
        Controls.Add(Btn_Save)
        Controls.Add(Lbl_BloodType)
        Controls.Add(Lbl_Allergy)
        Controls.Add(TableLayoutPanel1)
        Controls.Add(Cb_Area)
        Controls.Add(Lbl_Age)
        Controls.Add(Dgv_GrossMotor)
        Controls.Add(Dgv_SocialPerson)
        Controls.Add(Dgv_Language)
        Controls.Add(Dgv_FineMotor)
        MaximizeBox = False
        Name = "KidEvaluation"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Kid Stimulation Register"
        TableLayoutPanel1.ResumeLayout(False)
        TableLayoutPanel1.PerformLayout()
        CType(Dgv_FineMotor, ComponentModel.ISupportInitialize).EndInit()
        CType(Dgv_Language, ComponentModel.ISupportInitialize).EndInit()
        CType(Dgv_SocialPerson, ComponentModel.ISupportInitialize).EndInit()
        CType(Dgv_GrossMotor, ComponentModel.ISupportInitialize).EndInit()
        CType(Dgv_Adaptative, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Label8 As Label
    Friend WithEvents Lbl_Age As Label
    Friend WithEvents Lbl_Allergy As Label
    Friend WithEvents Lbl_BloodType As Label
    Friend WithEvents Btn_Save As Button
    Friend WithEvents Cb_Area As ComboBox
    Friend WithEvents Lbl_Name As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Tb_Comments As TextBox
    Friend WithEvents Dgv_FineMotor As DataGridView
    Friend WithEvents Dgv_Language As DataGridView
    Friend WithEvents Dgv_SocialPerson As DataGridView
    Friend WithEvents Dgv_GrossMotor As DataGridView
    Friend WithEvents Dgv_Adaptative As DataGridView
    Friend WithEvents ID_A As DataGridViewTextBoxColumn
    Friend WithEvents Conducta_A As DataGridViewTextBoxColumn
    Friend WithEvents Indicador_A As DataGridViewCheckBoxColumn
    Friend WithEvents ID_G As DataGridViewTextBoxColumn
    Friend WithEvents Conducta_G As DataGridViewTextBoxColumn
    Friend WithEvents Indicador_G As DataGridViewCheckBoxColumn
    Friend WithEvents ID_L As DataGridViewTextBoxColumn
    Friend WithEvents Conducta_L As DataGridViewTextBoxColumn
    Friend WithEvents Indicador_L As DataGridViewCheckBoxColumn
    Friend WithEvents ID_S As DataGridViewTextBoxColumn
    Friend WithEvents Conducta_S As DataGridViewTextBoxColumn
    Friend WithEvents Indicador_S As DataGridViewCheckBoxColumn
    Friend WithEvents ID_F As DataGridViewTextBoxColumn
    Friend WithEvents Conducta_F As DataGridViewTextBoxColumn
    Friend WithEvents Indicador_F As DataGridViewCheckBoxColumn
    Friend WithEvents btn_Exit As Button
    Friend WithEvents btn_Clean As Button
End Class
