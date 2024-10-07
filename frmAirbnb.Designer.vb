<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmAirbnb
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        lblHeading = New Label()
        lblNumberOfNight = New Label()
        txtNumberOfNight = New TextBox()
        btnDisplayCost = New Button()
        btnClear = New Button()
        btnExit = New Button()
        lblPricePerNight = New Label()
        picAirbnb = New PictureBox()
        lblTotalCost = New Label()
        lblCost = New Label()
        CType(picAirbnb, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblHeading
        ' 
        lblHeading.AutoSize = True
        lblHeading.Font = New Font("Tahoma", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblHeading.Location = New Point(475, 29)
        lblHeading.Name = "lblHeading"
        lblHeading.Size = New Size(194, 29)
        lblHeading.TabIndex = 0
        lblHeading.Text = "Orlando AirBnB"
        ' 
        ' lblNumberOfNight
        ' 
        lblNumberOfNight.AutoSize = True
        lblNumberOfNight.Font = New Font("Tahoma", 9.75F)
        lblNumberOfNight.Location = New Point(475, 131)
        lblNumberOfNight.Name = "lblNumberOfNight"
        lblNumberOfNight.Size = New Size(113, 16)
        lblNumberOfNight.TabIndex = 1
        lblNumberOfNight.Text = "Number Of Nights:" & vbCrLf
        ' 
        ' txtNumberOfNight
        ' 
        txtNumberOfNight.Font = New Font("Tahoma", 9.75F)
        txtNumberOfNight.Location = New Point(638, 124)
        txtNumberOfNight.Name = "txtNumberOfNight"
        txtNumberOfNight.Size = New Size(40, 23)
        txtNumberOfNight.TabIndex = 2
        txtNumberOfNight.TextAlign = HorizontalAlignment.Center
        ' 
        ' btnDisplayCost
        ' 
        btnDisplayCost.BackColor = Color.WhiteSmoke
        btnDisplayCost.Font = New Font("Tahoma", 9F)
        btnDisplayCost.Location = New Point(401, 221)
        btnDisplayCost.Name = "btnDisplayCost"
        btnDisplayCost.Size = New Size(87, 26)
        btnDisplayCost.TabIndex = 3
        btnDisplayCost.Text = "Display Cost"
        btnDisplayCost.UseVisualStyleBackColor = False
        ' 
        ' btnClear
        ' 
        btnClear.BackColor = Color.WhiteSmoke
        btnClear.Font = New Font("Tahoma", 9F)
        btnClear.Location = New Point(519, 221)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(87, 26)
        btnClear.TabIndex = 4
        btnClear.Text = "Clear"
        btnClear.UseVisualStyleBackColor = False
        ' 
        ' btnExit
        ' 
        btnExit.BackColor = Color.WhiteSmoke
        btnExit.Font = New Font("Tahoma", 9F)
        btnExit.Location = New Point(638, 221)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(87, 26)
        btnExit.TabIndex = 5
        btnExit.Text = "Exit"
        btnExit.UseVisualStyleBackColor = False
        ' 
        ' lblPricePerNight
        ' 
        lblPricePerNight.AutoSize = True
        lblPricePerNight.Font = New Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblPricePerNight.Location = New Point(494, 73)
        lblPricePerNight.Name = "lblPricePerNight"
        lblPricePerNight.Size = New Size(46, 16)
        lblPricePerNight.TabIndex = 6
        lblPricePerNight.Text = "$X.XX"
        ' 
        ' picAirbnb
        ' 
        picAirbnb.BackColor = Color.FloralWhite
        picAirbnb.Dock = DockStyle.Left
        picAirbnb.Image = My.Resources.Resources.Orlando
        picAirbnb.Location = New Point(0, 0)
        picAirbnb.Name = "picAirbnb"
        picAirbnb.Size = New Size(395, 450)
        picAirbnb.SizeMode = PictureBoxSizeMode.StretchImage
        picAirbnb.TabIndex = 7
        picAirbnb.TabStop = False
        ' 
        ' lblTotalCost
        ' 
        lblTotalCost.AutoSize = True
        lblTotalCost.Font = New Font("Tahoma", 9.75F)
        lblTotalCost.Location = New Point(475, 180)
        lblTotalCost.Name = "lblTotalCost"
        lblTotalCost.Size = New Size(81, 16)
        lblTotalCost.TabIndex = 8
        lblTotalCost.Text = "Cost of Stay:"
        ' 
        ' lblCost
        ' 
        lblCost.AutoSize = True
        lblCost.Font = New Font("Tahoma", 9.75F)
        lblCost.Location = New Point(638, 180)
        lblCost.Name = "lblCost"
        lblCost.Size = New Size(32, 16)
        lblCost.TabIndex = 9
        lblCost.Text = "Cost"
        ' 
        ' frmAirbnb
        ' 
        AcceptButton = btnDisplayCost
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.DarkKhaki
        CancelButton = btnClear
        ClientSize = New Size(800, 450)
        Controls.Add(lblCost)
        Controls.Add(lblTotalCost)
        Controls.Add(picAirbnb)
        Controls.Add(lblPricePerNight)
        Controls.Add(btnExit)
        Controls.Add(btnClear)
        Controls.Add(btnDisplayCost)
        Controls.Add(txtNumberOfNight)
        Controls.Add(lblNumberOfNight)
        Controls.Add(lblHeading)
        Name = "frmAirbnb"
        Text = "AirBnB Reservation"
        CType(picAirbnb, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblHeading As Label
    Friend WithEvents lblNumberOfNight As Label
    Friend WithEvents txtNumberOfNight As TextBox
    Friend WithEvents btnDisplayCost As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lblPricePerNight As Label
    Friend WithEvents picAirbnb As PictureBox
    Friend WithEvents lblTotalCost As Label
    Friend WithEvents lblCost As Label

End Class
