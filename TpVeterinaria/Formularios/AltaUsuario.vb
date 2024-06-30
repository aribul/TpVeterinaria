Imports System.Drawing.Text
Imports System.Runtime.CompilerServices
Imports Servicios.Models
Imports Servicios.Repositorios

Public Class AltaUsuario
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim nuevoUsuario = txtUsuario.Text
        Dim contrasenia = txtContrasenia.Text

        Dim usuarioNuevo As New Usuario(contrasenia, nuevoUsuario)

        Dim dao As New UsuarioDAO
        dao.insert(usuarioNuevo)
        Me.Close()

    End Sub
End Class