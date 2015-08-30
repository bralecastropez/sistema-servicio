Namespace Views.User
    Public Class AddUserView

        Private Sub addUser(ByVal nombre As String, ByVal nick As String, ByVal telefono As String, ByVal correo As String, ByVal contraseña As String)
            Dim dbEntities As dbServicioEntities = New dbServicioEntities
            Dim user As New Usuario
            user.nombre = nombre
            user.nick = nick
            user.telefono = telefono
            user.correo = correo
            user.contraseña = contraseña
            Proyecto_Servicio.Models.DataContext.DBEntities.SaveChanges()
            dbEntities.Usuarios.Add(user)
            dbEntities.SaveChanges()
        End Sub

        Private Sub btnAgregarUsuario_Click(sender As Object, e As RoutedEventArgs) Handles btnAgregarUsuario.Click
            Dim window As Window = window.GetWindow(Me)
            If (Not txtNombre.Text.ToString.Equals("")) Then
                If (Not txtNombreUsuario.Text.ToString.Equals("")) Then
                    If (Not txtTelefono.Text.ToString.Equals("")) Then
                        If (Not txtCorreo.Text.ToString.Equals("")) Then
                            If (Not txtContraseña.Password.ToString.Equals("")) Then
                                addUser(txtNombre.Text.ToString, txtNombreUsuario.Text.ToString, txtTelefono.Text.ToString, txtCorreo.Text.ToString, txtContraseña.Password.ToString)
                                window.Close()
                            Else
                                MsgBox("Debe Ingresar Una Contraseña")
                            End If
                        Else
                            MsgBox("Debe Ingresar Un Correo")
                        End If
                    Else
                        MsgBox("Debe Ingresar Un Telefono")
                    End If
                Else
                    MsgBox("Debe Ingresar un Nombre de Usuario")
                End If
            Else
                MsgBox("Debe Ingresar Un Nombre")
            End If
        End Sub

        Private Sub btnCancelar_Click(sender As Object, e As RoutedEventArgs) Handles btnCancelar.Click
            Dim window As Window = window.GetWindow(Me)
            window.Close()
        End Sub
    End Class
End Namespace

