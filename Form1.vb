Public Class CurrencyCalc
    Dim Area As Integer
    Dim Widthh As Integer
    Dim Lengthh As Integer
    Dim Cost As Decimal
    Dim Tax As Decimal
    Dim Grand As Decimal
    Private Sub QuartzButton_Click(sender As Object, e As EventArgs) Handles WoodButton.Click, TileButton.Click, QuartzButton.Click, CarpetButton.Click
        Select Case True
            Case WoodButton.Checked
                CostPerLabel.Text = 11.ToString("c2")
                SqGroupBox.Visible = True
            Case TileButton.Checked
                CostPerLabel.Text = 9.ToString("c2")
                SqGroupBox.Visible = True
            Case QuartzButton.Checked
                CostPerLabel.Text = 50.ToString("c2")
                SqGroupBox.Visible = True
            Case CarpetButton.Checked
                CostPerLabel.Text = 8.ToString("c2")
                SqGroupBox.Visible = True
        End Select

    End Sub
    Private Sub CalcButton_Click(sender As Object, e As EventArgs) Handles CalcButton.Click
        Integer.TryParse(WidthTextBox.Text, Widthh)
        Integer.TryParse(LengthTextBox.Text, Lengthh)
        AreaCalc()
        CostCalc()
    End Sub
    Function AreaCalc() As Integer
        Area = Widthh * Lengthh
        Return True
    End Function
    Sub CostCalc()
        Cost = (Area * CostPerLabel.Text)
        Tax = (Cost * 0.07)
        Grand = (Cost + Tax)
        GrandLabel.Text = "$" & Grand.ToString("n2")
        CostLabel.Text = "$" & Cost.ToString("n2")
        TaxLabel.Text = "$" & Tax.ToString("n2")
    End Sub
End Class
' Carpet is 8 Dollars per Sqft
' Wood is 11 Dollars per Sqft
' Tile is 9 Dollars per Sqft
' Quartz is 50 Dollars per Sqft