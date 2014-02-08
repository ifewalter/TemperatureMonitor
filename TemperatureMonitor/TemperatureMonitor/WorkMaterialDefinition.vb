Public Class WorkMaterialDefinition

    Private Sub WorkMaterialDefinition_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


        Me.Width = ActionsWindow.Width
        Me.Top = ActionsWindow.Height

        Me.Left = Form1.Width



        'Label1.Text = "Work : Heat (Л)"
        'Label2.Text = "Heat Generation Intensity"
        'Label5.Text = "Speed"
        ''Label6.Text = "Shear length"
        'Label8.Text = "Change in Shear Length"
        'Label10.Text = "x,  z      "
        'Label12.Text = "Angle"
        'Label3.Text = "Chip Angle"
    End Sub

    'Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    Label1.Text = "Work : Heat (Л) = " & Form1.wmn
    '    Try
    '        Form1.wmn = InputBox("Please Enter the Work to Heat ratio value", Title:="Work to Heat Ratio")
    '        'Label2.Enabled = True
    '        Label1.Text = "Work : Heat (Л) = " & Form1.wmn
    '    Catch ex As Exception
    '        Form1.wmn = 0
    '    End Try
    'End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'SelectFromExistingWorkMaterial.ShowDialog()
        NewWorkMaterial.Show()
        'Label1.Enabled = True
        Label10.Enabled = True
        'Label12.Enabled = True
        ' Label2.Enabled = True
        ' Label3.Enabled = True
        'Label5.Enabled = True
        'Label6.Enabled = true
        Label8.Enabled = True
    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ' Label2.Text = "Undeformed Chip Thickness"

        Try
            Form1.wmqshear = InputBox("Please enter the Undeformed Chip Thickness", Title:="Undeformed Chip Thickness")
            'Label5.Enabled = True
            ' Label2.Text = Label2.Text & " = " & Form1.wmqshear
        Catch ex As Exception
            Form1.wmqshear = 0
        End Try
    End Sub

    Private Sub Label5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Label5.Text = "Spindle Speed"
        Try
            Form1.wmv = InputBox("Please Enter the cutting Speed", Title:="V")
            'Label6.Enabled = True
            'Label5.Text = Label5.Text & " = " & Form1.wmv
        Catch ex As Exception
            Form1.wmv = 0
        End Try
    End Sub

    'Private Sub Label6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    Label6.Text = "Shear length"
    '    Try
    '        Form1.wmLfull = InputBox("Please enter the length of the Material", Title:="L")
    '        Label8.Enabled = True
    '        Label6.Text = Label6.Text & " = " & Form1.wmLfull
    '    Catch ex As Exception
    '        Form1.wmLfull = 0
    '    End Try
    'End Sub

    Private Sub Label8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label8.Click
        Label8.Text = "Change in Shear Length (mm) = " & Form1.wmLchange
        Try
            Form1.wmLchange = InputBox("Please input the intervals at which temerature will be measured (mm)", Title:="Change in L (mm)")

        Catch ex As Exception

        End Try
        Label8.Text = "Change in Shear Length (mm) = " & Form1.wmLchange
    End Sub

    Private Sub Label10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label10.Click
        Label10.Text = "x, y,  z (mm)"
        Dim divresult As Integer
        Dim counter As Integer = 1

        divresult = Form1.wmLfull / Form1.wmLchange
        Form1.divresult = divresult + 1
        Do Until counter = Form1.divresult
            Try
                Form1.wmx(counter) = InputBox("Please enter a value for X, Y and Z (mm)", Title:="X,Y,Z (mm)")
                Form1.wmz(counter) = Form1.wmx(counter)
                Form1.tay(counter) = Form1.wmx(counter)
            Catch ex As Exception
                MsgBox("Error")
            End Try
            counter = counter + 1
        Loop
        'Label12.Enabled = True
        Label10.Text = Label10.Text & " = (Defined)"

    End Sub

    Private Sub Label12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Label12.Text = "Angle"
        Try
            Form1.phi = InputBox("Please enter the angle for the work material", Title:=" Cutting Ө")
            '  Label12.Text = Label12.Text & "  =  " & Form1.wmtheta
            '  Label3.Enabled = True
        Catch ex As Exception
            Form1.phi = 0
            MsgBox("Please enter a numeric value")
        End Try
    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ' Label3.Text = "Chip Angle"
        Try
            Form1.alpha = InputBox("Please enter the calculating angle for the chip", Title:="Chip Ө")
            'Label3.Text = Label3.Text & "  =  " & Form1.ctheta
        Catch ex As Exception
            Form1.alpha = 0
        End Try
    End Sub

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.Click
        Label4.Text = "Height  (mm)  =  " & Form1.tchc
        Try
            Form1.tchc = InputBox("Please enter a avalue for Hc  (mm)", Title:="Hc  (mm)")
            Label4.Text = "Height  (mm)  =  " & Form1.tchc
        Catch ex As Exception
            MsgBox("Please enter a numeric value for Hc")
        End Try
    End Sub

    Private Sub Label9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ' Label9.Text = "Flow Stress"


        Try
            Form1.fs = InputBox("Please enter a value for Flow Stress", Title:="Fs")
        Catch ex As Exception
            MsgBox("Error")
        End Try

        'Label9.Text = Label9.Text & " = " & Form1.fs
    End Sub

    Private Sub Label7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ' Label7.Text = "W     "
        Try
            Form1.taw = InputBox("Please enter the value W", Title:="W")

            '     Label7.Text = Label7.Text & "  =  " & Form1.taw
        Catch ex As Exception
            Form1.taw = 0
        End Try
    End Sub

    Private Sub Label11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        '  Label11.Text = "Plastic Stream"
        Try
            Form1.ps = InputBox("Please enter the value for Plastic Stream", Title:="Plastic Stream")
            ActionsWindow.Button3.Enabled = True
            ' Label11.Text = Label11.Text & "  =  " & Form1.ps
        Catch ex As Exception
            Form1.ps = 0
        End Try
    End Sub

    Private Sub Label6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        ' Label6.Text = "Strain Hardening Parameter"
        Try
            Form1.shp = InputBox("Please enter the Strain Hardening Parameter", Title:="Strain Hardening Parameter")

            '    Label6.Text = Label6.Text & "  =  " & Form1.shp
        Catch ex As Exception
            Form1.shp = 0
        End Try
    End Sub

    Private Sub Label2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click
        Label2.Text = "Initial Shear Length (mm) =  " & Form1.wmLinitial

        Try
            Form1.wmLinitial = InputBox("Please enter the initial shear length  (mm)", Title:="Initial Shear Length (mm)")

            Label2.Text = "Initial Shear Length (mm) =  " & Form1.wmLinitial
        Catch ex As Exception
            Form1.wmLinitial = 0
        End Try
    End Sub

    'Private Sub Label3_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    Label3.Text = "y   "
    '    Dim divresult As Integer
    '    Dim counter As Integer = 1

    '    divresult = Form1.wmLfull / Form1.wmLchange
    '    Form1.divresult = divresult + 1
    '    Do Until counter = Form1.divresult
    '        Try
    '            Form1.tay(counter) = InputBox("Please enter a value for Y", Title:="Y")
    '        Catch ex As Exception
    '            MsgBox("Error")
    '        End Try
    '        counter = counter + 1
    '    Loop
    '    Label3.Text = Label3.Text & " = (Defined)"

    'End Sub
End Class