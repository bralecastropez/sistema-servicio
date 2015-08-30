Imports Proyecto_Servicio.Views.Main
Class MainWindow
    Private Sub wdPrincipal_Initialized(sender As Object, e As EventArgs) Handles wdPrincipal.Initialized
        Dim login As New LoginUserView
        login.VerticalAlignment = Windows.VerticalAlignment.Center
        login.HorizontalAlignment = Windows.HorizontalAlignment.Center
        login.Show()
        wdPrincipal.Hide()
    End Sub
End Class
