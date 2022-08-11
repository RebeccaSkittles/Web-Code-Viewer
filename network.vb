Imports System.IO
Imports System.Net
Public Class network
    Public Shared reqest As WebRequest = WebRequest.Create(Form1.url_box.Text)
    Public Shared response As HttpWebResponse = CType(reqest.GetResponse(), HttpWebResponse)
    Public Shared datastream As Stream = response.GetResponseStream
    Public Shared reader As New StreamReader(datastream)
    Public Shared strData As String = reader.ReadToEnd
End Class
