Public Class Form1

    Dim control_identif As New controlIdentification
    Dim control_visionnement As New controlVisionnement

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Rajoute les controles
        pControl.Controls.Add(control_identif)
        pControl.Controls.Add(control_visionnement)

        'Fait afficher le controle de base
        'control_identif.Dock = DockStyle.Fill
        'control_identif.Visible = True
        control_identif.Visible = False

        control_visionnement.Dock = DockStyle.Fill
        control_visionnement.Visible = True

    End Sub
End Class
