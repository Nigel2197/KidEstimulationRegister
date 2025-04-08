Public Class ScreenPrincipal
    Private Sub btn_ScreenEvaluation_Click(sender As Object, e As EventArgs) Handles Btn_ScreenEvaluation.Click
        Me.Hide()
        ScreenEvaluation.Show
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

    End Sub
End Class
