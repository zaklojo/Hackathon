Public Class clsMaladieMentales


    'Variables
    Private v_id_psychiatrique As Integer
    Private v_nom_maladie_mentale As String

    'Propriétés
    Public Property id_psychiatrique As Integer
        Get
            Return v_id_psychiatrique
        End Get
        Set(ByVal value As Integer)
            v_id_psychiatrique = value
        End Set
    End Property

    Public Property nom_maladie_mentale As String
        Get
            Return v_nom_maladie_mentale
        End Get
        Set(ByVal value As String)
            v_nom_maladie_mentale = value
        End Set
    End Property

    'Mapping
    Public Overloads Sub mapping(ByVal dataAccess As dataAccessObjet, ligne As Integer)
        With dataAccess.ds
            id_psychiatrique = verifierColonneDataSet(.Tables(0), ligne, constantes_maladies_mentales.STR_ID_PSYCHIATRIQUE)
            nom_maladie_mentale = verifierColonneDataSet(.Tables(0), ligne, constantes_maladies_mentales.STR_NOM)
        End With
    End Sub

End Class
