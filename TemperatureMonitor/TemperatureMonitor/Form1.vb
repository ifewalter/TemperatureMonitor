Imports System.Drawing.Printing

Public Class Form1
    Public Const wmn As Double = 0.5
#Region "Work Material Definitions"

    Public wmqshear As Double = 0
    Public wmlambda As Double = 0
    Public wmk As Double = 0
    Public wmv As Double = 0
    Public wmLchange As Double = 0
    Public wmLfull As Double = 0
    Public wmLinitial As Double = 0
    Public wma As Double = 0
    Public phi As Double = 0
    Public tu As Double = 0
    Public fs As Double = 0
    Public ps As Double = 0
    Public shp As Double = 0
    Public wmvc As Double = 0
    Public tao As Double = 0

    Public wmEachL As Double()
    Public wmsolution1(100) As Double
    Public wmsolution2(100) As Double
    Public wmsolution3(100) As Double
    Public wmsolution4(100) As Double
    Public wmx(100) As Double
    Public wmz(100) As Double
    Public wmNewl(100) As Double

    Public divresult As Integer
#End Region
#Region "Chip Definitions"
    Public alpha As Double = 0
#End Region
#Region "Tool-Chip Interface"
    Public tchc As Double = 0
#End Region
#Region "Tool Analysis"
    Public tak As Double = 0
    Public taa As Double = 0
    Public talambda As Double = 0
    Public tay(100) As Double
    Public taw As Double = 0
#End Region


#Region "openFile"
    Public valueindex(2000) As Double
