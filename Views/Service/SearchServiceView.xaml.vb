Namespace Views.Service
    Public Class SearchServiceView

        Private Sub rbtnUsuario_Checked(sender As Object, e As RoutedEventArgs) Handles rbtnUsuario.Checked
            txtNombreCliente.IsEnabled = False
            txtNombreUsuario.IsEnabled = True
            txtProblema.IsEnabled = False
            cmbTipoEquipo.IsEnabled = False
            cmbModeloEquipo.IsEnabled = False
            cmbMarcaEquipo.IsEnabled = False
            dtpFechaEntrega.IsEnabled = False
            dtpFechaIngreso.IsEnabled = False
            txtComponente.IsEnabled = False
        End Sub

        Private Sub rbtnCliente_Checked(sender As Object, e As RoutedEventArgs) Handles rbtnCliente.Checked
            txtNombreUsuario.IsEnabled = False
            txtNombreCliente.IsEnabled = True
            txtProblema.IsEnabled = False
            cmbTipoEquipo.IsEnabled = False
            cmbModeloEquipo.IsEnabled = False
            cmbMarcaEquipo.IsEnabled = False
            dtpFechaEntrega.IsEnabled = False
            dtpFechaIngreso.IsEnabled = False
            txtComponente.IsEnabled = False
        End Sub


        Private Sub rbtnProblema_Checked(sender As Object, e As RoutedEventArgs) Handles rbtnProblema.Checked
            txtNombreCliente.IsEnabled = False
            txtNombreUsuario.IsEnabled = False
            txtProblema.IsEnabled = True
            cmbTipoEquipo.IsEnabled = False
            cmbModeloEquipo.IsEnabled = False
            cmbMarcaEquipo.IsEnabled = False
            dtpFechaEntrega.IsEnabled = False
            dtpFechaIngreso.IsEnabled = False
            txtComponente.IsEnabled = False
        End Sub

        Private Sub btnBuscarServicio_Click(sender As Object, e As RoutedEventArgs) Handles btnBuscarServicio.Click
            Dim db As dbServicioEntities = New dbServicioEntities
            Dim servicios As List(Of Servicio) = (db.Servicios).ToList
            Dim usuarios As List(Of Usuario) = (db.Usuarios).ToList
            Dim clientes As List(Of Cliente) = (db.Clientes).ToList
            If (rbtnUsuario.IsChecked = True) Then
                If (Not txtNombreUsuario.Text.Trim.ToString.Equals("")) Then
                    Try
                        Dim user As Usuario = (From u In usuarios Where u.nombre.Contains(txtNombreUsuario.Text.ToString)).FirstOrDefault
                        If (Not user Is Nothing) Then
                            Dim query = From s In servicios Where s.idUsuario = user.idUsuario Select Servicio = s.idServicio, FechaIngreso = s.fechaIngreso, FechaEntrega = s.fechaEntrega, Tipo = s.tipo, Marca = s.marca, Modelo = s.modelo, Falla = s.falla, Costo = s.costo, Estado = s.estado
                            dgServicioBuscado.ItemsSource = query.ToList
                        Else
                            MsgBox(txtNombreUsuario.Text.ToString + " no existe.")
                        End If
                    Catch ex As Exception
                        MsgBox(ex.Message)
                        MsgBox(ex.InnerException)
                    End Try
                End If
            ElseIf (rbtnFechaIngreso.IsChecked = True) Then
                Try
                    MsgBox(dtpFechaIngreso.SelectedDate.ToString)
                    Dim service = (From s In servicios Where s.fechaIngreso.Contains(dtpFechaIngreso.SelectedDate.ToString) Select Servicio = s.idServicio, FechaIngreso = s.fechaIngreso, FechaEntrega = s.fechaEntrega, Tipo = s.tipo, Marca = s.marca, Modelo = s.modelo, Falla = s.falla, Costo = s.costo, Estado = s.estado).ToList
                    dgServicioBuscado.ItemsSource = service
                Catch ex As Exception
                    MsgBox(ex.Message)
                    MsgBox(ex.InnerException)
                End Try
            ElseIf (rbtnFechaEntrega.IsChecked = True) Then
                Try
                    Dim service = (From s In servicios Where s.fechaEntrega.Contains(dtpFechaEntrega.SelectedDate.ToString) Select Servicio = s.idServicio, FechaIngreso = s.fechaIngreso, FechaEntrega = s.fechaEntrega, Tipo = s.tipo, Marca = s.marca, Modelo = s.modelo, Falla = s.falla, Costo = s.costo, Estado = s.estado).ToList
                    dgServicioBuscado.ItemsSource = service
                Catch ex As Exception
                    MsgBox(ex.Message)
                    MsgBox(ex.InnerException)
                End Try
            ElseIf (rbtnMarcaEquipo.IsChecked = True) Then
                Try
                    Dim service = (From s In servicios Where s.marca = cmbMarcaEquipo.SelectedItem.ToString Select Servicio = s.idServicio, FechaIngreso = s.fechaIngreso, FechaEntrega = s.fechaEntrega, Tipo = s.tipo, Marca = s.marca, Modelo = s.modelo, Falla = s.falla, Costo = s.costo, Estado = s.estado).ToList
                    dgServicioBuscado.ItemsSource = service
                Catch ex As Exception
                    MsgBox(ex.Message)
                    MsgBox(ex.InnerException)
                End Try
            ElseIf (rbtnModeloEquipo.IsChecked = True) Then
                Try
                    Dim service = (From s In servicios Where s.modelo = cmbModeloEquipo.SelectedItem.ToString Select Servicio = s.idServicio, FechaIngreso = s.fechaIngreso, FechaEntrega = s.fechaEntrega, Tipo = s.tipo, Marca = s.marca, Modelo = s.modelo, Falla = s.falla, Costo = s.costo, Estado = s.estado).ToList
                    dgServicioBuscado.ItemsSource = service
                Catch ex As Exception
                    MsgBox(ex.Message)
                    MsgBox(ex.InnerException)
                End Try
            ElseIf (rbtnTipoEquipo.IsChecked = True) Then
                Try
                    Dim service = (From s In servicios Where s.tipo = cmbTipoEquipo.SelectedItem.ToString Select Servicio = s.idServicio, FechaIngreso = s.fechaIngreso, FechaEntrega = s.fechaEntrega, Tipo = s.tipo, Marca = s.marca, Modelo = s.modelo, Falla = s.falla, Costo = s.costo, Estado = s.estado).ToList
                    dgServicioBuscado.ItemsSource = service
                Catch ex As Exception
                    MsgBox(ex.Message)
                    MsgBox(ex.InnerException)
                End Try
            ElseIf (rbtnComponente.IsChecked = True) Then
                    Try
                    Dim service = (From s In servicios Where s.descripcion.Contains(txtComponente.Text.ToString) Select Servicio = s.idServicio, FechaIngreso = s.fechaIngreso, FechaEntrega = s.fechaEntrega, Tipo = s.tipo, Marca = s.marca, Modelo = s.modelo, Falla = s.falla, Costo = s.costo, Estado = s.estado).ToList
                        If (Not service Is Nothing) Then
                            dgServicioBuscado.ItemsSource = service
                        Else
                            MsgBox(txtComponente.Text.ToString + " no existe.")
                        End If
                    Catch ex As Exception
                        MsgBox(ex.Message)
                        MsgBox(ex.InnerException)
                    End Try
            ElseIf (rbtnProblema.IsChecked = True) Then
                    Try
                    Dim service = (From s In servicios Where s.falla.Contains(txtProblema.Text.ToString) Select Servicio = s.idServicio, FechaIngreso = s.fechaIngreso, FechaEntrega = s.fechaEntrega, Tipo = s.tipo, Marca = s.marca, Modelo = s.modelo, Falla = s.falla, Costo = s.costo, Estado = s.estado).ToList
                        If (Not service Is Nothing) Then
                            dgServicioBuscado.ItemsSource = service
                        Else
                            MsgBox(txtNombreCliente.Text.ToString + " no existe.")
                        End If
                    Catch ex As Exception
                        MsgBox(ex.Message)
                        MsgBox(ex.InnerException)
                    End Try
            ElseIf (rbtnCliente.IsChecked = True) Then
                    Try
                        Dim client As Cliente = (From c In clientes Where c.nombre.Contains(txtNombreCliente.Text.ToString)).FirstOrDefault
                        If (Not client Is Nothing) Then
                            Dim query = From s In servicios Where s.idCliente = client.idCliente Select Servicio = s.idServicio, FechaIngreso = s.fechaIngreso, FechaEntrega = s.fechaEntrega, Tipo = s.tipo, Marca = s.marca, Modelo = s.modelo, Falla = s.falla, Costo = s.costo, Estado = s.estado
                            dgServicioBuscado.ItemsSource = query.ToList
                        Else
                            MsgBox(txtNombreCliente.Text.ToString + " no existe.")
                        End If
                    Catch ex As Exception
                        MsgBox(ex.Message)
                        MsgBox(ex.InnerException)
                    End Try
            End If
        End Sub

        Private Sub UserControl_Initialized(sender As Object, e As EventArgs)
            txtNombreCliente.IsEnabled = False
            txtNombreUsuario.IsEnabled = False
            txtProblema.IsEnabled = False
            cmbTipoEquipo.IsEnabled = False
            cmbModeloEquipo.IsEnabled = False
            cmbMarcaEquipo.IsEnabled = False
            dtpFechaEntrega.IsEnabled = False
            dtpFechaIngreso.IsEnabled = False
            txtComponente.IsEnabled = False
            FillComboboxs()
        End Sub

        Private Sub rbtnComponente_Checked(sender As Object, e As RoutedEventArgs) Handles rbtnComponente.Checked
            txtNombreCliente.IsEnabled = False
            txtNombreUsuario.IsEnabled = False
            txtProblema.IsEnabled = False
            cmbTipoEquipo.IsEnabled = False
            cmbModeloEquipo.IsEnabled = False
            cmbMarcaEquipo.IsEnabled = False
            dtpFechaEntrega.IsEnabled = False
            dtpFechaIngreso.IsEnabled = False
            txtComponente.IsEnabled = True
        End Sub
        Public Sub FillComboboxs()
            Dim db As dbServicioEntities = New dbServicioEntities
            Dim servicios As List(Of Servicio) = (db.Servicios).ToList
            Dim usuarios As List(Of Usuario) = (db.Usuarios).ToList
            Dim clientes As List(Of Cliente) = (db.Clientes).ToList
            cmbTipoEquipo.ItemsSource = (From s In servicios Select s.tipo).ToList
            cmbMarcaEquipo.ItemsSource = (From s In servicios Select s.marca).ToList
            cmbModeloEquipo.ItemsSource = (From s In servicios Select s.modelo).ToList

        End Sub

        Private Sub rbtnFechaIngreso_Checked(sender As Object, e As RoutedEventArgs) Handles rbtnFechaIngreso.Checked
            txtNombreUsuario.IsEnabled = False
            txtNombreCliente.IsEnabled = False
            txtProblema.IsEnabled = False
            cmbTipoEquipo.IsEnabled = False
            cmbModeloEquipo.IsEnabled = False
            txtComponente.IsEnabled = False
            cmbMarcaEquipo.IsEnabled = False
            dtpFechaEntrega.IsEnabled = False
            dtpFechaIngreso.IsEnabled = True
        End Sub

        Private Sub rbtnFechaEntrega_Checked(sender As Object, e As RoutedEventArgs) Handles rbtnFechaEntrega.Checked
            txtNombreUsuario.IsEnabled = False
            txtNombreCliente.IsEnabled = False
            txtProblema.IsEnabled = False
            cmbTipoEquipo.IsEnabled = False
            cmbModeloEquipo.IsEnabled = False
            txtComponente.IsEnabled = False
            cmbMarcaEquipo.IsEnabled = False
            dtpFechaEntrega.IsEnabled = True
            dtpFechaIngreso.IsEnabled = False
        End Sub

        Private Sub rbtnTipoEquipo_Checked(sender As Object, e As RoutedEventArgs) Handles rbtnTipoEquipo.Checked
            txtNombreUsuario.IsEnabled = False
            txtNombreCliente.IsEnabled = False
            txtProblema.IsEnabled = False
            cmbTipoEquipo.IsEnabled = True
            cmbModeloEquipo.IsEnabled = False
            txtComponente.IsEnabled = False
            cmbMarcaEquipo.IsEnabled = False
            dtpFechaEntrega.IsEnabled = False
            dtpFechaIngreso.IsEnabled = False
        End Sub

        Private Sub rbtnModeloEquipo_Checked(sender As Object, e As RoutedEventArgs) Handles rbtnModeloEquipo.Checked
            txtNombreUsuario.IsEnabled = False
            txtNombreCliente.IsEnabled = False
            txtProblema.IsEnabled = False
            cmbTipoEquipo.IsEnabled = False
            cmbModeloEquipo.IsEnabled = True
            txtComponente.IsEnabled = False
            cmbMarcaEquipo.IsEnabled = False
            dtpFechaEntrega.IsEnabled = False
            dtpFechaIngreso.IsEnabled = False
        End Sub

        Private Sub rbtnMarcaEquipo_Checked(sender As Object, e As RoutedEventArgs) Handles rbtnMarcaEquipo.Checked
            txtNombreUsuario.IsEnabled = False
            txtNombreCliente.IsEnabled = False
            txtProblema.IsEnabled = False
            cmbTipoEquipo.IsEnabled = False
            cmbModeloEquipo.IsEnabled = False
            txtComponente.IsEnabled = False
            cmbMarcaEquipo.IsEnabled = True
            dtpFechaEntrega.IsEnabled = False
            dtpFechaIngreso.IsEnabled = False
        End Sub
    End Class
End Namespace

