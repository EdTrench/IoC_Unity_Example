Namespace View
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class CentreNetworkEmailForm
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
        Me.butCreateEmail = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
            Me.cboNetwork = New System.Windows.Forms.ComboBox()
            Me.SuspendLayout()
            '
            'butCreateEmail
            '
            Me.butCreateEmail.Location = New System.Drawing.Point(12, 68)
            Me.butCreateEmail.Name = "butCreateEmail"
            Me.butCreateEmail.Size = New System.Drawing.Size(356, 38)
            Me.butCreateEmail.TabIndex = 0
            Me.butCreateEmail.Text = "Create Email"
            Me.butCreateEmail.UseVisualStyleBackColor = True
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Location = New System.Drawing.Point(12, 8)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(50, 13)
            Me.Label1.TabIndex = 2
            Me.Label1.Text = "Network:"
            '
            'cboNetwork
            '
            Me.cboNetwork.FormattingEnabled = True
            Me.cboNetwork.Location = New System.Drawing.Point(15, 25)
            Me.cboNetwork.Name = "cboNetwork"
            Me.cboNetwork.Size = New System.Drawing.Size(353, 21)
            Me.cboNetwork.TabIndex = 3
            '
            'CentreNetworkEmailForm
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(380, 120)
            Me.Controls.Add(Me.cboNetwork)
            Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.butCreateEmail)
        Me.Name = "CentreNetworkEmailForm"
        Me.Text = "CentreNetworkEmailForm"
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
        Friend WithEvents butCreateEmail As System.Windows.Forms.Button
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents cboNetwork As System.Windows.Forms.ComboBox
    End Class
End Namespace