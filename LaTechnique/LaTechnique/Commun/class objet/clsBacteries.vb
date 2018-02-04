Public Class clsBacteries


    'Variables
    Private v_id_bacterie As Integer
    Private v_nom_bacteries As String

    'Propriétés
    Public Property id_bacterie As Integer
        Get
            Return v_id_bacterie
        End Get
        Set(ByVal value As Integer)
            v_id_bacterie = value
        End Set
    End Property

    Public Property nom_bacteries As String
        Get
            Return v_nom_bacteries
        End Get
        Set(ByVal value As String)
            v_nom_bacteries = value
        End Set
    End Property

    'Mapping
    Public Overloads Sub mapping(ByVal dataAccess As dataAccessObjet, ligne As Integer)
        With dataAccess.ds
            id_bacterie = verifierColonneDataSet(.Tables(0), ligne, constantes_bacteries.STR_ID_BACTERIE)
            nom_bacteries = verifierColonneDataSet(.Tables(0), ligne, constantes_bacteries.STR_NOM)
        End With
    End Sub

End Class
