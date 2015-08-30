Namespace Views.Service
    Public Class OnHoldServiceView

        Private Sub dgOnHoldServices_Initialized(sender As Object, e As EventArgs) Handles dgOnHoldServices.Initialized
            Dim dbEntities As dbServicioEntities = New dbServicioEntities
            Dim services As List(Of Servicio) = (dbEntities.Servicios).ToList
            Dim query = _
                From Servicio In services
            Select No = Servicio.idServicio, Estado = Servicio.estado, FechaIngreso = Servicio.fechaIngreso, FechaEntrega = Servicio.fechaEntrega, Tipo = Servicio.tipo, Marca = Servicio.marca, Modelo = Servicio.modelo, Descripcion = Servicio.descripcion, Falla = Servicio.falla, Repuesto = Servicio.repuesto, Informe = Servicio.informe, Costo = Servicio.costo Where Estado.Contains("En Espera, No Entregado")
            dgOnHoldServices.ItemsSource = query.ToList
        End Sub
    End Class
End Namespace
