Namespace Views.Service
    Public Class AddServiceView
        Dim userLogged As Usuario
        Private Sub dtpFechaIngreso_Initialized(sender As Object, e As EventArgs) Handles dtpFechaIngreso.Initialized
            dtpFechaIngreso.SelectedDate = Date.Now.ToString()
        End Sub

        Private Sub btnCancelarServicio_Click(sender As Object, e As RoutedEventArgs) Handles btnCancelarServicio.Click
            Dim window As Window = window.GetWindow(Me)
            window.Close()
            'Dim printDlg As New PrintDialog
            'printDlg.PrintVisual(Me, "Window Printing.")
        End Sub

        Private Sub btnAgregarServicio_Click(sender As Object, e As RoutedEventArgs) Handles btnAgregarServicio.Click
            If (Not dtpFechaEntrega.SelectedDate.HasValue = False) Then
                If (Not txtNombreCliente.Text.Trim.ToString.Equals("")) Then
                    If (Not txtCorreoCliente.Text.Trim.ToString.Equals("")) Then
                        If (Not txtDPICliente.Text.ToString.Trim.Equals("")) Then
                            If (Not txtTelefonoCliente.Text.ToString.Trim.Equals("")) Then
                                If (Not txtTipoEquipo.Text.ToString.Trim.Equals("")) Then
                                    If (Not txtMarcaEquipo.Text.ToString.Trim.Equals("")) Then
                                        If (Not txtModeloEquipo.Text.ToString.Trim.Equals("")) Then
                                            If (Not txtDescripcionEquipo.Text.ToString.Trim.Equals("")) Then
                                                If (Not txtFallaCliente.Text.ToString.Trim.Equals("")) Then
                                                    If (Not txtCosto.Text.ToString.Trim.Equals("")) Then
                                                        If (Not txtRepuestos.Text.ToString.Trim.Equals("")) Then
                                                            If (Not txtInforme.Text.ToString.Trim.Equals("")) Then
                                                                addService(dtpFechaIngreso.SelectedDate.Value.Date.ToString, dtpFechaEntrega.SelectedDate.Value.Date.ToString, txtNombreCliente.Text.ToString,
                                                                txtTelefonoCliente.Text.ToString, txtCorreoCliente.Text.ToString, txtDPICliente.Text.ToString, txtTipoEquipo.Text.ToString,
                                                                txtMarcaEquipo.Text.ToString, txtModeloEquipo.Text.ToString, txtDescripcionEquipo.Text.ToString, txtFallaCliente.Text.ToString, txtRepuestos.Text.ToString, txtInforme.Text.ToString, CInt(txtCosto.Text.ToString))
                                                                Dim window As Window = window.GetWindow(Me)
                                                                window.Close()
                                                            Else
                                                                MsgBox("Debe Ingresar algun Informe")
                                                            End If
                                                        Else
                                                            MsgBox("Debe Ingresar algun Repuesto")
                                                        End If
                                                    Else
                                                        MsgBox("Debe Ingresar un Costo")
                                                    End If
                                                Else
                                                    MsgBox("Debe Ingresar la Falla del Equipo")
                                                End If
                                            Else
                                                MsgBox("Debe Ingresar una Descripcion del Equipo")
                                            End If
                                        Else
                                            MsgBox("Debe Ingresar el Modelo del Equipo")
                                        End If
                                    Else
                                        MsgBox("Debe Ingresar la Marca del Equipo")
                                    End If
                                Else
                                    MsgBox("Debe Ingresar un Tipo de Equipo")
                                End If
                            Else
                                MsgBox("Debe Ingresar un Numero de Telefono")
                            End If
                        Else
                            MsgBox("Debe Ingresar DPI")
                        End If
                    Else
                        MsgBox("Debe Ingresar un Correo")
                    End If
                Else
                    MsgBox("Debe Ingresar el Nombre del Cliente")
                End If
            Else
                MsgBox("No Ingreso Fecha de Entrega")
            End If
            
        End Sub
        Private Sub addService(ByVal fechaIngreso As String, ByVal fechaEntrega As String, _
                               ByVal nombreCliente As String, ByVal telefonoCliente As String, ByVal correoCliente As String, ByVal DPI As String, _
                               ByVal tipoEquipo As String, ByVal marcaEquipo As String, modeloEquipo As String, descripcionEquipo As String, _
                               ByVal falla As String, ByVal repuesto As String, ByVal informe As String, ByVal costo As Integer)
            Try
                Dim db As dbServicioEntities = New dbServicioEntities

                Dim customer As New Cliente
                customer.nombre = nombreCliente
                customer.telefono = telefonoCliente
                customer.correo = correoCliente
                customer.DPI = DPI
                db.Clientes.Add(customer)

                Dim service As New Servicio
                service.fechaIngreso = fechaIngreso
                service.fechaEntrega = fechaEntrega
                service.idCliente = customer.idCliente
                service.tipo = tipoEquipo
                service.marca = marcaEquipo
                service.modelo = modeloEquipo
                service.descripcion = descripcionEquipo
                service.falla = falla
                service.repuesto = repuesto
                service.informe = informe
                service.costo = costo
                service.estado = "En Espera, No Entregado"
                service.idUsuario = userLogged.idUsuario
                db.Servicios.Add(service)
                db.SaveChanges()

            Catch ex As Exception
                MsgBox(ex.Message.ToString)
            End Try

        End Sub
        Sub New(ByVal usuario As Usuario)

            ' This call is required by the designer.
            InitializeComponent()

            ' Add any initialization after the InitializeComponent() call.
            userLogged = usuario
        End Sub
    End Class
End Namespace

