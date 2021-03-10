<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBossBanka
    Inherits System.Windows.Forms.Form

    'Form, bileşen listesini temizlemeyi bırakmayı geçersiz kılar.
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

    'Windows Form Tasarımcısı tarafından gerektirilir
    Private components As System.ComponentModel.IContainer

    'NOT: Aşağıdaki yordam Windows Form Tasarımcısı için gereklidir
    'Windows Form Tasarımcısı kullanılarak değiştirilebilir.  
    'Kod düzenleyicisini kullanarak değiştirmeyin.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lbBossBanka = New System.Windows.Forms.Label()
        Me.lbBossBankaIban = New System.Windows.Forms.Label()
        Me.lbBossBankaMüsNo = New System.Windows.Forms.Label()
        Me.cbBossBankaBil = New System.Windows.Forms.ComboBox()
        Me.txtBossIban = New System.Windows.Forms.TextBox()
        Me.txtBossBanka = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lbBossBanka
        '
        Me.lbBossBanka.AutoSize = True
        Me.lbBossBanka.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.lbBossBanka.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbBossBanka.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lbBossBanka.Enabled = False
        Me.lbBossBanka.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lbBossBanka.Font = New System.Drawing.Font("Dosis", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lbBossBanka.Location = New System.Drawing.Point(41, 33)
        Me.lbBossBanka.Name = "lbBossBanka"
        Me.lbBossBanka.Size = New System.Drawing.Size(45, 20)
        Me.lbBossBanka.TabIndex = 0
        Me.lbBossBanka.Text = "Banka:"
        Me.lbBossBanka.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbBossBankaIban
        '
        Me.lbBossBankaIban.AutoSize = True
        Me.lbBossBankaIban.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.lbBossBankaIban.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbBossBankaIban.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lbBossBankaIban.Enabled = False
        Me.lbBossBankaIban.Font = New System.Drawing.Font("Dosis", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lbBossBankaIban.Location = New System.Drawing.Point(41, 78)
        Me.lbBossBankaIban.Name = "lbBossBankaIban"
        Me.lbBossBankaIban.Size = New System.Drawing.Size(55, 20)
        Me.lbBossBankaIban.TabIndex = 1
        Me.lbBossBankaIban.Text = "IBAN No:"
        Me.lbBossBankaIban.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbBossBankaMüsNo
        '
        Me.lbBossBankaMüsNo.AutoSize = True
        Me.lbBossBankaMüsNo.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.lbBossBankaMüsNo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbBossBankaMüsNo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lbBossBankaMüsNo.Enabled = False
        Me.lbBossBankaMüsNo.Font = New System.Drawing.Font("Dosis", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lbBossBankaMüsNo.Location = New System.Drawing.Point(41, 124)
        Me.lbBossBankaMüsNo.Name = "lbBossBankaMüsNo"
        Me.lbBossBankaMüsNo.Size = New System.Drawing.Size(69, 20)
        Me.lbBossBankaMüsNo.TabIndex = 2
        Me.lbBossBankaMüsNo.Text = "Müşteri No:"
        Me.lbBossBankaMüsNo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cbBossBankaBil
        '
        Me.cbBossBankaBil.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbBossBankaBil.FormattingEnabled = True
        Me.cbBossBankaBil.Items.AddRange(New Object() {"Yapı Kredi", "Ziraat", "İş"})
        Me.cbBossBankaBil.Location = New System.Drawing.Point(118, 33)
        Me.cbBossBankaBil.Name = "cbBossBankaBil"
        Me.cbBossBankaBil.Size = New System.Drawing.Size(121, 21)
        Me.cbBossBankaBil.TabIndex = 3
        Me.cbBossBankaBil.Tag = ""
        '
        'txtBossIban
        '
        Me.txtBossIban.Location = New System.Drawing.Point(118, 78)
        Me.txtBossIban.Name = "txtBossIban"
        Me.txtBossIban.Size = New System.Drawing.Size(121, 20)
        Me.txtBossIban.TabIndex = 4
        '
        'txtBossBanka
        '
        Me.txtBossBanka.Location = New System.Drawing.Point(118, 124)
        Me.txtBossBanka.Name = "txtBossBanka"
        Me.txtBossBanka.Size = New System.Drawing.Size(121, 20)
        Me.txtBossBanka.TabIndex = 5
        '
        'frmBossBanka
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(273, 177)
        Me.Controls.Add(Me.txtBossBanka)
        Me.Controls.Add(Me.txtBossIban)
        Me.Controls.Add(Me.cbBossBankaBil)
        Me.Controls.Add(Me.lbBossBankaMüsNo)
        Me.Controls.Add(Me.lbBossBankaIban)
        Me.Controls.Add(Me.lbBossBanka)
        Me.Name = "frmBossBanka"
        Me.Text = "Banka Bigileri"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbBossBanka As Label
    Friend WithEvents lbBossBankaIban As Label
    Friend WithEvents lbBossBankaMüsNo As Label
    Friend WithEvents cbBossBankaBil As ComboBox
    Friend WithEvents txtBossIban As TextBox
    Friend WithEvents txtBossBanka As TextBox
End Class
