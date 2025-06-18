Module UI
    Private radio As Integer = 30 ' Radio por defecto para los bordes redondeados
    ' Redondea los bordes de todos los botones en un formulario
    Public Sub RoundAllButtons(contenedor As Control)
        For Each ctrl As Control In contenedor.Controls
            If TypeOf ctrl Is Button Then
                Dim btn As Button = DirectCast(ctrl, Button)

                If btn.Name = "btn_Back" Or btn.Name = "btn_Exit" Then
                    radio = 40
                    Dim path As New Drawing2D.GraphicsPath()
                    path.AddArc(0, 0, radio, radio, 180, 90)
                    path.AddArc(btn.Width - radio, 0, radio, radio, 270, 90)
                    path.AddArc(btn.Width - radio, btn.Height - radio, radio, radio, 0, 90)
                    path.AddArc(0, btn.Height - radio, radio, radio, 90, 90)
                    path.CloseAllFigures()

                    btn.Region = New Region(path)
                ElseIf btn.BackgroundImageLayout = ImageLayout.Stretch Then
                    radio = 30
                    Dim path As New Drawing2D.GraphicsPath()
                    path.AddArc(0, 0, radio, radio, 180, 90)
                    path.AddArc(btn.Width - radio, 0, radio, radio, 270, 90)
                    path.AddArc(btn.Width - radio, btn.Height - radio, radio, radio, 0, 90)
                    path.AddArc(0, btn.Height - radio, radio, radio, 90, 90)
                    path.CloseAllFigures()

                    btn.Region = New Region(path)
                End If

            ElseIf ctrl.HasChildren Then
                ' Recursividad para buscar en paneles, groupboxes, etc.
                RoundAllButtons(ctrl)
            End If
        Next
    End Sub
End Module
