Imports DataAccess
Public Class ScreenPrincipal

    Private Sub ScreenPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UpdateAges() ' Actualiza las edades de todos los infantes
        DeleteKids() ' Da de baja a todos los infantes que tengan mas de 5 años
        RoundAllButtons(Me) ' Redondea los bordes de los botones inferiores del formulario
    End Sub

    Private Sub btn_ScreenEvaluation_Click(sender As Object, e As EventArgs) Handles Btn_ScreenEvaluation.Click
        ScreenEvaluation.Show()
        Me.Hide()
    End Sub

    Private Sub btn_ScreenActivity_Click(sender As Object, e As EventArgs) Handles Btn_ScreenActivity.Click
        FindKidProgress.Show()
        Me.Hide()
    End Sub

    Private Sub btn_ScreenRegister_Click(sender As Object, e As EventArgs) Handles Btn_ScreenRegister.Click
        ScreenList.Show()
        Me.Hide()
    End Sub

    Private Sub UpdateAges()
        'Dim success As Boolean = WriteData("UPDATE Kids 
        '                                    SET Age_ID = (SELECT ID
        '                                    FROM Ages
        '                                    WHERE WeeksAge <= CAST((julianday(SUBSTR(DayBirth, 7, 4) || '-' || SUBSTR(DayBirth, 4, 2) || '-' || SUBSTR(DayBirth, 1, 2)) - julianday('now')) / -7 AS INT)
        '                                    ORDER BY WeeksAge DESC
        '                                    LIMIT 1)")
        Dim success As Boolean = WriteData("UPDATE Kids
                                            SET Age_ID = (SELECT ID
                                                          FROM Ages
                                                          WHERE MonthsAge <= ((CAST(strftime('%Y', 'now') AS INTEGER) - CAST(strftime('%Y', SUBSTR(DayBirth, 7, 4) || '-' || SUBSTR(DayBirth, 4, 2) || '-' || SUBSTR(DayBirth, 1, 2)) AS INTEGER)) * 12 +
                                                                              (CAST(strftime('%m', 'now') AS INTEGER) - CAST(strftime('%m', SUBSTR(DayBirth, 7, 4) || '-' || SUBSTR(DayBirth, 4, 2) || '-' || SUBSTR(DayBirth, 1, 2)) AS INTEGER)) )
                                                          ORDER BY MonthsAge DESC
                                                          LIMIT 1)")
        If Not success Then
            MessageBox.Show($"Ocurrió un error al actualizar las edades de los infantes{Environment.NewLine}Favor contactarse con el soporte del sistema", "Error de sistema", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub DeleteKids()
        Dim success As Boolean = WriteData("UPDATE Kids 
                                            SET Status = 0
                                            WHERE (julianday('now') - julianday(SUBSTR(DayBirth, 7, 4) || '-' || SUBSTR(DayBirth, 4, 2) || '-' || SUBSTR(DayBirth, 1, 2))) >= (5 * 365.25)")
        If Not success Then
            MessageBox.Show($"Ocurrió un error al eliminar a los infantes que tienen más de 5 años{Environment.NewLine}Favor contactarse con el soporte del sistema", "Error de sistema", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btn_Exit_Click(sender As Object, e As EventArgs) Handles btn_Exit.Click
        Dim confirmation As DialogResult

        Me.ActiveControl = Nothing ' Evita que se haga focus en el botón
        confirmation = MessageBox.Show($"¿Está seguro de que quiere cerrar el sistema?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If confirmation = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub

End Class
