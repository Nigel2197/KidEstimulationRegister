Imports DataAccess

Public Class ScreenEvaluation

    Private Sub ScreenEvaluation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GetListKidName()
        LoadListKidName()
    End Sub

    Private Sub Cb_Name_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cb_Name.SelectedIndexChanged
        ' Si el combobox fue seleccionado avanza con la busqueda
        If Cb_Name.Focused Then
            Btn_Evaluation_Click(Btn_Evaluation, EventArgs.Empty) ' Activa el boton de Evaluacion
        Else
            Exit Sub
        End If
    End Sub

    Private Sub Btn_Evaluation_Click(sender As Object, e As EventArgs) Handles Btn_Evaluation.Click
        If Not String.IsNullOrEmpty(Cb_Name.Text) Then
            Dim frm As New KidEvaluation(Cb_Name.Text) ' Pasa el valor directamente a la pantalla de Evaluacion de Infante
            Hide()
            frm.Show()
        Else
            MessageBox.Show("Favor seleccionar el Infante que va a evaluar")
        End If
    End Sub

    Private Sub GetListKidName()
        query = "SELECT Name FROM Kids"
        dt = GetData(query)
    End Sub

    Private Sub LoadListKidName()
        Cb_Name.DataSource = Nothing
        Cb_Name.DataSource = dt
        Cb_Name.DisplayMember = "Name" ' El campo "Name" se mostrará en el ComboBox
        Cb_Name.SelectedIndex = -1
    End Sub

    ''METODOS ESTETICOS (NO AFECTAN AL FLUJO DEL SISTEMA)

    Private Sub Cb_Name_DrawItem(sender As Object, e As DrawItemEventArgs) Handles Cb_Name.DrawItem
        If e.Index < 0 Then Exit Sub

        ' Colores personalizados
        Dim textColor As Color = Color.SkyBlue
        Dim bgColor As Color = Color.White

        ' Si está seleccionado, cambia el fondo pero mantiene el texto SkyBlue
        If (e.State And DrawItemState.Selected) = DrawItemState.Selected Then
            bgColor = Color.LightGray
        End If

        ' Fondo
        Using bgBrush As New SolidBrush(bgColor)
            e.Graphics.FillRectangle(bgBrush, e.Bounds)
        End Using

        ' Texto a mostrar
        Dim text As String = Cb_Name.GetItemText(Cb_Name.Items(e.Index))

        ' Dibuja el texto en su posición normal (sin centrar)
        Using textBrush As New SolidBrush(textColor)
            e.Graphics.DrawString(text, e.Font, textBrush, e.Bounds.X, e.Bounds.Y)
        End Using

        e.DrawFocusRectangle()
    End Sub

    Private Sub btn_Exit_Click(sender As Object, e As EventArgs) Handles btn_Exit.Click
        Dim frm As New ScreenPrincipal()
        frm.Show()
        Me.Dispose()
    End Sub
End Class