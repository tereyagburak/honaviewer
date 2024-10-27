Imports System.IO
Imports System.Reflection.Emit
Imports System.Runtime.InteropServices

Module WallpaperChanger
    <DllImport("user32.dll", CharSet:=CharSet.Auto, SetLastError:=True)>
    Public Function SystemParametersInfo(uAction As Integer, uParam As Integer, lpvParam As String, fuWinIni As Integer) As Boolean
    End Function

    ' Sabitleri Public olarak değiştir
    Public Const SPI_SETDESKWALLPAPER As Integer = 20
    Public Const SPIF_UPDATEINIFILE As Integer = &H1
    Public Const SPIF_SENDCHANGE As Integer = &H2
End Module


Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.KeyPreview = True
        renkdegis()
        ' Komut satırı argümanlarını al
        ' Komut satırından gelen dosya yolunu al
        Dim args() As String = Environment.GetCommandLineArgs()

        ' Eğer bir dosya yolu varsa
        If args.Length > 1 Then
            Dim filePath As String = args(1)
            ' Resmi açmayı dene
            Try
                ' FileStream kullanarak dosyayı aç
                Using fs As New IO.FileStream(filePath, IO.FileMode.Open, IO.FileAccess.Read)
                    ' Resmi FileStream'den yükle
                    Dim img As Image = Image.FromStream(fs)
                    picBox.Image = New Bitmap(img)
                End Using

                ' Formun başlığını güncelle
                Me.Text = $"honaViewer({filePath})"
                Label1.Visible = False

            Catch ex As OutOfMemoryException
                ' Bellek Yetersiz hatası olduğunda mesaj göster
                MessageBox.Show("Bellek Yetersiz. Resim dosyası geçerli bir formatta olmayabilir veya çok büyük olabilir.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Catch ex As Exception
                ' Diğer hataları yakala
                MessageBox.Show("Resim yüklenirken bir hata oluştu: " & ex.Message)
            End Try
        End If


        ' MenuStrip'in arka plan ve yazı rengini değiştir
        MenuStrip1.BackColor = Color.FromArgb(40, 36, 36)
        MenuStrip1.ForeColor = Color.White

        ' ToolStripMenuItem arka plan ve yazı rengini ayarlamak
        For Each item As ToolStripMenuItem In MenuStrip1.Items
            item.BackColor = Color.FromArgb(40, 36, 36)
            item.ForeColor = Color.White
            ChangeSubMenuColors(item)
        Next


        Try
            EnableDarkMode(Me.Handle, True)
        Catch ex As Exception
            Return
        End Try
    End Sub

    Private Sub AçToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AçToolStripMenuItem.Click
        ' OpenFileDialog ayarları
        Dim OpenFileDialog As New OpenFileDialog()
        OpenFileDialog.Filter = "Resim Dosyaları|*.jpg;*.jpeg;*.png;*.bmp;*.gif"
        OpenFileDialog.Title = "Bir resim dosyası seçin"

        ' Eğer kullanıcı bir dosya seçerse
        If OpenFileDialog.ShowDialog() = DialogResult.OK Then

            Try
                ' FileStream kullanarak dosyayı aç
                Using fs As New IO.FileStream(OpenFileDialog.FileName, IO.FileMode.Open, IO.FileAccess.Read)
                    ' Resmi FileStream'den yükle
                    Using img As Image = Image.FromStream(fs)
                        ' Resmi PictureBox'a kopyala
                        picBox.Image = New Bitmap(img)
                    End Using
                End Using

                ' Dosya adını form başlığına yaz
                Dim fileName As String = OpenFileDialog.FileName()
                Me.Text = $"honaViewer({fileName})"
                Label1.Visible = False

            Catch ex As OutOfMemoryException
                ' Bellek Yetersiz hatası olduğunda mesaj göster
                MessageBox.Show("Bellek Yetersiz. Resim dosyası geçerli bir formatta olmayabilir veya çok büyük olabilir.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Catch ex As Exception
                ' Diğer hataları yakala
                MessageBox.Show("Geçerli bir resim dosyası seçmediniz veya dosya bozuk.", "Üzgünüm. Ama,", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub


    'Başlık çubuğunu karanlık yapan eleman

    Private Const DWMWA_USE_IMMERSIVE_DARK_MODE As Integer = 20
    <DllImport("dwmapi.dll", PreserveSig:=True)>
    Public Shared Function DwmSetWindowAttribute(ByVal hwnd As IntPtr, ByVal attr As Integer, ByRef attrValue As Integer, ByVal attrSize As Integer) As Integer
    End Function
    Private Sub EnableDarkMode(hwnd As IntPtr, enable As Boolean)
        Dim useDarkMode As Integer = If(enable, 1, 0)
        DwmSetWindowAttribute(hwnd, DWMWA_USE_IMMERSIVE_DARK_MODE, useDarkMode, Marshal.SizeOf(useDarkMode))
    End Sub
    'endBaşlık çubuğunu karanlık yapan eleman


    ' Alt menülerin de rengini değiştirmek için rekürsif fonksiyon
    Private Sub ChangeSubMenuColors(menuItem As ToolStripMenuItem)
        For Each subItem As ToolStripItem In menuItem.DropDownItems
            ' Sadece ToolStripMenuItem öğelerini işle
            If TypeOf subItem Is ToolStripMenuItem Then
                subItem.BackColor = Color.FromArgb(40, 36, 36)
                subItem.ForeColor = Color.White
                ' Eğer daha fazla alt menü varsa, onları da değiştir
                ChangeSubMenuColors(DirectCast(subItem, ToolStripMenuItem))
            End If
        Next
    End Sub


    ' "Her Zaman Üstte" menü öğesine tıklama olayı
    Private Sub HerZamanÜstteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HerZamanÜstteToolStripMenuItem.Click
        ' CheckState değerini değiştir
        If HerZamanÜstteToolStripMenuItem.Checked Then
            HerZamanÜstteToolStripMenuItem.Checked = False ' Seçiliyse, işareti kaldır
            Me.TopMost = False
        Else
            HerZamanÜstteToolStripMenuItem.Checked = True ' Seçili değilse, işareti ekle
            Me.TopMost = True
        End If
    End Sub

    Private Sub ÇıkıToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ÇıkıToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub HonaViewerHakkındaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HonaViewerHakkındaToolStripMenuItem.Click
        about.Show()
    End Sub

    Private Sub picBox_BackgroundImageChanged(sender As Object, e As EventArgs) Handles picBox.BackgroundImageChanged
        If picBox.Image Is Nothing Then
            Label1.Visible = True

        Else
            Label1.Visible = False

        End If
    End Sub



    Private Sub SiyahToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SiyahToolStripMenuItem.Click
        Me.BackColor = Color.Black()
        Label1.ForeColor = Color.White()

        Dim dosyaYolu As String = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "honaviewer.txt")

        ' Dosya yoksa oluştur ve içine 1 yaz

        File.WriteAllText(dosyaYolu, "3")


    End Sub

    Private Sub BeyazToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BeyazToolStripMenuItem.Click
        Me.BackColor = Color.White()
        Label1.ForeColor = Color.Black()

        Dim dosyaYolu As String = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "honaviewer.txt")

        ' Dosya yoksa oluştur ve içine 1 yaz

        File.WriteAllText(dosyaYolu, "2")


    End Sub

    Private Sub GriToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GriToolStripMenuItem.Click
        Me.BackColor = Color.FromArgb(40, 36, 36)
        Label1.ForeColor = Color.White()

        Dim dosyaYolu As String = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "honaviewer.txt")

        ' Dosya yoksa oluştur ve içine 1 yaz
        File.WriteAllText(dosyaYolu, "1")


    End Sub


    Private Sub renkdegis()
        Dim dosyaYolu As String = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "honaviewer.txt")
        Dim renkAyar As String

        ' Dosya yoksa oluştur ve içine 1 yaz
        If Not File.Exists(dosyaYolu) Then
            File.WriteAllText(dosyaYolu, "1")
        End If

        ' Dosyanın içeriğini oku
        renkAyar = File.ReadAllText(dosyaYolu).Trim() ' Trim ile boşlukları temizle

        ' Metni göster
        Select Case renkAyar
            Case "1"
                Me.BackColor = Color.FromArgb(40, 36, 36)
                Label1.ForeColor = Color.White
            Case "2"
                Me.BackColor = Color.White
                Label1.ForeColor = Color.Black
            Case "3"
                Me.BackColor = Color.Black
                Label1.ForeColor = Color.White
            Case Else
                ' Geçersiz bir değer için bir işlem
                MessageBox.Show("Geçersiz renk ayarı!")
        End Select
    End Sub

    Private Sub picBox_Click(sender As Object, e As EventArgs) Handles picBox.Click

    End Sub

    Private Async Sub TamEkranToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TamEkranToolStripMenuItem.Click
        Dim screenWidth As Integer = Screen.PrimaryScreen.Bounds.Width
        Dim screenHeight As Integer = Screen.PrimaryScreen.Bounds.Height

        If picBox.Image Is Nothing Then
            Dim originalTitle As String = Me.Text
            Me.Text = "Önce bir resim açmalısınız."
            Await Task.Delay(2000)
            Me.Text = originalTitle
        Else
            Me.WindowState = FormWindowState.Maximized
            MenuStrip1.Visible = False
            Me.FormBorderStyle = FormBorderStyle.None

            Dim clientWidth As Integer = Me.ClientSize.Width
            Dim clientHeight As Integer = Me.ClientSize.Height
            picBox.Location = New Point(0, 0)
            picBox.Width = clientWidth
            picBox.Height = clientHeight

            Me.Width = screenWidth
            Me.Height = screenHeight
            Me.Location = New Point(0, 0)
            TamEkranToolStripMenuItem.Checked = True
            Me.WindowState = FormWindowState.Normal
            escbas.Visible = True
            Await Task.Delay(4000)
            escbas.Visible = False
        End If
    End Sub

    Private Sub escbas_Click(sender As Object, e As EventArgs) Handles escbas.Click
        escbas.Visible = False
    End Sub

    Private Sub Form1_KeyUp(sender As Object, e As KeyEventArgs) Handles MyBase.KeyUp
        If e.KeyCode = Keys.Escape AndAlso TamEkranToolStripMenuItem.Checked = True Then
            Try
                MenuStrip1.Visible = True
                Me.WindowState = FormWindowState.Maximized
                Me.Width = 684
                Me.Height = 583
                Me.FormBorderStyle = FormBorderStyle.Sizable
                Me.WindowState = FormWindowState.Normal
                Me.Location = New Point(70, 70)
                picBox.Location = New Point(0, 24)
                picBox.Width = 668
                picBox.Height = 521
                TamEkranToolStripMenuItem.Checked = False
                escbas.Visible = False
            Catch ex As Exception
                Return
            End Try
        End If
    End Sub

    Private Sub NormalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NormalToolStripMenuItem.Click
        picBox.SizeMode = PictureBoxSizeMode.Normal
    End Sub

    Private Sub ResmiUzatToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ResmiUzatToolStripMenuItem.Click
        picBox.SizeMode = PictureBoxSizeMode.StretchImage
    End Sub

    Private Sub ResmiOrtalaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ResmiOrtalaToolStripMenuItem.Click
        picBox.SizeMode = PictureBoxSizeMode.CenterImage
    End Sub

    Private Sub BüyütToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BüyütToolStripMenuItem.Click
        picBox.SizeMode = PictureBoxSizeMode.Zoom
    End Sub

    Private Sub ContextMenuStrip1_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles ContextMenuStrip1.Opening
        If MenuStrip1.Visible = False Then
            TamEkranModundanÇıkToolStripMenuItem.Enabled = True
        End If

        If MenuStrip1.Visible = True Then
            TamEkranModundanÇıkToolStripMenuItem.Enabled = False
        End If
    End Sub

    Private Sub TamEkranModundanÇıkToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TamEkranModundanÇıkToolStripMenuItem.Click
        Try
            MenuStrip1.Visible = True
            Me.WindowState = FormWindowState.Maximized
            Me.Width = 684
            Me.Height = 583
            Me.FormBorderStyle = FormBorderStyle.Sizable
            Me.WindowState = FormWindowState.Normal
            Me.Location = New Point(70, 70)
            picBox.Location = New Point(0, 24)
            picBox.Width = 668
            picBox.Height = 521
            TamEkranToolStripMenuItem.Checked = False
            escbas.Visible = False
        Catch ex As Exception
            Return
        End Try
    End Sub

    Private Async Sub PanoyaKopyalaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PanoyaKopyalaToolStripMenuItem.Click
        If picBox.Image Is Nothing Then
            Dim seredaraa As String
            seredaraa = Me.Text()
            Me.Text = "Önce bir resim açmalısınız."
            Await Task.Delay(2000)
            Me.Text = seredaraa

        Else
            Clipboard.SetImage(picBox.Image)
            Dim seredara As String
            seredara = Me.Text()
            Me.Text = "Panoya kopyalandı!"
            Await Task.Delay(1000)
            Me.Text = seredara

        End If
    End Sub


    Private Async Sub ResmiMasaüstüArkaPlanıOlarakAyarlaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ResmiMasaüstüArkaPlanıOlarakAyarlaToolStripMenuItem.Click
        If picBox.Image Is Nothing Then
            Dim seredara As String
            seredara = Me.Text()
            Me.Text = "Önce bir resim açmalısınız."
            Await Task.Delay(1000)
            Me.Text = seredara


        End If

        If picBox.Image IsNot Nothing Then

            Dim wallpaperPath As String = Path.Combine(Path.GetTempPath(), "wallpaper.jpg")
            picBox.Image.Save(wallpaperPath, System.Drawing.Imaging.ImageFormat.Jpeg)

            Dim result As Boolean = SystemParametersInfo(SPI_SETDESKWALLPAPER, 0, wallpaperPath, SPIF_UPDATEINIFILE Or SPIF_SENDCHANGE)

            If result Then
                Return
            Else
                MessageBox.Show("Masaüstü arka planı değiştirilemedi.")
            End If
        End If
    End Sub
End Class



