Public Class frm_authentifier

    Private Sub init()
        txt_NomUtilisateur.Clear()
        txt_Motdepasse.Clear()
    End Sub

    Private Sub btn_valider_Click(sender As Object, e As EventArgs) Handles btn_valider.Click

        Dim login As String
        Dim pw As String
        login = txt_NomUtilisateur.Text
        pw = txt_Motdepasse.Text
        If (login = "admin") And (pw = "1234") Then
            Me.Hide()
            frm_gestion.Show()
            frm_gestion.WindowState = FormWindowState.Maximized
        Else
            init()
        End If



    End Sub

    Private Sub btn_annuler_Click(sender As Object, e As EventArgs) Handles btn_annuler.Click
        init()

    End Sub


End Class
