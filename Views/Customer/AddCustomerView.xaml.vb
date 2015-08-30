Namespace Views.Customer
    Public Class AddCustomerView

        Private Sub btnCancelar_Click(sender As Object, e As RoutedEventArgs) Handles btnCancelar.Click
            Dim window As Window = window.GetWindow(Me)
            window.Close()
        End Sub

        Private Sub btnAgregarCliente_Click(sender As Object, e As RoutedEventArgs) Handles btnAgregarCliente.Click
            Dim window As Window = window.GetWindow(Me)
            If (Not txtNombreCliente.Text.ToString.Equals("")) Then
                If (Not txtDPICliente.Text.ToString.Equals("")) Then
                    If (Not txtTelefonoCliente.Text.ToString.Equals("")) Then
                        If (Not txtCorreoCliente.Text.ToString.Equals("")) Then
                            AddCustomer(txtNombreCliente.Text.ToString, txtDPICliente.Text.ToString, CInt(txtTelefonoCliente.Text.ToString), txtCorreoCliente.Text.ToString)
                            window.Close()
                        Else
                            MsgBox("No Ingreso correo del cliente")
                        End If
                    Else
                        MsgBox("No Ingreso telefono del cliente")
                    End If
                Else
                    MsgBox("No ingreso DPI del cliente")
                End If
            Else
                MsgBox("Debe Ingresar el Nombre del Cliente")
            End If


        End Sub
        Private Sub AddCustomer(ByVal nombre As String, ByVal DPI As String, ByVal telefono As Integer, ByVal correo As String)
            Dim db As dbServicioEntities = New dbServicioEntities
            Dim customer As New Cliente
            customer.nombre = nombre
            customer.DPI = DPI
            customer.telefono = telefono
            customer.correo = correo
            db.Clientes.Add(customer)
            db.SaveChanges()
        End Sub
    End Class
End Namespace

