Private Sub Button3_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        TextBox3.Clear()
        Label13.Text = ""
        Label14.Text = ""
        Label15.Text = ""
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        Dim sqrt As Double
        sqrt = Convert.ToDouble(TextBox3.Text)
        TextBox3.Text = Convert.ToString(Math.Sqrt(sqrt))

    End Sub

    Private Sub TextBox3_TextChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox3.TextChanged

    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Dim numb As Double
        numb = Convert.ToDouble(TextBox3.Text)
        Dim nu As Double
        nu = numb - numb - numb
        TextBox3.Text = Convert.ToString(nu)
    End Sub

    Private Sub Button27_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button27.Click
        TextBox3.AppendText(0)
    End Sub

    Private Sub Button22_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button22.Click
        TextBox3.AppendText(1)
    End Sub

    Private Sub Button18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button18.Click
        TextBox3.AppendText(2)
    End Sub

    Private Sub Button20_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button20.Click
        TextBox3.AppendText(3)
    End Sub

    Private Sub Button17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button17.Click
        TextBox3.AppendText(4)
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        TextBox3.AppendText(5)
    End Sub

    Private Sub Button15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button15.Click
        TextBox3.AppendText(6)
    End Sub

    Private Sub Button13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button13.Click
        TextBox3.AppendText(7)
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        TextBox3.AppendText(8)
    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        TextBox3.AppendText(9)
    End Sub

    Private Sub Button23_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button23.Click
        TextBox3.AppendText(".")
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Label13.Text = TextBox3.Text
        Label14.Text = "+"
        TextBox3.Clear()
    End Sub

    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click
        Label13.Text = TextBox3.Text
        Label14.Text = "-"
        TextBox3.Clear()
    End Sub

    Private Sub Button16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button16.Click
        Label13.Text = TextBox3.Text
        Label14.Text = "*"
        TextBox3.Clear()
    End Sub

    Private Sub Button21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button21.Click
        Label13.Text = TextBox3.Text
        Label14.Text = "/"
        TextBox3.Clear()
    End Sub

    Private Sub Button24_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button24.Click
        Label15.Text = TextBox3.Text
        Dim sign As Char
        sign = Label14.Text
        Dim n1 As Double
        n1 = Convert.ToDouble(Label13.Text)
        Dim n2 As Double
        n2 = Convert.ToDouble(Label15.Text)
        Dim n3 As Double

        Select Case (sign)
            Case "+"
                n3 = n1 + n2
            Case "-"
                n3 = n1 - n2
            Case "*"
                n3 = n1 * n2
            Case "/"
                n3 = n1 / n2
        End Select
        TextBox3.Text = Convert.ToString(n3)
    End Sub

    Private Sub TabPage4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabPage4.Click

    End Sub
