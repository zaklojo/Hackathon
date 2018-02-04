Public Class clsPiecesJointes

    'Variables
    Private v_assurance_maladie As String
    Private v_description As String
    Private v_piece_jointe As Integer

    'Propriétés
    Public Property piece_jointe As String
        Get
            Return v_piece_jointe
        End Get
        Set(ByVal value As String)
            v_piece_jointe = value
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

    Public Property description As String
        Get
            Return v_description
        End Get
        Set(ByVal value As String)
            v_description = value
        End Set
    End Property


    'Mapping
    Public Overloads Sub mapping(ByVal dataAccess As dataAccessObjet, ligne As Integer)
        With dataAccess.ds
            piece_jointe = verifierColonneDataSet(.Tables(0), ligne, constantes_pieces_jointes.STR_PIECE_JOINTE)
            assurance_maladie = verifierColonneDataSet(.Tables(0), ligne, constantes_pieces_jointes.STR_ASSURANCE_MALADIE)
            description = verifierColonneDataSet(.Tables(0), ligne, constantes_pieces_jointes.STR_DESCRIPTION)
        End With
    End Sub

End Class
