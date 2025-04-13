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
        Dgv_Adaptative = New DataGridView()
        Label1 = New Label()
        Lbl_WeeksAge = New Label()
        TableLayoutPanel1 = New TableLayoutPanel()
        Label8 = New Label()
        Cb_Behavior = New ComboBox()
        Label13 = New Label()
        Label11 = New Label()
        Label15 = New Label()
        Label10 = New Label()
        Label12 = New Label()
        Lbl_Age = New Label()
        Lbl_Name = New Label()
        Lbl_Allergy = New Label()
        Lbl_BloodType = New Label()
        CType(Dgv_Adaptative, ComponentModel.ISupportInitialize).BeginInit()
        TableLayoutPanel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Dgv_Adaptative
        ' 
        Dgv_Adaptative.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Dgv_Adaptative.Location = New Point(85, 188)
        Dgv_Adaptative.Name = "Dgv_Adaptative"
        Dgv_Adaptative.Size = New Size(666, 347)
        Dgv_Adaptative.TabIndex = 78
        ' 
        ' Label1
        ' 
        Label1.BackColor = Color.LightSkyBlue
        Label1.Font = New Font("Segoe UI Light", 8.25F)
        Label1.Location = New Point(411, 148)
        Label1.Name = "Label1"
        Label1.Size = New Size(5, 38)
        Label1.TabIndex = 77
        ' 
        ' Lbl_WeeksAge
        ' 
        Lbl_WeeksAge.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        Lbl_WeeksAge.Font = New Font("Baloo", 14.2499981F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Lbl_WeeksAge.Location = New Point(418, 150)
        Lbl_WeeksAge.Name = "Lbl_WeeksAge"
        Lbl_WeeksAge.Size = New Size(333, 33)
        Lbl_WeeksAge.TabIndex = 70
        Lbl_WeeksAge.Text = "4 Semanas"
        Lbl_WeeksAge.TextAlign = ContentAlignment.MiddleCenter
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
        ' Cb_Behavior
        ' 
        Cb_Behavior.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        Cb_Behavior.BackColor = Color.AliceBlue
        Cb_Behavior.Cursor = Cursors.Hand
        Cb_Behavior.DrawMode = DrawMode.OwnerDrawVariable
        Cb_Behavior.DropDownStyle = ComboBoxStyle.DropDownList
        Cb_Behavior.Font = New Font("Segoe UI Semibold", 14.25F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Cb_Behavior.ForeColor = Color.SkyBlue
        Cb_Behavior.FormattingEnabled = True
        Cb_Behavior.Items.AddRange(New Object() {"Adaptativa", "Motriz Gruesa", "Motriz Delgada"})
        Cb_Behavior.Location = New Point(85, 149)
        Cb_Behavior.Name = "Cb_Behavior"
        Cb_Behavior.Size = New Size(327, 34)
        Cb_Behavior.TabIndex = 69
        ' 
        ' Label13
        ' 
        Label13.BackColor = Color.LightSkyBlue
        Label13.Font = New Font("Segoe UI Light", 8.25F)
        Label13.Location = New Point(85, 183)
        Label13.Name = "Label13"
        Label13.Size = New Size(666, 5)
        Label13.TabIndex = 75
        ' 
        ' Label11
        ' 
        Label11.BackColor = Color.LightSkyBlue
        Label11.Font = New Font("Segoe UI Light", 8.25F)
        Label11.Location = New Point(80, 145)
        Label11.Name = "Label11"
        Label11.Size = New Size(5, 396)
        Label11.TabIndex = 74
        ' 
        ' Label15
        ' 
        Label15.BackColor = Color.LightSkyBlue
        Label15.Font = New Font("Segoe UI Light", 8.25F)
        Label15.Location = New Point(751, 145)
        Label15.Name = "Label15"
        Label15.Size = New Size(5, 396)
        Label15.TabIndex = 73
        ' 
        ' Label10
        ' 
        Label10.BackColor = Color.LightSkyBlue
        Label10.Font = New Font("Segoe UI Light", 8.25F)
        Label10.Location = New Point(85, 536)
        Label10.Name = "Label10"
        Label10.Size = New Size(666, 5)
        Label10.TabIndex = 72
        ' 
        ' Label12
        ' 
        Label12.BackColor = Color.LightSkyBlue
        Label12.Font = New Font("Segoe UI Light", 8.25F)
        Label12.Location = New Point(85, 145)
        Label12.Name = "Label12"
        Label12.Size = New Size(666, 5)
        Label12.TabIndex = 71
        ' 
        ' Lbl_Age
        ' 
        Lbl_Age.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom
        Lbl_Age.Font = New Font("Baloo", 15.7499981F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Lbl_Age.ForeColor = Color.SkyBlue
        Lbl_Age.Location = New Point(37, 145)
        Lbl_Age.Name = "Lbl_Age"
        Lbl_Age.Size = New Size(37, 396)
        Lbl_Age.TabIndex = 68
        Lbl_Age.Text = "3 AÑOS - 6 MESES"
        Lbl_Age.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Lbl_Name
        ' 
        Lbl_Name.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom
        Lbl_Name.Font = New Font("Baloo", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Lbl_Name.ForeColor = Color.SkyBlue
        Lbl_Name.Location = New Point(131, 673)
        Lbl_Name.Name = "Lbl_Name"
        Lbl_Name.Size = New Size(317, 37)
        Lbl_Name.TabIndex = 79
        Lbl_Name.Text = "Nombre"
        Lbl_Name.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Lbl_Allergy
        ' 
        Lbl_Allergy.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom
        Lbl_Allergy.Font = New Font("Baloo", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Lbl_Allergy.ForeColor = Color.SkyBlue
        Lbl_Allergy.Location = New Point(418, 673)
        Lbl_Allergy.Name = "Lbl_Allergy"
        Lbl_Allergy.Size = New Size(317, 37)
        Lbl_Allergy.TabIndex = 80
        Lbl_Allergy.Text = "Nombre"
        Lbl_Allergy.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Lbl_BloodType
        ' 
        Lbl_BloodType.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom
        Lbl_BloodType.Font = New Font("Baloo", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Lbl_BloodType.ForeColor = Color.SkyBlue
        Lbl_BloodType.Location = New Point(602, 577)
        Lbl_BloodType.Name = "Lbl_BloodType"
        Lbl_BloodType.Size = New Size(53, 37)
        Lbl_BloodType.TabIndex = 81
        Lbl_BloodType.Text = "A+"
        Lbl_BloodType.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' KidEvaluation
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.fondo_de_pantalla
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(786, 719)
        Controls.Add(Lbl_BloodType)
        Controls.Add(Lbl_Allergy)
        Controls.Add(Lbl_Name)
        Controls.Add(Dgv_Adaptative)
        Controls.Add(Label1)
        Controls.Add(Lbl_WeeksAge)
        Controls.Add(TableLayoutPanel1)
        Controls.Add(Cb_Behavior)
        Controls.Add(Label13)
        Controls.Add(Label11)
        Controls.Add(Label15)
        Controls.Add(Label10)
        Controls.Add(Label12)
        Controls.Add(Lbl_Age)
        Name = "KidEvaluation"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Kid Stimulation Register"
        CType(Dgv_Adaptative, ComponentModel.ISupportInitialize).EndInit()
        TableLayoutPanel1.ResumeLayout(False)
        TableLayoutPanel1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Dgv_Adaptative As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Lbl_WeeksAge As Label
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Label8 As Label
    Friend WithEvents Cb_Behavior As ComboBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Lbl_Age As Label
    Friend WithEvents Lbl_Name As Label
    Friend WithEvents Lbl_Allergy As Label
    Friend WithEvents Lbl_BloodType As Label
End Class
