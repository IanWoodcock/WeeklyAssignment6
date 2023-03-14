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
        Me.picSpeed = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.btnEnterSpeed = New System.Windows.Forms.Button()
        Me.lblAveIntSpeed = New System.Windows.Forms.Label()
        Me.lblAveSpeed = New System.Windows.Forms.Label()
        Me.lstSpeeds = New System.Windows.Forms.ListBox()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        CType(Me.picSpeed, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picSpeed
        '
        Me.picSpeed.Image = CType(resources.GetObject("picSpeed.Image"), System.Drawing.Image)
        Me.picSpeed.Location = New System.Drawing.Point(-1195, -8)
        Me.picSpeed.Name = "picSpeed"
        Me.picSpeed.Size = New System.Drawing.Size(796, 531)
        Me.picSpeed.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picSpeed.TabIndex = 0
        Me.picSpeed.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(-862, -60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 32)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Label1"
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.BackColor = System.Drawing.Color.White
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblTitle.Location = New System.Drawing.Point(370, 36)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(319, 32)
        Me.lblTitle.TabIndex = 2
        Me.lblTitle.Text = "Internet Speed Test Survey"
        '
        'btnEnterSpeed
        '
        Me.btnEnterSpeed.BackColor = System.Drawing.Color.DarkKhaki
        Me.btnEnterSpeed.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnEnterSpeed.ForeColor = System.Drawing.Color.Black
        Me.btnEnterSpeed.Location = New System.Drawing.Point(426, 92)
        Me.btnEnterSpeed.Name = "btnEnterSpeed"
        Me.btnEnterSpeed.Size = New System.Drawing.Size(217, 35)
        Me.btnEnterSpeed.TabIndex = 3
        Me.btnEnterSpeed.Text = "Enter Internet Speed"
        Me.btnEnterSpeed.UseVisualStyleBackColor = False
        '
        'lblAveIntSpeed
        '
        Me.lblAveIntSpeed.AutoSize = True
        Me.lblAveIntSpeed.BackColor = System.Drawing.Color.White
        Me.lblAveIntSpeed.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblAveIntSpeed.Location = New System.Drawing.Point(462, 475)
        Me.lblAveIntSpeed.Name = "lblAveIntSpeed"
        Me.lblAveIntSpeed.Size = New System.Drawing.Size(227, 25)
        Me.lblAveIntSpeed.TabIndex = 4
        Me.lblAveIntSpeed.Text = "Average Internet Speed:"
        '
        'lblAveSpeed
        '
        Me.lblAveSpeed.AutoSize = True
        Me.lblAveSpeed.BackColor = System.Drawing.Color.White
        Me.lblAveSpeed.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblAveSpeed.Location = New System.Drawing.Point(695, 475)
        Me.lblAveSpeed.Name = "lblAveSpeed"
        Me.lblAveSpeed.Size = New System.Drawing.Size(105, 25)
        Me.lblAveSpeed.TabIndex = 5
        Me.lblAveSpeed.Text = "0.00 Mbps"
        '
        'lstSpeeds
        '
        Me.lstSpeeds.FormattingEnabled = True
        Me.lstSpeeds.ItemHeight = 15
        Me.lstSpeeds.Location = New System.Drawing.Point(723, 73)
        Me.lstSpeeds.Name = "lstSpeeds"
        Me.lstSpeeds.ScrollAlwaysVisible = True
        Me.lstSpeeds.SelectionMode = System.Windows.Forms.SelectionMode.None
        Me.lstSpeeds.Size = New System.Drawing.Size(86, 199)
        Me.lstSpeeds.TabIndex = 6
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(832, 556)
        Me.Controls.Add(Me.lstSpeeds)
        Me.Controls.Add(Me.lblAveSpeed)
        Me.Controls.Add(Me.lblAveIntSpeed)
        Me.Controls.Add(Me.btnEnterSpeed)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.picSpeed)
        Me.Name = "Form1"
        Me.Text = "Internet Speed Test Survey for Home Users"
        CType(Me.picSpeed, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picSpeed As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lblTitle As Label
    Friend WithEvents btnEnterSpeed As Button
    Friend WithEvents lblAveIntSpeed As Label
    Friend WithEvents lblAveSpeed As Label
    Friend WithEvents lstSpeeds As ListBox
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
End Class
