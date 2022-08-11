<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.url_box = New System.Windows.Forms.TextBox()
        Me.URL = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.url_display = New System.Windows.Forms.RichTextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.save_data = New System.Windows.Forms.SaveFileDialog()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'url_box
        '
        Me.url_box.Location = New System.Drawing.Point(0, 31)
        Me.url_box.Name = "url_box"
        Me.url_box.Size = New System.Drawing.Size(801, 23)
        Me.url_box.TabIndex = 0
        '
        'URL
        '
        Me.URL.AutoSize = True
        Me.URL.Location = New System.Drawing.Point(4, 9)
        Me.URL.Name = "URL"
        Me.URL.Size = New System.Drawing.Size(85, 15)
        Me.URL.TabIndex = 1
        Me.URL.Text = "Enter Web URL"
        Me.URL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(0, 69)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Get Code"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'url_display
        '
        Me.url_display.Location = New System.Drawing.Point(0, -2)
        Me.url_display.Name = "url_display"
        Me.url_display.Size = New System.Drawing.Size(801, 425)
        Me.url_display.TabIndex = 3
        Me.url_display.Text = ""
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(0, 429)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "New URL"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(605, 433)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(196, 15)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "It Might Take A Bit To Load The Data"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(81, 429)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 6
        Me.Button3.Text = "Save"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.url_display)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.URL)
        Me.Controls.Add(Me.url_box)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(816, 489)
        Me.MinimumSize = New System.Drawing.Size(816, 489)
        Me.Name = "Form1"
        Me.Text = "Web Code Viewer"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents url_box As TextBox
    Friend WithEvents URL As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents url_display As RichTextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents save_data As SaveFileDialog
    Friend WithEvents Button3 As Button
End Class
