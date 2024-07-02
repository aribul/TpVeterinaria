Imports System.Windows.Forms.VisualStyles
Imports Servicios.Models
Imports Servicios.Repositorios
Imports Servicios.VeterinariaServices

Public Class Animales

    Private Sub Clear()
        txtNombreAnimal.Text = ""
        txtPesoAnimal.Text = ""
        txtEdadAnimal.Text = ""
        txtEspecieAnimal.Text = ""
        txtClienteAnimal.Text = ""

    End Sub
    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles txtClienteAnimal.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


        'valores text box

        Dim nombreAnimal = txtNombreAnimal.Text.ToUpper
        Dim sPesoAnimal = txtPesoAnimal.Text
        Dim sEdadAnimal = txtEdadAnimal.Text
        Dim especie = txtEspecieAnimal.Text
        Dim duenio = txtClienteAnimal.Text

        If nombreAnimal = "" Or sPesoAnimal = "" Or sEdadAnimal = "" Or especie = "" Or duenio = "" Then
            MessageBox.Show("Debe llenar todos los campos")
            Return
        End If

        Dim pesoAnimal As Double
        Dim edadAnimal As Integer


        Try
            pesoAnimal = Double.Parse(sPesoAnimal)
            edadAnimal = Integer.Parse(sEdadAnimal)
        Catch ex As FormatException
            MessageBox.Show("El formato de la edad o el peso es incorrecto.")
            Return
        Catch ex As OverflowException
            MessageBox.Show("El valor de la edad o el peso es demasiado grande o pequeño.")
            Return
        End Try

        'Creo el DAO e inserto'
        Dim dao As New AnimalDAO

        Dim nAnimal As New Animal(nombreAnimal, pesoAnimal, edadAnimal, especie, duenio)

        If dao.Insert(nAnimal) Then

            MessageBox.Show("El animal fue cargado")

            'limpia los txt'
            Me.Clear()
        End If

    End Sub
End Class