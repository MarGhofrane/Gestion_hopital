<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Patient
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lbl_code = New System.Windows.Forms.Label()
        Me.lbl_nom = New System.Windows.Forms.Label()
        Me.lbl_prenom = New System.Windows.Forms.Label()
        Me.txt_code = New System.Windows.Forms.TextBox()
        Me.txt_nom = New System.Windows.Forms.TextBox()
        Me.txt_prenom = New System.Windows.Forms.TextBox()
        Me.btn_ajouter = New System.Windows.Forms.Button()
        Me.btn_annuler = New System.Windows.Forms.Button()
        Me.Btn_supprimer = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lbl_code
        '
        Me.lbl_code.AutoSize = True
        Me.lbl_code.Font = New System.Drawing.Font("Bell MT", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_code.Location = New System.Drawing.Point(24, 47)
        Me.lbl_code.Name = "lbl_code"
        Me.lbl_code.Size = New System.Drawing.Size(37, 17)
        Me.lbl_code.TabIndex = 0
        Me.lbl_code.Text = "Code"
        '
        'lbl_nom
        '
        Me.lbl_nom.AutoSize = True
        Me.lbl_nom.Font = New System.Drawing.Font("Bell MT", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_nom.Location = New System.Drawing.Point(27, 113)
        Me.lbl_nom.Name = "lbl_nom"
        Me.lbl_nom.Size = New System.Drawing.Size(35, 17)
        Me.lbl_nom.TabIndex = 1
        Me.lbl_nom.Text = "Nom"
        '
        'lbl_prenom
        '
        Me.lbl_prenom.AutoSize = True
        Me.lbl_prenom.Font = New System.Drawing.Font("Bell MT", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_prenom.Location = New System.Drawing.Point(27, 180)
        Me.lbl_prenom.Name = "lbl_prenom"
        Me.lbl_prenom.Size = New System.Drawing.Size(51, 17)
        Me.lbl_prenom.TabIndex = 2
        Me.lbl_prenom.Text = "Prenom"
        '
        'txt_code
        '
        Me.txt_code.Location = New System.Drawing.Point(113, 47)
        Me.txt_code.Name = "txt_code"
        Me.txt_code.Size = New System.Drawing.Size(100, 20)
        Me.txt_code.TabIndex = 3
        '
        'txt_nom
        '
        Me.txt_nom.Location = New System.Drawing.Point(124, 110)
        Me.txt_nom.Name = "txt_nom"
        Me.txt_nom.Size = New System.Drawing.Size(100, 20)
        Me.txt_nom.TabIndex = 4
        '
        'txt_prenom
        '
        Me.txt_prenom.Location = New System.Drawing.Point(124, 177)
        Me.txt_prenom.Name = "txt_prenom"
        Me.txt_prenom.Size = New System.Drawing.Size(100, 20)
        Me.txt_prenom.TabIndex = 5
        '
        'btn_ajouter
        '
        Me.btn_ajouter.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_ajouter.Font = New System.Drawing.Font("Bell MT", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_ajouter.Location = New System.Drawing.Point(302, 47)
        Me.btn_ajouter.Name = "btn_ajouter"
        Me.btn_ajouter.Size = New System.Drawing.Size(75, 23)
        Me.btn_ajouter.TabIndex = 6
        Me.btn_ajouter.Text = "Ajouter"
        Me.btn_ajouter.UseVisualStyleBackColor = False
        '
        'btn_annuler
        '
        Me.btn_annuler.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_annuler.Font = New System.Drawing.Font("Bell MT", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_annuler.Location = New System.Drawing.Point(302, 113)
        Me.btn_annuler.Name = "btn_annuler"
        Me.btn_annuler.Size = New System.Drawing.Size(75, 23)
        Me.btn_annuler.TabIndex = 7
        Me.btn_annuler.Text = "Annuler"
        Me.btn_annuler.UseVisualStyleBackColor = False
        '
        'Btn_supprimer
        '
        Me.Btn_supprimer.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Btn_supprimer.Font = New System.Drawing.Font("Bell MT", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_supprimer.Location = New System.Drawing.Point(302, 174)
        Me.Btn_supprimer.Name = "Btn_supprimer"
        Me.Btn_supprimer.Size = New System.Drawing.Size(75, 23)
        Me.Btn_supprimer.TabIndex = 8
        Me.Btn_supprimer.Text = "supprimer"
        Me.Btn_supprimer.UseVisualStyleBackColor = False
        '
        'Frm_Patient
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(408, 280)
        Me.Controls.Add(Me.Btn_supprimer)
        Me.Controls.Add(Me.btn_annuler)
        Me.Controls.Add(Me.btn_ajouter)
        Me.Controls.Add(Me.txt_prenom)
        Me.Controls.Add(Me.txt_nom)
        Me.Controls.Add(Me.txt_code)
        Me.Controls.Add(Me.lbl_prenom)
        Me.Controls.Add(Me.lbl_nom)
        Me.Controls.Add(Me.lbl_code)
        Me.Name = "Frm_Patient"
        Me.Text = "Frm_Patient"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_code As Label
    Friend WithEvents lbl_nom As Label
    Friend WithEvents lbl_prenom As Label
    Friend WithEvents txt_code As TextBox
    Friend WithEvents txt_nom As TextBox
    Friend WithEvents txt_prenom As TextBox
    Friend WithEvents btn_ajouter As Button
    Friend WithEvents btn_annuler As Button
    Friend WithEvents Btn_supprimer As Button
End Class
