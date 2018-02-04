Public Class clsAllergies

    'Variables
    Private v_id_allergie As Integer
    Private v_nom_allergie As Integer

    'Propriétés
    Public Property id_allergie As Integer
        Get
            Return v_id_allergie
        End Get
        Set(ByVal value As Integer)
            v_id_allergie = value
        End Set
    End Property

    Public Property nom_allergie As Integer
        Get
            Return v_nom_allergie
        End Get
        Set(ByVal value As Integer)
            v_nom_allergie = value
        End Set
    End Property

    'Mapping
    Public Overloads Sub mapping(ByVal dataAccess As dataAccessObjet, ligne As Integer)
        With dataAccess.ds
            id_allergie = verifierColonneDataSet(.Tables(0), ligne, constantes_allergies.STR_ID_ALLERGIE)
            nom_allergie = verifierColonneDataSet(.Tables(0), ligne, constantes_allergies.STR_NOM)
        End With
    End Sub


End Class
