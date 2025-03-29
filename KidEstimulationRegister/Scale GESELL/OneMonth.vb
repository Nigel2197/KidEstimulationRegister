Imports System.Data
Imports System.IO
Imports ExcelDataReader
Imports System.Windows.Forms

Public Class OneMonth
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

    Private Sub TableLayoutPanel1_Paint(sender As Object, e As PaintEventArgs) Handles TableLayoutPanel1.Paint
        Dim colorSeparador As Color = Color.LightSkyBlue ' Color celeste suave
        Dim grosor As Integer = 5 ' Grosor de las líneas

        Using pen As New Pen(colorSeparador, grosor)
            ' Dibujar líneas verticales (Columnas)
            For i As Integer = 1 To TableLayoutPanel1.ColumnCount - 1
                Dim x As Integer = TableLayoutPanel1.GetColumnWidths().Take(i).Sum()
                e.Graphics.DrawLine(pen, x, 0, x, TableLayoutPanel1.Height)
            Next

            ' Dibujar líneas horizontales (Filas)
            For i As Integer = 1 To TableLayoutPanel1.RowCount - 1
                Dim y As Integer = TableLayoutPanel1.GetRowHeights().Take(i).Sum()
                e.Graphics.DrawLine(pen, 0, y, TableLayoutPanel1.Width, y)
            Next
        End Using
    End Sub
End Class