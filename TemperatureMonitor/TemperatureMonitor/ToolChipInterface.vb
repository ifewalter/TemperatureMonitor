Public Class ToolChipInterface

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click
        Try
            Form1.tchc = InputBox("Please enter a avalue for Hc", Title:="Hc")
            label1.Enabled = True
        Catch ex As Exception
            MsgBox("Please enter a numeric value for Hc")
        End Try

    End Sub

    Private Sub ToolChipInterface_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        label1.enabled = False
        Label2.Enabled = False
        Label3.Enabled = False
        Me.Width = ActionsWindow.Width
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'SelectToolProperties.Show()
        NewToolProperty.Show()
    End Sub
    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click
        
    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click
        Label2.Text = "W  =  "
        Try
            Form1.taw = InputBox("Please enter the value W", Title:="W")
            ActionsWindow.Button3.Enabled = True
            Label2.Text = Label2.Text & "  =  " & Form1.taw
        Catch ex As Exception
            Form1.taw = 0
        End Try
    End Sub
End Class