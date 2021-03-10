<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAyarlar
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
        Me.tabcAyarlar = New System.Windows.Forms.TabControl()
        Me.tabcIsBolumleri = New System.Windows.Forms.TabPage()
        Me.btnAyarNoksan = New System.Windows.Forms.Button()
        Me.btnAyarCikar = New System.Windows.Forms.Button()
        Me.btnAyarEkle = New System.Windows.Forms.Button()
        Me.lbAyarCikarilan = New System.Windows.Forms.Label()
        Me.lbAyarPozis = New System.Windows.Forms.Label()
        Me.clbCikarilan = New System.Windows.Forms.CheckedListBox()
        Me.clbPozisyon = New System.Windows.Forms.CheckedListBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.btnTema = New System.Windows.Forms.Button()
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnAyarKaydet = New System.Windows.Forms.Button()
        Me.tabcAyarlar.SuspendLayout()
        Me.tabcIsBolumleri.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        Me.TabPage5.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tabcAyarlar
        '
        Me.tabcAyarlar.Controls.Add(Me.tabcIsBolumleri)
        Me.tabcAyarlar.Controls.Add(Me.TabPage2)
        Me.tabcAyarlar.Controls.Add(Me.TabPage4)
        Me.tabcAyarlar.Controls.Add(Me.TabPage5)
        Me.tabcAyarlar.Controls.Add(Me.TabPage3)
        Me.tabcAyarlar.Location = New System.Drawing.Point(-1, 0)
        Me.tabcAyarlar.Name = "tabcAyarlar"
        Me.tabcAyarlar.SelectedIndex = 0
        Me.tabcAyarlar.Size = New System.Drawing.Size(554, 382)
        Me.tabcAyarlar.TabIndex = 0
        '
        'tabcIsBolumleri
        '
        Me.tabcIsBolumleri.Controls.Add(Me.btnAyarNoksan)
        Me.tabcIsBolumleri.Controls.Add(Me.btnAyarCikar)
        Me.tabcIsBolumleri.Controls.Add(Me.btnAyarEkle)
        Me.tabcIsBolumleri.Controls.Add(Me.lbAyarCikarilan)
        Me.tabcIsBolumleri.Controls.Add(Me.lbAyarPozis)
        Me.tabcIsBolumleri.Controls.Add(Me.clbCikarilan)
        Me.tabcIsBolumleri.Controls.Add(Me.clbPozisyon)
        Me.tabcIsBolumleri.Location = New System.Drawing.Point(4, 22)
        Me.tabcIsBolumleri.Name = "tabcIsBolumleri"
        Me.tabcIsBolumleri.Padding = New System.Windows.Forms.Padding(3)
        Me.tabcIsBolumleri.Size = New System.Drawing.Size(546, 356)
        Me.tabcIsBolumleri.TabIndex = 0
        Me.tabcIsBolumleri.Text = "İş Bölümleri"
        Me.tabcIsBolumleri.UseVisualStyleBackColor = True
        '
        'btnAyarNoksan
        '
        Me.btnAyarNoksan.Font = New System.Drawing.Font("Dosis", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btnAyarNoksan.Location = New System.Drawing.Point(146, 156)
        Me.btnAyarNoksan.Name = "btnAyarNoksan"
        Me.btnAyarNoksan.Size = New System.Drawing.Size(118, 61)
        Me.btnAyarNoksan.TabIndex = 6
        Me.btnAyarNoksan.Text = "Görev Açığı Olarak İşaretle"
        Me.btnAyarNoksan.UseVisualStyleBackColor = True
        '
        'btnAyarCikar
        '
        Me.btnAyarCikar.Font = New System.Drawing.Font("Dosis", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btnAyarCikar.Location = New System.Drawing.Point(146, 23)
        Me.btnAyarCikar.Name = "btnAyarCikar"
        Me.btnAyarCikar.Size = New System.Drawing.Size(118, 61)
        Me.btnAyarCikar.TabIndex = 5
        Me.btnAyarCikar.Text = "Çıkar"
        Me.btnAyarCikar.UseVisualStyleBackColor = True
        '
        'btnAyarEkle
        '
        Me.btnAyarEkle.Font = New System.Drawing.Font("Dosis", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btnAyarEkle.Location = New System.Drawing.Point(146, 88)
        Me.btnAyarEkle.Name = "btnAyarEkle"
        Me.btnAyarEkle.Size = New System.Drawing.Size(118, 61)
        Me.btnAyarEkle.TabIndex = 4
        Me.btnAyarEkle.Text = "Geri Ekle"
        Me.btnAyarEkle.UseVisualStyleBackColor = True
        '
        'lbAyarCikarilan
        '
        Me.lbAyarCikarilan.AutoSize = True
        Me.lbAyarCikarilan.Font = New System.Drawing.Font("Dosis", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lbAyarCikarilan.Location = New System.Drawing.Point(272, 2)
        Me.lbAyarCikarilan.Name = "lbAyarCikarilan"
        Me.lbAyarCikarilan.Size = New System.Drawing.Size(117, 18)
        Me.lbAyarCikarilan.TabIndex = 3
        Me.lbAyarCikarilan.Text = "Çıkarılan Pozisyonlar"
        '
        'lbAyarPozis
        '
        Me.lbAyarPozis.AutoSize = True
        Me.lbAyarPozis.Font = New System.Drawing.Font("Dosis", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lbAyarPozis.Location = New System.Drawing.Point(32, 2)
        Me.lbAyarPozis.Name = "lbAyarPozis"
        Me.lbAyarPozis.Size = New System.Drawing.Size(68, 18)
        Me.lbAyarPozis.TabIndex = 2
        Me.lbAyarPozis.Text = "Pozisyonlar"
        '
        'clbCikarilan
        '
        Me.clbCikarilan.Font = New System.Drawing.Font("Dosis", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.clbCikarilan.FormattingEnabled = True
        Me.clbCikarilan.Location = New System.Drawing.Point(270, 23)
        Me.clbCikarilan.Name = "clbCikarilan"
        Me.clbCikarilan.Size = New System.Drawing.Size(121, 327)
        Me.clbCikarilan.TabIndex = 1
        '
        'clbPozisyon
        '
        Me.clbPozisyon.CheckOnClick = True
        Me.clbPozisyon.Font = New System.Drawing.Font("Dosis", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.clbPozisyon.FormattingEnabled = True
        Me.clbPozisyon.Items.AddRange(New Object() {"Genel Müdür", "Ön Büro Müdürü", "Muhasebe Müdürü", "Personel Müdürü", "Garson", "Şef Garson", "Komi", "Vale", "Ahçı", "Hademe", "Kurye", "Kasiyer", "Karşılama Hostesi", "Bulaşıkçı"})
        Me.clbPozisyon.Location = New System.Drawing.Point(11, 23)
        Me.clbPozisyon.MultiColumn = True
        Me.clbPozisyon.Name = "clbPozisyon"
        Me.clbPozisyon.Size = New System.Drawing.Size(125, 327)
        Me.clbPozisyon.TabIndex = 0
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.Button6)
        Me.TabPage2.Controls.Add(Me.Button4)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(546, 356)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Yedekleme"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Font = New System.Drawing.Font("Dosis", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Button6.Location = New System.Drawing.Point(0, 178)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(393, 178)
        Me.Button6.TabIndex = 1
        Me.Button6.Text = "Veritabanı Yedekten Geri Yükle"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Dosis", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Button4.Location = New System.Drawing.Point(0, 0)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(393, 178)
        Me.Button4.TabIndex = 0
        Me.Button4.Text = "Veritabanı Yedekle"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.btnTema)
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(546, 356)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Tema Ayarları"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'btnTema
        '
        Me.btnTema.Font = New System.Drawing.Font("Dosis", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btnTema.Location = New System.Drawing.Point(102, 101)
        Me.btnTema.Name = "btnTema"
        Me.btnTema.Size = New System.Drawing.Size(191, 145)
        Me.btnTema.TabIndex = 0
        Me.btnTema.Text = "Tema Ayarlarına Git"
        Me.btnTema.UseVisualStyleBackColor = True
        '
        'TabPage5
        '
        Me.TabPage5.Controls.Add(Me.Button8)
        Me.TabPage5.Location = New System.Drawing.Point(4, 22)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Size = New System.Drawing.Size(546, 356)
        Me.TabPage5.TabIndex = 4
        Me.TabPage5.Text = "Yazılım Güncelleştirme"
        Me.TabPage5.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.Font = New System.Drawing.Font("Dosis", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Button8.Location = New System.Drawing.Point(108, 95)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(191, 145)
        Me.Button8.TabIndex = 1
        Me.Button8.Text = "Son Sürüme Güncelle"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.DataGridView1)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(546, 356)
        Me.TabPage3.TabIndex = 5
        Me.TabPage3.Text = "Borçlar"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5})
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.DataGridView1.Location = New System.Drawing.Point(3, 3)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(540, 350)
        Me.DataGridView1.TabIndex = 0
        '
        'Column1
        '
        Me.Column1.HeaderText = "Şirket"
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.HeaderText = "Borç Miktarı"
        Me.Column2.Name = "Column2"
        '
        'Column3
        '
        Me.Column3.HeaderText = "Son Ödeme Tarihi"
        Me.Column3.Name = "Column3"
        '
        'Column4
        '
        Me.Column4.HeaderText = "Alınacak Miktar"
        Me.Column4.Name = "Column4"
        '
        'Column5
        '
        Me.Column5.HeaderText = "Son Tahsilat Tarihi"
        Me.Column5.Name = "Column5"
        '
        'btnAyarKaydet
        '
        Me.btnAyarKaydet.Location = New System.Drawing.Point(347, 388)
        Me.btnAyarKaydet.Name = "btnAyarKaydet"
        Me.btnAyarKaydet.Size = New System.Drawing.Size(88, 34)
        Me.btnAyarKaydet.TabIndex = 8
        Me.btnAyarKaydet.Text = "Kaydet"
        Me.btnAyarKaydet.UseVisualStyleBackColor = True
        '
        'frmAyarlar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(547, 426)
        Me.Controls.Add(Me.btnAyarKaydet)
        Me.Controls.Add(Me.tabcAyarlar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "frmAyarlar"
        Me.Text = "Ayarlar"
        Me.tabcAyarlar.ResumeLayout(False)
        Me.tabcIsBolumleri.ResumeLayout(False)
        Me.tabcIsBolumleri.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage5.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tabcAyarlar As TabControl
    Friend WithEvents tabcIsBolumleri As TabPage
    Friend WithEvents btnAyarNoksan As Button
    Friend WithEvents btnAyarCikar As Button
    Friend WithEvents btnAyarEkle As Button
    Friend WithEvents lbAyarCikarilan As Label
    Friend WithEvents lbAyarPozis As Label
    Friend WithEvents clbCikarilan As CheckedListBox
    Friend WithEvents clbPozisyon As CheckedListBox
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents TabPage5 As TabPage
    Friend WithEvents btnAyarKaydet As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents btnTema As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
End Class
