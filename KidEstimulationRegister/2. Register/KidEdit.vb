Imports System.Globalization
Imports DataAccess

Public Class KidEdit

    Private NameKid As String
    Private KidID As Integer
    Private AgeID As Integer
    Private WhatAllergy As String

    '''Variables para las consultas a las bases de datos
    'Dim query As String
    'Dim where As New List(Of String)()
    'Dim parameters As New Dictionary(Of String, Object)()
    'Dim clauses As String

    ' Variables para el calculo de edad
    Dim today As Date = Date.Today 'Establece la fecha del dia actual
    Dim selectedDate As Date
    Dim totalDays As Double
    Dim weeksPassed As Integer

    Private Sub KidEdit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GetListKidName()
        LoadListKidName()
    End Sub

    Private Sub Cb_Name_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cb_Name.SelectedIndexChanged
        ' Si el combobox fue seleccionado avanza con la busqueda
        If Cb_Name.Focused Then
            NameKid = Cb_Name.Text
            FindKidData() ' Busca la informacion personal del infante
            LoadKidData() ' Carga la informacion y la muestra en pantalla
            LoadCalendar() ' Carga la fecha minima y maxima del calendario de cumpleaños
            WhatAllergy = Tb_WhatAllergy.Text
            Cb_Name.Visible = False
            Tb_Name.Visible = True
        Else
            Exit Sub
        End If
    End Sub

    Private Sub btn_Save_Click(sender As Object, e As EventArgs) Handles btn_Save.Click
        Dim validation As Boolean = True
        Dim confirmation As DialogResult

        If String.IsNullOrWhiteSpace(Tb_Name.Text) Then
            MessageBox.Show("Falta indicar el nombre del infante", "Faltan datos", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            validation = False
            Return
        End If

        If String.IsNullOrWhiteSpace(Dtp_DayBirth.Text) Then
            MessageBox.Show("Falta indicar la fecha de nacimiento del infante", "Faltan datos", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            validation = False
            Return
        End If

        If String.IsNullOrWhiteSpace(Dtp_DayBirth.Text) Then
            MessageBox.Show("Falta indicar la dirección del infante", "Faltan datos", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            validation = False
            Return
        End If

        If validation Then
            confirmation = MessageBox.Show("¿Estás seguro de que deseas registrar los datos del infante?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If confirmation = DialogResult.Yes Then
                UpdateKidRegister()
            Else
                Return
            End If
        Else
            MessageBox.Show("Favor completar los datos faltantes para proceder con la edición del registro del infante", "Faltan datos", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

    End Sub

    Private Sub Dtp_DayBirth_ValueChanged(sender As Object, e As EventArgs) Handles Dtp_DayBirth.ValueChanged
        ' Si el combobox fue seleccionado avanza con la busqueda
        If NameKid IsNot Nothing Then
            Dtp_DayBirth.Format = DateTimePickerFormat.Custom
            Dtp_DayBirth.CustomFormat = "dd/MM/yyyy" ' Cambia al formato dia/mes/año
            GetWeeksAgeKid()
        Else
            Exit Sub
        End If
    End Sub

    Private Sub Ckb_Allergic_CheckedChanged(sender As Object, e As EventArgs) Handles Ckb_Allergic.CheckedChanged
        If Ckb_Allergic.Checked Then
            Tb_WhatAllergy.Enabled = True
            Tb_WhatAllergy.Text = WhatAllergy
        Else
            Tb_WhatAllergy.Enabled = False
            Tb_WhatAllergy.Text = Nothing
        End If
    End Sub

    Private Sub GetListKidName()
        query = "SELECT Name FROM Kids"
        dt = GetData(query)
    End Sub

    Private Sub LoadListKidName()
        Cb_Name.DataSource = Nothing
        Cb_Name.DataSource = dt
        Cb_Name.DisplayMember = "Name" ' El campo "Name" se mostrará en el ComboBox
        Cb_Name.SelectedIndex = -1
    End Sub

    Private Sub FindKidData() ' Busca los datos personales del infante
        where = New List(Of String)() ' Se vacian los filtros utilizados
        parameters = New Dictionary(Of String, Object)() ' Se vacian los parametros utilizados

        query = "SELECT K.ID AS Kid_ID, K.Gender, K.DayBirth, A.Age, K.Address, K.BloodType, K.Allergic, K.WhatAllergy
                 FROM Kids K
                 JOIN Ages A ON K.Age_ID = A.ID "

        where.Add("Name = @name")
        parameters.Add("@name", NameKid)

        query &= "WHERE " & String.Join("", where)

        dt = GetData(query, parameters)
    End Sub

    Private Sub LoadKidData() ' Muestra en pantalla los datos personales del infante
        If dt IsNot Nothing Then
            Tb_Name.Text = Cb_Name.Text
            Cb_Gender.Text = dt.Rows(0)("Gender").ToString()
            Dtp_DayBirth.Value = DateTime.ParseExact(dt.Rows(0)("DayBirth").ToString(), "dd/MM/yyyy", CultureInfo.InvariantCulture)
            Tb_Age.Text = dt.Rows(0)("Age").ToString()
            Tb_Address.Text = dt.Rows(0)("Address").ToString()
            Cb_BloodType.Text = dt.Rows(0)("BloodType").ToString()
            Ckb_Allergic.Checked = Convert.ToBoolean(dt.Rows(0)("Allergic"))
            Tb_WhatAllergy.Text = dt.Rows(0)("WhatAllergy").ToString()
        Else
            MessageBox.Show("Error al consultar los datos del infante")
        End If
    End Sub

    Private Sub GetListWeeksAge()
        query = "SELECT Age FROM Ages"
        dt = GetData(query)
    End Sub

    Private Sub LoadCalendar()
        Dtp_DayBirth.MaxDate = today
        Dtp_DayBirth.MinDate = today.AddYears(-5)
    End Sub

    Private Sub GetWeeksAgeKid()
        selectedDate = Dtp_DayBirth.Value ' Toma la fecha seleccionada
        totalDays = (today - selectedDate).TotalDays ' Trae el total de dias de nacimiento
        weeksPassed = Math.Floor(totalDays / 7) ' Calcula las semanas de nacimiento

        Tb_Age.Text = ExecuteScalar("SELECT Age FROM Ages WHERE WeeksAge <= @weeksage ORDER BY WeeksAge DESC LIMIT 1",
                                           New Dictionary(Of String, Object) From {{"@weeksage", weeksPassed}})
    End Sub

    Private Sub UpdateKidRegister()
        Dim ageID As Integer = ExecuteScalar("SELECT ID FROM Ages WHERE Age = @weeksage",
                                           New Dictionary(Of String, Object) From {{"@weeksage", Tb_Age.Text}})

        Dim success As Boolean = WriteData("UPDATE Kids SET Name = @name, Gender = @gender, DayBirth = @daybirth, Age_ID = @ageid, Address = @address, BloodType = @bloodtype, Allergic = @allergic, WhatAllergy = @whatallergy
                                            WHERE Name = @nameorigin",
                                           New Dictionary(Of String, Object) From {{"@name", Tb_Name.Text},
                                                                                   {"@gender", Cb_Gender.Text},
                                                                                   {"@daybirth", Dtp_DayBirth.Text},
                                                                                   {"@ageid", ageID},
                                                                                   {"@address", Tb_Address.Text},
                                                                                   {"@bloodtype", Cb_BloodType.Text},
                                                                                   {"@allergic", Ckb_Allergic.Checked},
                                                                                   {"@whatallergy", Tb_WhatAllergy.Text},
                                                                                   {"@nameorigin", Cb_Name.Text}})
        If success Then
            MessageBox.Show("Se registraron los datos del infante correctamente", "Registro aceptado", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("Error al ejecutar procedimiento.", "Registro rechazado", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End If

    End Sub

    Private Sub btn_Exit_Click(sender As Object, e As EventArgs) Handles btn_Exit.Click
        Dim confirmation As DialogResult

        confirmation = MessageBox.Show($"¿Está seguro de que desea salir?{Environment.NewLine}{Environment.NewLine}Los cambios realizados en los datos del infante no se guardarán", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If confirmation = DialogResult.Yes Then
            Dim frm As New MenuRegister()
            frm.Show()
            Me.Close()
        End If
    End Sub
End Class