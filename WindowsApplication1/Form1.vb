Public Class Form1
    Dim price, quan As Double
    Dim total, rec, change As Double
    Private Sub buExit_Click(sender As Object, e As EventArgs) Handles buExit.Click
        End
    End Sub

    Private Sub buChange_Click(sender As Object, e As EventArgs) Handles buChange.Click
        If tbName.Text = "" Then
            MessageBox.Show("Please fill up your order", "No Entry", MessageBoxButtons.OK, MessageBoxIcon.Error)
            With tbName
                .Focus()
                .SelectAll()
            End With
            Exit Sub
        End If
        If cbMeal.Text = "" Then
            MessageBox.Show("Please fill up your order", "No Entry", MessageBoxButtons.OK, MessageBoxIcon.Error)
            With cbMeal
                .Focus()
                .SelectAll()
            End With
            Exit Sub
        End If
        If tbQuantity.Text = "" Then
            MessageBox.Show("Please fill up your order", "No Entry", MessageBoxButtons.OK, MessageBoxIcon.Error)
            With tbQuantity
                .Focus()
                .SelectAll()
            End With
            Exit Sub
        End If
        If tbAmount.Text = "" Then
            MessageBox.Show("Please fill up your order", "No Entry", MessageBoxButtons.OK, MessageBoxIcon.Error)
            With tbAmount
                .Focus()
                .SelectAll()
            End With
            Exit Sub
        End If
        change = rec - total
        If change <= 0 Then
            MessageBox.Show("Sorry, Not enough your money.", "Sorry", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        tbChange.Text = change
    End Sub

    Private Sub cbMeal_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbMeal.SelectedIndexChanged
        If cbMeal.Text = "CCS Meal 1" Then
            chbSpagetti.Checked = True
            chbCarbonara.Checked = False
            chbFettucini.Checked = False
            chbHamAndEgg.Checked = False
            chbHamAndCheese.Checked = True
            chbClubHouse.Checked = False
            chbFruitSalad.Checked = False
            chbCakeSlice.Checked = False
            chbBrownies.Checked = True
            chbSoda.Checked = True
            chbJuice.Checked = False
            chbIcedTea.Checked = False
            tbPrice.Text = "170.00"

        End If
        If cbMeal.Text = "CCS Meal 2" Then
            chbSpagetti.Checked = False
            chbCarbonara.Checked = True
            chbFettucini.Checked = False
            chbHamAndEgg.Checked = True
            chbHamAndCheese.Checked = False
            chbClubHouse.Checked = False
            chbFruitSalad.Checked = True
            chbCakeSlice.Checked = False
            chbBrownies.Checked = False
            chbSoda.Checked = False
            chbJuice.Checked = False
            chbIcedTea.Checked = True
            tbPrice.Text = "200.00"

        End If
        If cbMeal.Text = "CCS Meal 3" Then
            chbSpagetti.Checked = False
            chbCarbonara.Checked = False
            chbFettucini.Checked = True
            chbHamAndEgg.Checked = False
            chbHamAndCheese.Checked = False
            chbClubHouse.Checked = True
            chbFruitSalad.Checked = False
            chbCakeSlice.Checked = True
            chbBrownies.Checked = False
            chbSoda.Checked = False
            chbJuice.Checked = True
            chbIcedTea.Checked = False
            tbPrice.Text = "250.00"
        End If


    End Sub

    Private Sub tbPrice_TextChanged(sender As Object, e As EventArgs) Handles tbPrice.TextChanged
        price = Val(tbPrice.Text)
    End Sub

    Private Sub tbAmount_TextChanged(sender As Object, e As EventArgs) Handles tbAmount.TextChanged
        rec = Val(tbAmount.Text)
    End Sub

    Private Sub tbName_TextChanged(sender As Object, e As EventArgs) Handles tbName.TextChanged

    End Sub

    Private Sub buViewReceipt_Click(sender As Object, e As EventArgs) Handles buViewReceipt.Click
        If cbMeal.SelectedItem = "CCS Meal 1" Then
            Me.Hide()
            Form2.Show()
            Form2.laName.Text = Me.tbName.Text
            Form2.lbOrder.Items.Add(Me.chbSpagetti.Text)
            Form2.lbOrder.Items.Add(Me.chbHamAndCheese.Text)
            Form2.lbOrder.Items.Add(Me.chbBrownies.Text)
            Form2.lbOrder.Items.Add(Me.chbSoda.Text)
            Form2.laChange.Text = Me.tbChange.Text
            Form2.laAmRe.Text = Me.tbAmount.Text
            Form2.laTotal.Text = Me.tbTotal.Text
            Form2.laQuan.Text = Me.tbQuantity.Text
            Form2.laMeal.Text = Me.cbMeal.Text
            Form2.laPrice.Text = Me.tbPrice.Text
        End If
        If cbMeal.SelectedItem = "CCS Meal 2" Then
            Me.Hide()
            Form2.Show()
            Form2.laName.Text = Me.tbName.Text
            Form2.lbOrder.Items.Add(Me.chbCarbonara.Text)
            Form2.lbOrder.Items.Add(Me.chbHamAndEgg.Text)
            Form2.lbOrder.Items.Add(Me.chbFruitSalad.Text)
            Form2.lbOrder.Items.Add(Me.chbIcedTea.Text)
            Form2.laChange.Text = Me.tbChange.Text
            Form2.laAmRe.Text = Me.tbAmount.Text
            Form2.laTotal.Text = Me.tbTotal.Text
            Form2.laQuan.Text = Me.tbQuantity.Text
            Form2.laMeal.Text = Me.cbMeal.Text
            Form2.laPrice.Text = Me.tbPrice.Text
        End If
        If cbMeal.SelectedItem = "CCS Meal 3" Then
            Me.Hide()
            Form2.Show()
            Form2.laName.Text = Me.tbName.Text
            Form2.lbOrder.Items.Add(Me.chbFettucini.Text)
            Form2.lbOrder.Items.Add(Me.chbClubHouse.Text)
            Form2.lbOrder.Items.Add(Me.chbCakeSlice.Text)
            Form2.lbOrder.Items.Add(Me.chbJuice.Text)
            Form2.laChange.Text = Me.tbChange.Text
            Form2.laAmRe.Text = Me.tbAmount.Text
            Form2.laTotal.Text = Me.tbTotal.Text
            Form2.laQuan.Text = Me.tbQuantity.Text
            Form2.laMeal.Text = Me.cbMeal.Text
            Form2.laPrice.Text = Me.tbPrice.Text
        End If
    End Sub
    Private Sub buClear_Click(sender As Object, e As EventArgs) Handles buClear.Click
        chbSpagetti.Checked = False
        chbCarbonara.Checked = False
        chbFettucini.Checked = False
        chbHamAndEgg.Checked = False
        chbHamAndCheese.Checked = False
        chbClubHouse.Checked = False
        chbFruitSalad.Checked = False
        chbCakeSlice.Checked = False
        chbBrownies.Checked = False
        chbSoda.Checked = False
        chbJuice.Checked = False
        chbIcedTea.Checked = False
        tbName.Text = ""
        cbMeal.Text = ""
        tbPrice.Text = ""
        tbQuantity.Text = ""
        tbTotal.Text = ""
        tbAmount.Text = ""
        tbChange.Text = ""
    End Sub
    Private Sub tbQuantity_TextChanged(sender As Object, e As EventArgs) Handles tbQuantity.TextChanged
        quan = Val(tbQuantity.Text)
        tbTotal.Text = price * quan
        total = tbTotal.Text
    End Sub
    Private Sub tbTotal_TextChanged(sender As Object, e As EventArgs) Handles tbTotal.TextChanged

    End Sub
End Class
