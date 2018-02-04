Public Class clsAntecedantsMedicaments


    'Variables
    Private v_id_medicament As Integer
    Private v_assurance_maladie As String

    'Propriétés
    Public Property id_medicament As Integer
        Get
            Return v_id_medicament
        End Get
        Set(ByVal value As Integer)
            v_id_medicament = value
        End Set
    End Property

    Public Property assurance_maladie As Integer
        Get
            Return v_assurance_maladie
        End Get
        Set(ByVal value As Integer)
            v_assurance_maladie = value
        End Set
    End Property

    'Mapping
    Public Overloads Sub mapping(ByVal dataAccess As dataAccessObjet, ligne As Integer)
        With dataAccess.ds
            id_medicament = verifierColonneDataSet(.Tables(0), ligne, constantes_antecedants_medicaments.STR_ID_ANTECEDANTS_MEDICAMENTS)
            assurance_maladie = verifierColonneDataSet(.Tables(0), ligne, constantes_antecedants_medicaments.STR_ASSURANCE_MALADIE)
        End With
    End Sub

End Class
