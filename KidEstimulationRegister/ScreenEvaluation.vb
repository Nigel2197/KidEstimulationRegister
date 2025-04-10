Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class ScreenEvaluation
    Private Sub btn_ScreenEvaluation_Click(sender As Object, e As EventArgs) Handles btn_Evaluation.Click
        Me.Hide()
        KidEvaluation.Show()
    End Sub

    Private Sub ScreenEvaluation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' 1. Consulta y obtención del DataTable
        'Dim query As String = "SELECT Name, Age FROM Kids"
        'Dim dt As DataTable = GetData(query) ' Suponiendo que GetData es la función que llena el DataTable

        '' 2. Asignar el DataSource al ComboBox
        'ComboBox1.DataSource = dt

        '' 3. Configurar el campo a mostrar en el ComboBox
        'ComboBox1.DisplayMember = "Name"  ' El campo "Name" se mostrará en el ComboBox
        'ComboBox1.ValueMember = "Age"     ' El campo "Age" será el valor asociado (puedes usar otro campo si prefieres)

    End Sub
End Class