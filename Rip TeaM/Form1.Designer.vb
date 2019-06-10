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
        Me.user = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.pass = New System.Windows.Forms.TextBox()
        Me.target = New System.Windows.Forms.TextBox()
        Me.THREADZ = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.COUNTS = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'user
        '
        Me.user.BackColor = System.Drawing.Color.Black
        Me.user.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.user.ForeColor = System.Drawing.Color.White
        Me.user.Location = New System.Drawing.Point(12, 12)
        Me.user.Name = "user"
        Me.user.Size = New System.Drawing.Size(110, 20)
        Me.user.TabIndex = 0
        Me.user.Text = "username"
        Me.user.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Red
        Me.Button1.Location = New System.Drawing.Point(12, 119)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(110, 23)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "Start"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'pass
        '
        Me.pass.BackColor = System.Drawing.Color.Black
        Me.pass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pass.ForeColor = System.Drawing.Color.White
        Me.pass.Location = New System.Drawing.Point(12, 38)
        Me.pass.Name = "pass"
        Me.pass.Size = New System.Drawing.Size(110, 20)
        Me.pass.TabIndex = 11
        Me.pass.Text = "Password"
        Me.pass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.pass.UseSystemPasswordChar = True
        '
        'target
        '
        Me.target.BackColor = System.Drawing.Color.Black
        Me.target.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.target.ForeColor = System.Drawing.Color.White
        Me.target.Location = New System.Drawing.Point(12, 64)
        Me.target.Name = "target"
        Me.target.Size = New System.Drawing.Size(110, 20)
        Me.target.TabIndex = 12
        Me.target.Text = "Target"
        Me.target.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'THREADZ
        '
        Me.THREADZ.BackColor = System.Drawing.Color.Black
        Me.THREADZ.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.THREADZ.ForeColor = System.Drawing.Color.White
        Me.THREADZ.Location = New System.Drawing.Point(12, 90)
        Me.THREADZ.Name = "THREADZ"
        Me.THREADZ.Size = New System.Drawing.Size(59, 20)
        Me.THREADZ.TabIndex = 13
        Me.THREADZ.Text = "120"
        Me.THREADZ.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox5
        '
        Me.TextBox5.BackColor = System.Drawing.Color.Black
        Me.TextBox5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox5.ForeColor = System.Drawing.Color.White
        Me.TextBox5.Location = New System.Drawing.Point(77, 90)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(45, 20)
        Me.TextBox5.TabIndex = 14
        Me.TextBox5.Text = "1.5"
        Me.TextBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'COUNTS
        '
        Me.COUNTS.BackColor = System.Drawing.Color.Black
        Me.COUNTS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.COUNTS.ForeColor = System.Drawing.Color.White
        Me.COUNTS.Location = New System.Drawing.Point(12, 148)
        Me.COUNTS.Name = "COUNTS"
        Me.COUNTS.Size = New System.Drawing.Size(110, 20)
        Me.COUNTS.TabIndex = 15
        Me.COUNTS.Text = "0"
        Me.COUNTS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(131, 178)
        Me.Controls.Add(Me.COUNTS)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.THREADZ)
        Me.Controls.Add(Me.target)
        Me.Controls.Add(Me.pass)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.user)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "KingFHD"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents user As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents pass As System.Windows.Forms.TextBox
    Friend WithEvents target As System.Windows.Forms.TextBox
    Friend WithEvents THREADZ As System.Windows.Forms.TextBox
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents COUNTS As System.Windows.Forms.TextBox
End Class
