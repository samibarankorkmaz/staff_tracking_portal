<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmIsBolumleri
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
        Me.cbIsBolumleri = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'cbIsBolumleri
        '
        Me.cbIsBolumleri.Font = New System.Drawing.Font("Dosis", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.cbIsBolumleri.FormattingEnabled = True
        Me.cbIsBolumleri.Items.AddRange(New Object() {"Genel Müdür", "Ön Büro Müdürü", "Muhasebe Müdürü", "Personel Müdürü", "Garson", "Şef Garson ", "Komi", "Vale", "Ahçı", "Hademe", "Kurye", "Kasiyer", "Karşılama Hostesi", "Bulaşıkçı"})
        Me.cbIsBolumleri.Location = New System.Drawing.Point(-2, -1)
        Me.cbIsBolumleri.Name = "cbIsBolumleri"
        Me.cbIsBolumleri.Size = New System.Drawing.Size(121, 29)
        Me.cbIsBolumleri.TabIndex = 0
        '
        'frmIsBolumleri
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(120, 29)
        Me.Controls.Add(Me.cbIsBolumleri)
        Me.Name = "frmIsBolumleri"
        Me.Text = "Form4"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents cbIsBolumleri As ComboBox
End Class
