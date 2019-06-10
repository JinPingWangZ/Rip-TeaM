Imports Rip_TeaM.My
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Net
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms

Public Class KingFHD

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim str As String = (New WebClient()).DownloadString("https://pastebin.com/raw/7mt1J8Um")
        If (Operators.CompareString(Me.TextBox1.Text, str, False) <> 0) Then
            Interaction.MsgBox("For more Info Dm :@KingFHD", MsgBoxStyle.OkOnly, Nothing)
            Me.Close()
        End If
        Me.Hide()
        MyProject.Forms.Form1.Show()
    End Sub
End Class
