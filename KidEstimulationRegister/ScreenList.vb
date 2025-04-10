Imports DataAccess

Public Class ScreenList
    Dim dt As DataTable

    ''Variables para las consultas a las bases de datos
    Dim query As String
    Dim where As New List(Of String)()
    Dim parameters As New Dictionary(Of String, Object)()
    Dim clauses As String

    Private Sub ScreenList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GetListKidName()
        LoadListKidName()
        'Cb_Name.Focus()
    End Sub

    Private Sub Cb_Name_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cb_Name.SelectedIndexChanged
        ' Si el combobox fue seleccionado avanza con la busqueda
        If Cb_Name.Focused Then
            FindKid()
        Else
            Exit Sub
        End If
    End Sub

    Private Sub Btn_FindKids_Click(sender As Object, e As EventArgs) Handles Btn_FindKids.Click
        FindKid()
    End Sub

    Private Sub GetListKidName()
        query = "SELECT Name FROM Kids"
        dt = GetData(query)
    End Sub

    Private Sub LoadListKidName()
        Cb_Name.DataSource = dt
        Cb_Name.DisplayMember = "Name"
        Cb_Name.SelectedIndex = -1
    End Sub

    Private Sub FindKid()
        query = "SELECT Name AS Nombre, Gender AS Sexo, WeeksAge AS [Edad (Semanas)], Address AS Dirección FROM Kids"

        ' Verifica si el parámetro @name tiene un valor y añade la condición correspondiente
        If Not String.IsNullOrEmpty(Cb_Name.Text) Then
            where.Add("Name LIKE @name")
            parameters.Add("@name", "%" & Cb_Name.Text & "%")
        End If

        ' Verifica si el parámetro @weeksage tiene un valor mayor a 0 y añade la condición correspondiente
        If Nud_WeeksAge.Value > 0 Then
            where.Add("WeeksAge = @weeksage")
            parameters.Add("@weeksage", Nud_WeeksAge.Value)
        End If

        ' Verifica si el parámetro @gender tiene un valor y añade la condición correspondiente
        If Not String.IsNullOrEmpty(Cb_Gender.Text) Then
            where.Add("Gender = @gender")
            parameters.Add("@gender", Cb_Gender.Text)
        End If

        If where.Count > 0 Then
            query &= " WHERE " & String.Join(" AND ", where)
        End If

        'dt = GetData("SELECT Name AS Nombre, Gender AS Sexo, WeeksAge AS [Edad (Semanas)], Address AS Dirección FROM Kids
        '                               WHERE Name LIKE IFNULL(NULLIF(@name, ''), Name)
        '                               AND WeeksAge = IFNULL(NULLIF(@weeksage, 0), WeeksAge)
        '                               AND Gender = IFNULL(NULLIF(@gender, ''), Gender)",
        '                               New Dictionary(Of String, Object) From {{"@name", Cb_Name.Text},
        '                                                                       {"@weeksage", Nud_WeeksAge.Value},
        '                                                                       {"@gender", Cb_Gender.Text}})

        dt = GetData(query, parameters)

        If dt IsNot Nothing Then
            Dgv_KidList.DataSource = Nothing
            Dgv_KidList.DataSource = dt
        Else
            MessageBox.Show("Error al consultar la vista.")
        End If
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

    'Private Sub Cb_Name_KeyDown(sender As Object, e As KeyEventArgs) Handles Cb_Name.KeyDown
    '    ' Verifica si se presionó la tecla Enter
    '    If e.KeyCode = Keys.Enter Then
    '        'FindKid()
    '        MessageBox.Show("Enter")
    '    End If
    'End Sub
End Class