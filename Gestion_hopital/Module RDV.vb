Imports System.Data.SqlClient
Module Module_RDV
    Dim Connexion As String = ("Data Source=DESKTOP-4GLI3ED\SQLEXPRESS;Initial Catalog=gestion_Hopital;Integrated Security=True")
    Dim Cn As New SqlConnection
    Public Structure RDV
        Dim code As String
        Dim D As Date
        Dim H As String
    End Structure
    Public Sub Afficher_RDV()
        Using Cn As New SqlConnection(Connexion)
            Cn.Open()
            Dim req As String = "SELECT* FROM T_RDV "
            Using Command As New SqlCommand(req, Cn)
                Dim sda As New SqlDataAdapter(Command)
                Dim dt As New DataTable
                sda.Fill(dt)
                Form_AffichRDV.dgv_AffichRDV.DataSource = dt
            End Using
        End Using
    End Sub
    Public Sub AfficherRDVsDuJour()
        Using Cn As New SqlConnection(Connexion)
            Dim DateDuJour As Date = Date.Now.Date
            Cn.Open()
            Dim req As String = "SELECT* FROM T_RDV WHERE Date = @DateDuJour"
            Using Command As New SqlCommand(req, Cn)
                Command.Parameters.AddWithValue("@DateDuJour", DateDuJour)
                Dim SDA As New SqlDataAdapter(Command)
                Dim DT As New DataTable
                SDA.Fill(DT)
                Form_AffichRDV.dgv_AffichRDV.DataSource = DT
            End Using
        End Using
    End Sub
    Public Function PatientExiste(code As String) As Boolean
        Using Cn As New SqlConnection(Connexion)
            Cn.Open()
            Dim req As String = "Select COUNT(*) FROM T_Patient WHERE Code = @Code"
            Using Command As New SqlCommand(req, Cn)
                Command.Parameters.AddWithValue("@Code", code)
                Dim count As Integer = (Command.ExecuteScalar())
                Return count > 0
            End Using
        End Using
    End Function
    Public Sub Ajouter_RDV_Avec_Verification(rdv As RDV)
        If PatientExiste(rdv.code) Then
            Using Cn As New SqlConnection(Connexion)
                Cn.Open()
                Dim req As String = "INSERT INTO T_RDV (Code, Date, heure) VALUES (@CodePatient, @DateRDV, @HeureRDV)"
                Using Command As New SqlCommand(req, Cn)
                    Command.Parameters.AddWithValue("@CodePatient", rdv.code)
                    Command.Parameters.AddWithValue("@DateRDV", rdv.D)
                    Command.Parameters.AddWithValue("@HeureRDV", rdv.H)
                    Command.ExecuteNonQuery()
                    MsgBox("Rendez-vous ajouté avec succès.")
                End Using
            End Using
        Else

            MsgBox("Le patient avec le code " & rdv.code & " n'existe pas.")
        End If

    End Sub
    Public Sub Supprimer(codePatient As String, dateRDV As Date, heureRDV As String)
        Using Cn As New SqlConnection(Connexion)
            Cn.Open()
            Dim reqDelete As String = "DELETE FROM T_RDV WHERE Code = @Code AND Date = @DateRDV AND heure = @HeureRDV"
            Using CommandDelete As New SqlCommand(reqDelete, Cn)
                CommandDelete.Parameters.AddWithValue("@Code", codePatient)
                CommandDelete.Parameters.AddWithValue("@DateRDV", dateRDV)
                CommandDelete.Parameters.AddWithValue("@HeureRDV", heureRDV)
                CommandDelete.ExecuteNonQuery()

                MsgBox("Rendez-vous supprimé avec succès.")
            End Using
        End Using
    End Sub


End Module
