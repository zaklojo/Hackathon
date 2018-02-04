Public Class clsVaccins

    'Variables
    Private v_id_vaccins As Integer
    Private v_nom_vaccins As String

    'Propriétés
    Public Property id_vaccins As Integer
        Get
            Return v_id_vaccins
        End Get
        Set(ByVal value As Integer)
            v_id_vaccins = value
        End Set
    End Property

    Public Property nom_vaccins As String
        Get
            Return v_nom_vaccins
        End Get
        Set(ByVal value As String)
            v_nom_vaccins = value
        End Set
    End Property

    'Mapping
    Public Overloads Sub mapping(ByVal dataAccess As dataAccessObjet, ligne As Integer)
        With dataAccess.ds
            id_vaccins = verifierColonneDataSet(.Tables(0), ligne, constantes_vaccins.STR_ID_VACCIN)
            nom_vaccins = verifierColonneDataSet(.Tables(0), ligne, constantes_vaccins.STR_NOM)
        End With
    End Sub


End Class
