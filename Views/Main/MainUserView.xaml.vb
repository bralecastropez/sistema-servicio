Imports Proyecto_Servicio.Views.Customer
Imports Proyecto_Servicio.Views.User
Imports Proyecto_Servicio.Views.Service
Namespace Views.Main
    Public Class MainView
        Dim userLogged As Usuario
        Private Sub tbServicios_Initialized(sender As Object, e As EventArgs) Handles tbServicios.Initialized
            tbServicios.Content = New MainServiceView(userLogged)
        End Sub

        Private Sub tbUsuarios_Initialized(sender As Object, e As EventArgs) Handles tbUsuarios.Initialized
            tbUsuarios.Content = New MainUserView
        End Sub

        Private Sub tbClientes_Initialized(sender As Object, e As EventArgs) Handles tbClientes.Initialized
            tbClientes.Content = New MainCustomerView
        End Sub

        Private Sub tbEntregados_Initialized(sender As Object, e As EventArgs) Handles tbEntregados.Initialized
            tbEntregados.Content = New DeliveredServiceView
        End Sub

        Private Sub tbEspera_Initialized(sender As Object, e As EventArgs) Handles tbEspera.Initialized
            tbEspera.Content = New OnHoldServiceView
        End Sub

        Sub New(ByVal usuario As Usuario)

            ' This call is required by the designer.
            InitializeComponent()

            ' Add any initialization after the InitializeComponent() call.
            userLogged = usuario
            lblHeader.Content = "Bienvenido " + userLogged.nombre
        End Sub

        Private Sub btnCerrarSesion_Click(sender As Object, e As RoutedEventArgs) Handles btnCerrarSesion.Click
            Dim logout As Window = Window.GetWindow(Me)
            Dim login As New LoginUserView
            login.VerticalAlignment = Windows.VerticalAlignment.Center
            login.HorizontalAlignment = Windows.HorizontalAlignment.Center
            logout.Content = login
            logout.WindowStartupLocation = WindowStartupLocation.CenterScreen
            logout.WindowState = WindowState.Normal
            logout.MinWidth = 500
            logout.MinHeight = 500
        End Sub
    End Class
End Namespace

