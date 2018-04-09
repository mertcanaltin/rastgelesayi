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
        Me.SayiTextBox = New System.Windows.Forms.TextBox()
        Me.Yontem1Button = New System.Windows.Forms.Button()
        Me.Yontem2Button = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'SayiTextBox
        '
        Me.SayiTextBox.Location = New System.Drawing.Point(12, 21)
        Me.SayiTextBox.Name = "SayiTextBox"
        Me.SayiTextBox.Size = New System.Drawing.Size(162, 20)
        Me.SayiTextBox.TabIndex = 0
        '
        'Yontem1Button
        '
        Me.Yontem1Button.Location = New System.Drawing.Point(12, 57)
        Me.Yontem1Button.Name = "Yontem1Button"
        Me.Yontem1Button.Size = New System.Drawing.Size(162, 47)
        Me.Yontem1Button.TabIndex = 1
        Me.Yontem1Button.Text = "Rastgele Sayı Üret Yöntem 1"
        Me.Yontem1Button.UseVisualStyleBackColor = True
        '
        'Yontem2Button
        '
        Me.Yontem2Button.Location = New System.Drawing.Point(14, 107)
        Me.Yontem2Button.Name = "Yontem2Button"
        Me.Yontem2Button.Size = New System.Drawing.Size(162, 47)
        Me.Yontem2Button.TabIndex = 2
        Me.Yontem2Button.Text = "Rastgele Sayı Üret Yöntem 2"
        Me.Yontem2Button.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(190, 261)
        Me.Controls.Add(Me.Yontem2Button)
        Me.Controls.Add(Me.Yontem1Button)
        Me.Controls.Add(Me.SayiTextBox)
        Me.Name = "Form1"
        Me.Text = "Rastgele"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SayiTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Yontem1Button As System.Windows.Forms.Button
    Friend WithEvents Yontem2Button As System.Windows.Forms.Button

End Class
