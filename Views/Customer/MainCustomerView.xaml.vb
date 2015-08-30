Namespace Views.Customer
    Public Class MainCustomerView

        Private Sub btnAddCustomer_Click(sender As Object, e As RoutedEventArgs) Handles btnAddCustomer.Click
            Dim addCustomerView As New AddCustomerView
            Dim addCustomerWindow As New Window
            addCustomerWindow.Content = addCustomerView
            addCustomerWindow.SizeToContent() = Windows.SizeToContent.WidthAndHeight
            addCustomerWindow.WindowStartupLocation = WindowStartupLocation.CenterScreen
            addCustomerWindow.ShowDialog()
        End Sub


        Private Sub dgClientes_Initialized(sender As Object, e As EventArgs) Handles dgClientes.Initialized
            Dim dbEntities As dbServicioEntities = New dbServicioEntities
            Dim customers As List(Of Cliente) = (dbEntities.Clientes).ToList
            Dim query = _
                From Cliente In customers _
                Select Cliente = Cliente.idCliente, Nombre = Cliente.nombre, Cliente.DPI, Teléfono = Cliente.telefono, Correo = Cliente.correo
            dgClientes.ItemsSource = query.ToList
        End Sub

        Private Sub btnActualizar_Click(sender As Object, e As RoutedEventArgs) Handles btnActualizar.Click
            Dim dbEntities As dbServicioEntities = New dbServicioEntities
            Dim customers As List(Of Cliente) = (dbEntities.Clientes).ToList
            Dim query = _
                From Cliente In customers _
                Select Cliente = Cliente.idCliente, Nombre = Cliente.nombre, Cliente.DPI, Teléfono = Cliente.telefono, Correo = Cliente.correo
            dgClientes.ItemsSource = query.ToList
        End Sub
    End Class
End Namespace

