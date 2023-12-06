Public Class Frm_Menu
    Private Sub AjoutpatientToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AjoutpatientToolStripMenuItem.Click

        Frm_Patient.show()



    End Sub

    Private Sub AfficherpatientToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AfficherpatientToolStripMenuItem.Click
        Form_AffichPatients.Show()

    End Sub

    Private Sub AfficherRDVToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AfficherRDVToolStripMenuItem.Click
        Form_AffichRDV.Show()
    End Sub

    Private Sub RendreRDVToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RendreRDVToolStripMenuItem.Click
        Frm_RDV.Show()
    End Sub
End Class
