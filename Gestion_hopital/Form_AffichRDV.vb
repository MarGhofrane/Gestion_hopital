Public Class Form_AffichRDV
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_AffichRDV.CellContentClick
    End Sub

    Private Sub Form_AffichRDV_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Afficher_RDV()

    End Sub

    Private Sub btn_RDVDuJour_Click(sender As Object, e As EventArgs) Handles btn_RDVDuJour.Click
        btn_RDVDuJour.BackColor = Color.MediumPurple
        AfficherRDVsDuJour()
    End Sub


End Class