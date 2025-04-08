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
        DataGridView1 = New DataGridView()
        Label1 = New Label()
        Label14 = New Label()
        TableLayoutPanel1 = New TableLayoutPanel()
        Label8 = New Label()
        cb_Conducta = New ComboBox()
        Label13 = New Label()
        Label11 = New Label()
        Label15 = New Label()
        Label10 = New Label()
        Label12 = New Label()
        Label4 = New Label()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        TableLayoutPanel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(85, 188)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.Size = New Size(666, 347)
        DataGridView1.TabIndex = 78
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
        ' Label14
        ' 
        Label14.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        Label14.Font = New Font("Baloo", 14.2499981F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label14.Location = New Point(418, 150)
        Label14.Name = "Label14"
        Label14.Size = New Size(333, 33)
        Label14.TabIndex = 70
        Label14.Text = "4 Semanas"
        Label14.TextAlign = ContentAlignment.MiddleCenter
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
        ' cb_Conducta
        ' 
        cb_Conducta.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        cb_Conducta.BackColor = Color.AliceBlue
        cb_Conducta.Cursor = Cursors.Hand
        cb_Conducta.DrawMode = DrawMode.OwnerDrawVariable
        cb_Conducta.DropDownStyle = ComboBoxStyle.DropDownList
        cb_Conducta.Font = New Font("Segoe UI Semibold", 14.25F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        cb_Conducta.ForeColor = Color.SkyBlue
        cb_Conducta.FormattingEnabled = True
        cb_Conducta.Items.AddRange(New Object() {"Adaptativa", "Motriz Gruesa", "Motriz Delgada"})
        cb_Conducta.Location = New Point(85, 149)
        cb_Conducta.Name = "cb_Conducta"
        cb_Conducta.Size = New Size(327, 34)
        cb_Conducta.TabIndex = 69
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
        ' Label4
        ' 
        Label4.Font = New Font("Baloo", 15.7499981F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.SkyBlue
        Label4.Location = New Point(37, 145)
        Label4.Name = "Label4"
        Label4.Size = New Size(37, 396)
        Label4.TabIndex = 68
        Label4.Text = "3 AÑOS - 6 MESES"
        Label4.TextAlign = ContentAlignment.TopCenter
        ' 
        ' KidEvaluation
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.fondo_de_pantalla
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(786, 719)
        Controls.Add(DataGridView1)
        Controls.Add(Label1)
        Controls.Add(Label14)
        Controls.Add(TableLayoutPanel1)
        Controls.Add(cb_Conducta)
        Controls.Add(Label13)
        Controls.Add(Label11)
        Controls.Add(Label15)
        Controls.Add(Label10)
        Controls.Add(Label12)
        Controls.Add(Label4)
        Name = "KidEvaluation"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Kid Stimulation Register"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        TableLayoutPanel1.ResumeLayout(False)
        TableLayoutPanel1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Label8 As Label
    Friend WithEvents cb_Conducta As ComboBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label4 As Label
End Class
