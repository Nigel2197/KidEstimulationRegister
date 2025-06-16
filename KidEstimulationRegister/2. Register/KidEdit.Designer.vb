<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class KidEdit
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(KidEdit))
        TableLayoutPanel1 = New TableLayoutPanel()
        Label8 = New Label()
        btn_Back = New Button()
        Label11 = New Label()
        Label2 = New Label()
        Tb_Name = New TextBox()
        Label10 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Cb_Gender = New ComboBox()
        Tb_Address = New TextBox()
        Label6 = New Label()
        Cb_BloodType = New ComboBox()
        Label7 = New Label()
        Label9 = New Label()
        Tb_WhatAllergy = New TextBox()
        btn_Save = New Button()
        Ckb_Allergic = New CheckBox()
        Dtp_DayBirth = New DateTimePicker()
        Tb_Age = New TextBox()
        Cb_Name = New ComboBox()
        btn_Exit = New Button()
        TableLayoutPanel1.SuspendLayout()
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
        TableLayoutPanel1.TabIndex = 43
        ' 
        ' Label8
        ' 
        Label8.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom
        Label8.AutoSize = True
        Label8.BackColor = Color.Transparent
        Label8.Font = New Font("Baloo", 23.9999981F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label8.ForeColor = Color.White
        Label8.Location = New Point(261, 0)
        Label8.Name = "Label8"
        Label8.Size = New Size(240, 50)
        Label8.TabIndex = 48
        Label8.Text = "Editar Infante"
        Label8.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' btn_Back
        ' 
        btn_Back.BackColor = Color.Transparent
        btn_Back.BackgroundImage = My.Resources.Resources.regresar
        btn_Back.BackgroundImageLayout = ImageLayout.Stretch
        btn_Back.Cursor = Cursors.Hand
        btn_Back.FlatAppearance.BorderSize = 0
        btn_Back.FlatStyle = FlatStyle.Flat
        btn_Back.ForeColor = Color.Transparent
        btn_Back.Location = New Point(5, 5)
        btn_Back.Name = "btn_Back"
        btn_Back.Size = New Size(118, 40)
        btn_Back.TabIndex = 42
        btn_Back.UseVisualStyleBackColor = False
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.BackColor = Color.Transparent
        Label11.Font = New Font("Baloo", 14.2499981F)
        Label11.ForeColor = SystemColors.Window
        Label11.Location = New Point(450, 170)
        Label11.Name = "Label11"
        Label11.Size = New Size(59, 30)
        Label11.TabIndex = 20
        Label11.Text = "Sexo:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Baloo", 14.2499981F)
        Label2.ForeColor = SystemColors.Window
        Label2.Location = New Point(167, 170)
        Label2.Name = "Label2"
        Label2.Size = New Size(87, 30)
        Label2.TabIndex = 1
        Label2.Text = "Nombre:"
        ' 
        ' Tb_Name
        ' 
        Tb_Name.BackColor = Color.LightSteelBlue
        Tb_Name.Cursor = Cursors.Hand
        Tb_Name.Font = New Font("Baloo", 11.999999F)
        Tb_Name.ForeColor = Color.WhiteSmoke
        Tb_Name.Location = New Point(167, 203)
        Tb_Name.Name = "Tb_Name"
        Tb_Name.Size = New Size(255, 33)
        Tb_Name.TabIndex = 1
        Tb_Name.Visible = False
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.BackColor = Color.Transparent
        Label10.Font = New Font("Baloo", 14.2499981F)
        Label10.ForeColor = SystemColors.Window
        Label10.Location = New Point(167, 261)
        Label10.Name = "Label10"
        Label10.Size = New Size(193, 30)
        Label10.TabIndex = 19
        Label10.Text = "Fecha de nacimiento:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Baloo", 14.2499981F)
        Label3.ForeColor = SystemColors.Window
        Label3.Location = New Point(450, 261)
        Label3.Name = "Label3"
        Label3.Size = New Size(60, 30)
        Label3.TabIndex = 3
        Label3.Text = "Edad:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Baloo", 14.2499981F)
        Label4.ForeColor = SystemColors.Window
        Label4.Location = New Point(167, 351)
        Label4.Name = "Label4"
        Label4.Size = New Size(99, 30)
        Label4.TabIndex = 7
        Label4.Text = "Dirección:"
        ' 
        ' Cb_Gender
        ' 
        Cb_Gender.BackColor = Color.LightSteelBlue
        Cb_Gender.Cursor = Cursors.Hand
        Cb_Gender.DropDownStyle = ComboBoxStyle.DropDownList
        Cb_Gender.FlatStyle = FlatStyle.Flat
        Cb_Gender.Font = New Font("Baloo", 11.999999F)
        Cb_Gender.ForeColor = SystemColors.Window
        Cb_Gender.FormattingEnabled = True
        Cb_Gender.Items.AddRange(New Object() {"Masculino", "Femenino"})
        Cb_Gender.Location = New Point(450, 203)
        Cb_Gender.Name = "Cb_Gender"
        Cb_Gender.Size = New Size(165, 33)
        Cb_Gender.TabIndex = 2
        Cb_Gender.Tag = ""
        ' 
        ' Tb_Address
        ' 
        Tb_Address.BackColor = Color.LightSteelBlue
        Tb_Address.Cursor = Cursors.Hand
        Tb_Address.Font = New Font("Baloo", 11.999999F)
        Tb_Address.ForeColor = SystemColors.Window
        Tb_Address.Location = New Point(167, 384)
        Tb_Address.Name = "Tb_Address"
        Tb_Address.Size = New Size(448, 33)
        Tb_Address.TabIndex = 4
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.Transparent
        Label6.Font = New Font("Baloo", 14.2499981F)
        Label6.ForeColor = SystemColors.Window
        Label6.Location = New Point(167, 441)
        Label6.Name = "Label6"
        Label6.Size = New Size(144, 30)
        Label6.TabIndex = 33
        Label6.Text = "Tipo de sangre:"
        ' 
        ' Cb_BloodType
        ' 
        Cb_BloodType.BackColor = Color.LightSteelBlue
        Cb_BloodType.Cursor = Cursors.Hand
        Cb_BloodType.DropDownStyle = ComboBoxStyle.DropDownList
        Cb_BloodType.FlatStyle = FlatStyle.Flat
        Cb_BloodType.Font = New Font("Baloo", 11.999999F)
        Cb_BloodType.ForeColor = SystemColors.Window
        Cb_BloodType.FormattingEnabled = True
        Cb_BloodType.Items.AddRange(New Object() {"A+", "A-", "B+", "B-", "AB+", "AB-", "O+", "O-"})
        Cb_BloodType.Location = New Point(167, 474)
        Cb_BloodType.Name = "Cb_BloodType"
        Cb_BloodType.Size = New Size(87, 33)
        Cb_BloodType.TabIndex = 5
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = Color.Transparent
        Label7.Font = New Font("Baloo", 14.2499981F)
        Label7.ForeColor = SystemColors.Window
        Label7.Location = New Point(330, 441)
        Label7.Name = "Label7"
        Label7.Size = New Size(88, 30)
        Label7.TabIndex = 37
        Label7.Text = "Alergias:"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.BackColor = Color.Transparent
        Label9.Font = New Font("Baloo", 14.2499981F)
        Label9.ForeColor = SystemColors.Window
        Label9.Location = New Point(450, 441)
        Label9.Name = "Label9"
        Label9.Size = New Size(162, 30)
        Label9.TabIndex = 38
        Label9.Text = "A que es alérgico:"
        ' 
        ' Tb_WhatAllergy
        ' 
        Tb_WhatAllergy.BackColor = Color.LightSteelBlue
        Tb_WhatAllergy.Cursor = Cursors.Hand
        Tb_WhatAllergy.Enabled = False
        Tb_WhatAllergy.Font = New Font("Baloo", 11.999999F)
        Tb_WhatAllergy.ForeColor = SystemColors.Window
        Tb_WhatAllergy.Location = New Point(450, 474)
        Tb_WhatAllergy.Name = "Tb_WhatAllergy"
        Tb_WhatAllergy.Size = New Size(165, 33)
        Tb_WhatAllergy.TabIndex = 7
        ' 
        ' btn_Save
        ' 
        btn_Save.BackColor = Color.Transparent
        btn_Save.BackgroundImage = My.Resources.Resources.guardar
        btn_Save.BackgroundImageLayout = ImageLayout.Stretch
        btn_Save.Cursor = Cursors.Hand
        btn_Save.FlatAppearance.BorderSize = 0
        btn_Save.FlatStyle = FlatStyle.Flat
        btn_Save.ForeColor = Color.Transparent
        btn_Save.Location = New Point(664, 674)
        btn_Save.Name = "btn_Save"
        btn_Save.Size = New Size(118, 40)
        btn_Save.TabIndex = 9
        btn_Save.UseVisualStyleBackColor = False
        ' 
        ' Ckb_Allergic
        ' 
        Ckb_Allergic.BackColor = Color.LightSteelBlue
        Ckb_Allergic.CheckAlign = ContentAlignment.MiddleCenter
        Ckb_Allergic.Cursor = Cursors.Hand
        Ckb_Allergic.Font = New Font("Baloo", 11.999999F)
        Ckb_Allergic.ForeColor = SystemColors.Window
        Ckb_Allergic.Location = New Point(330, 474)
        Ckb_Allergic.Name = "Ckb_Allergic"
        Ckb_Allergic.Size = New Size(88, 33)
        Ckb_Allergic.TabIndex = 6
        Ckb_Allergic.UseVisualStyleBackColor = False
        ' 
        ' Dtp_DayBirth
        ' 
        Dtp_DayBirth.CalendarFont = New Font("Baloo", 11.999999F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Dtp_DayBirth.CalendarForeColor = SystemColors.Window
        Dtp_DayBirth.CalendarMonthBackground = SystemColors.WindowFrame
        Dtp_DayBirth.CalendarTitleBackColor = Color.LightSteelBlue
        Dtp_DayBirth.Checked = False
        Dtp_DayBirth.Cursor = Cursors.Hand
        Dtp_DayBirth.CustomFormat = " "
        Dtp_DayBirth.Font = New Font("Baloo", 11.999999F, FontStyle.Regular, GraphicsUnit.Point, CByte(0), True)
        Dtp_DayBirth.Format = DateTimePickerFormat.Custom
        Dtp_DayBirth.Location = New Point(167, 295)
        Dtp_DayBirth.MaxDate = New Date(2110, 12, 31, 0, 0, 0, 0)
        Dtp_DayBirth.Name = "Dtp_DayBirth"
        Dtp_DayBirth.Size = New Size(255, 33)
        Dtp_DayBirth.TabIndex = 3
        Dtp_DayBirth.Value = New Date(2025, 4, 6, 0, 0, 0, 0)
        ' 
        ' Tb_Age
        ' 
        Tb_Age.BackColor = SystemColors.Window
        Tb_Age.Font = New Font("Baloo", 11.999999F)
        Tb_Age.ForeColor = SystemColors.ActiveCaptionText
        Tb_Age.Location = New Point(450, 295)
        Tb_Age.Name = "Tb_Age"
        Tb_Age.ReadOnly = True
        Tb_Age.Size = New Size(165, 33)
        Tb_Age.TabIndex = 40
        ' 
        ' Cb_Name
        ' 
        Cb_Name.BackColor = Color.LightSteelBlue
        Cb_Name.Cursor = Cursors.Hand
        Cb_Name.Font = New Font("Baloo", 11.999999F)
        Cb_Name.ForeColor = SystemColors.Window
        Cb_Name.FormattingEnabled = True
        Cb_Name.Location = New Point(167, 203)
        Cb_Name.Name = "Cb_Name"
        Cb_Name.Size = New Size(255, 33)
        Cb_Name.TabIndex = 1
        Cb_Name.Tag = ""
        ' 
        ' btn_Exit
        ' 
        btn_Exit.BackColor = Color.Transparent
        btn_Exit.BackgroundImage = My.Resources.Resources.salir
        btn_Exit.BackgroundImageLayout = ImageLayout.Stretch
        btn_Exit.Cursor = Cursors.Hand
        btn_Exit.FlatAppearance.BorderSize = 0
        btn_Exit.FlatStyle = FlatStyle.Flat
        btn_Exit.ForeColor = Color.Transparent
        btn_Exit.Location = New Point(5, 674)
        btn_Exit.Name = "btn_Exit"
        btn_Exit.Size = New Size(118, 40)
        btn_Exit.TabIndex = 50
        btn_Exit.UseVisualStyleBackColor = False
        ' 
        ' KidEdit
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.fondo_de_pantalla
        BackgroundImageLayout = ImageLayout.Stretch
        CancelButton = btn_Exit
        ClientSize = New Size(786, 719)
        Controls.Add(btn_Exit)
        Controls.Add(Tb_Age)
        Controls.Add(Dtp_DayBirth)
        Controls.Add(Ckb_Allergic)
        Controls.Add(btn_Save)
        Controls.Add(TableLayoutPanel1)
        Controls.Add(btn_Back)
        Controls.Add(Tb_WhatAllergy)
        Controls.Add(Label9)
        Controls.Add(Label7)
        Controls.Add(Cb_BloodType)
        Controls.Add(Label6)
        Controls.Add(Tb_Address)
        Controls.Add(Cb_Gender)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label10)
        Controls.Add(Label2)
        Controls.Add(Label11)
        Controls.Add(Cb_Name)
        Controls.Add(Tb_Name)
        ForeColor = Color.Transparent
        FormBorderStyle = FormBorderStyle.FixedDialog
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MaximizeBox = False
        Name = "KidEdit"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Primeros Pasos"
        TableLayoutPanel1.ResumeLayout(False)
        TableLayoutPanel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents btn_Back As Button
    Friend WithEvents Label11 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Tb_Name As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Cb_Gender As ComboBox
    Friend WithEvents Tb_Address As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Cb_BloodType As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Tb_WhatAllergy As TextBox
    Friend WithEvents btn_Save As Button
    Friend WithEvents Ckb_Allergic As CheckBox
    Friend WithEvents Label8 As Label
    Private WithEvents Dtp_DayBirth As DateTimePicker
    Friend WithEvents Tb_Age As TextBox
    Friend WithEvents Cb_Name As ComboBox
    Friend WithEvents btn_Exit As Button
End Class
