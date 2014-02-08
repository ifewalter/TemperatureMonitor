<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SelectUnitSystem
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.SIRadio1 = New System.Windows.Forms.RadioButton
        Me.MetricRadio = New System.Windows.Forms.RadioButton
        Me.Button1 = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'SIRadio1
        '
        Me.SIRadio1.AutoSize = True
        Me.SIRadio1.Location = New System.Drawing.Point(36, 57)
        Me.SIRadio1.Name = "SIRadio1"
        Me.SIRadio1.Size = New System.Drawing.Size(139, 17)
        Me.SIRadio1.TabIndex = 0
        Me.SIRadio1.TabStop = True
        Me.SIRadio1.Text = "International System (SI)"
        Me.SIRadio1.UseVisualStyleBackColor = True
        '
        'MetricRadio
        '
        Me.MetricRadio.AutoSize = True
        Me.MetricRadio.Location = New System.Drawing.Point(36, 119)
        Me.MetricRadio.Name = "MetricRadio"
        Me.MetricRadio.Size = New System.Drawing.Size(91, 17)
        Me.MetricRadio.TabIndex = 1
        Me.MetricRadio.TabStop = True
        Me.MetricRadio.Text = "Metric System"
        Me.MetricRadio.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(213, 158)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(67, 25)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "OK"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(33, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(170, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Select unit of measurement system"
        '
        'SelectUnitSystem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(292, 205)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.MetricRadio)
        Me.Controls.Add(Me.SIRadio1)
        Me.Name = "SelectUnitSystem"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SelectUnitSystem"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SIRadio1 As System.Windows.Forms.RadioButton
    Friend WithEvents MetricRadio As System.Windows.Forms.RadioButton
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
