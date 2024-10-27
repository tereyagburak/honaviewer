Imports System.Runtime.InteropServices

Public Class about
    'Başlık çubuğunu karanlık yapan eleman

    Private Const DWMWA_USE_IMMERSIVE_DARK_MODE As Integer = 20
    <DllImport("dwmapi.dll", PreserveSig:=True)>
    Public Shared Function DwmSetWindowAttribute(ByVal hwnd As IntPtr, ByVal attr As Integer, ByRef attrValue As Integer, ByVal attrSize As Integer) As Integer
    End Function
    Private Sub EnableDarkMode(hwnd As IntPtr, enable As Boolean)
        Dim useDarkMode As Integer = If(enable, 1, 0)
        DwmSetWindowAttribute(hwnd, DWMWA_USE_IMMERSIVE_DARK_MODE, useDarkMode, Marshal.SizeOf(useDarkMode))
    End Sub

    Private Sub about_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PictureBox1.Visible = False
        Me.TopMost = True

        EnableDarkMode(Me.Handle, True)

        Me.BackColor = Color.FromArgb(40, 36, 36)
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Process.Start("https://github.com/tereyagburak/honaviewer")
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        PictureBox1.Visible = True
    End Sub



End Class