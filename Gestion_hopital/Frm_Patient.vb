
Imports System.Data.SqlClient
Public Class Frm_Patient
    Private Sub Frm_Patient_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btn_ajouter_Click(sender As Object, e As EventArgs) Handles btn_ajouter.Click
        btn_ajouter.BackColor = Color.Green
        Dim p As Patient
        With p
            .code = txt_code.Text
            .Nom = txt_nom.Text
            .Prenom = txt_prenom.Text
        End With
        Ajouter_Patient(p)
        MessageBox.Show("patient ajouté avec succés")

    End Sub

    Private Sub btn_annuler_Click(sender As Object, e As EventArgs) Handles btn_annuler.Click
        btn_annuler.BackColor = Color.Red
        txt_code.Clear()
        txt_nom.Clear()
        txt_prenom.Clear()
    End Sub

    Private Sub Btn_supprimer_Click(sender As Object, e As EventArgs) Handles Btn_supprimer.Click
        Btn_supprimer.BackColor = Color.Yellow
        Dim code As String = txt_code.Text
        Dim Nom As String = txt_nom.Text
        Dim Prenom As String = txt_prenom.Text
        Delete(code, Nom, Prenom)
    End Sub

End Class