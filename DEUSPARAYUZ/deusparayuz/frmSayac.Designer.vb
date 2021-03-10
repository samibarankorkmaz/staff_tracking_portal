<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSayac
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
        Me.lbKalanSayac = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lbKalanSayac
        '
        Me.lbKalanSayac.Font = New System.Drawing.Font("Action Jackson", 72.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbKalanSayac.Location = New System.Drawing.Point(16, 9)
        Me.lbKalanSayac.Name = "lbKalanSayac"
        Me.lbKalanSayac.Size = New System.Drawing.Size(430, 256)
        Me.lbKalanSayac.TabIndex = 0
        Me.lbKalanSayac.Tag = ""
        Me.lbKalanSayac.Text = "0"
        Me.lbKalanSayac.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmSayac
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(458, 279)
        Me.Controls.Add(Me.lbKalanSayac)
        Me.Name = "frmSayac"
        Me.Text = "Kalan Ödeme Göstergesi"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lbKalanSayac As Label
End Class
