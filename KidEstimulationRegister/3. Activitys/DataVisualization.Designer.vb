<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DataVisualization
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
        Dim ChartArea3 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend3 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series3 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        TableLayoutPanel1 = New TableLayoutPanel()
        Label8 = New Label()
        Lbl_Age = New Label()
        Btn_Save = New Button()
        Cb_Area = New ComboBox()
        Lbl_Name = New Label()
        Label2 = New Label()
        Tb_Name = New TextBox()
        Ch_ProgressKid = New System.Windows.Forms.DataVisualization.Charting.Chart()
        btn_Exit = New Button()
        TableLayoutPanel1.SuspendLayout()
        CType(Ch_ProgressKid, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
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
        ' Lbl_Age
        ' 
        Lbl_Age.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom
        Lbl_Age.BackColor = Color.LightSteelBlue
        Lbl_Age.Font = New Font("Baloo", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Lbl_Age.ForeColor = Color.White
        Lbl_Age.Location = New Point(550, 147)
        Lbl_Age.Name = "Lbl_Age"
        Lbl_Age.Size = New Size(181, 34)
        Lbl_Age.TabIndex = 68
        Lbl_Age.Text = "3 AÑOS - 6 MESES"
        Lbl_Age.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Btn_Save
        ' 
        Btn_Save.BackgroundImage = My.Resources.Resources.guardar
        Btn_Save.BackgroundImageLayout = ImageLayout.Stretch
        Btn_Save.Cursor = Cursors.Hand
        Btn_Save.FlatStyle = FlatStyle.Flat
        Btn_Save.ForeColor = SystemColors.ControlText
        Btn_Save.Location = New Point(677, 678)
        Btn_Save.Name = "Btn_Save"
        Btn_Save.Size = New Size(97, 35)
        Btn_Save.TabIndex = 83
        Btn_Save.UseVisualStyleBackColor = True
        ' 
        ' Cb_Area
        ' 
        Cb_Area.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        Cb_Area.BackColor = Color.LightSteelBlue
        Cb_Area.Cursor = Cursors.Hand
        Cb_Area.DrawMode = DrawMode.OwnerDrawVariable
        Cb_Area.DropDownStyle = ComboBoxStyle.DropDownList
        Cb_Area.Font = New Font("Segoe UI Semibold", 14.25F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Cb_Area.ForeColor = Color.SkyBlue
        Cb_Area.FormattingEnabled = True
        Cb_Area.Items.AddRange(New Object() {"Adaptativa", "Motriz Gruesa", "Motriz Fina", "Lenguaje", "Personal Social"})
        Cb_Area.Location = New Point(61, 148)
        Cb_Area.Name = "Cb_Area"
        Cb_Area.Size = New Size(166, 34)
        Cb_Area.TabIndex = 69
        ' 
        ' Lbl_Name
        ' 
        Lbl_Name.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom
        Lbl_Name.BackColor = Color.LightSteelBlue
        Lbl_Name.Font = New Font("Baloo", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Lbl_Name.ForeColor = Color.White
        Lbl_Name.Location = New Point(233, 148)
        Lbl_Name.Name = "Lbl_Name"
        Lbl_Name.Size = New Size(311, 34)
        Lbl_Name.TabIndex = 88
        Lbl_Name.Text = "Nombre"
        Lbl_Name.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Baloo", 11.999999F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.White
        Label2.Location = New Point(61, 193)
        Label2.Name = "Label2"
        Label2.Size = New Size(126, 25)
        Label2.TabIndex = 90
        Label2.Text = "Observaciones:"
        Label2.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Tb_Name
        ' 
        Tb_Name.BackColor = Color.LightSteelBlue
        Tb_Name.Cursor = Cursors.Hand
        Tb_Name.Font = New Font("Baloo", 11.999999F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Tb_Name.ForeColor = Color.WhiteSmoke
        Tb_Name.Location = New Point(193, 189)
        Tb_Name.Name = "Tb_Name"
        Tb_Name.Size = New Size(538, 33)
        Tb_Name.TabIndex = 91
        ' 
        ' Ch_ProgressKid
        ' 
        ChartArea3.Name = "ChartArea1"
        Ch_ProgressKid.ChartAreas.Add(ChartArea3)
        Legend3.Name = "Legend1"
        Ch_ProgressKid.Legends.Add(Legend3)
        Ch_ProgressKid.Location = New Point(273, 242)
        Ch_ProgressKid.Name = "Ch_ProgressKid"
        Series3.ChartArea = "ChartArea1"
        Series3.Legend = "Legend1"
        Series3.Name = "Series1"
        Ch_ProgressKid.Series.Add(Series3)
        Ch_ProgressKid.Size = New Size(300, 300)
        Ch_ProgressKid.TabIndex = 92
        ' 
        ' btn_Exit
        ' 
        btn_Exit.BackgroundImage = My.Resources.Resources.salir
        btn_Exit.BackgroundImageLayout = ImageLayout.Stretch
        btn_Exit.Cursor = Cursors.Hand
        btn_Exit.FlatStyle = FlatStyle.Flat
        btn_Exit.ForeColor = SystemColors.ControlText
        btn_Exit.Location = New Point(12, 678)
        btn_Exit.Name = "btn_Exit"
        btn_Exit.Size = New Size(97, 35)
        btn_Exit.TabIndex = 98
        btn_Exit.UseVisualStyleBackColor = True
        ' 
        ' DataVisualization
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.fondo_de_pantalla
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(786, 719)
        Controls.Add(btn_Exit)
        Controls.Add(Ch_ProgressKid)
        Controls.Add(Tb_Name)
        Controls.Add(Label2)
        Controls.Add(Lbl_Name)
        Controls.Add(Btn_Save)
        Controls.Add(TableLayoutPanel1)
        Controls.Add(Cb_Area)
        Controls.Add(Lbl_Age)
        MaximizeBox = False
        Name = "DataVisualization"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Kid Stimulation Register"
        TableLayoutPanel1.ResumeLayout(False)
        TableLayoutPanel1.PerformLayout()
        CType(Ch_ProgressKid, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Label8 As Label
    Friend WithEvents Lbl_Age As Label
    Friend WithEvents Btn_Save As Button
    Friend WithEvents Cb_Area As ComboBox
    Friend WithEvents Lbl_Name As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Tb_Name As TextBox
    Friend WithEvents Ch_ProgressKid As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents btn_Exit As Button
End Class
