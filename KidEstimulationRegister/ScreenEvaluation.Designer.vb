<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ScreenEvaluation
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
        Tb_Name = New TextBox()
        Label2 = New Label()
        btn_Evaluation = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = Color.AliceBlue
        Label1.Location = New Point(295, 144)
        Label1.Name = "Label1"
        Label1.Size = New Size(195, 47)
        Label1.TabIndex = 1
        Label1.Text = "Evaluación"
        ' 
        ' Tb_Name
        ' 
        Tb_Name.BackColor = Color.LightSteelBlue
        Tb_Name.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Tb_Name.ForeColor = SystemColors.Window
        Tb_Name.Location = New Point(241, 296)
        Tb_Name.Name = "Tb_Name"
        Tb_Name.Size = New Size(300, 29)
        Tb_Name.TabIndex = 4
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.ForeColor = Color.AliceBlue
        Label2.Location = New Point(279, 249)
        Label2.Name = "Label2"
        Label2.Size = New Size(225, 30)
        Label2.TabIndex = 3
        Label2.Text = "Introduzca el nombre"
        ' 
        ' btn_Evaluation
        ' 
        btn_Evaluation.BackColor = Color.SteelBlue
        btn_Evaluation.Cursor = Cursors.Hand
        btn_Evaluation.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        btn_Evaluation.ForeColor = Color.White
        btn_Evaluation.Location = New Point(295, 386)
        btn_Evaluation.Name = "btn_Evaluation"
        btn_Evaluation.Size = New Size(195, 65)
        btn_Evaluation.TabIndex = 5
        btn_Evaluation.Text = "Evaluar"
        btn_Evaluation.UseVisualStyleBackColor = False
        ' 
        ' ScreenEvaluation
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.fondo_de_pantalla
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(786, 719)
        Controls.Add(btn_Evaluation)
        Controls.Add(Tb_Name)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "ScreenEvaluation"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Kid Stimulation Register"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Tb_Name As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btn_Evaluation As Button
End Class
