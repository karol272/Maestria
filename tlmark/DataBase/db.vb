Imports System.Data.SqlClient



Public Class Db

    Dim con As New SqlConnection(ConfigurationManager.ConnectionStrings("con").ConnectionString)
    Dim cmd As New SqlCommand()





End Class
