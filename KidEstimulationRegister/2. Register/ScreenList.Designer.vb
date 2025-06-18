<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ScreenList
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
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ScreenList))
        TableLayoutPanel1 = New TableLayoutPanel()
        Label8 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        Label3 = New Label()
        Cb_Name = New ComboBox()
        TableLayoutPanel4 = New TableLayoutPanel()
        Dgv_KidList = New DataGridView()
        Nombre = New DataGridViewTextBoxColumn()
        Sexo = New DataGridViewTextBoxColumn()
        Años = New DataGridViewTextBoxColumn()
        Direccion = New DataGridViewTextBoxColumn()
        Sangre = New DataGridViewTextBoxColumn()
        btn_Back = New Button()
        Cb_Age = New ComboBox()
        Cb_Gender = New ComboBox()
        Btn_New = New Button()
        Btn_Find = New Button()
        Btn_Edit = New Button()
        btn_Exit = New Button()
        TableLayoutPanel1.SuspendLayout()
        TableLayoutPanel4.SuspendLayout()
        CType(Dgv_KidList, ComponentModel.ISupportInitialize).BeginInit()
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
        TableLayoutPanel1.TabIndex = 65
        ' 
        ' Label8
        ' 
        Label8.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom
        Label8.AutoSize = True
        Label8.BackColor = Color.Transparent
        Label8.Font = New Font("Baloo", 23.9999981F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label8.ForeColor = Color.White
        Label8.Location = New Point(303, 0)
        Label8.Name = "Label8"
        Label8.Size = New Size(155, 50)
        Label8.TabIndex = 48
        Label8.Text = "Infantes"
        Label8.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Baloo", 11.999999F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.White
        Label2.Location = New Point(55, 158)
        Label2.Name = "Label2"
        Label2.Size = New Size(75, 25)
        Label2.TabIndex = 69
        Label2.Text = "Nombre:"
        Label2.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Baloo", 11.999999F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = SystemColors.Window
        Label1.Location = New Point(574, 158)
        Label1.Name = "Label1"
        Label1.Size = New Size(51, 25)
        Label1.TabIndex = 71
        Label1.Text = "Sexo:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Baloo", 11.999999F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = SystemColors.Window
        Label3.Location = New Point(383, 158)
        Label3.Name = "Label3"
        Label3.Size = New Size(52, 25)
        Label3.TabIndex = 72
        Label3.Text = "Edad:"
        ' 
        ' Cb_Name
        ' 
        Cb_Name.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        Cb_Name.AutoCompleteMode = AutoCompleteMode.Suggest
        Cb_Name.AutoCompleteSource = AutoCompleteSource.ListItems
        Cb_Name.BackColor = Color.LightSteelBlue
        Cb_Name.Cursor = Cursors.Hand
        Cb_Name.DrawMode = DrawMode.OwnerDrawVariable
        Cb_Name.Font = New Font("Baloo", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Cb_Name.ForeColor = SystemColors.Window
        Cb_Name.FormattingEnabled = True
        Cb_Name.Location = New Point(55, 186)
        Cb_Name.Name = "Cb_Name"
        Cb_Name.Size = New Size(297, 29)
        Cb_Name.TabIndex = 1
        ' 
        ' TableLayoutPanel4
        ' 
        TableLayoutPanel4.BackColor = Color.LightSkyBlue
        TableLayoutPanel4.ColumnCount = 1
        TableLayoutPanel4.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel4.Controls.Add(Dgv_KidList, 0, 0)
        TableLayoutPanel4.Location = New Point(55, 225)
        TableLayoutPanel4.Name = "TableLayoutPanel4"
        TableLayoutPanel4.RowCount = 1
        TableLayoutPanel4.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel4.Size = New Size(676, 308)
        TableLayoutPanel4.TabIndex = 77
        ' 
        ' Dgv_KidList
        ' 
        Dgv_KidList.AllowUserToAddRows = False
        Dgv_KidList.AllowUserToDeleteRows = False
        Dgv_KidList.BackgroundColor = Color.AliceBlue
        Dgv_KidList.BorderStyle = BorderStyle.Fixed3D
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = Color.LightSkyBlue
        DataGridViewCellStyle1.Font = New Font("Baloo", 11.249999F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle1.ForeColor = SystemColors.Window
        DataGridViewCellStyle1.SelectionBackColor = Color.LightSkyBlue
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.Window
        Dgv_KidList.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Dgv_KidList.Columns.AddRange(New DataGridViewColumn() {Nombre, Sexo, Años, Direccion, Sangre})
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = Color.AliceBlue
        DataGridViewCellStyle2.Font = New Font("Baloo", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle2.ForeColor = Color.SkyBlue
        DataGridViewCellStyle2.SelectionBackColor = Color.AliceBlue
        DataGridViewCellStyle2.SelectionForeColor = Color.SkyBlue
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.False
        Dgv_KidList.DefaultCellStyle = DataGridViewCellStyle2
        Dgv_KidList.EnableHeadersVisualStyles = False
        Dgv_KidList.GridColor = Color.Black
        Dgv_KidList.Location = New Point(3, 3)
        Dgv_KidList.Name = "Dgv_KidList"
        Dgv_KidList.ReadOnly = True
        DataGridViewCellStyle3.BackColor = SystemColors.Control
        DataGridViewCellStyle3.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle3.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText
        Dgv_KidList.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Dgv_KidList.RowHeadersVisible = False
        Dgv_KidList.ShowEditingIcon = False
        Dgv_KidList.Size = New Size(670, 302)
        Dgv_KidList.TabIndex = 5
        ' 
        ' Nombre
        ' 
        Nombre.AutoSizeMode = DataGridViewAutoSizeColumnMode.None
        Nombre.DataPropertyName = "Nombre"
        Nombre.DividerWidth = 1
        Nombre.Frozen = True
        Nombre.HeaderText = "Nombre"
        Nombre.Name = "Nombre"
        Nombre.ReadOnly = True
        Nombre.Width = 215
        ' 
        ' Sexo
        ' 
        Sexo.AutoSizeMode = DataGridViewAutoSizeColumnMode.None
        Sexo.DataPropertyName = "Sexo"
        Sexo.DividerWidth = 1
        Sexo.Frozen = True
        Sexo.HeaderText = "Sexo"
        Sexo.MaxInputLength = 9
        Sexo.Name = "Sexo"
        Sexo.ReadOnly = True
        Sexo.Width = 77
        ' 
        ' Años
        ' 
        Años.AutoSizeMode = DataGridViewAutoSizeColumnMode.None
        Años.DataPropertyName = "Años"
        Años.DividerWidth = 1
        Años.Frozen = True
        Años.HeaderText = "Años"
        Años.Name = "Años"
        Años.ReadOnly = True
        Años.Width = 118
        ' 
        ' Direccion
        ' 
        Direccion.AutoSizeMode = DataGridViewAutoSizeColumnMode.None
        Direccion.DataPropertyName = "Direccion"
        Direccion.DividerWidth = 1
        Direccion.Frozen = True
        Direccion.HeaderText = "Dirección"
        Direccion.Name = "Direccion"
        Direccion.ReadOnly = True
        Direccion.Width = 175
        ' 
        ' Sangre
        ' 
        Sangre.AutoSizeMode = DataGridViewAutoSizeColumnMode.None
        Sangre.DataPropertyName = "Sangre"
        Sangre.DividerWidth = 1
        Sangre.Frozen = True
        Sangre.HeaderText = "Sangre"
        Sangre.MaxInputLength = 3
        Sangre.Name = "Sangre"
        Sangre.ReadOnly = True
        Sangre.Width = 65
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
        ' Cb_Age
        ' 
        Cb_Age.BackColor = Color.LightSteelBlue
        Cb_Age.Cursor = Cursors.Hand
        Cb_Age.DropDownStyle = ComboBoxStyle.DropDownList
        Cb_Age.FlatStyle = FlatStyle.Flat
        Cb_Age.Font = New Font("Baloo", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Cb_Age.ForeColor = SystemColors.Window
        Cb_Age.FormattingEnabled = True
        Cb_Age.Location = New Point(383, 186)
        Cb_Age.Name = "Cb_Age"
        Cb_Age.Size = New Size(159, 29)
        Cb_Age.TabIndex = 102
        ' 
        ' Cb_Gender
        ' 
        Cb_Gender.BackColor = Color.LightSteelBlue
        Cb_Gender.Cursor = Cursors.Hand
        Cb_Gender.DropDownStyle = ComboBoxStyle.DropDownList
        Cb_Gender.FlatStyle = FlatStyle.Flat
        Cb_Gender.Font = New Font("Baloo", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Cb_Gender.ForeColor = SystemColors.Window
        Cb_Gender.FormattingEnabled = True
        Cb_Gender.Items.AddRange(New Object() {"Masculino", "Femenino"})
        Cb_Gender.Location = New Point(574, 186)
        Cb_Gender.Name = "Cb_Gender"
        Cb_Gender.Size = New Size(157, 29)
        Cb_Gender.TabIndex = 103
        ' 
        ' Btn_New
        ' 
        Btn_New.BackColor = Color.Transparent
        Btn_New.BackgroundImage = My.Resources.Resources.nuevo
        Btn_New.BackgroundImageLayout = ImageLayout.Stretch
        Btn_New.Cursor = Cursors.Hand
        Btn_New.FlatAppearance.BorderSize = 0
        Btn_New.FlatStyle = FlatStyle.Flat
        Btn_New.ForeColor = Color.Transparent
        Btn_New.Location = New Point(540, 674)
        Btn_New.Name = "Btn_New"
        Btn_New.Size = New Size(118, 40)
        Btn_New.TabIndex = 104
        Btn_New.UseVisualStyleBackColor = False
        ' 
        ' Btn_Find
        ' 
        Btn_Find.BackColor = Color.Transparent
        Btn_Find.BackgroundImage = My.Resources.Resources.buscar
        Btn_Find.BackgroundImageLayout = ImageLayout.Stretch
        Btn_Find.Cursor = Cursors.Hand
        Btn_Find.FlatAppearance.BorderSize = 0
        Btn_Find.FlatStyle = FlatStyle.Flat
        Btn_Find.ForeColor = Color.Transparent
        Btn_Find.Location = New Point(664, 674)
        Btn_Find.Name = "Btn_Find"
        Btn_Find.Size = New Size(118, 40)
        Btn_Find.TabIndex = 100
        Btn_Find.UseVisualStyleBackColor = False
        ' 
        ' Btn_Edit
        ' 
        Btn_Edit.BackColor = Color.Transparent
        Btn_Edit.BackgroundImage = My.Resources.Resources.editar
        Btn_Edit.BackgroundImageLayout = ImageLayout.Stretch
        Btn_Edit.Cursor = Cursors.Hand
        Btn_Edit.FlatAppearance.BorderSize = 0
        Btn_Edit.FlatStyle = FlatStyle.Flat
        Btn_Edit.ForeColor = Color.Transparent
        Btn_Edit.Location = New Point(416, 674)
        Btn_Edit.Name = "Btn_Edit"
        Btn_Edit.Size = New Size(118, 40)
        Btn_Edit.TabIndex = 105
        Btn_Edit.UseVisualStyleBackColor = False
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
        btn_Exit.TabIndex = 106
        btn_Exit.UseVisualStyleBackColor = False
        ' 
        ' ScreenList
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.fondo_de_pantalla
        BackgroundImageLayout = ImageLayout.Stretch
        CancelButton = btn_Exit
        ClientSize = New Size(786, 719)
        Controls.Add(btn_Exit)
        Controls.Add(Btn_Edit)
        Controls.Add(Btn_New)
        Controls.Add(Cb_Gender)
        Controls.Add(Cb_Age)
        Controls.Add(Btn_Find)
        Controls.Add(btn_Back)
        Controls.Add(Cb_Name)
        Controls.Add(Label2)
        Controls.Add(TableLayoutPanel4)
        Controls.Add(Label3)
        Controls.Add(Label1)
        Controls.Add(TableLayoutPanel1)
        ForeColor = Color.SkyBlue
        FormBorderStyle = FormBorderStyle.FixedSingle
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MaximizeBox = False
        Name = "ScreenList"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Primeros Pasos"
        TableLayoutPanel1.ResumeLayout(False)
        TableLayoutPanel1.PerformLayout()
        TableLayoutPanel4.ResumeLayout(False)
        CType(Dgv_KidList, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Label8 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents Cb_Name As ComboBox
    Friend WithEvents Dgv_KidList As DataGridView
    Friend WithEvents Nombre As DataGridViewTextBoxColumn
    Friend WithEvents Sexo As DataGridViewTextBoxColumn
    Friend WithEvents Años As DataGridViewTextBoxColumn
    Friend WithEvents Direccion As DataGridViewTextBoxColumn
    Friend WithEvents Sangre As DataGridViewTextBoxColumn
    Friend WithEvents btn_Back As Button
    Friend WithEvents Cb_Age As ComboBox
    Friend WithEvents Cb_Gender As ComboBox
    Friend WithEvents Btn_New As Button
    Friend WithEvents Btn_Find As Button
    Friend WithEvents Btn_Edit As Button
    Friend WithEvents btn_Exit As Button
End Class
