<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MenuRegister
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
        Btn_Edit = New Button()
        Btn_New = New Button()
        TableLayoutPanel1 = New TableLayoutPanel()
        Label8 = New Label()
        Btn_ScreenList = New Button()
        TableLayoutPanel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Btn_Edit
        ' 
        Btn_Edit.BackColor = Color.SteelBlue
        Btn_Edit.Cursor = Cursors.Hand
        Btn_Edit.Font = New Font("Baloo", 11.999999F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Btn_Edit.ForeColor = Color.White
        Btn_Edit.Location = New Point(200, 382)
        Btn_Edit.Name = "Btn_Edit"
        Btn_Edit.Size = New Size(160, 80)
        Btn_Edit.TabIndex = 5
        Btn_Edit.Text = "Editar"
        Btn_Edit.UseVisualStyleBackColor = False
        ' 
        ' Btn_New
        ' 
        Btn_New.BackColor = Color.SteelBlue
        Btn_New.Cursor = Cursors.Hand
        Btn_New.Font = New Font("Baloo", 11.999999F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Btn_New.ForeColor = Color.White
        Btn_New.Location = New Point(316, 246)
        Btn_New.Name = "Btn_New"
        Btn_New.Size = New Size(160, 80)
        Btn_New.TabIndex = 6
        Btn_New.Text = "Nuevo"
        Btn_New.UseVisualStyleBackColor = False
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
        TableLayoutPanel1.TabIndex = 44
        ' 
        ' Label8
        ' 
        Label8.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom
        Label8.AutoSize = True
        Label8.BackColor = Color.Transparent
        Label8.Font = New Font("Baloo", 23.9999981F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label8.ForeColor = Color.White
        Label8.Location = New Point(211, 0)
        Label8.Name = "Label8"
        Label8.Size = New Size(340, 50)
        Label8.TabIndex = 48
        Label8.Text = "Registro de Infantes"
        Label8.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Btn_ScreenList
        ' 
        Btn_ScreenList.BackColor = Color.SteelBlue
        Btn_ScreenList.Cursor = Cursors.Hand
        Btn_ScreenList.Font = New Font("Baloo", 11.999999F, FontStyle.Bold)
        Btn_ScreenList.ForeColor = Color.White
        Btn_ScreenList.Location = New Point(436, 382)
        Btn_ScreenList.Name = "Btn_ScreenList"
        Btn_ScreenList.Size = New Size(160, 80)
        Btn_ScreenList.TabIndex = 46
        Btn_ScreenList.Text = "Lista de Infantes"
        Btn_ScreenList.UseVisualStyleBackColor = False
        ' 
        ' MenuRegister
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.fondo_de_pantalla
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(786, 719)
        Controls.Add(Btn_ScreenList)
        Controls.Add(TableLayoutPanel1)
        Controls.Add(Btn_New)
        Controls.Add(Btn_Edit)
        MaximizeBox = False
        Name = "MenuRegister"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Kid Stimulation Register"
        TableLayoutPanel1.ResumeLayout(False)
        TableLayoutPanel1.PerformLayout()
        ResumeLayout(False)
    End Sub
    Friend WithEvents Btn_Edit As Button
    Friend WithEvents Btn_New As Button
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Label8 As Label
    Friend WithEvents Btn_ScreenList As Button
End Class
