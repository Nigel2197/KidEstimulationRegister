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

    Private Sub Btn_Delete_Click(sender As Object, e As EventArgs) Handles Btn_Delete.Click

    End Sub

End Class