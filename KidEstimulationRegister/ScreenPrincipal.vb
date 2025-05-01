Imports DataAccess
Public Class ScreenPrincipal

    Private Sub ScreenPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UpdateAges() ' Actualiza las edades de todos los infantes
    End Sub

    Private Sub btn_ScreenEvaluation_Click(sender As Object, e As EventArgs) Handles Btn_ScreenEvaluation.Click
        Me.Hide()
        ScreenEvaluation.Show()
    End Sub

    'Private Sub btn_ScreenActivity_Click(sender As Object, e As EventArgs) Handles btn_ScreenActivity.Click
    '    Me.Hide()
    '    ScreenEvaluation.Show()
    'End Sub

    Private Sub btn_ScreenRegister_Click(sender As Object, e As EventArgs) Handles Btn_ScreenRegister.Click
        Me.Hide()
        ScreenRegister.Show()
    End Sub

    Private Sub btn_Exit_Click(sender As Object, e As EventArgs) Handles btn_Exit.Click
        Me.Close()
    End Sub

    Private Sub Btn_ScreenList_Click(sender As Object, e As EventArgs) Handles Btn_ScreenList.Click
        Me.Hide()
        ScreenList.Show()
    End Sub

    Private Sub UpdateAges()
        Dim success As Boolean = WriteData("UPDATE Kids 
                                            SET Age_ID = (SELECT ID
                                            FROM Ages
                                            WHERE WeeksAge <= CAST((julianday(SUBSTR(DayBirth, 7, 4) || '-' || SUBSTR(DayBirth, 4, 2) || '-' || SUBSTR(DayBirth, 1, 2)) - julianday('now')) / -7 AS INT)
                                            ORDER BY WeeksAge DESC
                                            LIMIT 1)")
        If Not success Then
            MessageBox.Show($"Ocurrió un error al actualizar las edades de los infantes{Environment.NewLine}Favor contactarse con el soporte del sistema", "Error de sistema", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

End Class
