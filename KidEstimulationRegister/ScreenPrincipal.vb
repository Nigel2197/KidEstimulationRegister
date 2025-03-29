Public Class ScreenPrincipal
    Private Sub btn_ScreenEvaluation_Click(sender As Object, e As EventArgs) Handles btn_ScreenEvaluation.Click
        Me.Hide()
        ScreenEvaluation.Show
    End Sub

    Private Sub btn_ScreenActivity_Click(sender As Object, e As EventArgs) Handles btn_ScreenActivity.Click
        Me.Hide()
        ScreenEvaluation.Show()
    End Sub

    Private Sub btn_ScreenRegister_Click(sender As Object, e As EventArgs) Handles btn_ScreenRegister.Click
        Me.Hide()
        ScreenRegister.Show()
    End Sub

    Private Sub btn_Exit_Click(sender As Object, e As EventArgs) Handles btn_Exit.Click
        Me.Close()
    End Sub
End Class
