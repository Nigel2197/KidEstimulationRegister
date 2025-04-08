Imports System.Data
Imports System.IO
Imports System.Windows.Forms
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class KidEvaluation
    Private Sub OneMonth_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim MesesEdad As Integer = 1

        LabelLoad(MesesEdad)
        RadioButtonVisible()

    End Sub

    Public Sub LabelLoad(Edad As Integer)
        Select Case Edad
            Case 1
        End Select
    End Sub

    Public Sub RadioButtonVisible()
        'If lbl_adap1.Text = Nothing Then
        '    pnl_rb1.Visible = False
        'End If
        'If lbl_adap2.Text = Nothing Then
        '    pnl_rb2.Visible = False
        'End If
        'If lbl_adap3.Text = Nothing Then
        '    pnl_rb3.Visible = False
        'End If
        'If lbl_adap4.Text = Nothing Then
        '    pnl_rb4.Visible = False
        'End If
        'If lbl_adap5.Text = Nothing Then
        '    pnl_rb5.Visible = False
        'End If
        'If lbl_adap6.Text = Nothing Then
        '    pnl_rb6.Visible = False
        'End If
        'If lbl_adap7.Text = Nothing Then
        '    pnl_rb7.Visible = False
        'End If
        'If lbl_adap8.Text = Nothing Then
        '    pnl_rb8.Visible = False
        'End If
    End Sub

    Private Sub cb_Conducta_DrawItem(sender As Object, e As DrawItemEventArgs) Handles cb_Conducta.DrawItem
        If e.Index < 0 Then Exit Sub ' Evita errores si el ComboBox está vacío

        ' Definir colores
        Dim textColor As Color = Color.SkyBlue
        Dim bgColor As Color = Color.White

        ' Si el ítem está seleccionado, mantiene el mismo color de texto
        If (e.State And DrawItemState.Selected) = DrawItemState.Selected Then
            bgColor = Color.LightGray ' Color de fondo cuando se selecciona
        End If

        ' Dibujar fondo del ítem
        Using bgBrush As New SolidBrush(bgColor)
            e.Graphics.FillRectangle(bgBrush, e.Bounds)
        End Using

        ' Obtener el texto y calcular su posición para centrarlo
        Dim text As String = cb_Conducta.Items(e.Index).ToString()
        Dim textFont As Font = cb_Conducta.Font
        Dim textSize As SizeF = e.Graphics.MeasureString(text, textFont)

        ' Calcular la posición correcta para cada ítem
        Dim x As Integer = e.Bounds.Left + (e.Bounds.Width - textSize.Width) / 2
        Dim y As Integer = e.Bounds.Top + (e.Bounds.Height - textSize.Height) / 2

        ' Dibujar el texto centrado en su ítem correspondiente
        Using textBrush As New SolidBrush(textColor)
            e.Graphics.DrawString(text, textFont, textBrush, New PointF(x, y))
        End Using

        e.DrawFocusRectangle() ' Dibuja el rectángulo de selección si es necesario
    End Sub

    Private Sub cb_Conducta_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_Conducta.SelectedIndexChanged
        Me.ActiveControl = Nothing ' Quita el foco del ComboBox

    End Sub
End Class