Imports System.Windows.Forms.VisualStyles
Imports Servicios.Models
Imports Servicios.Repositorios

Public Class Especies

    Private Sub Clear()
        txtNombre.Text = ""
        txtEdadMadurez.Text = ""
        txtPesoProm.Text = ""
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        'valores text box'

        Dim nombre = txtNombre.Text.ToUpper
        Dim sEdad = txtEdadMadurez.Text
        Dim sPeso = txtPesoProm.Text

        If nombre = "" Or sEdad = "" Or sPeso = "" Then
            MessageBox.Show("Debe llenar todos los campos: Nombre, Edad de Madurez y Peso Promedio")
            Return
        End If

        Dim edad As Double
        Dim peso As Double

        Try
            edad = Double.Parse(sEdad)
            peso = Double.Parse(sPeso)
        Catch ex As FormatException
            MessageBox.Show("El formato de la edad o el peso es incorrecto.")
            Return
        Catch ex As OverflowException
            MessageBox.Show("El valor de la edad o el peso es demasiado grande o pequeño.")
            Return
        End Try

        'Creo el DAO e inserto'
        Dim dao As New EspecieDAO

        Dim nEspecie As New Especie(nombre, edad, peso)

        If dao.Insert(nEspecie) Then

            MessageBox.Show("La especie fue cargada")

            'limpia los txt'
            Me.Clear()
        End If


    End Sub
End Class