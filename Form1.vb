
Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        url_display.Hide()
        Button2.Hide()
        Label1.Hide()
        Button3.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        URL.Hide()
        url_box.Hide()
        Button1.Hide()
        url_display.Show()
        Button2.Show()
        Label1.Show()
        Button3.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        url_display.Hide()
        url_box.Text() = ""
        url_display.Text() = ""
        URL.Show()
        url_box.Show()
        Button1.Show()
        Button2.Hide()
        Label1.Hide()
        Button3.Hide()
    End Sub

    Private Sub url_display_TextChanged(sender As Object, e As EventArgs) Handles url_display.TextChanged
        url_display.Text() = network.strData
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        save_data.ShowDialog()
        save_data.Filter = "Web Data(*.txt)|*.text"
        If DialogResult.OK Then
            IO.File.WriteAllText(save_data.FileName, url_display.Text)
        End If

    End Sub
End Class