#End Region



    Private Sub Form1_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        saveDialog.Show()
    End Sub
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = Me.Text & "  -  " & My.Settings.CurrentWorkFile.ToString

        'TabControl1.Hide()
        Me.Width = (Screen.PrimaryScreen.Bounds.Width) - (ActionsWindow.Width)
        Me.Height = Screen.PrimaryScreen.Bounds.Height
        ActionsWindow.Left = Me.Width
        ActionsWindow.Show()
    End Sub
    Private Sub CustomizeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CustomizeToolStripMenuItem.Click
        ActionsWindow.Left = Me.Width
        ActionsWindow.Show()
    End Sub

    Private Sub Form1_MaximizedBoundsChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.MaximizedBoundsChanged
        If Me.Visible = True Then
            ActionsWindow.Visible = True
            WorkMaterialDefinition.Visible = True
            NewToolProperty.Visible = True

        ElseIf Me.Visible = False Then
            ActionsWindow.Visible = False
            WorkMaterialDefinition.Visible = False
            NewToolProperty.WindowState = FormWindowState.Minimized
        End If
    End Sub

    Private Sub Form1_MaximumSizeChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.MaximumSizeChanged
        If Me.Visible = True Then
            ActionsWindow.Visible = True
            WorkMaterialDefinition.Visible = True
            NewToolProperty.Visible = True

        ElseIf Me.Visible = False Then
            ActionsWindow.Visible = False
            WorkMaterialDefinition.Visible = False
            NewToolProperty.WindowState = FormWindowState.Minimized
        End If
    End Sub

    Private Sub Form1_MinimumSizeChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.MinimumSizeChanged
        If Me.Visible = True Then
            ActionsWindow.Visible = True
            WorkMaterialDefinition.Visible = True
            NewToolProperty.Visible = True

        ElseIf Me.Visible = False Then
            ActionsWindow.Visible = False
            WorkMaterialDefinition.Visible = False
            NewToolProperty.WindowState = FormWindowState.Minimized
        End If
    End Sub

    Private Sub Form1_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        If Me.WindowState = FormWindowState.Minimized Then
            ActionsWindow.Hide()
            WorkMaterialDefinition.Hide()
            NewToolProperty.Hide()
        End If
        If Me.WindowState = FormWindowState.Maximized Then
            ActionsWindow.Show()
            WorkMaterialDefinition.Show()
            NewToolProperty.Show()
            ActionsWindow.Visible = True
            WorkMaterialDefinition.Visible = True
            NewToolProperty.Visible = True

        End If
    End Sub
    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        saveDialog.Show()
    End Sub
    Private Sub SaveToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveToolStripButton.Click
        FIleOps.saveCalculations()
    End Sub

    Private Sub NewToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewToolStripButton.Click
        'Dim newfiledlg As New SaveFileDialog
        'newfiledlg.Filter = "Temperature Monitor File (*.tm)|*.tm"
        'newfiledlg.ShowDialog()
        'Try
        '    IO.File.Create(newfiledlg.FileName)
        'Catch ex As Exception
        '    MsgBox("Could Not Create File. Please Make sue you have Permissions to create file." & vbCrLf & "HINT: Try running the program as Administrator")
        'End Try

        'Me.Refresh()
        'ActionsWindow.Refresh()
        'WorkMaterialDefinition.Refresh()
        'NewToolProperty.Refresh()

        Application.Restart()

    End Sub

   

    Private Sub PrintToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintToolStripButton.Click

        PrintDGV.Print_DataGridView(DataGridView1)


        Chart1.Printing.PrintDocument = New PrintDocument()
        AddHandler Chart1.Printing.PrintDocument.PrintPage, AddressOf ChartPrinting.pd_PrintPage1

        Chart1.Printing.Print(True)


        Chart2.Printing.PrintDocument = New PrintDocument()
        AddHandler Chart2.Printing.PrintDocument.PrintPage, AddressOf ChartPrinting.pd_PrintPage2


        Chart2.Printing.Print(True)
        'Chart3.Printing.PrintDocument = New PrintDocument()
        ' AddHandler Chart3.Printing.PrintDocument.PrintPage, AddressOf ChartPrinting.pd_PrintPage3

        ' Chart3.Printing.Print(True)
        Chart4.Printing.PrintDocument = New PrintDocument()
        AddHandler Chart4.Printing.PrintDocument.PrintPage, AddressOf ChartPrinting.pd_PrintPage4

        Chart4.Printing.Print(True)
        Chart5.Printing.PrintDocument = New PrintDocument()
        AddHandler Chart5.Printing.PrintDocument.PrintPage, AddressOf ChartPrinting.pd_PrintPage5

        Chart5.Printing.Print(True)

    End Sub

    Private Sub SaveToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveToolStripMenuItem.Click
        Try
            FIleOps.saveCalculations()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub PrintToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintToolStripMenuItem.Click
        Chart1.Printing.PrintDocument = New PrintDocument()
        AddHandler Chart1.Printing.PrintDocument.PrintPage, AddressOf ChartPrinting.pd_PrintPage1

        Chart1.Printing.Print(True)

        Chart2.Printing.PrintDocument = New PrintDocument()
        AddHandler Chart2.Printing.PrintDocument.PrintPage, AddressOf ChartPrinting.pd_PrintPage2


        Chart2.Printing.Print(True)
        'Chart3.Printing.PrintDocument = New PrintDocument()
        'AddHandler Chart3.Printing.PrintDocument.PrintPage, AddressOf ChartPrinting.pd_PrintPage3

        'Chart3.Printing.Print(True)
        Chart4.Printing.PrintDocument = New PrintDocument()
        AddHandler Chart4.Printing.PrintDocument.PrintPage, AddressOf ChartPrinting.pd_PrintPage4

        Chart4.Printing.Print(True)
        Chart5.Printing.PrintDocument = New PrintDocument()
        AddHandler Chart5.Printing.PrintDocument.PrintPage, AddressOf ChartPrinting.pd_PrintPage5

        Chart5.Printing.Print(True)

    End Sub

    Private Sub PrintPreviewToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintPreviewToolStripMenuItem.Click
        Chart1.Printing.PrintDocument = New PrintDocument()
        AddHandler Chart1.Printing.PrintDocument.PrintPage, AddressOf ChartPrinting.pd_PrintPage1
        Chart1.Printing.PrintPreview()

        Chart2.Printing.PrintDocument = New PrintDocument()
        AddHandler Chart1.Printing.PrintDocument.PrintPage, AddressOf ChartPrinting.pd_PrintPage2
        Chart2.Printing.PrintPreview()

        'Chart3.Printing.PrintDocument = New PrintDocument()
        'AddHandler Chart1.Printing.PrintDocument.PrintPage, AddressOf ChartPrinting.pd_PrintPage3
        'Chart3.Printing.PrintPreview()

        Chart4.Printing.PrintDocument = New PrintDocument()
        AddHandler Chart1.Printing.PrintDocument.PrintPage, AddressOf ChartPrinting.pd_PrintPage4

        Chart4.Printing.PrintPreview()


        Chart5.Printing.PrintDocument = New PrintDocument()
        AddHandler Chart1.Printing.PrintDocument.PrintPage, AddressOf ChartPrinting.pd_PrintPage5

        Chart5.Printing.PrintPreview()

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If Timer1.Tag = 500 Then
            PictureBox1.BackgroundImage = My.Resources.heavy_duty_lathe_machine
        End If
        If Timer1.Tag = 1000 Then
            PictureBox1.BackgroundImage = My.Resources.Lathe_Machine_C6236_
        End If
        If Timer1.Tag = 1500 Then
            PictureBox1.BackgroundImage = My.Resources.lathemit1
        End If

    End Sub

    Private Sub HelpToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HelpToolStripMenuItem1.Click

        Help.Show()

    End Sub

   

    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        About.Show()
    End Sub

    Private Sub PrintDocument1_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage

    End Sub

    Private Sub NewToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewToolStripMenuItem.Click
        Application.Restart()
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
    End Sub

    Private Sub SaveAsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveAsToolStripMenuItem.Click
        SaveFileDialog1.Filter = "Temperature Monitor File (*.tm)|*.tm"
        SaveFileDialog1.ShowDialog()
    End Sub
  
End Class