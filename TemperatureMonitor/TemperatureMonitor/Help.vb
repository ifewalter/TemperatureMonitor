Public Class Help

    Private Sub Help_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim hj As String
        hj = Application.StartupPath.ToString

        WebBrowser1.Navigate(hj & "/Temperature monitor help file2.mht")
    End Sub
End Class