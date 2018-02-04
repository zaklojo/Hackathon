Public Class clsAntecedentsChirurgicaux


    'Variables
    Private v_id_chirurgie As Integer
    Private v_assurance_maladie As String

    'Propriétés
    Public Property id_chirurgie As Integer
        Get
            Return v_id_chirurgie
        End Get
        Set(ByVal value As Integer)
            v_id_chirurgie = value
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
            id_chirurgie = verifierColonneDataSet(.Tables(0), ligne, constantes_antecedents_chirurgicaux.STR_ID_ANTECEDENTS_CHIRURGICAUX)
            assurance_maladie = verifierColonneDataSet(.Tables(0), ligne, constantes_antecedents_chirurgicaux.STR_ASSURANCE_MALADIE)
        End With
    End Sub

End Class
