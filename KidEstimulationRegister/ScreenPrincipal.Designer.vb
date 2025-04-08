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
        Btn_ScreenRegister = New Button()
        Btn_ScreenActivity = New Button()
        Label1 = New Label()
        Btn_ScreenEvaluation = New Button()
        btn_Exit = New Button()
        Btn_ScreenList = New Button()
        SuspendLayout()
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Baloo", 26.2499962F, FontStyle.Bold)
        Label2.ForeColor = Color.DodgerBlue
        Label2.Location = New Point(204, 128)
        Label2.Name = "Label2"
        Label2.Size = New Size(416, 55)
        Label2.TabIndex = 1
        Label2.Text = "Estimulación Temprana"
        ' 
        ' Btn_ScreenRegister
        ' 
        Btn_ScreenRegister.BackColor = Color.SteelBlue
        Btn_ScreenRegister.Cursor = Cursors.Hand
        Btn_ScreenRegister.Font = New Font("Baloo", 11.999999F, FontStyle.Bold)
        Btn_ScreenRegister.ForeColor = Color.White
        Btn_ScreenRegister.Location = New Point(460, 291)
        Btn_ScreenRegister.Name = "Btn_ScreenRegister"
        Btn_ScreenRegister.Size = New Size(160, 80)
        Btn_ScreenRegister.TabIndex = 3
        Btn_ScreenRegister.Text = "Registro"
        Btn_ScreenRegister.UseVisualStyleBackColor = False
        ' 
        ' Btn_ScreenActivity
        ' 
        Btn_ScreenActivity.BackColor = Color.SteelBlue
        Btn_ScreenActivity.Cursor = Cursors.Hand
        Btn_ScreenActivity.Font = New Font("Baloo", 11.999999F, FontStyle.Bold)
        Btn_ScreenActivity.ForeColor = Color.White
        Btn_ScreenActivity.Location = New Point(204, 412)
        Btn_ScreenActivity.Name = "Btn_ScreenActivity"
        Btn_ScreenActivity.Size = New Size(160, 80)
        Btn_ScreenActivity.TabIndex = 4
        Btn_ScreenActivity.Text = "Actividades Realizadas"
        Btn_ScreenActivity.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Baloo", 26.2499962F, FontStyle.Bold)
        Label1.ForeColor = Color.Plum
        Label1.Location = New Point(225, 183)
        Label1.Name = "Label1"
        Label1.Size = New Size(370, 55)
        Label1.TabIndex = 5
        Label1.Text = "Orientación Familiar"
        ' 
        ' Btn_ScreenEvaluation
        ' 
        Btn_ScreenEvaluation.BackColor = Color.SteelBlue
        Btn_ScreenEvaluation.Cursor = Cursors.Hand
        Btn_ScreenEvaluation.Font = New Font("Baloo", 11.999999F, FontStyle.Bold)
        Btn_ScreenEvaluation.ForeColor = Color.White
        Btn_ScreenEvaluation.Location = New Point(204, 291)
        Btn_ScreenEvaluation.Name = "Btn_ScreenEvaluation"
        Btn_ScreenEvaluation.Size = New Size(160, 80)
        Btn_ScreenEvaluation.TabIndex = 2
        Btn_ScreenEvaluation.Text = "Evaluación"
        Btn_ScreenEvaluation.UseVisualStyleBackColor = False
        ' 
        ' btn_Exit
        ' 
        btn_Exit.BackgroundImage = My.Resources.Resources.salir1
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
        ' Btn_ScreenList
        ' 
        Btn_ScreenList.BackColor = Color.SteelBlue
        Btn_ScreenList.Cursor = Cursors.Hand
        Btn_ScreenList.Font = New Font("Baloo", 11.999999F, FontStyle.Bold)
        Btn_ScreenList.ForeColor = Color.White
        Btn_ScreenList.Location = New Point(460, 412)
        Btn_ScreenList.Name = "Btn_ScreenList"
        Btn_ScreenList.Size = New Size(160, 80)
        Btn_ScreenList.TabIndex = 7
        Btn_ScreenList.Text = "Lista de Infantes"
        Btn_ScreenList.UseVisualStyleBackColor = False
        ' 
        ' ScreenPrincipal
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.fondo_de_pantalla
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(786, 719)
        Controls.Add(Btn_ScreenList)
        Controls.Add(btn_Exit)
        Controls.Add(Label1)
        Controls.Add(Btn_ScreenActivity)
        Controls.Add(Btn_ScreenRegister)
        Controls.Add(Btn_ScreenEvaluation)
        Controls.Add(Label2)
        Name = "ScreenPrincipal"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Kid Stimulation Register"
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents Btn_ScreenRegister As Button
    Friend WithEvents Btn_ScreenActivity As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Btn_ScreenEvaluation As Button
    Friend WithEvents btn_Exit As Button
    Friend WithEvents Btn_ScreenList As Button

End Class
