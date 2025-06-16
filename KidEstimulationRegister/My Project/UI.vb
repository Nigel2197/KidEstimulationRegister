Module UI

    ' Redondea los bordes de todos los botones en un formulario
    Public Sub RoundAllButtons(contenedor As Control, Optional radio As Integer = 40)
        For Each ctrl As Control In contenedor.Controls
            If TypeOf ctrl Is Button Then
                Dim btn As Button = DirectCast(ctrl, Button)

                If btn.BackgroundImageLayout = ImageLayout.Stretch Then
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
                RoundAllButtons(ctrl, radio)
            End If
        Next
    End Sub
End Module
