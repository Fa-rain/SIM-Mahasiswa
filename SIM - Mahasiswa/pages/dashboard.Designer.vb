<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class dashboard
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dashboard))
        Me.panelContent = New System.Windows.Forms.Panel()
        Me.SuspendLayout()
        '
        'panelContent
        '
        Me.panelContent.BackColor = System.Drawing.Color.WhiteSmoke
        Me.panelContent.Location = New System.Drawing.Point(132, 16)
        Me.panelContent.Name = "panelContent"
        Me.panelContent.Size = New System.Drawing.Size(780, 597)
        Me.panelContent.TabIndex = 15
        '
        'dashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(924, 631)
        Me.Controls.Add(Me.panelContent)
        Me.Name = "dashboard"
        Me.Text = "dashboard"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents panelContent As Panel
End Class
