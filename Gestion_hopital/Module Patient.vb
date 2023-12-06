Imports System.Data.SqlClient
Module Module_Patient
    Dim Connexion As String = ("Data Source=DESKTOP-4GLI3ED\SQLEXPRESS;Initial Catalog=gestion_Hopital;Integrated Security=True")
    Dim Cn As New SqlConnection
    Public Structure Patient
        Dim code As String
        Dim Nom As String
        Dim Prenom As String
    End Structure
    Dim nb As Integer = 0

    Public Sub Ajouter_Patient(P As Patient)
        Using Cn As New SqlConnection(Connexion)
            Cn.Open()
            Dim req As String = "INSERT INTO T_Patient (Code, Nom, Prenom) VALUES (@Code, @Nom, @Prenom)"
            Using Command As New SqlCommand(req, Cn)

                Command.Parameters.AddWithValue("@Code", P.code)
                Command.Parameters.AddWithValue("@Nom", P.Nom)
                Command.Parameters.AddWithValue("@Prenom", P.Prenom)
                Command.ExecuteNonQuery()
                MsgBox("Patient ajouté avec succées")
            End Using
        End Using
    End Sub
    Public Sub Afficher_Patient()
        Using Cn As New SqlConnection(Connexion)
            Cn.Open()
            Dim req As String = "SELECT* FROM T_Patient "
            Using Command As New SqlCommand(req, Cn)
                Dim sda As New SqlDataAdapter(Command)
                Dim dt As New DataTable
                sda.Fill(dt)
                Form_AffichPatients.dgv_AffichPatients.DataSource = dt
            End Using
        End Using
    End Sub
    Public Sub Delete(Code As String, NOM As String, Prenom As String)
        Using Cn As New SqlConnection(Connexion)
            Cn.Open()
            Dim reqDelete As String = "DELETE FROM T_Patient WHERE Code = @Code AND Nom = @Nom AND Prenom = @Prenom"
            Using CommandDelete As New SqlCommand(reqDelete, Cn)
                CommandDelete.Parameters.AddWithValue("@Code", Code)
                CommandDelete.Parameters.AddWithValue("@Nom", NOM)
                CommandDelete.Parameters.AddWithValue("@Prenom", Prenom)
                CommandDelete.ExecuteNonQuery()

                MsgBox("Rendez-vous supprimé avec succès.")
            End Using
        End Using
    End Sub

End Module
