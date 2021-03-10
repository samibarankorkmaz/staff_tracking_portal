<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTemaAyarlari
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
        Me.txtR = New System.Windows.Forms.TextBox()
        Me.txtG = New System.Windows.Forms.TextBox()
        Me.txtB = New System.Windows.Forms.TextBox()
        Me.hsR = New System.Windows.Forms.HScrollBar()
        Me.hsG = New System.Windows.Forms.HScrollBar()
        Me.hsB = New System.Windows.Forms.HScrollBar()
        Me.pnRenk = New System.Windows.Forms.Panel()
        Me.lbRGB = New System.Windows.Forms.Label()
        Me.lbHexa = New System.Windows.Forms.Label()
        Me.btnTemaRastgele = New System.Windows.Forms.Button()
        Me.txtRGB = New System.Windows.Forms.TextBox()
        Me.txtHexa = New System.Windows.Forms.TextBox()
        Me.btnTemaAyarla = New System.Windows.Forms.Button()
        Me.gbTema = New System.Windows.Forms.GroupBox()
        Me.gbTema.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtR
        '
        Me.txtR.Location = New System.Drawing.Point(57, 33)
        Me.txtR.Name = "txtR"
        Me.txtR.Size = New System.Drawing.Size(35, 20)
        Me.txtR.TabIndex = 0
        '
        'txtG
        '
        Me.txtG.Location = New System.Drawing.Point(57, 75)
        Me.txtG.Name = "txtG"
        Me.txtG.Size = New System.Drawing.Size(35, 20)
        Me.txtG.TabIndex = 1
        '
        'txtB
        '
        Me.txtB.Location = New System.Drawing.Point(57, 123)
        Me.txtB.Name = "txtB"
        Me.txtB.Size = New System.Drawing.Size(35, 20)
        Me.txtB.TabIndex = 2
        '
        'hsR
        '
        Me.hsR.Location = New System.Drawing.Point(158, 35)
        Me.hsR.Name = "hsR"
        Me.hsR.Size = New System.Drawing.Size(138, 17)
        Me.hsR.TabIndex = 3
        '
        'hsG
        '
        Me.hsG.Location = New System.Drawing.Point(158, 78)
        Me.hsG.Name = "hsG"
        Me.hsG.Size = New System.Drawing.Size(138, 17)
        Me.hsG.TabIndex = 4
        '
        'hsB
        '
        Me.hsB.Location = New System.Drawing.Point(158, 123)
        Me.hsB.Name = "hsB"
        Me.hsB.Size = New System.Drawing.Size(138, 17)
        Me.hsB.TabIndex = 5
        '
        'pnRenk
        '
        Me.pnRenk.Location = New System.Drawing.Point(29, 22)
        Me.pnRenk.Name = "pnRenk"
        Me.pnRenk.Size = New System.Drawing.Size(145, 88)
        Me.pnRenk.TabIndex = 6
        '
        'lbRGB
        '
        Me.lbRGB.AutoSize = True
        Me.lbRGB.Location = New System.Drawing.Point(52, 188)
        Me.lbRGB.Name = "lbRGB"
        Me.lbRGB.Size = New System.Drawing.Size(61, 13)
        Me.lbRGB.TabIndex = 7
        Me.lbRGB.Text = "RGB Kodu:"
        '
        'lbHexa
        '
        Me.lbHexa.AutoSize = True
        Me.lbHexa.Location = New System.Drawing.Point(52, 216)
        Me.lbHexa.Name = "lbHexa"
        Me.lbHexa.Size = New System.Drawing.Size(63, 13)
        Me.lbHexa.TabIndex = 8
        Me.lbHexa.Text = "Hexa Kodu:"
        '
        'btnTemaRastgele
        '
        Me.btnTemaRastgele.Location = New System.Drawing.Point(310, 195)
        Me.btnTemaRastgele.Name = "btnTemaRastgele"
        Me.btnTemaRastgele.Size = New System.Drawing.Size(104, 55)
        Me.btnTemaRastgele.TabIndex = 9
        Me.btnTemaRastgele.Text = "Rastgele"
        Me.btnTemaRastgele.UseVisualStyleBackColor = True
        '
        'txtRGB
        '
        Me.txtRGB.Location = New System.Drawing.Point(143, 185)
        Me.txtRGB.Name = "txtRGB"
        Me.txtRGB.Size = New System.Drawing.Size(100, 20)
        Me.txtRGB.TabIndex = 10
        '
        'txtHexa
        '
        Me.txtHexa.Location = New System.Drawing.Point(143, 211)
        Me.txtHexa.Name = "txtHexa"
        Me.txtHexa.Size = New System.Drawing.Size(100, 20)
        Me.txtHexa.TabIndex = 11
        '
        'btnTemaAyarla
        '
        Me.btnTemaAyarla.Location = New System.Drawing.Point(413, 195)
        Me.btnTemaAyarla.Name = "btnTemaAyarla"
        Me.btnTemaAyarla.Size = New System.Drawing.Size(104, 55)
        Me.btnTemaAyarla.TabIndex = 12
        Me.btnTemaAyarla.Text = "Arayüz Teması Olarak Ayarla"
        Me.btnTemaAyarla.UseVisualStyleBackColor = True
        '
        'gbTema
        '
        Me.gbTema.Controls.Add(Me.pnRenk)
        Me.gbTema.Location = New System.Drawing.Point(354, 33)
        Me.gbTema.Name = "gbTema"
        Me.gbTema.Size = New System.Drawing.Size(200, 131)
        Me.gbTema.TabIndex = 0
        Me.gbTema.TabStop = False
        Me.gbTema.Text = "GroupBox1"
        '
        'frmTemaAyarlari
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(584, 286)
        Me.Controls.Add(Me.gbTema)
        Me.Controls.Add(Me.btnTemaAyarla)
        Me.Controls.Add(Me.txtHexa)
        Me.Controls.Add(Me.txtRGB)
        Me.Controls.Add(Me.btnTemaRastgele)
        Me.Controls.Add(Me.lbHexa)
        Me.Controls.Add(Me.lbRGB)
        Me.Controls.Add(Me.hsB)
        Me.Controls.Add(Me.hsG)
        Me.Controls.Add(Me.hsR)
        Me.Controls.Add(Me.txtB)
        Me.Controls.Add(Me.txtG)
        Me.Controls.Add(Me.txtR)
        Me.Name = "frmTemaAyarlari"
        Me.Text = "Tema Ayarları"
        Me.gbTema.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtR As TextBox
    Friend WithEvents txtG As TextBox
    Friend WithEvents txtB As TextBox
    Friend WithEvents hsR As HScrollBar
    Friend WithEvents hsG As HScrollBar
    Friend WithEvents hsB As HScrollBar
    Friend WithEvents pnRenk As Panel
    Friend WithEvents lbRGB As Label
    Friend WithEvents lbHexa As Label
    Friend WithEvents btnTemaRastgele As Button
    Friend WithEvents txtRGB As TextBox
    Friend WithEvents txtHexa As TextBox
    Friend WithEvents btnTemaAyarla As Button
    Friend WithEvents gbTema As GroupBox
End Class
