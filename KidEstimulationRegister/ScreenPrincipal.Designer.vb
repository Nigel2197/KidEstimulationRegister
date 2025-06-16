<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ScreenPrincipal
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ScreenPrincipal))
        Label2 = New Label()
        Btn_ScreenRegister = New Button()
        Btn_ScreenActivity = New Button()
        Label1 = New Label()
        Btn_ScreenEvaluation = New Button()
        btn_Exit = New Button()
        TableLayoutPanel1 = New TableLayoutPanel()
        TableLayoutPanel2 = New TableLayoutPanel()
        TableLayoutPanel1.SuspendLayout()
        TableLayoutPanel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Baloo", 26.2499962F, FontStyle.Bold)
        Label2.ForeColor = Color.DodgerBlue
        Label2.Location = New Point(191, 0)
        Label2.Margin = New Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(380, 50)
        Label2.TabIndex = 1
        Label2.Text = "Evaluación Temprana"
        Label2.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Btn_ScreenRegister
        ' 
        Btn_ScreenRegister.BackColor = Color.LightSkyBlue
        Btn_ScreenRegister.Cursor = Cursors.Hand
        Btn_ScreenRegister.Font = New Font("Baloo", 11.999999F, FontStyle.Bold)
        Btn_ScreenRegister.ForeColor = Color.White
        Btn_ScreenRegister.Location = New Point(436, 382)
        Btn_ScreenRegister.Margin = New Padding(4, 3, 4, 3)
        Btn_ScreenRegister.Name = "Btn_ScreenRegister"
        Btn_ScreenRegister.Size = New Size(160, 80)
        Btn_ScreenRegister.TabIndex = 3
        Btn_ScreenRegister.Text = "Infantes"
        Btn_ScreenRegister.UseVisualStyleBackColor = False
        ' 
        ' Btn_ScreenActivity
        ' 
        Btn_ScreenActivity.BackColor = Color.LightSkyBlue
        Btn_ScreenActivity.Cursor = Cursors.Hand
        Btn_ScreenActivity.Font = New Font("Baloo", 11.999999F, FontStyle.Bold)
        Btn_ScreenActivity.ForeColor = Color.White
        Btn_ScreenActivity.Location = New Point(200, 382)
        Btn_ScreenActivity.Margin = New Padding(4, 3, 4, 3)
        Btn_ScreenActivity.Name = "Btn_ScreenActivity"
        Btn_ScreenActivity.Size = New Size(160, 80)
        Btn_ScreenActivity.TabIndex = 4
        Btn_ScreenActivity.Text = "Actividades Realizadas"
        Btn_ScreenActivity.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Baloo", 26.2499962F, FontStyle.Bold)
        Label1.ForeColor = Color.Orchid
        Label1.Location = New Point(196, 0)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(370, 50)
        Label1.TabIndex = 5
        Label1.Text = "Orientación Familiar"
        ' 
        ' Btn_ScreenEvaluation
        ' 
        Btn_ScreenEvaluation.BackColor = Color.LightSkyBlue
        Btn_ScreenEvaluation.Cursor = Cursors.Hand
        Btn_ScreenEvaluation.Font = New Font("Baloo", 11.999999F, FontStyle.Bold)
        Btn_ScreenEvaluation.ForeColor = Color.White
        Btn_ScreenEvaluation.Location = New Point(316, 246)
        Btn_ScreenEvaluation.Margin = New Padding(4, 3, 4, 3)
        Btn_ScreenEvaluation.Name = "Btn_ScreenEvaluation"
        Btn_ScreenEvaluation.Size = New Size(160, 80)
        Btn_ScreenEvaluation.TabIndex = 2
        Btn_ScreenEvaluation.Text = "Evaluación"
        Btn_ScreenEvaluation.UseVisualStyleBackColor = False
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
        btn_Exit.Margin = New Padding(4, 3, 4, 3)
        btn_Exit.Name = "btn_Exit"
        btn_Exit.Size = New Size(118, 40)
        btn_Exit.TabIndex = 6
        btn_Exit.UseVisualStyleBackColor = False
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.BackColor = Color.Transparent
        TableLayoutPanel1.ColumnCount = 1
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel1.Controls.Add(Label2, 0, 0)
        TableLayoutPanel1.Location = New Point(12, 80)
        TableLayoutPanel1.Margin = New Padding(4, 3, 4, 3)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 1
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 51F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Absolute, 50F))
        TableLayoutPanel1.Size = New Size(762, 50)
        TableLayoutPanel1.TabIndex = 44
        ' 
        ' TableLayoutPanel2
        ' 
        TableLayoutPanel2.BackColor = Color.Transparent
        TableLayoutPanel2.ColumnCount = 1
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel2.Controls.Add(Label1, 0, 0)
        TableLayoutPanel2.Location = New Point(12, 130)
        TableLayoutPanel2.Margin = New Padding(4, 3, 4, 3)
        TableLayoutPanel2.Name = "TableLayoutPanel2"
        TableLayoutPanel2.RowCount = 1
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 51F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Absolute, 50F))
        TableLayoutPanel2.Size = New Size(762, 50)
        TableLayoutPanel2.TabIndex = 45
        ' 
        ' ScreenPrincipal
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.fondo_de_pantalla
        BackgroundImageLayout = ImageLayout.Stretch
        CancelButton = btn_Exit
        ClientSize = New Size(786, 719)
        Controls.Add(TableLayoutPanel2)
        Controls.Add(TableLayoutPanel1)
        Controls.Add(btn_Exit)
        Controls.Add(Btn_ScreenActivity)
        Controls.Add(Btn_ScreenRegister)
        Controls.Add(Btn_ScreenEvaluation)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Margin = New Padding(4, 3, 4, 3)
        MaximizeBox = False
        Name = "ScreenPrincipal"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Primeros Pasos"
        TableLayoutPanel1.ResumeLayout(False)
        TableLayoutPanel1.PerformLayout()
        TableLayoutPanel2.ResumeLayout(False)
        TableLayoutPanel2.PerformLayout()
        ResumeLayout(False)
    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents Btn_ScreenRegister As Button
    Friend WithEvents Btn_ScreenActivity As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Btn_ScreenEvaluation As Button
    Friend WithEvents btn_Exit As Button
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel

End Class
