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
        lbl_Age = New Label()
        Label12 = New Label()
        Label10 = New Label()
        Label15 = New Label()
        Label13 = New Label()
        cb_Conducta = New ComboBox()
        lbl_WeeksAge = New Label()
        dgv_ScaleGessell = New DataGridView()
        Label11 = New Label()
        Label2 = New Label()
        TableLayoutPanel1 = New TableLayoutPanel()
        Label8 = New Label()
        CType(dgv_ScaleGessell, ComponentModel.ISupportInitialize).BeginInit()
        TableLayoutPanel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' lbl_Age
        ' 
        lbl_Age.BackColor = Color.AliceBlue
        lbl_Age.Font = New Font("Baloo", 15.7499981F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lbl_Age.ForeColor = Color.SkyBlue
        lbl_Age.Location = New Point(33, 132)
        lbl_Age.Name = "lbl_Age"
        lbl_Age.Size = New Size(37, 404)
        lbl_Age.TabIndex = 7
        lbl_Age.Text = "3 AÑOS - 6 MESES"
        lbl_Age.TextAlign = ContentAlignment.TopCenter
        ' 
        ' Label12
        ' 
        Label12.BackColor = Color.LightSkyBlue
        Label12.Font = New Font("Segoe UI Light", 8.25F)
        Label12.Location = New Point(85, 175)
        Label12.Name = "Label12"
        Label12.Size = New Size(666, 5)
        Label12.TabIndex = 59
        ' 
        ' Label10
        ' 
        Label10.BackColor = Color.LightSkyBlue
        Label10.Font = New Font("Segoe UI Light", 8.25F)
        Label10.Location = New Point(85, 536)
        Label10.Name = "Label10"
        Label10.Size = New Size(666, 5)
        Label10.TabIndex = 60
        ' 
        ' Label15
        ' 
        Label15.BackColor = Color.LightSkyBlue
        Label15.Font = New Font("Segoe UI Light", 8.25F)
        Label15.Location = New Point(751, 132)
        Label15.Name = "Label15"
        Label15.Size = New Size(5, 409)
        Label15.TabIndex = 61
        ' 
        ' Label13
        ' 
        Label13.BackColor = Color.LightSkyBlue
        Label13.Font = New Font("Segoe UI Light", 8.25F)
        Label13.Location = New Point(85, 132)
        Label13.Name = "Label13"
        Label13.Size = New Size(666, 5)
        Label13.TabIndex = 64
        ' 
        ' cb_Conducta
        ' 
        cb_Conducta.BackColor = Color.AliceBlue
        cb_Conducta.Cursor = Cursors.Hand
        cb_Conducta.DrawMode = DrawMode.OwnerDrawVariable
        cb_Conducta.DropDownStyle = ComboBoxStyle.DropDownList
        cb_Conducta.FlatStyle = FlatStyle.Popup
        cb_Conducta.Font = New Font("Baloo", 14.2499981F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        cb_Conducta.ForeColor = Color.SkyBlue
        cb_Conducta.FormattingEnabled = True
        cb_Conducta.Items.AddRange(New Object() {"Adaptativa", "Motriz Gruesa", "Motriz Fina", "Lenguaje", "Personal Social"})
        cb_Conducta.Location = New Point(85, 137)
        cb_Conducta.Name = "cb_Conducta"
        cb_Conducta.Size = New Size(327, 38)
        cb_Conducta.TabIndex = 58
        ' 
        ' lbl_WeeksAge
        ' 
        lbl_WeeksAge.BackColor = Color.AliceBlue
        lbl_WeeksAge.Font = New Font("Baloo", 14.2499981F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        lbl_WeeksAge.ForeColor = Color.SkyBlue
        lbl_WeeksAge.Location = New Point(418, 137)
        lbl_WeeksAge.Name = "lbl_WeeksAge"
        lbl_WeeksAge.Size = New Size(333, 38)
        lbl_WeeksAge.TabIndex = 59
        lbl_WeeksAge.Text = "4 Semanas"
        lbl_WeeksAge.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' dgv_ScaleGessell
        ' 
        dgv_ScaleGessell.BackgroundColor = Color.AliceBlue
        dgv_ScaleGessell.BorderStyle = BorderStyle.None
        dgv_ScaleGessell.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgv_ScaleGessell.GridColor = Color.LightSkyBlue
        dgv_ScaleGessell.Location = New Point(85, 180)
        dgv_ScaleGessell.Name = "dgv_ScaleGessell"
        dgv_ScaleGessell.Size = New Size(666, 355)
        dgv_ScaleGessell.TabIndex = 0
        ' 
        ' Label11
        ' 
        Label11.BackColor = Color.LightSkyBlue
        Label11.Font = New Font("Segoe UI Light", 8.25F)
        Label11.Location = New Point(80, 132)
        Label11.Name = "Label11"
        Label11.Size = New Size(5, 409)
        Label11.TabIndex = 62
        ' 
        ' Label2
        ' 
        Label2.BackColor = Color.LightSkyBlue
        Label2.Font = New Font("Segoe UI Light", 8.25F)
        Label2.Location = New Point(412, 137)
        Label2.Name = "Label2"
        Label2.Size = New Size(5, 38)
        Label2.TabIndex = 65
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
        TableLayoutPanel1.TabIndex = 66
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
        ' KidEvaluation
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.fondo_de_pantalla
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(786, 719)
        Controls.Add(TableLayoutPanel1)
        Controls.Add(Label2)
        Controls.Add(cb_Conducta)
        Controls.Add(lbl_WeeksAge)
        Controls.Add(dgv_ScaleGessell)
        Controls.Add(Label13)
        Controls.Add(Label11)
        Controls.Add(Label15)
        Controls.Add(Label10)
        Controls.Add(Label12)
        Controls.Add(lbl_Age)
        Name = "KidEvaluation"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Kid Stimulation Register"
        CType(dgv_ScaleGessell, ComponentModel.ISupportInitialize).EndInit()
        TableLayoutPanel1.ResumeLayout(False)
        TableLayoutPanel1.PerformLayout()
        ResumeLayout(False)
    End Sub
    Friend WithEvents lbl_Age As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents cb_Conducta As ComboBox
    Friend WithEvents lbl_WeeksAge As Label
    Friend WithEvents dgv_ScaleGessell As DataGridView
    Friend WithEvents Label11 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Label8 As Label
End Class
