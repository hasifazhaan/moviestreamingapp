<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class favourite
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.pic_fav = New System.Windows.Forms.Panel()
        Me.emptylab2 = New System.Windows.Forms.Label()
        Me.emptylab1 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.pic_fav.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1453, 64)
        Me.Panel1.TabIndex = 1
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(12, 22)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(158, 29)
        Me.Label9.TabIndex = 1
        Me.Label9.Text = "My Collection"
        '
        'pic_fav
        '
        Me.pic_fav.AutoScroll = True
        Me.pic_fav.Controls.Add(Me.emptylab2)
        Me.pic_fav.Controls.Add(Me.emptylab1)
        Me.pic_fav.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pic_fav.Location = New System.Drawing.Point(0, 64)
        Me.pic_fav.Name = "pic_fav"
        Me.pic_fav.Size = New System.Drawing.Size(1453, 678)
        Me.pic_fav.TabIndex = 2
        '
        'emptylab2
        '
        Me.emptylab2.AutoSize = True
        Me.emptylab2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.emptylab2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.emptylab2.Location = New System.Drawing.Point(608, 309)
        Me.emptylab2.Name = "emptylab2"
        Me.emptylab2.Size = New System.Drawing.Size(211, 36)
        Me.emptylab2.TabIndex = 4
        Me.emptylab2.Text = "Go And Watch" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.emptylab2.Visible = False
        '
        'emptylab1
        '
        Me.emptylab1.AutoSize = True
        Me.emptylab1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.emptylab1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.emptylab1.Location = New System.Drawing.Point(468, 273)
        Me.emptylab1.Name = "emptylab1"
        Me.emptylab1.Size = New System.Drawing.Size(558, 36)
        Me.emptylab1.TabIndex = 3
        Me.emptylab1.Text = "Aww,You Have Not Watched Anything ..."
        Me.emptylab1.Visible = False
        '
        'favourite
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1453, 742)
        Me.Controls.Add(Me.pic_fav)
        Me.Controls.Add(Me.Panel1)
        Me.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "favourite"
        Me.Text = "favourite"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.pic_fav.ResumeLayout(False)
        Me.pic_fav.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label9 As Label
    Private WithEvents Panel1 As Panel
    Friend WithEvents pic_fav As Panel
    Friend WithEvents emptylab2 As Label
    Friend WithEvents emptylab1 As Label
End Class
