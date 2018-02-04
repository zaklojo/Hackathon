Imports System.IO

Public Class controlVisionnement

    Dim bd As New DataTest
    Dim clsPers As New clsPersonne
    Dim clsAllergies As New clsAntecedentsAllergies
    Dim clsBacteries As New clsAntecedentsBacteries
    Dim clsChir As New clsAntecedentsChirurgicaux
    Dim clsMedicaments As New clsAntecedentsMedicaments
    Dim clsMedicaux As New clsAntecedentsMedicaux
    Dim clsPsy As New clsAntecedentsPsychiatriques
    Dim clsVaccins As New clsAntecedentsVaccins
    Dim clsInfoSupplementaire As New clsInfosSupplementaires

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

        bd.infoPersonneAllergies(am)
        If (bd.ds.Tables(0).Rows.Count - 1 <> 0) Then
            For ctr = 0 To bd.ds.Tables(0).Rows.Count - 1
                clsAllergies.mapping(bd, 0)
                If ctr <> 0 Then
                    lblAllergies.Text += ", "
                    lblAllergies.Text += clsAllergies.id_allergie
                Else
                    If clsAllergies.id_allergie <> 0 Then
                        lblAllergies.Text = "Aucune connue"
                    Else
                        lblAllergies.Text = clsAllergies.id_allergie
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

        bd.infoPersonneChirurgies(am)

        If (bd.ds.Tables(0).Rows.Count - 1 <> 0) Then
            For ctr = 0 To bd.ds.Tables(0).Rows.Count - 1
                clsChir.mapping(bd, 0)
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

        'bd.infoPersonneMedicaments(am)

        'For ctr = 0 To bd.ds.Tables(0).Rows.Count - 1
        '    clsMedicaments.mapping(bd, 0)
        'If ctr <> 0 Then
        '    lblMedicaments.Text += ", "
        '    lblMedicaments.Text += clsMedicaments.id_medicament
        'Else
        '    lblMedicaments.Text = clsMedicaments.id_medicament
        'End If
        'Next

        bd.infoPersonnePsychatriques(am)

        If (bd.ds.Tables(0).Rows.Count - 1 <> 0) Then
            For ctr = 0 To bd.ds.Tables(0).Rows.Count - 1
                clsPsy.mapping(bd, 0)
                If ctr <> 0 Then
                    lblAntecedentsPsychiatriques.Text += ", "
                    lblAntecedentsPsychiatriques.Text += clsPsy.id_psychiatrique
                Else
                    If clsPsy.id_psychiatrique <> "0" Then
                        lblAntecedentsPsychiatriques.Text = "Aucune connue"
                    Else
                        lblAntecedentsPsychiatriques.Text = clsPsy.id_psychiatrique
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

        bd.infoPersonneMedicaux(am)

        If (bd.ds.Tables(0).Rows.Count - 1 <> 0) Then
            For ctr = 0 To bd.ds.Tables(0).Rows.Count - 1
                clsMedicaux.mapping(bd, 0)
                If ctr <> 0 Then
                    lblAntecedentsMedicaux.Text += ", "
                    lblAntecedentsMedicaux.Text += clsMedicaux.id_medicaux
                Else
                    If clsMedicaux.id_medicaux <> 0 Then
                        lblAntecedentsMedicaux.Text = "Aucune connue"
                    Else
                        lblAntecedentsMedicaux.Text = clsMedicaux.id_medicaux
                    End If
                End If
            Next
        Else
            lblAntecedentsMedicaux.Text = "Aucune connue"
        End If

        bd.infoPersonneInfoSupp(am)
        clsInfoSupplementaire.mapping(bd, 0)

        If (clsInfoSupplementaire.trouble_comportement_info_supp) Then
            lblTroubleComportement.Text = "Oui, "
            lblTroubleComportement.Text += clsInfoSupplementaire.p_trouble_comportement_info_supp
        Else
            lblTroubleComportement.Text = "Non"
        End If

        If (clsInfoSupplementaire.desorientation_info_supp) Then
            lblDesorientation.Text = "Oui"
        Else
            lblDesorientation.Text = "Non"
        End If

        If (clsInfoSupplementaire.fugue_info_supp) Then
            lblRisqueFugue.Text = "Oui"
        Else
            lblRisqueFugue.Text = "Non"
        End If

        If (clsInfoSupplementaire.contention_info_supp) Then
            lblUtilisationContention.Text = "Oui, "
            lblUtilisationContention.Text += clsInfoSupplementaire.p_contention_info_supp
        Else
            lblUtilisationContention.Text = "Non"
        End If

        If (clsInfoSupplementaire.problemes_cutanes_info_supp) Then
            lblCutanes.Text = "Oui, "
            lblCutanes.Text += clsInfoSupplementaire.p_problemes_cutanes_info_supp
        Else
            lblCutanes.Text = "Non"
        End If

        If (clsInfoSupplementaire.aide_technique_info_supp) Then
            lblCutanes.Text = "Oui, "
            lblCutanes.Text += clsInfoSupplementaire.p_aide_technique_info_supp
        Else
            lblCutanes.Text = "Non"
        End If

        If (clsInfoSupplementaire.protections_info_supp) Then
            lblCutanes.Text = "Oui"
        Else
            lblCutanes.Text = "Non"
        End If

        If (clsInfoSupplementaire.appareil_auditif_info_supp) Then
            lblCutanes.Text = "Oui"
        Else
            lblCutanes.Text = "Non"
        End If

        If (clsInfoSupplementaire.protheses_dentaires_info_supp) Then
            lblCutanes.Text = "Oui, "
            lblCutanes.Text += clsInfoSupplementaire.p_protheses_dentaires_info_supp
        Else
            lblCutanes.Text = "Non"
        End If

        If (clsInfoSupplementaire.lunettes_info_supp) Then
            lblCutanes.Text = "Oui"
        Else
            lblCutanes.Text = "Non"
        End If

    End Sub



End Class
