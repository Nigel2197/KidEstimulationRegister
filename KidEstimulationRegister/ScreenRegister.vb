Imports DataAccess

Public Class ScreenRegister
    Dim dt As DataTable

    ''Variables para las consultas a las bases de datos
    Dim query As String
    Dim where As New List(Of String)()
    Dim parameters As New Dictionary(Of String, Object)()
    Dim clauses As String

    ' Variables para el calculo de edad
    Dim today As Date = Date.Today 'Establece la fecha del dia actual
    Dim selectedDate As Date
    Dim totalDays As Double
    Dim weeksPassed As Integer

    Private Sub ScreenRegister_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GetListWeeksAge()
        LoadCalendar()
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
                KidRegister()
            Else
                Return
            End If
        Else
            MessageBox.Show("Favor completar los datos faltantes para proceder con el registro del infante", "Faltan datos", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

    End Sub

    Private Sub Dtp_DayBirth_ValueChanged(sender As Object, e As EventArgs) Handles Dtp_DayBirth.ValueChanged

        ' Si el combobox fue seleccionado avanza con la busqueda
        If Dtp_DayBirth.Focused Then
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
        Else
            Tb_WhatAllergy.Enabled = False
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

    Private Sub KidRegister()
        Dim ageID As Integer = ExecuteScalar("SELECT ID FROM Ages WHERE Age = @weeksage",
                                           New Dictionary(Of String, Object) From {{"@weeksage", Tb_Age.Text}})

        Dim success As Boolean = WriteData("INSERT INTO Kids (Name, Gender, DayBirth, Age_ID, Address, BloodType, Allergic, WhatAllergy, Status)
                                            VALUES (@name, @gender, @daybirth, @ageid, @address, @bloodtype, @allergic, @whatallergy, @status)",
                                           New Dictionary(Of String, Object) From {{"@name", Tb_Name.Text},
                                                                                   {"@gender", Cb_Gender.Text},
                                                                                   {"@daybirth", Dtp_DayBirth.Text},
                                                                                   {"@ageid", ageID},
                                                                                   {"@address", Tb_Address.Text},
                                                                                   {"@bloodtype", Cb_BloodType.Text},
                                                                                   {"@allergic", Ckb_Allergic.Checked},
                                                                                   {"@whatallergy", Tb_WhatAllergy.Text},
                                                                                   {"@status", 1}})
        If success Then
            MessageBox.Show("Se registraron los datos del infante correctamente", "Registro aceptado", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("Error al ejecutar procedimiento.", "Registro rechazado", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End If

    End Sub

End Class