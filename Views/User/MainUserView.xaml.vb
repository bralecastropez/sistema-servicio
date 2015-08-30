Namespace Views.User
    Public Class MainUserView
        Private _usuarioSeleccionado As Usuario
        Public Property UsuarioSeleccionado As Usuario
            Get
                Return _usuarioSeleccionado
            End Get
            Set(value As Usuario)
                _usuarioSeleccionado = value
            End Set
        End Property
        Private Sub btnAddUser_Click(sender As Object, e As RoutedEventArgs) Handles btnAddUser.Click
            Dim addComputerView As New AddUserView
            Dim addComputerWindow As New Window
            addComputerWindow.Content = addComputerView
            addComputerWindow.SizeToContent() = Windows.SizeToContent.WidthAndHeight
            addComputerWindow.WindowStartupLocation = WindowStartupLocation.CenterScreen
            addComputerWindow.ShowDialog()
        End Sub

        Private Sub dgUsuarios_Initialized(sender As Object, e As EventArgs) Handles dgUsuarios.Initialized
            
            Dim dbEntities As dbServicioEntities = New dbServicioEntities
            Dim users As List(Of Usuario) = (dbEntities.Usuarios).ToList
            Dim query = _
                From Usuario In users _
                Select Nombre = Usuario.nombre, NombreUsuario = Usuario.nick, Contraseña = Usuario.contraseña, Correo = Usuario.correo, Telefono = Usuario.telefono
            dgUsuarios.ItemsSource = query.ToList
        End Sub

        Private Sub btnEliminar_Click(sender As Object, e As RoutedEventArgs) Handles btnEliminar.Click
            
            If Not UsuarioSeleccionado Is Nothing Then
                Dim db As New dbServicioEntities
                MsgBox(UsuarioSeleccionado.nombre)
                Dim user = (From u In db.Usuarios Where u.idUsuario = UsuarioSeleccionado.idUsuario Select u).FirstOrDefault
                MsgBox(user.idUsuario)
                MsgBox(user.nombre)
                db.Usuarios.Remove(user)
                db.SaveChanges()
            Else
                MsgBox("Debe Seleccionar un Usuario")
            End If
        End Sub

        Private Sub btnActualizar_Click(sender As Object, e As RoutedEventArgs) Handles btnActualizar.Click
            Dim dbEntities As dbServicioEntities = New dbServicioEntities
            Dim users As List(Of Usuario) = (dbEntities.Usuarios).ToList
            Dim query = _
                From Usuario In users _
                Select Nombre = Usuario.nombre, NombreUsuario = Usuario.nick, Contraseña = Usuario.contraseña, Correo = Usuario.correo, Telefono = Usuario.telefono
            dgUsuarios.ItemsSource = query.ToList
        End Sub

        Private Sub dgUsuarios_SelectedCellsChanged(sender As Object, e As SelectedCellsChangedEventArgs) Handles dgUsuarios.SelectedCellsChanged
            btnEditar.IsEnabled = True
            btnEliminar.IsEnabled = True
        End Sub

        Private Sub btnEditar_Click(sender As Object, e As RoutedEventArgs) Handles btnEditar.Click
            If dgUsuarios.SelectedValue Is Nothing Then
                MsgBox("No ha seleccionado nada")
            Else
                Try
                    Dim usuario As Usuario = TryCast(dgUsuarios.SelectedItem, Usuario)
                Catch ex As Exception
                    MsgBox(ex.InnerException)
                    MsgBox(ex.Message.ToString)
                End Try
            End If
        End Sub

        Private Sub UserControl_Initialized(sender As Object, e As EventArgs)
            btnEditar.IsEnabled = False
            btnEliminar.IsEnabled = False
        End Sub

    End Class
End Namespace

