<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Perpus
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
        Me.btnRmv = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.ListBoxKoleksi = New System.Windows.Forms.ListBox()
        Me.MenuStripKoleksi = New System.Windows.Forms.MenuStrip()
        Me.KoleksiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TambahKoleksiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataGridKoleksi = New System.Windows.Forms.DataGridView()
        Me.BtnUpdate = New System.Windows.Forms.Button()
        Me.BtnRemove = New System.Windows.Forms.Button()
        Me.BtnSelect = New System.Windows.Forms.Button()
        Me.MenuStripKoleksi.SuspendLayout()
        CType(Me.DataGridKoleksi, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnRmv
        '
        Me.btnRmv.Location = New System.Drawing.Point(109, 56)
        Me.btnRmv.Name = "btnRmv"
        Me.btnRmv.Size = New System.Drawing.Size(25, 21)
        Me.btnRmv.TabIndex = 7
        Me.btnRmv.Text = "-"
        Me.btnRmv.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(78, 56)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(25, 21)
        Me.btnAdd.TabIndex = 6
        Me.btnAdd.Text = "+"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'ListBoxKoleksi
        '
        Me.ListBoxKoleksi.FormattingEnabled = True
        Me.ListBoxKoleksi.Location = New System.Drawing.Point(78, 83)
        Me.ListBoxKoleksi.Name = "ListBoxKoleksi"
        Me.ListBoxKoleksi.Size = New System.Drawing.Size(331, 160)
        Me.ListBoxKoleksi.TabIndex = 4
        '
        'MenuStripKoleksi
        '
        Me.MenuStripKoleksi.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStripKoleksi.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible
        Me.MenuStripKoleksi.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.KoleksiToolStripMenuItem})
        Me.MenuStripKoleksi.Location = New System.Drawing.Point(78, 9)
        Me.MenuStripKoleksi.Name = "MenuStripKoleksi"
        Me.MenuStripKoleksi.Size = New System.Drawing.Size(68, 24)
        Me.MenuStripKoleksi.TabIndex = 5
        Me.MenuStripKoleksi.Text = "Koleksi"
        '
        'KoleksiToolStripMenuItem
        '
        Me.KoleksiToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TambahKoleksiToolStripMenuItem})
        Me.KoleksiToolStripMenuItem.Name = "KoleksiToolStripMenuItem"
        Me.KoleksiToolStripMenuItem.Size = New System.Drawing.Size(56, 20)
        Me.KoleksiToolStripMenuItem.Text = "Koleksi"
        '
        'TambahKoleksiToolStripMenuItem
        '
        Me.TambahKoleksiToolStripMenuItem.Name = "TambahKoleksiToolStripMenuItem"
        Me.TambahKoleksiToolStripMenuItem.Size = New System.Drawing.Size(156, 22)
        Me.TambahKoleksiToolStripMenuItem.Text = "Tambah Koleksi"
        '
        'DataGridKoleksi
        '
        Me.DataGridKoleksi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridKoleksi.Location = New System.Drawing.Point(445, 83)
        Me.DataGridKoleksi.Name = "DataGridKoleksi"
        Me.DataGridKoleksi.Size = New System.Drawing.Size(478, 150)
        Me.DataGridKoleksi.TabIndex = 8
        '
        'BtnUpdate
        '
        Me.BtnUpdate.Location = New System.Drawing.Point(623, 239)
        Me.BtnUpdate.Name = "BtnUpdate"
        Me.BtnUpdate.Size = New System.Drawing.Size(75, 23)
        Me.BtnUpdate.TabIndex = 9
        Me.BtnUpdate.Text = "Update"
        Me.BtnUpdate.UseVisualStyleBackColor = True
        '
        'BtnRemove
        '
        Me.BtnRemove.Location = New System.Drawing.Point(801, 239)
        Me.BtnRemove.Name = "BtnRemove"
        Me.BtnRemove.Size = New System.Drawing.Size(75, 23)
        Me.BtnRemove.TabIndex = 10
        Me.BtnRemove.Text = "Remove"
        Me.BtnRemove.UseVisualStyleBackColor = True
        '
        'BtnSelect
        '
        Me.BtnSelect.Location = New System.Drawing.Point(720, 239)
        Me.BtnSelect.Name = "BtnSelect"
        Me.BtnSelect.Size = New System.Drawing.Size(75, 23)
        Me.BtnSelect.TabIndex = 11
        Me.BtnSelect.Text = "Select"
        Me.BtnSelect.UseVisualStyleBackColor = True
        '
        'Perpus
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(959, 414)
        Me.Controls.Add(Me.BtnSelect)
        Me.Controls.Add(Me.BtnRemove)
        Me.Controls.Add(Me.BtnUpdate)
        Me.Controls.Add(Me.DataGridKoleksi)
        Me.Controls.Add(Me.btnRmv)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.ListBoxKoleksi)
        Me.Controls.Add(Me.MenuStripKoleksi)
        Me.Name = "Perpus"
        Me.Text = "Perpus"
        Me.MenuStripKoleksi.ResumeLayout(False)
        Me.MenuStripKoleksi.PerformLayout()
        CType(Me.DataGridKoleksi, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnRmv As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents ListBoxKoleksi As ListBox
    Friend WithEvents MenuStripKoleksi As MenuStrip
    Friend WithEvents KoleksiToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TambahKoleksiToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DataGridKoleksi As DataGridView
    Friend WithEvents BtnUpdate As Button
    Friend WithEvents BtnRemove As Button
    Friend WithEvents BtnSelect As Button
End Class
