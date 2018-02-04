Public Class clsAjoutCategories


    'Variables
    Private v_categorie As Integer
    Private v_assurance_maladie As String
    Private v_description As String
    'Propriétés
    Public Property categorie As Integer
        Get
            Return v_categorie
        End Get
        Set(ByVal value As Integer)
            v_categorie = value
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

    Public Property description As String
        Get
            Return v_description
        End Get
        Set(ByVal value As String)
            v_description = value
        End Set
    End Property

    'Mapping
    Public Overloads Sub mapping(ByVal dataAccess As dataAccessObjet, ligne As Integer)
        With dataAccess.ds
            v_categorie = verifierColonneDataSet(.Tables(0), ligne, constantes_ajout_categories.STR_CATEGORIE)
            assurance_maladie = verifierColonneDataSet(.Tables(0), ligne, constantes_ajout_categories.STR_ASSURANCE_MALADIE)
            description = verifierColonneDataSet(.Tables(0), ligne, constantes_ajout_categories.STR_DESCRIPTION)
        End With
    End Sub

End Class
