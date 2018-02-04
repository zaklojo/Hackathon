Public Class DataTest
    Inherits dataAccessObjet

    Public Sub test()
        ds.Clear()
        bd.Requete($"select assurance_maladie from {constantes_personnes.STR_TABLE}", ds, da, constantes_personnes.STR_TABLE)
    End Sub

    Public Sub infoPersonne(ByVal am As String)
        ds.Clear()
        bd.Requete($"select * from {constantes_personnes.STR_TABLE} where {constantes_personnes.STR_ASSURANCE_MALADIE} = '{am}'", ds, da, constantes_personnes.STR_TABLE)
    End Sub

    Public Sub infoPersonneAllergies(ByVal am As String)
        ds.Clear()
        bd.Requete($"select * from {constantes_allergies.STR_TABLE} a inner join {constantes_antecedents_allergies.STR_TABLE} aa on a.{constantes_allergies.STR_ID_ALLERGIE} = aa.{constantes_antecedents_allergies.STR_ID_ANTECEDENTS_ALLERGIES} where aa.{constantes_antecedents_allergies.STR_ASSURANCE_MALADIE} = '{am}'", ds, da, constantes_antecedents_allergies.STR_TABLE)
    End Sub

    Public Sub infoPersonneBacteries(ByVal am As String)
        ds.Clear()
        bd.Requete($"select b.{constantes_bacteries.STR_NOM} from {constantes_antecedents_bacteries.STR_TABLE} inner join {constantes_bacteries.STR_TABLE} b where {constantes_antecedents_bacteries.STR_ASSURANCE_MALADIE} = '{am}'", ds, da, constantes_personnes.STR_TABLE)
    End Sub

    Public Sub infoPersonneChirurgies(ByVal am As String)
        ds.Clear()
        bd.Requete($"select * from {constantes_antecedents_chirurgicaux.STR_TABLE} where {constantes_antecedents_chirurgicaux.STR_ASSURANCE_MALADIE} = '{am}'", ds, da, constantes_antecedents_chirurgicaux.STR_TABLE)
    End Sub

    Public Sub infoPersonneMedicaments(ByVal am As String)
        ds.Clear()
        bd.Requete($"select * from {constantes_medicaments.STR_TABLE} m inner join {constantes_antecedents_medicaments.STR_TABLE} am on m.{constantes_medicaments.STR_ID_MEDICAMENT} = am.{constantes_antecedents_medicaments.STR_ID_ANTECEDENTS_MEDICAMENTS} where am.{constantes_antecedents_medicaments.STR_ASSURANCE_MALADIE} = '{am}'", ds, da, constantes_antecedents_medicaments.STR_TABLE)
    End Sub

    Public Sub infoPersonnePsychatriques(ByVal am As String)
        ds.Clear()
        bd.Requete($"select * from {constantes_antecedents_psychiatriques.STR_TABLE} where {constantes_antecedents_psychiatriques.STR_ASSURANCE_MALADIE} = '{am}'", ds, da, constantes_antecedents_psychiatriques.STR_TABLE)
    End Sub

    Public Sub infoPersonneVaccins(ByVal am As String)
        ds.Clear()
        bd.Requete($"select v.{constantes_vaccins.STR_NOM} from {constantes_antecedents_vaccins.STR_TABLE} inner join {constantes_vaccins.STR_TABLE} b where {constantes_antecedents_vaccins.STR_ASSURANCE_MALADIE} = '{am}'", ds, da, constantes_personnes.STR_TABLE)
    End Sub

    Public Sub infoPersonneMedicaux(ByVal am As String)
        ds.Clear()
        bd.Requete($"select * from {constantes_maladies.STR_TABLE} m inner join {constantes_antecedents_medicaux.STR_TABLE} am on m.{constantes_antecedents_medicaux.STR_ID_ANTECEDENTS_MEDICAUX} = am.{constantes_maladies.STR_ID_MALADIE} where {constantes_antecedents_medicaux.STR_ASSURANCE_MALADIE} = '{am}'", ds, da, constantes_antecedents_medicaux.STR_TABLE)
    End Sub

    Public Sub infoPersonneInfoSupp(ByVal am As String)
        ds.Clear()
        bd.Requete($"select * from {constantes_infos_supplementaires.STR_TABLE} where {constantes_infos_supplementaires.STR_ASSURANCE_MALADIE} = '{am}'", ds, da, constantes_infos_supplementaires.STR_TABLE)
    End Sub

End Class
