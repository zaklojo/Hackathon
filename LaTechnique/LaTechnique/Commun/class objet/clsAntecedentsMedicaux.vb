Public Class clsAntecedentsMedicaux


    'Variables
    Private v_id_medicaux As Integer
    Private v_assurance_maladie As String

    'Propriétés
    Public Property id_medicaux As Integer
        Get
            Return v_id_medicaux
        End Get
        Set(ByVal value As Integer)
            v_id_medicaux = value
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
            id_medicaux = verifierColonneDataSet(.Tables(0), ligne, constantes_antecedents_medicaux.STR_ID_ANTECEDENTS_MEDICAUX)
            assurance_maladie = verifierColonneDataSet(.Tables(0), ligne, constantes_antecedents_medicaux.STR_ASSURANCE_MALADIE)
        End With
    End Sub

End Class
