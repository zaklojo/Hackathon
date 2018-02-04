Public Class clsPersonne

    'Variables
    Private v_assurance_maladie As String
    Private v_nom As String
    Private v_prenom As String
    Private v_date_naissance As Date
    Private v_dossier_hopital As String
    Private v_medecin_famille As String
    Private v_medecin_specialiste As String
    Private v_pharmacie As String
    Private v_poids As Integer
    Private v_date_pesee As Date
    Private v_taille As Integer
    Private v_reanimation As Boolean
    Private v_photo As Image
    Private v_note_supplementaire As String

    'Propriétés
    Public Property reanimation As Boolean
        Get
            Return v_reanimation
        End Get
        Set(ByVal value As Boolean)
            v_reanimation = value
        End Set
    End Property
    Public Property photo As Image
        Get
            Return v_photo
        End Get
        Set(ByVal value As Image)
            v_photo = value
        End Set
    End Property

    Public Property date_naissance As Date
        Get
            Return v_date_naissance
        End Get
        Set(ByVal value As Date)
            v_date_naissance = value
        End Set
    End Property

    Public Property date_pesee As Date
        Get
            Return v_date_pesee
        End Get
        Set(ByVal value As Date)
            v_date_pesee = value
        End Set
    End Property

    Public Property poids As Integer
        Get
            Return v_poids
        End Get
        Set(ByVal value As Integer)
            v_poids = value
        End Set
    End Property

    Public Property taille As Integer
        Get
            Return v_taille
        End Get
        Set(ByVal value As Integer)
            v_taille = value
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

    Public Property nom As String
        Get
            Return v_nom
        End Get
        Set(ByVal value As String)
            v_nom = value
        End Set
    End Property

    Public Property prenom As String
        Get
            Return v_prenom
        End Get
        Set(ByVal value As String)
            v_prenom = value
        End Set
    End Property

    Public Property dossier_hopital As String
        Get
            Return v_dossier_hopital
        End Get
        Set(ByVal value As String)
            v_dossier_hopital = value
        End Set
    End Property

    Public Property medecin_famille As String
        Get
            Return v_medecin_famille
        End Get
        Set(ByVal value As String)
            v_medecin_famille = value
        End Set
    End Property

    Public Property medecin_specialiste As String
        Get
            Return v_medecin_specialiste
        End Get
        Set(ByVal value As String)
            v_medecin_specialiste = value
        End Set
    End Property

    Public Property pharmacie As String
        Get
            Return v_pharmacie
        End Get
        Set(ByVal value As String)
            v_pharmacie = value
        End Set
    End Property

    Public Property note_supplementaire As String
        Get
            Return v_note_supplementaire
        End Get
        Set(ByVal value As String)
            v_note_supplementaire = value
        End Set
    End Property

    'Mapping
    Public Overloads Sub mapping(ByVal dataAccess As dataAccessObjet, ligne As Integer)
        With dataAccess.ds
            assurance_maladie = verifierColonneDataSet(.Tables(0), ligne, constantes_personnes.STR_ASSURANCE_MALADIE)
            nom = verifierColonneDataSet(.Tables(0), ligne, constantes_personnes.STR_NOM)
            prenom = verifierColonneDataSet(.Tables(0), ligne, constantes_personnes.STR_PRENOM)
            date_naissance = verifierColonneDataSet(.Tables(0), ligne, constantes_personnes.STR_DATE_NAISSANCE)
            date_pesee = verifierColonneDataSet(.Tables(0), ligne, constantes_personnes.STR_DATE_PESEE)
            dossier_hopital = verifierColonneDataSet(.Tables(0), ligne, constantes_personnes.STR_DOSSIER_HOPITAL)
            medecin_famille = verifierColonneDataSet(.Tables(0), ligne, constantes_personnes.STR_MEDECIN_FAMILLE)
            medecin_specialiste = verifierColonneDataSet(.Tables(0), ligne, constantes_personnes.STR_MEDECIN_SPECIALISTE)
            note_supplementaire = verifierColonneDataSet(.Tables(0), ligne, constantes_personnes.STR_NOTE_SUPPLIMENTAIRE)
            pharmacie = verifierColonneDataSet(.Tables(0), ligne, constantes_personnes.STR_PHARMACIE)
            photo = verifierColonneDataSet(.Tables(0), ligne, constantes_personnes.STR_PHOTO)
            poids = verifierColonneDataSet(.Tables(0), ligne, constantes_personnes.STR_POIDS)
            v_reanimation = verifierColonneDataSet(.Tables(0), ligne, constantes_personnes.STR_REANIMATION)
            taille = verifierColonneDataSet(.Tables(0), ligne, constantes_personnes.STR_TAILLE)
        End With
    End Sub


End Class
