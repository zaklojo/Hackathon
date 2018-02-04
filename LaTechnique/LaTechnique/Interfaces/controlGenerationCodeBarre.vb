Imports System
Imports System.IO
Imports System.Drawing
Imports System.Drawing.Printing
Imports System.Windows.Forms

Public Class controlGenerationCodeBarre

    'Variables
    Dim Binaire As String
    Dim SommeValeur As Integer
    Dim ValeurBinaire As String
    Dim LongueurBinaire As Int32

    Friend WithEvents printDoc As New PrintDocument()
    Dim PDF As Bitmap

    'Début de la génération du code62
    Private Sub btnGenererCode_Click(sender As Object, e As EventArgs) Handles btnGenererCode.Click
        clearCodeBarre()
        GenererBinaire(txtSaisie.Text.Trim)
        GenererCodeBarre(Binaire)
        lblIDCode.Text = txtSaisie.Text
        txtSaisie.Clear()
        btnSave.Visible = True
    End Sub

    'Conversion des caractères en binaire
    Private Sub GenererBinaire(texte As String)

        Binaire = 0

        Dim CharVal As Integer = 0
        Dim CharCount As Integer = 0
        Dim GrandCharCount As Integer = 0
        Dim Somme As Integer = 0


        For Each caractere As Char In texte

            Select Case caractere
                Case = " "
                    Binaire = Binaire & "11011001100"
                    CharVal = 0
                Case = "!"
                    Binaire = Binaire & "11001101100"
                    CharVal = 1
                Case = """"
                    Binaire = Binaire & "11001100110"
                    CharVal = 2
                Case = "#"
                    Binaire = Binaire & "10010011000"
                    CharVal = 3
                Case = "$"
                    Binaire = Binaire & "10010001100"
                    CharVal = 4
                Case "%"
                    Binaire = Binaire & "10001001100"
                    CharVal = 5
                Case "&"
                    Binaire = Binaire & "10011001000"
                    CharVal = 6
                Case "'"
                    Binaire = Binaire & "10011000100"
                    CharVal = 7
                Case "("
                    Binaire = Binaire & "10001100100"
                    CharVal = 8
                Case ")"
                    Binaire = Binaire & "11001001000"
                    CharVal = 9
                Case "*"
                    Binaire = Binaire & "11001000100"
                    CharVal = 10
                Case "+"
                    Binaire = Binaire & "11000100100"
                    CharVal = 11
                Case ","
                    Binaire = Binaire & "10110011100"
                    CharVal = 12
                Case "-"
                    Binaire = Binaire & "10011011100"
                    CharVal = 13
                Case "."
                    Binaire = Binaire & "10011001110"
                    CharVal = 14
                Case "/"
                    Binaire = Binaire & "10111001100"
                    CharVal = 15
                Case "0"
                    Binaire = Binaire & "10011101100"
                    CharVal = 16
                Case "1"
                    Binaire = Binaire & "10011100110"
                    CharVal = 17
                Case "2"
                    Binaire = Binaire & "11001110010"
                    CharVal = 18
                Case "3"
                    Binaire = Binaire & "11001011100"
                    CharVal = 19
                Case "4"
                    Binaire = Binaire & "11001001110"
                    CharVal = 20
                Case "5"
                    Binaire = Binaire & "11011100100"
                    CharVal = 21
                Case "6"
                    Binaire = Binaire & "11001110100"
                    CharVal = 22
                Case "7"
                    Binaire = Binaire & "11101101110"
                    CharVal = 23
                Case "8"
                    Binaire = Binaire & "11101001100"
                    CharVal = 24
                Case "9"
                    Binaire = Binaire & "11100101100"
                    CharVal = 25
                Case ":"
                    Binaire = Binaire & "11100100110"
                    CharVal = 26
                Case " ;"
                    Binaire = Binaire & "11101100100"
                    CharVal = 27
                Case "<"
                    Binaire = Binaire & "11100110100"
                    CharVal = 28
                Case "="
                    Binaire = Binaire & "11100110010"
                    CharVal = 29
                Case ">"
                    Binaire = Binaire & "11011011000"
                    CharVal = 30
                Case " ?"
                    Binaire = Binaire & "11011000110"
                    CharVal = 31
                Case "@"
                    Binaire = Binaire & "11000110110"
                    CharVal = 32
                Case "A"
                    Binaire = Binaire & "10100011000"
                    CharVal = 33
                Case "B"
                    Binaire = Binaire & "10001011000"
                    CharVal = 34
                Case "C"
                    Binaire = Binaire & "10001000110"
                    CharVal = 35
                Case "D"
                    Binaire = Binaire & "10110001000"
                    CharVal = 36
                Case "E"
                    Binaire = Binaire & "10001101000"
                    CharVal = 37
                Case "F"
                    Binaire = Binaire & "10001100010"
                    CharVal = 38
                Case "G"
                    Binaire = Binaire & "11010001000"
                    CharVal = 39
                Case "H"
                    Binaire = Binaire & "11000101000"
                    CharVal = 40
                Case "I"
                    Binaire = Binaire & "11000100010"
                    CharVal = 41
                Case "J"
                    Binaire = Binaire & "10110111000"
                    CharVal = 42
                Case "K"
                    Binaire = Binaire & "10110001110"
                    CharVal = 43
                Case "L"
                    Binaire = Binaire & "10001101110"
                    CharVal = 44
                Case "M"
                    Binaire = Binaire & "10111011000"
                    CharVal = 45
                Case "N"
                    Binaire = Binaire & "10111000110"
                    CharVal = 46
                Case "O"
                    Binaire = Binaire & "10001110110"
                    CharVal = 47
                Case "P"
                    Binaire = Binaire & "11101110110"
                    CharVal = 48
                Case "Q"
                    Binaire = Binaire & "11010001110"
                    CharVal = 49
                Case "R"
                    Binaire = Binaire & "11000101110"
                    CharVal = 50
                Case "S"
                    Binaire = Binaire & "11011101000"
                    CharVal = 51
                Case "T"
                    Binaire = Binaire & "11011100010"
                    CharVal = 52
                Case "U"
                    Binaire = Binaire & "11011101110"
                    CharVal = 53
                Case "V"
                    Binaire = Binaire & "11101011000"
                    CharVal = 54
                Case "W"
                    Binaire = Binaire & "11101000110"
                    CharVal = 55
                Case "X"
                    Binaire = Binaire & "11100010110"
                    CharVal = 56
                Case "Y"
                    Binaire = Binaire & "11101101000"
                    CharVal = 57
                Case "Z"
                    Binaire = Binaire & "11101100010"
                    CharVal = 58
                Case "["
                    Binaire = Binaire & "11100011010"
                    CharVal = 59
                Case "\"
                    Binaire = Binaire & "11101111010"
                    CharVal = 60
                Case "]"
                    Binaire = Binaire & "11001000010"
                    CharVal = 61
                Case "^"
                    Binaire = Binaire & "11110001010"
                    CharVal = 62
                Case "_"
                    Binaire = Binaire & "10100110000"
                    CharVal = 63
                Case "`"
                    Binaire = Binaire & "10100001100"
                    CharVal = 64
                Case "a"
                    Binaire = Binaire & "10010110000"
                    CharVal = 65
                Case "b"
                    Binaire = Binaire & "10010000110"
                    CharVal = 66
                Case "c"
                    Binaire = Binaire & "10000101100"
                    CharVal = 67
                Case "d"
                    Binaire = Binaire & "10000100110"
                    CharVal = 68
                Case "e"
                    Binaire = Binaire & "10110010000"
                    CharVal = 69
                Case "f"
                    Binaire = Binaire & "10110000100"
                    CharVal = 70
                Case "g"
                    Binaire = Binaire & "10011010000"
                    CharVal = 71
                Case "h"
                    Binaire = Binaire & "10011000010"
                    CharVal = 72
                Case "i"
                    Binaire = Binaire & "10000110100"
                    CharVal = 73
                Case "j"
                    Binaire = Binaire & "10000110010"
                    CharVal = 74
                Case "k"
                    Binaire = Binaire & "11000010010"
                    CharVal = 75
                Case "l"
                    Binaire = Binaire & "11001010000"
                    CharVal = 76
                Case "m"
                    Binaire = Binaire & "11110111010"
                    CharVal = 77
                Case "n"
                    Binaire = Binaire & "11000010100"
                    CharVal = 78
                Case "o"
                    Binaire = Binaire & "10001111010"
                    CharVal = 79
                Case "p"
                    Binaire = Binaire & "10100111100"
                    CharVal = 80
                Case "q"
                    Binaire = Binaire & "10010111100"
                    CharVal = 81
                Case "r"
                    Binaire = Binaire & "10010011110"
                    CharVal = 82
                Case "s"
                    Binaire = Binaire & "10111100100"
                    CharVal = 83
                Case "t"
                    Binaire = Binaire & "10011110100"
                    CharVal = 84
                Case "u"
                    Binaire = Binaire & "10011110010"
                    CharVal = 85
                Case "v"
                    Binaire = Binaire & "11110100100"
                    CharVal = 86
                Case "w"
                    Binaire = Binaire & "11110010100"
                    CharVal = 87
                Case "x"
                    Binaire = Binaire & "11110010010"
                    CharVal = 88
                Case "y"
                    Binaire = Binaire & "11011011110"
                    CharVal = 89
                Case "z"
                    Binaire = Binaire & "11011110110"
                    CharVal = 90
                Case "{"
                    Binaire = Binaire & "11110110110"
                    CharVal = 91
                Case "|"
                    Binaire = Binaire & "10101111000"
                    CharVal = 92
                Case "}"
                    Binaire = Binaire & "10100011110"
                    CharVal = 93
                Case "~"
                    Binaire = Binaire & "10001011110"
                    CharVal = 94
            End Select
            CharCount = CharCount + 1
            GrandCharCount = CharVal * CharCount
            Somme = Somme + GrandCharCount

        Next

        Somme = Somme + 104
        SommeValeur = Somme Mod 103

        ValeurBinaire = 0
        GenererSomme(SommeValeur)

        Binaire = "00011010010000" & Binaire
        Binaire = Binaire & ValeurBinaire & "1100011101011000"

        LongueurBinaire = 0
        For Each dig As String In Binaire
            CharCount = CharCount + 1
        Next


    End Sub

    Private Sub GenererSomme(Dig As Integer)
        Select Case Dig
            Case "0"
                ValeurBinaire = "11011001100"
            Case "1"
                ValeurBinaire = "11001101100"
            Case "2"
                ValeurBinaire = "11001100110"
            Case "3"
                ValeurBinaire = "10010011000"
            Case "4"
                ValeurBinaire = "10010001100"
            Case "5"
                ValeurBinaire = "10001001100"
            Case "6"
                ValeurBinaire = "10011001000"
            Case "7"
                ValeurBinaire = "10011000100"
            Case "8"
                ValeurBinaire = "10001100100"
            Case "9"
                ValeurBinaire = "11001001000"
            Case "10"
                ValeurBinaire = "11001000100"
            Case "11"
                ValeurBinaire = "11000100100"
            Case "12"
                ValeurBinaire = "10110011100"
            Case "13"
                ValeurBinaire = "10011011100"
            Case "14"
                ValeurBinaire = "10011001110"
            Case "15"
                ValeurBinaire = "10111001100"
            Case "16"
                ValeurBinaire = "10011101100"
            Case "17"
                ValeurBinaire = "10011100110"
            Case "18"
                ValeurBinaire = "11001110010"
            Case "19"
                ValeurBinaire = "11001011100"
            Case "20"
                ValeurBinaire = "11001001110"
            Case "21"
                ValeurBinaire = "11011100100"
            Case "22"
                ValeurBinaire = "11001110100"
            Case "23"
                ValeurBinaire = "11101101110"
            Case "24"
                ValeurBinaire = "11101001100"
            Case "25"
                ValeurBinaire = "11100101100"
            Case "26"
                ValeurBinaire = "11100100110"
            Case "27"
                ValeurBinaire = "11101100100"
            Case "28"
                ValeurBinaire = "11100110100"
            Case "29"
                ValeurBinaire = "11100110010"
            Case "30"
                ValeurBinaire = "11011011000"
            Case "31"
                ValeurBinaire = "11011000110"
            Case "32"
                ValeurBinaire = "11000110110"
            Case "33"
                ValeurBinaire = "10100011000"
            Case "34"
                ValeurBinaire = "10001011000"
            Case "35"
                ValeurBinaire = "10001000110"
            Case "36"
                ValeurBinaire = "10110001000"
            Case "37"
                ValeurBinaire = "10001101000"
            Case "38"
                ValeurBinaire = "10001100010"
            Case "39"
                ValeurBinaire = "11010001000"
            Case "40"
                ValeurBinaire = "11000101000"
            Case "41"
                ValeurBinaire = "11000100010"
            Case "42"
                ValeurBinaire = "10110111000"
            Case "43"
                ValeurBinaire = "10110001110"
            Case "44"
                ValeurBinaire = "10001101110"
            Case "45"
                ValeurBinaire = "10111011000"
            Case "46"
                ValeurBinaire = "10111000110"
            Case "47"
                ValeurBinaire = "10001110110"
            Case "48"
                ValeurBinaire = "11101110110"
            Case "49"
                ValeurBinaire = "11010001110"
            Case "50"
                ValeurBinaire = "11000101110"
            Case "51"
                ValeurBinaire = "11011101000"
            Case "52"
                ValeurBinaire = "11011100010"
            Case "53"
                ValeurBinaire = "11011101110"
            Case "54"
                ValeurBinaire = "11101011000"
            Case "55"
                ValeurBinaire = "11101000110"
            Case "56"
                ValeurBinaire = "11100010110"
            Case "57"
                ValeurBinaire = "11101101000"
            Case "58"
                ValeurBinaire = "11101100010"
            Case "59"
                ValeurBinaire = "11100011010"
            Case "60"
                ValeurBinaire = "11101111010"
            Case "61"
                ValeurBinaire = "11001000010"
            Case "62"
                ValeurBinaire = "11110001010"
            Case "63"
                ValeurBinaire = "10100110000"
            Case "64"
                ValeurBinaire = "10100001100"
            Case "65"
                ValeurBinaire = "10010110000"
            Case "66"
                ValeurBinaire = "10010000110"
            Case "67"
                ValeurBinaire = "10000101100"
            Case "68"
                ValeurBinaire = "10000100110"
            Case "69"
                ValeurBinaire = "10110010000"
            Case "70"
                ValeurBinaire = "10110000100"
            Case "71"
                ValeurBinaire = "10011010000"
            Case "72"
                ValeurBinaire = "10011000010"
            Case "73"
                ValeurBinaire = "10000110100"
            Case "74"
                ValeurBinaire = "10000110010"
            Case "75"
                ValeurBinaire = "11000010010"
            Case "76"
                ValeurBinaire = "11001010000"
            Case "77"
                ValeurBinaire = "11110111010"
            Case "78"
                ValeurBinaire = "11000010100"
            Case "79"
                ValeurBinaire = "10001111010"
            Case "80"
                ValeurBinaire = "10100111100"
            Case "81"
                ValeurBinaire = "10010111100"
            Case "82"
                ValeurBinaire = "10010011110"
            Case "83"
                ValeurBinaire = "10111100100"
            Case "84"
                ValeurBinaire = "10011110100"
            Case "85"
                ValeurBinaire = "10011110010"
            Case "86"
                ValeurBinaire = "11110100100"
            Case "87"
                ValeurBinaire = "11110010100"
            Case "88"
                ValeurBinaire = "11110010010"
            Case "89"
                ValeurBinaire = "11011011110"
            Case "90"
                ValeurBinaire = "11011110110"
            Case "91"
                ValeurBinaire = "11110110110"
            Case "92"
                ValeurBinaire = "10101111000"
            Case "93"
                ValeurBinaire = "10100011110"
            Case "94"
                ValeurBinaire = "10001011110"

        End Select



    End Sub

    'Remplissage de la picturebox avec les informations binaire
    Private Sub GenererCodeBarre(saisie As String)

        Dim num As Integer = 0
        For Each one As String In saisie
            num = num + 2
        Next

        Dim rec As New Rectangle(1, 1, num, 100)
        Dim img As New Bitmap(num, Convert.ToInt32(100))



        Dim count As Integer = 0
        Dim length As Integer = 100

        Dim ligneNoire As New Pen(Color.Black)
        Dim ligneBlanche As New Pen(Color.White)

        ligneNoire.Width = 2
        ligneBlanche.Width = 2


        For Each element As String In saisie
            count = count + 2

            If element = 1 Then
                codeBarre.CreateGraphics.DrawLine(ligneNoire, count, 1, count, length)

            Else
                codeBarre.CreateGraphics.DrawLine(ligneBlanche, count, 1, count, length)

            End If

        Next

        codeBarre.DrawToBitmap(img, rec)

        PDF = img 'Impression en PDF éventuelle
    End Sub

    'Permet de reset le code barre
    Sub clearCodeBarre()
        For ctr As Integer = 0 To 600
            codeBarre.CreateGraphics.DrawLine(New Pen(Color.White), ctr, 1, ctr, 100)
        Next
    End Sub

    Private Sub PrintImage(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles printDoc.PrintPage
        e.Graphics.DrawImage(getBitmap(codeBarre), e.MarginBounds.Left, e.MarginBounds.Top)
    End Sub

    'Fonction utilisée pour prendre un screenshot du composant codeBarre. Un screenshot est utilisé pour éviter de perdre les informations des lignes ajoutés par dessus le contrôle
    Private Function getBitmap(ByVal pCtrl As Control) As Drawing.Bitmap
        Dim ScreenPos As Point = Me.PointToScreen(New Point(0, 0))
        Dim myBmp As New Bitmap(pCtrl.Width, pCtrl.Height)
        Dim g As Graphics = Graphics.FromImage(myBmp)
        Dim pOffset As New Point(pCtrl.Parent.Width - pCtrl.Parent.ClientRectangle.Width - 4, pCtrl.Parent.Height - pCtrl.Parent.ClientRectangle.Height - 4)
        g.CopyFromScreen(ScreenPos + pCtrl.Parent.Location + pCtrl.Location + pOffset, Point.Empty, myBmp.Size)
        Return myBmp
        g.Dispose()
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        printDoc.Print()
    End Sub

    Private Sub controlGenerationCodeBarre_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnSave.Visible = False
    End Sub

    Private Sub btnQuitter_Click(sender As Object, e As EventArgs) Handles btnQuitter.Click
        Me.Visible = False
        Form1.control_identif.Dock = DockStyle.Fill
        Form1.control_identif.Visible = True
    End Sub
End Class
