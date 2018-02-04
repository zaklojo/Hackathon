Public Class clsConnexion

    'Variables
    Private v_idMembre As Integer
    Private v_nom_utilisateur As String
    Private v_mdp As String
    Private v_type As Integer

    'Propriétés
    Public Property idMembre As Integer
        Get
            Return v_idMembre
        End Get
        Set(ByVal value As Integer)
            v_idMembre = value
        End Set
    End Property

    Public Property type As Integer
        Get
            Return v_type
        End Get
        Set(ByVal value As Integer)
            v_type = value
        End Set
    End Property

    Public Property nom_utilisateur As String
        Get
            Return v_nom_utilisateur
        End Get
        Set(ByVal value As String)
            v_nom_utilisateur = value
        End Set
    End Property

    Public Property mdp As String
        Get
            Return v_mdp
        End Get
        Set(ByVal value As String)
            v_mdp = value
        End Set
    End Property

    'Mapping
    Public Overloads Sub mapping(ByVal dataAccess As dataAccessObjet, ligne As Integer)
        With dataAccess.ds
            type = verifierColonneDataSet(.Tables(0), ligne, constantes_connexion.STR_TYPE)
            nom_utilisateur = verifierColonneDataSet(.Tables(0), ligne, constantes_connexion.STR_NOM_UTILISATEUR)
            mdp = verifierColonneDataSet(.Tables(0), ligne, constantes_connexion.STR_MDP)
            idMembre = verifierColonneDataSet(.Tables(0), ligne, constantes_connexion.STR_IDMEMBRE)
        End With
    End Sub

End Class
