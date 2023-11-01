Public Class frm_gestion
    Private Sub vider()
        txt_Prixunitaire.Clear()
        txt_MontantHT.Clear()
        cmb_Produit.SelectedIndex = -1
        cmb_Qunatité.SelectedIndex = -1
    End Sub
    Private Sub cmb_Qunatité_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_Qunatité.SelectedIndexChanged
        Dim prix As Integer = txt_Prixunitaire.Text
        Dim quantité As Integer = cmb_Qunatité.SelectedItem
        txt_MontantHT.Text = prix * quantité
    End Sub
    Private Sub bnt_Ajouter_Click(sender As Object, e As EventArgs) Handles btn_Ajouter.Click

        lst__AFFProduit.Items.Add(cmb_Produit.SelectedItem)
        lst_AFFPrixunitaire.Items.Add(txt_Prixunitaire.Text)
        lst_AFFquantité.Items.Add(cmb_Qunatité.SelectedItem)
        lst_AFFmontantHT.Items.Add(txt_MontantHT.Text)

        vider()
    End Sub
    Private Sub btn_calculer_Click(sender As Object, e As EventArgs) Handles btn_calculer.Click
        Dim somme As Double = 0
        For Each i As Double In lst_AFFPrixunitaire.Items
            somme += i

        Next
        txt_totalpxunitaire.Text = somme

        somme = 0

        For Each i As Double In lst_AFFquantité.Items
            somme += i

        Next
        txt_totalquantité.Text = somme

        somme = 0
        For Each i As Double In lst_AFFmontantHT.Items
            somme += i

        Next
        txt_totalmontantHT.Text = somme

        Dim tva As Double = txt_totalmontantHT.Text * 0.2
        txt_Tva.Text = tva

        If (txt_totalmontantHT.Text >= 1000) Then
            txt_remise.Text = tva * 0.01
        Else
            txt_remise.Text = 0
        End If
        txt_TTC.Text = txt_totalmontantHT.Text - txt_remise.Text + tva

    End Sub
    Private Sub btn_Vider_Click(sender As Object, e As EventArgs) Handles btn_Vider.Click
        vider()
    End Sub
    Private Sub cmb_Produit_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_Produit.SelectedIndexChanged

        If (cmb_Produit.SelectedItem = "souris") Then
            txt_Prixunitaire.Text = "30.000"
        ElseIf (cmb_Produit.SelectedItem = "casque") Then
            txt_Prixunitaire.Text = "50.000"
        ElseIf (cmb_Produit.SelectedItem = "tapis") Then
            txt_Prixunitaire.Text = "10.000"
        Else
            txt_Prixunitaire.Text = "60.000"
        End If
    End Sub
    Private Sub lst__AFFProduit_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lst__AFFProduit.SelectedIndexChanged
        Dim index As Integer = lst__AFFProduit.SelectedIndex
        If lst__AFFProduit.SelectedIndex = index Then
            lst_AFFPrixunitaire.SelectedIndex = index
            lst_AFFquantité.SelectedIndex = index
            lst_AFFmontantHT.SelectedIndex = index
        End If
    End Sub
    Private Sub btn_modifier_Click(sender As Object, e As EventArgs) Handles btn_modifier.Click
        Dim index As Integer = lst__AFFProduit.SelectedIndex
        If lst__AFFProduit.SelectedIndex <> -1 Then

            cmb_Qunatité.Text = lst_AFFquantité.SelectedItem
            txt_Prixunitaire.Text = lst_AFFPrixunitaire.SelectedItem
            txt_MontantHT.Text = lst_AFFmontantHT.SelectedItem
            cmb_Produit.Text = lst__AFFProduit.SelectedItem

            lst_AFFquantité.Items.RemoveAt(index)
            lst_AFFPrixunitaire.Items.RemoveAt(index)
            lst_AFFmontantHT.Items.RemoveAt(index)
            lst__AFFProduit.Items.RemoveAt(index)

        End If
    End Sub
    Private Sub btn_Supprimer_Click(sender As Object, e As EventArgs) Handles btn_Supprimer.Click
        Dim index As Integer = lst__AFFProduit.SelectedIndex
        If lst__AFFProduit.SelectedIndex <> -1 Then
            lst_AFFquantité.Items.RemoveAt(index)
            lst_AFFPrixunitaire.Items.RemoveAt(index)
            lst_AFFmontantHT.Items.RemoveAt(index)
            lst__AFFProduit.Items.RemoveAt(index)
        End If
    End Sub
    Private Sub btn_quitter_Click(sender As Object, e As EventArgs) Handles btn_quitter.Click
        Me.Close()
    End Sub
End Class
