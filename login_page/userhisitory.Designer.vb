<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class userhistory
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(userhistory))
        Me.pic_his = New System.Windows.Forms.Panel()
        Me.emptylab2 = New System.Windows.Forms.Label()
        Me.emptylab1 = New System.Windows.Forms.Label()
        Me.pic_his.SuspendLayout()
        Me.SuspendLayout()
        '
        'pic_his
        '
        Me.pic_his.Controls.Add(Me.emptylab2)
        Me.pic_his.Controls.Add(Me.emptylab1)
        Me.pic_his.Dock = System.Windows.Forms.DockStyle.Top
        Me.pic_his.Location = New System.Drawing.Point(0, 0)
        Me.pic_his.Name = "pic_his"
        Me.pic_his.Size = New System.Drawing.Size(1431, 689)
        Me.pic_his.TabIndex = 3
        '
        'emptylab2
        '
        Me.emptylab2.AutoSize = True
        Me.emptylab2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.emptylab2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.emptylab2.Location = New System.Drawing.Point(581, 321)
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
        Me.emptylab1.Location = New System.Drawing.Point(441, 285)
        Me.emptylab1.Name = "emptylab1"
        Me.emptylab1.Size = New System.Drawing.Size(558, 36)
        Me.emptylab1.TabIndex = 3
        Me.emptylab1.Text = "Aww,You Have Not Watched Anything ..."
        Me.emptylab1.Visible = False
        '
        'userhistory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.AutoScrollMargin = New System.Drawing.Size(500, 500)
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1452, 767)
        Me.Controls.Add(Me.pic_his)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "userhistory"
        Me.Text = "userhisitory"
        Me.pic_his.ResumeLayout(False)
        Me.pic_his.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pic_his As Panel
    Friend WithEvents emptylab2 As Label
    Friend WithEvents emptylab1 As Label
End Class
