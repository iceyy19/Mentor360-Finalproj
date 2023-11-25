Imports MySql.Data.MySqlClient
Public Class Connector
    Public Shared myDBConnection As MySqlConnection
    Public Shared Function getDBConnection() As MySqlConnection

        myDBConnection = New MySqlConnection(
            "Database=mentor360-finals;" &
            "Data Source=localhost;" &
            "User id= root;" &
            "Password= pass0403;" &
            "Port=3306;Command TimeOut=600;")
        Return myDBConnection

    End Function
End Class
