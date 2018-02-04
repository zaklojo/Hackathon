Public Class clsRessource

    'Variables
    Private v_id_ressource As Integer
    Private v_assurance_maladie As String
    Private v_nom As String
    Private v_lien As Integer
    Private v_prenom As Integer
    Private v_priorite As Integer

    'Propriétés
    Public Property id_ressource As Integer
        Get
            Return v_id_ressource
        End Get
        Set(ByVal value As Integer)
            v_id_ressource = value
        End Set
    End Property

    Public Property lien As String
        Get
            Return v_lien
        End Get
        Set(ByVal value As String)
            v_lien = value
        End Set
    End Property

    Public Property assurance_maladie As String
        Get
            Return v_assurance_maladie
        End Get
        Set(ByVal value As String)
            v_assurance_maladie = value
        End Set
    End Property

    Public Property nom As String
        Get
            Return v_nom
        End Get
        Set(ByVal value As String)
            v_nom = value
        End Set
    End Property

    Public Property prenom As String
        Get
            Return v_prenom
        End Get
        Set(ByVal value As String)
            v_prenom = value
        End Set
    End Property

    Public Property priorite As Integer
        Get
            Return v_priorite
        End Get
        Set(ByVal value As Integer)
            v_priorite = value
        End Set
    End Property


    'Mapping
    Public Overloads Sub mapping(ByVal dataAccess As dataAccessObjet, ligne As Integer)
        With dataAccess.ds
            id_ressource = verifierColonneDataSet(.Tables(0), ligne, constantes_ressources.STR_ID_ALLERGIE)
            assurance_maladie = verifierColonneDataSet(.Tables(0), ligne, constantes_ressources.STR_ASSURANCE_MALADIE)
            lien = verifierColonneDataSet(.Tables(0), ligne, constantes_ressources.STR_LIEN)
            prenom = verifierColonneDataSet(.Tables(0), ligne, constantes_ressources.STR_PRENOM)
            nom = verifierColonneDataSet(.Tables(0), ligne, constantes_ressources.STR_NOM)
            priorite = verifierColonneDataSet(.Tables(0), ligne, constantes_ressources.STR_PRIORITE)
        End With
    End Sub

End Class
