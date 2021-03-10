<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDelal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDelal))
        Me.tabcDelal = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.gbDelalKisisel = New System.Windows.Forms.GroupBox()
        Me.btnDelalKaydet1 = New System.Windows.Forms.Button()
        Me.cbDelalMedeni = New System.Windows.Forms.ComboBox()
        Me.lbDelalMedeni = New System.Windows.Forms.Label()
        Me.txtDelalTc = New System.Windows.Forms.TextBox()
        Me.mtbDelalTarih = New System.Windows.Forms.MaskedTextBox()
        Me.cbDelalTahsil = New System.Windows.Forms.ComboBox()
        Me.cbDelalDogum = New System.Windows.Forms.ComboBox()
        Me.cbDelalMemleket = New System.Windows.Forms.ComboBox()
        Me.rtbDelalAdres = New System.Windows.Forms.RichTextBox()
        Me.txtDelalYas = New System.Windows.Forms.TextBox()
        Me.txtDelalSoyad = New System.Windows.Forms.TextBox()
        Me.txtDelalAd = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.lbDelalAdres = New System.Windows.Forms.Label()
        Me.lbDelalTahsil = New System.Windows.Forms.Label()
        Me.lbDelalDogum = New System.Windows.Forms.Label()
        Me.lbDelalMemleket = New System.Windows.Forms.Label()
        Me.lbDelalTc = New System.Windows.Forms.Label()
        Me.lbDelalYas = New System.Windows.Forms.Label()
        Me.lbDelalSoyad = New System.Windows.Forms.Label()
        Me.lbDelalAd = New System.Windows.Forms.Label()
        Me.pbDelal = New System.Windows.Forms.PictureBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.gbDelalFirma = New System.Windows.Forms.GroupBox()
        Me.btnDelalKaydet2 = New System.Windows.Forms.Button()
        Me.lbDelalNokGunSay = New System.Windows.Forms.Label()
        Me.lbDelalNoksanGun = New System.Windows.Forms.Label()
        Me.dtpDelalMaas = New System.Windows.Forms.DateTimePicker()
        Me.lbDelalOdeme = New System.Windows.Forms.Label()
        Me.clbDelalTatil = New System.Windows.Forms.CheckedListBox()
        Me.lbDelalTatil = New System.Windows.Forms.Label()
        Me.lbDelalMaas = New System.Windows.Forms.Label()
        Me.btnDelalMail = New System.Windows.Forms.Button()
        Me.btnDelalTel = New System.Windows.Forms.Button()
        Me.btnDelalBanka = New System.Windows.Forms.Button()
        Me.txtDelalPara = New System.Windows.Forms.ComboBox()
        Me.txtDelalMaas = New System.Windows.Forms.TextBox()
        Me.txtDelalPozisyon = New System.Windows.Forms.TextBox()
        Me.lbDelalPozisyon = New System.Windows.Forms.Label()
        Me.tabcDelal.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.gbDelalKisisel.SuspendLayout()
        CType(Me.pbDelal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        Me.gbDelalFirma.SuspendLayout()
        Me.SuspendLayout()
        '
        'tabcDelal
        '
        Me.tabcDelal.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tabcDelal.Appearance = System.Windows.Forms.TabAppearance.FlatButtons
        Me.tabcDelal.Controls.Add(Me.TabPage1)
        Me.tabcDelal.Controls.Add(Me.TabPage2)
        Me.tabcDelal.Location = New System.Drawing.Point(0, 3)
        Me.tabcDelal.Name = "tabcDelal"
        Me.tabcDelal.SelectedIndex = 0
        Me.tabcDelal.Size = New System.Drawing.Size(431, 491)
        Me.tabcDelal.TabIndex = 11
        Me.tabcDelal.Tag = ""
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.gbDelalKisisel)
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(423, 462)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Kişisel Bilgiler"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'gbDelalKisisel
        '
        Me.gbDelalKisisel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbDelalKisisel.BackColor = System.Drawing.SystemColors.ControlDark
        Me.gbDelalKisisel.Controls.Add(Me.btnDelalKaydet1)
        Me.gbDelalKisisel.Controls.Add(Me.cbDelalMedeni)
        Me.gbDelalKisisel.Controls.Add(Me.lbDelalMedeni)
        Me.gbDelalKisisel.Controls.Add(Me.txtDelalTc)
        Me.gbDelalKisisel.Controls.Add(Me.mtbDelalTarih)
        Me.gbDelalKisisel.Controls.Add(Me.cbDelalTahsil)
        Me.gbDelalKisisel.Controls.Add(Me.cbDelalDogum)
        Me.gbDelalKisisel.Controls.Add(Me.cbDelalMemleket)
        Me.gbDelalKisisel.Controls.Add(Me.rtbDelalAdres)
        Me.gbDelalKisisel.Controls.Add(Me.txtDelalYas)
        Me.gbDelalKisisel.Controls.Add(Me.txtDelalSoyad)
        Me.gbDelalKisisel.Controls.Add(Me.txtDelalAd)
        Me.gbDelalKisisel.Controls.Add(Me.Label13)
        Me.gbDelalKisisel.Controls.Add(Me.lbDelalAdres)
        Me.gbDelalKisisel.Controls.Add(Me.lbDelalTahsil)
        Me.gbDelalKisisel.Controls.Add(Me.lbDelalDogum)
        Me.gbDelalKisisel.Controls.Add(Me.lbDelalMemleket)
        Me.gbDelalKisisel.Controls.Add(Me.lbDelalTc)
        Me.gbDelalKisisel.Controls.Add(Me.lbDelalYas)
        Me.gbDelalKisisel.Controls.Add(Me.lbDelalSoyad)
        Me.gbDelalKisisel.Controls.Add(Me.lbDelalAd)
        Me.gbDelalKisisel.Controls.Add(Me.pbDelal)
        Me.gbDelalKisisel.Font = New System.Drawing.Font("Dosis", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.gbDelalKisisel.ForeColor = System.Drawing.SystemColors.MenuText
        Me.gbDelalKisisel.Location = New System.Drawing.Point(1, 0)
        Me.gbDelalKisisel.Name = "gbDelalKisisel"
        Me.gbDelalKisisel.Size = New System.Drawing.Size(423, 463)
        Me.gbDelalKisisel.TabIndex = 9
        Me.gbDelalKisisel.TabStop = False
        Me.gbDelalKisisel.Text = "Delal Abdüllatif "
        '
        'btnDelalKaydet1
        '
        Me.btnDelalKaydet1.Location = New System.Drawing.Point(338, 423)
        Me.btnDelalKaydet1.Name = "btnDelalKaydet1"
        Me.btnDelalKaydet1.Size = New System.Drawing.Size(78, 33)
        Me.btnDelalKaydet1.TabIndex = 30
        Me.btnDelalKaydet1.Text = "Kaydet"
        Me.btnDelalKaydet1.UseVisualStyleBackColor = True
        '
        'cbDelalMedeni
        '
        Me.cbDelalMedeni.FormattingEnabled = True
        Me.cbDelalMedeni.Items.AddRange(New Object() {"Evli", "Bekar", "Dul"})
        Me.cbDelalMedeni.Location = New System.Drawing.Point(280, 343)
        Me.cbDelalMedeni.Name = "cbDelalMedeni"
        Me.cbDelalMedeni.Size = New System.Drawing.Size(95, 26)
        Me.cbDelalMedeni.TabIndex = 29
        Me.cbDelalMedeni.Text = "Evli"
        '
        'lbDelalMedeni
        '
        Me.lbDelalMedeni.AutoSize = True
        Me.lbDelalMedeni.Font = New System.Drawing.Font("Dosis", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lbDelalMedeni.ForeColor = System.Drawing.SystemColors.InfoText
        Me.lbDelalMedeni.Location = New System.Drawing.Point(276, 296)
        Me.lbDelalMedeni.Name = "lbDelalMedeni"
        Me.lbDelalMedeni.Size = New System.Drawing.Size(115, 21)
        Me.lbDelalMedeni.TabIndex = 28
        Me.lbDelalMedeni.Text = "Medeni Durumu:"
        '
        'txtDelalTc
        '
        Me.txtDelalTc.Location = New System.Drawing.Point(292, 140)
        Me.txtDelalTc.Name = "txtDelalTc"
        Me.txtDelalTc.Size = New System.Drawing.Size(100, 24)
        Me.txtDelalTc.TabIndex = 27
        Me.txtDelalTc.Text = "1354685461"
        Me.txtDelalTc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'mtbDelalTarih
        '
        Me.mtbDelalTarih.Location = New System.Drawing.Point(271, 246)
        Me.mtbDelalTarih.Mask = "00/00/0000"
        Me.mtbDelalTarih.Name = "mtbDelalTarih"
        Me.mtbDelalTarih.Size = New System.Drawing.Size(121, 24)
        Me.mtbDelalTarih.TabIndex = 26
        Me.mtbDelalTarih.Text = "27031988"
        Me.mtbDelalTarih.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.mtbDelalTarih.ValidatingType = GetType(Date)
        '
        'cbDelalTahsil
        '
        Me.cbDelalTahsil.FormattingEnabled = True
        Me.cbDelalTahsil.Items.AddRange(New Object() {"İlkokul", "Ortaokul", "Lise", "Üniversite", "Yüksek Lisans", "Okumamış"})
        Me.cbDelalTahsil.Location = New System.Drawing.Point(150, 343)
        Me.cbDelalTahsil.Name = "cbDelalTahsil"
        Me.cbDelalTahsil.Size = New System.Drawing.Size(95, 26)
        Me.cbDelalTahsil.TabIndex = 25
        Me.cbDelalTahsil.Text = "Üniversite"
        '
        'cbDelalDogum
        '
        Me.cbDelalDogum.FormattingEnabled = True
        Me.cbDelalDogum.Location = New System.Drawing.Point(144, 245)
        Me.cbDelalDogum.Name = "cbDelalDogum"
        Me.cbDelalDogum.Size = New System.Drawing.Size(121, 26)
        Me.cbDelalDogum.TabIndex = 24
        Me.cbDelalDogum.Text = "Kırıkkale"
        '
        'cbDelalMemleket
        '
        Me.cbDelalMemleket.FormattingEnabled = True
        Me.cbDelalMemleket.Location = New System.Drawing.Point(144, 197)
        Me.cbDelalMemleket.Name = "cbDelalMemleket"
        Me.cbDelalMemleket.Size = New System.Drawing.Size(121, 26)
        Me.cbDelalMemleket.TabIndex = 23
        Me.cbDelalMemleket.Text = "Ankara"
        '
        'rtbDelalAdres
        '
        Me.rtbDelalAdres.Location = New System.Drawing.Point(11, 333)
        Me.rtbDelalAdres.Name = "rtbDelalAdres"
        Me.rtbDelalAdres.Size = New System.Drawing.Size(105, 104)
        Me.rtbDelalAdres.TabIndex = 22
        Me.rtbDelalAdres.Text = "x caddesi y sokak .......... İstanbul"
        '
        'txtDelalYas
        '
        Me.txtDelalYas.Location = New System.Drawing.Point(292, 105)
        Me.txtDelalYas.Name = "txtDelalYas"
        Me.txtDelalYas.Size = New System.Drawing.Size(100, 24)
        Me.txtDelalYas.TabIndex = 17
        Me.txtDelalYas.Text = "30"
        Me.txtDelalYas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtDelalSoyad
        '
        Me.txtDelalSoyad.Location = New System.Drawing.Point(292, 66)
        Me.txtDelalSoyad.Name = "txtDelalSoyad"
        Me.txtDelalSoyad.Size = New System.Drawing.Size(100, 24)
        Me.txtDelalSoyad.TabIndex = 16
        Me.txtDelalSoyad.Text = "Abzak"
        Me.txtDelalSoyad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtDelalAd
        '
        Me.txtDelalAd.Location = New System.Drawing.Point(292, 28)
        Me.txtDelalAd.Name = "txtDelalAd"
        Me.txtDelalAd.Size = New System.Drawing.Size(100, 24)
        Me.txtDelalAd.TabIndex = 15
        Me.txtDelalAd.Text = "Delal Abdüllatif"
        Me.txtDelalAd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label13
        '
        Me.Label13.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label13.BackColor = System.Drawing.SystemColors.MenuText
        Me.Label13.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label13.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label13.Location = New System.Drawing.Point(0, 171)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(423, 0)
        Me.Label13.TabIndex = 14
        Me.Label13.Text = "Label13"
        '
        'lbDelalAdres
        '
        Me.lbDelalAdres.AutoSize = True
        Me.lbDelalAdres.Font = New System.Drawing.Font("Dosis", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lbDelalAdres.ForeColor = System.Drawing.SystemColors.InfoText
        Me.lbDelalAdres.Location = New System.Drawing.Point(7, 296)
        Me.lbDelalAdres.Name = "lbDelalAdres"
        Me.lbDelalAdres.Size = New System.Drawing.Size(54, 21)
        Me.lbDelalAdres.TabIndex = 9
        Me.lbDelalAdres.Text = "Adresi:"
        '
        'lbDelalTahsil
        '
        Me.lbDelalTahsil.AutoSize = True
        Me.lbDelalTahsil.Font = New System.Drawing.Font("Dosis", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lbDelalTahsil.ForeColor = System.Drawing.SystemColors.InfoText
        Me.lbDelalTahsil.Location = New System.Drawing.Point(146, 296)
        Me.lbDelalTahsil.Name = "lbDelalTahsil"
        Me.lbDelalTahsil.Size = New System.Drawing.Size(104, 21)
        Me.lbDelalTahsil.TabIndex = 8
        Me.lbDelalTahsil.Text = "Tahsil Durumu:"
        '
        'lbDelalDogum
        '
        Me.lbDelalDogum.AutoSize = True
        Me.lbDelalDogum.Font = New System.Drawing.Font("Dosis", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lbDelalDogum.ForeColor = System.Drawing.SystemColors.InfoText
        Me.lbDelalDogum.Location = New System.Drawing.Point(3, 249)
        Me.lbDelalDogum.Name = "lbDelalDogum"
        Me.lbDelalDogum.Size = New System.Drawing.Size(131, 21)
        Me.lbDelalDogum.TabIndex = 7
        Me.lbDelalDogum.Text = "Doğum Yeri/ Tarihi:"
        '
        'lbDelalMemleket
        '
        Me.lbDelalMemleket.AutoSize = True
        Me.lbDelalMemleket.Font = New System.Drawing.Font("Dosis", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lbDelalMemleket.ForeColor = System.Drawing.SystemColors.InfoText
        Me.lbDelalMemleket.Location = New System.Drawing.Point(31, 200)
        Me.lbDelalMemleket.Name = "lbDelalMemleket"
        Me.lbDelalMemleket.Size = New System.Drawing.Size(82, 21)
        Me.lbDelalMemleket.TabIndex = 6
        Me.lbDelalMemleket.Text = "Memleketi:"
        '
        'lbDelalTc
        '
        Me.lbDelalTc.AutoSize = True
        Me.lbDelalTc.Font = New System.Drawing.Font("Dosis", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lbDelalTc.ForeColor = System.Drawing.SystemColors.InfoText
        Me.lbDelalTc.Location = New System.Drawing.Point(180, 140)
        Me.lbDelalTc.Name = "lbDelalTc"
        Me.lbDelalTc.Size = New System.Drawing.Size(94, 21)
        Me.lbDelalTc.TabIndex = 5
        Me.lbDelalTc.Text = "TC Kimlik No:"
        '
        'lbDelalYas
        '
        Me.lbDelalYas.AutoSize = True
        Me.lbDelalYas.Font = New System.Drawing.Font("Dosis", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lbDelalYas.ForeColor = System.Drawing.SystemColors.InfoText
        Me.lbDelalYas.Location = New System.Drawing.Point(180, 108)
        Me.lbDelalYas.Name = "lbDelalYas"
        Me.lbDelalYas.Size = New System.Drawing.Size(35, 21)
        Me.lbDelalYas.TabIndex = 4
        Me.lbDelalYas.Text = "Yaş:"
        '
        'lbDelalSoyad
        '
        Me.lbDelalSoyad.AutoSize = True
        Me.lbDelalSoyad.Font = New System.Drawing.Font("Dosis", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lbDelalSoyad.ForeColor = System.Drawing.SystemColors.InfoText
        Me.lbDelalSoyad.Location = New System.Drawing.Point(180, 69)
        Me.lbDelalSoyad.Name = "lbDelalSoyad"
        Me.lbDelalSoyad.Size = New System.Drawing.Size(55, 21)
        Me.lbDelalSoyad.TabIndex = 3
        Me.lbDelalSoyad.Text = "Soyadı:"
        '
        'lbDelalAd
        '
        Me.lbDelalAd.AutoSize = True
        Me.lbDelalAd.Font = New System.Drawing.Font("Dosis", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lbDelalAd.ForeColor = System.Drawing.SystemColors.InfoText
        Me.lbDelalAd.Location = New System.Drawing.Point(180, 31)
        Me.lbDelalAd.Name = "lbDelalAd"
        Me.lbDelalAd.Size = New System.Drawing.Size(34, 21)
        Me.lbDelalAd.TabIndex = 2
        Me.lbDelalAd.Text = "Adı:"
        '
        'pbDelal
        '
        Me.pbDelal.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pbDelal.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.pbDelal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.pbDelal.Cursor = System.Windows.Forms.Cursors.Default
        Me.pbDelal.Image = CType(resources.GetObject("pbDelal.Image"), System.Drawing.Image)
        Me.pbDelal.Location = New System.Drawing.Point(0, 19)
        Me.pbDelal.Name = "pbDelal"
        Me.pbDelal.Size = New System.Drawing.Size(174, 146)
        Me.pbDelal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbDelal.TabIndex = 1
        Me.pbDelal.TabStop = False
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.gbDelalFirma)
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(423, 462)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Firma Bilgileri"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'gbDelalFirma
        '
        Me.gbDelalFirma.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbDelalFirma.BackColor = System.Drawing.SystemColors.ControlDark
        Me.gbDelalFirma.Controls.Add(Me.btnDelalKaydet2)
        Me.gbDelalFirma.Controls.Add(Me.lbDelalNokGunSay)
        Me.gbDelalFirma.Controls.Add(Me.lbDelalNoksanGun)
        Me.gbDelalFirma.Controls.Add(Me.dtpDelalMaas)
        Me.gbDelalFirma.Controls.Add(Me.lbDelalOdeme)
        Me.gbDelalFirma.Controls.Add(Me.clbDelalTatil)
        Me.gbDelalFirma.Controls.Add(Me.lbDelalTatil)
        Me.gbDelalFirma.Controls.Add(Me.lbDelalMaas)
        Me.gbDelalFirma.Controls.Add(Me.btnDelalMail)
        Me.gbDelalFirma.Controls.Add(Me.btnDelalTel)
        Me.gbDelalFirma.Controls.Add(Me.btnDelalBanka)
        Me.gbDelalFirma.Controls.Add(Me.txtDelalPara)
        Me.gbDelalFirma.Controls.Add(Me.txtDelalMaas)
        Me.gbDelalFirma.Controls.Add(Me.txtDelalPozisyon)
        Me.gbDelalFirma.Controls.Add(Me.lbDelalPozisyon)
        Me.gbDelalFirma.Font = New System.Drawing.Font("Dosis", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.gbDelalFirma.Location = New System.Drawing.Point(0, 0)
        Me.gbDelalFirma.Name = "gbDelalFirma"
        Me.gbDelalFirma.Size = New System.Drawing.Size(467, 859)
        Me.gbDelalFirma.TabIndex = 0
        Me.gbDelalFirma.TabStop = False
        Me.gbDelalFirma.Text = "Delal | Şef Garson"
        '
        'btnDelalKaydet2
        '
        Me.btnDelalKaydet2.Location = New System.Drawing.Point(339, 423)
        Me.btnDelalKaydet2.Name = "btnDelalKaydet2"
        Me.btnDelalKaydet2.Size = New System.Drawing.Size(78, 33)
        Me.btnDelalKaydet2.TabIndex = 31
        Me.btnDelalKaydet2.Text = "Kaydet"
        Me.btnDelalKaydet2.UseVisualStyleBackColor = True
        '
        'lbDelalNokGunSay
        '
        Me.lbDelalNokGunSay.Font = New System.Drawing.Font("Dosis", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lbDelalNokGunSay.Location = New System.Drawing.Point(112, 366)
        Me.lbDelalNokGunSay.Name = "lbDelalNokGunSay"
        Me.lbDelalNokGunSay.Size = New System.Drawing.Size(124, 51)
        Me.lbDelalNokGunSay.TabIndex = 15
        Me.lbDelalNokGunSay.Text = "32"
        Me.lbDelalNokGunSay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbDelalNoksanGun
        '
        Me.lbDelalNoksanGun.Font = New System.Drawing.Font("Dosis", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lbDelalNoksanGun.Location = New System.Drawing.Point(8, 376)
        Me.lbDelalNoksanGun.Name = "lbDelalNoksanGun"
        Me.lbDelalNoksanGun.Size = New System.Drawing.Size(98, 41)
        Me.lbDelalNoksanGun.TabIndex = 14
        Me.lbDelalNoksanGun.Text = "Ekstra Gelmediği Gün Sayısı:"
        Me.lbDelalNoksanGun.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dtpDelalMaas
        '
        Me.dtpDelalMaas.Location = New System.Drawing.Point(112, 307)
        Me.dtpDelalMaas.Name = "dtpDelalMaas"
        Me.dtpDelalMaas.Size = New System.Drawing.Size(173, 24)
        Me.dtpDelalMaas.TabIndex = 13
        Me.dtpDelalMaas.Value = New Date(2018, 11, 29, 23, 10, 53, 0)
        '
        'lbDelalOdeme
        '
        Me.lbDelalOdeme.Font = New System.Drawing.Font("Dosis", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lbDelalOdeme.Location = New System.Drawing.Point(6, 301)
        Me.lbDelalOdeme.Name = "lbDelalOdeme"
        Me.lbDelalOdeme.Size = New System.Drawing.Size(98, 41)
        Me.lbDelalOdeme.TabIndex = 12
        Me.lbDelalOdeme.Text = "Maaş Ödeme Tarihi:"
        Me.lbDelalOdeme.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'clbDelalTatil
        '
        Me.clbDelalTatil.FormattingEnabled = True
        Me.clbDelalTatil.Items.AddRange(New Object() {"Pazartesi", "Salı", "Çarşamba", "Perşembe", "Cuma", "Cumartesi", "Pazar"})
        Me.clbDelalTatil.Location = New System.Drawing.Point(112, 145)
        Me.clbDelalTatil.Name = "clbDelalTatil"
        Me.clbDelalTatil.Size = New System.Drawing.Size(120, 137)
        Me.clbDelalTatil.TabIndex = 11
        '
        'lbDelalTatil
        '
        Me.lbDelalTatil.Font = New System.Drawing.Font("Dosis", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lbDelalTatil.Location = New System.Drawing.Point(8, 145)
        Me.lbDelalTatil.Name = "lbDelalTatil"
        Me.lbDelalTatil.Size = New System.Drawing.Size(98, 41)
        Me.lbDelalTatil.TabIndex = 10
        Me.lbDelalTatil.Text = "Tatil Günleri:"
        Me.lbDelalTatil.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbDelalMaas
        '
        Me.lbDelalMaas.Font = New System.Drawing.Font("Dosis", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lbDelalMaas.Location = New System.Drawing.Point(6, 90)
        Me.lbDelalMaas.Name = "lbDelalMaas"
        Me.lbDelalMaas.Size = New System.Drawing.Size(98, 39)
        Me.lbDelalMaas.TabIndex = 9
        Me.lbDelalMaas.Text = "Aldığı Maaş:"
        Me.lbDelalMaas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnDelalMail
        '
        Me.btnDelalMail.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.btnDelalMail.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnDelalMail.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnDelalMail.Font = New System.Drawing.Font("Dosis", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btnDelalMail.Location = New System.Drawing.Point(318, 171)
        Me.btnDelalMail.Name = "btnDelalMail"
        Me.btnDelalMail.Size = New System.Drawing.Size(90, 40)
        Me.btnDelalMail.TabIndex = 8
        Me.btnDelalMail.Text = "E-mail "
        Me.btnDelalMail.UseVisualStyleBackColor = False
        '
        'btnDelalTel
        '
        Me.btnDelalTel.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.btnDelalTel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnDelalTel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnDelalTel.Font = New System.Drawing.Font("Dosis", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btnDelalTel.Location = New System.Drawing.Point(318, 97)
        Me.btnDelalTel.Name = "btnDelalTel"
        Me.btnDelalTel.Size = New System.Drawing.Size(90, 40)
        Me.btnDelalTel.TabIndex = 7
        Me.btnDelalTel.Text = "Telefon"
        Me.btnDelalTel.UseVisualStyleBackColor = False
        '
        'btnDelalBanka
        '
        Me.btnDelalBanka.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.btnDelalBanka.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnDelalBanka.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnDelalBanka.Font = New System.Drawing.Font("Dosis", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btnDelalBanka.Location = New System.Drawing.Point(318, 23)
        Me.btnDelalBanka.Name = "btnDelalBanka"
        Me.btnDelalBanka.Size = New System.Drawing.Size(90, 40)
        Me.btnDelalBanka.TabIndex = 6
        Me.btnDelalBanka.Text = "Banka Bilgileri"
        Me.btnDelalBanka.UseVisualStyleBackColor = False
        '
        'txtDelalPara
        '
        Me.txtDelalPara.FormattingEnabled = True
        Me.txtDelalPara.Items.AddRange(New Object() {"₺", "€", "$", "£", "KWD"})
        Me.txtDelalPara.Location = New System.Drawing.Point(167, 97)
        Me.txtDelalPara.Name = "txtDelalPara"
        Me.txtDelalPara.Size = New System.Drawing.Size(50, 26)
        Me.txtDelalPara.TabIndex = 5
        '
        'txtDelalMaas
        '
        Me.txtDelalMaas.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txtDelalMaas.Location = New System.Drawing.Point(110, 99)
        Me.txtDelalMaas.Name = "txtDelalMaas"
        Me.txtDelalMaas.Size = New System.Drawing.Size(51, 24)
        Me.txtDelalMaas.TabIndex = 4
        Me.txtDelalMaas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtDelalPozisyon
        '
        Me.txtDelalPozisyon.Font = New System.Drawing.Font("Dosis", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txtDelalPozisyon.Location = New System.Drawing.Point(110, 47)
        Me.txtDelalPozisyon.Name = "txtDelalPozisyon"
        Me.txtDelalPozisyon.Size = New System.Drawing.Size(87, 24)
        Me.txtDelalPozisyon.TabIndex = 2
        Me.txtDelalPozisyon.Text = "Şef Garson"
        Me.txtDelalPozisyon.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lbDelalPozisyon
        '
        Me.lbDelalPozisyon.Font = New System.Drawing.Font("Dosis", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lbDelalPozisyon.Location = New System.Drawing.Point(6, 30)
        Me.lbDelalPozisyon.Name = "lbDelalPozisyon"
        Me.lbDelalPozisyon.Size = New System.Drawing.Size(98, 60)
        Me.lbDelalPozisyon.TabIndex = 1
        Me.lbDelalPozisyon.Text = "İşyerindeki Konumu:"
        Me.lbDelalPozisyon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmDelal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(475, 506)
        Me.Controls.Add(Me.tabcDelal)
        Me.Name = "frmDelal"
        Me.Text = "Delal Abdüllatif"
        Me.tabcDelal.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.gbDelalKisisel.ResumeLayout(False)
        Me.gbDelalKisisel.PerformLayout()
        CType(Me.pbDelal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.gbDelalFirma.ResumeLayout(False)
        Me.gbDelalFirma.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tabcDelal As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents gbDelalKisisel As GroupBox
    Friend WithEvents txtDelalTc As TextBox
    Friend WithEvents mtbDelalTarih As MaskedTextBox
    Friend WithEvents cbDelalTahsil As ComboBox
    Friend WithEvents cbDelalDogum As ComboBox
    Friend WithEvents cbDelalMemleket As ComboBox
    Friend WithEvents rtbDelalAdres As RichTextBox
    Friend WithEvents txtDelalYas As TextBox
    Friend WithEvents txtDelalSoyad As TextBox
    Friend WithEvents txtDelalAd As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents lbDelalAdres As Label
    Friend WithEvents lbDelalTahsil As Label
    Friend WithEvents lbDelalDogum As Label
    Friend WithEvents lbDelalMemleket As Label
    Friend WithEvents lbDelalTc As Label
    Friend WithEvents lbDelalYas As Label
    Friend WithEvents lbDelalSoyad As Label
    Friend WithEvents lbDelalAd As Label
    Friend WithEvents pbDelal As PictureBox
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents gbDelalFirma As GroupBox
    Friend WithEvents btnDelalMail As Button
    Friend WithEvents btnDelalTel As Button
    Friend WithEvents btnDelalBanka As Button
    Friend WithEvents txtDelalPara As ComboBox
    Friend WithEvents txtDelalPozisyon As TextBox
    Friend WithEvents lbDelalPozisyon As Label
    Friend WithEvents lbDelalNokGunSay As Label
    Friend WithEvents lbDelalNoksanGun As Label
    Friend WithEvents dtpDelalMaas As DateTimePicker
    Friend WithEvents lbDelalOdeme As Label
    Friend WithEvents clbDelalTatil As CheckedListBox
    Friend WithEvents lbDelalTatil As Label
    Friend WithEvents lbDelalMaas As Label
    Friend WithEvents txtDelalMaas As TextBox
    Friend WithEvents cbDelalMedeni As ComboBox
    Friend WithEvents lbDelalMedeni As Label
    Friend WithEvents btnDelalKaydet1 As Button
    Friend WithEvents btnDelalKaydet2 As Button
End Class
