Public Class Form1
    Dim a1s, b1s, c1s, a2s, b2s, c2s, a3s, b3s, c3s As Integer
    Dim p1, p2 As Integer
    Dim a, b As Integer
     
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim r As Integer

        r = MsgBox("Deseja sair?", 4, "quit")
        If r = 6 Then
            Me.Close()

        End If

    End Sub
    Private Sub a1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles a1.Click
        a1.Text = ""
        If p1 = p2 Then
            p1 = p1 + 1
            p2 = p1 - 1
            a1.Image = ImageList1.Images(a)
            a1s = 1

            Svitoria(a1s, b1s, c1s, a2s, b2s, c2s, a3s, b3s, c3s)
        Else
            p2 = p2 + 1
            a1.Image = ImageList1.Images(b)
            a1s = -1

            Svitoria(a1s, b1s, c1s, a2s, b2s, c2s, a3s, b3s, c3s)


        End If



    End Sub
    Private Sub b1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles b1.Click
        b1.Text = ""
        If p1 = p2 Then
            p1 = p1 + 1
            p2 = p1 - 1
            b1.Image = ImageList1.Images(a)
            b1s = 1

            Svitoria(a1s, b1s, c1s, a2s, b2s, c2s, a3s, b3s, c3s)
        Else
            p2 = p2 + 1
            b1.Image = ImageList1.Images(b)
            b1s = -1

            Svitoria(a1s, b1s, c1s, a2s, b2s, c2s, a3s, b3s, c3s)
        End If
    End Sub

    Private Sub c1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles c1.Click
        c1.Text = ""
        If p1 = p2 Then
            p1 = p1 + 1
            p2 = p1 - 1
            c1.Image = ImageList1.Images(a)
            c1s = 1

            Svitoria(a1s, b1s, c1s, a2s, b2s, c2s, a3s, b3s, c3s)
        Else
            p2 = p2 + 1
            c1.Image = ImageList1.Images(b)
            c1s = -1

            Svitoria(a1s, b1s, c1s, a2s, b2s, c2s, a3s, b3s, c3s)
        End If
    End Sub

    Private Sub c2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles c2.Click
        c2.Text = ""
        If p1 = p2 Then
            p1 = p1 + 1
            c2.Image = ImageList1.Images(a)
            c2s = 1

            Svitoria(a1s, b1s, c1s, a2s, b2s, c2s, a3s, b3s, c3s)
        Else
            p2 = p2 + 1
            c2.Image = ImageList1.Images(b)
            c2s = -1

            Svitoria(a1s, b1s, c1s, a2s, b2s, c2s, a3s, b3s, c3s)
        End If

    End Sub

    Private Sub b2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles b2.Click
        b2.Text = ""
        If p1 = p2 Then
            p1 = p1 + 1
            b2.Image = ImageList1.Images(a)
            b2s = 1

            Svitoria(a1s, b1s, c1s, a2s, b2s, c2s, a3s, b3s, c3s)
        Else
            p2 = p2 + 1
            b2.Image = ImageList1.Images(b)
            b2s = -1

            Svitoria(a1s, b1s, c1s, a2s, b2s, c2s, a3s, b3s, c3s)
        End If



    End Sub

    Private Sub a2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles a2.Click
        a2.Text = ""
        If p1 = p2 Then
            p1 = p1 + 1
            a2.Image = ImageList1.Images(a)
            a2s = 1

            Svitoria(a1s, b1s, c1s, a2s, b2s, c2s, a3s, b3s, c3s)
        Else
            p2 = p2 + 1
            a2.Image = ImageList1.Images(b)
            a2s = -1

            Svitoria(a1s, b1s, c1s, a2s, b2s, c2s, a3s, b3s, c3s)
        End If
    End Sub

    Private Sub a3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles a3.Click
        a3.Text = ""
        If p1 = p2 Then
            p1 = p1 + 1
            a3.Image = ImageList1.Images(a)
            a3s = 1

            Svitoria(a1s, b1s, c1s, a2s, b2s, c2s, a3s, b3s, c3s)
        Else
            p2 = p2 + 1
            a3.Image = ImageList1.Images(b)
            a3s = -1

            Svitoria(a1s, b1s, c1s, a2s, b2s, c2s, a3s, b3s, c3s)
        End If

    End Sub

    Private Sub b3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles b3.Click
        b3.Text = ""
        If p1 = p2 Then
            p1 = p1 + 1
            b3.Image = ImageList1.Images(a)
            b3s = 1

            Svitoria(a1s, b1s, c1s, a2s, b2s, c2s, a3s, b3s, c3s)
        Else
            p2 = p2 + 1
            b3.Image = ImageList1.Images(b)
            b3s = -1

            Svitoria(a1s, b1s, c1s, a2s, b2s, c2s, a3s, b3s, c3s)
        End If



    End Sub

    Private Sub c3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles c3.Click
        c3.Text = ""
        If p1 = p2 Then
            p1 = p1 + 1
            c3.Image = ImageList1.Images(a)
            c3s = 1

            Svitoria(a1s, b1s, c1s, a2s, b2s, c2s, a3s, b3s, c3s)
        Else
            p2 = p2 + 1
            c3.Image = ImageList1.Images(b)
            c3s = -1

            Svitoria(a1s, b1s, c1s, a2s, b2s, c2s, a3s, b3s, c3s)
        End If

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click

        If a = b Then
            a = 0
            b = 1
        End If


        Button3.Visible = False
        Button2.Visible = False
        Button5.Visible = False
        Button8.Visible = True
        Button4.Visible = True
        a1.Visible = True
        a2.Visible = True
        a3.Visible = True
        b1.Visible = True
        b2.Visible = True
        b3.Visible = True
        c1.Visible = True
        c2.Visible = True
        c3.Visible = True


    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        a1.Image = ImageList1.Images(2)
        a2.Image = ImageList1.Images(2)
        a3.Image = ImageList1.Images(2)
        b1.Image = ImageList1.Images(2)
        b2.Image = ImageList1.Images(2)
        b3.Image = ImageList1.Images(2)
        c1.Image = ImageList1.Images(2)
        c2.Image = ImageList1.Images(2)
        c3.Image = ImageList1.Images(2)
        a1s = 0
        b1s = 0
        c1s = 0
        a2s = 0
        b2s = 0
        c2s = 0
        a3s = 0
        b3s = 0
        c3s = 0
        p1 = 0
        p2 = 0
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim r As Integer

        r = MsgBox("Deseja sair?", 4, "quit")
        If r = 6 Then
            Me.Close()

        End If

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Button6.Visible = True
        Button8.Visible = True
        Button3.Visible = False
        Button2.Visible = False
        Button5.Visible = False

        Button4.Visible = False
        a1.Visible = False
        a2.Visible = False
        a3.Visible = False
        b1.Visible = False
        b2.Visible = False
        b3.Visible = False
        c1.Visible = False
        c2.Visible = False
        c3.Visible = False

        If a = 0 Then
            Button6.Text = " jogador joga com cruz"
        End If
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click

        If a = 1 Then

            Button6.Text = "jogador 1 joga com cruz"
            a = 0
            b = 1
        Else
            Button6.Text = "jogador 1 joga com bola"


            a = 1
            b = 0
        End If
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        Button3.Visible = True
        Button2.Visible = True
        Button5.Visible = True
        Button8.Visible = False
        Button4.Visible = False
        Button6.Visible = False
        a1.Visible = False
        a2.Visible = False
        a3.Visible = False
        b1.Visible = False
        b2.Visible = False
        b3.Visible = False
        c1.Visible = False
        c2.Visible = False
        c3.Visible = False

    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Button3.Visible = True
        Button2.Visible = True
        Button5.Visible = True

        Button4.Visible = False
        Button6.Visible = False
        a1.Visible = False
        a2.Visible = False
        a3.Visible = False
        b1.Visible = False
        b2.Visible = False
        b3.Visible = False
        c1.Visible = False
        c2.Visible = False
        c3.Visible = False
    End Sub
End Class
