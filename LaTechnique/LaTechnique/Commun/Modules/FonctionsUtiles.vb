Imports MySql.Data.Types
Imports System.IO
Imports System.Net.Mail

Module FonctionsUtiles
    Public Function verifierColonneDataSet(ByVal dataSet As DataTable, ByVal ligne As Integer, ByVal nomColonne As String)
        If Not dataSet.Columns.Contains(nomColonne) OrElse IsDBNull(dataSet.Rows(ligne).Item(nomColonne)) Then
            Return Nothing
        ElseIf nomColonne = "photo" Then
            Return ConvertByteArrayToImage(dataSet.Rows(ligne).Item(nomColonne))
        Else
            Select Case dataSet.Columns(nomColonne).DataType.ToString
                Case "MySql.Data.Types.MySqlDateTime"
                    Return ConvtireDate(dataSet.Rows(ligne).Item(nomColonne))
                Case "System.Byte[]"
                    Return BittoStr(dataSet.Rows(ligne).Item(nomColonne)).Replace("´", "'")
                Case "System.String"
                    Return dataSet.Rows(ligne).Item(nomColonne).Replace("´", "'")
                Case Else
                    Return dataSet.Rows(ligne).Item(nomColonne)
            End Select
        End If
    End Function
    Public Function ConvertByteArrayToImage(ByVal tableau As Byte()) As Image
        Try
            Dim myimage As Image
            Dim ms As MemoryStream = New MemoryStream(tableau)
            myimage = Image.FromStream(ms)
            Return myimage
        Catch

            Return Nothing
        End Try
    End Function

    Function ConvtireDate(dateMySql As MySqlDateTime)
        Dim jour As String
        Dim mois As String

        If (dateMySql.Day < 10) Then
            jour = "0"
        Else
            jour = ""
        End If

        jour = jour & dateMySql.Day

        If (dateMySql.Month < 10) Then
            mois = "0"
        Else
            mois = ""
        End If

        mois = mois & dateMySql.Month
        Return Date.ParseExact(jour & "/" & mois & "/" & dateMySql.Year, "dd/MM/yyyy",
                       Globalization.DateTimeFormatInfo.InvariantInfo)
    End Function
    Function BittoStr(bit As Byte())
        Return Text.Encoding.UTF8.GetString(bit)
    End Function

End Module
