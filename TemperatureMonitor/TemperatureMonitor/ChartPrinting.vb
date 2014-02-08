Imports System.Drawing.Printing

Module ChartPrinting

    Public Sub pd_PrintPage1(ByVal sender As Object, ByVal ev As PrintPageEventArgs)

        ' Calculate title string position
        Dim titlePosition As New Rectangle(ev.MarginBounds.X, ev.MarginBounds.Y, ev.MarginBounds.Width, ev.MarginBounds.Height)
        Dim fontTitle As New Font("Times New Roman", 16)
        Dim chartTitle As String = "Chart of work material temperature model."
        Dim titleSize As SizeF = ev.Graphics.MeasureString(chartTitle, fontTitle)
        titlePosition.Height = CInt(titleSize.Height)

        '' Draw charts title
        'Dim format As New StringFormat()
        'format.Alignment = StringAlignment.Center
        'ev.Graphics.DrawString(chartTitle, fontTitle, Brushes.Black, titlePosition, format)

        ' Calculate first chart position rectangle
        Dim chartPosition As New Rectangle(ev.MarginBounds.X, titlePosition.Bottom, Form1.Chart1.Size.Width, Form1.Chart1.Size.Height)

        ' Align first chart position on the page
        Dim chartWidthScale As Single = CSng(ev.MarginBounds.Width) / 1.0F / CSng(chartPosition.Width)
        Dim chartHeightScale As Single = CSng(ev.MarginBounds.Height) / CSng(chartPosition.Height)
        chartPosition.Width = CInt(chartPosition.Width * Math.Min(chartWidthScale, chartHeightScale))
        chartPosition.Height = CInt(chartPosition.Height * Math.Min(chartWidthScale, chartHeightScale))

        ' Draw first chart on the printer graphics
        Form1.Chart1.Printing.PrintPaint(ev.Graphics, chartPosition)
    End Sub

    Public Sub pd_PrintPage2(ByVal sender As Object, ByVal ev As PrintPageEventArgs)

        ' Calculate title string position
        Dim titlePosition As New Rectangle(ev.MarginBounds.X, ev.MarginBounds.Y, ev.MarginBounds.Width, ev.MarginBounds.Height)
        Dim fontTitle As New Font("Times New Roman", 16)
        Dim chartTitle As String = "Chart of chip temperature model."
        Dim titleSize As SizeF = ev.Graphics.MeasureString(chartTitle, fontTitle)
        titlePosition.Height = CInt(titleSize.Height)

        '' Draw charts title
        'Dim format As New StringFormat()
        'format.Alignment = StringAlignment.Center
        'ev.Graphics.DrawString(chartTitle, fontTitle, Brushes.Black, titlePosition, format)

        ' Calculate first chart position rectangle
        Dim chartPosition As New Rectangle(ev.MarginBounds.X, titlePosition.Bottom, Form1.Chart2.Size.Width, Form1.Chart1.Size.Height)

        ' Align first chart position on the page
        Dim chartWidthScale As Single = CSng(ev.MarginBounds.Width) / 1.0F / CSng(chartPosition.Width)
        Dim chartHeightScale As Single = CSng(ev.MarginBounds.Height) / CSng(chartPosition.Height)
        chartPosition.Width = CInt(chartPosition.Width * Math.Min(chartWidthScale, chartHeightScale))
        chartPosition.Height = CInt(chartPosition.Height * Math.Min(chartWidthScale, chartHeightScale))

        ' Draw first chart on the printer graphics
        Form1.Chart2.Printing.PrintPaint(ev.Graphics, chartPosition)
    End Sub

    'Public Sub pd_PrintPage3(ByVal sender As Object, ByVal ev As PrintPageEventArgs)

    '    ' Calculate title string position
    '    Dim titlePosition As New Rectangle(ev.MarginBounds.X, ev.MarginBounds.Y, ev.MarginBounds.Width, ev.MarginBounds.Height)
    '    Dim fontTitle As New Font("Times New Roman", 16)
    '    Dim chartTitle As String = "Chart of tool-chip interface temperature model."
    '    Dim titleSize As SizeF = ev.Graphics.MeasureString(chartTitle, fontTitle)
    '    titlePosition.Height = CInt(titleSize.Height)

    '    '' Draw charts title
    '    'Dim format As New StringFormat()
    '    'format.Alignment = StringAlignment.Center
    '    'ev.Graphics.DrawString(chartTitle, fontTitle, Brushes.Black, titlePosition, format)

    '    ' Calculate first chart position rectangle
    '    Dim chartPosition As New Rectangle(ev.MarginBounds.X, titlePosition.Bottom, Form1.Chart3.Size.Width, Form1.Chart1.Size.Height)

    '    ' Align first chart position on the page
    '    Dim chartWidthScale As Single = CSng(ev.MarginBounds.Width) / 1.0F / CSng(chartPosition.Width)
    '    Dim chartHeightScale As Single = CSng(ev.MarginBounds.Height) / CSng(chartPosition.Height)
    '    chartPosition.Width = CInt(chartPosition.Width * Math.Min(chartWidthScale, chartHeightScale))
    '    chartPosition.Height = CInt(chartPosition.Height * Math.Min(chartWidthScale, chartHeightScale))

    '    ' Draw first chart on the printer graphics
    '    Form1.Chart3.Printing.PrintPaint(ev.Graphics, chartPosition)
    'End Sub

    Public Sub pd_PrintPage4(ByVal sender As Object, ByVal ev As PrintPageEventArgs)

        ' Calculate title string position
        Dim titlePosition As New Rectangle(ev.MarginBounds.X, ev.MarginBounds.Y, ev.MarginBounds.Width, ev.MarginBounds.Height)
        Dim fontTitle As New Font("Times New Roman", 16)
        Dim chartTitle As String = "Chart of tool temperature analysis."
        Dim titleSize As SizeF = ev.Graphics.MeasureString(chartTitle, fontTitle)
        titlePosition.Height = CInt(titleSize.Height)

        '' Draw charts title
        'Dim format As New StringFormat()
        'format.Alignment = StringAlignment.Center
        'ev.Graphics.DrawString(chartTitle, fontTitle, Brushes.Black, titlePosition, format)

        ' Calculate first chart position rectangle
        Dim chartPosition As New Rectangle(ev.MarginBounds.X, titlePosition.Bottom, Form1.Chart4.Size.Width, Form1.Chart1.Size.Height)

        ' Align first chart position on the page
        Dim chartWidthScale As Single = CSng(ev.MarginBounds.Width) / 1.0F / CSng(chartPosition.Width)
        Dim chartHeightScale As Single = CSng(ev.MarginBounds.Height) / CSng(chartPosition.Height)
        chartPosition.Width = CInt(chartPosition.Width * Math.Min(chartWidthScale, chartHeightScale))
        chartPosition.Height = CInt(chartPosition.Height * Math.Min(chartWidthScale, chartHeightScale))

        ' Draw first chart on the printer graphics
        Form1.Chart4.Printing.PrintPaint(ev.Graphics, chartPosition)
    End Sub

    Public Sub pd_PrintPage5(ByVal sender As Object, ByVal ev As PrintPageEventArgs)

        ' Calculate title string position
        Dim titlePosition As New Rectangle(ev.MarginBounds.X, ev.MarginBounds.Y, ev.MarginBounds.Width, ev.MarginBounds.Height)
        Dim fontTitle As New Font("Times New Roman", 16)
        Dim chartTitle As String = "Combined graph of all Models."
        Dim titleSize As SizeF = ev.Graphics.MeasureString(chartTitle, fontTitle)
        titlePosition.Height = CInt(titleSize.Height)

        '' Draw charts title
        'Dim format As New StringFormat()
        'format.Alignment = StringAlignment.Center
        'ev.Graphics.DrawString(chartTitle, fontTitle, Brushes.Black, titlePosition, format)

        ' Calculate first chart position rectangle
        Dim chartPosition As New Rectangle(ev.MarginBounds.X, titlePosition.Bottom, Form1.Chart5.Size.Width, Form1.Chart1.Size.Height)

        ' Align first chart position on the page
        Dim chartWidthScale As Single = CSng(ev.MarginBounds.Width) / 1.0F / CSng(chartPosition.Width)
        Dim chartHeightScale As Single = CSng(ev.MarginBounds.Height) / CSng(chartPosition.Height)
        chartPosition.Width = CInt(chartPosition.Width * Math.Min(chartWidthScale, chartHeightScale))
        chartPosition.Height = CInt(chartPosition.Height * Math.Min(chartWidthScale, chartHeightScale))

        ' Draw first chart on the printer graphics
        Form1.Chart5.Printing.PrintPaint(ev.Graphics, chartPosition)
    End Sub








End Module
