<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.radioBob = New System.Windows.Forms.RadioButton()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.radioSam = New System.Windows.Forms.RadioButton()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtSales = New System.Windows.Forms.TextBox()
        Me.txtCost = New System.Windows.Forms.TextBox()
        Me.txtProfit = New System.Windows.Forms.TextBox()
        Me.txtProfitPct = New System.Windows.Forms.TextBox()
        Me.txtTerritory = New System.Windows.Forms.TextBox()
        Me.lblInvalid = New System.Windows.Forms.Label()
        Me.txtBonusOne = New System.Windows.Forms.TextBox()
        Me.txtBonusTwo = New System.Windows.Forms.TextBox()
        Me.txtBonusThree = New System.Windows.Forms.TextBox()
        Me.txtBonusTotal = New System.Windows.Forms.TextBox()
        Me.txtBonusCounter = New System.Windows.Forms.TextBox()
        Me.picBob = New System.Windows.Forms.PictureBox()
        Me.picSam = New System.Windows.Forms.PictureBox()
        CType(Me.picBob, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picSam, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(200, 68)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(284, 39)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Calculate Bonus"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(61, 156)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(33, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Sales"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(61, 208)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(28, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Cost"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(61, 260)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(31, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Profit"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(61, 312)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(42, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "% Profit"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(61, 364)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(74, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Sales Territory"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(364, 156)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(53, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Bonus #1"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(364, 208)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(53, 13)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Bonus #2"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(364, 260)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(53, 13)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Bonus #3"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(328, 312)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(89, 13)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "Total All Bonuses"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(297, 361)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(120, 13)
        Me.Label11.TabIndex = 10
        Me.Label11.Text = "Running Bonus Counter"
        '
        'btnCalculate
        '
        Me.btnCalculate.BackColor = System.Drawing.Color.Moccasin
        Me.btnCalculate.Location = New System.Drawing.Point(591, 124)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(102, 23)
        Me.btnCalculate.TabIndex = 3
        Me.btnCalculate.Text = "Calculate Bonus"
        Me.btnCalculate.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.Moccasin
        Me.btnClear.Location = New System.Drawing.Point(591, 169)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(102, 23)
        Me.btnClear.TabIndex = 4
        Me.btnClear.Text = "Clear Data"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.Moccasin
        Me.btnExit.Location = New System.Drawing.Point(591, 211)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(102, 23)
        Me.btnExit.TabIndex = 5
        Me.btnExit.Text = "Exit Program"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'radioBob
        '
        Me.radioBob.AutoSize = True
        Me.radioBob.Location = New System.Drawing.Point(149, 453)
        Me.radioBob.Name = "radioBob"
        Me.radioBob.Size = New System.Drawing.Size(14, 13)
        Me.radioBob.TabIndex = 14
        Me.radioBob.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(72, 453)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(66, 13)
        Me.Label12.TabIndex = 15
        Me.Label12.Text = "Sponge Bob"
        '
        'radioSam
        '
        Me.radioSam.AutoSize = True
        Me.radioSam.Location = New System.Drawing.Point(149, 490)
        Me.radioSam.Name = "radioSam"
        Me.radioSam.Size = New System.Drawing.Size(14, 13)
        Me.radioSam.TabIndex = 17
        Me.radioSam.UseVisualStyleBackColor = True
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(64, 490)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(74, 13)
        Me.Label13.TabIndex = 18
        Me.Label13.Text = "Yosemite Sam"
        '
        'txtSales
        '
        Me.txtSales.Location = New System.Drawing.Point(152, 156)
        Me.txtSales.Name = "txtSales"
        Me.txtSales.Size = New System.Drawing.Size(100, 20)
        Me.txtSales.TabIndex = 0
        '
        'txtCost
        '
        Me.txtCost.Location = New System.Drawing.Point(152, 208)
        Me.txtCost.Name = "txtCost"
        Me.txtCost.Size = New System.Drawing.Size(100, 20)
        Me.txtCost.TabIndex = 1
        '
        'txtProfit
        '
        Me.txtProfit.BackColor = System.Drawing.Color.PapayaWhip
        Me.txtProfit.Location = New System.Drawing.Point(149, 260)
        Me.txtProfit.Name = "txtProfit"
        Me.txtProfit.Size = New System.Drawing.Size(100, 20)
        Me.txtProfit.TabIndex = 21
        Me.txtProfit.TabStop = False
        '
        'txtProfitPct
        '
        Me.txtProfitPct.BackColor = System.Drawing.Color.PapayaWhip
        Me.txtProfitPct.Location = New System.Drawing.Point(152, 312)
        Me.txtProfitPct.Name = "txtProfitPct"
        Me.txtProfitPct.Size = New System.Drawing.Size(53, 20)
        Me.txtProfitPct.TabIndex = 22
        Me.txtProfitPct.TabStop = False
        '
        'txtTerritory
        '
        Me.txtTerritory.Location = New System.Drawing.Point(152, 361)
        Me.txtTerritory.Name = "txtTerritory"
        Me.txtTerritory.Size = New System.Drawing.Size(76, 20)
        Me.txtTerritory.TabIndex = 2
        '
        'lblInvalid
        '
        Me.lblInvalid.AutoSize = True
        Me.lblInvalid.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInvalid.ForeColor = System.Drawing.Color.Red
        Me.lblInvalid.Location = New System.Drawing.Point(88, 400)
        Me.lblInvalid.Name = "lblInvalid"
        Me.lblInvalid.Size = New System.Drawing.Size(117, 16)
        Me.lblInvalid.TabIndex = 24
        Me.lblInvalid.Text = "Invalid Territory"
        Me.lblInvalid.Visible = False
        '
        'txtBonusOne
        '
        Me.txtBonusOne.BackColor = System.Drawing.Color.PapayaWhip
        Me.txtBonusOne.Location = New System.Drawing.Point(445, 156)
        Me.txtBonusOne.Name = "txtBonusOne"
        Me.txtBonusOne.ReadOnly = True
        Me.txtBonusOne.Size = New System.Drawing.Size(100, 20)
        Me.txtBonusOne.TabIndex = 25
        Me.txtBonusOne.TabStop = False
        '
        'txtBonusTwo
        '
        Me.txtBonusTwo.BackColor = System.Drawing.Color.PapayaWhip
        Me.txtBonusTwo.Location = New System.Drawing.Point(445, 208)
        Me.txtBonusTwo.Name = "txtBonusTwo"
        Me.txtBonusTwo.ReadOnly = True
        Me.txtBonusTwo.Size = New System.Drawing.Size(100, 20)
        Me.txtBonusTwo.TabIndex = 26
        Me.txtBonusTwo.TabStop = False
        '
        'txtBonusThree
        '
        Me.txtBonusThree.BackColor = System.Drawing.Color.PapayaWhip
        Me.txtBonusThree.Location = New System.Drawing.Point(445, 260)
        Me.txtBonusThree.Name = "txtBonusThree"
        Me.txtBonusThree.ReadOnly = True
        Me.txtBonusThree.Size = New System.Drawing.Size(100, 20)
        Me.txtBonusThree.TabIndex = 27
        Me.txtBonusThree.TabStop = False
        '
        'txtBonusTotal
        '
        Me.txtBonusTotal.BackColor = System.Drawing.Color.PapayaWhip
        Me.txtBonusTotal.Location = New System.Drawing.Point(445, 312)
        Me.txtBonusTotal.Name = "txtBonusTotal"
        Me.txtBonusTotal.ReadOnly = True
        Me.txtBonusTotal.Size = New System.Drawing.Size(100, 20)
        Me.txtBonusTotal.TabIndex = 28
        Me.txtBonusTotal.TabStop = False
        '
        'txtBonusCounter
        '
        Me.txtBonusCounter.BackColor = System.Drawing.Color.PapayaWhip
        Me.txtBonusCounter.Location = New System.Drawing.Point(445, 364)
        Me.txtBonusCounter.Name = "txtBonusCounter"
        Me.txtBonusCounter.ReadOnly = True
        Me.txtBonusCounter.Size = New System.Drawing.Size(100, 20)
        Me.txtBonusCounter.TabIndex = 29
        Me.txtBonusCounter.TabStop = False
        '
        'picBob
        '
        Me.picBob.Image = CType(resources.GetObject("picBob.Image"), System.Drawing.Image)
        Me.picBob.Location = New System.Drawing.Point(242, 400)
        Me.picBob.Name = "picBob"
        Me.picBob.Size = New System.Drawing.Size(197, 197)
        Me.picBob.TabIndex = 30
        Me.picBob.TabStop = False
        Me.picBob.Visible = False
        '
        'picSam
        '
        Me.picSam.Image = CType(resources.GetObject("picSam.Image"), System.Drawing.Image)
        Me.picSam.Location = New System.Drawing.Point(476, 400)
        Me.picSam.Name = "picSam"
        Me.picSam.Size = New System.Drawing.Size(184, 197)
        Me.picSam.TabIndex = 31
        Me.picSam.TabStop = False
        Me.picSam.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(798, 644)
        Me.Controls.Add(Me.picSam)
        Me.Controls.Add(Me.picBob)
        Me.Controls.Add(Me.txtBonusCounter)
        Me.Controls.Add(Me.txtBonusTotal)
        Me.Controls.Add(Me.txtBonusThree)
        Me.Controls.Add(Me.txtBonusTwo)
        Me.Controls.Add(Me.txtBonusOne)
        Me.Controls.Add(Me.lblInvalid)
        Me.Controls.Add(Me.txtTerritory)
        Me.Controls.Add(Me.txtProfitPct)
        Me.Controls.Add(Me.txtProfit)
        Me.Controls.Add(Me.txtCost)
        Me.Controls.Add(Me.txtSales)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.radioSam)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.radioBob)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.picBob, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picSam, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents radioBob As RadioButton
    Friend WithEvents Label12 As Label
    Friend WithEvents radioSam As RadioButton
    Friend WithEvents Label13 As Label
    Friend WithEvents txtSales As TextBox
    Friend WithEvents txtCost As TextBox
    Friend WithEvents txtProfit As TextBox
    Friend WithEvents txtProfitPct As TextBox
    Friend WithEvents txtTerritory As TextBox
    Friend WithEvents lblInvalid As Label
    Friend WithEvents txtBonusOne As TextBox
    Friend WithEvents txtBonusTwo As TextBox
    Friend WithEvents txtBonusThree As TextBox
    Friend WithEvents txtBonusTotal As TextBox
    Friend WithEvents txtBonusCounter As TextBox
    Friend WithEvents picBob As PictureBox
    Friend WithEvents picSam As PictureBox
End Class
