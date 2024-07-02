Imports Servicios.Repositorios

Public Class MaxMinPro
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub TxtBoxEdadMax_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles TxtBoxEdadMax.MaskInputRejected

    End Sub

    Private Sub btnMostrar_Click(sender As Object, e As EventArgs) Handles btnMostrar.Click

        Dim minimo = TxtBoxEdadMin.Text
        Dim maximo = TxtBoxEdadMax.Text

        Dim dao As New AnimalDAO

        dao.promedioPeso(minimo, maximo)
        dao.pesoMaximo(minimo, maximo)
        dao.pesoMinimo(minimo, maximo)

        Dim data = dao.getAll

        DataGridReporte.DataSource = data


    End Sub
End Class