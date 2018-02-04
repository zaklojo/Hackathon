Imports System.IO

Public Class controlVisionnement

    Dim bd As New DataTest
    Dim bd2 As New DataTest
    Dim bd3 As New DataTest
    Dim bd4 As New DataTest
    Dim bd5 As New DataTest
    Dim bd6 As New DataTest
    Dim bd7 As New DataTest
    Dim clsPers As New clsPersonne
    Dim clsAllergies As New clsAllergies
    Dim clsBacteries As New clsAntecedentsBacteries
    Dim clsChir As New clsAntecedentsChirurgicaux
    Dim clsMedicament As New clsMedicaments
    Dim clsMedicaux As New clsMaladies
    Dim clsPsy As New clsAntecedentsPsychiatriques
    Dim clsVaccins As New clsAntecedentsVaccins
    Dim clsInfoSupp As New clsInfosSupplementaires
    Dim clsRessources As New clsRessource

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Visible = False
        Form1.menu()
    End Sub



    Public Sub initialiser(ByVal am As String)
        bd.infoPersonne(am)
        clsPers.mapping(bd, 0)

        lblPrenom.Text = clsPers.prenom
        lblNom.Text = clsPers.nom
        lblDateNaissance.Text = clsPers.date_naissance



        If (clsPers.dossier_hopital = vbNullString) Then
            lblDossierHopital.Text = "Aucun connu"
        Else
            lblDossierHopital.Text = clsPers.dossier_hopital
        End If

        lblAssuranceMaladie.Text = clsPers.assurance_maladie
        lblPoids.Text = clsPers.poids
        lblPoids.Text += " lbs"
        lblTaille.Text = clsPers.taille
        lblTaille.Text += " cm"

        bd2.infoPersonneAllergies(am)
        If (bd2.ds.Tables(0).Rows.Count > 0) Then
            For ctr = 0 To bd2.ds.Tables(0).Rows.Count - 1
                clsAllergies.mapping(bd2, ctr)
                If ctr <> 0 Then
                    lblAllergies.Text += $", {clsAllergies.nom_allergie}"
                Else
                    If clsAllergies.id_allergie <> 0 Then
                        lblAllergies.Text = clsAllergies.nom_allergie
                    Else
                        lblAllergies.Text = "Aucune connue"
                    End If
                End If
            Next
        Else
            lblAllergies.Text = "Aucune connue"
        End If

        'bd.infoPersonneBacteries(am)

        'For ctr = 0 To bd.ds.Tables(0).Rows.Count - 1
        '    clsBacteries.mapping(bd, 0)
        '    If ctr <> 0 Then
        '        lblBacterie.Text += ", "
        '        lblBacterie.Text += clsBacteries.id_bacterie
        '    Else
        '        lblBacterie.Text = clsBacteries.id_bacterie
        '    End If
        'Next

        bd3.infoPersonneChirurgies(am)

        If (bd3.ds.Tables(0).Rows.Count > 0) Then
            For ctr = 0 To bd3.ds.Tables(0).Rows.Count - 1
                clsChir.mapping(bd3, ctr)
                If ctr <> 0 Then
                    lblAntecedentsChirurgicaux.Text += ", "
                    lblAntecedentsChirurgicaux.Text += clsChir.id_chirurgie
                Else
                    If clsChir.id_chirurgie <> 0 Then
                        lblAntecedentsChirurgicaux.Text = "Aucune connue"
                    Else
                        lblAntecedentsChirurgicaux.Text = clsChir.id_chirurgie
                    End If
                End If
            Next
        Else
            lblAntecedentsChirurgicaux.Text = "Aucune connue"
        End If

        bd4.infoPersonneMedicaments(am)

        If (bd4.ds.Tables(0).Rows.Count > 0) Then
            For ctr = 0 To bd4.ds.Tables(0).Rows.Count - 1
                clsMedicament.mapping(bd4, ctr)
                If ctr <> 0 Then
                    lblMedic.Text += ", "
                    lblMedic.Text += clsMedicament.nom_medicament
                Else
                    lblMedic.Text = clsMedicament.nom_medicament
                End If
            Next
        Else
            lblMedic.Text = "Aucun connu"
        End If

        bd5.infoPersonnePsychatriques(am)

        If (bd5.ds.Tables(0).Rows.Count > 0) Then
            For ctr = 0 To bd5.ds.Tables(0).Rows.Count - 1
                clsPsy.mapping(bd5, ctr)
                If ctr <> 0 Then
                    lblAntecedentsPsychiatriques.Text += ", "
                    lblAntecedentsPsychiatriques.Text += clsPsy.id_psychiatrique
                Else
                    If clsPsy.id_psychiatrique <> "0" Then
                        lblAntecedentsPsychiatriques.Text = clsPsy.id_psychiatrique
                    Else
                        lblAntecedentsPsychiatriques.Text = "Aucune connue"
                    End If
                End If
            Next
        Else
            lblAntecedentsPsychiatriques.Text = "Aucune connue"
        End If

        'bd.infoPersonneVaccins(am)


        'For ctr = 0 To bd.ds.Tables(0).Rows.Count - 1
        '    clsVaccins.mapping(bd, 0)
        '    If ctr <> 0 Then
        '        lblVaccins.Text += ", "
        '        lblVaccins.Text += clsVaccins.id_vaccin
        '    Else
        '        lblVaccins.Text = clsVaccins.id_vaccin
        '    End If
        'Next

        bd6.infoPersonneMedicaux(am)

        If (bd6.ds.Tables(0).Rows.Count > 0) Then
            For ctr = 0 To bd6.ds.Tables(0).Rows.Count - 1
                clsMedicaux.mapping(bd6, ctr)
                If ctr <> 0 Then
                    lblAntecedentsMedicaux.Text += ", "
                    lblAntecedentsMedicaux.Text += clsMedicaux.nom
                Else
                    If clsMedicaux.id_maladie <> 0 Then
                        lblAntecedentsMedicaux.Text = clsMedicaux.nom
                    Else
                        lblAntecedentsMedicaux.Text = "Aucune connue"
                    End If
                End If
            Next
        Else
            lblAntecedentsMedicaux.Text = "Aucune connue"
        End If

        bd7.infoPersonneInfoSupp(am)
        clsInfoSupp.mapping(bd7, 0)

        If (clsInfoSupp.trouble_comportement_info_supp) Then
            lblTroubleComportement.Text = "Oui, "
            lblTroubleComportement.Text += clsInfoSupp.p_trouble_comportement_info_supp
        Else
            lblTroubleComportement.Text = "Non"
        End If

        If (clsInfoSupp.desorientation_info_supp) Then
            lblDesorientation.Text = "Oui"
        Else
            lblDesorientation.Text = "Non"
        End If

        If (clsInfoSupp.fugue_info_supp) Then
            lblRisqueFugue.Text = "Oui"
        Else
            lblRisqueFugue.Text = "Non"
        End If

        If (clsInfoSupp.contention_info_supp) Then
            lblUtilisationContention.Text = "Oui, "
            lblUtilisationContention.Text += clsInfoSupp.p_contention_info_supp
        Else
            lblUtilisationContention.Text = "Non"
        End If

        If (clsInfoSupp.problemes_cutanes_info_supp) Then
            lblCutanes.Text = "Oui, "
            lblCutanes.Text += clsInfoSupp.p_problemes_cutanes_info_supp
        Else
            lblCutanes.Text = "Non"
        End If

        If (clsInfoSupp.aide_technique_info_supp) Then
            lblAideTechnique.Text = "Oui, "
            lblAideTechnique.Text += clsInfoSupp.p_aide_technique_info_supp
        Else
            lblAideTechnique.Text = "Non"
        End If

        If (clsInfoSupp.protections_info_supp) Then
            lblPortProtection.Text = "Oui"
        Else
            lblPortProtection.Text = "Non"
        End If

        If (clsInfoSupp.appareil_auditif_info_supp) Then
            lblAppareilAuditif.Text = "Oui"
        Else
            lblAppareilAuditif.Text = "Non"
        End If

        If (clsInfoSupp.protheses_dentaires_info_supp) Then
            lblProthesesDentaires.Text = "Oui"
        Else
            lblProthesesDentaires.Text = "Non"
        End If

        If (clsInfoSupp.lunettes_info_supp) Then
            lblLunettes.Text = "Oui"
        Else
            lblLunettes.Text = "Non"
        End If



        'Afficher les personnes à contacter/Ressources
        bd = New DataTest
        bd.ressources(am)
        If (bd.ds.Tables(0).Rows.Count <> 0) Then
            For ctr = 0 To bd.ds.Tables(0).Rows.Count - 1
                clsRessources.mapping(bd, ctr)
                If ctr <> 0 Then
                    lblPersonneContact.Text += vbNewLine
                    lblPersonneContact.Text += clsRessources.nom + ", " + clsRessources.prenom
                Else
                    lblPersonneContact.Text = clsRessources.nom + ", " + clsRessources.prenom
                End If
            Next
        Else
            lblPersonneContact.Text = "Aucune personne à contacter connue"
        End If

    End Sub

End Class
