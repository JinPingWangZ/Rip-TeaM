Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Globalization
Imports System.IO
Imports System.Net
Imports System.Runtime.CompilerServices
Imports System.Security.Cryptography
Imports System.Text
Imports System.Threading
Imports System.Windows.Forms

Public Class Form1

    Public bool_0 As Boolean

    Public int_0 As Integer

    Public string_0 As String

    Public string_1 As String

    Public Boolean0 As Boolean

    Public Point0 As Point

    Public point_0 As Point

    Public Sub New()
        MyBase.New()
        Dim form11 As Form1 = Me
        AddHandler MyBase.Load, New EventHandler(AddressOf form11.Form1_Load)
        Form1.__ENCAddToList(Me)
        Dim form12 As Form1 = Me
        AddHandler MyBase.Load, New EventHandler(AddressOf form12.Form1_Load)
        Me.bool_0 = False
        Me.string_1 = "Instagram 79.0.0.5.101 Android (16/4.1.2; 240dpi; 480x800; samsung; GT-S7390; kylevess; hawaii_ss_kylevess; nl_NL)"
        Me.InitializeComponent()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim [integer] As Integer = Conversions.ToInteger(Me.THREADZ.Text) * 3
        Try
            If (Operators.CompareString(Me.user.Text, "", False) = 0) Then
                Interaction.MsgBox(" Username!", MsgBoxStyle.OkOnly, "xD")
            ElseIf (Operators.CompareString(Me.pass.Text, "", False) = 0) Then
                Interaction.MsgBox("Password!", MsgBoxStyle.OkOnly, "xD")
            ElseIf (Conversions.ToBoolean(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(API.smethod_0(Me.user.Text, Me.pass.Text)))))))) Then
                If (Not Conversions.ToBoolean(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(API.smethod_2()))))))) Then
                    Interaction.MsgBox("Error Information!", MsgBoxStyle.OkOnly, "xD")
                ElseIf (Not Conversions.ToBoolean(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(Me.method_7(Me.target.Text)))))))) Then
                    Dim thread As System.Threading.Thread = New System.Threading.Thread(Sub(a0 As Object) Me.method_4(), 100)
                    thread.Start(Conversions.ToDouble([integer]) - 1)
                    GC.Collect()
                Else
                    Me.bool_0 = True
                End If
            End If
        Catch exception1 As System.Exception
            ProjectData.SetProjectError(exception1)
            Dim exception As System.Exception = exception1
            Interaction.MsgBox(String.Concat("Error : ", exception.Message), MsgBoxStyle.OkOnly, Nothing)
            ProjectData.EndApp()
            ProjectData.ClearProjectError()
        End Try
    End Sub
    Private Function method_4() As Object
        Dim obj As Object = Nothing
        Conversions.ToInteger(Me.THREADZ.Text)
        While Not Me.bool_0
            Try
                Using webClient As System.Net.WebClient = New System.Net.WebClient()
                    ServicePointManager.DefaultConnectionLimit = 600
                    ServicePointManager.UseNagleAlgorithm = False
                    ServicePointManager.Expect100Continue = False
                    webClient.Proxy = Nothing
                    webClient.Headers.Add("User-Agent", "Instagram 79.0.0.5.101 Android (16/4.1.2; 240dpi; 480x800; samsung; GT-S7390; kylevess; hawaii_ss_kylevess; nl_NL")
                    webClient.Headers.Add("Cookie", API.string_9)
                    If (Operators.CompareString(webClient.DownloadString(String.Concat("https://i.instagram.com/api/v1/feed/user/", Me.target.Text, "/username/")), "{""items"": [], ""num_results"": 0, ""status"": ""ok""}", False) <> 0) Then
                        Me.int_0 = Me.int_0 + 1
                        Me.COUNTS.Text = Conversions.ToString(Me.int_0)
                    ElseIf (Conversions.ToBoolean(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(Me.method_7(Me.target.Text)))))))) Then
                        Me.bool_0 = True
                    End If
                    webClient.Dispose()
                End Using
                Thread.Sleep(0)
            Catch exception1 As System.Exception
                ProjectData.SetProjectError(exception1)
                Try
                    Dim text() As String = {"https://i.instagram.com/api/v1/users/search?q=", Me.target.Text, "&access_token=", Nothing, Nothing}
                    Dim guid As System.Guid = System.Guid.NewGuid()
                    text(3) = guid.ToString().ToUpper()
                    text(4) = "/"
                    If ((Me.method_5(String.Concat(text)).Contains(String.Concat("""username"": """, Me.target.Text, """")) Or 0) <> 0) Then
                        Me.int_0 = Me.int_0 + 1
                        Me.COUNTS.Text = Conversions.ToString(Me.int_0)
                    ElseIf (Conversions.ToBoolean(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(Me.method_7(Me.target.Text)))))))) Then
                        Me.bool_0 = True
                    End If
                Catch exception As System.Exception
                    ProjectData.SetProjectError(exception)
                    ProjectData.ClearProjectError()
                End Try
                Thread.Sleep(0)
                ProjectData.ClearProjectError()
            End Try
        End While
        Return obj
    End Function

    Public Function method_5(ByVal string_2 As String) As String
        Dim [end] As String
        Dim cookieContainer0 As HttpWebRequest = DirectCast(WebRequest.Create(string_2), HttpWebRequest)
        cookieContainer0.Method = "GET"
        cookieContainer0.KeepAlive = True
        cookieContainer0.CookieContainer = API.cookieContainer_0
        cookieContainer0.UserAgent = Me.string_1
        cookieContainer0.Proxy = Nothing
        cookieContainer0.Headers.Add("X-IG-Connection-Type", "WiFi")
        cookieContainer0.Headers.Add("X-IG-Capabilities", "3ToAAA==")
        Try
            Dim response As HttpWebResponse = DirectCast(cookieContainer0.GetResponse(), HttpWebResponse)
            [end] = (New System.IO.StreamReader(response.GetResponseStream())).ReadToEnd()
        Catch webException As System.Net.WebException
            ProjectData.SetProjectError(webException)
            Dim streamReader As System.IO.StreamReader = New System.IO.StreamReader(webException.Response.GetResponseStream())
            [end] = streamReader.ReadToEnd()
            ProjectData.ClearProjectError()
        End Try
        Return [end]
    End Function

    Public Function method_7(ByVal string_2 As String) As Object
        Dim str As String = "signed_body="
        Dim string1() As Object = {API.string_1, API.string_7, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing}
        string1(2) = Guid.NewGuid().ToString()
        string1(3) = API.string_0
        string1(4) = API.string_2
        string1(5) = string_2
        string1(6) = API.string_5
        string1(7) = API.string_3
        string1(8) = API.string_6
        string1(9) = ""
        Dim str1 As String = String.Format("{{""gender"":""{0}"",""_csrftoken"":""{1}"",""_uuid"":""{2}"",""_uid"":""{3}"",""external_url"":""{4}"",""username"":""{5}"",""email"":""{6}"",""phone_number"":""{7}"",""biography"":""{8}"",""first_name"":""Rip TeaM""}}", string1)
        Dim str2 As String = String.Concat(Form1.smethod_1(str1), ".")
        Dim str3 As String = "&ig_sig_key_version=5"
        Dim obj As Object = False
        Try
            Dim cookieContainer0 As HttpWebRequest = DirectCast(WebRequest.Create("https://i.instagram.com/api/v1/accounts/edit_profile/"), HttpWebRequest)
            cookieContainer0.Method = "POST"
            cookieContainer0.KeepAlive = True
            cookieContainer0.CookieContainer = API.cookieContainer_0
            cookieContainer0.ContentType = "application/x-www-form-urlencoded"
            cookieContainer0.UserAgent = "Instagram 79.0.0.5.101 Android (16/4.1.2; 240dpi; 480x800; samsung; GT-S7390; kylevess; hawaii_ss_kylevess; nl_NL)"
            cookieContainer0.AllowAutoRedirect = True
            cookieContainer0.Proxy = Nothing
            cookieContainer0.Timeout = 8000
            cookieContainer0.Headers.Add("X-IG-Connection-Type", "WIFI")
            cookieContainer0.Headers.Add("X-IG-Capabilities", "3ToAAA==")
            Using requestStream As Stream = cookieContainer0.GetRequestStream()
                Dim bytes As Byte() = Encoding.UTF8.GetBytes(String.Concat(str, str2, str1, str3))
                requestStream.Write(bytes, 0, CInt(bytes.Length))
            End Using
            If (DirectCast(cookieContainer0.GetResponse(), HttpWebResponse).StatusCode = HttpStatusCode.OK) Then
                Me.Button1.Text = "Claimed"
                Me.Button1.ForeColor = Color.Lime
                Interaction.MsgBox(String.Concat(" - Rip @", Me.target.Text), MsgBoxStyle.OkOnly, String.Concat("Done @", Me.target.Text))
                obj = True
            End If
        Catch webException1 As System.Net.WebException
            ProjectData.SetProjectError(webException1)
            Dim webException As System.Net.WebException = webException1
            Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo("en-US")
            Using streamReader As System.IO.StreamReader = New System.IO.StreamReader(DirectCast(webException.Response, HttpWebResponse).GetResponseStream())
                If (streamReader.ReadToEnd().Contains("feedback_")) Then
                    Me.COUNTS.Text = Conversions.ToString(Me.int_0)
                    Interaction.MsgBox("Your Account is Blocked", MsgBoxStyle.OkOnly, Nothing)
                    obj = False
                End If
                obj = False
            End Using
            ProjectData.ClearProjectError()
        End Try
        Return obj
    End Function
    Public Shared Function smethod_1(ByVal string_2 As String) As String
        Dim str As String = "5ad7d6f013666cc93c88fc8af940348bd067b68f0dce3c85122a923f4f74b251"
        Dim num As Integer = 0
        Dim stringBuilder As System.Text.StringBuilder = New System.Text.StringBuilder()
        Dim hMACSHA256 As System.Security.Cryptography.HMACSHA256 = New System.Security.Cryptography.HMACSHA256(Encoding.UTF8.GetBytes(str))
        hMACSHA256.ComputeHash(Encoding.UTF8.GetBytes(string_2))
        Dim hash As Byte() = hMACSHA256.Hash
        Dim length As Integer = CInt(hash.Length) - 1
        Dim num1 As Integer = 0
        While num1 <= num
            Dim num2 As Byte = hash(num1)
            stringBuilder.Append(num2.ToString("x2"))
            num1 = num1 + 1
            num = length
        End While
        Return stringBuilder.ToString()
    End Function

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Me.Close()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Control.CheckForIllegalCrossThreadCalls = False
        ThreadPool.SetMinThreads(2147483647, 2147483647)
        ServicePointManager.DefaultConnectionLimit = 2147483647
    End Sub
End Class