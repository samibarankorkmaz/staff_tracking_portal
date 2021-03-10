<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmAnasayfa
    Inherits System.Windows.Forms.Form

    'Form, bileşen listesini temizlemeyi bırakmayı geçersiz kılar.
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

    'Windows Form Tasarımcısı tarafından gerektirilir
    Private components As System.ComponentModel.IContainer

    'NOT: Aşağıdaki yordam Windows Form Tasarımcısı için gereklidir
    'Windows Form Tasarımcısı kullanılarak değiştirilebilir.  
    'Kod düzenleyicisini kullanarak değiştirmeyin.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAnasayfa))
        Me.imglistAnasayfa = New System.Windows.Forms.ImageList(Me.components)
        Me.btnAyrilan = New System.Windows.Forms.Button()
        Me.cbPersonel = New System.Windows.Forms.ComboBox()
        Me.cmsAnasayfa = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ofdAnasayfa = New System.Windows.Forms.OpenFileDialog()
        Me.gbBossKisisel = New System.Windows.Forms.GroupBox()
        Me.txtBossTc = New System.Windows.Forms.TextBox()
        Me.mtbBossTarih = New System.Windows.Forms.MaskedTextBox()
        Me.cbBossTahsil = New System.Windows.Forms.ComboBox()
        Me.cbBossDogum = New System.Windows.Forms.ComboBox()
        Me.cbBossMemleket = New System.Windows.Forms.ComboBox()
        Me.rtbBossAdres = New System.Windows.Forms.RichTextBox()
        Me.txtBossYas = New System.Windows.Forms.TextBox()
        Me.txtBossSoyad = New System.Windows.Forms.TextBox()
        Me.txtBossAd = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.lbBossAdres = New System.Windows.Forms.Label()
        Me.lbBossTahsil = New System.Windows.Forms.Label()
        Me.lbBossDogum = New System.Windows.Forms.Label()
        Me.lbBossMemleket = New System.Windows.Forms.Label()
        Me.lbBossTc = New System.Windows.Forms.Label()
        Me.lbBossYas = New System.Windows.Forms.Label()
        Me.lbBossSoyad = New System.Windows.Forms.Label()
        Me.lbBossAd = New System.Windows.Forms.Label()
        Me.pbBoss = New System.Windows.Forms.PictureBox()
        Me.tabcBoss = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.gbBossFirma = New System.Windows.Forms.GroupBox()
        Me.btnBossMail = New System.Windows.Forms.Button()
        Me.btnBossTel = New System.Windows.Forms.Button()
        Me.btnBossBanka = New System.Windows.Forms.Button()
        Me.cbBossPara = New System.Windows.Forms.ComboBox()
        Me.txtBossCiro = New System.Windows.Forms.TextBox()
        Me.lbBossCiro = New System.Windows.Forms.Label()
        Me.txtBossPozisyon = New System.Windows.Forms.TextBox()
        Me.lbBossPozisyon = New System.Windows.Forms.Label()
        Me.btnMesai = New System.Windows.Forms.Button()
        Me.btnPerIzin = New System.Windows.Forms.Button()
        Me.btnPerMaas = New System.Windows.Forms.Button()
        Me.gbSubeOzel = New System.Windows.Forms.GroupBox()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.gbSubeBil = New System.Windows.Forms.GroupBox()
        Me.rtbSubeAdres = New System.Windows.Forms.RichTextBox()
        Me.txtMekanKonum = New System.Windows.Forms.TextBox()
        Me.txtMekanAd = New System.Windows.Forms.TextBox()
        Me.lbSubeAdres = New System.Windows.Forms.Label()
        Me.lbSubeTel = New System.Windows.Forms.Label()
        Me.mtbSubeTel = New System.Windows.Forms.MaskedTextBox()
        Me.lbSubeAd = New System.Windows.Forms.Label()
        Me.lbFirma = New System.Windows.Forms.Label()
        Me.gbSubeCalisan = New System.Windows.Forms.GroupBox()
        Me.txtCal8 = New System.Windows.Forms.TextBox()
        Me.txtCal7 = New System.Windows.Forms.TextBox()
        Me.txtCal6 = New System.Windows.Forms.TextBox()
        Me.txtCal5 = New System.Windows.Forms.TextBox()
        Me.txtCal4 = New System.Windows.Forms.TextBox()
        Me.txtCal3 = New System.Windows.Forms.TextBox()
        Me.txtCal2 = New System.Windows.Forms.TextBox()
        Me.txtCal1 = New System.Windows.Forms.TextBox()
        Me.lbCalisanlar7 = New System.Windows.Forms.Label()
        Me.lbCalisanlar4 = New System.Windows.Forms.Label()
        Me.lbCalisanlar6 = New System.Windows.Forms.Label()
        Me.lbCalisanlar5 = New System.Windows.Forms.Label()
        Me.lbCalisanlar1 = New System.Windows.Forms.Label()
        Me.lbCalisanlar2 = New System.Windows.Forms.Label()
        Me.lbCalisanlar3 = New System.Windows.Forms.Label()
        Me.lbCalisanlar8 = New System.Windows.Forms.Label()
        Me.btnPerKayit = New System.Windows.Forms.Button()
        Me.btnEksEleman = New System.Windows.Forms.Button()
        Me.btnKalanMaas = New System.Windows.Forms.Button()
        Me.gbAnasayfa = New System.Windows.Forms.GroupBox()
        Me.mcalAnasayfa = New System.Windows.Forms.MonthCalendar()
        Me.timerAnasayfa = New System.Windows.Forms.Timer(Me.components)
        Me.tsNavigator = New System.Windows.Forms.ToolStrip()
        Me.tsbuttonExit = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator8 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbuttonSettings = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbuttonBirthday = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbuttonDonation = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbuttonFeedback = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbuttonInsta = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbuttonFbook = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbuttonTwitter = New System.Windows.Forms.ToolStripButton()
        Me.cmsAnasayfa.SuspendLayout()
        Me.gbBossKisisel.SuspendLayout()
        CType(Me.pbBoss, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabcBoss.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.gbBossFirma.SuspendLayout()
        Me.gbSubeOzel.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.gbSubeBil.SuspendLayout()
        Me.gbSubeCalisan.SuspendLayout()
        Me.gbAnasayfa.SuspendLayout()
        Me.tsNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'imglistAnasayfa
        '
        Me.imglistAnasayfa.ImageStream = CType(resources.GetObject("imglistAnasayfa.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imglistAnasayfa.TransparentColor = System.Drawing.Color.Transparent
        Me.imglistAnasayfa.Images.SetKeyName(0, "birthday.png")
        Me.imglistAnasayfa.Images.SetKeyName(1, "donate.png")
        Me.imglistAnasayfa.Images.SetKeyName(2, "exit.png")
        Me.imglistAnasayfa.Images.SetKeyName(3, "facebook.png")
        Me.imglistAnasayfa.Images.SetKeyName(4, "feedback.png")
        Me.imglistAnasayfa.Images.SetKeyName(5, "instagram.png")
        Me.imglistAnasayfa.Images.SetKeyName(6, "settings.png")
        Me.imglistAnasayfa.Images.SetKeyName(7, "twitter.png")
        Me.imglistAnasayfa.Images.SetKeyName(8, "dsfsdfds.jpg")
        '
        'btnAyrilan
        '
        Me.btnAyrilan.BackColor = System.Drawing.Color.PowderBlue
        Me.btnAyrilan.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAyrilan.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAyrilan.Location = New System.Drawing.Point(6, 76)
        Me.btnAyrilan.Name = "btnAyrilan"
        Me.btnAyrilan.Size = New System.Drawing.Size(156, 48)
        Me.btnAyrilan.TabIndex = 5
        Me.btnAyrilan.Text = "İşten Ayrılanlar"
        Me.btnAyrilan.UseVisualStyleBackColor = False
        '
        'cbPersonel
        '
        Me.cbPersonel.AccessibleDescription = ""
        Me.cbPersonel.BackColor = System.Drawing.Color.PowderBlue
        Me.cbPersonel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cbPersonel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.cbPersonel.FormattingEnabled = True
        Me.cbPersonel.Items.AddRange(New Object() {"Delal Abdüllatif Abzak", "Fatma Özlem Acar", "Özde Acarkan", "Mükerrem Zeynep Ağca", "Bestami Ağırağaç"})
        Me.cbPersonel.Location = New System.Drawing.Point(6, 28)
        Me.cbPersonel.MaxDropDownItems = 100
        Me.cbPersonel.Name = "cbPersonel"
        Me.cbPersonel.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cbPersonel.Size = New System.Drawing.Size(156, 28)
        Me.cbPersonel.TabIndex = 6
        Me.cbPersonel.Text = "Personeller"
        '
        'cmsAnasayfa
        '
        Me.cmsAnasayfa.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.ToolStripMenuItem2})
        Me.cmsAnasayfa.Name = "ContextMenuStrip1"
        Me.cmsAnasayfa.Size = New System.Drawing.Size(115, 48)
        Me.cmsAnasayfa.Text = "Seçenekler"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(114, 22)
        Me.ToolStripMenuItem1.Text = "Değiştir"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(114, 22)
        Me.ToolStripMenuItem2.Text = "Kaldır"
        '
        'ofdAnasayfa
        '
        Me.ofdAnasayfa.FileName = "OpenFileDialog1"
        '
        'gbBossKisisel
        '
        Me.gbBossKisisel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbBossKisisel.BackColor = System.Drawing.SystemColors.ControlDark
        Me.gbBossKisisel.BackgroundImage = CType(resources.GetObject("gbBossKisisel.BackgroundImage"), System.Drawing.Image)
        Me.gbBossKisisel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.gbBossKisisel.Controls.Add(Me.txtBossTc)
        Me.gbBossKisisel.Controls.Add(Me.mtbBossTarih)
        Me.gbBossKisisel.Controls.Add(Me.cbBossTahsil)
        Me.gbBossKisisel.Controls.Add(Me.cbBossDogum)
        Me.gbBossKisisel.Controls.Add(Me.cbBossMemleket)
        Me.gbBossKisisel.Controls.Add(Me.rtbBossAdres)
        Me.gbBossKisisel.Controls.Add(Me.txtBossYas)
        Me.gbBossKisisel.Controls.Add(Me.txtBossSoyad)
        Me.gbBossKisisel.Controls.Add(Me.txtBossAd)
        Me.gbBossKisisel.Controls.Add(Me.Label13)
        Me.gbBossKisisel.Controls.Add(Me.lbBossAdres)
        Me.gbBossKisisel.Controls.Add(Me.lbBossTahsil)
        Me.gbBossKisisel.Controls.Add(Me.lbBossDogum)
        Me.gbBossKisisel.Controls.Add(Me.lbBossMemleket)
        Me.gbBossKisisel.Controls.Add(Me.lbBossTc)
        Me.gbBossKisisel.Controls.Add(Me.lbBossYas)
        Me.gbBossKisisel.Controls.Add(Me.lbBossSoyad)
        Me.gbBossKisisel.Controls.Add(Me.lbBossAd)
        Me.gbBossKisisel.Controls.Add(Me.pbBoss)
        Me.gbBossKisisel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.gbBossKisisel.ForeColor = System.Drawing.SystemColors.MenuText
        Me.gbBossKisisel.Location = New System.Drawing.Point(1, 0)
        Me.gbBossKisisel.Name = "gbBossKisisel"
        Me.gbBossKisisel.Size = New System.Drawing.Size(407, 463)
        Me.gbBossKisisel.TabIndex = 9
        Me.gbBossKisisel.TabStop = False
        Me.gbBossKisisel.Text = "Baran Korkmaz | TheBoss"
        '
        'txtBossTc
        '
        Me.txtBossTc.BackColor = System.Drawing.Color.PowderBlue
        Me.txtBossTc.Location = New System.Drawing.Point(264, 140)
        Me.txtBossTc.Name = "txtBossTc"
        Me.txtBossTc.ReadOnly = True
        Me.txtBossTc.Size = New System.Drawing.Size(100, 22)
        Me.txtBossTc.TabIndex = 27
        Me.txtBossTc.Text = "3.................6"
        Me.txtBossTc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'mtbBossTarih
        '
        Me.mtbBossTarih.BackColor = System.Drawing.Color.PowderBlue
        Me.mtbBossTarih.Location = New System.Drawing.Point(271, 246)
        Me.mtbBossTarih.Mask = "00/00/0000"
        Me.mtbBossTarih.Name = "mtbBossTarih"
        Me.mtbBossTarih.ReadOnly = True
        Me.mtbBossTarih.Size = New System.Drawing.Size(121, 22)
        Me.mtbBossTarih.TabIndex = 26
        Me.mtbBossTarih.Text = "27031997"
        Me.mtbBossTarih.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.mtbBossTarih.ValidatingType = GetType(Date)
        '
        'cbBossTahsil
        '
        Me.cbBossTahsil.BackColor = System.Drawing.Color.PowderBlue
        Me.cbBossTahsil.Enabled = False
        Me.cbBossTahsil.FormattingEnabled = True
        Me.cbBossTahsil.Items.AddRange(New Object() {"İlkokul", "Ortaokul", "Lise", "Üniversite", "Yüksek Lisans", "Okumamış"})
        Me.cbBossTahsil.Location = New System.Drawing.Point(144, 296)
        Me.cbBossTahsil.Name = "cbBossTahsil"
        Me.cbBossTahsil.Size = New System.Drawing.Size(121, 24)
        Me.cbBossTahsil.TabIndex = 25
        Me.cbBossTahsil.Text = "Üniversite"
        '
        'cbBossDogum
        '
        Me.cbBossDogum.BackColor = System.Drawing.Color.PowderBlue
        Me.cbBossDogum.Enabled = False
        Me.cbBossDogum.FormattingEnabled = True
        Me.cbBossDogum.Location = New System.Drawing.Point(144, 245)
        Me.cbBossDogum.Name = "cbBossDogum"
        Me.cbBossDogum.Size = New System.Drawing.Size(121, 24)
        Me.cbBossDogum.TabIndex = 24
        Me.cbBossDogum.Text = "Ankara"
        '
        'cbBossMemleket
        '
        Me.cbBossMemleket.BackColor = System.Drawing.Color.PowderBlue
        Me.cbBossMemleket.Enabled = False
        Me.cbBossMemleket.FormattingEnabled = True
        Me.cbBossMemleket.Location = New System.Drawing.Point(144, 197)
        Me.cbBossMemleket.Name = "cbBossMemleket"
        Me.cbBossMemleket.Size = New System.Drawing.Size(121, 24)
        Me.cbBossMemleket.TabIndex = 23
        Me.cbBossMemleket.Text = "Sivas"
        '
        'rtbBossAdres
        '
        Me.rtbBossAdres.BackColor = System.Drawing.Color.PowderBlue
        Me.rtbBossAdres.Location = New System.Drawing.Point(144, 342)
        Me.rtbBossAdres.Name = "rtbBossAdres"
        Me.rtbBossAdres.ReadOnly = True
        Me.rtbBossAdres.Size = New System.Drawing.Size(220, 104)
        Me.rtbBossAdres.TabIndex = 22
        Me.rtbBossAdres.Text = "75.Yıl Cd. ....................... Antalya"
        '
        'txtBossYas
        '
        Me.txtBossYas.BackColor = System.Drawing.Color.PowderBlue
        Me.txtBossYas.Location = New System.Drawing.Point(264, 105)
        Me.txtBossYas.Name = "txtBossYas"
        Me.txtBossYas.ReadOnly = True
        Me.txtBossYas.Size = New System.Drawing.Size(100, 22)
        Me.txtBossYas.TabIndex = 17
        Me.txtBossYas.Text = "21"
        Me.txtBossYas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtBossSoyad
        '
        Me.txtBossSoyad.BackColor = System.Drawing.Color.PowderBlue
        Me.txtBossSoyad.Location = New System.Drawing.Point(264, 66)
        Me.txtBossSoyad.Name = "txtBossSoyad"
        Me.txtBossSoyad.ReadOnly = True
        Me.txtBossSoyad.Size = New System.Drawing.Size(100, 22)
        Me.txtBossSoyad.TabIndex = 16
        Me.txtBossSoyad.Text = "Korkmaz"
        Me.txtBossSoyad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtBossAd
        '
        Me.txtBossAd.BackColor = System.Drawing.Color.PowderBlue
        Me.txtBossAd.Location = New System.Drawing.Point(264, 28)
        Me.txtBossAd.Name = "txtBossAd"
        Me.txtBossAd.ReadOnly = True
        Me.txtBossAd.Size = New System.Drawing.Size(100, 22)
        Me.txtBossAd.TabIndex = 15
        Me.txtBossAd.Text = "Sami Baran"
        Me.txtBossAd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
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
        Me.Label13.Size = New System.Drawing.Size(407, 0)
        Me.Label13.TabIndex = 14
        Me.Label13.Text = "Label13"
        '
        'lbBossAdres
        '
        Me.lbBossAdres.AutoSize = True
        Me.lbBossAdres.BackColor = System.Drawing.Color.PowderBlue
        Me.lbBossAdres.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lbBossAdres.ForeColor = System.Drawing.SystemColors.InfoText
        Me.lbBossAdres.Location = New System.Drawing.Point(31, 345)
        Me.lbBossAdres.Name = "lbBossAdres"
        Me.lbBossAdres.Size = New System.Drawing.Size(65, 20)
        Me.lbBossAdres.TabIndex = 9
        Me.lbBossAdres.Text = "Adresi:"
        '
        'lbBossTahsil
        '
        Me.lbBossTahsil.AutoSize = True
        Me.lbBossTahsil.BackColor = System.Drawing.Color.PowderBlue
        Me.lbBossTahsil.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lbBossTahsil.ForeColor = System.Drawing.SystemColors.InfoText
        Me.lbBossTahsil.Location = New System.Drawing.Point(31, 299)
        Me.lbBossTahsil.Name = "lbBossTahsil"
        Me.lbBossTahsil.Size = New System.Drawing.Size(129, 20)
        Me.lbBossTahsil.TabIndex = 8
        Me.lbBossTahsil.Text = "Tahsil Durumu:"
        '
        'lbBossDogum
        '
        Me.lbBossDogum.AutoSize = True
        Me.lbBossDogum.BackColor = System.Drawing.Color.PowderBlue
        Me.lbBossDogum.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lbBossDogum.ForeColor = System.Drawing.SystemColors.InfoText
        Me.lbBossDogum.Location = New System.Drawing.Point(3, 249)
        Me.lbBossDogum.Name = "lbBossDogum"
        Me.lbBossDogum.Size = New System.Drawing.Size(162, 20)
        Me.lbBossDogum.TabIndex = 7
        Me.lbBossDogum.Text = "Doğum Yeri/ Tarihi:"
        '
        'lbBossMemleket
        '
        Me.lbBossMemleket.AutoSize = True
        Me.lbBossMemleket.BackColor = System.Drawing.Color.PowderBlue
        Me.lbBossMemleket.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lbBossMemleket.ForeColor = System.Drawing.SystemColors.InfoText
        Me.lbBossMemleket.Location = New System.Drawing.Point(31, 200)
        Me.lbBossMemleket.Name = "lbBossMemleket"
        Me.lbBossMemleket.Size = New System.Drawing.Size(95, 20)
        Me.lbBossMemleket.TabIndex = 6
        Me.lbBossMemleket.Text = "Memleketi:"
        '
        'lbBossTc
        '
        Me.lbBossTc.AutoSize = True
        Me.lbBossTc.BackColor = System.Drawing.Color.PowderBlue
        Me.lbBossTc.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lbBossTc.ForeColor = System.Drawing.SystemColors.InfoText
        Me.lbBossTc.Location = New System.Drawing.Point(164, 140)
        Me.lbBossTc.Name = "lbBossTc"
        Me.lbBossTc.Size = New System.Drawing.Size(114, 20)
        Me.lbBossTc.TabIndex = 5
        Me.lbBossTc.Text = "TC Kimlik No:"
        '
        'lbBossYas
        '
        Me.lbBossYas.AutoSize = True
        Me.lbBossYas.BackColor = System.Drawing.Color.PowderBlue
        Me.lbBossYas.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lbBossYas.ForeColor = System.Drawing.SystemColors.InfoText
        Me.lbBossYas.Location = New System.Drawing.Point(164, 108)
        Me.lbBossYas.Name = "lbBossYas"
        Me.lbBossYas.Size = New System.Drawing.Size(45, 20)
        Me.lbBossYas.TabIndex = 4
        Me.lbBossYas.Text = "Yaş:"
        '
        'lbBossSoyad
        '
        Me.lbBossSoyad.AutoSize = True
        Me.lbBossSoyad.BackColor = System.Drawing.Color.PowderBlue
        Me.lbBossSoyad.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lbBossSoyad.ForeColor = System.Drawing.SystemColors.InfoText
        Me.lbBossSoyad.Location = New System.Drawing.Point(164, 69)
        Me.lbBossSoyad.Name = "lbBossSoyad"
        Me.lbBossSoyad.Size = New System.Drawing.Size(68, 20)
        Me.lbBossSoyad.TabIndex = 3
        Me.lbBossSoyad.Text = "Soyadı:"
        '
        'lbBossAd
        '
        Me.lbBossAd.AutoSize = True
        Me.lbBossAd.BackColor = System.Drawing.Color.PowderBlue
        Me.lbBossAd.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lbBossAd.ForeColor = System.Drawing.SystemColors.InfoText
        Me.lbBossAd.Location = New System.Drawing.Point(164, 33)
        Me.lbBossAd.Name = "lbBossAd"
        Me.lbBossAd.Size = New System.Drawing.Size(40, 20)
        Me.lbBossAd.TabIndex = 2
        Me.lbBossAd.Text = "Adı:"
        '
        'pbBoss
        '
        Me.pbBoss.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pbBoss.BackColor = System.Drawing.Color.PowderBlue
        Me.pbBoss.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.pbBoss.ContextMenuStrip = Me.cmsAnasayfa
        Me.pbBoss.Cursor = System.Windows.Forms.Cursors.Default
        Me.pbBoss.Image = CType(resources.GetObject("pbBoss.Image"), System.Drawing.Image)
        Me.pbBoss.Location = New System.Drawing.Point(0, 19)
        Me.pbBoss.Name = "pbBoss"
        Me.pbBoss.Size = New System.Drawing.Size(158, 146)
        Me.pbBoss.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbBoss.TabIndex = 1
        Me.pbBoss.TabStop = False
        '
        'tabcBoss
        '
        Me.tabcBoss.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tabcBoss.Appearance = System.Windows.Forms.TabAppearance.FlatButtons
        Me.tabcBoss.Controls.Add(Me.TabPage1)
        Me.tabcBoss.Controls.Add(Me.TabPage2)
        Me.tabcBoss.Location = New System.Drawing.Point(-4, 42)
        Me.tabcBoss.Name = "tabcBoss"
        Me.tabcBoss.SelectedIndex = 0
        Me.tabcBoss.Size = New System.Drawing.Size(415, 491)
        Me.tabcBoss.TabIndex = 10
        Me.tabcBoss.Tag = ""
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.gbBossKisisel)
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(407, 462)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Kişisel Bilgiler"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.gbBossFirma)
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(407, 462)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Firma Bilgileri"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'gbBossFirma
        '
        Me.gbBossFirma.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbBossFirma.BackColor = System.Drawing.SystemColors.ControlDark
        Me.gbBossFirma.BackgroundImage = CType(resources.GetObject("gbBossFirma.BackgroundImage"), System.Drawing.Image)
        Me.gbBossFirma.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.gbBossFirma.Controls.Add(Me.btnBossMail)
        Me.gbBossFirma.Controls.Add(Me.btnBossTel)
        Me.gbBossFirma.Controls.Add(Me.btnBossBanka)
        Me.gbBossFirma.Controls.Add(Me.cbBossPara)
        Me.gbBossFirma.Controls.Add(Me.txtBossCiro)
        Me.gbBossFirma.Controls.Add(Me.lbBossCiro)
        Me.gbBossFirma.Controls.Add(Me.txtBossPozisyon)
        Me.gbBossFirma.Controls.Add(Me.lbBossPozisyon)
        Me.gbBossFirma.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.gbBossFirma.Location = New System.Drawing.Point(0, 0)
        Me.gbBossFirma.Name = "gbBossFirma"
        Me.gbBossFirma.Size = New System.Drawing.Size(407, 859)
        Me.gbBossFirma.TabIndex = 0
        Me.gbBossFirma.TabStop = False
        Me.gbBossFirma.Text = "Baran Korkmaz | TheBoss"
        '
        'btnBossMail
        '
        Me.btnBossMail.BackColor = System.Drawing.Color.PowderBlue
        Me.btnBossMail.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnBossMail.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnBossMail.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btnBossMail.Location = New System.Drawing.Point(27, 350)
        Me.btnBossMail.Name = "btnBossMail"
        Me.btnBossMail.Size = New System.Drawing.Size(349, 51)
        Me.btnBossMail.TabIndex = 8
        Me.btnBossMail.Text = "E-mail "
        Me.btnBossMail.UseVisualStyleBackColor = False
        '
        'btnBossTel
        '
        Me.btnBossTel.BackColor = System.Drawing.Color.PowderBlue
        Me.btnBossTel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnBossTel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnBossTel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btnBossTel.Location = New System.Drawing.Point(27, 261)
        Me.btnBossTel.Name = "btnBossTel"
        Me.btnBossTel.Size = New System.Drawing.Size(349, 51)
        Me.btnBossTel.TabIndex = 7
        Me.btnBossTel.Text = "Telefon"
        Me.btnBossTel.UseVisualStyleBackColor = False
        '
        'btnBossBanka
        '
        Me.btnBossBanka.BackColor = System.Drawing.Color.PowderBlue
        Me.btnBossBanka.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnBossBanka.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnBossBanka.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btnBossBanka.Location = New System.Drawing.Point(27, 173)
        Me.btnBossBanka.Name = "btnBossBanka"
        Me.btnBossBanka.Size = New System.Drawing.Size(349, 51)
        Me.btnBossBanka.TabIndex = 6
        Me.btnBossBanka.Text = "Banka Bilgileri"
        Me.btnBossBanka.UseVisualStyleBackColor = False
        '
        'cbBossPara
        '
        Me.cbBossPara.BackColor = System.Drawing.Color.PowderBlue
        Me.cbBossPara.FormattingEnabled = True
        Me.cbBossPara.Items.AddRange(New Object() {"₺", "€", "$", "£", "KWD"})
        Me.cbBossPara.Location = New System.Drawing.Point(327, 99)
        Me.cbBossPara.Name = "cbBossPara"
        Me.cbBossPara.Size = New System.Drawing.Size(49, 24)
        Me.cbBossPara.TabIndex = 5
        '
        'txtBossCiro
        '
        Me.txtBossCiro.BackColor = System.Drawing.Color.PowderBlue
        Me.txtBossCiro.ContextMenuStrip = Me.cmsAnasayfa
        Me.txtBossCiro.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txtBossCiro.Location = New System.Drawing.Point(213, 101)
        Me.txtBossCiro.Name = "txtBossCiro"
        Me.txtBossCiro.Size = New System.Drawing.Size(108, 22)
        Me.txtBossCiro.TabIndex = 4
        Me.txtBossCiro.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lbBossCiro
        '
        Me.lbBossCiro.AutoSize = True
        Me.lbBossCiro.BackColor = System.Drawing.Color.PowderBlue
        Me.lbBossCiro.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lbBossCiro.Location = New System.Drawing.Point(61, 101)
        Me.lbBossCiro.Name = "lbBossCiro"
        Me.lbBossCiro.Size = New System.Drawing.Size(85, 20)
        Me.lbBossCiro.TabIndex = 3
        Me.lbBossCiro.Text = "Ciro (ort):"
        '
        'txtBossPozisyon
        '
        Me.txtBossPozisyon.BackColor = System.Drawing.Color.PowderBlue
        Me.txtBossPozisyon.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txtBossPozisyon.Location = New System.Drawing.Point(213, 36)
        Me.txtBossPozisyon.Name = "txtBossPozisyon"
        Me.txtBossPozisyon.ReadOnly = True
        Me.txtBossPozisyon.Size = New System.Drawing.Size(163, 26)
        Me.txtBossPozisyon.TabIndex = 2
        Me.txtBossPozisyon.Text = "İşveren"
        Me.txtBossPozisyon.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lbBossPozisyon
        '
        Me.lbBossPozisyon.BackColor = System.Drawing.Color.PowderBlue
        Me.lbBossPozisyon.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lbBossPozisyon.Location = New System.Drawing.Point(23, 30)
        Me.lbBossPozisyon.Name = "lbBossPozisyon"
        Me.lbBossPozisyon.Size = New System.Drawing.Size(162, 39)
        Me.lbBossPozisyon.TabIndex = 1
        Me.lbBossPozisyon.Text = "İşyerindeki Konumu:"
        Me.lbBossPozisyon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnMesai
        '
        Me.btnMesai.BackColor = System.Drawing.Color.PowderBlue
        Me.btnMesai.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnMesai.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMesai.Location = New System.Drawing.Point(6, 273)
        Me.btnMesai.Name = "btnMesai"
        Me.btnMesai.Size = New System.Drawing.Size(156, 48)
        Me.btnMesai.TabIndex = 11
        Me.btnMesai.Text = "Mesai İşlemleri"
        Me.btnMesai.UseVisualStyleBackColor = False
        '
        'btnPerIzin
        '
        Me.btnPerIzin.BackColor = System.Drawing.Color.PowderBlue
        Me.btnPerIzin.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnPerIzin.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPerIzin.Location = New System.Drawing.Point(6, 223)
        Me.btnPerIzin.Name = "btnPerIzin"
        Me.btnPerIzin.Size = New System.Drawing.Size(156, 48)
        Me.btnPerIzin.TabIndex = 12
        Me.btnPerIzin.Text = "İzin İşlemleri"
        Me.btnPerIzin.UseVisualStyleBackColor = False
        '
        'btnPerMaas
        '
        Me.btnPerMaas.BackColor = System.Drawing.Color.PowderBlue
        Me.btnPerMaas.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnPerMaas.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPerMaas.Location = New System.Drawing.Point(6, 174)
        Me.btnPerMaas.Name = "btnPerMaas"
        Me.btnPerMaas.Size = New System.Drawing.Size(156, 48)
        Me.btnPerMaas.TabIndex = 13
        Me.btnPerMaas.Text = "Personel Maaşı Hesapla"
        Me.btnPerMaas.UseVisualStyleBackColor = False
        '
        'gbSubeOzel
        '
        Me.gbSubeOzel.BackColor = System.Drawing.SystemColors.ControlDark
        Me.gbSubeOzel.BackgroundImage = CType(resources.GetObject("gbSubeOzel.BackgroundImage"), System.Drawing.Image)
        Me.gbSubeOzel.Controls.Add(Me.SplitContainer1)
        Me.gbSubeOzel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.gbSubeOzel.Location = New System.Drawing.Point(877, 66)
        Me.gbSubeOzel.Name = "gbSubeOzel"
        Me.gbSubeOzel.Size = New System.Drawing.Size(407, 467)
        Me.gbSubeOzel.TabIndex = 14
        Me.gbSubeOzel.TabStop = False
        Me.gbSubeOzel.Text = "Kültür Şube Özel"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(3, 18)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.gbSubeBil)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.gbSubeCalisan)
        Me.SplitContainer1.Size = New System.Drawing.Size(401, 446)
        Me.SplitContainer1.SplitterDistance = 200
        Me.SplitContainer1.TabIndex = 0
        '
        'gbSubeBil
        '
        Me.gbSubeBil.BackColor = System.Drawing.SystemColors.ControlDark
        Me.gbSubeBil.BackgroundImage = CType(resources.GetObject("gbSubeBil.BackgroundImage"), System.Drawing.Image)
        Me.gbSubeBil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.gbSubeBil.Controls.Add(Me.rtbSubeAdres)
        Me.gbSubeBil.Controls.Add(Me.txtMekanKonum)
        Me.gbSubeBil.Controls.Add(Me.txtMekanAd)
        Me.gbSubeBil.Controls.Add(Me.lbSubeAdres)
        Me.gbSubeBil.Controls.Add(Me.lbSubeTel)
        Me.gbSubeBil.Controls.Add(Me.mtbSubeTel)
        Me.gbSubeBil.Controls.Add(Me.lbSubeAd)
        Me.gbSubeBil.Controls.Add(Me.lbFirma)
        Me.gbSubeBil.Location = New System.Drawing.Point(0, 0)
        Me.gbSubeBil.Name = "gbSubeBil"
        Me.gbSubeBil.Size = New System.Drawing.Size(200, 454)
        Me.gbSubeBil.TabIndex = 0
        Me.gbSubeBil.TabStop = False
        Me.gbSubeBil.Text = "Şube Bilgileri"
        '
        'rtbSubeAdres
        '
        Me.rtbSubeAdres.BackColor = System.Drawing.Color.PowderBlue
        Me.rtbSubeAdres.Location = New System.Drawing.Point(19, 262)
        Me.rtbSubeAdres.Name = "rtbSubeAdres"
        Me.rtbSubeAdres.Size = New System.Drawing.Size(173, 121)
        Me.rtbSubeAdres.TabIndex = 9
        Me.rtbSubeAdres.Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit."
        '
        'txtMekanKonum
        '
        Me.txtMekanKonum.BackColor = System.Drawing.Color.PowderBlue
        Me.txtMekanKonum.Location = New System.Drawing.Point(94, 96)
        Me.txtMekanKonum.Name = "txtMekanKonum"
        Me.txtMekanKonum.ReadOnly = True
        Me.txtMekanKonum.Size = New System.Drawing.Size(100, 22)
        Me.txtMekanKonum.TabIndex = 8
        Me.txtMekanKonum.Text = "Kültür"
        Me.txtMekanKonum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtMekanAd
        '
        Me.txtMekanAd.BackColor = System.Drawing.Color.PowderBlue
        Me.txtMekanAd.Location = New System.Drawing.Point(94, 37)
        Me.txtMekanAd.Name = "txtMekanAd"
        Me.txtMekanAd.ReadOnly = True
        Me.txtMekanAd.Size = New System.Drawing.Size(100, 22)
        Me.txtMekanAd.TabIndex = 6
        Me.txtMekanAd.Text = "Köfteci Ramsey"
        Me.txtMekanAd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lbSubeAdres
        '
        Me.lbSubeAdres.AutoSize = True
        Me.lbSubeAdres.BackColor = System.Drawing.Color.PowderBlue
        Me.lbSubeAdres.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lbSubeAdres.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lbSubeAdres.Location = New System.Drawing.Point(16, 233)
        Me.lbSubeAdres.Name = "lbSubeAdres"
        Me.lbSubeAdres.Size = New System.Drawing.Size(53, 16)
        Me.lbSubeAdres.TabIndex = 3
        Me.lbSubeAdres.Text = "Adres:"
        '
        'lbSubeTel
        '
        Me.lbSubeTel.AutoSize = True
        Me.lbSubeTel.BackColor = System.Drawing.Color.PowderBlue
        Me.lbSubeTel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lbSubeTel.Location = New System.Drawing.Point(16, 167)
        Me.lbSubeTel.Name = "lbSubeTel"
        Me.lbSubeTel.Size = New System.Drawing.Size(113, 16)
        Me.lbSubeTel.TabIndex = 2
        Me.lbSubeTel.Text = "Şube Telefonu:"
        '
        'mtbSubeTel
        '
        Me.mtbSubeTel.BackColor = System.Drawing.Color.PowderBlue
        Me.mtbSubeTel.Location = New System.Drawing.Point(108, 166)
        Me.mtbSubeTel.Mask = "(999) 000-0000"
        Me.mtbSubeTel.Name = "mtbSubeTel"
        Me.mtbSubeTel.ReadOnly = True
        Me.mtbSubeTel.Size = New System.Drawing.Size(84, 22)
        Me.mtbSubeTel.TabIndex = 5
        Me.mtbSubeTel.Text = "5555555555"
        '
        'lbSubeAd
        '
        Me.lbSubeAd.AutoSize = True
        Me.lbSubeAd.BackColor = System.Drawing.Color.PowderBlue
        Me.lbSubeAd.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lbSubeAd.Location = New System.Drawing.Point(16, 96)
        Me.lbSubeAd.Name = "lbSubeAd"
        Me.lbSubeAd.Size = New System.Drawing.Size(75, 16)
        Me.lbSubeAd.TabIndex = 1
        Me.lbSubeAd.Text = "Şube Adı:"
        '
        'lbFirma
        '
        Me.lbFirma.AutoSize = True
        Me.lbFirma.BackColor = System.Drawing.Color.PowderBlue
        Me.lbFirma.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lbFirma.Location = New System.Drawing.Point(16, 40)
        Me.lbFirma.Name = "lbFirma"
        Me.lbFirma.Size = New System.Drawing.Size(51, 16)
        Me.lbFirma.TabIndex = 0
        Me.lbFirma.Text = "Firma:"
        '
        'gbSubeCalisan
        '
        Me.gbSubeCalisan.BackgroundImage = CType(resources.GetObject("gbSubeCalisan.BackgroundImage"), System.Drawing.Image)
        Me.gbSubeCalisan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.gbSubeCalisan.Controls.Add(Me.txtCal8)
        Me.gbSubeCalisan.Controls.Add(Me.txtCal7)
        Me.gbSubeCalisan.Controls.Add(Me.txtCal6)
        Me.gbSubeCalisan.Controls.Add(Me.txtCal5)
        Me.gbSubeCalisan.Controls.Add(Me.txtCal4)
        Me.gbSubeCalisan.Controls.Add(Me.txtCal3)
        Me.gbSubeCalisan.Controls.Add(Me.txtCal2)
        Me.gbSubeCalisan.Controls.Add(Me.txtCal1)
        Me.gbSubeCalisan.Controls.Add(Me.lbCalisanlar7)
        Me.gbSubeCalisan.Controls.Add(Me.lbCalisanlar4)
        Me.gbSubeCalisan.Controls.Add(Me.lbCalisanlar6)
        Me.gbSubeCalisan.Controls.Add(Me.lbCalisanlar5)
        Me.gbSubeCalisan.Controls.Add(Me.lbCalisanlar1)
        Me.gbSubeCalisan.Controls.Add(Me.lbCalisanlar2)
        Me.gbSubeCalisan.Controls.Add(Me.lbCalisanlar3)
        Me.gbSubeCalisan.Controls.Add(Me.lbCalisanlar8)
        Me.gbSubeCalisan.Location = New System.Drawing.Point(-4, 0)
        Me.gbSubeCalisan.Name = "gbSubeCalisan"
        Me.gbSubeCalisan.Size = New System.Drawing.Size(204, 458)
        Me.gbSubeCalisan.TabIndex = 1
        Me.gbSubeCalisan.TabStop = False
        Me.gbSubeCalisan.Text = "Çalışanlar"
        '
        'txtCal8
        '
        Me.txtCal8.BackColor = System.Drawing.Color.PowderBlue
        Me.txtCal8.Location = New System.Drawing.Point(146, 320)
        Me.txtCal8.Name = "txtCal8"
        Me.txtCal8.Size = New System.Drawing.Size(42, 22)
        Me.txtCal8.TabIndex = 19
        Me.txtCal8.Text = "7"
        '
        'txtCal7
        '
        Me.txtCal7.BackColor = System.Drawing.Color.PowderBlue
        Me.txtCal7.Location = New System.Drawing.Point(146, 277)
        Me.txtCal7.Name = "txtCal7"
        Me.txtCal7.Size = New System.Drawing.Size(42, 22)
        Me.txtCal7.TabIndex = 18
        Me.txtCal7.Text = "50"
        '
        'txtCal6
        '
        Me.txtCal6.BackColor = System.Drawing.Color.PowderBlue
        Me.txtCal6.Location = New System.Drawing.Point(146, 233)
        Me.txtCal6.Name = "txtCal6"
        Me.txtCal6.Size = New System.Drawing.Size(42, 22)
        Me.txtCal6.TabIndex = 17
        Me.txtCal6.Text = "10"
        '
        'txtCal5
        '
        Me.txtCal5.BackColor = System.Drawing.Color.PowderBlue
        Me.txtCal5.Location = New System.Drawing.Point(146, 193)
        Me.txtCal5.Name = "txtCal5"
        Me.txtCal5.Size = New System.Drawing.Size(42, 22)
        Me.txtCal5.TabIndex = 16
        Me.txtCal5.Text = "10"
        '
        'txtCal4
        '
        Me.txtCal4.BackColor = System.Drawing.Color.PowderBlue
        Me.txtCal4.Location = New System.Drawing.Point(146, 157)
        Me.txtCal4.Name = "txtCal4"
        Me.txtCal4.Size = New System.Drawing.Size(42, 22)
        Me.txtCal4.TabIndex = 15
        Me.txtCal4.Text = "20"
        '
        'txtCal3
        '
        Me.txtCal3.BackColor = System.Drawing.Color.PowderBlue
        Me.txtCal3.Location = New System.Drawing.Point(146, 122)
        Me.txtCal3.Name = "txtCal3"
        Me.txtCal3.Size = New System.Drawing.Size(42, 22)
        Me.txtCal3.TabIndex = 14
        Me.txtCal3.Text = "15"
        '
        'txtCal2
        '
        Me.txtCal2.BackColor = System.Drawing.Color.PowderBlue
        Me.txtCal2.Location = New System.Drawing.Point(146, 86)
        Me.txtCal2.Name = "txtCal2"
        Me.txtCal2.Size = New System.Drawing.Size(42, 22)
        Me.txtCal2.TabIndex = 13
        Me.txtCal2.Text = "5"
        '
        'txtCal1
        '
        Me.txtCal1.BackColor = System.Drawing.Color.PowderBlue
        Me.txtCal1.Location = New System.Drawing.Point(146, 47)
        Me.txtCal1.Name = "txtCal1"
        Me.txtCal1.Size = New System.Drawing.Size(42, 22)
        Me.txtCal1.TabIndex = 12
        Me.txtCal1.Text = "3"
        '
        'lbCalisanlar7
        '
        Me.lbCalisanlar7.AutoSize = True
        Me.lbCalisanlar7.BackColor = System.Drawing.Color.PowderBlue
        Me.lbCalisanlar7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lbCalisanlar7.Location = New System.Drawing.Point(17, 280)
        Me.lbCalisanlar7.Name = "lbCalisanlar7"
        Me.lbCalisanlar7.Size = New System.Drawing.Size(116, 15)
        Me.lbCalisanlar7.TabIndex = 11
        Me.lbCalisanlar7.Text = "Emekli Personel:"
        '
        'lbCalisanlar4
        '
        Me.lbCalisanlar4.AutoSize = True
        Me.lbCalisanlar4.BackColor = System.Drawing.Color.PowderBlue
        Me.lbCalisanlar4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lbCalisanlar4.Location = New System.Drawing.Point(17, 161)
        Me.lbCalisanlar4.Name = "lbCalisanlar4"
        Me.lbCalisanlar4.Size = New System.Drawing.Size(120, 15)
        Me.lbCalisanlar4.TabIndex = 10
        Me.lbCalisanlar4.Text = "Çalışan Personel:"
        '
        'lbCalisanlar6
        '
        Me.lbCalisanlar6.AutoSize = True
        Me.lbCalisanlar6.BackColor = System.Drawing.Color.PowderBlue
        Me.lbCalisanlar6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lbCalisanlar6.Location = New System.Drawing.Point(17, 238)
        Me.lbCalisanlar6.Name = "lbCalisanlar6"
        Me.lbCalisanlar6.Size = New System.Drawing.Size(111, 15)
        Me.lbCalisanlar6.TabIndex = 9
        Me.lbCalisanlar6.Text = "Bayan Personel:"
        '
        'lbCalisanlar5
        '
        Me.lbCalisanlar5.AutoSize = True
        Me.lbCalisanlar5.BackColor = System.Drawing.Color.PowderBlue
        Me.lbCalisanlar5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lbCalisanlar5.Location = New System.Drawing.Point(17, 200)
        Me.lbCalisanlar5.Name = "lbCalisanlar5"
        Me.lbCalisanlar5.Size = New System.Drawing.Size(95, 15)
        Me.lbCalisanlar5.TabIndex = 8
        Me.lbCalisanlar5.Text = "Bay Personel:"
        '
        'lbCalisanlar1
        '
        Me.lbCalisanlar1.BackColor = System.Drawing.Color.PowderBlue
        Me.lbCalisanlar1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lbCalisanlar1.Location = New System.Drawing.Point(17, 50)
        Me.lbCalisanlar1.Name = "lbCalisanlar1"
        Me.lbCalisanlar1.Size = New System.Drawing.Size(171, 21)
        Me.lbCalisanlar1.TabIndex = 4
        Me.lbCalisanlar1.Text = "Ay İçinde İşten Ayrılanlar:"
        '
        'lbCalisanlar2
        '
        Me.lbCalisanlar2.AutoSize = True
        Me.lbCalisanlar2.BackColor = System.Drawing.Color.PowderBlue
        Me.lbCalisanlar2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lbCalisanlar2.Location = New System.Drawing.Point(17, 89)
        Me.lbCalisanlar2.Name = "lbCalisanlar2"
        Me.lbCalisanlar2.Size = New System.Drawing.Size(147, 15)
        Me.lbCalisanlar2.TabIndex = 5
        Me.lbCalisanlar2.Text = "Ay İçinde İşe Girenler:"
        '
        'lbCalisanlar3
        '
        Me.lbCalisanlar3.AutoSize = True
        Me.lbCalisanlar3.BackColor = System.Drawing.Color.PowderBlue
        Me.lbCalisanlar3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lbCalisanlar3.Location = New System.Drawing.Point(17, 127)
        Me.lbCalisanlar3.Name = "lbCalisanlar3"
        Me.lbCalisanlar3.Size = New System.Drawing.Size(172, 15)
        Me.lbCalisanlar3.TabIndex = 6
        Me.lbCalisanlar3.Text = "Ay İçinde Toplam Çalışan:"
        '
        'lbCalisanlar8
        '
        Me.lbCalisanlar8.AutoSize = True
        Me.lbCalisanlar8.BackColor = System.Drawing.Color.PowderBlue
        Me.lbCalisanlar8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lbCalisanlar8.Location = New System.Drawing.Point(17, 323)
        Me.lbCalisanlar8.Name = "lbCalisanlar8"
        Me.lbCalisanlar8.Size = New System.Drawing.Size(117, 15)
        Me.lbCalisanlar8.TabIndex = 7
        Me.lbCalisanlar8.Text = "Engelli Personel:"
        '
        'btnPerKayit
        '
        Me.btnPerKayit.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnPerKayit.BackColor = System.Drawing.Color.PowderBlue
        Me.btnPerKayit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnPerKayit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnPerKayit.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPerKayit.Location = New System.Drawing.Point(6, 125)
        Me.btnPerKayit.Name = "btnPerKayit"
        Me.btnPerKayit.Size = New System.Drawing.Size(156, 48)
        Me.btnPerKayit.TabIndex = 4
        Me.btnPerKayit.Text = "Yeni Personel Kaydı"
        Me.btnPerKayit.UseVisualStyleBackColor = False
        '
        'btnEksEleman
        '
        Me.btnEksEleman.BackColor = System.Drawing.Color.PowderBlue
        Me.btnEksEleman.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnEksEleman.Location = New System.Drawing.Point(192, 212)
        Me.btnEksEleman.Name = "btnEksEleman"
        Me.btnEksEleman.Size = New System.Drawing.Size(117, 58)
        Me.btnEksEleman.TabIndex = 28
        Me.btnEksEleman.Text = "Eksik Eleman Sayısı"
        Me.btnEksEleman.UseVisualStyleBackColor = False
        '
        'btnKalanMaas
        '
        Me.btnKalanMaas.BackColor = System.Drawing.Color.PowderBlue
        Me.btnKalanMaas.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnKalanMaas.Location = New System.Drawing.Point(329, 212)
        Me.btnKalanMaas.Name = "btnKalanMaas"
        Me.btnKalanMaas.Size = New System.Drawing.Size(115, 58)
        Me.btnKalanMaas.TabIndex = 29
        Me.btnKalanMaas.Text = "Kalan Maaş Ödemesi"
        Me.btnKalanMaas.UseVisualStyleBackColor = False
        '
        'gbAnasayfa
        '
        Me.gbAnasayfa.BackColor = System.Drawing.SystemColors.ControlDark
        Me.gbAnasayfa.BackgroundImage = CType(resources.GetObject("gbAnasayfa.BackgroundImage"), System.Drawing.Image)
        Me.gbAnasayfa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.gbAnasayfa.Controls.Add(Me.mcalAnasayfa)
        Me.gbAnasayfa.Controls.Add(Me.cbPersonel)
        Me.gbAnasayfa.Controls.Add(Me.btnKalanMaas)
        Me.gbAnasayfa.Controls.Add(Me.btnAyrilan)
        Me.gbAnasayfa.Controls.Add(Me.btnEksEleman)
        Me.gbAnasayfa.Controls.Add(Me.btnPerKayit)
        Me.gbAnasayfa.Controls.Add(Me.btnMesai)
        Me.gbAnasayfa.Controls.Add(Me.btnPerIzin)
        Me.gbAnasayfa.Controls.Add(Me.btnPerMaas)
        Me.gbAnasayfa.Location = New System.Drawing.Point(417, 67)
        Me.gbAnasayfa.Name = "gbAnasayfa"
        Me.gbAnasayfa.Size = New System.Drawing.Size(450, 467)
        Me.gbAnasayfa.TabIndex = 30
        Me.gbAnasayfa.TabStop = False
        '
        'mcalAnasayfa
        '
        Me.mcalAnasayfa.AnnuallyBoldedDates = New Date() {New Date(CType(0, Long))}
        Me.mcalAnasayfa.BackColor = System.Drawing.Color.PowderBlue
        Me.mcalAnasayfa.Location = New System.Drawing.Point(192, 25)
        Me.mcalAnasayfa.Name = "mcalAnasayfa"
        Me.mcalAnasayfa.ShowWeekNumbers = True
        Me.mcalAnasayfa.TabIndex = 30
        Me.mcalAnasayfa.TitleBackColor = System.Drawing.Color.PowderBlue
        Me.mcalAnasayfa.TitleForeColor = System.Drawing.Color.PowderBlue
        Me.mcalAnasayfa.TrailingForeColor = System.Drawing.SystemColors.GradientActiveCaption
        '
        'timerAnasayfa
        '
        '
        'tsNavigator
        '
        Me.tsNavigator.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.tsNavigator.AutoSize = False
        Me.tsNavigator.BackgroundImage = CType(resources.GetObject("tsNavigator.BackgroundImage"), System.Drawing.Image)
        Me.tsNavigator.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.tsNavigator.CanOverflow = False
        Me.tsNavigator.Dock = System.Windows.Forms.DockStyle.None
        Me.tsNavigator.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tsNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbuttonExit, Me.ToolStripSeparator8, Me.tsbuttonSettings, Me.ToolStripSeparator4, Me.tsbuttonBirthday, Me.ToolStripSeparator1, Me.tsbuttonDonation, Me.ToolStripSeparator5, Me.tsbuttonFeedback, Me.ToolStripSeparator6, Me.tsbuttonInsta, Me.ToolStripSeparator7, Me.tsbuttonFbook, Me.ToolStripSeparator3, Me.tsbuttonTwitter})
        Me.tsNavigator.Location = New System.Drawing.Point(414, 0)
        Me.tsNavigator.Name = "tsNavigator"
        Me.tsNavigator.Size = New System.Drawing.Size(477, 63)
        Me.tsNavigator.Stretch = True
        Me.tsNavigator.TabIndex = 0
        Me.tsNavigator.Text = "ToolStrip1"
        '
        'tsbuttonExit
        '
        Me.tsbuttonExit.AutoSize = False
        Me.tsbuttonExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.tsbuttonExit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbuttonExit.Image = CType(resources.GetObject("tsbuttonExit.Image"), System.Drawing.Image)
        Me.tsbuttonExit.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsbuttonExit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbuttonExit.Name = "tsbuttonExit"
        Me.tsbuttonExit.Size = New System.Drawing.Size(54, 54)
        Me.tsbuttonExit.Text = "Çıkış"
        '
        'ToolStripSeparator8
        '
        Me.ToolStripSeparator8.Name = "ToolStripSeparator8"
        Me.ToolStripSeparator8.Size = New System.Drawing.Size(6, 63)
        '
        'tsbuttonSettings
        '
        Me.tsbuttonSettings.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbuttonSettings.Image = CType(resources.GetObject("tsbuttonSettings.Image"), System.Drawing.Image)
        Me.tsbuttonSettings.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsbuttonSettings.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbuttonSettings.Name = "tsbuttonSettings"
        Me.tsbuttonSettings.Size = New System.Drawing.Size(54, 60)
        Me.tsbuttonSettings.Text = "Ayarlar"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 63)
        '
        'tsbuttonBirthday
        '
        Me.tsbuttonBirthday.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbuttonBirthday.Image = CType(resources.GetObject("tsbuttonBirthday.Image"), System.Drawing.Image)
        Me.tsbuttonBirthday.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsbuttonBirthday.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbuttonBirthday.Name = "tsbuttonBirthday"
        Me.tsbuttonBirthday.Size = New System.Drawing.Size(54, 60)
        Me.tsbuttonBirthday.Text = "Doğum Günleri"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 63)
        '
        'tsbuttonDonation
        '
        Me.tsbuttonDonation.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbuttonDonation.Image = CType(resources.GetObject("tsbuttonDonation.Image"), System.Drawing.Image)
        Me.tsbuttonDonation.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsbuttonDonation.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbuttonDonation.Name = "tsbuttonDonation"
        Me.tsbuttonDonation.Size = New System.Drawing.Size(54, 60)
        Me.tsbuttonDonation.Text = "Bağış Yap"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 63)
        '
        'tsbuttonFeedback
        '
        Me.tsbuttonFeedback.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbuttonFeedback.Image = CType(resources.GetObject("tsbuttonFeedback.Image"), System.Drawing.Image)
        Me.tsbuttonFeedback.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsbuttonFeedback.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbuttonFeedback.Name = "tsbuttonFeedback"
        Me.tsbuttonFeedback.Size = New System.Drawing.Size(54, 60)
        Me.tsbuttonFeedback.Text = "Geri Bildirim"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(6, 63)
        '
        'tsbuttonInsta
        '
        Me.tsbuttonInsta.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbuttonInsta.Image = CType(resources.GetObject("tsbuttonInsta.Image"), System.Drawing.Image)
        Me.tsbuttonInsta.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsbuttonInsta.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbuttonInsta.Name = "tsbuttonInsta"
        Me.tsbuttonInsta.Size = New System.Drawing.Size(54, 60)
        Me.tsbuttonInsta.Text = "Instagram"
        '
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        Me.ToolStripSeparator7.Size = New System.Drawing.Size(6, 63)
        '
        'tsbuttonFbook
        '
        Me.tsbuttonFbook.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbuttonFbook.Image = CType(resources.GetObject("tsbuttonFbook.Image"), System.Drawing.Image)
        Me.tsbuttonFbook.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsbuttonFbook.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbuttonFbook.Name = "tsbuttonFbook"
        Me.tsbuttonFbook.Size = New System.Drawing.Size(54, 60)
        Me.tsbuttonFbook.Text = "Facebook"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 63)
        '
        'tsbuttonTwitter
        '
        Me.tsbuttonTwitter.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbuttonTwitter.Image = CType(resources.GetObject("tsbuttonTwitter.Image"), System.Drawing.Image)
        Me.tsbuttonTwitter.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsbuttonTwitter.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbuttonTwitter.Name = "tsbuttonTwitter"
        Me.tsbuttonTwitter.Size = New System.Drawing.Size(54, 60)
        Me.tsbuttonTwitter.Text = "Twitter"
        '
        'frmAnasayfa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.AutoSize = True
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1284, 537)
        Me.Controls.Add(Me.gbAnasayfa)
        Me.Controls.Add(Me.gbSubeOzel)
        Me.Controls.Add(Me.tabcBoss)
        Me.Controls.Add(Me.tsNavigator)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimumSize = New System.Drawing.Size(100, 50)
        Me.Name = "frmAnasayfa"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Kültür Şube | DEUSP2019 | V.1.0.0"
        Me.cmsAnasayfa.ResumeLayout(False)
        Me.gbBossKisisel.ResumeLayout(False)
        Me.gbBossKisisel.PerformLayout()
        CType(Me.pbBoss, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabcBoss.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.gbBossFirma.ResumeLayout(False)
        Me.gbBossFirma.PerformLayout()
        Me.gbSubeOzel.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.gbSubeBil.ResumeLayout(False)
        Me.gbSubeBil.PerformLayout()
        Me.gbSubeCalisan.ResumeLayout(False)
        Me.gbSubeCalisan.PerformLayout()
        Me.gbAnasayfa.ResumeLayout(False)
        Me.tsNavigator.ResumeLayout(False)
        Me.tsNavigator.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents imglistAnasayfa As ImageList
    Friend WithEvents tsNavigator As ToolStrip
    Friend WithEvents tsbuttonExit As ToolStripButton
    Friend WithEvents tsbuttonSettings As ToolStripButton
    Friend WithEvents tsbuttonBirthday As ToolStripButton
    Friend WithEvents tsbuttonDonation As ToolStripButton
    Friend WithEvents tsbuttonFeedback As ToolStripButton
    Friend WithEvents tsbuttonInsta As ToolStripButton
    Friend WithEvents tsbuttonFbook As ToolStripButton
    Friend WithEvents tsbuttonTwitter As ToolStripButton
    Friend WithEvents pbBoss As PictureBox
    Friend WithEvents ToolStripSeparator8 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator5 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator6 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator7 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents btnAyrilan As Button
    Friend WithEvents cbPersonel As ComboBox
    Friend WithEvents cmsAnasayfa As ContextMenuStrip
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents ofdAnasayfa As OpenFileDialog
    Friend WithEvents gbBossKisisel As GroupBox
    Friend WithEvents lbBossTc As Label
    Friend WithEvents lbBossYas As Label
    Friend WithEvents lbBossSoyad As Label
    Friend WithEvents lbBossAd As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents lbBossAdres As Label
    Friend WithEvents lbBossTahsil As Label
    Friend WithEvents lbBossDogum As Label
    Friend WithEvents lbBossMemleket As Label
    Friend WithEvents txtBossYas As TextBox
    Friend WithEvents txtBossSoyad As TextBox
    Friend WithEvents txtBossAd As TextBox
    Friend WithEvents tabcBoss As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents rtbBossAdres As RichTextBox
    Friend WithEvents cbBossMemleket As ComboBox
    Friend WithEvents cbBossTahsil As ComboBox
    Friend WithEvents cbBossDogum As ComboBox
    Friend WithEvents gbBossFirma As GroupBox
    Friend WithEvents btnBossMail As Button
    Friend WithEvents btnBossTel As Button
    Friend WithEvents btnBossBanka As Button
    Friend WithEvents cbBossPara As ComboBox
    Friend WithEvents txtBossCiro As TextBox
    Friend WithEvents lbBossCiro As Label
    Friend WithEvents txtBossPozisyon As TextBox
    Friend WithEvents lbBossPozisyon As Label
    Friend WithEvents btnMesai As Button
    Friend WithEvents btnPerIzin As Button
    Friend WithEvents btnPerMaas As Button
    Friend WithEvents gbSubeOzel As GroupBox
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents mtbBossTarih As MaskedTextBox
    Friend WithEvents mtbSubeTel As MaskedTextBox
    Friend WithEvents gbSubeBil As GroupBox
    Friend WithEvents MaskedTextBox1 As MaskedTextBox
    Friend WithEvents lbSubeAdres As Label
    Friend WithEvents lbSubeTel As Label
    Friend WithEvents lbSubeAd As Label
    Friend WithEvents lbFirma As Label
    Friend WithEvents gbSubeCalisan As GroupBox
    Friend WithEvents lbCalisanlar7 As Label
    Friend WithEvents lbCalisanlar4 As Label
    Friend WithEvents lbCalisanlar6 As Label
    Friend WithEvents lbCalisanlar5 As Label
    Friend WithEvents lbCalisanlar1 As Label
    Friend WithEvents lbCalisanlar2 As Label
    Friend WithEvents lbCalisanlar3 As Label
    Friend WithEvents lbCalisanlar8 As Label
    Friend WithEvents txtBossTc As TextBox
    Friend WithEvents txtMekanKonum As TextBox
    Friend WithEvents txtMekanAd As TextBox
    Friend WithEvents txtCal1 As TextBox
    Friend WithEvents txtCal8 As TextBox
    Friend WithEvents txtCal7 As TextBox
    Friend WithEvents txtCal6 As TextBox
    Friend WithEvents txtCal5 As TextBox
    Friend WithEvents txtCal4 As TextBox
    Friend WithEvents txtCal3 As TextBox
    Friend WithEvents txtCal2 As TextBox
    Friend WithEvents rtbSubeAdres As RichTextBox
    Friend WithEvents btnPerKayit As Button
    Friend WithEvents btnEksEleman As Button
    Friend WithEvents btnKalanMaas As Button
    Friend WithEvents gbAnasayfa As GroupBox
    Friend WithEvents mcalAnasayfa As MonthCalendar
    Friend WithEvents timerAnasayfa As Timer
End Class
