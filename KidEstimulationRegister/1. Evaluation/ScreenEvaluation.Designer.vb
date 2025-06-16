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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ScreenEvaluation))
        Label2 = New Label()
        Btn_Evaluation = New Button()
        Cb_Name = New ComboBox()
        TableLayoutPanel1 = New TableLayoutPanel()
        Label8 = New Label()
        btn_Back = New Button()
        btn_Exit = New Button()
        TableLayoutPanel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Baloo", 15.7499981F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.AliceBlue
        Label2.Location = New Point(216, 249)
        Label2.Name = "Label2"
        Label2.Size = New Size(358, 33)
        Label2.TabIndex = 3
        Label2.Text = "Introduzca el nombre del infante"
        ' 
        ' Btn_Evaluation
        ' 
        Btn_Evaluation.BackColor = Color.LightSkyBlue
        Btn_Evaluation.Cursor = Cursors.Hand
        Btn_Evaluation.Font = New Font("Baloo", 11.999999F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Btn_Evaluation.ForeColor = Color.White
        Btn_Evaluation.Location = New Point(315, 374)
        Btn_Evaluation.Name = "Btn_Evaluation"
        Btn_Evaluation.Size = New Size(160, 60)
        Btn_Evaluation.TabIndex = 5
        Btn_Evaluation.Text = "Evaluar"
        Btn_Evaluation.UseVisualStyleBackColor = False
        ' 
        ' Cb_Name
        ' 
        Cb_Name.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        Cb_Name.AutoCompleteMode = AutoCompleteMode.Suggest
        Cb_Name.AutoCompleteSource = AutoCompleteSource.ListItems
        Cb_Name.BackColor = Color.LightSteelBlue
        Cb_Name.Cursor = Cursors.Hand
        Cb_Name.DrawMode = DrawMode.OwnerDrawVariable
        Cb_Name.Font = New Font("Baloo", 11.999999F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Cb_Name.ForeColor = SystemColors.Window
        Cb_Name.FormattingEnabled = True
        Cb_Name.Location = New Point(214, 296)
        Cb_Name.Name = "Cb_Name"
        Cb_Name.Size = New Size(358, 34)
        Cb_Name.TabIndex = 6
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
        TableLayoutPanel1.TabIndex = 77
        ' 
        ' Label8
        ' 
        Label8.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom
        Label8.AutoSize = True
        Label8.BackColor = Color.Transparent
        Label8.Font = New Font("Baloo", 23.9999981F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label8.ForeColor = Color.White
        Label8.Location = New Point(285, 0)
        Label8.Name = "Label8"
        Label8.Size = New Size(191, 50)
        Label8.TabIndex = 48
        Label8.Text = "Evaluación"
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
        btn_Back.TabIndex = 98
        btn_Back.UseVisualStyleBackColor = False
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
        btn_Exit.TabIndex = 99
        btn_Exit.UseVisualStyleBackColor = False
        ' 
        ' ScreenEvaluation
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.fondo_de_pantalla
        BackgroundImageLayout = ImageLayout.Stretch
        CancelButton = btn_Exit
        ClientSize = New Size(786, 719)
        Controls.Add(btn_Exit)
        Controls.Add(btn_Back)
        Controls.Add(TableLayoutPanel1)
        Controls.Add(Cb_Name)
        Controls.Add(Btn_Evaluation)
        Controls.Add(Label2)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MaximizeBox = False
        Name = "ScreenEvaluation"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Primeros Pasos"
        TableLayoutPanel1.ResumeLayout(False)
        TableLayoutPanel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents Btn_Evaluation As Button
    Friend WithEvents Cb_Name As ComboBox
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Label8 As Label
    Friend WithEvents btn_Back As Button
    Friend WithEvents btn_Exit As Button
End Class
