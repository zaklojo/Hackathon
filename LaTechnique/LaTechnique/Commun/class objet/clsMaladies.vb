Public Class clsMaladies


    'Variables
    Private v_id_maladie As Integer
    Private v_nom As String

    'Propriétés
    Public Property id_maladie As Integer
        Get
            Return v_id_maladie
        End Get
        Set(ByVal value As Integer)
            v_id_maladie = value
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

    'Mapping
    Public Overloads Sub mapping(ByVal dataAccess As dataAccessObjet, ligne As Integer)
        With dataAccess.ds
            id_maladie = verifierColonneDataSet(.Tables(0), ligne, constantes_maladies.STR_ID_MALADIE)
            nom = verifierColonneDataSet(.Tables(0), ligne, constantes_maladies.STR_NOM)
        End With
    End Sub

End Class
