<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form_AffichRDV
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
        Me.dgv_AffichRDV = New System.Windows.Forms.DataGridView()
        Me.btn_RDVDuJour = New System.Windows.Forms.Button()
        CType(Me.dgv_AffichRDV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgv_AffichRDV
        '
        Me.dgv_AffichRDV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_AffichRDV.Location = New System.Drawing.Point(101, 12)
        Me.dgv_AffichRDV.Name = "dgv_AffichRDV"
        Me.dgv_AffichRDV.Size = New System.Drawing.Size(338, 171)
        Me.dgv_AffichRDV.TabIndex = 0
        '
        'btn_RDVDuJour
        '
        Me.btn_RDVDuJour.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_RDVDuJour.Font = New System.Drawing.Font("Bell MT", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_RDVDuJour.ForeColor = System.Drawing.Color.White
        Me.btn_RDVDuJour.Location = New System.Drawing.Point(213, 198)
        Me.btn_RDVDuJour.Name = "btn_RDVDuJour"
        Me.btn_RDVDuJour.Size = New System.Drawing.Size(122, 23)
        Me.btn_RDVDuJour.TabIndex = 2
        Me.btn_RDVDuJour.Text = "RDV Du Jour"
        Me.btn_RDVDuJour.UseVisualStyleBackColor = False
        '
        'Form_AffichRDV
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(548, 233)
        Me.Controls.Add(Me.btn_RDVDuJour)
        Me.Controls.Add(Me.dgv_AffichRDV)
        Me.Name = "Form_AffichRDV"
        Me.Text = "Form_AffichRDV"
        CType(Me.dgv_AffichRDV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgv_AffichRDV As DataGridView
    Friend WithEvents btn_RDVDuJour As Button
End Class
