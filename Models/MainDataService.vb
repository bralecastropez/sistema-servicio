Namespace Models
    Public Class MainDataService
        Public Function GetUsers() As List(Of Usuario)
            Try
                Dim users As List(Of Usuario) = (DataContext.DBEntities.Usuarios).ToList
                Return users
            Catch ex As Exception
                Throw New Exception(ex.Message, ex.InnerException)
            End Try
        End Function
        Public Function GetCustomers() As Object
            Try
                Dim customers As List(Of Cliente) = (DataContext.DBEntities.Clientes).ToList
                Dim query = _
                    From Cliente In customers _
                    Select Cliente.nombre, Cliente.idCliente, Cliente.DPI, Cliente.telefono, Cliente.correo

                Return query
            Catch ex As Exception
                Throw New Exception(ex.Message, ex.InnerException)
            End Try
        End Function
        Public Function GetServices() As List(Of Servicio)
            Try
                Dim services As List(Of Servicio) = (DataContext.DBEntities.Servicios).ToList
                Return services
            Catch ex As Exception
                Throw New Exception(ex.Message, ex.InnerException)
            End Try
        End Function
    End Class
End Namespace

