Imports DataAccess
Imports System.Windows.Forms

Public Class ScreenPrincipal

    Private Sub ScreenPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim backupPath As String = My.Settings.BackupPath

        ' Si no hay ruta guardada, pedirla al usuario solo la primera vez
        If String.IsNullOrWhiteSpace(backupPath) OrElse Not IO.Directory.Exists(backupPath) Then
            MessageBox.Show($"Por favor, seleccione la carpeta donde desea guardar la copia de seguridad de la base de datos.{Environment.NewLine}{Environment.NewLine}Esta acción solo se solicitará la primera vez que use el programa.", "Configuración de Backup", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Using fbd As New FolderBrowserDialog()
                If fbd.ShowDialog() = DialogResult.OK Then
                    backupPath = fbd.SelectedPath
                    My.Settings.BackupPath = backupPath
                    My.Settings.Save()
                Else
                    MessageBox.Show($"Debe seleccionar una carpeta para el backup.{Environment.NewLine}El programa se cerrará.", "Backup obligatorio", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Application.Exit()
                    Return
                End If
            End Using
        End If

        CopyDataBase(backupPath) 'Realiza una copía de la base de datos que sirva como backup
        UpdateAges() ' Actualiza las edades de todos los infantes
        DeleteKids() ' Da de baja a todos los infantes que tengan mas de 5 años
        RoundAllButtons(Me) ' Redondea los bordes de los botones inferiores del formulario
    End Sub

    Private Sub btn_ScreenEvaluation_Click(sender As Object, e As EventArgs) Handles Btn_ScreenEvaluation.Click
        Dim frm As New ScreenEvaluation()
        frm.Show()
        Me.Hide()
    End Sub

    Private Sub btn_ScreenActivity_Click(sender As Object, e As EventArgs) Handles Btn_ScreenActivity.Click
        Dim frm As New FindKidProgress()
        frm.Show()
        Me.Hide()
    End Sub

    Private Sub btn_ScreenList_Click(sender As Object, e As EventArgs) Handles Btn_ScreenList.Click
        Dim frm As New ScreenList()
        frm.Show()
        Me.Hide()
    End Sub

    Private Sub CopyDataBase(backupPath As String)
        Try
            Dim origen As String = IO.Path.Combine(Application.StartupPath, "KERDB.db")
            Dim destino As String = IO.Path.Combine(backupPath, "KERDB_backup.db")

            ' Si el backup ya existe, intenta eliminarlo primero
            If IO.File.Exists(destino) Then
                Try
                    IO.File.SetAttributes(destino, IO.FileAttributes.Normal) ' Quita atributos de solo lectura/oculto si los tiene
                    IO.File.Delete(destino)
                Catch ex As Exception
                    MessageBox.Show("No se pudo eliminar el backup anterior: " & ex.Message)
                    Return
                End Try
            End If

            IO.File.Copy(origen, destino, True)

            ' Ocultar ambos archivos
            If IO.File.Exists(origen) Then
                IO.File.SetAttributes(origen, IO.File.GetAttributes(origen) Or IO.FileAttributes.Hidden)
            End If
            If IO.File.Exists(destino) Then
                IO.File.SetAttributes(destino, IO.File.GetAttributes(destino) Or IO.FileAttributes.Hidden)
            End If
        Catch ex As Exception
            MessageBox.Show("Error al copiar la base de datos: " & ex.Message)
        End Try
    End Sub

    Private Sub UpdateAges()
        'Dim success As Boolean = WriteData("UPDATE Kids
        '                                    SET Age_ID = (SELECT ID
        '                                                  FROM Ages
        '                                                  WHERE MonthsAge <= ((CAST(strftime('%Y', 'now') AS INTEGER) - CAST(strftime('%Y', SUBSTR(DayBirth, 7, 4) || '-' || SUBSTR(DayBirth, 4, 2) || '-' || SUBSTR(DayBirth, 1, 2)) AS INTEGER)) * 12 +
        '                                                                      (CAST(strftime('%m', 'now') AS INTEGER) - CAST(strftime('%m', SUBSTR(DayBirth, 7, 4) || '-' || SUBSTR(DayBirth, 4, 2) || '-' || SUBSTR(DayBirth, 1, 2)) AS INTEGER)) )
        '                                                  ORDER BY MonthsAge DESC
        '                                                  LIMIT 1)")
        Dim success As Boolean = WriteData("UPDATE Kids
                                            SET Age_ID = (
                                                SELECT ID
                                                FROM Ages
                                                WHERE MonthsAge <= (
                                                    (CAST(strftime('%Y', 'now') AS INTEGER) - CAST(strftime('%Y', SUBSTR(DayBirth, 7, 4) || '-' || SUBSTR(DayBirth, 4, 2) || '-' || SUBSTR(DayBirth, 1, 2)) AS INTEGER)) * 12
                                                    + (CAST(strftime('%m', 'now') AS INTEGER) - CAST(strftime('%m', SUBSTR(DayBirth, 7, 4) || '-' || SUBSTR(DayBirth, 4, 2) || '-' || SUBSTR(DayBirth, 1, 2)) AS INTEGER))
                                                    - CASE
                                                        WHEN CAST(strftime('%d', 'now') AS INTEGER) < CAST(SUBSTR(DayBirth, 1, 2) AS INTEGER) THEN 1
                                                        ELSE 0
                                                      END
                                                )
                                                ORDER BY MonthsAge DESC
                                                LIMIT 1
                                            )")
        If Not success Then
            MessageBox.Show($"Ocurrió un error al actualizar las edades de los infantes{Environment.NewLine}Favor contactarse con el soporte del sistema", "Error de sistema", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub DeleteKids()
        Dim success As Boolean = WriteData("UPDATE Kids 
                                            SET Status = 0
                                            WHERE (julianday('now') - julianday(SUBSTR(DayBirth, 7, 4) || '-' || SUBSTR(DayBirth, 4, 2) || '-' || SUBSTR(DayBirth, 1, 2))) >= (5 * 365.25)")
        If Not success Then
            MessageBox.Show($"Ocurrió un error al eliminar a los infantes que tienen más de 5 años{Environment.NewLine}Favor contactarse con el soporte del sistema", "Error de sistema", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub ResetSettings()
        If MessageBox.Show("¿Está seguro de que desea restablecer la configuración de usuario? Se perderá la ruta de backup y deberá seleccionarla nuevamente al reiniciar.", "Restablecer configuración", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
            My.Settings.Reset()
            My.Settings.Save()
            MessageBox.Show("La configuración de usuario ha sido restablecida. El programa se cerrará.", "Configuración restablecida", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Application.Exit()
        End If
    End Sub

    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, keyData As Keys) As Boolean
        If keyData = (Keys.Control Or Keys.Alt Or Keys.Shift Or Keys.F1) Then ' Se activa al presionar las teclas Control + Alt + Shift + F1
            ResetSettings()
            Return True ' Indica que la tecla fue manejada
        End If
        Return MyBase.ProcessCmdKey(msg, keyData)
    End Function

    Private Sub btn_Exit_Click(sender As Object, e As EventArgs) Handles btn_Exit.Click
        Dim confirmation As DialogResult

        Me.ActiveControl = Nothing ' Evita que se haga focus en el botón
        confirmation = MessageBox.Show($"¿Está seguro de que quiere cerrar el sistema?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If confirmation = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub

    'Private Sub ScreenPrincipal_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
    '    Dim confirmation As DialogResult

    '    Me.ActiveControl = Nothing
    '    confirmation = MessageBox.Show($"¿Está seguro de que quiere cerrar el sistema?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

    '    If confirmation = DialogResult.Yes Then
    '    ' Cierra todos los formularios abiertos
    '    For Each frm As Form In Application.OpenForms.OfType(Of Form)().ToList()
    '        frm.Close()
    '    Next
    '        Application.Exit()
    '    Else
    '        e.Cancel = True ' Cancela el cierre si el usuario elige No
    '    End If
    'End Sub

End Class
