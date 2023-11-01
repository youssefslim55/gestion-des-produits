<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_authentifier
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_authentifier))
        Me.lbl_NomUtilisateur = New System.Windows.Forms.Label()
        Me.lbl_Motdepasse = New System.Windows.Forms.Label()
        Me.txt_NomUtilisateur = New System.Windows.Forms.TextBox()
        Me.txt_Motdepasse = New System.Windows.Forms.TextBox()
        Me.btn_valider = New System.Windows.Forms.Button()
        Me.btn_annuler = New System.Windows.Forms.Button()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_NomUtilisateur
        '
        Me.lbl_NomUtilisateur.AutoSize = True
        Me.lbl_NomUtilisateur.BackColor = System.Drawing.Color.Transparent
        Me.lbl_NomUtilisateur.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_NomUtilisateur.ForeColor = System.Drawing.Color.White
        Me.lbl_NomUtilisateur.Location = New System.Drawing.Point(206, 164)
        Me.lbl_NomUtilisateur.Name = "lbl_NomUtilisateur"
        Me.lbl_NomUtilisateur.Size = New System.Drawing.Size(171, 25)
        Me.lbl_NomUtilisateur.TabIndex = 0
        Me.lbl_NomUtilisateur.Text = "Nom Utilisateur :" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'lbl_Motdepasse
        '
        Me.lbl_Motdepasse.AutoSize = True
        Me.lbl_Motdepasse.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Motdepasse.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Motdepasse.ForeColor = System.Drawing.Color.White
        Me.lbl_Motdepasse.Location = New System.Drawing.Point(206, 237)
        Me.lbl_Motdepasse.Name = "lbl_Motdepasse"
        Me.lbl_Motdepasse.Size = New System.Drawing.Size(157, 25)
        Me.lbl_Motdepasse.TabIndex = 1
        Me.lbl_Motdepasse.Text = "Mot de Passe :"
        '
        'txt_NomUtilisateur
        '
        Me.txt_NomUtilisateur.Location = New System.Drawing.Point(428, 164)
        Me.txt_NomUtilisateur.Name = "txt_NomUtilisateur"
        Me.txt_NomUtilisateur.Size = New System.Drawing.Size(227, 22)
        Me.txt_NomUtilisateur.TabIndex = 2
        '
        'txt_Motdepasse
        '
        Me.txt_Motdepasse.Location = New System.Drawing.Point(428, 232)
        Me.txt_Motdepasse.Name = "txt_Motdepasse"
        Me.txt_Motdepasse.Size = New System.Drawing.Size(227, 22)
        Me.txt_Motdepasse.TabIndex = 3
        Me.txt_Motdepasse.UseSystemPasswordChar = True
        '
        'btn_valider
        '
        Me.btn_valider.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_valider.Location = New System.Drawing.Point(553, 319)
        Me.btn_valider.Name = "btn_valider"
        Me.btn_valider.Size = New System.Drawing.Size(102, 32)
        Me.btn_valider.TabIndex = 4
        Me.btn_valider.Text = "Valider"
        Me.btn_valider.UseVisualStyleBackColor = True
        '
        'btn_annuler
        '
        Me.btn_annuler.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_annuler.Location = New System.Drawing.Point(428, 319)
        Me.btn_annuler.Name = "btn_annuler"
        Me.btn_annuler.Size = New System.Drawing.Size(95, 32)
        Me.btn_annuler.TabIndex = 5
        Me.btn_annuler.Text = "Annuler"
        Me.btn_annuler.UseVisualStyleBackColor = True
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(498, 69)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(76, 56)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 8
        Me.PictureBox3.TabStop = False
        '
        'frm_authentifier
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1079, 472)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.btn_annuler)
        Me.Controls.Add(Me.btn_valider)
        Me.Controls.Add(Me.txt_Motdepasse)
        Me.Controls.Add(Me.txt_NomUtilisateur)
        Me.Controls.Add(Me.lbl_Motdepasse)
        Me.Controls.Add(Me.lbl_NomUtilisateur)
        Me.Name = "frm_authentifier"
        Me.Text = "login"
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_NomUtilisateur As Label
    Friend WithEvents lbl_Motdepasse As Label
    Friend WithEvents txt_NomUtilisateur As TextBox
    Friend WithEvents txt_Motdepasse As TextBox
    Friend WithEvents btn_valider As Button
    Friend WithEvents btn_annuler As Button
    Friend WithEvents PictureBox3 As PictureBox
End Class
