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
        Me.FileClinertempcheckbox = New System.Windows.Forms.CheckBox()
        Me.FileClinerprefetchcheckbox = New System.Windows.Forms.CheckBox()
        Me.FileClinerjavacachecheckbox = New System.Windows.Forms.CheckBox()
        Me.FileClinerrecyclebincheckbox = New System.Windows.Forms.CheckBox()
        Me.FileClinerGuna2GradientButton2 = New System.Windows.Forms.Button()
        Me.FileClinerLogsListbox = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'FileClinertempcheckbox
        '
        Me.FileClinertempcheckbox.AutoSize = True
        Me.FileClinertempcheckbox.Location = New System.Drawing.Point(11, 158)
        Me.FileClinertempcheckbox.Name = "FileClinertempcheckbox"
        Me.FileClinertempcheckbox.Size = New System.Drawing.Size(53, 17)
        Me.FileClinertempcheckbox.TabIndex = 0
        Me.FileClinertempcheckbox.Text = "Temp"
        Me.FileClinertempcheckbox.UseVisualStyleBackColor = True
        '
        'FileClinerprefetchcheckbox
        '
        Me.FileClinerprefetchcheckbox.AutoSize = True
        Me.FileClinerprefetchcheckbox.Location = New System.Drawing.Point(98, 158)
        Me.FileClinerprefetchcheckbox.Name = "FileClinerprefetchcheckbox"
        Me.FileClinerprefetchcheckbox.Size = New System.Drawing.Size(66, 17)
        Me.FileClinerprefetchcheckbox.TabIndex = 1
        Me.FileClinerprefetchcheckbox.Text = "Prefetch"
        Me.FileClinerprefetchcheckbox.UseVisualStyleBackColor = True
        '
        'FileClinerjavacachecheckbox
        '
        Me.FileClinerjavacachecheckbox.AutoSize = True
        Me.FileClinerjavacachecheckbox.Location = New System.Drawing.Point(185, 158)
        Me.FileClinerjavacachecheckbox.Name = "FileClinerjavacachecheckbox"
        Me.FileClinerjavacachecheckbox.Size = New System.Drawing.Size(83, 17)
        Me.FileClinerjavacachecheckbox.TabIndex = 2
        Me.FileClinerjavacachecheckbox.Text = "Java Cache"
        Me.FileClinerjavacachecheckbox.UseVisualStyleBackColor = True
        '
        'FileClinerrecyclebincheckbox
        '
        Me.FileClinerrecyclebincheckbox.AutoSize = True
        Me.FileClinerrecyclebincheckbox.Location = New System.Drawing.Point(283, 158)
        Me.FileClinerrecyclebincheckbox.Name = "FileClinerrecyclebincheckbox"
        Me.FileClinerrecyclebincheckbox.Size = New System.Drawing.Size(83, 17)
        Me.FileClinerrecyclebincheckbox.TabIndex = 3
        Me.FileClinerrecyclebincheckbox.Text = "Recycle Bin"
        Me.FileClinerrecyclebincheckbox.UseVisualStyleBackColor = True
        '
        'FileClinerGuna2GradientButton2
        '
        Me.FileClinerGuna2GradientButton2.Location = New System.Drawing.Point(116, 186)
        Me.FileClinerGuna2GradientButton2.Name = "FileClinerGuna2GradientButton2"
        Me.FileClinerGuna2GradientButton2.Size = New System.Drawing.Size(149, 23)
        Me.FileClinerGuna2GradientButton2.TabIndex = 4
        Me.FileClinerGuna2GradientButton2.Text = "Clean Files"
        Me.FileClinerGuna2GradientButton2.UseVisualStyleBackColor = True
        '
        'FileClinerLogsListbox
        '
        Me.FileClinerLogsListbox.FormattingEnabled = True
        Me.FileClinerLogsListbox.Location = New System.Drawing.Point(11, 12)
        Me.FileClinerLogsListbox.Name = "FileClinerLogsListbox"
        Me.FileClinerLogsListbox.Size = New System.Drawing.Size(355, 134)
        Me.FileClinerLogsListbox.TabIndex = 12
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(377, 221)
        Me.Controls.Add(Me.FileClinerLogsListbox)
        Me.Controls.Add(Me.FileClinerGuna2GradientButton2)
        Me.Controls.Add(Me.FileClinerrecyclebincheckbox)
        Me.Controls.Add(Me.FileClinerjavacachecheckbox)
        Me.Controls.Add(Me.FileClinerprefetchcheckbox)
        Me.Controls.Add(Me.FileClinertempcheckbox)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents FileClinertempcheckbox As CheckBox
    Friend WithEvents FileClinerprefetchcheckbox As CheckBox
    Friend WithEvents FileClinerjavacachecheckbox As CheckBox
    Friend WithEvents FileClinerrecyclebincheckbox As CheckBox
    Friend WithEvents FileClinerGuna2GradientButton2 As Button
    Friend WithEvents FileClinerLogsListbox As ListBox
End Class
