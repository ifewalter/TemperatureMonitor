Public Class SelectUnitSystem

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If SIRadio1.Checked = True Then
            My.Settings.UnitSystem = "International System"
        End If

        If MetricRadio.Checked = True Then
            My.Settings.UnitSystem = "Metric System"
        End If

        Form1.Show()
        Me.Close()

    End Sub

    Private Sub SelectUnitSystem_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class