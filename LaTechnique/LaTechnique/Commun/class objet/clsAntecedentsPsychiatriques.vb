Public Class clsAntecedentsPsychiatriques


    'Variables
    Private v_id_psychiatrique As Integer
    Private v_assurance_maladie As String

    'Propriétés
    Public Property id_psychiatrique As Integer
        Get
            Return v_id_psychiatrique
        End Get
        Set(ByVal value As Integer)
            v_id_psychiatrique = value
        End Set
    End Property

    Public Property assurance_maladie As String
        Get
            Return v_assurance_maladie
        End Get
        Set(ByVal value As String)
            v_assurance_maladie = value
        End Set
    End Property

    'Mapping
    Public Overloads Sub mapping(ByVal dataAccess As dataAccessObjet, ligne As Integer)
        With dataAccess.ds
            id_psychiatrique = verifierColonneDataSet(.Tables(0), ligne, constantes_antecedents_psychiatriques.STR_ID_ANTECEDENTS_PSYCHIATRIQUES)
            assurance_maladie = verifierColonneDataSet(.Tables(0), ligne, constantes_antecedents_psychiatriques.STR_ASSURANCE_MALADIE)
        End With
    End Sub

End Class
