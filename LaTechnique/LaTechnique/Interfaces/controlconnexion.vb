Public Class controlconnexion
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim clsCo As New clsConnexion
        Dim da As New DataTest
        clsCo.nom_utilisateur = txtAssuranceMaladie.Text
        clsCo.mdp = txtDossierHopital.Text
        da.connexion(clsCo)
        If da.ds.Tables(0).Rows.Count > 0 Then
            lbl_erreur.Visible = False
            If da.ds.Tables(0).Rows(0).Item(0) = 1 Then
                Form1.control_visionnement.Visible = False
                Form1.control_identif.Visible = True
                Form1.control_identif.Dock = DockStyle.Fill
            Else
                Form1.control_saisie.Visible = True
                Form1.control_identif.Visible = False
                Form1.control_saisie.Dock = DockStyle.Fill
            End If
            Me.Visible = False
            txtAssuranceMaladie.Text = vbNullString
            txtDossierHopital.Text = vbNullString
        Else
            lbl_erreur.Visible = True
        End If

    End Sub
End Class
