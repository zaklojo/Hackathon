Public Class DataTest
    Inherits dataAccessObjet

    Public Sub test()
        bd.Requete($"select * from {constantes_personnes.STR_TABLE}", ds, da, constantes_personnes.STR_TABLE)
    End Sub


End Class
