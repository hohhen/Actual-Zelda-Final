Public Class messageForm

    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Dim prevy As Integer = player.Top
        Dim prevx As Integer = player.Left
        Dim Dunform As New DungeonForm
        Dim form1 As New Welcome
        Dim Down As New down
        form1.Close()
        Select Case e.KeyCode
            Case Keys.W
                player.Top -= 5
            Case Keys.A
                player.Left -= 5
            Case Keys.S
                player.Top += 5
            Case Keys.D
                player.Left += 5
        End Select
        obsticle.Visible = False
        obsticle2.Visible = False
        obsticle3.Visible = False
        obsticle4.Visible = False
        obsticle5.Visible = False
        obsticle6.Visible = False
        obsticle7.Visible = False
        obsticle8.Visible = False
        obsticle9.Visible = False
        obsticle10.Visible = False
        obsticle11.Visible = False
        obsticle12.Visible = False
        obsticle13.Visible = False
        If testcollision(player, obsticle) = True Then
            player.Top = prevy
            player.Left = prevx
        End If
        If testcollision(player, obsticle2) = True Then
            player.Top = prevy
            player.Left = prevx
        End If
        If testcollision(player, obsticle3) = True Then
            player.Top = prevy
            player.Left = prevx
        End If
        If testcollision(player, obsticle4) = True Then
            player.Top = prevy
            player.Left = prevx
        End If
        If testcollision(player, obsticle5) = True Then
            player.Top = prevy
            player.Left = prevx
        End If
        If testcollision(player, obsticle6) = True Then
            player.Top = prevy
            player.Left = prevx
        End If
        If testcollision(player, obsticle7) = True Then
            player.Top = prevy
            player.Left = prevx
        End If
        If testcollision(player, obsticle8) = True Then
            player.Top = prevy
            player.Left = prevx
        End If
        If testcollision(player, obsticle9) = True Then
            player.Top = prevy
            player.Left = prevx
        End If
        If testcollision(player, obsticle10) = True Then
            player.Top = prevy
            player.Left = prevx
        End If
        If testcollision(player, obsticle11) = True Then
            player.Top = prevy
            player.Left = prevx
        End If
        If testcollision(player, obsticle12) = True Then
            player.Top = prevy
            player.Left = prevx
        End If
        If testcollision(player, obsticle13) = True Then
            player.Top = prevy
            player.Left = prevx
        End If
        picNext.Visible = False
        If testcollision(player, picNext) = True Then
            Dunform.ShowDialog()
        End If
        picDown.Visible = False
        If testcollision(player, picDown) = True Then
            Down.ShowDialog()
        End If
    End Sub

    Function testcollision(ByRef pic1 As PictureBox, ByVal pic2 As PictureBox) As Boolean
        If pic1.Top < pic2.Bottom And pic1.Left < pic2.Right And pic1.Bottom > pic2.Top And pic1.Right > pic2.Left Then
            Return True
        End If
        Return False
    End Function

    Private Sub player_Click(sender As Object, e As EventArgs) Handles player.Click

    End Sub
End Class