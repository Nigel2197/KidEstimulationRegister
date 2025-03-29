<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ScreenRegister
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Label1 = New Label()
        TableLayoutPanel1 = New TableLayoutPanel()
        btn_Exit = New Button()
        Label11 = New Label()
        Label2 = New Label()
        Tb_Name = New TextBox()
        Cb_DayBirth = New ComboBox()
        Label10 = New Label()
        Label3 = New Label()
        Nud_Age = New NumericUpDown()
        Cb_MonthBirth = New ComboBox()
        Cb_YearBirth = New ComboBox()
        Label4 = New Label()
        Cb_Gender = New ComboBox()
        Tb_Address = New TextBox()
        Label6 = New Label()
        ComboBox3 = New ComboBox()
        RadioButton1 = New RadioButton()
        RadioButton2 = New RadioButton()
        Label7 = New Label()
        Label9 = New Label()
        TextBox2 = New TextBox()
        ComboBox4 = New ComboBox()
        Label12 = New Label()
        TextBox3 = New TextBox()
        TableLayoutPanel1.SuspendLayout()
        CType(Nud_Age, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = Color.AliceBlue
        Label1.Location = New Point(3, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(756, 47)
        Label1.TabIndex = 0
        Label1.Text = "Registro"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.BackColor = Color.Transparent
        TableLayoutPanel1.ColumnCount = 1
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel1.Controls.Add(Label1, 0, 0)
        TableLayoutPanel1.Location = New Point(12, 97)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 1
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 51F))
        TableLayoutPanel1.Size = New Size(762, 50)
        TableLayoutPanel1.TabIndex = 43
        ' 
        ' btn_Exit
        ' 
        btn_Exit.BackgroundImage = My.Resources.Resources.salir
        btn_Exit.BackgroundImageLayout = ImageLayout.Stretch
        btn_Exit.Cursor = Cursors.Hand
        btn_Exit.FlatStyle = FlatStyle.Flat
        btn_Exit.ForeColor = SystemColors.ControlText
        btn_Exit.Location = New Point(680, 677)
        btn_Exit.Name = "btn_Exit"
        btn_Exit.Size = New Size(97, 35)
        btn_Exit.TabIndex = 42
        btn_Exit.UseVisualStyleBackColor = True
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.BackColor = Color.Transparent
        Label11.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label11.ForeColor = SystemColors.Window
        Label11.Location = New Point(449, 175)
        Label11.Name = "Label11"
        Label11.Size = New Size(41, 17)
        Label11.TabIndex = 20
        Label11.Text = "Sexo:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.ForeColor = SystemColors.Window
        Label2.Location = New Point(193, 174)
        Label2.Name = "Label2"
        Label2.Size = New Size(62, 17)
        Label2.TabIndex = 1
        Label2.Text = "Nombre:"
        ' 
        ' Tb_Name
        ' 
        Tb_Name.BackColor = Color.LightSteelBlue
        Tb_Name.ForeColor = SystemColors.Window
        Tb_Name.Location = New Point(193, 194)
        Tb_Name.Name = "Tb_Name"
        Tb_Name.Size = New Size(225, 23)
        Tb_Name.TabIndex = 1
        ' 
        ' Cb_DayBirth
        ' 
        Cb_DayBirth.BackColor = Color.LightSteelBlue
        Cb_DayBirth.ForeColor = SystemColors.Window
        Cb_DayBirth.FormattingEnabled = True
        Cb_DayBirth.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31"})
        Cb_DayBirth.Location = New Point(193, 264)
        Cb_DayBirth.Name = "Cb_DayBirth"
        Cb_DayBirth.Size = New Size(56, 23)
        Cb_DayBirth.TabIndex = 3
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.BackColor = Color.Transparent
        Label10.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label10.ForeColor = SystemColors.Window
        Label10.Location = New Point(193, 244)
        Label10.Name = "Label10"
        Label10.Size = New Size(139, 17)
        Label10.TabIndex = 19
        Label10.Text = "Fecha de nacimiento:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.ForeColor = SystemColors.Window
        Label3.Location = New Point(449, 244)
        Label3.Name = "Label3"
        Label3.Size = New Size(42, 17)
        Label3.TabIndex = 3
        Label3.Text = "Edad:"
        ' 
        ' Nud_Age
        ' 
        Nud_Age.BackColor = Color.LightSteelBlue
        Nud_Age.ForeColor = SystemColors.Window
        Nud_Age.Location = New Point(449, 265)
        Nud_Age.Name = "Nud_Age"
        Nud_Age.Size = New Size(63, 23)
        Nud_Age.TabIndex = 6
        ' 
        ' Cb_MonthBirth
        ' 
        Cb_MonthBirth.BackColor = Color.LightSteelBlue
        Cb_MonthBirth.ForeColor = SystemColors.Window
        Cb_MonthBirth.FormattingEnabled = True
        Cb_MonthBirth.Items.AddRange(New Object() {"Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre"})
        Cb_MonthBirth.Location = New Point(255, 264)
        Cb_MonthBirth.Name = "Cb_MonthBirth"
        Cb_MonthBirth.Size = New Size(94, 23)
        Cb_MonthBirth.TabIndex = 4
        ' 
        ' Cb_YearBirth
        ' 
        Cb_YearBirth.BackColor = Color.LightSteelBlue
        Cb_YearBirth.ForeColor = SystemColors.Window
        Cb_YearBirth.FormattingEnabled = True
        Cb_YearBirth.Location = New Point(355, 264)
        Cb_YearBirth.Name = "Cb_YearBirth"
        Cb_YearBirth.Size = New Size(63, 23)
        Cb_YearBirth.TabIndex = 5
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.ForeColor = SystemColors.Window
        Label4.Location = New Point(193, 316)
        Label4.Name = "Label4"
        Label4.Size = New Size(70, 17)
        Label4.TabIndex = 7
        Label4.Text = "Dirección:"
        ' 
        ' Cb_Gender
        ' 
        Cb_Gender.BackColor = Color.LightSteelBlue
        Cb_Gender.ForeColor = SystemColors.Window
        Cb_Gender.FormattingEnabled = True
        Cb_Gender.Items.AddRange(New Object() {"Masculino", "Femenino"})
        Cb_Gender.Location = New Point(449, 194)
        Cb_Gender.Name = "Cb_Gender"
        Cb_Gender.Size = New Size(151, 23)
        Cb_Gender.TabIndex = 8
        ' 
        ' Tb_Address
        ' 
        Tb_Address.BackColor = Color.LightSteelBlue
        Tb_Address.ForeColor = SystemColors.Window
        Tb_Address.Location = New Point(193, 336)
        Tb_Address.Name = "Tb_Address"
        Tb_Address.Size = New Size(400, 23)
        Tb_Address.TabIndex = 11
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.Transparent
        Label6.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label6.ForeColor = SystemColors.Window
        Label6.Location = New Point(193, 386)
        Label6.Name = "Label6"
        Label6.Size = New Size(104, 17)
        Label6.TabIndex = 33
        Label6.Text = "Tipo de sangre:"
        ' 
        ' ComboBox3
        ' 
        ComboBox3.BackColor = Color.LightSteelBlue
        ComboBox3.ForeColor = SystemColors.Window
        ComboBox3.FormattingEnabled = True
        ComboBox3.Location = New Point(193, 406)
        ComboBox3.Name = "ComboBox3"
        ComboBox3.Size = New Size(74, 23)
        ComboBox3.TabIndex = 13
        ' 
        ' RadioButton1
        ' 
        RadioButton1.AutoSize = True
        RadioButton1.BackColor = Color.LightSteelBlue
        RadioButton1.ForeColor = SystemColors.Window
        RadioButton1.Location = New Point(337, 410)
        RadioButton1.Name = "RadioButton1"
        RadioButton1.Size = New Size(34, 19)
        RadioButton1.TabIndex = 14
        RadioButton1.TabStop = True
        RadioButton1.Text = "Si"
        RadioButton1.UseVisualStyleBackColor = False
        ' 
        ' RadioButton2
        ' 
        RadioButton2.AutoSize = True
        RadioButton2.BackColor = Color.LightSteelBlue
        RadioButton2.ForeColor = SystemColors.Window
        RadioButton2.Location = New Point(377, 410)
        RadioButton2.Name = "RadioButton2"
        RadioButton2.Size = New Size(41, 19)
        RadioButton2.TabIndex = 15
        RadioButton2.TabStop = True
        RadioButton2.Text = "No"
        RadioButton2.UseVisualStyleBackColor = False
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = Color.Transparent
        Label7.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label7.ForeColor = SystemColors.Window
        Label7.Location = New Point(337, 388)
        Label7.Name = "Label7"
        Label7.Size = New Size(63, 17)
        Label7.TabIndex = 37
        Label7.Text = "Alérgico:"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.BackColor = Color.Transparent
        Label9.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label9.ForeColor = SystemColors.Window
        Label9.Location = New Point(449, 386)
        Label9.Name = "Label9"
        Label9.Size = New Size(118, 17)
        Label9.TabIndex = 38
        Label9.Text = "A que es alérgico:"
        ' 
        ' TextBox2
        ' 
        TextBox2.BackColor = Color.LightSteelBlue
        TextBox2.ForeColor = SystemColors.Window
        TextBox2.Location = New Point(449, 406)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(151, 23)
        TextBox2.TabIndex = 16
        ' 
        ' ComboBox4
        ' 
        ComboBox4.BackColor = Color.LightSteelBlue
        ComboBox4.ForeColor = SystemColors.Window
        ComboBox4.FormattingEnabled = True
        ComboBox4.Items.AddRange(New Object() {"Meses", "Años"})
        ComboBox4.Location = New Point(519, 264)
        ComboBox4.Name = "ComboBox4"
        ComboBox4.Size = New Size(81, 23)
        ComboBox4.TabIndex = 7
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.BackColor = Color.Transparent
        Label12.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label12.ForeColor = SystemColors.Window
        Label12.Location = New Point(193, 454)
        Label12.Name = "Label12"
        Label12.Size = New Size(151, 17)
        Label12.TabIndex = 41
        Label12.Text = "Nombre del Acudiente:"
        ' 
        ' TextBox3
        ' 
        TextBox3.BackColor = Color.LightSteelBlue
        TextBox3.ForeColor = SystemColors.Window
        TextBox3.Location = New Point(193, 474)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(225, 23)
        TextBox3.TabIndex = 12
        ' 
        ' ScreenRegister
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.fondo_de_pantalla
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(786, 719)
        Controls.Add(TableLayoutPanel1)
        Controls.Add(btn_Exit)
        Controls.Add(TextBox3)
        Controls.Add(Label12)
        Controls.Add(ComboBox4)
        Controls.Add(TextBox2)
        Controls.Add(Label9)
        Controls.Add(Label7)
        Controls.Add(RadioButton2)
        Controls.Add(RadioButton1)
        Controls.Add(ComboBox3)
        Controls.Add(Label6)
        Controls.Add(Tb_Address)
        Controls.Add(Cb_Gender)
        Controls.Add(Label4)
        Controls.Add(Cb_YearBirth)
        Controls.Add(Cb_MonthBirth)
        Controls.Add(Nud_Age)
        Controls.Add(Label3)
        Controls.Add(Label10)
        Controls.Add(Cb_DayBirth)
        Controls.Add(Tb_Name)
        Controls.Add(Label2)
        Controls.Add(Label11)
        Name = "ScreenRegister"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Kid Stimulation Register"
        TableLayoutPanel1.ResumeLayout(False)
        CType(Nud_Age, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents btn_Exit As Button
    Friend WithEvents Label11 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Tb_Name As TextBox
    Friend WithEvents Cb_DayBirth As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Nud_Age As NumericUpDown
    Friend WithEvents Cb_MonthBirth As ComboBox
    Friend WithEvents Cb_YearBirth As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Cb_Gender As ComboBox
    Friend WithEvents Tb_Address As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents ComboBox3 As ComboBox
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents Label7 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents ComboBox4 As ComboBox
    Friend WithEvents Label12 As Label
    Friend WithEvents TextBox3 As TextBox
End Class
