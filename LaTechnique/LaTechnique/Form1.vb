Imports System.Text
Imports System.Text.RegularExpressions
Public Class Form1

    Public control_identif As New controlIdentification
    Dim control_visionnement As New controlVisionnement

    Dim test As New DataTest
    Dim clsPers As New clsPersonne

    'Code regex pour vérifier que le code scanné était bien un numéro d'assurance maladie
    Dim assMaladie As Regex = New Regex("[A-z]{4}\d{8}")

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Rajoute les controles
        pControl.Controls.Add(control_identif)
        pControl.Controls.Add(control_visionnement)

        'Fait afficher le controle de base
        control_identif.Dock = DockStyle.Fill
        control_identif.Visible = True
        control_visionnement.Visible = True
        'control_identif.Visible = False
        'control_visionnement.Dock = DockStyle.Fill
        'control_visionnement.Visible = True

        test.test()

        'For ctr = 0 To 1
        '    clsPers.mapping(test, ctr)
        '    MsgBox(clsPers.assurance_maladie)
        'Next

    End Sub
    Public Function identification()
        If assMaladie.IsMatch(control_identif.txtNum.Text) Then
            control_identif.Visible = False
            control_visionnement.Dock = DockStyle.Fill
            control_visionnement.Visible = True
        Else
            If control_identif.txtNum.TextLength = 12 Then
                control_identif.txtNum.Text = ""
                control_identif.lblValide.Visible = True
            Else
                control_identif.lblValide.Visible = False
            End If
        End If
    End Function

    Public Function menu()
        control_identif.Dock = DockStyle.Fill
        control_identif.Visible = True
        control_visionnement.Visible = True
        control_identif.txtNum.Text = ""
    End Function

End Class
