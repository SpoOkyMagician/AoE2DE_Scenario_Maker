<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_map
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
        pnl_main = New Panel()
        SuspendLayout()
        ' 
        ' pnl_main
        ' 
        pnl_main.AutoScroll = True
        pnl_main.AutoSize = True
        pnl_main.AutoSizeMode = AutoSizeMode.GrowAndShrink
        pnl_main.Dock = DockStyle.Fill
        pnl_main.Location = New Point(0, 0)
        pnl_main.Margin = New Padding(2)
        pnl_main.Name = "pnl_main"
        pnl_main.Size = New Size(1458, 461)
        pnl_main.TabIndex = 13
        ' 
        ' frm_map
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1458, 461)
        Controls.Add(pnl_main)
        Name = "frm_map"
        Text = "Map"
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Panel1 As Panel
    Public WithEvents pnl_main As Panel
End Class
