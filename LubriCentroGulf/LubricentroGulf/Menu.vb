Public Class Menu
    Private Sub AgregarFiltroAireToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AgregarFiltroAireToolStripMenuItem.Click
        filtroAire.MdiParent = Me
        filtroAire.Show()
    End Sub

    Private Sub AgregarFiltroAceiteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AgregarFiltroAceiteToolStripMenuItem.Click
        FiltroAceite.MdiParent = Me
        FiltroAceite.Show()
    End Sub

    Private Sub AgregarFiltroCombustibleToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AgregarFiltroCombustibleToolStripMenuItem.Click
        filtroCombustible.MdiParent = Me
        filtroCombustible.Show()
    End Sub

    Private Sub AgregarLubricanteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AgregarLubricanteToolStripMenuItem.Click
        Lubricante.MdiParent = Me
        Lubricante.Show()
    End Sub

    Private Sub AgregarVehiculoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AgregarVehiculoToolStripMenuItem.Click
        Vehiculo.MdiParent = Me
        Vehiculo.Show()
    End Sub

    Private Sub ServiciosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ServiciosToolStripMenuItem.Click
        Form2.MdiParent = Me
        Form2.Show()
    End Sub

    Private Sub AgregarPatenteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AgregarPatenteToolStripMenuItem.Click
        patente.mdiparent = Me
        patente.show
    End Sub
End Class