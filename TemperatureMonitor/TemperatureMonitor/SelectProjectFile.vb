Public Class SelectProjectFile
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Application.Exit()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        If RadioButton1.Checked = True Then
            SaveFileDialog1.Filter = "Temperature Monitor File (*.tm)|*.tm"
            SaveFileDialog1.ShowDialog()
        ElseIf RadioButton2.Checked = True Then
            OpenFileDialog1.FileName = ""
            OpenFileDialog1.Filter = "Temperature Monitor File (*.tm)|*.tm"
            OpenFileDialog1.ShowDialog()
        End If
    End Sub

    Private Sub SaveFileDialog1_FileOk(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles SaveFileDialog1.FileOk
        My.Settings.CurrentWorkFile = SaveFileDialog1.FileName
        'SelectUnitSystem.Show()
        Try
            IO.File.Create(SaveFileDialog1.FileName)
            My.Settings.CurrentWorkFile = SaveFileDialog1.FileName
        Catch ex As Exception
            MsgBox("Could Not Create File. Please Make sue you have Permissions to create file." & vbCrLf & "HINT: Try running the program as Administrator")
        End Try
        Form1.Show()
        ActionsWindow.Visible = True
        Me.Close()
    End Sub

    Private Sub OpenFileDialog1_FileOk(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk
        My.Settings.CurrentWorkFile = OpenFileDialog1.FileName


        FIleOps.opencalcs()

        'MsgBox(Form1.wmn)


        ' SelectUnitSystem.Show()
        Form1.Show()
        ActionsWindow.Visible = True
        Me.Close()
    End Sub

    Private Sub SelectProjectFile_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Me.Show()
        'ActionsWindow.Visible = False
        'Me.Visible = False
    End Sub
End Class