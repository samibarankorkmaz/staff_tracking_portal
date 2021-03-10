<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAdminGiris
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAdminGiris))
        Me.lbAd = New System.Windows.Forms.Label()
        Me.lbSif = New System.Windows.Forms.Label()
        Me.lbBaglanti = New System.Windows.Forms.Label()
        Me.txtAd = New System.Windows.Forms.TextBox()
        Me.txtSif = New System.Windows.Forms.TextBox()
        Me.cbBaglanti = New System.Windows.Forms.ComboBox()
        Me.btnGiris = New System.Windows.Forms.Button()
        Me.pbErkek = New System.Windows.Forms.PictureBox()
        Me.pbKadin = New System.Windows.Forms.PictureBox()
        Me.lbYazi = New System.Windows.Forms.Label()
        Me.lbNo = New System.Windows.Forms.Label()
        Me.lnkDeusp = New System.Windows.Forms.LinkLabel()
        CType(Me.pbErkek, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbKadin, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbAd
        '
        Me.lbAd.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lbAd.Location = New System.Drawing.Point(274, 25)
        Me.lbAd.Name = "lbAd"
        Me.lbAd.Size = New System.Drawing.Size(160, 50)
        Me.lbAd.TabIndex = 1
        Me.lbAd.Text = "Kullanıcı Adı :"
        Me.lbAd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbSif
        '
        Me.lbSif.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbSif.Location = New System.Drawing.Point(274, 75)
        Me.lbSif.Name = "lbSif"
        Me.lbSif.Size = New System.Drawing.Size(116, 63)
        Me.lbSif.TabIndex = 7
        Me.lbSif.Text = "Şifre : "
        Me.lbSif.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbBaglanti
        '
        Me.lbBaglanti.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lbBaglanti.Location = New System.Drawing.Point(274, 137)
        Me.lbBaglanti.Name = "lbBaglanti"
        Me.lbBaglanti.Size = New System.Drawing.Size(123, 52)
        Me.lbBaglanti.TabIndex = 10
        Me.lbBaglanti.Text = "Bağlantı :"
        Me.lbBaglanti.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtAd
        '
        Me.txtAd.AutoCompleteCustomSource.AddRange(New String() {"admin"})
        Me.txtAd.Location = New System.Drawing.Point(427, 44)
        Me.txtAd.Name = "txtAd"
        Me.txtAd.Size = New System.Drawing.Size(135, 20)
        Me.txtAd.TabIndex = 11
        Me.txtAd.Tag = ""
        '
        'txtSif
        '
        Me.txtSif.Location = New System.Drawing.Point(427, 100)
        Me.txtSif.Name = "txtSif"
        Me.txtSif.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtSif.Size = New System.Drawing.Size(135, 20)
        Me.txtSif.TabIndex = 12
        '
        'cbBaglanti
        '
        Me.cbBaglanti.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.cbBaglanti.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbBaglanti.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cbBaglanti.ForeColor = System.Drawing.SystemColors.MenuText
        Me.cbBaglanti.FormattingEnabled = True
        Me.cbBaglanti.IntegralHeight = False
        Me.cbBaglanti.Items.AddRange(New Object() {"Online", "Offline"})
        Me.cbBaglanti.Location = New System.Drawing.Point(427, 157)
        Me.cbBaglanti.Name = "cbBaglanti"
        Me.cbBaglanti.Size = New System.Drawing.Size(135, 21)
        Me.cbBaglanti.TabIndex = 13
        '
        'btnGiris
        '
        Me.btnGiris.BackColor = System.Drawing.Color.SlateGray
        Me.btnGiris.Font = New System.Drawing.Font("Bahnschrift Condensed", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btnGiris.Location = New System.Drawing.Point(427, 224)
        Me.btnGiris.Name = "btnGiris"
        Me.btnGiris.Size = New System.Drawing.Size(135, 63)
        Me.btnGiris.TabIndex = 14
        Me.btnGiris.Text = "Giriş"
        Me.btnGiris.UseVisualStyleBackColor = False
        '
        'pbErkek
        '
        Me.pbErkek.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.pbErkek.Image = CType(resources.GetObject("pbErkek.Image"), System.Drawing.Image)
        Me.pbErkek.Location = New System.Drawing.Point(22, 12)
        Me.pbErkek.Name = "pbErkek"
        Me.pbErkek.Size = New System.Drawing.Size(125, 166)
        Me.pbErkek.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbErkek.TabIndex = 15
        Me.pbErkek.TabStop = False
        '
        'pbKadin
        '
        Me.pbKadin.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.pbKadin.ErrorImage = Nothing
        Me.pbKadin.Image = CType(resources.GetObject("pbKadin.Image"), System.Drawing.Image)
        Me.pbKadin.Location = New System.Drawing.Point(143, 12)
        Me.pbKadin.Name = "pbKadin"
        Me.pbKadin.Size = New System.Drawing.Size(125, 166)
        Me.pbKadin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbKadin.TabIndex = 16
        Me.pbKadin.TabStop = False
        '
        'lbYazi
        '
        Me.lbYazi.AutoSize = True
        Me.lbYazi.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbYazi.Location = New System.Drawing.Point(19, 208)
        Me.lbYazi.Name = "lbYazi"
        Me.lbYazi.Size = New System.Drawing.Size(262, 16)
        Me.lbYazi.TabIndex = 17
        Me.lbYazi.Text = """DEUSP PDKS 2019 Tüm Hakları Saklıdır."""
        '
        'lbNo
        '
        Me.lbNo.AutoSize = True
        Me.lbNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbNo.Location = New System.Drawing.Point(19, 236)
        Me.lbNo.Name = "lbNo"
        Me.lbNo.Size = New System.Drawing.Size(104, 16)
        Me.lbNo.TabIndex = 18
        Me.lbNo.Text = """0532 410 53 97"""
        '
        'lnkDeusp
        '
        Me.lnkDeusp.AutoSize = True
        Me.lnkDeusp.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lnkDeusp.Location = New System.Drawing.Point(14, 273)
        Me.lnkDeusp.Name = "lnkDeusp"
        Me.lnkDeusp.Size = New System.Drawing.Size(205, 25)
        Me.lnkDeusp.TabIndex = 19
        Me.lnkDeusp.TabStop = True
        Me.lnkDeusp.Text = "http://deuspdks.com"
        '
        'frmAdminGiris
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(599, 319)
        Me.Controls.Add(Me.lnkDeusp)
        Me.Controls.Add(Me.lbNo)
        Me.Controls.Add(Me.lbYazi)
        Me.Controls.Add(Me.pbKadin)
        Me.Controls.Add(Me.pbErkek)
        Me.Controls.Add(Me.btnGiris)
        Me.Controls.Add(Me.cbBaglanti)
        Me.Controls.Add(Me.txtSif)
        Me.Controls.Add(Me.txtAd)
        Me.Controls.Add(Me.lbBaglanti)
        Me.Controls.Add(Me.lbSif)
        Me.Controls.Add(Me.lbAd)
        Me.Name = "frmAdminGiris"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DEUSP PDKS GİRİŞ | v.1.0.0"
        CType(Me.pbErkek, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbKadin, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbAd As Label
    Friend WithEvents lbSif As Label
    Friend WithEvents lbBaglanti As Label
    Friend WithEvents txtAd As TextBox
    Friend WithEvents txtSif As TextBox
    Friend WithEvents cbBaglanti As ComboBox
    Friend WithEvents btnGiris As Button
    Friend WithEvents pbErkek As PictureBox
    Friend WithEvents pbKadin As PictureBox
    Friend WithEvents lbYazi As Label
    Friend WithEvents lbNo As Label
    Friend WithEvents lnkDeusp As LinkLabel
End Class
