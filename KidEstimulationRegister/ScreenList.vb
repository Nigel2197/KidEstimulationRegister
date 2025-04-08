Imports System.Data
Imports System.IO
Imports System.Windows.Forms
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports DataAccess

Public Class ScreenList
    Private Sub Btn_FindKids_Click(sender As Object, e As EventArgs) Handles Btn_FindKids.Click
        KidList()
    End Sub

    Private Sub KidList()
        Dim dt As DataTable = GetData("SELECT Name AS Nombre, Gender AS Sexo, WeeksAge AS [Edad (Semanas)], Address AS Dirección 
                                       FROM Kids 
                                       WHERE Name = @name 
                                       AND WeeksAge = @weeksage
                                       AND Gender = @gender",
                                       New Dictionary(Of String, Object) From {{"@name", Tb_Name.Text},
                                                                               {"@weeksage", Nud_WeeksAge.Value},
                                                                               {"@gender", Cb_Gender.Text}})
        If dt IsNot Nothing Then
            Dgv_KidList.DataSource = dt
        Else
            MessageBox.Show("Error al consultar la vista.")
        End If
    End Sub

End Class