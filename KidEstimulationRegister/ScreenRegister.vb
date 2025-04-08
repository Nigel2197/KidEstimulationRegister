Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports DataAccess

Public Class ScreenRegister
    Dim today As Date = Date.Today 'Establece la fecha del dia actual

    Private Sub ScreenRegister_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dtp_DayBirth.MaxDate = today
        Dtp_DayBirth.MinDate = today.AddYears(-5)
    End Sub

    Private Sub btn_Save_Click(sender As Object, e As EventArgs) Handles btn_Save.Click
        Dim validation As Boolean = True
        Dim result As DialogResult

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
            result = MessageBox.Show("¿Estás seguro de que deseas registrar los datos del infante?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result = DialogResult.Yes Then
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
        Dim selectedDate As Date = Dtp_DayBirth.Value
        Dim totalDays As Double = (today - selectedDate).TotalDays
        Dim weeksPassed As Integer = Math.Floor(totalDays / 7)

        Nud_WeeksAge.Value = weeksPassed

        Dtp_DayBirth.Format = DateTimePickerFormat.Custom
        Dtp_DayBirth.CustomFormat = "dd/MM/yyyy" ' Cambia al formato dia/mes/año
    End Sub

    Private Sub KidRegister()
        Dim success As Boolean = WriteData("INSERT INTO Kids (Name, Gender, DayBirth, WeeksAge, Address, BloodType, Allergic, WhatAllergy, TutorName, Status)
                                            VALUES (@name, @gender, @daybirth, @weeksage, @address, @bloodtype, @allergic, @whatallergy, @tutorname, @status)",
                                           New Dictionary(Of String, Object) From {{"@name", Tb_Name.Text},
                                                                                   {"@gender", Cb_Gender.Text},
                                                                                   {"@daybirth", Dtp_DayBirth.Text},
                                                                                   {"@weeksage", Nud_WeeksAge.Text},
                                                                                   {"@address", Tb_Address.Text},
                                                                                   {"@bloodtype", Cb_BloodType.Text},
                                                                                   {"@allergic", Ckb_Allergic.Checked},
                                                                                   {"@whatallergy", Tb_WhatAllergy.Text},
                                                                                   {"@tutorname", Tb_TutorName.Text},
                                                                                   {"@status", 1}})
        If success Then
            MessageBox.Show("Se registraron los datos del infante correctamente", "Registro aceptado", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("Error al ejecutar procedimiento.", "Registro rechazado", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End If

    End Sub

    Private Sub Ckb_Allergic_CheckedChanged(sender As Object, e As EventArgs) Handles Ckb_Allergic.CheckedChanged
        If Ckb_Allergic.Checked Then
            Tb_WhatAllergy.Enabled = True
        Else
            Tb_WhatAllergy.Enabled = False
        End If
    End Sub
End Class