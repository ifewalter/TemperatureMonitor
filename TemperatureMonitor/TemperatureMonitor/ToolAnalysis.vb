Public Class ToolAnalysis

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click
        'Label1.Text = "Chip Angle"
        'Try
        '    Form1.tay = InputBox("Please enter the value of Y", Title:="Y")
        '    Label2.Enabled = True
        '    Label1.Text = Label1.Text & "  =  " & Form1.tay
        'Catch ex As Exception
        '    Form1.tay = 0
        'End Try
    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click
        Label2.Text = "Chip Angle"
        Try
            Form1.taw = InputBox("Please enter the value W", Title:="W")
            ActionsWindow.Button3.Enabled = True
            Label2.Text = Label2.Text & "  =  " & Form1.taw
        Catch ex As Exception
            Form1.taw = 0
        End Try
    End Sub

End Class