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
        Me.btn_BrowseFolder = New System.Windows.Forms.Button()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbo_Extensions = New System.Windows.Forms.ComboBox()
        Me.cbo_lbl_Extensions = New System.Windows.Forms.Label()
        Me.cbo_DPI = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btn_BrowseFolder
        '
        Me.btn_BrowseFolder.Location = New System.Drawing.Point(26, 135)
        Me.btn_BrowseFolder.Name = "btn_BrowseFolder"
        Me.btn_BrowseFolder.Size = New System.Drawing.Size(75, 26)
        Me.btn_BrowseFolder.TabIndex = 0
        Me.btn_BrowseFolder.Text = "Browse..."
        Me.btn_BrowseFolder.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(127, 140)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(20, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "..."
        '
        'cbo_Extensions
        '
        Me.cbo_Extensions.FormattingEnabled = True
        Me.cbo_Extensions.Items.AddRange(New Object() {".jpg", ".png", ".tiff"})
        Me.cbo_Extensions.Location = New System.Drawing.Point(26, 41)
        Me.cbo_Extensions.Name = "cbo_Extensions"
        Me.cbo_Extensions.Size = New System.Drawing.Size(121, 24)
        Me.cbo_Extensions.TabIndex = 2
        '
        'cbo_lbl_Extensions
        '
        Me.cbo_lbl_Extensions.AutoSize = True
        Me.cbo_lbl_Extensions.Location = New System.Drawing.Point(23, 21)
        Me.cbo_lbl_Extensions.Name = "cbo_lbl_Extensions"
        Me.cbo_lbl_Extensions.Size = New System.Drawing.Size(160, 17)
        Me.cbo_lbl_Extensions.TabIndex = 3
        Me.cbo_lbl_Extensions.Text = "Select Picture Extension"
        '
        'cbo_DPI
        '
        Me.cbo_DPI.FormattingEnabled = True
        Me.cbo_DPI.Items.AddRange(New Object() {"Same as File", "72", "96", "150", "300", "2540", "4000"})
        Me.cbo_DPI.Location = New System.Drawing.Point(26, 94)
        Me.cbo_DPI.Name = "cbo_DPI"
        Me.cbo_DPI.Size = New System.Drawing.Size(121, 24)
        Me.cbo_DPI.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(23, 74)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(151, 17)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Set DPI for new image."
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cbo_DPI)
        Me.Controls.Add(Me.cbo_lbl_Extensions)
        Me.Controls.Add(Me.cbo_Extensions)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_BrowseFolder)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Revert-ScanSpeeder"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_BrowseFolder As Button
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
    Friend WithEvents Label1 As Label
    Friend WithEvents cbo_Extensions As ComboBox
    Friend WithEvents cbo_lbl_Extensions As Label
    Friend WithEvents cbo_DPI As ComboBox
    Friend WithEvents Label2 As Label
End Class
