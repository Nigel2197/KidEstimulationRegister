Imports DataAccess

Public Class ScreenList

    Private Sub ScreenList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GetListKidName()
        LoadListKidName()
        GetListWeeksAge()
        LoadListWeeksAge()
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

    Private Sub GetListWeeksAge()
        query = "SELECT WeeksAge FROM Ages"
        dt = GetData(query)
    End Sub

    Private Sub LoadListWeeksAge()
        Cb_WeeksAge.DataSource = dt
        Cb_WeeksAge.DisplayMember = "WeeksAge"
        Cb_WeeksAge.SelectedIndex = -1
    End Sub

    Private Sub FindKid()
        query = "SELECT Name AS Nombre, Gender AS Sexo, A.Age AS Años, Address AS Direccion, BloodType AS Sangre
                 FROM Kids K
                 JOIN Ages A ON K.Age_ID = A.ID "

        where = New List(Of String)() ' Se vacian los filtros utilizados
        parameters = New Dictionary(Of String, Object)() ' Se vacian los parametros utilizados

        ' Verifica si el parámetro @name tiene un valor y añade la condición correspondiente
        If Not String.IsNullOrEmpty(Cb_Name.Text) Then
            where.Add("Name LIKE @name")
            parameters.Add("@name", "%" & Cb_Name.Text & "%")
        End If

        ' Verifica si el parámetro @weeksage tiene un valor mayor a 0 y añade la condición correspondiente
        If Not String.IsNullOrEmpty(Cb_WeeksAge.Text) Then
            where.Add("WeeksAge = @weeksage")
            parameters.Add("@weeksage", Cb_WeeksAge.Text)
        End If

        ' Verifica si el parámetro @gender tiene un valor y añade la condición correspondiente
        If Not String.IsNullOrEmpty(Cb_Gender.Text) Then
            where.Add("Gender = @gender")
            parameters.Add("@gender", Cb_Gender.Text)
        End If

        If where.Count > 0 Then
            query &= "WHERE " & String.Join(" AND ", where)
        End If

        dt = GetData(query, parameters)

        If dt IsNot Nothing Then
            LoadDataListKid()
        Else
            MessageBox.Show("Error al consultar la vista")
        End If
    End Sub

    Private Sub LoadDataListKid()
        Dgv_KidList.DataSource = Nothing

        If dt IsNot Nothing Then
            Dgv_KidList.AutoGenerateColumns = False
            Dgv_KidList.DataSource = dt
        Else
            MessageBox.Show("No se encontraron resultados")
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

    Private Sub btn_Exit_Click(sender As Object, e As EventArgs) Handles btn_Exit.Click
        Dim frm As New MenuRegister()
        frm.Show()
        Me.Close()
    End Sub
End Class