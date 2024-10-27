<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.picBox = New System.Windows.Forms.PictureBox()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.TamEkranModundanÇıkToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.PanoyaKopyalaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ResmiMasaüstüArkaPlanıOlarakAyarlaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.DosyaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AçToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HerZamanÜstteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ÇıkıToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GörünümToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ArkaPlanRengiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SiyahToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BeyazToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GriToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GörüntülemeModuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BüyütToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NormalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ResmiUzatToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ResmiOrtalaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TamEkranToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.YardımToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HonaViewerHakkındaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.escbas = New System.Windows.Forms.Label()
        CType(Me.picBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'picBox
        '
        Me.picBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.picBox.ContextMenuStrip = Me.ContextMenuStrip1
        Me.picBox.Location = New System.Drawing.Point(0, 24)
        Me.picBox.Name = "picBox"
        Me.picBox.Size = New System.Drawing.Size(668, 521)
        Me.picBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picBox.TabIndex = 0
        Me.picBox.TabStop = False
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TamEkranModundanÇıkToolStripMenuItem, Me.ToolStripSeparator1, Me.PanoyaKopyalaToolStripMenuItem, Me.ResmiMasaüstüArkaPlanıOlarakAyarlaToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(255, 98)
        '
        'TamEkranModundanÇıkToolStripMenuItem
        '
        Me.TamEkranModundanÇıkToolStripMenuItem.Name = "TamEkranModundanÇıkToolStripMenuItem"
        Me.TamEkranModundanÇıkToolStripMenuItem.Size = New System.Drawing.Size(254, 22)
        Me.TamEkranModundanÇıkToolStripMenuItem.Text = "Tam Ekran Modundan Çık"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(251, 6)
        '
        'PanoyaKopyalaToolStripMenuItem
        '
        Me.PanoyaKopyalaToolStripMenuItem.Name = "PanoyaKopyalaToolStripMenuItem"
        Me.PanoyaKopyalaToolStripMenuItem.Size = New System.Drawing.Size(254, 22)
        Me.PanoyaKopyalaToolStripMenuItem.Text = "Panoya Kopyala"
        '
        'ResmiMasaüstüArkaPlanıOlarakAyarlaToolStripMenuItem
        '
        Me.ResmiMasaüstüArkaPlanıOlarakAyarlaToolStripMenuItem.Name = "ResmiMasaüstüArkaPlanıOlarakAyarlaToolStripMenuItem"
        Me.ResmiMasaüstüArkaPlanıOlarakAyarlaToolStripMenuItem.Size = New System.Drawing.Size(254, 22)
        Me.ResmiMasaüstüArkaPlanıOlarakAyarlaToolStripMenuItem.Text = "Masaüstü Arka Planı Olarak Ayarla"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.White
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DosyaToolStripMenuItem, Me.GörünümToolStripMenuItem, Me.YardımToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(668, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'DosyaToolStripMenuItem
        '
        Me.DosyaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AçToolStripMenuItem, Me.HerZamanÜstteToolStripMenuItem, Me.ÇıkıToolStripMenuItem})
        Me.DosyaToolStripMenuItem.Name = "DosyaToolStripMenuItem"
        Me.DosyaToolStripMenuItem.Size = New System.Drawing.Size(51, 20)
        Me.DosyaToolStripMenuItem.Text = "Dosya"
        '
        'AçToolStripMenuItem
        '
        Me.AçToolStripMenuItem.Name = "AçToolStripMenuItem"
        Me.AçToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.AçToolStripMenuItem.Text = "Aç"
        '
        'HerZamanÜstteToolStripMenuItem
        '
        Me.HerZamanÜstteToolStripMenuItem.Name = "HerZamanÜstteToolStripMenuItem"
        Me.HerZamanÜstteToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.HerZamanÜstteToolStripMenuItem.Text = "Her Zaman Üstte"
        '
        'ÇıkıToolStripMenuItem
        '
        Me.ÇıkıToolStripMenuItem.Name = "ÇıkıToolStripMenuItem"
        Me.ÇıkıToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ÇıkıToolStripMenuItem.Text = "Çıkış"
        '
        'GörünümToolStripMenuItem
        '
        Me.GörünümToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArkaPlanRengiToolStripMenuItem, Me.GörüntülemeModuToolStripMenuItem, Me.TamEkranToolStripMenuItem})
        Me.GörünümToolStripMenuItem.Name = "GörünümToolStripMenuItem"
        Me.GörünümToolStripMenuItem.Size = New System.Drawing.Size(70, 20)
        Me.GörünümToolStripMenuItem.Text = "Görünüm"
        '
        'ArkaPlanRengiToolStripMenuItem
        '
        Me.ArkaPlanRengiToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SiyahToolStripMenuItem, Me.BeyazToolStripMenuItem, Me.GriToolStripMenuItem})
        Me.ArkaPlanRengiToolStripMenuItem.Name = "ArkaPlanRengiToolStripMenuItem"
        Me.ArkaPlanRengiToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ArkaPlanRengiToolStripMenuItem.Text = "Arka Plan Rengi"
        '
        'SiyahToolStripMenuItem
        '
        Me.SiyahToolStripMenuItem.Name = "SiyahToolStripMenuItem"
        Me.SiyahToolStripMenuItem.Size = New System.Drawing.Size(104, 22)
        Me.SiyahToolStripMenuItem.Text = "Siyah"
        '
        'BeyazToolStripMenuItem
        '
        Me.BeyazToolStripMenuItem.Name = "BeyazToolStripMenuItem"
        Me.BeyazToolStripMenuItem.Size = New System.Drawing.Size(104, 22)
        Me.BeyazToolStripMenuItem.Text = "Beyaz"
        '
        'GriToolStripMenuItem
        '
        Me.GriToolStripMenuItem.Name = "GriToolStripMenuItem"
        Me.GriToolStripMenuItem.Size = New System.Drawing.Size(104, 22)
        Me.GriToolStripMenuItem.Text = "Gri"
        '
        'GörüntülemeModuToolStripMenuItem
        '
        Me.GörüntülemeModuToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BüyütToolStripMenuItem, Me.NormalToolStripMenuItem, Me.ResmiUzatToolStripMenuItem, Me.ResmiOrtalaToolStripMenuItem})
        Me.GörüntülemeModuToolStripMenuItem.Name = "GörüntülemeModuToolStripMenuItem"
        Me.GörüntülemeModuToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.GörüntülemeModuToolStripMenuItem.Text = "Görüntüleme Modu"
        '
        'BüyütToolStripMenuItem
        '
        Me.BüyütToolStripMenuItem.Name = "BüyütToolStripMenuItem"
        Me.BüyütToolStripMenuItem.Size = New System.Drawing.Size(249, 22)
        Me.BüyütToolStripMenuItem.Text = "Büyüt (Varsayılan)"
        '
        'NormalToolStripMenuItem
        '
        Me.NormalToolStripMenuItem.Name = "NormalToolStripMenuItem"
        Me.NormalToolStripMenuItem.Size = New System.Drawing.Size(249, 22)
        Me.NormalToolStripMenuItem.Text = "Çözünürlüğü Tut"
        '
        'ResmiUzatToolStripMenuItem
        '
        Me.ResmiUzatToolStripMenuItem.Name = "ResmiUzatToolStripMenuItem"
        Me.ResmiUzatToolStripMenuItem.Size = New System.Drawing.Size(249, 22)
        Me.ResmiUzatToolStripMenuItem.Text = "Resmi Uzat"
        '
        'ResmiOrtalaToolStripMenuItem
        '
        Me.ResmiOrtalaToolStripMenuItem.Name = "ResmiOrtalaToolStripMenuItem"
        Me.ResmiOrtalaToolStripMenuItem.Size = New System.Drawing.Size(249, 22)
        Me.ResmiOrtalaToolStripMenuItem.Text = "Resmi Ortala ve Çözünürlüğü Tut"
        '
        'TamEkranToolStripMenuItem
        '
        Me.TamEkranToolStripMenuItem.Name = "TamEkranToolStripMenuItem"
        Me.TamEkranToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.TamEkranToolStripMenuItem.Text = "Tam Ekran Modu"
        '
        'YardımToolStripMenuItem
        '
        Me.YardımToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HonaViewerHakkındaToolStripMenuItem})
        Me.YardımToolStripMenuItem.Name = "YardımToolStripMenuItem"
        Me.YardımToolStripMenuItem.Size = New System.Drawing.Size(56, 20)
        Me.YardımToolStripMenuItem.Text = "Yardım"
        '
        'HonaViewerHakkındaToolStripMenuItem
        '
        Me.HonaViewerHakkındaToolStripMenuItem.Name = "HonaViewerHakkındaToolStripMenuItem"
        Me.HonaViewerHakkındaToolStripMenuItem.Size = New System.Drawing.Size(189, 22)
        Me.HonaViewerHakkındaToolStripMenuItem.Text = "honaViewer Hakkında"
        '
        'Label1
        '
        Me.Label1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft JhengHei UI Light", 16.0!)
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.Location = New System.Drawing.Point(12, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(151, 28)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Bir dosya açın"
        '
        'escbas
        '
        Me.escbas.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.escbas.AutoSize = True
        Me.escbas.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.escbas.Font = New System.Drawing.Font("Microsoft JhengHei UI Light", 16.0!)
        Me.escbas.ForeColor = System.Drawing.Color.White
        Me.escbas.Location = New System.Drawing.Point(119, 476)
        Me.escbas.Name = "escbas"
        Me.escbas.Size = New System.Drawing.Size(537, 56)
        Me.escbas.TabIndex = 3
        Me.escbas.Text = "Tam ekran modundan çıkmak için ESC tusuna basın!" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Beni gizlemek için üstüme tıkla" &
    "yın."
        Me.escbas.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(668, 544)
        Me.Controls.Add(Me.escbas)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.picBox)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MinimumSize = New System.Drawing.Size(300, 110)
        Me.Name = "Form1"
        Me.Text = "honaViewer"
        CType(Me.picBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picBox As PictureBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents DosyaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AçToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ÇıkıToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents YardımToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HonaViewerHakkındaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label1 As Label
    Friend WithEvents GörünümToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ArkaPlanRengiToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SiyahToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BeyazToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GriToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TamEkranToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HerZamanÜstteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents escbas As Label
    Friend WithEvents GörüntülemeModuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NormalToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ResmiUzatToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ResmiOrtalaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BüyütToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents TamEkranModundanÇıkToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents PanoyaKopyalaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ResmiMasaüstüArkaPlanıOlarakAyarlaToolStripMenuItem As ToolStripMenuItem
End Class
