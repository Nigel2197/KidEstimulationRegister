Imports DataAccess

Public Class ScreenList

    Private Sub ScreenList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GetListKidName()
        GetListAge()
        RoundAllButtons(Me) ' Redondea los bordes de los botones inferiores del formulario
    End Sub

    Private Sub Cb_Name_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cb_Name.SelectedIndexChanged
        ' Si el combobox fue seleccionado avanza con la busqueda
        If Cb_Name.Focused Then
            FindKid()
        Else
            Exit Sub
        End If
    End Sub

    Private Sub Btn_Find_Click(sender As Object, e As EventArgs) Handles Btn_Find.Click
        FindKid()
    End Sub

    Private Sub Btn_New_Click(sender As Object, e As EventArgs) Handles Btn_New.Click
        KidAdd.Show()
        Me.Hide()
    End Sub
    Private Sub Btn_Edit_Click(sender As Object, e As EventArgs) Handles Btn_Edit.Click
        Dim frm As New KidEdit(Nothing) ' Pasa el valor directamente a la pantalla de Edición de Infante
        frm.Show()
        Me.Hide()
    End Sub

    Private Sub Dgv_KidList_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles Dgv_KidList.CellDoubleClick
        If e.RowIndex >= 0 Then
            Dim nombre As String = Dgv_KidList.Rows(e.RowIndex).Cells("Nombre").Value.ToString()
            Dim frm As New KidEdit(nombre)
            frm.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub GetListKidName()
        query = "SELECT Name FROM Kids"
        dt = GetData(query)

        Cb_Name.DataSource = dt
        Cb_Name.DisplayMember = "Name"
        Cb_Name.SelectedIndex = -1
    End Sub

    Private Sub GetListAge()
        query = "SELECT Age FROM Ages"
        dt = GetData(query)

        Cb_Age.DataSource = dt
        Cb_Age.DisplayMember = "Age"
        Cb_Age.SelectedIndex = -1
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
        If Not String.IsNullOrEmpty(Cb_Age.Text) Then
            where.Add("A.Age = @age")
            parameters.Add("@age", Cb_Age.Text)
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
            Dgv_KidList.DataSource = Nothing
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

    Private Sub btn_Clean_Click(sender As Object, e As EventArgs)
        Dim frm As New ScreenList
        frm.Show()
        Close()
    End Sub

    Private Sub btn_Back_Click(sender As Object, e As EventArgs) Handles btn_Back.Click
        Dim frm As New ScreenPrincipal()
        frm.Show()
        Me.Close()
    End Sub

    Private Sub btn_Exit_Click(sender As Object, e As EventArgs) Handles btn_Exit.Click
        Dim confirmation As DialogResult

        Me.ActiveControl = Nothing ' Evita que se haga focus en el botón
        confirmation = MessageBox.Show($"¿Está seguro de que quiere cerrar el sistema?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If confirmation = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub

End Class