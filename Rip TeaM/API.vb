Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices
Imports System
Imports System.Collections
Imports System.Diagnostics
Imports System.IO
Imports System.Net
Imports System.Runtime.CompilerServices
Imports System.Security.Cryptography
Imports System.Text
Imports System.Text.RegularExpressions
Friend Class API
    Public Shared string_0 As String

    Public Shared string_1 As String

    Public Shared string_2 As String

    Public Shared string_3 As String

    Public Shared string_4 As String

    Public Shared string_5 As String

    Public Shared string_6 As String

    Public Shared string_7 As String

    Public Shared string_8 As String

    Public Shared string_9 As String

    Public Shared string_10 As String

    Public Shared cookieContainer_0 As CookieContainer

    Public Shared string_11 As String

    Public Shared string_12 As String

    Shared Sub New()
        API.string_0 = Nothing
        API.string_1 = Nothing
        API.string_2 = Nothing
        API.string_3 = Nothing
        API.string_4 = Nothing
        API.string_5 = Nothing
        API.string_6 = Nothing
        API.string_7 = Nothing
        API.string_8 = Nothing
        API.string_9 = Nothing
        API.cookieContainer_0 = New CookieContainer()
        API.string_11 = "https://i.instagram.com/api/v1/"
        API.string_12 = "Instagram 79.0.0.5.101 Android (16/4.1.2; 240dpi; 480x800; samsung; GT-S7390; kylevess; hawaii_ss_kylevess; nl_NL)"
    End Sub

    <DebuggerNonUserCode>
    Public Sub New()
        MyBase.New()
    End Sub

    Public Shared Function smethod_0(ByVal string_13 As String, ByVal string_14 As String) As Object
        Dim obj As Object = False
        Dim str As String = "signed_body="
        Dim guid As System.Guid = System.Guid.NewGuid()
        Dim str1 As String = String.Format("{{""device_id"":""{0}"",""username"":""{1}"",""password"":""{2}"",""login_attempt_count"":""0""}}", guid.ToString(), string_13, string_14)
        Dim str2 As String = String.Concat(API.smethod_3(str1), ".")
        Dim str3 As String = "&ig_sig_key_version=5"
        Try
            If (Not API.smethod_1(String.Concat(str, str2, str1, str3), "accounts/login/").Contains("logged_in_user")) Then
                Interaction.MsgBox("Error username or password !!", MsgBoxStyle.OkOnly, Nothing)
            Else
                obj = True
            End If
        Catch exception As System.Exception
            ProjectData.SetProjectError(exception)
            obj = False
            ProjectData.ClearProjectError()
        End Try
        Return obj
    End Function

    Public Shared Function smethod_1(ByVal string_13 As String, ByVal string_14 As String) As String
        Dim enumerator As IEnumerator = Nothing
        Dim enumerator1 As IEnumerator = Nothing
        Dim enumerator2 As IEnumerator = Nothing
        Dim [end] As String = Nothing
        Dim bytes As Byte() = Encoding.UTF8.GetBytes(string_13)
        Dim cookieContainer0 As HttpWebRequest = DirectCast(WebRequest.Create(String.Concat(API.string_11, string_14)), HttpWebRequest)
        cookieContainer0.Method = "POST"
        cookieContainer0.Accept = "*/*"
        cookieContainer0.KeepAlive = True
        cookieContainer0.CookieContainer = API.cookieContainer_0
        cookieContainer0.ContentType = "application/x-www-form-urlencoded; charset=UTF-8"
        cookieContainer0.Referer = "https://www.instagram.com/"
        cookieContainer0.UserAgent = API.string_12
        cookieContainer0.Timeout = 8000
        cookieContainer0.ContentLength = CLng(CInt(bytes.Length))
        cookieContainer0.Proxy = Nothing
        cookieContainer0.Headers.Add("X-IG-Connection-Type", "WIFI")
        cookieContainer0.Headers.Add("X-IG-Capabilities", "3ToAAA==")
        Try
            Using requestStream As Stream = cookieContainer0.GetRequestStream()
                requestStream.Write(bytes, 0, CInt(bytes.Length))
            End Using
            Dim response As HttpWebResponse = DirectCast(cookieContainer0.GetResponse(), HttpWebResponse)
            Using streamReader As System.IO.StreamReader = New System.IO.StreamReader(response.GetResponseStream())
                [end] = streamReader.ReadToEnd()
            End Using
            Try
                Try
                    Try
                        Try
                            enumerator2 = response.Cookies.GetEnumerator()
                            While enumerator2.MoveNext()
                                Dim objectValue As Object = RuntimeHelpers.GetObjectValue(enumerator2.Current)
                                Dim obj As Object = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(objectValue)))
                                Dim objectValue1 As Object = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(obj)))))
                                Dim obj1 As Object = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(objectValue1)))))))))))))))))
                                API.string_9 = String.Concat(API.string_9, obj1.ToString(), ";")
                            End While
                        Finally
                            If (TypeOf enumerator2 Is IDisposable) Then
                                TryCast(enumerator2, IDisposable).Dispose()
                            End If
                        End Try
                    Finally
                        If (TypeOf enumerator Is IDisposable) Then
                            TryCast(enumerator, IDisposable).Dispose()
                        End If
                    End Try
                Finally
                    If (TypeOf enumerator1 Is IDisposable) Then
                        TryCast(enumerator1, IDisposable).Dispose()
                    End If
                End Try
            Finally
            End Try
        Catch webException As System.Net.WebException
            ProjectData.SetProjectError(webException)
            Using streamReader1 As System.IO.StreamReader = New System.IO.StreamReader(webException.Response.GetResponseStream())
                [end] = streamReader1.ReadToEnd()
            End Using
            ProjectData.ClearProjectError()
        End Try
        Return [end]
    End Function

    Public Shared Function smethod_2() As Object
        Dim obj As Object = False
        Dim string12 As HttpWebRequest = DirectCast(WebRequest.Create("https://i.instagram.com/api/v1/accounts/current_user/?edit=true"), HttpWebRequest)
        string12.Method = "GET"
        string12.KeepAlive = True
        string12.UserAgent = API.string_12
        string12.Proxy = Nothing
        string12.CookieContainer = API.cookieContainer_0
        Try
            Using streamReader As System.IO.StreamReader = New System.IO.StreamReader(DirectCast(string12.GetResponse(), HttpWebResponse).GetResponseStream())
                Dim [end] As String = streamReader.ReadToEnd()
                API.string_0 = Regex.Match([end], "pk"": (.*?),").Groups(1).Value
                API.string_4 = Regex.Match([end], "full_name"": ""(.*?)""").Groups(1).Value
                API.string_3 = Regex.Match([end], "phone_number"": ""(.*?)""").Groups(1).Value
                API.string_6 = Regex.Match([end], "biography"": ""(.*?)""").Groups(1).Value
                API.string_1 = Regex.Match([end], "gender"": (.*?),").Groups(1).Value
                API.string_5 = Regex.Match([end], "email"": ""(.*?)""").Groups(1).Value
                API.string_2 = Regex.Match([end], "external_url"": ""(.*?)""").Groups(1).Value
                obj = True
            End Using
        Catch webException1 As System.Net.WebException
            ProjectData.SetProjectError(webException1)
            Dim webException As System.Net.WebException = webException1
            obj = False
            Using streamReader1 As System.IO.StreamReader = New System.IO.StreamReader(webException.Response.GetResponseStream())
            End Using
            ProjectData.ClearProjectError()
        End Try
        Return obj
    End Function

    Public Shared Function smethod_3(ByVal string_13 As String) As String
        Dim str As String = "5ad7d6f013666cc93c88fc8af940348bd067b68f0dce3c85122a923f4f74b251"
        Dim num As Integer = 0
        Dim stringBuilder As System.Text.StringBuilder = New System.Text.StringBuilder()
        Dim hMACSHA256 As System.Security.Cryptography.HMACSHA256 = New System.Security.Cryptography.HMACSHA256(Encoding.UTF8.GetBytes(str))
        hMACSHA256.ComputeHash(Encoding.UTF8.GetBytes(string_13))
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
End Class
