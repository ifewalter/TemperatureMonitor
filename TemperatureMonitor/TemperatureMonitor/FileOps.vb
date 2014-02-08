Module FIleOps
    Public Sub saveCalculations()

        Dim newstringb As New System.Text.StringBuilder
        newstringb.Append(Form1.divresult)
        newstringb.Append(",")
        ' newstringb.Append(Form1.wmn)
        ' newstringb.Append(",")
        newstringb.Append(Form1.tu)
        newstringb.Append(",")
        newstringb.Append(Form1.wmqshear)
        newstringb.Append(",")
        newstringb.Append(Form1.wmlambda)
        newstringb.Append(",")
        newstringb.Append(Form1.wmk)
        newstringb.Append(",")
        newstringb.Append(Form1.wmv)
        newstringb.Append(",")
        newstringb.Append(Form1.wmLchange)
        newstringb.Append(",")
        newstringb.Append(Form1.wmLfull)
        newstringb.Append(",")
        newstringb.Append(Form1.wmLinitial)
        newstringb.Append(",")
        newstringb.Append(Form1.wma)
        newstringb.Append(",")
        newstringb.Append(Form1.phi)
        newstringb.Append(",")

        newstringb.Append(Form1.tak)
        newstringb.Append(",")
        newstringb.Append(Form1.taa)
        newstringb.Append(",")
        newstringb.Append(Form1.talambda)
        newstringb.Append(",")

        newstringb.Append(Form1.taw)
        newstringb.Append(",")

        newstringb.Append(Form1.alpha)
        newstringb.Append(",")
        newstringb.Append(Form1.tchc)
        newstringb.Append(",")
        newstringb.Append(Form1.fs)
        newstringb.Append(",")
        newstringb.Append(Form1.ps)
        newstringb.Append(",")
        newstringb.Append(Form1.shp)
        newstringb.Append(",")
        newstringb.Append(Form1.wmvc)
        
        Dim counter3 As Integer = 1
        Try
            Do Until counter3 = 100
                newstringb.Append(",")
                newstringb.Append(Form1.wmx(counter3))
                newstringb.Append(",")
                newstringb.Append(Form1.wmz(counter3))
                newstringb.Append(",")
                newstringb.Append(Form1.tay(counter3))
                newstringb.Append(",")
                newstringb.Append(Form1.wmsolution1(counter3))
                newstringb.Append(",")
                newstringb.Append(Form1.wmsolution2(counter3))
                newstringb.Append(",")
                'newstringb.Append(Form1.wmsolution3(counter3))
                'newstringb.Append(",")
                newstringb.Append(Form1.wmsolution4(counter3))
                counter3 = counter3 + 1


                'recursively append to string builder

                'finally write string to file

                My.Computer.FileSystem.WriteAllText(My.Settings.CurrentWorkFile.ToString, newstringb.ToString, False)

            Loop

            MsgBox("File save complete")
        Catch ex As Exception
            MsgBox("File save complete")
        End Try

    End Sub



    Public Sub opencalcs()
        Try

        
            Dim counter4 As Integer = 1

            Using MyReader As New  _
    Microsoft.VisualBasic.FileIO.TextFieldParser(My.Settings.CurrentWorkFile.ToString)
                MyReader.TextFieldType = FileIO.FieldType.Delimited
                MyReader.SetDelimiters(",")
                Dim currentRow As String()
                While Not MyReader.EndOfData
                    'Try
                    currentRow = MyReader.ReadFields()
                    Dim currentField As String
                    For Each currentField In currentRow
                        Form1.valueindex(counter4) = currentField
                        counter4 = counter4 + 1
                    Next

                    Dim counter5 As Integer = 1
                    Form1.divresult = Form1.valueindex(counter5)
                    counter5 = counter5 + 1
                    'Form1.wmn = Form1.valueindex(counter5)
                    'counter5 = counter5 + 1
                    Form1.tu = Form1.valueindex(counter5)
                    counter5 = counter5 + 1
                    Form1.wmqshear = Form1.valueindex(counter5)
                    counter5 = counter5 + 1
                    Form1.wmlambda = Form1.valueindex(counter5)
                    counter5 = counter5 + 1
                    Form1.wmk = Form1.valueindex(counter5)
                    counter5 = counter5 + 1
                    Form1.wmv = Form1.valueindex(counter5)
                    counter5 = counter5 + 1
                    Form1.wmLchange = Form1.valueindex(counter5)
                    counter5 = counter5 + 1
                    Form1.wmLfull = Form1.valueindex(counter5)
                    counter5 = counter5 + 1
                    Form1.wmLinitial = Form1.valueindex(counter5)
                    counter5 = counter5 + 1
                    Form1.wma = Form1.valueindex(counter5)
                    counter5 = counter5 + 1
                    Form1.phi = Form1.valueindex(counter5)
                    counter5 = counter5 + 1
                    Form1.tak = Form1.valueindex(counter5)
                    counter5 = counter5 + 1
                    Form1.taa = Form1.valueindex(counter5)
                    counter5 = counter5 + 1
                    Form1.talambda = Form1.valueindex(counter5)
                    counter5 = counter5 + 1
                    Form1.taw = Form1.valueindex(counter5)
                    counter5 = counter5 + 1
                    Form1.alpha = Form1.valueindex(counter5)
                    counter5 = counter5 + 1
                    Form1.tchc = Form1.valueindex(counter5)
                    counter5 = counter5 + 1
                    Form1.fs = Form1.valueindex(counter5)
                    counter5 = counter5 + 1
                    Form1.ps = Form1.valueindex(counter5)
                    counter5 = counter5 + 1
                    Form1.shp = Form1.valueindex(counter5)
                    counter5 = counter5 + 1
                    Form1.wmvc = Form1.valueindex(counter5)
                    counter5 = counter5 + 1
                   

                    Dim counter6 As Integer
                    counter6 = counter5 + 100
                    Dim counter7 As Integer = 1

                    Do Until counter7 = 100

                        Form1.wmx(counter7) = Form1.valueindex(counter5)

                        counter5 = counter5 + 1

                        Form1.wmz(counter7) = Form1.valueindex(counter5)

                        counter5 = counter5 + 1

                        Form1.tay(counter7) = Form1.valueindex(counter5)

                        counter5 = counter5 + 1

                        Form1.wmsolution1(counter7) = Form1.valueindex(counter5)

                        counter5 = counter5 + 1

                        Form1.wmsolution2(counter7) = Form1.valueindex(counter5)

                        counter5 = counter5 + 1

                        'Form1.wmsolution3(counter7) = Form1.valueindex(counter5)

                        'counter5 = counter5 + 1

                        Form1.wmsolution4(counter7) = Form1.valueindex(counter5)
                        counter5 = counter5 + 1
                        counter7 = counter7 + 1
                    Loop

                    ActionsWindow.allsolutions()

                    '##################################
                    'Dim rwcnt As Integer

                    'rwcnt = Form1.DataGridView1.Rows.Count

                    'Dim newlength As Double = Form1.wmLinitial
                    'Dim counter2 As Integer

                    'Dim chser1 As New Windows.Forms.DataVisualization.Charting.Series
                    'Dim chser2 As New Windows.Forms.DataVisualization.Charting.Series
                    'Dim chser3 As New Windows.Forms.DataVisualization.Charting.Series
                    'Dim chser4 As New Windows.Forms.DataVisualization.Charting.Series

                    'chser1.Name = "Work material"
                    'chser2.Name = "Chip"
                    'chser3.Name = "Tool-Chip Interface"
                    'chser4.Name = "Qtool-Analysis"

                    ''#

                    'Dim counter10 As Integer = 1
                    'Dim soln1 As Double = 0
                    'Dim soln2 As Double = 0
                    'Dim soln3 As Double = 0
                    'Dim soln4 As Double = 0


                    'Do Until counter10 = Form1.divresult
                    '    soln1 = soln1 + Form1.wmsolution1(counter10)
                    '    soln2 = soln2 + Form1.wmsolution2(counter10)
                    '    soln3 = soln3 + Form1.wmsolution3(counter10)
                    '    soln4 = soln4 + Form1.wmsolution4(counter10)

                    '    chser1.Points.AddXY(newlength, Form1.wmsolution1(counter2))
                    '    chser2.Points.AddXY(newlength, Form1.wmsolution2(counter2))
                    '    chser3.Points.AddXY(newlength, Form1.wmsolution3(counter2))
                    '    chser4.Points.AddXY(newlength, Form1.wmsolution4(counter2))
                    '    counter10 = counter10 + 1
                    'Loop


                    'chser1.ChartType = DataVisualization.Charting.SeriesChartType.Spline
                    'chser2.ChartType = DataVisualization.Charting.SeriesChartType.Spline
                    'chser3.ChartType = DataVisualization.Charting.SeriesChartType.Spline
                    'chser4.ChartType = DataVisualization.Charting.SeriesChartType.Spline


                    'chser1.MarkerStyle = DataVisualization.Charting.MarkerStyle.Star5
                    'chser2.MarkerStyle = DataVisualization.Charting.MarkerStyle.Star5
                    'chser3.MarkerStyle = DataVisualization.Charting.MarkerStyle.Star5
                    'chser4.MarkerStyle = DataVisualization.Charting.MarkerStyle.Star5


                    'Form1.Chart1.Series.Add(chser1)
                    'Form1.Chart2.Series.Add(chser2)
                    'Form1.Chart3.Series.Add(chser3)
                    'Form1.Chart4.Series.Add(chser4)




                    'Form1.Chart5.Series.Add(chser1)
                    'Form1.Chart5.Series.Add(chser2)
                    'Form1.Chart5.Series.Add(chser3)
                    'Form1.Chart5.Series.Add(chser4)


                    'Form1.DataGridView1.Rows.Add()
                    'Form1.DataGridView1.Rows.Add()
                    'Form1.DataGridView1.Rows.Add("TOTAL", "", "", "", soln1.ToString, soln2.ToString, soln3.ToString, soln4.ToString)
                    'Form1.Chart1.Titles.Add("FIG 4.1: TEMPERATURE DISTRIBUTION IN THE WORK MATERIAL")

                    'Form1.Chart2.Titles.Add("FIG 4.2: TEMPEARTURE DISTRIBUTION IN THE CHIP")
                    'Form1.Chart3.Titles.Add("FIG 4.3: TEMPERATURE DISTRIBUTION IN THE TOOL-CHIP INTERFACE")
                    'Form1.Chart4.Titles.Add("FIG 4.4: TEMPERATURE DISTRIBUTION IN THE TOOL")
                    'Form1.Chart5.Titles.Add("FIG4.5: TEMPERATURE DISTRIBUTION IN WORK MATERIAL, CHIP," & vbCrLf & " THE TOOL-CHIP INTERFACE AND THE TOOL")




                    ' Catch ex As Microsoft.VisualBasic.FileIO.MalformedLineException
                    '  MsgBox("Invalid Project File")
                    ' Catch ex2 As Exception
                    'MsgBox(ex2.ToString)
                    'End Try

                End While
            End Using
        Catch ex As Exception
            MsgBox("Invalid Project File")
        End Try
    End Sub
End Module