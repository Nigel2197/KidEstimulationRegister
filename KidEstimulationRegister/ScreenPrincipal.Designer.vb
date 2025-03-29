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
        Label2 = New Label()
        btn_ScreenRegister = New Button()
        btn_ScreenActivity = New Button()
        Label1 = New Label()
        btn_ScreenEvaluation = New Button()
        btn_Exit = New Button()
        SuspendLayout()
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.ForeColor = Color.DodgerBlue
        Label2.Location = New Point(205, 132)
        Label2.Name = "Label2"
        Label2.Size = New Size(403, 47)
        Label2.TabIndex = 1
        Label2.Text = "Estimulación Temprana"
        ' 
        ' btn_ScreenRegister
        ' 
        btn_ScreenRegister.BackColor = Color.SteelBlue
        btn_ScreenRegister.Cursor = Cursors.Hand
        btn_ScreenRegister.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        btn_ScreenRegister.ForeColor = Color.White
        btn_ScreenRegister.Location = New Point(315, 447)
        btn_ScreenRegister.Name = "btn_ScreenRegister"
        btn_ScreenRegister.Size = New Size(189, 65)
        btn_ScreenRegister.TabIndex = 3
        btn_ScreenRegister.Text = "Registro"
        btn_ScreenRegister.UseVisualStyleBackColor = False
        ' 
        ' btn_ScreenActivity
        ' 
        btn_ScreenActivity.BackColor = Color.SteelBlue
        btn_ScreenActivity.Cursor = Cursors.Hand
        btn_ScreenActivity.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        btn_ScreenActivity.ForeColor = Color.White
        btn_ScreenActivity.Location = New Point(315, 358)
        btn_ScreenActivity.Name = "btn_ScreenActivity"
        btn_ScreenActivity.Size = New Size(189, 65)
        btn_ScreenActivity.TabIndex = 4
        btn_ScreenActivity.Text = "Actividades Realizadas"
        btn_ScreenActivity.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = Color.Plum
        Label1.Location = New Point(226, 184)
        Label1.Name = "Label1"
        Label1.Size = New Size(354, 47)
        Label1.TabIndex = 5
        Label1.Text = "Orientación Familiar"
        ' 
        ' btn_ScreenEvaluation
        ' 
        btn_ScreenEvaluation.BackColor = Color.SteelBlue
        btn_ScreenEvaluation.Cursor = Cursors.Hand
        btn_ScreenEvaluation.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        btn_ScreenEvaluation.ForeColor = Color.White
        btn_ScreenEvaluation.Location = New Point(315, 271)
        btn_ScreenEvaluation.Name = "btn_ScreenEvaluation"
        btn_ScreenEvaluation.Size = New Size(189, 65)
        btn_ScreenEvaluation.TabIndex = 2
        btn_ScreenEvaluation.Text = "Evaluación"
        btn_ScreenEvaluation.UseVisualStyleBackColor = False
        ' 
        ' btn_Exit
        ' 
        btn_Exit.BackgroundImage = My.Resources.Resources.salir
        btn_Exit.BackgroundImageLayout = ImageLayout.Stretch
        btn_Exit.Cursor = Cursors.Hand
        btn_Exit.FlatStyle = FlatStyle.Flat
        btn_Exit.ForeColor = SystemColors.ControlText
        btn_Exit.Location = New Point(681, 677)
        btn_Exit.Name = "btn_Exit"
        btn_Exit.Size = New Size(97, 35)
        btn_Exit.TabIndex = 6
        btn_Exit.UseVisualStyleBackColor = True
        ' 
        ' ScreenPrincipal
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.fondo_de_pantalla
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(786, 719)
        Controls.Add(btn_Exit)
        Controls.Add(Label1)
        Controls.Add(btn_ScreenActivity)
        Controls.Add(btn_ScreenRegister)
        Controls.Add(btn_ScreenEvaluation)
        Controls.Add(Label2)
        Name = "ScreenPrincipal"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Kid Stimulation Register"
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents btn_ScreenRegister As Button
    Friend WithEvents btn_ScreenActivity As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents btn_ScreenEvaluation As Button
    Friend WithEvents btn_Exit As Button

End Class
