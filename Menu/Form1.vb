Public Class Welcome

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnPlay_Click(sender As Object, e As EventArgs) Handles btnPlay.Click
        Dim MessageFrm As New messageForm
        MessageFrm.ShowDialog()
    End Sub
End Class
