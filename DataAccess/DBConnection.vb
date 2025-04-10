Imports Microsoft.Data.Sqlite
Imports System.Data

Public Module DBConnection
    Public Function SetConnection() As SqliteConnection
        ' Ruta completa del archivo de la base de datos en la misma carpeta del ejecutable
        Dim path As String = AppContext.BaseDirectory & "KERDB.db"

        ' Cadena de conexión con SQLite
        Dim ConnectionString As String = $"Data Source={path};"

        ' Devolver el objeto de conexión (puede ser usado con Using)
        Return New SqliteConnection(ConnectionString)
    End Function

    ' 1. Función para obtener datos desde una Vista
    Public Function GetData(query As String, Optional parameters As Dictionary(Of String, Object) = Nothing) As DataTable
        Dim dataTable As New DataTable() ' Crea un DataTable donde se guardarán los resultados

        Try
            Using connection As SqliteConnection = SetConnection() ' Crea y abre la conexión a la base de datos
                connection.Open()

                Using command As New SqliteCommand(query, connection) ' Crea el comando con la consulta a ejecutar
                    ' Si hay parámetros, se agregan al comando
                    If parameters IsNot Nothing Then
                        For Each param In parameters
                            command.Parameters.AddWithValue(param.Key, param.Value)
                        Next
                    End If

                    ' Ejecuta la consulta y obtiene un lector de datos
                    Using reader As SqliteDataReader = command.ExecuteReader()
                        dataTable.Load(reader) ' Carga los datos del lector al DataTable
                    End Using
                End Using
            End Using

            Return dataTable ' Devuelve los datos obtenidos

        Catch ex As Exception
            Return Nothing ' Si ocurre un error, devuelve Nothing (nulo)
        End Try
    End Function

    ' 2. Función para ejecutar un procedimiento almacenado o instrucción compleja
    Public Function WriteData(query As String, Optional parameters As Dictionary(Of String, Object) = Nothing) As Boolean
        Try
            Using connection As SqliteConnection = SetConnection() ' Crea y abre la conexión
                connection.Open()

                Using command As New SqliteCommand(query, connection) ' Crea el comando con la instrucción
                    ' Agrega los parámetros si los hay
                    If parameters IsNot Nothing Then
                        For Each param In parameters
                            command.Parameters.AddWithValue(param.Key, param.Value)
                        Next
                    End If

                    command.ExecuteNonQuery() ' Ejecuta la instrucción sin esperar resultados (INSERT, UPDATE, DELETE)
                End Using
            End Using

            Return True ' Todo funcionó correctamente

        Catch ex As Exception
            Return False ' Ocurrió un error
        End Try
    End Function

    ' 3. Función para ejecutar una vista que devuelve un solo valor
    Public Function ExecuteScalar(query As String, Optional parameters As Dictionary(Of String, Object) = Nothing) As Object
        Try
            Using connection As SqliteConnection = SetConnection() ' Abre la conexión a la base de datos
                connection.Open()

                Using command As New SqliteCommand(query, connection) ' Prepara el comando
                    ' Agrega los parámetros si existen
                    If parameters IsNot Nothing Then
                        For Each param In parameters
                            command.Parameters.AddWithValue(param.Key, param.Value)
                        Next
                    End If

                    ' Ejecuta la consulta y obtiene el primer valor del primer registro
                    Dim result As Object = command.ExecuteScalar()
                    Return result ' Devuelve el resultado de la consulta
                End Using
            End Using

            Return True ' Se obtuvo correctamente el valor

        Catch ex As Exception
            Return False ' Indica que hubo un error
        End Try
    End Function

End Module
