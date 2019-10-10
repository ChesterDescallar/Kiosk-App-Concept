Public Class ShoppingBasket
    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        Me.Hide()
        SelectType.Show()
    End Sub

    Private Sub button2_Click(sender As Object, e As EventArgs) Handles button2.Click
        Me.Hide()
        SelectAmount.Show()
    End Sub

    Private Sub button3_Click(sender As Object, e As EventArgs) Handles button3.Click
        Me.Hide()
        SelectImage.Show()
    End Sub

    Private Sub button4_Click(sender As Object, e As EventArgs) Handles button4.Click
        Me.Hide()
        MessageBox.Show()
    End Sub

    Private Sub pictureBox3_Click(sender As Object, e As EventArgs) Handles pictureBox3.Click
        Me.Hide()
        MessageBox.Show()

    End Sub

    Private Sub button14_Click(sender As Object, e As EventArgs) Handles button14.Click
        Me.Hide()
        Payment.Show()
    End Sub
End Class