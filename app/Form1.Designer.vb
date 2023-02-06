<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.lstFlavors = New System.Windows.Forms.ListBox()
        Me.picImage = New System.Windows.Forms.PictureBox()
        CType(Me.picImage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lstFlavors
        '
        Me.lstFlavors.FormattingEnabled = True
        Me.lstFlavors.Items.AddRange(New Object() {"Vanilla", "Chocolate", "Strawberry", "Rocky Road", "Oreo"})
        Me.lstFlavors.Location = New System.Drawing.Point(109, 146)
        Me.lstFlavors.Name = "lstFlavors"
        Me.lstFlavors.Size = New System.Drawing.Size(120, 134)
        Me.lstFlavors.TabIndex = 0
        '
        'picImage
        '
        Me.picImage.Location = New System.Drawing.Point(316, 146)
        Me.picImage.Name = "picImage"
        Me.picImage.Size = New System.Drawing.Size(182, 134)
        Me.picImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picImage.TabIndex = 1
        Me.picImage.TabStop = False
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.picImage)
        Me.Controls.Add(Me.lstFlavors)
        Me.Name = "frmMain"
        Me.Text = "Ice Cream Haven!"
        CType(Me.picImage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lstFlavors As ListBox
    Friend WithEvents picImage As PictureBox
End Class
