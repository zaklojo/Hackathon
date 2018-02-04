Public Class clsMedicaments


    'Variables
    Private v_id_medicament As Integer
    Private v_nom_medicament As String

    'Propriétés
    Public Property id_medicament As Integer
        Get
            Return v_id_medicament
        End Get
        Set(ByVal value As Integer)
            v_id_medicament = value
        End Set
    End Property

    Public Property nom_medicament As String
        Get
            Return v_nom_medicament
        End Get
        Set(ByVal value As String)
            v_nom_medicament = value
        End Set
    End Property

    'Mapping
    Public Overloads Sub mapping(ByVal dataAccess As dataAccessObjet, ligne As Integer)
        With dataAccess.ds
            v_id_medicament = verifierColonneDataSet(.Tables(0), ligne, constantes_medicaments.STR_ID_MEDICAMENT)
            v_nom_medicament = verifierColonneDataSet(.Tables(0), ligne, constantes_medicaments.STR_NOM)
        End With
    End Sub

End Class
