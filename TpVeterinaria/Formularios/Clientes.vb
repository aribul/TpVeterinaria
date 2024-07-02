Imports Servicios.Repositorios
Imports Servicios.VeterinariaServices

Public Class Clientes

    Private Sub Clear()
        txtNombreCliente.Text = ""
        txtDniCliente.Text = ""

    End Sub
    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click




        'valores text box

        Dim nombreCliente = txtNombreCliente.Text.ToUpper
        Dim dniCliente = txtDniCliente.Text


        If nombreCliente = "" Or dniCliente = "" Then
            MessageBox.Show("Debe llenar todos los campos")
            Return
        End If

        'Creo el DAO e inserto'
        Dim dao As New ClienteDAO

        Dim clienteNuevo As New Cliente(nombreCliente, dniCliente)

        If dao.insert(clienteNuevo) Then

            MessageBox.Show("El animal fue cargado")

            'limpia los txt'
            Me.Clear()
        End If

    End Sub
End Class