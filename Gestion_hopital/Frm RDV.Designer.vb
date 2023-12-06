<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frm_RDV
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.lbl_CodePatient = New System.Windows.Forms.Label()
        Me.lbl_Date = New System.Windows.Forms.Label()
        Me.Txt_CodePatient = New System.Windows.Forms.TextBox()
        Me.txt_Date = New System.Windows.Forms.TextBox()
        Me.btn_Ajouteer = New System.Windows.Forms.Button()
        Me.btn_Annuleer = New System.Windows.Forms.Button()
        Me.lbl_Heure = New System.Windows.Forms.Label()
        Me.txt_Heure = New System.Windows.Forms.TextBox()
        Me.btn_supprimer = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lbl_CodePatient
        '
        Me.lbl_CodePatient.AutoSize = True
        Me.lbl_CodePatient.Font = New System.Drawing.Font("Bell MT", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_CodePatient.Location = New System.Drawing.Point(33, 38)
        Me.lbl_CodePatient.Name = "lbl_CodePatient"
        Me.lbl_CodePatient.Size = New System.Drawing.Size(81, 17)
        Me.lbl_CodePatient.TabIndex = 0
        Me.lbl_CodePatient.Text = "Code Patient"
        '
        'lbl_Date
        '
        Me.lbl_Date.AutoSize = True
        Me.lbl_Date.Font = New System.Drawing.Font("Bell MT", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Date.Location = New System.Drawing.Point(52, 100)
        Me.lbl_Date.Name = "lbl_Date"
        Me.lbl_Date.Size = New System.Drawing.Size(35, 17)
        Me.lbl_Date.TabIndex = 1
        Me.lbl_Date.Text = "Date"
        '
        'Txt_CodePatient
        '
        Me.Txt_CodePatient.Location = New System.Drawing.Point(136, 35)
        Me.Txt_CodePatient.Name = "Txt_CodePatient"
        Me.Txt_CodePatient.Size = New System.Drawing.Size(100, 20)
        Me.Txt_CodePatient.TabIndex = 3
        '
        'txt_Date
        '
        Me.txt_Date.Location = New System.Drawing.Point(136, 101)
        Me.txt_Date.Name = "txt_Date"
        Me.txt_Date.Size = New System.Drawing.Size(100, 20)
        Me.txt_Date.TabIndex = 4
        '
        'btn_Ajouteer
        '
        Me.btn_Ajouteer.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_Ajouteer.Font = New System.Drawing.Font("Bell MT", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Ajouteer.Location = New System.Drawing.Point(287, 35)
        Me.btn_Ajouteer.Name = "btn_Ajouteer"
        Me.btn_Ajouteer.Size = New System.Drawing.Size(75, 23)
        Me.btn_Ajouteer.TabIndex = 6
        Me.btn_Ajouteer.Text = "Ajouter"
        Me.btn_Ajouteer.UseVisualStyleBackColor = False
        '
        'btn_Annuleer
        '
        Me.btn_Annuleer.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_Annuleer.Font = New System.Drawing.Font("Bell MT", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Annuleer.Location = New System.Drawing.Point(287, 165)
        Me.btn_Annuleer.Name = "btn_Annuleer"
        Me.btn_Annuleer.Size = New System.Drawing.Size(75, 23)
        Me.btn_Annuleer.TabIndex = 7
        Me.btn_Annuleer.Text = "Annuler"
        Me.btn_Annuleer.UseVisualStyleBackColor = False
        '
        'lbl_Heure
        '
        Me.lbl_Heure.AutoSize = True
        Me.lbl_Heure.Font = New System.Drawing.Font("Bell MT", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Heure.Location = New System.Drawing.Point(52, 166)
        Me.lbl_Heure.Name = "lbl_Heure"
        Me.lbl_Heure.Size = New System.Drawing.Size(42, 17)
        Me.lbl_Heure.TabIndex = 8
        Me.lbl_Heure.Text = "Heure"
        '
        'txt_Heure
        '
        Me.txt_Heure.Location = New System.Drawing.Point(136, 166)
        Me.txt_Heure.Name = "txt_Heure"
        Me.txt_Heure.Size = New System.Drawing.Size(100, 20)
        Me.txt_Heure.TabIndex = 9
        '
        'btn_supprimer
        '
        Me.btn_supprimer.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_supprimer.Font = New System.Drawing.Font("Bell MT", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_supprimer.Location = New System.Drawing.Point(287, 101)
        Me.btn_supprimer.Name = "btn_supprimer"
        Me.btn_supprimer.Size = New System.Drawing.Size(75, 23)
        Me.btn_supprimer.TabIndex = 10
        Me.btn_supprimer.Text = "Supprimer"
        Me.btn_supprimer.UseVisualStyleBackColor = False
        '
        'Frm_RDV
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(387, 271)
        Me.Controls.Add(Me.btn_supprimer)
        Me.Controls.Add(Me.txt_Heure)
        Me.Controls.Add(Me.lbl_Heure)
        Me.Controls.Add(Me.btn_Annuleer)
        Me.Controls.Add(Me.btn_Ajouteer)
        Me.Controls.Add(Me.txt_Date)
        Me.Controls.Add(Me.Txt_CodePatient)
        Me.Controls.Add(Me.lbl_Date)
        Me.Controls.Add(Me.lbl_CodePatient)
        Me.Name = "Frm_RDV"
        Me.Text = "Frm_RDV"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_CodePatient As Label
    Friend WithEvents lbl_Date As Label
    Friend WithEvents Txt_CodePatient As TextBox
    Friend WithEvents txt_Date As TextBox
    Friend WithEvents btn_Ajouteer As Button
    Friend WithEvents btn_Annuleer As Button
    Friend WithEvents lbl_Heure As Label
    Friend WithEvents txt_Heure As TextBox
    Friend WithEvents btn_supprimer As Button
End Class
