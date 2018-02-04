Public Class controlSaisie
    Public dtSaisie As New DataTest
    Public Sub initialiser()
        dtSaisie.testAllergies()
        For index = 0 To dtSaisie.ds.Tables(0).Rows.Count - 1
            Dim allergies As New clsAllergies
            allergies.mapping(dtSaisie, index)
            cboAllergies.Items.Add(allergies.nom_allergie)
        Next
    End Sub
    Private Sub btnEnregistrer_Click(sender As Object, e As EventArgs) Handles btnEnregistrer.Click

        Dim personne As New clsPersonne
        Dim infos_supp As New clsInfosSupplementaires





    End Sub
End Class
