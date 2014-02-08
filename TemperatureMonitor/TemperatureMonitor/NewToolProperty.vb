Public Class NewToolProperty

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Try
            Dim qshear, vs, vc, fs, kab, l, tc, anglediff As Double
            Form1.tu = tubox.Text
            Form1.wmv = vbox.Text
            Form1.phi = sabox.Text
            Form1.alpha = rabox.Text
            Form1.fs = taobox.Text
            Form1.ps = epsibox.Text
            Form1.taw = swbox.Text
            Form1.shp = shpbox.Text



            anglediff = Form1.phi - Form1.alpha

            kab = Form1.fs * Math.Pow(Form1.ps, Form1.shp)
            kab = kab / Math.Sqrt(3)

            fs = kab * Form1.tu * Form1.taw

            l = Math.Sin((Math.PI * Form1.phi) / 180)
            l = Form1.tu / l

            tc = (Form1.tu * Math.Cos(Math.PI * anglediff / 180)) / (Math.Sin(Math.PI * Form1.phi / 180))

            vs = (Form1.wmv * Math.Cos(Math.PI * Form1.alpha / 180)) / (Math.Cos(Math.PI * anglediff / 180))
            vc = (Form1.wmv * Math.Sin(Math.PI * Form1.phi / 180)) / (Math.Cos(Math.PI * anglediff / 180))

            qshear = l * Form1.taw
            qshear = fs * vs / qshear


            TextBox8.Text = Math.Round(qshear, 3, MidpointRounding.ToEven)
            TextBox7.Text = Math.Round(l, 3, MidpointRounding.ToEven)
            TextBox10.Text = Math.Round(fs, 3, MidpointRounding.ToEven)
            TextBox11.Text = Math.Round(vc, 3, MidpointRounding.ToEven)


            Form1.wmLfull = Math.Round(l, 3, MidpointRounding.ToEven)
            Form1.fs = Math.Round(fs, 3, MidpointRounding.ToEven)
            Form1.wmvc = Math.Round(vc, 3, MidpointRounding.ToEven)
            Form1.wmqshear = Math.Round(qshear, 3, MidpointRounding.ToEven)

        Catch ex As Exception
            Form1.wmk = 0
            Form1.wma = 0
            Form1.wmlambda = 0

            MsgBox("Please redefine tool properties")
        End Try

        If WorkMaterialDefinition.Visible = False Then
            WorkMaterialDefinition.Show()
        End If
    End Sub

    Private Sub TextBox1_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles tubox.Enter
        tubox.Text = ""
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tubox.TextChanged

    End Sub

    Private Sub TextBox12_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles shpbox.Enter
        shpbox.Text = ""
    End Sub

    Private Sub TextBox2_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles vbox.Enter
        vbox.Text = ""
    End Sub

    Private Sub TextBox3_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles rabox.Enter
        rabox.Text = ""
    End Sub

    Private Sub TextBox4_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles sabox.Enter
        sabox.Text = ""
    End Sub

    Private Sub TextBox5_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles taobox.Enter
        taobox.Text = ""
    End Sub

    Private Sub TextBox6_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles epsibox.Enter
        epsibox.Text = ""
    End Sub

    Private Sub TextBox9_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles swbox.Enter
        swbox.Text = ""
    End Sub

    Private Sub NewToolProperty_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            tubox.Text = Form1.tu
            vbox.Text = Form1.wmv
            sabox.Text = Form1.phi
            rabox.Text = Form1.alpha
            taobox.Text = Form1.fs
            epsibox.Text = Form1.ps
            swbox.Text = Form1.taw
            shpbox.Text = Form1.shp
        Catch ex As Exception

        End Try

    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub

    Private Sub NewToolProperty_MinimumSizeChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.MinimumSizeChanged

    End Sub

    Private Sub shpbox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles shpbox.TextChanged

    End Sub

    Private Sub taobox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles taobox.TextChanged

    End Sub
End Class