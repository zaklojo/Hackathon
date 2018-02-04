Public Class controlSaisie
    Public dtSaisie As New DataTest
    Private listAllergie As New List(Of clsAllergies)
    Dim allergies As New clsAllergies

    Public Sub initialiser()



        'dtSaisie.testAllergies()
        For index = 0 To dtSaisie.ds.Tables(0).Rows.Count - 1
            Dim allergies As New clsAllergies
            allergies.mapping(dtSaisie, index)
            cboAllergies.Items.Add(allergies.nom_allergie)
        Next

    End Sub
    Private Sub btnEnregistrer_Click(sender As Object, e As EventArgs) Handles btnEnregistrer.Click

        Dim personne As New clsPersonne
        Dim infos_supp As New clsInfosSupplementaires

        personne.assurance_maladie = txtAssuranceMaladie.Text
        personne.nom = txtNom.Text
        personne.prenom = txtPrenom.Text
        personne.dossier_hopital = txtDossierHopital.Text
        personne.date_naissance = dtpDateNaissance.Value
        personne.poids = txtPoids.Text
        personne.taille = txtTaille.Text
        personne.date_pesee = dtpDernierePesee.Value
        personne.pharmacie = txtPharmacie.Text
        If chkReanimationOui.Checked = True Then
            personne.reanimation = True
        ElseIf chkReanimationNon.Checked = True Then
            personne.reanimation = False
        End If
        dtSaisie.insertPersonne(personne)

    End Sub
End Class
