Public Class controlIdentification
    Private Sub txtNum_TextChanged(sender As Object, e As EventArgs) Handles txtNum.TextChanged
        Form1.identification()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form1.control_co.Visible = True
        Form1.control_co.Dock = DockStyle.Fill
        Me.Visible = False
    End Sub
End Class
