Public Class SelectAmount
    Private Sub pictureBox1_Click(sender As Object, e As EventArgs) Handles pictureBox1.Click
        Me.Hide()
        StartPage.Show()
    End Sub

    Private Sub pictureBox3_Click(sender As Object, e As EventArgs) Handles pictureBox3.Click
        Me.Hide()
        SelectType.Show()
    End Sub

    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        Me.Hide()
        SelectType.Show()
    End Sub

    Private Sub button3_Click(sender As Object, e As EventArgs) Handles button3.Click
        Me.Hide()
        SelectImage.Show()
    End Sub

    Private Sub button4_Click(sender As Object, e As EventArgs) Handles button4.Click
        Me.Hide()
        MessageBox.Show()

    End Sub

    Private Sub button5_Click(sender As Object, e As EventArgs) Handles button5.Click
        Me.Hide()
        Payment.Show()
    End Sub

    Private Sub button14_Click(sender As Object, e As EventArgs) Handles button14.Click
        Me.Hide()
        SelectImage.Show()
    End Sub

    Private Sub button11_Click(sender As Object, e As EventArgs) Handles button11.Click
        Me.Hide()
        ShoppingBasket.Show()
    End Sub
End Class