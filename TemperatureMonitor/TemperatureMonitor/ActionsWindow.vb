Imports System.Windows.Forms.DataVisualization.Charting



Public Class ActionsWindow
    Dim calccounter As Integer = 0

    Private Sub ActionsWindow_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Button3.Enabled = False
        'WorkMaterialDefinition.Label1.Enabled = False
        'WorkMaterialDefinition.Label10.Enabled = False
        'WorkMaterialDefinition.Label12.Enabled = False
        'WorkMaterialDefinition.Label2.Enabled = False
        'WorkMaterialDefinition.Label3.Enabled = False
        'WorkMaterialDefinition.Label5.Enabled = False
        ''WorkMaterialDefinition.Label6.Enabled = False
        'WorkMaterialDefinition.Label8.Enabled = False
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        NewToolProperty.Show()

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If WorkMaterialDefinition.Visible = True Then
            ToolChipInterface.Top = Me.Height + WorkMaterialDefinition.Height
            ToolChipInterface.Left = Form1.Width
            ToolChipInterface.Show()
        Else
            ToolChipInterface.Top = Me.Height
            ToolChipInterface.Show()
        End If
    End Sub

    Public Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        allsolutions()
    End Sub

    Public Sub allsolutions()
        If calccounter < 1 Then

            NewToolProperty.Close()
            If Form1.wmlambda = 0 Then
                MsgBox("Please Define Material Properties (e.g Bessel Function...)")
            Else


                Try


                    Dim rwcnt As Integer

                    rwcnt = Form1.DataGridView1.Rows.Count

                    Dim newlength As Double = Form1.wmLinitial
                    Dim counter2 As Integer

                    Dim chser1 As New Series
                    Dim chser2 As New Windows.Forms.DataVisualization.Charting.Series
                    'Dim chser3 As New Windows.Forms.DataVisualization.Charting.Series
                    Dim chser4 As New Windows.Forms.DataVisualization.Charting.Series


                    chser1.Name = "Work material"
                    chser2.Name = "Chip"
                    'chser3.Name = "Tool-Chip Interface"
                    chser4.Name = "Qtool-Analysis"


                    counter2 = 1

                    Do Until counter2 = Form1.divresult Or newlength >= Form1.wmLfull
                        Form1.wmNewl(counter2) = newlength


                        Try
                            Form1.wmsolution1(counter2) = Math.Round(Main_Module.Chips(Form1.wmn, Form1.wmqshear, Form1.wmlambda, Form1.wmk, Form1.wmv, Form1.wma, Form1.wmx(counter2), Form1.wmz(counter2), newlength, Form1.phi, Form1.alpha, Form1.fs, Form1.ps, Form1.taw, Form1.shp), 3, MidpointRounding.ToEven)

                            Form1.wmsolution2(counter2) = Math.Round(Main_Module.Chips(Form1.wmn, Form1.wmqshear, Form1.wmlambda, Form1.wmk, Form1.wmvc, Form1.wma, Form1.wmx(counter2), Form1.wmz(counter2), newlength, Form1.phi, Form1.alpha, Form1.fs, Form1.ps, Form1.taw, Form1.shp), 3, MidpointRounding.ToEven)

                            '  Form1.wmsolution3(counter2) = Main_Module.toolchip(Form1.wmn, Form1.wmqshear, Form1.wmlambda, Form1.wmk, Form1.wmvc, newlength, Form1.wma, _
                            '                     Form1.wmx(counter2), Form1.wmz(counter2), Form1.tchc, Form1.fs, Form1.ps, Form1.shp, Form1.alpha, Form1.phi, Form1.taw)

                            Form1.wmsolution4(counter2) = Math.Round(Main_Module.toolanalysis(Form1.wmn, Form1.wmx(counter2), newlength, Form1.tay(counter2), Form1.taw, Form1.wmz(counter2), Form1.wmLfull, Form1.wmlambda, Form1.wmqshear, Form1.phi, Form1.alpha, Form1.shp, Form1.fs, Form1.taw, Form1.ps, Form1.wmvc), 3, MidpointRounding.ToEven)


                            Form1.DataGridView1.Rows.Add(Form1.wmx(counter2).ToString, Form1.wmz(counter2).ToString.ToString, Form1.wmLfull, newlength.ToString, Form1.wmsolution1(counter2).ToString, Form1.wmsolution2(counter2).ToString, Form1.wmsolution4(counter2).ToString)
                        Catch ex As Exception
                            Continue Do
                        End Try


                        chser1.Points.AddXY(newlength, Form1.wmsolution1(counter2))
                        chser2.Points.AddXY(newlength, Form1.wmsolution2(counter2))
                        ' chser3.Points.AddXY(newlength, Form1.wmsolution3(counter2))
                        chser4.Points.AddXY(newlength, Form1.wmsolution4(counter2))

                        chser1.ChartType = DataVisualization.Charting.SeriesChartType.Spline
                        chser2.ChartType = DataVisualization.Charting.SeriesChartType.Spline
                        ' chser3.ChartType = DataVisualization.Charting.SeriesChartType.Spline
                        chser4.ChartType = DataVisualization.Charting.SeriesChartType.Spline


                        chser1.MarkerStyle = DataVisualization.Charting.MarkerStyle.Circle
                        chser2.MarkerStyle = DataVisualization.Charting.MarkerStyle.Circle
                        ' chser3.MarkerStyle = DataVisualization.Charting.MarkerStyle.Circle
                        chser4.MarkerStyle = DataVisualization.Charting.MarkerStyle.Circle


                        counter2 = counter2 + 1
                        newlength = newlength + Form1.wmLchange

                    Loop

                    Try
                        Form1.Chart1.Series.Add(chser1)
                        Form1.Chart2.Series.Add(chser2)
                        ' Form1.Chart3.Series.Add(chser3)
                        Form1.Chart4.Series.Add(chser4)



                        Form1.Chart5.Series.Add(chser1)
                        Form1.Chart5.Series.Add(chser2)

                        Form1.Chart5.Series.Add(chser4)


                    Catch ex As Exception

                    End Try


                    Dim counter7 As Integer = 1
                    Dim soln1 As Double = 0
                    Dim soln2 As Double = 0
                    ' Dim soln3 As Double = 0
                    Dim soln4 As Double = 0

                    Do Until counter7 = Form1.divresult
                        soln1 = soln1 + Form1.wmsolution1(counter7)
                        soln2 = soln2 + Form1.wmsolution2(counter7)
                        '  soln3 = soln3 + Form1.wmsolution3(counter7)
                        soln4 = soln4 + Form1.wmsolution4(counter7)
                        counter7 = counter7 + 1
                    Loop

                    Form1.DataGridView1.Rows.Add()
                    Form1.DataGridView1.Rows.Add()
                    Form1.DataGridView1.Rows.Add("TOTAL", "", "", "", soln1.ToString, soln2.ToString, soln4.ToString)


                    Form1.Chart1.Titles.Add("FIG 4.1: TEMPERATURE DISTRIBUTION IN THE WORK MATERIAL")
                    Form1.Chart1.Titles(0).Docking = DataVisualization.Charting.Docking.Bottom
                    Form1.Chart2.Titles.Add("FIG 4.2: TEMPEARTURE DISTRIBUTION IN THE CHIP")
                    Form1.Chart2.Titles(0).Docking = DataVisualization.Charting.Docking.Bottom
                    ' Form1.Chart3.Titles.Add("FIG 4.3: TEMPERATURE DISTRIBUTION IN THE TOOL-CHIP INTERFACE")
                    ' Form1.Chart3.Titles(0).Docking = DataVisualization.Charting.Docking.Bottom
                    Form1.Chart4.Titles.Add("FIG 4.3: TEMPERATURE DISTRIBUTION IN THE TOOL")
                    Form1.Chart4.Titles(0).Docking = DataVisualization.Charting.Docking.Bottom
                    Form1.Chart5.Titles.Add("FIG 4.4: TEMPERATURE DISTRIBUTION IN WORK MATERIAL, CHIP," & vbCrLf & " AND THE TOOL")
                    Form1.Chart5.Titles(0).Docking = DataVisualization.Charting.Docking.Bottom

                Catch ex As Exception

                End Try
                Form1.PictureBox1.Visible = False




            End If

            calccounter = 1


            Dim newstringb2 As New System.Text.StringBuilder
            newstringb2.Append("Heat Flux Inensity = " & Form1.wmqshear.ToString)
            newstringb2.Append(vbCrLf)
            newstringb2.Append("Full Length of Material = " & Form1.wmLfull.ToString)
            newstringb2.Append(vbCrLf)
            newstringb2.Append("Shear Force = " & Form1.fs.ToString)
            newstringb2.Append(vbCrLf)
            newstringb2.Append("Shear Speed = " & Form1.wmvc.ToString)
            newstringb2.Append(vbCrLf)
            newstringb2.Append("Spindle Speed = " & Form1.wmv.ToString)
            Form1.RichTextBox1.Text = newstringb2.ToString
        End If
    End Sub


End Class
