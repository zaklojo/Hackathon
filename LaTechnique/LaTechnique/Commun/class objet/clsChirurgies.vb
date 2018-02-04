Public Class clsChirurgies


    'Variables
    Private v_id_chirurgie As Integer
    Private v_nom_Chirurgie As String

    'Propriétés
    Public Property id_chirurgie As Integer
        Get
            Return v_id_chirurgie
        End Get
        Set(ByVal value As Integer)
            v_id_chirurgie = value
        End Set
    End Property

    Public Property nom_Chirurgie As String
        Get
            Return v_nom_Chirurgie
        End Get
        Set(ByVal value As String)
            v_nom_Chirurgie = value
        End Set
    End Property

    'Mapping
    Public Overloads Sub mapping(ByVal dataAccess As dataAccessObjet, ligne As Integer)
        With dataAccess.ds
            id_chirurgie = verifierColonneDataSet(.Tables(0), ligne, constantes_chirurgies.STR_ID_CHIRURGIE)
            nom_Chirurgie = verifierColonneDataSet(.Tables(0), ligne, constantes_chirurgies.STR_NOM)
        End With
    End Sub

End Class
