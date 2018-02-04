Public Class clsAntecedentsVaccins


    'Variables
    Private v_id_vaccin As Integer
    Private v_assurance_maladie As Integer

    'Propriétés
    Public Property id_vaccin As Integer
        Get
            Return v_id_vaccin
        End Get
        Set(ByVal value As Integer)
            v_id_vaccin = value
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
            id_vaccin = verifierColonneDataSet(.Tables(0), ligne, constantes_antecedents_vaccins.STR_ID_ANTECEDENTS_VACCINS)
            assurance_maladie = verifierColonneDataSet(.Tables(0), ligne, constantes_antecedents_vaccins.STR_ASSURANCE_MALADIE)
        End With
    End Sub

End Class
