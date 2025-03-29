Imports System.Data
Imports System.IO
Imports ExcelDataReader
Imports System.Windows.Forms

Public Class Adaptive
    Private Sub Adaptive_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim MesesEdad As Integer = 1

        LabelLoad(MesesEdad)
        RadioButtonVisible()

    End Sub

    Public Sub LabelLoad(Edad As Integer)
        Select Case Edad
            Case 1
                lbl_adap1.Text = "Arcg. Son: mira únicamente cuando están en línea de visión"
                lbl_adap2.Text = "Arcg: lo sigue con la mirada hacia la línea media"
                lbl_adap3.Text = "Son: Cae inmediatamente de la mano"
                lbl_adap4.Text = "Camp: escucha, actividad disminuye"
                lbl_adap5.Text = Nothing
                lbl_adap6.Text = Nothing
                lbl_adap7.Text = Nothing
                lbl_adap8.Text = Nothing
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

End Class