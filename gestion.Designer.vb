<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_gestion
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_gestion))
        Me.lbl_produit = New System.Windows.Forms.Label()
        Me.lbl_Prixunitaire = New System.Windows.Forms.Label()
        Me.lbl_Quantité = New System.Windows.Forms.Label()
        Me.lbl_MontantHT = New System.Windows.Forms.Label()
        Me.cmb_Produit = New System.Windows.Forms.ComboBox()
        Me.txt_Prixunitaire = New System.Windows.Forms.TextBox()
        Me.cmb_Qunatité = New System.Windows.Forms.ComboBox()
        Me.txt_MontantHT = New System.Windows.Forms.TextBox()
        Me.btn_Ajouter = New System.Windows.Forms.Button()
        Me.btn_Supprimer = New System.Windows.Forms.Button()
        Me.btn_Vider = New System.Windows.Forms.Button()
        Me.lst__AFFProduit = New System.Windows.Forms.ListBox()
        Me.lst_AFFPrixunitaire = New System.Windows.Forms.ListBox()
        Me.lst_AFFquantité = New System.Windows.Forms.ListBox()
        Me.lst_AFFmontantHT = New System.Windows.Forms.ListBox()
        Me.lbl_Total = New System.Windows.Forms.Label()
        Me.txt_totalpxunitaire = New System.Windows.Forms.TextBox()
        Me.txt_totalquantité = New System.Windows.Forms.TextBox()
        Me.txt_totalmontantHT = New System.Windows.Forms.TextBox()
        Me.btn_calculer = New System.Windows.Forms.Button()
        Me.txt_Tva = New System.Windows.Forms.TextBox()
        Me.txt_remise = New System.Windows.Forms.TextBox()
        Me.lbl_remise = New System.Windows.Forms.Label()
        Me.lbl_Tva = New System.Windows.Forms.Label()
        Me.lbl_TTC = New System.Windows.Forms.Label()
        Me.txt_TTC = New System.Windows.Forms.TextBox()
        Me.btn_modifier = New System.Windows.Forms.Button()
        Me.btn_quitter = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_produit
        '
        Me.lbl_produit.AutoSize = True
        Me.lbl_produit.BackColor = System.Drawing.Color.Transparent
        Me.lbl_produit.Font = New System.Drawing.Font("Perpetua Titling MT", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_produit.ForeColor = System.Drawing.Color.White
        Me.lbl_produit.Location = New System.Drawing.Point(142, 28)
        Me.lbl_produit.Name = "lbl_produit"
        Me.lbl_produit.Size = New System.Drawing.Size(116, 23)
        Me.lbl_produit.TabIndex = 0
        Me.lbl_produit.Text = "Produit :"
        '
        'lbl_Prixunitaire
        '
        Me.lbl_Prixunitaire.AutoSize = True
        Me.lbl_Prixunitaire.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Prixunitaire.Font = New System.Drawing.Font("Perpetua Titling MT", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Prixunitaire.ForeColor = System.Drawing.Color.White
        Me.lbl_Prixunitaire.Location = New System.Drawing.Point(142, 77)
        Me.lbl_Prixunitaire.Name = "lbl_Prixunitaire"
        Me.lbl_Prixunitaire.Size = New System.Drawing.Size(177, 23)
        Me.lbl_Prixunitaire.TabIndex = 1
        Me.lbl_Prixunitaire.Text = "Prix Unitaire :"
        '
        'lbl_Quantité
        '
        Me.lbl_Quantité.AutoSize = True
        Me.lbl_Quantité.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Quantité.Font = New System.Drawing.Font("Perpetua Titling MT", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Quantité.ForeColor = System.Drawing.Color.Transparent
        Me.lbl_Quantité.Location = New System.Drawing.Point(142, 118)
        Me.lbl_Quantité.Name = "lbl_Quantité"
        Me.lbl_Quantité.Size = New System.Drawing.Size(128, 23)
        Me.lbl_Quantité.TabIndex = 2
        Me.lbl_Quantité.Text = "Quantité :"
        '
        'lbl_MontantHT
        '
        Me.lbl_MontantHT.AutoSize = True
        Me.lbl_MontantHT.BackColor = System.Drawing.Color.Transparent
        Me.lbl_MontantHT.Font = New System.Drawing.Font("Perpetua Titling MT", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_MontantHT.ForeColor = System.Drawing.Color.White
        Me.lbl_MontantHT.Location = New System.Drawing.Point(142, 165)
        Me.lbl_MontantHT.Name = "lbl_MontantHT"
        Me.lbl_MontantHT.Size = New System.Drawing.Size(164, 23)
        Me.lbl_MontantHT.TabIndex = 3
        Me.lbl_MontantHT.Text = "Montant HT :"
        '
        'cmb_Produit
        '
        Me.cmb_Produit.FormattingEnabled = True
        Me.cmb_Produit.Items.AddRange(New Object() {"clavier ", "souris", "casque", "tapis"})
        Me.cmb_Produit.Location = New System.Drawing.Point(368, 30)
        Me.cmb_Produit.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cmb_Produit.Name = "cmb_Produit"
        Me.cmb_Produit.Size = New System.Drawing.Size(147, 24)
        Me.cmb_Produit.TabIndex = 4
        '
        'txt_Prixunitaire
        '
        Me.txt_Prixunitaire.Location = New System.Drawing.Point(368, 77)
        Me.txt_Prixunitaire.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_Prixunitaire.Name = "txt_Prixunitaire"
        Me.txt_Prixunitaire.ReadOnly = True
        Me.txt_Prixunitaire.Size = New System.Drawing.Size(147, 22)
        Me.txt_Prixunitaire.TabIndex = 5
        '
        'cmb_Qunatité
        '
        Me.cmb_Qunatité.FormattingEnabled = True
        Me.cmb_Qunatité.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15"})
        Me.cmb_Qunatité.Location = New System.Drawing.Point(368, 120)
        Me.cmb_Qunatité.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cmb_Qunatité.Name = "cmb_Qunatité"
        Me.cmb_Qunatité.Size = New System.Drawing.Size(147, 24)
        Me.cmb_Qunatité.TabIndex = 6
        '
        'txt_MontantHT
        '
        Me.txt_MontantHT.Location = New System.Drawing.Point(368, 167)
        Me.txt_MontantHT.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_MontantHT.Name = "txt_MontantHT"
        Me.txt_MontantHT.ReadOnly = True
        Me.txt_MontantHT.Size = New System.Drawing.Size(147, 22)
        Me.txt_MontantHT.TabIndex = 7
        '
        'btn_Ajouter
        '
        Me.btn_Ajouter.BackColor = System.Drawing.Color.White
        Me.btn_Ajouter.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Ajouter.Location = New System.Drawing.Point(635, 28)
        Me.btn_Ajouter.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_Ajouter.Name = "btn_Ajouter"
        Me.btn_Ajouter.Size = New System.Drawing.Size(109, 39)
        Me.btn_Ajouter.TabIndex = 8
        Me.btn_Ajouter.Text = "Ajouter"
        Me.btn_Ajouter.UseVisualStyleBackColor = False
        '
        'btn_Supprimer
        '
        Me.btn_Supprimer.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Supprimer.Location = New System.Drawing.Point(883, 331)
        Me.btn_Supprimer.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_Supprimer.Name = "btn_Supprimer"
        Me.btn_Supprimer.Size = New System.Drawing.Size(109, 30)
        Me.btn_Supprimer.TabIndex = 9
        Me.btn_Supprimer.Text = "Supprimer"
        Me.btn_Supprimer.UseVisualStyleBackColor = True
        '
        'btn_Vider
        '
        Me.btn_Vider.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Vider.Location = New System.Drawing.Point(635, 149)
        Me.btn_Vider.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_Vider.Name = "btn_Vider"
        Me.btn_Vider.Size = New System.Drawing.Size(109, 39)
        Me.btn_Vider.TabIndex = 10
        Me.btn_Vider.Text = "Vider"
        Me.btn_Vider.UseVisualStyleBackColor = True
        '
        'lst__AFFProduit
        '
        Me.lst__AFFProduit.FormattingEnabled = True
        Me.lst__AFFProduit.ItemHeight = 16
        Me.lst__AFFProduit.Location = New System.Drawing.Point(91, 272)
        Me.lst__AFFProduit.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.lst__AFFProduit.Name = "lst__AFFProduit"
        Me.lst__AFFProduit.Size = New System.Drawing.Size(115, 148)
        Me.lst__AFFProduit.TabIndex = 11
        '
        'lst_AFFPrixunitaire
        '
        Me.lst_AFFPrixunitaire.FormattingEnabled = True
        Me.lst_AFFPrixunitaire.ItemHeight = 16
        Me.lst_AFFPrixunitaire.Location = New System.Drawing.Point(299, 272)
        Me.lst_AFFPrixunitaire.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.lst_AFFPrixunitaire.Name = "lst_AFFPrixunitaire"
        Me.lst_AFFPrixunitaire.Size = New System.Drawing.Size(115, 148)
        Me.lst_AFFPrixunitaire.TabIndex = 12
        '
        'lst_AFFquantité
        '
        Me.lst_AFFquantité.FormattingEnabled = True
        Me.lst_AFFquantité.ItemHeight = 16
        Me.lst_AFFquantité.Location = New System.Drawing.Point(500, 272)
        Me.lst_AFFquantité.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.lst_AFFquantité.Name = "lst_AFFquantité"
        Me.lst_AFFquantité.Size = New System.Drawing.Size(115, 148)
        Me.lst_AFFquantité.TabIndex = 13
        '
        'lst_AFFmontantHT
        '
        Me.lst_AFFmontantHT.FormattingEnabled = True
        Me.lst_AFFmontantHT.ItemHeight = 16
        Me.lst_AFFmontantHT.Location = New System.Drawing.Point(712, 272)
        Me.lst_AFFmontantHT.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.lst_AFFmontantHT.Name = "lst_AFFmontantHT"
        Me.lst_AFFmontantHT.Size = New System.Drawing.Size(115, 148)
        Me.lst_AFFmontantHT.TabIndex = 14
        '
        'lbl_Total
        '
        Me.lbl_Total.AutoSize = True
        Me.lbl_Total.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Total.Font = New System.Drawing.Font("Perpetua Titling MT", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Total.ForeColor = System.Drawing.Color.White
        Me.lbl_Total.Location = New System.Drawing.Point(142, 446)
        Me.lbl_Total.Name = "lbl_Total"
        Me.lbl_Total.Size = New System.Drawing.Size(89, 23)
        Me.lbl_Total.TabIndex = 15
        Me.lbl_Total.Text = "Total :"
        '
        'txt_totalpxunitaire
        '
        Me.txt_totalpxunitaire.Location = New System.Drawing.Point(299, 446)
        Me.txt_totalpxunitaire.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_totalpxunitaire.Name = "txt_totalpxunitaire"
        Me.txt_totalpxunitaire.ReadOnly = True
        Me.txt_totalpxunitaire.Size = New System.Drawing.Size(115, 22)
        Me.txt_totalpxunitaire.TabIndex = 16
        '
        'txt_totalquantité
        '
        Me.txt_totalquantité.Location = New System.Drawing.Point(500, 446)
        Me.txt_totalquantité.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_totalquantité.Name = "txt_totalquantité"
        Me.txt_totalquantité.ReadOnly = True
        Me.txt_totalquantité.Size = New System.Drawing.Size(115, 22)
        Me.txt_totalquantité.TabIndex = 17
        '
        'txt_totalmontantHT
        '
        Me.txt_totalmontantHT.Location = New System.Drawing.Point(712, 446)
        Me.txt_totalmontantHT.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_totalmontantHT.Name = "txt_totalmontantHT"
        Me.txt_totalmontantHT.ReadOnly = True
        Me.txt_totalmontantHT.Size = New System.Drawing.Size(115, 22)
        Me.txt_totalmontantHT.TabIndex = 18
        '
        'btn_calculer
        '
        Me.btn_calculer.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_calculer.Location = New System.Drawing.Point(883, 379)
        Me.btn_calculer.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_calculer.Name = "btn_calculer"
        Me.btn_calculer.Size = New System.Drawing.Size(109, 30)
        Me.btn_calculer.TabIndex = 19
        Me.btn_calculer.Text = "Calculer"
        Me.btn_calculer.UseVisualStyleBackColor = True
        '
        'txt_Tva
        '
        Me.txt_Tva.Location = New System.Drawing.Point(247, 521)
        Me.txt_Tva.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_Tva.Name = "txt_Tva"
        Me.txt_Tva.Size = New System.Drawing.Size(199, 22)
        Me.txt_Tva.TabIndex = 20
        '
        'txt_remise
        '
        Me.txt_remise.Location = New System.Drawing.Point(247, 582)
        Me.txt_remise.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_remise.Name = "txt_remise"
        Me.txt_remise.Size = New System.Drawing.Size(199, 22)
        Me.txt_remise.TabIndex = 21
        '
        'lbl_remise
        '
        Me.lbl_remise.AutoSize = True
        Me.lbl_remise.BackColor = System.Drawing.Color.Transparent
        Me.lbl_remise.Font = New System.Drawing.Font("Perpetua Titling MT", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_remise.ForeColor = System.Drawing.Color.White
        Me.lbl_remise.Location = New System.Drawing.Point(87, 581)
        Me.lbl_remise.Name = "lbl_remise"
        Me.lbl_remise.Size = New System.Drawing.Size(100, 23)
        Me.lbl_remise.TabIndex = 22
        Me.lbl_remise.Text = "Remise : "
        '
        'lbl_Tva
        '
        Me.lbl_Tva.AutoSize = True
        Me.lbl_Tva.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Tva.Font = New System.Drawing.Font("Perpetua Titling MT", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Tva.ForeColor = System.Drawing.Color.White
        Me.lbl_Tva.Location = New System.Drawing.Point(87, 519)
        Me.lbl_Tva.Name = "lbl_Tva"
        Me.lbl_Tva.Size = New System.Drawing.Size(111, 23)
        Me.lbl_Tva.TabIndex = 23
        Me.lbl_Tva.Text = "TVA 20% :"
        '
        'lbl_TTC
        '
        Me.lbl_TTC.AutoSize = True
        Me.lbl_TTC.BackColor = System.Drawing.Color.Transparent
        Me.lbl_TTC.Font = New System.Drawing.Font("Perpetua Titling MT", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_TTC.ForeColor = System.Drawing.Color.White
        Me.lbl_TTC.Location = New System.Drawing.Point(87, 637)
        Me.lbl_TTC.Name = "lbl_TTC"
        Me.lbl_TTC.Size = New System.Drawing.Size(61, 23)
        Me.lbl_TTC.TabIndex = 24
        Me.lbl_TTC.Text = "TTC :"
        '
        'txt_TTC
        '
        Me.txt_TTC.Location = New System.Drawing.Point(247, 637)
        Me.txt_TTC.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_TTC.Name = "txt_TTC"
        Me.txt_TTC.Size = New System.Drawing.Size(199, 22)
        Me.txt_TTC.TabIndex = 25
        '
        'btn_modifier
        '
        Me.btn_modifier.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_modifier.Location = New System.Drawing.Point(883, 283)
        Me.btn_modifier.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_modifier.Name = "btn_modifier"
        Me.btn_modifier.Size = New System.Drawing.Size(109, 30)
        Me.btn_modifier.TabIndex = 26
        Me.btn_modifier.Text = "Modifier"
        Me.btn_modifier.UseVisualStyleBackColor = True
        '
        'btn_quitter
        '
        Me.btn_quitter.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_quitter.Location = New System.Drawing.Point(635, 88)
        Me.btn_quitter.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_quitter.Name = "btn_quitter"
        Me.btn_quitter.Size = New System.Drawing.Size(109, 38)
        Me.btn_quitter.TabIndex = 27
        Me.btn_quitter.Text = "Quitter"
        Me.btn_quitter.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(834, 45)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(125, 121)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 28
        Me.PictureBox1.TabStop = False
        '
        'frm_gestion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1029, 711)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lbl_Prixunitaire)
        Me.Controls.Add(Me.btn_quitter)
        Me.Controls.Add(Me.btn_modifier)
        Me.Controls.Add(Me.txt_TTC)
        Me.Controls.Add(Me.lbl_TTC)
        Me.Controls.Add(Me.lbl_Tva)
        Me.Controls.Add(Me.lbl_remise)
        Me.Controls.Add(Me.txt_remise)
        Me.Controls.Add(Me.txt_Tva)
        Me.Controls.Add(Me.btn_calculer)
        Me.Controls.Add(Me.txt_totalmontantHT)
        Me.Controls.Add(Me.txt_totalquantité)
        Me.Controls.Add(Me.txt_totalpxunitaire)
        Me.Controls.Add(Me.lbl_Total)
        Me.Controls.Add(Me.lst_AFFmontantHT)
        Me.Controls.Add(Me.lst_AFFquantité)
        Me.Controls.Add(Me.lst_AFFPrixunitaire)
        Me.Controls.Add(Me.lst__AFFProduit)
        Me.Controls.Add(Me.btn_Vider)
        Me.Controls.Add(Me.btn_Supprimer)
        Me.Controls.Add(Me.btn_Ajouter)
        Me.Controls.Add(Me.txt_MontantHT)
        Me.Controls.Add(Me.cmb_Qunatité)
        Me.Controls.Add(Me.txt_Prixunitaire)
        Me.Controls.Add(Me.cmb_Produit)
        Me.Controls.Add(Me.lbl_MontantHT)
        Me.Controls.Add(Me.lbl_Quantité)
        Me.Controls.Add(Me.lbl_produit)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "frm_gestion"
        Me.Text = "gestion"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_produit As Label
    Friend WithEvents lbl_Prixunitaire As Label
    Friend WithEvents lbl_Quantité As Label
    Friend WithEvents lbl_MontantHT As Label
    Friend WithEvents cmb_Produit As ComboBox
    Friend WithEvents txt_Prixunitaire As TextBox
    Friend WithEvents cmb_Qunatité As ComboBox
    Friend WithEvents txt_MontantHT As TextBox
    Friend WithEvents btn_Ajouter As Button
    Friend WithEvents btn_Supprimer As Button
    Friend WithEvents btn_Vider As Button
    Friend WithEvents lst__AFFProduit As ListBox
    Friend WithEvents lst_AFFPrixunitaire As ListBox
    Friend WithEvents lst_AFFquantité As ListBox
    Friend WithEvents lst_AFFmontantHT As ListBox
    Friend WithEvents lbl_Total As Label
    Friend WithEvents txt_totalpxunitaire As TextBox
    Friend WithEvents txt_totalquantité As TextBox
    Friend WithEvents txt_totalmontantHT As TextBox
    Friend WithEvents btn_calculer As Button
    Friend WithEvents txt_Tva As TextBox
    Friend WithEvents txt_remise As TextBox
    Friend WithEvents lbl_remise As Label
    Friend WithEvents lbl_Tva As Label
    Friend WithEvents lbl_TTC As Label
    Friend WithEvents txt_TTC As TextBox
    Friend WithEvents btn_modifier As Button
    Friend WithEvents btn_quitter As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
