Imports DataAccess

Public Class KidEvaluation
    Private NameKid As String
    Private KidID As Integer
    Private AgeID As Integer
    Private BehaviourID As Integer

    Private Sub KidEvaluation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FindKidData()
        LoadKidData()
        LoadFormAdaptive()
    End Sub

    Public Sub New(Name As String)
        InitializeComponent()
        NameKid = Name
    End Sub

    Private Sub Cb_Behavior_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cb_Behavior.SelectedIndexChanged
        Select Case Cb_Behavior.SelectedIndex
            Case 1
                LoadFormAdaptive()
        End Select
    End Sub

    Private Sub FindKidData()
        query = "SELECT K.ID AS Kid_ID, A.ID AS Age_ID, A.WeeksAge, A.Age, K.BloodType, K.WhatAllergy
                 FROM Kids K
                 JOIN Ages A ON K.Age_ID = A.ID "

        where.Add("Name = @name")
        parameters.Add("@name", NameKid)

        query &= "WHERE " & String.Join("", where)

        dt = GetData(query, parameters)
    End Sub

    Private Sub LoadKidData()
        If dt.Rows.Count > 0 Then
            Lbl_Age.Text = dt.Rows(0)("Age").ToString().ToUpper
            Lbl_WeeksAge.Text = dt.Rows(0)("WeeksAge").ToString() & " Semanas"
            Lbl_Allergy.Text = "Es alérgico a: " & dt.Rows(0)("WhatAllergy").ToString()
            Lbl_BloodType.Text = dt.Rows(0)("BloodType").ToString()
            Lbl_Name.Text = NameKid
            KidID = dt.Rows(0)("Kid_ID")
            AgeID = dt.Rows(0)("Age_ID")
        Else
            MessageBox.Show("Error al consultar los datos del infante")
        End If
    End Sub

    Private Sub FindBehaviour()

    Private Sub LoadFormAdaptive()


        Dim result As Object = ExecuteScalar("SELECT 1 FROM Registers WHERE Kid_ID = @kidid AND AgeID = @ageid",
                                           New Dictionary(Of String, Object) From {{"@kidid", KidID},
                                                                                   {"@ageid", AgeID}})

        If result IsNot Nothing Then

        Else
            query = "SELECT ID, Description FROM Behaviors "

            where.Add("Area_ID = @areaid")
            parameters.Add("@areaid", 1)

            where.Add("Age_ID = @ageid")
            parameters.Add("@ageid", AgeID)

            query &= "WHERE " & String.Join(" AND ", where)

            dt = GetData(query, parameters)
        End If


    End Sub

    Private Sub LoadLabelForm()
        Select Case Cb_Behavior.SelectedIndex
            Case 1
                LoadFormAdaptive()
        End Select
    End Sub

    Private Sub LoadStatusForm()

    End Sub

    Private Sub cb_Conducta_DrawItem(sender As Object, e As DrawItemEventArgs) Handles Cb_Behavior.DrawItem
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
        Dim text As String = Cb_Behavior.Items(e.Index).ToString()
        Dim textFont As Font = Cb_Behavior.Font
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

End Class