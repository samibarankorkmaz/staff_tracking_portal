<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBagis
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBagis))
        Me.pnBagisYap = New System.Windows.Forms.Panel()
        Me.txtBagisIban = New System.Windows.Forms.TextBox()
        Me.lbBagisIban = New System.Windows.Forms.Label()
        Me.lbBagisMiktar = New System.Windows.Forms.Label()
        Me.txtBagisMiktar = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'pnBagisYap
        '
        Me.pnBagisYap.BackgroundImage = CType(resources.GetObject("pnBagisYap.BackgroundImage"), System.Drawing.Image)
        Me.pnBagisYap.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pnBagisYap.Location = New System.Drawing.Point(157, 117)
        Me.pnBagisYap.Name = "pnBagisYap"
        Me.pnBagisYap.Size = New System.Drawing.Size(80, 55)
        Me.pnBagisYap.TabIndex = 0
        '
        'txtBagisIban
        '
        Me.txtBagisIban.Location = New System.Drawing.Point(100, 29)
        Me.txtBagisIban.Name = "txtBagisIban"
        Me.txtBagisIban.Size = New System.Drawing.Size(119, 20)
        Me.txtBagisIban.TabIndex = 1
        '
        'lbBagisIban
        '
        Me.lbBagisIban.AutoSize = True
        Me.lbBagisIban.Location = New System.Drawing.Point(12, 32)
        Me.lbBagisIban.Name = "lbBagisIban"
        Me.lbBagisIban.Size = New System.Drawing.Size(82, 13)
        Me.lbBagisIban.TabIndex = 2
        Me.lbBagisIban.Text = "IBAN No:    TR-"
        '
        'lbBagisMiktar
        '
        Me.lbBagisMiktar.AutoSize = True
        Me.lbBagisMiktar.Location = New System.Drawing.Point(12, 78)
        Me.lbBagisMiktar.Name = "lbBagisMiktar"
        Me.lbBagisMiktar.Size = New System.Drawing.Size(39, 13)
        Me.lbBagisMiktar.TabIndex = 3
        Me.lbBagisMiktar.Text = "Miktar:"
        '
        'txtBagisMiktar
        '
        Me.txtBagisMiktar.Location = New System.Drawing.Point(98, 78)
        Me.txtBagisMiktar.Name = "txtBagisMiktar"
        Me.txtBagisMiktar.Size = New System.Drawing.Size(121, 20)
        Me.txtBagisMiktar.TabIndex = 4
        '
        'frmBagis
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(249, 174)
        Me.Controls.Add(Me.txtBagisMiktar)
        Me.Controls.Add(Me.lbBagisMiktar)
        Me.Controls.Add(Me.lbBagisIban)
        Me.Controls.Add(Me.txtBagisIban)
        Me.Controls.Add(Me.pnBagisYap)
        Me.Name = "frmBagis"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Bağış Yap"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pnBagisYap As Panel
    Friend WithEvents txtBagisIban As TextBox
    Friend WithEvents lbBagisIban As Label
    Friend WithEvents lbBagisMiktar As Label
    Friend WithEvents txtBagisMiktar As TextBox
End Class
