Public Class clsInfosSupplementaires


    'Variables
    Private v_assurance_maladie_info_supp As String
    Private v_trouble_comportement_info_supp As Boolean
    Private v_p_trouble_comportement_info_supp As String
    Private v_desorientation_info_supp As Boolean
    Private v_fugue_info_supp As Boolean
    Private v_contention_info_supp As Boolean
    Private v_p_contention_info_supp As String
    Private v_problemes_cutanes_info_supp As Boolean
    Private v_p_problemes_cutanes_info_supp As String
    Private v_aide_technique_info_supp As Boolean
    Private v_p_aide_technique_info_supp As String
    Private v_protections_info_supp As Boolean
    Private v_appareil_auditif_info_supp As Boolean
    Private v_protheses_dentaires_info_supp As Integer
    Private v_p_protheses_dentaires_info_supp As Integer
    Private v_lunettes_info_supp As Boolean

    'Propriétés
    Public Property assurance_maladie_info_supp As String
        Get
            Return v_assurance_maladie_info_supp
        End Get
        Set(ByVal value As String)
            v_assurance_maladie_info_supp = value
        End Set
    End Property

    Public Property trouble_comportement_info_supp As Boolean
        Get
            Return v_trouble_comportement_info_supp
        End Get
        Set(ByVal value As Boolean)
            v_trouble_comportement_info_supp = value
        End Set
    End Property

    Public Property p_trouble_comportement_info_supp As String
        Get
            Return v_p_trouble_comportement_info_supp
        End Get
        Set(ByVal value As String)
            v_p_trouble_comportement_info_supp = value
        End Set
    End Property
    Public Property desorientation_info_supp As Boolean
        Get
            Return v_desorientation_info_supp
        End Get
        Set(ByVal value As Boolean)
            v_desorientation_info_supp = value
        End Set
    End Property
    Public Property fugue_info_supp As Boolean
        Get
            Return v_fugue_info_supp
        End Get
        Set(ByVal value As Boolean)
            v_fugue_info_supp = value
        End Set
    End Property
    Public Property contention_info_supp As Boolean
        Get
            Return v_contention_info_supp
        End Get
        Set(ByVal value As Boolean)
            v_contention_info_supp = value
        End Set
    End Property
    Public Property p_contention_info_supp As String
        Get
            Return v_p_contention_info_supp
        End Get
        Set(ByVal value As String)
            v_p_contention_info_supp = value
        End Set
    End Property
    Public Property problemes_cutanes_info_supp As Boolean
        Get
            Return v_problemes_cutanes_info_supp
        End Get
        Set(ByVal value As Boolean)
            v_problemes_cutanes_info_supp = value
        End Set
    End Property
    Public Property p_problemes_cutanes_info_supp As String
        Get
            Return v_p_problemes_cutanes_info_supp
        End Get
        Set(ByVal value As String)
            v_p_problemes_cutanes_info_supp = value
        End Set
    End Property
    Public Property aide_technique_info_supp As Boolean
        Get
            Return v_aide_technique_info_supp
        End Get
        Set(ByVal value As Boolean)
            v_aide_technique_info_supp = value
        End Set
    End Property
    Public Property p_aide_technique_info_supp As String
        Get
            Return v_p_aide_technique_info_supp
        End Get
        Set(ByVal value As String)
            v_p_aide_technique_info_supp = value
        End Set
    End Property
    Public Property protections_info_supp As Boolean
        Get
            Return v_protections_info_supp
        End Get
        Set(ByVal value As Boolean)
            v_protections_info_supp = value
        End Set
    End Property
    Public Property appareil_auditif_info_supp As Boolean
        Get
            Return v_appareil_auditif_info_supp
        End Get
        Set(ByVal value As Boolean)
            v_appareil_auditif_info_supp = value
        End Set
    End Property
    Public Property protheses_dentaires_info_supp As Integer
        Get
            Return v_protheses_dentaires_info_supp
        End Get
        Set(ByVal value As Integer)
            v_protheses_dentaires_info_supp = value
        End Set
    End Property
    Public Property p_protheses_dentaires_info_supp As Integer
        Get
            Return v_p_protheses_dentaires_info_supp
        End Get
        Set(ByVal value As Integer)
            v_p_protheses_dentaires_info_supp = value
        End Set
    End Property
    Public Property lunettes_info_supp As Boolean
        Get
            Return v_lunettes_info_supp
        End Get
        Set(ByVal value As Boolean)
            v_lunettes_info_supp = value
        End Set
    End Property

    'Mapping
    Public Overloads Sub mapping(ByVal dataAccess As dataAccessObjet, ligne As Integer)
        With dataAccess.ds
            assurance_maladie_info_supp = verifierColonneDataSet(.Tables(0), ligne, constantes_infos_supplementaires.STR_ASSURANCE_MALADIE)
            trouble_comportement_info_supp = verifierColonneDataSet(.Tables(0), ligne, constantes_infos_supplementaires.STR_TROUBLE_COMPORTEMENT)
            p_trouble_comportement_info_supp = verifierColonneDataSet(.Tables(0), ligne, constantes_infos_supplementaires.STR_P_TROUBLE_COMPORTENEBT)
            desorientation_info_supp = verifierColonneDataSet(.Tables(0), ligne, constantes_infos_supplementaires.STR_DESORIENTATION)
            fugue_info_supp = verifierColonneDataSet(.Tables(0), ligne, constantes_infos_supplementaires.STR_FUGUE)
            contention_info_supp = verifierColonneDataSet(.Tables(0), ligne, constantes_infos_supplementaires.STR_CONTENTION)
            p_contention_info_supp = verifierColonneDataSet(.Tables(0), ligne, constantes_infos_supplementaires.STR_P_CONTENTION)
            problemes_cutanes_info_supp = verifierColonneDataSet(.Tables(0), ligne, constantes_infos_supplementaires.STR_PROBLEMES_CUTANES)
            p_problemes_cutanes_info_supp = verifierColonneDataSet(.Tables(0), ligne, constantes_infos_supplementaires.STR_P_PROBLEMES_CUTANES)
            aide_technique_info_supp = verifierColonneDataSet(.Tables(0), ligne, constantes_infos_supplementaires.STR_AIDE_TECHNIQUE)
            p_aide_technique_info_supp = verifierColonneDataSet(.Tables(0), ligne, constantes_infos_supplementaires.STR_P_AIDE_TECHNIQUE)
            protections_info_supp = verifierColonneDataSet(.Tables(0), ligne, constantes_infos_supplementaires.STR_PROTECTIONS)
            appareil_auditif_info_supp = verifierColonneDataSet(.Tables(0), ligne, constantes_infos_supplementaires.STR_APPAREIL_AUDITIF)
            protheses_dentaires_info_supp = verifierColonneDataSet(.Tables(0), ligne, constantes_infos_supplementaires.STR_PROTHESES_DENTAIRES)
            p_protheses_dentaires_info_supp = verifierColonneDataSet(.Tables(0), ligne, constantes_infos_supplementaires.STR_P_PROTHESES_DENTAIRES)
            lunettes_info_supp = verifierColonneDataSet(.Tables(0), ligne, constantes_infos_supplementaires.STR_LUNETTES)
        End With
    End Sub

End Class
