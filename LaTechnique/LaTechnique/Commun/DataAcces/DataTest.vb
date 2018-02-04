Public Class DataTest
    Inherits dataAccessObjet

    Public Sub test()
        bd.Requete($"select assurance_maladie from {constantes_personnes.STR_TABLE}", ds, da, constantes_personnes.STR_TABLE)
    End Sub

    Public Sub infoPersonne(ByVal am As String)
        bd.Requete($"select * from {constantes_personnes.STR_TABLE} where {constantes_personnes.STR_ASSURANCE_MALADIE} = '{am}'", ds, da, constantes_personnes.STR_TABLE)
    End Sub

    Public Sub infoPersonneAllergies(ByVal am As String)
        bd.Requete($"select * from {constantes_antecedents_allergies.STR_TABLE} where {constantes_antecedents_allergies.STR_ASSURANCE_MALADIE} = '{am}'", ds, da, constantes_antecedents_allergies.STR_TABLE)
    End Sub

    Public Sub infoPersonneBacteries(ByVal am As String)
        bd.Requete($"select * from {constantes_antecedents_bacteries.STR_TABLE} where {constantes_antecedents_bacteries.STR_ASSURANCE_MALADIE} = '{am}'", ds, da, constantes_antecedents_bacteries.STR_TABLE)
    End Sub

    Public Sub infoPersonneChirurgies(ByVal am As String)
        bd.Requete($"select * from {constantes_antecedents_chirurgicaux.STR_TABLE} where {constantes_antecedents_chirurgicaux.STR_ASSURANCE_MALADIE} = '{am}'", ds, da, constantes_antecedents_chirurgicaux.STR_TABLE)
    End Sub

    Public Sub infoPersonneMedicaments(ByVal am As String)
        bd.Requete($"select * from {constantes_antecedents_medicaments.STR_TABLE} where {constantes_antecedents_medicaments.STR_ASSURANCE_MALADIE} = '{am}'", ds, da, constantes_antecedents_medicaments.STR_TABLE)
    End Sub

    Public Sub infoPersonnePsychatriques(ByVal am As String)
        bd.Requete($"select * from {constantes_antecedents_psychiatriques.STR_TABLE} where {constantes_antecedents_psychiatriques.STR_ASSURANCE_MALADIE} = '{am}'", ds, da, constantes_antecedents_psychiatriques.STR_TABLE)
    End Sub

    Public Sub infoPersonneVaccins(ByVal am As String)
        bd.Requete($"select * from {constantes_antecedents_vaccins.STR_TABLE} where {constantes_antecedents_vaccins.STR_ASSURANCE_MALADIE} = '{am}'", ds, da, constantes_antecedents_vaccins.STR_TABLE)
    End Sub

    Public Sub infoPersonneMedicaux(ByVal am As String)
        bd.Requete($"select * from {constantes_antecedents_medicaux.STR_TABLE} where {constantes_antecedents_medicaux.STR_ASSURANCE_MALADIE} = '{am}'", ds, da, constantes_antecedents_medicaux.STR_TABLE)
    End Sub

    Public Sub infoPersonneInfoSupp(ByVal am As String)
        bd.Requete($"select * from {constantes_infos_supplementaires.STR_TABLE} where {constantes_infos_supplementaires.STR_ASSURANCE_MALADIE} = '{am}'", ds, da, constantes_infos_supplementaires.STR_TABLE)
    End Sub

<<<<<<< HEAD


    Public Sub connexion(ByVal co As clsConnexion)
        bd.Requete($"select {constantes_connexion.STR_TYPE} from {constantes_connexion.STR_TABLE} where {constantes_connexion.STR_NOM_UTILISATEUR} = '{co.nom_utilisateur}' and {constantes_connexion.STR_MDP} = '{co.mdp}'", ds, da, constantes_infos_supplementaires.STR_TABLE)
=======
    Public Sub ressources(ByVal am As String)
        bd.Requete($"select * from {constantes_ressources.STR_TABLE} where {constantes_ressources.STR_ASSURANCE_MALADIE} = '{am}'", ds, da, constantes_ressources.STR_TABLE)
    End Sub

    Public Sub allergieAll()
        bd.Requete($"select * from {constantes_allergies.STR_TABLE}`", ds, da, constantes_allergies.STR_TABLE)
    End Sub
    Public Sub allergiAll()
        bd.Requete($"select * from {constantes_allergies.STR_TABLE}`", ds, da, constantes_allergies.STR_TABLE)
    End Sub
    Public Sub insertPersonne(ByVal personne As clsPersonne)
        bd.Requete($"insert into {constantes_personnes.STR_TABLE} values ('{personne.assurance_maladie}', '{personne.nom}', '{personne.prenom}', '{personne.date_naissance}', '{personne.dossier_hopital}', '{personne.medecin_famille}', '{personne.medecin_specialiste}', '{personne.pharmacie}', {personne.poids}, '{personne.date_pesee}', {personne.taille}, {personne.reanimation}, null, null)", ds, da, constantes_personnes.STR_TABLE)
>>>>>>> origin/Interfaces
    End Sub
End Class
