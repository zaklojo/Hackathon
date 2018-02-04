Public Class controlIdentification
    Private Sub txtNum_TextChanged(sender As Object, e As EventArgs) Handles txtNum.TextChanged
        Form1.identification()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Visible = False
        Form1.control_generationcode.Dock = DockStyle.Fill
        Form1.control_generationcode.Visible = True
    End Sub
End Class
