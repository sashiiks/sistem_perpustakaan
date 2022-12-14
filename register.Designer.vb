<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class register
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
        Me.Btnregis = New System.Windows.Forms.Button()
        Me.TextBoxPass = New System.Windows.Forms.TextBox()
        Me.TextBoxUsername = New System.Windows.Forms.TextBox()
        Me.LblPass = New System.Windows.Forms.Label()
        Me.LblUsername = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Btnregis
        '
        Me.Btnregis.Location = New System.Drawing.Point(402, 192)
        Me.Btnregis.Name = "Btnregis"
        Me.Btnregis.Size = New System.Drawing.Size(75, 23)
        Me.Btnregis.TabIndex = 9
        Me.Btnregis.Text = "register"
        Me.Btnregis.UseVisualStyleBackColor = True
        '
        'TextBoxPass
        '
        Me.TextBoxPass.Location = New System.Drawing.Point(244, 105)
        Me.TextBoxPass.Name = "TextBoxPass"
        Me.TextBoxPass.Size = New System.Drawing.Size(165, 20)
        Me.TextBoxPass.TabIndex = 8
        '
        'TextBoxUsername
        '
        Me.TextBoxUsername.Location = New System.Drawing.Point(244, 42)
        Me.TextBoxUsername.Name = "TextBoxUsername"
        Me.TextBoxUsername.Size = New System.Drawing.Size(165, 20)
        Me.TextBoxUsername.TabIndex = 7
        '
        'LblPass
        '
        Me.LblPass.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPass.Location = New System.Drawing.Point(42, 101)
        Me.LblPass.Name = "LblPass"
        Me.LblPass.Size = New System.Drawing.Size(74, 24)
        Me.LblPass.TabIndex = 6
        Me.LblPass.Text = "Password"
        '
        'LblUsername
        '
        Me.LblUsername.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblUsername.Location = New System.Drawing.Point(42, 39)
        Me.LblUsername.Name = "LblUsername"
        Me.LblUsername.Size = New System.Drawing.Size(74, 24)
        Me.LblUsername.TabIndex = 5
        Me.LblUsername.Text = "Username"
        '
        'register
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Btnregis)
        Me.Controls.Add(Me.TextBoxPass)
        Me.Controls.Add(Me.TextBoxUsername)
        Me.Controls.Add(Me.LblPass)
        Me.Controls.Add(Me.LblUsername)
        Me.Name = "register"
        Me.Text = "register"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Btnregis As Button
    Friend WithEvents TextBoxPass As TextBox
    Friend WithEvents TextBoxUsername As TextBox
    Friend WithEvents LblPass As Label
    Friend WithEvents LblUsername As Label
End Class
