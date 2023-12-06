<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frm_Menu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Menu))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MenuStrip2 = New System.Windows.Forms.MenuStrip()
        Me.PatientToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AjoutpatientToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AfficherpatientToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RDVToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AfficherRDVToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RendreRDVToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MenuStrip2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(384, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MenuStrip2
        '
        Me.MenuStrip2.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PatientToolStripMenuItem, Me.RDVToolStripMenuItem})
        Me.MenuStrip2.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip2.Name = "MenuStrip2"
        Me.MenuStrip2.Size = New System.Drawing.Size(105, 24)
        Me.MenuStrip2.TabIndex = 1
        Me.MenuStrip2.Text = "MenuStrip2"
        '
        'PatientToolStripMenuItem
        '
        Me.PatientToolStripMenuItem.BackColor = System.Drawing.Color.Teal
        Me.PatientToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AjoutpatientToolStripMenuItem, Me.AfficherpatientToolStripMenuItem})
        Me.PatientToolStripMenuItem.Name = "PatientToolStripMenuItem"
        Me.PatientToolStripMenuItem.Size = New System.Drawing.Size(56, 20)
        Me.PatientToolStripMenuItem.Text = "Patient"
        '
        'AjoutpatientToolStripMenuItem
        '
        Me.AjoutpatientToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.AjoutpatientToolStripMenuItem.Name = "AjoutpatientToolStripMenuItem"
        Me.AjoutpatientToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.AjoutpatientToolStripMenuItem.Text = "ajout_patient"
        '
        'AfficherpatientToolStripMenuItem
        '
        Me.AfficherpatientToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.AfficherpatientToolStripMenuItem.Name = "AfficherpatientToolStripMenuItem"
        Me.AfficherpatientToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.AfficherpatientToolStripMenuItem.Text = "afficher_patient"
        '
        'RDVToolStripMenuItem
        '
        Me.RDVToolStripMenuItem.BackColor = System.Drawing.Color.Teal
        Me.RDVToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AfficherRDVToolStripMenuItem, Me.RendreRDVToolStripMenuItem})
        Me.RDVToolStripMenuItem.Name = "RDVToolStripMenuItem"
        Me.RDVToolStripMenuItem.Size = New System.Drawing.Size(41, 20)
        Me.RDVToolStripMenuItem.Text = "RDV"
        '
        'AfficherRDVToolStripMenuItem
        '
        Me.AfficherRDVToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.AfficherRDVToolStripMenuItem.Name = "AfficherRDVToolStripMenuItem"
        Me.AfficherRDVToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.AfficherRDVToolStripMenuItem.Text = "afficher_RDV"
        '
        'RendreRDVToolStripMenuItem
        '
        Me.RendreRDVToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.RendreRDVToolStripMenuItem.Name = "RendreRDVToolStripMenuItem"
        Me.RendreRDVToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.RendreRDVToolStripMenuItem.Text = "rendre_RDV"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(-8, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(392, 240)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'Frm_Menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(384, 241)
        Me.Controls.Add(Me.MenuStrip2)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.PictureBox1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Frm_Menu"
        Me.Text = "Form1"
        Me.MenuStrip2.ResumeLayout(False)
        Me.MenuStrip2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MenuStrip2 As MenuStrip
    Friend WithEvents PatientToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AjoutpatientToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AfficherpatientToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RDVToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AfficherRDVToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RendreRDVToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PictureBox1 As PictureBox
End Class
