Public Class clsTelephones

    'Variables
    Private v_id_telephones As Integer
    Private v_description As String
    Private v_id_personne As String
    Private v_no_telephone As Integer
    Private v_poste As Integer

    'Propriétés
    Public Property id_telephones As Integer
        Get
            Return v_id_telephones
        End Get
        Set(ByVal value As Integer)
            v_id_telephones = value
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

    Public Property id_personne As Integer
        Get
            Return v_id_personne
        End Get
        Set(ByVal value As Integer)
            v_id_personne = value
        End Set
    End Property

    Public Property no_telephone As Integer
        Get
            Return v_no_telephone
        End Get
        Set(ByVal value As Integer)
            v_no_telephone = value
        End Set
    End Property

    Public Property poste As Integer
        Get
            Return v_poste
        End Get
        Set(ByVal value As Integer)
            v_poste = value
        End Set
    End Property


    'Mapping
    Public Overloads Sub mapping(ByVal dataAccess As dataAccessObjet, ligne As Integer)
        With dataAccess.ds
            id_telephones = verifierColonneDataSet(.Tables(0), ligne, constantes_telephones.STR_ID_TELEPHONE)
            description = verifierColonneDataSet(.Tables(0), ligne, constantes_telephones.STR_DESCRIPTION)
            id_personne = verifierColonneDataSet(.Tables(0), ligne, constantes_telephones.STR_ID_PERSONNE)
            no_telephone = verifierColonneDataSet(.Tables(0), ligne, constantes_telephones.STR_NO_TELEPHONE)
            poste = verifierColonneDataSet(.Tables(0), ligne, constantes_telephones.STR_POSTE)
        End With
    End Sub

End Class
