Module GlobalVariables
    'Variable para almacenar los datos extraidos de las consultas a la base de datos
    Public dt As DataTable

    ''Variables para las consultas a las bases de datos
    Public query As String
    Public where As New List(Of String)()
    Public parameters As New Dictionary(Of String, Object)()
    Public clauses As String
    Public success As Boolean
End Module
