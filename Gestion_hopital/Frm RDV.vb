
Imports System.Data.SqlClient
Public Class Frm_RDV
    Dim Connexion As New SqlConnection("Data Source=DESKTOP-4GLI3ED\SQLEXPRESS;Initial Catalog=DataBase RDV;Integrated Security=True")
    Private Sub btn_Ajouteer_Click(sender As Object, e As EventArgs) Handles btn_Ajouteer.Click
        btn_Ajouteer.BackColor = Color.Green
        Dim codePatient As String = Txt_CodePatient.Text
        Dim dateRDV As Date = txt_Date.Text
        Dim heureRDV As String = txt_Heure.Text

        Dim nouveauRDV As New RDV
        With nouveauRDV
            .code = codePatient
        .D = dateRDV
        .H = heureRDV

        End With

        Ajouter_RDV_Avec_Verification(nouveauRDV)


    End Sub


    Private Sub btn_Annuleer_Click(sender As Object, e As EventArgs) Handles btn_Annuleer.Click
        btn_Annuleer.BackColor = Color.Red
        Txt_CodePatient.Text = ""
        txt_Date.Text = ""
        txt_Heure.Text = ""
    End Sub

    Private Sub btn_supprimer_Click(sender As Object, e As EventArgs) Handles btn_supprimer.Click
        btn_supprimer.BackColor = Color.Yellow
        Dim CodePatient As String = Txt_CodePatient.Text
        Dim dateRDV As Date = txt_Date.Text
        Dim heureRDV As String = txt_Heure.Text
        Supprimer(CodePatient, dateRDV, heureRDV)
    End Sub


End Class

