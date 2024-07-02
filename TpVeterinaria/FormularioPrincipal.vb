Public Class FormularioPrincipal
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnIniciarSesion.Click

        MenuPrinicpal.Show()
        PanelLogin.Hide()

    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub btnCrearUsuarioNuevo_Click(sender As Object, e As EventArgs) Handles btnCrearUsuarioNuevo.Click
        PanelLogin.Hide()
        Dim formu As New AltaUsuario
        formu.MdiParent = Me
        formu.Show()
    End Sub

    Private Sub FormularioPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
