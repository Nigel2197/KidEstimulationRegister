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
        Lbl_Name = New Label()
        Lbl_Allergy = New Label()
        Lbl_BloodType = New Label()
        Dgv_Adaptative = New DataGridView()
        Btn_Save = New Button()
        Dgv_GrossMotor = New DataGridView()
        Dgv_FineMotor = New DataGridView()
        Dgv_Language = New DataGridView()
        Dgv_SocialPerson = New DataGridView()
        Cb_Area = New ComboBox()
        ID = New DataGridViewTextBoxColumn()
        Conducta = New DataGridViewTextBoxColumn()
        Indicador = New DataGridViewCheckBoxColumn()
        TableLayoutPanel1.SuspendLayout()
        CType(Dgv_Adaptative, ComponentModel.ISupportInitialize).BeginInit()
        CType(Dgv_GrossMotor, ComponentModel.ISupportInitialize).BeginInit()
        CType(Dgv_FineMotor, ComponentModel.ISupportInitialize).BeginInit()
        CType(Dgv_Language, ComponentModel.ISupportInitialize).BeginInit()
        CType(Dgv_SocialPerson, ComponentModel.ISupportInitialize).BeginInit()
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
        Lbl_Age.BackColor = Color.AliceBlue
        Lbl_Age.Font = New Font("Baloo", 15.7499981F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Lbl_Age.ForeColor = Color.SkyBlue
        Lbl_Age.Location = New Point(413, 201)
        Lbl_Age.Name = "Lbl_Age"
        Lbl_Age.Size = New Size(318, 34)
        Lbl_Age.TabIndex = 68
        Lbl_Age.Text = "3 AÑOS - 6 MESES"
        Lbl_Age.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Lbl_Name
        ' 
        Lbl_Name.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom
        Lbl_Name.BackColor = Color.AliceBlue
        Lbl_Name.Font = New Font("Baloo", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Lbl_Name.ForeColor = Color.SkyBlue
        Lbl_Name.Location = New Point(61, 157)
        Lbl_Name.Name = "Lbl_Name"
        Lbl_Name.Size = New Size(346, 37)
        Lbl_Name.TabIndex = 79
        Lbl_Name.Text = "Nombre"
        Lbl_Name.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Lbl_Allergy
        ' 
        Lbl_Allergy.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom
        Lbl_Allergy.BackColor = Color.AliceBlue
        Lbl_Allergy.Font = New Font("Baloo", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Lbl_Allergy.ForeColor = Color.SkyBlue
        Lbl_Allergy.Location = New Point(413, 157)
        Lbl_Allergy.Name = "Lbl_Allergy"
        Lbl_Allergy.Size = New Size(259, 37)
        Lbl_Allergy.TabIndex = 80
        Lbl_Allergy.Text = "Alergico"
        Lbl_Allergy.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Lbl_BloodType
        ' 
        Lbl_BloodType.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom
        Lbl_BloodType.BackColor = Color.AliceBlue
        Lbl_BloodType.Font = New Font("Baloo", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Lbl_BloodType.ForeColor = Color.SkyBlue
        Lbl_BloodType.Location = New Point(678, 157)
        Lbl_BloodType.Name = "Lbl_BloodType"
        Lbl_BloodType.Size = New Size(53, 37)
        Lbl_BloodType.TabIndex = 81
        Lbl_BloodType.Text = "A+"
        Lbl_BloodType.TextAlign = ContentAlignment.MiddleCenter
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
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = Color.LightSkyBlue
        DataGridViewCellStyle1.Font = New Font("Baloo", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle1.ForeColor = SystemColors.Window
        DataGridViewCellStyle1.SelectionBackColor = Color.LightSkyBlue
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.Window
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        Dgv_Adaptative.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Dgv_Adaptative.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Dgv_Adaptative.Columns.AddRange(New DataGridViewColumn() {ID, Conducta, Indicador})
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = SystemColors.Window
        DataGridViewCellStyle2.Font = New Font("Baloo", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle2.ForeColor = SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.False
        Dgv_Adaptative.DefaultCellStyle = DataGridViewCellStyle2
        Dgv_Adaptative.EnableHeadersVisualStyles = False
        Dgv_Adaptative.GridColor = Color.Black
        Dgv_Adaptative.Location = New Point(61, 241)
        Dgv_Adaptative.Name = "Dgv_Adaptative"
        Dgv_Adaptative.RowHeadersVisible = False
        Dgv_Adaptative.ShowEditingIcon = False
        Dgv_Adaptative.Size = New Size(670, 300)
        Dgv_Adaptative.TabIndex = 82
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
        ' Dgv_GrossMotor
        ' 
        Dgv_GrossMotor.AllowUserToAddRows = False
        Dgv_GrossMotor.AllowUserToDeleteRows = False
        Dgv_GrossMotor.AllowUserToOrderColumns = True
        Dgv_GrossMotor.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        Dgv_GrossMotor.BackgroundColor = Color.SlateGray
        Dgv_GrossMotor.BorderStyle = BorderStyle.Fixed3D
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = Color.LightSkyBlue
        DataGridViewCellStyle3.Font = New Font("Baloo", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle3.ForeColor = SystemColors.Window
        DataGridViewCellStyle3.SelectionBackColor = Color.LightSkyBlue
        DataGridViewCellStyle3.SelectionForeColor = SystemColors.Window
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.True
        Dgv_GrossMotor.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Dgv_GrossMotor.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = SystemColors.Window
        DataGridViewCellStyle4.Font = New Font("Baloo", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle4.ForeColor = SystemColors.ControlText
        DataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = DataGridViewTriState.False
        Dgv_GrossMotor.DefaultCellStyle = DataGridViewCellStyle4
        Dgv_GrossMotor.EnableHeadersVisualStyles = False
        Dgv_GrossMotor.GridColor = Color.Black
        Dgv_GrossMotor.Location = New Point(95, 241)
        Dgv_GrossMotor.Name = "Dgv_GrossMotor"
        Dgv_GrossMotor.RowHeadersVisible = False
        Dgv_GrossMotor.ShowEditingIcon = False
        Dgv_GrossMotor.Size = New Size(600, 300)
        Dgv_GrossMotor.TabIndex = 84
        ' 
        ' Dgv_FineMotor
        ' 
        Dgv_FineMotor.AllowUserToAddRows = False
        Dgv_FineMotor.AllowUserToDeleteRows = False
        Dgv_FineMotor.AllowUserToOrderColumns = True
        Dgv_FineMotor.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        Dgv_FineMotor.BackgroundColor = Color.SlateGray
        Dgv_FineMotor.BorderStyle = BorderStyle.Fixed3D
        DataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.BackColor = Color.LightSkyBlue
        DataGridViewCellStyle5.Font = New Font("Baloo", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle5.ForeColor = SystemColors.Window
        DataGridViewCellStyle5.SelectionBackColor = Color.LightSkyBlue
        DataGridViewCellStyle5.SelectionForeColor = SystemColors.Window
        DataGridViewCellStyle5.WrapMode = DataGridViewTriState.True
        Dgv_FineMotor.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Dgv_FineMotor.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = SystemColors.Window
        DataGridViewCellStyle6.Font = New Font("Baloo", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle6.ForeColor = SystemColors.ControlText
        DataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = DataGridViewTriState.False
        Dgv_FineMotor.DefaultCellStyle = DataGridViewCellStyle6
        Dgv_FineMotor.EnableHeadersVisualStyles = False
        Dgv_FineMotor.GridColor = Color.Black
        Dgv_FineMotor.Location = New Point(95, 241)
        Dgv_FineMotor.Name = "Dgv_FineMotor"
        Dgv_FineMotor.RowHeadersVisible = False
        Dgv_FineMotor.ShowEditingIcon = False
        Dgv_FineMotor.Size = New Size(600, 300)
        Dgv_FineMotor.TabIndex = 85
        ' 
        ' Dgv_Language
        ' 
        Dgv_Language.AllowUserToAddRows = False
        Dgv_Language.AllowUserToDeleteRows = False
        Dgv_Language.AllowUserToOrderColumns = True
        Dgv_Language.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        Dgv_Language.BackgroundColor = Color.SlateGray
        Dgv_Language.BorderStyle = BorderStyle.Fixed3D
        DataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle7.BackColor = Color.LightSkyBlue
        DataGridViewCellStyle7.Font = New Font("Baloo", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle7.ForeColor = SystemColors.Window
        DataGridViewCellStyle7.SelectionBackColor = Color.LightSkyBlue
        DataGridViewCellStyle7.SelectionForeColor = SystemColors.Window
        DataGridViewCellStyle7.WrapMode = DataGridViewTriState.True
        Dgv_Language.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        Dgv_Language.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = SystemColors.Window
        DataGridViewCellStyle8.Font = New Font("Baloo", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle8.ForeColor = SystemColors.ControlText
        DataGridViewCellStyle8.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = DataGridViewTriState.False
        Dgv_Language.DefaultCellStyle = DataGridViewCellStyle8
        Dgv_Language.EnableHeadersVisualStyles = False
        Dgv_Language.GridColor = Color.Black
        Dgv_Language.Location = New Point(95, 241)
        Dgv_Language.Name = "Dgv_Language"
        Dgv_Language.RowHeadersVisible = False
        Dgv_Language.ShowEditingIcon = False
        Dgv_Language.Size = New Size(600, 300)
        Dgv_Language.TabIndex = 86
        ' 
        ' Dgv_SocialPerson
        ' 
        Dgv_SocialPerson.AllowUserToAddRows = False
        Dgv_SocialPerson.AllowUserToDeleteRows = False
        Dgv_SocialPerson.AllowUserToOrderColumns = True
        Dgv_SocialPerson.AllowUserToResizeColumns = False
        Dgv_SocialPerson.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        Dgv_SocialPerson.BackgroundColor = Color.SlateGray
        Dgv_SocialPerson.BorderStyle = BorderStyle.Fixed3D
        DataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle9.BackColor = Color.LightSkyBlue
        DataGridViewCellStyle9.Font = New Font("Baloo", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle9.ForeColor = SystemColors.Window
        DataGridViewCellStyle9.SelectionBackColor = Color.LightSkyBlue
        DataGridViewCellStyle9.SelectionForeColor = SystemColors.Window
        DataGridViewCellStyle9.WrapMode = DataGridViewTriState.True
        Dgv_SocialPerson.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle9
        Dgv_SocialPerson.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle10.BackColor = SystemColors.Window
        DataGridViewCellStyle10.Font = New Font("Baloo", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle10.ForeColor = SystemColors.ControlText
        DataGridViewCellStyle10.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle10.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle10.WrapMode = DataGridViewTriState.False
        Dgv_SocialPerson.DefaultCellStyle = DataGridViewCellStyle10
        Dgv_SocialPerson.EnableHeadersVisualStyles = False
        Dgv_SocialPerson.GridColor = Color.Black
        Dgv_SocialPerson.Location = New Point(95, 241)
        Dgv_SocialPerson.Name = "Dgv_SocialPerson"
        Dgv_SocialPerson.RowHeadersVisible = False
        Dgv_SocialPerson.ShowEditingIcon = False
        Dgv_SocialPerson.Size = New Size(600, 300)
        Dgv_SocialPerson.TabIndex = 87
        ' 
        ' Cb_Area
        ' 
        Cb_Area.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        Cb_Area.BackColor = Color.AliceBlue
        Cb_Area.Cursor = Cursors.Hand
        Cb_Area.DrawMode = DrawMode.OwnerDrawVariable
        Cb_Area.DropDownStyle = ComboBoxStyle.DropDownList
        Cb_Area.Font = New Font("Segoe UI Semibold", 14.25F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Cb_Area.ForeColor = Color.SkyBlue
        Cb_Area.FormattingEnabled = True
        Cb_Area.Items.AddRange(New Object() {"Adaptativa", "Motriz Gruesa", "Motriz Fina", "Lenguaje", "Personal Social"})
        Cb_Area.Location = New Point(61, 201)
        Cb_Area.Name = "Cb_Area"
        Cb_Area.Size = New Size(346, 34)
        Cb_Area.TabIndex = 69
        ' 
        ' ID
        ' 
        ID.AutoSizeMode = DataGridViewAutoSizeColumnMode.None
        ID.Frozen = True
        ID.HeaderText = "ID"
        ID.Name = "ID"
        ID.Resizable = DataGridViewTriState.False
        ID.Visible = False
        ID.Width = 10
        ' 
        ' Conducta
        ' 
        Conducta.AutoSizeMode = DataGridViewAutoSizeColumnMode.None
        Conducta.DataPropertyName = "Conducta"
        Conducta.DividerWidth = 1
        Conducta.Frozen = True
        Conducta.HeaderText = "Conducta"
        Conducta.Name = "Conducta"
        Conducta.ReadOnly = True
        Conducta.Resizable = DataGridViewTriState.False
        Conducta.Width = 570
        ' 
        ' Indicador
        ' 
        Indicador.AutoSizeMode = DataGridViewAutoSizeColumnMode.None
        Indicador.DataPropertyName = "Indicador"
        Indicador.DividerWidth = 1
        Indicador.Frozen = True
        Indicador.HeaderText = "Indicador"
        Indicador.Name = "Indicador"
        Indicador.Resizable = DataGridViewTriState.False
        Indicador.Width = 80
        ' 
        ' KidEvaluation
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.fondo_de_pantalla
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(786, 719)
        Controls.Add(Btn_Save)
        Controls.Add(Dgv_Adaptative)
        Controls.Add(Lbl_BloodType)
        Controls.Add(Lbl_Allergy)
        Controls.Add(Lbl_Name)
        Controls.Add(TableLayoutPanel1)
        Controls.Add(Cb_Area)
        Controls.Add(Lbl_Age)
        Controls.Add(Dgv_SocialPerson)
        Controls.Add(Dgv_Language)
        Controls.Add(Dgv_FineMotor)
        Controls.Add(Dgv_GrossMotor)
        MaximizeBox = False
        Name = "KidEvaluation"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Kid Stimulation Register"
        TableLayoutPanel1.ResumeLayout(False)
        TableLayoutPanel1.PerformLayout()
        CType(Dgv_Adaptative, ComponentModel.ISupportInitialize).EndInit()
        CType(Dgv_GrossMotor, ComponentModel.ISupportInitialize).EndInit()
        CType(Dgv_FineMotor, ComponentModel.ISupportInitialize).EndInit()
        CType(Dgv_Language, ComponentModel.ISupportInitialize).EndInit()
        CType(Dgv_SocialPerson, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Label8 As Label
    Friend WithEvents Lbl_Age As Label
    Friend WithEvents Lbl_Name As Label
    Friend WithEvents Lbl_Allergy As Label
    Friend WithEvents Lbl_BloodType As Label
    Friend WithEvents Dgv_Adaptative As DataGridView
    Friend WithEvents Btn_Save As Button
    Friend WithEvents Dgv_GrossMotor As DataGridView
    Friend WithEvents Dgv_FineMotor As DataGridView
    Friend WithEvents Dgv_Language As DataGridView
    Friend WithEvents Dgv_SocialPerson As DataGridView
    Friend WithEvents Cb_Area As ComboBox
    Friend WithEvents ID As DataGridViewTextBoxColumn
    Friend WithEvents Conducta As DataGridViewTextBoxColumn
    Friend WithEvents Indicador As DataGridViewCheckBoxColumn
End Class
