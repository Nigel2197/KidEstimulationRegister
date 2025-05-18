Imports DataAccess

Public Class MenuRegister

    Private Sub Btn_Add_Click(sender As Object, e As EventArgs) Handles Btn_New.Click
        Me.Hide()
        ScreenRegister.Show()
    End Sub

    Private Sub Btn_Edit_Click(sender As Object, e As EventArgs) Handles Btn_Edit.Click
        Me.Hide()
        KidEdit.Show()
    End Sub

    Private Sub Btn_ScreenList_Click(sender As Object, e As EventArgs) Handles Btn_ScreenList.Click
        Me.Hide()
        ScreenList.Show()
    End Sub

    Private Sub btn_Exit_Click(sender As Object, e As EventArgs) Handles btn_Exit.Click
        Dim frm As New ScreenPrincipal()
        frm.Show()
        Me.Close()
    End Sub
End Class