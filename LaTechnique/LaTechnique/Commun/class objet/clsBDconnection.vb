Imports System.Data
Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient
Imports System.Windows.Forms

Public Class clsBDconnection

    Private _position As Integer = 0
    Public Const _Connectionstring As String = "Server=192.168.108.124; DataBase=technique; UId=user; Pwd=; Allow Zero DateTime=true ; Convert Zero Datetime=true; "
    Friend _conn As New MySqlConnection
    Private _cmd As MySqlCommand
    Dim gestionOperation As New MySqlCommandBuilder

    '- Permet de set ou get la position actuel de la personne sélectionner
    Public Property position() As Integer
        Get
            Return _position
        End Get
        Set(ByVal value As Integer)
            _position = value
        End Set
    End Property


    '- Remplie mon dataset des données de ma bd en fonction de la requête envoyée.
    Sub Requete(ByVal req As String, ByVal ds As DataSet, ByVal da As MySqlDataAdapter, ByVal table As String)
        _conn.Close()
        _conn.ConnectionString = _Connectionstring

        Try
            If _conn.State <> ConnectionState.Open Then
                _conn.Open()
            End If
        Catch ae As SqlException
            MessageBox.Show(ae.Message.ToString())
        End Try



        _cmd = New MySqlCommand
        _cmd.Connection = _conn
        _cmd.CommandText = req
        da.SelectCommand = _cmd



        Try
            '_cmd.ExecuteNonQuery()
            da = New MySqlDataAdapter(_cmd)
            da.Fill(ds, table)

        Catch ae As SqlException
            MessageBox.Show(ae.Message.ToString())

        End Try

        _conn.Close()
    End Sub

    '- Met à jour la bd selon la requete que je suis envoie. Elle sert pour les inserts, les updates, et les deletes.
    Sub InsDelUpd(ByVal req As String)

        'AJOUT CAR CA BUG
        If _conn.State = ConnectionState.Open Then _conn.Close()
        _conn.ConnectionString = _Connectionstring

        Try
            If _conn.State <> ConnectionState.Open Then
                _conn.Open()
            End If
        Catch e As SqlException
            MessageBox.Show(e.Message.ToString())
        End Try



        _cmd = New MySqlCommand(req, _conn)


        Try
            _cmd.ExecuteNonQuery()
        Catch e As SqlException
            MessageBox.Show(e.Message.ToString())

        End Try

        _conn.Close()


    End Sub

    '- Met à jour la bd en fonction du dataset que je lui passe en paramètre
    Sub miseAjourBD(ByVal ds As DataSet, ByVal da As MySqlDataAdapter, tbl As String)

        _conn.ConnectionString = _Connectionstring

        Try
            If _conn.State <> ConnectionState.Open Then
                _conn.Open()
            End If
        Catch ae As SqlException
            MessageBox.Show(ae.Message.ToString())
        End Try



        Try
            gestionOperation = New MySqlCommandBuilder(da)
            da.Update(ds, tbl)
        Catch e As SqlException
            MessageBox.Show(e.Message.ToString())

        End Try

        _conn.Close()
    End Sub


    '- Met à jour un dataset avec les informations de la bd.
    Sub miseAjourDS(ByRef ds As DataSet, ByRef da As MySqlDataAdapter, req As String, table As String)
        ds = New DataSet
        da = New MySqlDataAdapter
        Requete(req, ds, da, table)
    End Sub

End Class
