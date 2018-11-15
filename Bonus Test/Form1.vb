Public Class Form1

    Dim RunningBonus As Integer


    Private Sub radioBob_Click(sender As Object, e As EventArgs) Handles radioBob.Click

        picSam.Visible = False

        Dim Count As Integer = 1
        Do While Count <= 20
            If picBob.Visible = True Then
                picBob.Visible = False
            Else
                picBob.Visible = True
            End If
            Me.Refresh()
            System.Threading.Thread.Sleep(100)
            Count = Count + 1
        Loop
        picBob.Visible = True

    End Sub

    Private Sub radioSam_Click(sender As Object, e As EventArgs) Handles radioSam.Click

        picBob.Visible = False

        Dim Count As Integer = 1
        Do While Count <= 20
            If picSam.Visible = True Then
                picSam.Visible = False
            Else
                picSam.Visible = True
            End If
            Me.Refresh()
            System.Threading.Thread.Sleep(100)
            Count = Count + 1
        Loop
        picSam.Visible = True

    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click

        ' variables

        Dim Sales As Integer
        Dim Cost As Integer
        Dim Profit As Integer
        Dim ProfitPct As Integer
        Dim BonusOne As Integer
        Dim BonusTwo As Integer
        Dim BonusThree As Integer
        Dim TotalBonus As Integer

        ' Input

        Integer.TryParse(txtSales.Text, Sales)
        Integer.TryParse(txtCost.Text, Cost)


        Profit = Sales - Cost
        ProfitPct = (Profit / Sales) * 100

        ' Bonus One Below

        If Sales > 1000000 And txtTerritory.Text = "Midwest" Then
            BonusOne = Sales * 0.02
        Else
            BonusOne = Sales * 0.01

        End If

        If Sales < 1000000 Then
            BonusOne = 0
        End If


        ' Bonus Two Below

        If Profit > 200000 Then
            BonusTwo = (Profit - 200000) * 0.1
        End If

        ' Bonus Three Below

        If ProfitPct >= 20 And ProfitPct <= 30 Then
            BonusThree = Profit * 0.01
        ElseIf Profitpct > 30 Then
            BonusThree = Profit * 0.03
        End If

        ' Total All Bonuses

        TotalBonus = BonusOne + BonusTwo + BonusThree

        ' Running Total Bonus

        RunningBonus = RunningBonus + TotalBonus

        ' Invaild Region below

        If txtTerritory.Text = "Midwest" Or
                txtTerritory.Text = "East" Or
                txtTerritory.Text = "South" Then
            lblInvalid.Visible = False
        Else
            lblInvalid.Visible = True
        End If

        If lblInvalid.Visible = True Then
            BonusOne = 0
            BonusTwo = 0
            BonusThree = 0
            TotalBonus = 0
            RunningBonus = 0

        End If


        ' Output

        txtBonusOne.Text = Convert.ToString(BonusOne)
        txtBonusTwo.Text = Convert.ToString(BonusTwo)
        txtBonusThree.Text = Convert.ToString(BonusThree)
        txtBonusTotal.Text = Convert.ToString(TotalBonus)
        txtBonusCounter.Text = Convert.ToString(RunningBonus)
        txtProfitPct.Text = Convert.ToString(ProfitPct)
        txtProfit.Text = Convert.ToString(Profit)

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtBonusOne.Text = String.Empty
        txtBonusTwo.Text = String.Empty
        txtBonusThree.Text = String.Empty
        txtCost.Text = String.Empty
        txtProfit.Text = String.Empty
        txtProfitPct.Text = String.Empty
        txtSales.Text = String.Empty
        txtTerritory.Text = String.Empty
        txtBonusTotal.Text = String.Empty
        picBob.Visible = False
        picSam.Visible = False
        radioBob.Checked = False
        radioSam.Checked = False
        lblInvalid.Visible = False



    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()

    End Sub
End Class
