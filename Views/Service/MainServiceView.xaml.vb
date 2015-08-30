Namespace Views.Service
    Public Class MainServiceView
        Dim servicios As List(Of Servicio) = (Proyecto_Servicio.Models.DataContext.DBEntities.Servicios).ToList
        Dim userLogged As Usuario
        Private Sub btnAddService_Click(sender As Object, e As RoutedEventArgs) Handles btnAddService.Click
            Dim window As New Window
            window.Content = New AddServiceView(userLogged)
            window.WindowStartupLocation = WindowStartupLocation.CenterScreen
            window.SizeToContent = SizeToContent.WidthAndHeight
            window.ShowDialog()

        End Sub

        Private Sub dgService_Initialized(sender As Object, e As EventArgs) Handles dgService.Initialized
            Try
                Dim dbEntities As dbServicioEntities = New dbServicioEntities
                Dim query = _
                    From Servicio In servicios
                Select No = Servicio.idServicio, Usuario = Servicio.Usuario.nombre, FechaIngreso = Servicio.fechaIngreso, FechaEntrega = Servicio.fechaEntrega, Tipo = Servicio.tipo, Marca = Servicio.marca, Modelo = Servicio.modelo, Descripcion = Servicio.descripcion, Falla = Servicio.falla, Repuesto = Servicio.repuesto, Informe = Servicio.informe, Costo = Servicio.costo
                dgService.ItemsSource = query.ToList
            Catch ex As Exception
                MsgBox(ex.Message)
                MsgBox(ex.InnerException)
            End Try

        End Sub
        Sub New(ByVal usuario As Usuario)

            ' This call is required by the designer.
            InitializeComponent()

            ' Add any initialization after the InitializeComponent() call.
            userLogged = usuario
        End Sub
        Private Sub btnBuscarServicio_Click(sender As Object, e As RoutedEventArgs) Handles btnBuscarServicio.Click
            Dim searchWindow As New Window
            Dim searchView As New SearchServiceView
            searchView.HorizontalAlignment = Windows.HorizontalAlignment.Center
            searchView.VerticalAlignment = Windows.VerticalAlignment.Center
            'searchWindow.Content = searchView
            searchWindow.WindowStartupLocation = WindowStartupLocation.CenterScreen
            searchView.ShowDialog()
        End Sub

        Private Sub btnActualizarServicio_Click(sender As Object, e As RoutedEventArgs) Handles btnActualizarServicio.Click
            Try
                Dim dbEntities As dbServicioEntities = New dbServicioEntities
                Dim query = _
                    From Servicio In servicios
                Select No = Servicio.idServicio, FechaIngreso = Servicio.fechaIngreso, FechaEntrega = Servicio.fechaEntrega, Tipo = Servicio.tipo, Marca = Servicio.marca, Modelo = Servicio.modelo, Descripcion = Servicio.descripcion, Falla = Servicio.falla, Repuesto = Servicio.repuesto, Informe = Servicio.informe, Costo = Servicio.costo
                dgService.ItemsSource = query.ToList
            Catch ex As Exception
                MsgBox("Error Al Actualizar")
            End Try
        End Sub
    End Class
End Namespace