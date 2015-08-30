Namespace Views.Main
    Public Class LoginUserView
        Private Function auth(ByVal nick As String, ByVal pass As String) As Usuario
            Dim db As dbServicioEntities = New dbServicioEntities
            Dim users As List(Of Usuario) = (db.Usuarios).ToList
            Dim user = (From Usuario In users Where Usuario.nick = nick AndAlso Usuario.contraseña = pass).FirstOrDefault
            If (Not user Is Nothing) Then
                Return user
            Else
                Return Nothing
            End If

        End Function

        Private Sub btnIniciarSesion_Click(sender As Object, e As RoutedEventArgs) Handles btnIniciarSesion.Click
            If (Not auth(txtNombreUsuario.Text.ToString, txtContraseña.Password.ToString) Is Nothing) Then
                Dim user As Usuario = auth(txtNombreUsuario.Text.ToString, txtContraseña.Password.ToString)
                MsgBox("Bienvenido", MsgBoxStyle.Information)
                Dim loginCorrecto As Window = Window.GetWindow(Me)
                Dim main As New MainView(user)
                main.HorizontalAlignment = Windows.HorizontalAlignment.Center
                main.VerticalAlignment = Windows.VerticalAlignment.Center
                loginCorrecto.Content = main
                loginCorrecto.WindowState = WindowState.Maximized

            Else
                MsgBox("Verifique Sus Datos", MsgBoxStyle.Exclamation)
            End If

        End Sub
    End Class
End Namespace

