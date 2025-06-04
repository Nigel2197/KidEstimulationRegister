Imports DataAccess

Public Class ScreenRegister

    ' Variables para el calculo de edad
    Dim today As Date = Date.Today 'Establece la fecha del dia actual
    Dim selectedDate As Date
    Dim totalDays As Double
    Dim weeksPassed As Integer

    Private Sub ScreenRegister_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
            confirmation = MessageBox.Show("¿Está seguro de que desea registrar los datos del infante?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If confirmation = DialogResult.Yes Then
                KidRegister()

                ' Cierra esta pantalla de creacion
                Dim frm As New MenuRegister()
                frm.Show()
                Me.Close()
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
            GetMonthsAgeKid()
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

    Private Sub LoadCalendar()
        Dtp_DayBirth.MaxDate = today
        Dtp_DayBirth.MinDate = today.AddYears(-5)
    End Sub

    Private Sub GetMonthsAgeKid()
        selectedDate = Dtp_DayBirth.Value
        today = Date.Today

        ' Calcular meses calendario exactos
        Dim monthsPassed As Integer = (today.Year - selectedDate.Year) * 12 + (today.Month - selectedDate.Month)

        ' Si aún no ha llegado el día del mes, restamos 1 (aún no cumplió el mes actual)
        If today.Day < selectedDate.Day Then
            monthsPassed -= 1
        End If

        ' Buscar en la tabla Ages por el valor más cercano menor o igual
        Dim query As String = "SELECT Age FROM Ages WHERE MonthsAge <= @monthAge ORDER BY MonthsAge DESC LIMIT 1"
        Dim parameters = New Dictionary(Of String, Object) From {{"@monthAge", monthsPassed}}

        Tb_Age.Text = ExecuteScalar(query, parameters)
    End Sub

    'Private Sub GetWeeksAgeKid()
    '    selectedDate = Dtp_DayBirth.Value ' Toma la fecha seleccionada
    '    totalDays = (today - selectedDate).TotalDays ' Trae el total de dias de nacimiento
    '    weeksPassed = Math.Floor(totalDays / 7) ' Calcula las semanas de nacimiento

    '    Tb_Age.Text = ExecuteScalar("SELECT Age FROM Ages WHERE WeeksAge <= @weeksage ORDER BY WeeksAge DESC LIMIT 1",
    '                                       New Dictionary(Of String, Object) From {{"@weeksage", weeksPassed}})
    'End Sub

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

    Private Sub btn_Exit_Click(sender As Object, e As EventArgs) Handles btn_Exit.Click
        Dim confirmation As DialogResult

        confirmation = MessageBox.Show($"¿Está seguro de que desea salir?{Environment.NewLine}{Environment.NewLine}El registro de los datos del infante no se guardará", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If confirmation = DialogResult.Yes Then
            Dim frm As New MenuRegister()
            frm.Show()
            Me.Close()
        End If
    End Sub
End Class