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
        Me.lblIntructions = New System.Windows.Forms.Label()
        Me.lblLengthX = New System.Windows.Forms.Label()
        Me.lblLengthY = New System.Windows.Forms.Label()
        Me.lblTotalNeeded = New System.Windows.Forms.Label()
        Me.lblResult = New System.Windows.Forms.Label()
        Me.txtLengthX = New System.Windows.Forms.TextBox()
        Me.txtLengthY = New System.Windows.Forms.TextBox()
        Me.pic1 = New System.Windows.Forms.PictureBox()
        Me.btnCalculate = New System.Windows.Forms.Button()
        CType(Me.pic1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblIntructions
        '
        Me.lblIntructions.Location = New System.Drawing.Point(85, 20)
        Me.lblIntructions.Name = "lblIntructions"
        Me.lblIntructions.Size = New System.Drawing.Size(256, 40)
        Me.lblIntructions.TabIndex = 0
        Me.lblIntructions.Text = "Enter the length of side  x and y of your room to calculate the number of square " & _
    "feet of carpet need."
        '
        'lblLengthX
        '
        Me.lblLengthX.AutoSize = True
        Me.lblLengthX.Location = New System.Drawing.Point(97, 81)
        Me.lblLengthX.Name = "lblLengthX"
        Me.lblLengthX.Size = New System.Drawing.Size(60, 13)
        Me.lblLengthX.TabIndex = 1
        Me.lblLengthX.Text = "Length of x"
        '
        'lblLengthY
        '
        Me.lblLengthY.AutoSize = True
        Me.lblLengthY.Location = New System.Drawing.Point(97, 139)
        Me.lblLengthY.Name = "lblLengthY"
        Me.lblLengthY.Size = New System.Drawing.Size(60, 13)
        Me.lblLengthY.TabIndex = 2
        Me.lblLengthY.Text = "Length of y"
        '
        'lblTotalNeeded
        '
        Me.lblTotalNeeded.AutoSize = True
        Me.lblTotalNeeded.Location = New System.Drawing.Point(85, 259)
        Me.lblTotalNeeded.Name = "lblTotalNeeded"
        Me.lblTotalNeeded.Size = New System.Drawing.Size(72, 13)
        Me.lblTotalNeeded.TabIndex = 3
        Me.lblTotalNeeded.Text = "Total Needed"
        '
        'lblResult
        '
        Me.lblResult.BackColor = System.Drawing.Color.White
        Me.lblResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblResult.Location = New System.Drawing.Point(163, 258)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(100, 21)
        Me.lblResult.TabIndex = 4
        '
        'txtLengthX
        '
        Me.txtLengthX.Location = New System.Drawing.Point(160, 81)
        Me.txtLengthX.Name = "txtLengthX"
        Me.txtLengthX.Size = New System.Drawing.Size(100, 20)
        Me.txtLengthX.TabIndex = 5
        '
        'txtLengthY
        '
        Me.txtLengthY.Location = New System.Drawing.Point(160, 132)
        Me.txtLengthY.Name = "txtLengthY"
        Me.txtLengthY.Size = New System.Drawing.Size(100, 20)
        Me.txtLengthY.TabIndex = 6
        '
        'pic1
        '
        Me.pic1.Image = CType(resources.GetObject("pic1.Image"), System.Drawing.Image)
        Me.pic1.Location = New System.Drawing.Point(88, 301)
        Me.pic1.Name = "pic1"
        Me.pic1.Size = New System.Drawing.Size(242, 142)
        Me.pic1.TabIndex = 7
        Me.pic1.TabStop = False
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(160, 186)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(75, 23)
        Me.btnCalculate.TabIndex = 8
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(415, 468)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.pic1)
        Me.Controls.Add(Me.txtLengthY)
        Me.Controls.Add(Me.txtLengthX)
        Me.Controls.Add(Me.lblResult)
        Me.Controls.Add(Me.lblTotalNeeded)
        Me.Controls.Add(Me.lblLengthY)
        Me.Controls.Add(Me.lblLengthX)
        Me.Controls.Add(Me.lblIntructions)
        Me.Name = "Form1"
        Me.Text = "Carpet Amount"
        CType(Me.pic1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblIntructions As System.Windows.Forms.Label
    Friend WithEvents lblLengthX As System.Windows.Forms.Label
    Friend WithEvents lblLengthY As System.Windows.Forms.Label
    Friend WithEvents lblTotalNeeded As System.Windows.Forms.Label
    Friend WithEvents lblResult As System.Windows.Forms.Label
    Friend WithEvents txtLengthX As System.Windows.Forms.TextBox
    Friend WithEvents txtLengthY As System.Windows.Forms.TextBox
    Friend WithEvents pic1 As System.Windows.Forms.PictureBox
    Friend WithEvents btnCalculate As System.Windows.Forms.Button

End Class
