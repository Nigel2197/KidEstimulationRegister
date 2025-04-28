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
        Dim DataGridViewCellStyle11 As DataGridViewCellStyle = New DataGridViewCellStyle()
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
        Tb_Name = New TextBox()
        Dgv_FineMotor = New DataGridView()
        DataGridViewTextBoxColumn1 = New DataGridViewTextBoxColumn()
        DataGridViewTextBoxColumn2 = New DataGridViewTextBoxColumn()
        DataGridViewCheckBoxColumn1 = New DataGridViewCheckBoxColumn()
        Dgv_Language = New DataGridView()
        DataGridViewTextBoxColumn3 = New DataGridViewTextBoxColumn()
        DataGridViewTextBoxColumn4 = New DataGridViewTextBoxColumn()
        DataGridViewCheckBoxColumn2 = New DataGridViewCheckBoxColumn()
        Dgv_SocialPerson = New DataGridView()
        DataGridViewTextBoxColumn5 = New DataGridViewTextBoxColumn()
        DataGridViewTextBoxColumn6 = New DataGridViewTextBoxColumn()
        DataGridViewCheckBoxColumn3 = New DataGridViewCheckBoxColumn()
        Dgv_GrossMotor = New DataGridView()
        DataGridViewTextBoxColumn7 = New DataGridViewTextBoxColumn()
        DataGridViewTextBoxColumn8 = New DataGridViewTextBoxColumn()
        DataGridViewCheckBoxColumn4 = New DataGridViewCheckBoxColumn()
        Dgv_Adaptative = New DataGridView()
        ID_A = New DataGridViewTextBoxColumn()
        Conducta_A = New DataGridViewTextBoxColumn()
        Indicador_A = New DataGridViewCheckBoxColumn()
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
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50.0F))
        TableLayoutPanel1.Controls.Add(Label8, 0, 0)
        TableLayoutPanel1.Location = New Point(12, 80)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 1
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 51.0F))
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
        Btn_Save.Location = New Point(683, 678)
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
        ' Tb_Name
        ' 
        Tb_Name.BackColor = Color.LightSteelBlue
        Tb_Name.Cursor = Cursors.Hand
        Tb_Name.Font = New Font("Baloo", 11.999999F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Tb_Name.ForeColor = Color.WhiteSmoke
        Tb_Name.Location = New Point(193, 189)
        Tb_Name.Name = "Tb_Name"
        Tb_Name.PlaceholderText = "       ¿Observó algo en el infante?"
        Tb_Name.Size = New Size(255, 33)
        Tb_Name.TabIndex = 91
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
        Dgv_FineMotor.Columns.AddRange(New DataGridViewColumn() {DataGridViewTextBoxColumn1, DataGridViewTextBoxColumn2, DataGridViewCheckBoxColumn1})
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
        ' DataGridViewTextBoxColumn1
        ' 
        DataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.None
        DataGridViewTextBoxColumn1.DataPropertyName = "ID"
        DataGridViewTextBoxColumn1.Frozen = True
        DataGridViewTextBoxColumn1.HeaderText = "ID"
        DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        DataGridViewTextBoxColumn1.Resizable = DataGridViewTriState.False
        DataGridViewTextBoxColumn1.Visible = False
        DataGridViewTextBoxColumn1.Width = 5
        ' 
        ' DataGridViewTextBoxColumn2
        ' 
        DataGridViewTextBoxColumn2.AutoSizeMode = DataGridViewAutoSizeColumnMode.None
        DataGridViewTextBoxColumn2.DataPropertyName = "Conducta"
        DataGridViewTextBoxColumn2.DividerWidth = 1
        DataGridViewTextBoxColumn2.Frozen = True
        DataGridViewTextBoxColumn2.HeaderText = "Conducta"
        DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        DataGridViewTextBoxColumn2.ReadOnly = True
        DataGridViewTextBoxColumn2.Resizable = DataGridViewTriState.False
        DataGridViewTextBoxColumn2.Width = 588
        ' 
        ' DataGridViewCheckBoxColumn1
        ' 
        DataGridViewCheckBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.None
        DataGridViewCheckBoxColumn1.DataPropertyName = "Indicador"
        DataGridViewCheckBoxColumn1.DividerWidth = 1
        DataGridViewCheckBoxColumn1.Frozen = True
        DataGridViewCheckBoxColumn1.HeaderText = "Indicador"
        DataGridViewCheckBoxColumn1.Name = "DataGridViewCheckBoxColumn1"
        DataGridViewCheckBoxColumn1.Resizable = DataGridViewTriState.False
        DataGridViewCheckBoxColumn1.Width = 80
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
        Dgv_Language.Columns.AddRange(New DataGridViewColumn() {DataGridViewTextBoxColumn3, DataGridViewTextBoxColumn4, DataGridViewCheckBoxColumn2})
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
        ' DataGridViewTextBoxColumn3
        ' 
        DataGridViewTextBoxColumn3.AutoSizeMode = DataGridViewAutoSizeColumnMode.None
        DataGridViewTextBoxColumn3.DataPropertyName = "ID"
        DataGridViewTextBoxColumn3.Frozen = True
        DataGridViewTextBoxColumn3.HeaderText = "ID"
        DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        DataGridViewTextBoxColumn3.Resizable = DataGridViewTriState.False
        DataGridViewTextBoxColumn3.Visible = False
        DataGridViewTextBoxColumn3.Width = 5
        ' 
        ' DataGridViewTextBoxColumn4
        ' 
        DataGridViewTextBoxColumn4.AutoSizeMode = DataGridViewAutoSizeColumnMode.None
        DataGridViewTextBoxColumn4.DataPropertyName = "Conducta"
        DataGridViewTextBoxColumn4.DividerWidth = 1
        DataGridViewTextBoxColumn4.Frozen = True
        DataGridViewTextBoxColumn4.HeaderText = "Conducta"
        DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        DataGridViewTextBoxColumn4.ReadOnly = True
        DataGridViewTextBoxColumn4.Resizable = DataGridViewTriState.False
        DataGridViewTextBoxColumn4.Width = 588
        ' 
        ' DataGridViewCheckBoxColumn2
        ' 
        DataGridViewCheckBoxColumn2.AutoSizeMode = DataGridViewAutoSizeColumnMode.None
        DataGridViewCheckBoxColumn2.DataPropertyName = "Indicador"
        DataGridViewCheckBoxColumn2.DividerWidth = 1
        DataGridViewCheckBoxColumn2.Frozen = True
        DataGridViewCheckBoxColumn2.HeaderText = "Indicador"
        DataGridViewCheckBoxColumn2.Name = "DataGridViewCheckBoxColumn2"
        DataGridViewCheckBoxColumn2.Resizable = DataGridViewTriState.False
        DataGridViewCheckBoxColumn2.Width = 80
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
        Dgv_SocialPerson.Columns.AddRange(New DataGridViewColumn() {DataGridViewTextBoxColumn5, DataGridViewTextBoxColumn6, DataGridViewCheckBoxColumn3})
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
        ' DataGridViewTextBoxColumn5
        ' 
        DataGridViewTextBoxColumn5.AutoSizeMode = DataGridViewAutoSizeColumnMode.None
        DataGridViewTextBoxColumn5.DataPropertyName = "ID"
        DataGridViewTextBoxColumn5.Frozen = True
        DataGridViewTextBoxColumn5.HeaderText = "ID"
        DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        DataGridViewTextBoxColumn5.Resizable = DataGridViewTriState.False
        DataGridViewTextBoxColumn5.Visible = False
        DataGridViewTextBoxColumn5.Width = 5
        ' 
        ' DataGridViewTextBoxColumn6
        ' 
        DataGridViewTextBoxColumn6.AutoSizeMode = DataGridViewAutoSizeColumnMode.None
        DataGridViewTextBoxColumn6.DataPropertyName = "Conducta"
        DataGridViewTextBoxColumn6.DividerWidth = 1
        DataGridViewTextBoxColumn6.Frozen = True
        DataGridViewTextBoxColumn6.HeaderText = "Conducta"
        DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        DataGridViewTextBoxColumn6.ReadOnly = True
        DataGridViewTextBoxColumn6.Resizable = DataGridViewTriState.False
        DataGridViewTextBoxColumn6.Width = 588
        ' 
        ' DataGridViewCheckBoxColumn3
        ' 
        DataGridViewCheckBoxColumn3.AutoSizeMode = DataGridViewAutoSizeColumnMode.None
        DataGridViewCheckBoxColumn3.DataPropertyName = "Indicador"
        DataGridViewCheckBoxColumn3.DividerWidth = 1
        DataGridViewCheckBoxColumn3.Frozen = True
        DataGridViewCheckBoxColumn3.HeaderText = "Indicador"
        DataGridViewCheckBoxColumn3.Name = "DataGridViewCheckBoxColumn3"
        DataGridViewCheckBoxColumn3.Resizable = DataGridViewTriState.False
        DataGridViewCheckBoxColumn3.Width = 80
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
        Dgv_GrossMotor.Columns.AddRange(New DataGridViewColumn() {DataGridViewTextBoxColumn7, DataGridViewTextBoxColumn8, DataGridViewCheckBoxColumn4})
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
        ' DataGridViewTextBoxColumn7
        ' 
        DataGridViewTextBoxColumn7.AutoSizeMode = DataGridViewAutoSizeColumnMode.None
        DataGridViewTextBoxColumn7.DataPropertyName = "ID"
        DataGridViewTextBoxColumn7.Frozen = True
        DataGridViewTextBoxColumn7.HeaderText = "ID"
        DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        DataGridViewTextBoxColumn7.Resizable = DataGridViewTriState.False
        DataGridViewTextBoxColumn7.Visible = False
        DataGridViewTextBoxColumn7.Width = 5
        ' 
        ' DataGridViewTextBoxColumn8
        ' 
        DataGridViewTextBoxColumn8.AutoSizeMode = DataGridViewAutoSizeColumnMode.None
        DataGridViewTextBoxColumn8.DataPropertyName = "Conducta"
        DataGridViewTextBoxColumn8.DividerWidth = 1
        DataGridViewTextBoxColumn8.Frozen = True
        DataGridViewTextBoxColumn8.HeaderText = "Conducta"
        DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        DataGridViewTextBoxColumn8.ReadOnly = True
        DataGridViewTextBoxColumn8.Resizable = DataGridViewTriState.False
        DataGridViewTextBoxColumn8.Width = 588
        ' 
        ' DataGridViewCheckBoxColumn4
        ' 
        DataGridViewCheckBoxColumn4.AutoSizeMode = DataGridViewAutoSizeColumnMode.None
        DataGridViewCheckBoxColumn4.DataPropertyName = "Indicador"
        DataGridViewCheckBoxColumn4.DividerWidth = 1
        DataGridViewCheckBoxColumn4.Frozen = True
        DataGridViewCheckBoxColumn4.HeaderText = "Indicador"
        DataGridViewCheckBoxColumn4.Name = "DataGridViewCheckBoxColumn4"
        DataGridViewCheckBoxColumn4.Resizable = DataGridViewTriState.False
        DataGridViewCheckBoxColumn4.Width = 80
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
        DataGridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle11.BackColor = Color.AliceBlue
        DataGridViewCellStyle11.Font = New Font("Baloo", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle11.ForeColor = Color.SkyBlue
        DataGridViewCellStyle11.SelectionBackColor = Color.AliceBlue
        DataGridViewCellStyle11.SelectionForeColor = Color.SkyBlue
        DataGridViewCellStyle11.WrapMode = DataGridViewTriState.False
        Dgv_Adaptative.DefaultCellStyle = DataGridViewCellStyle11
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
        DataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle10.NullValue = False
        Indicador_A.DefaultCellStyle = DataGridViewCellStyle10
        Indicador_A.DividerWidth = 1
        Indicador_A.FalseValue = False
        Indicador_A.Frozen = True
        Indicador_A.HeaderText = "Indicador"
        Indicador_A.Name = "Indicador_A"
        Indicador_A.Resizable = DataGridViewTriState.False
        Indicador_A.TrueValue = True
        Indicador_A.Width = 80
        ' 
        ' KidEvaluation
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.fondo_de_pantalla
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(786, 719)
        Controls.Add(Dgv_Adaptative)
        Controls.Add(Tb_Name)
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
    Friend WithEvents Tb_Name As TextBox
    Friend WithEvents Dgv_FineMotor As DataGridView
    Friend WithEvents Dgv_Language As DataGridView
    Friend WithEvents Dgv_SocialPerson As DataGridView
    Friend WithEvents Dgv_GrossMotor As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn1 As DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn2 As DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn3 As DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn4 As DataGridViewCheckBoxColumn
    Friend WithEvents Dgv_Adaptative As DataGridView
    Friend WithEvents ID_A As DataGridViewTextBoxColumn
    Friend WithEvents Conducta_A As DataGridViewTextBoxColumn
    Friend WithEvents Indicador_A As DataGridViewCheckBoxColumn
End Class
