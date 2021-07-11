Public Class Form2
    Private Sub buEXIT2_Click(sender As Object, e As EventArgs) Handles buEXIT2.Click
        End
    End Sub

    Private Sub buBACK_Click(sender As Object, e As EventArgs) Handles buBACK.Click
        lbOrder.Items.Clear()
        Me.Hide()
        Form1.Show()
    End Sub
End Class