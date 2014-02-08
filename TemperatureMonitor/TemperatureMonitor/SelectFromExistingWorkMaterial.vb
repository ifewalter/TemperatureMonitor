Imports System.Xml

Public Class SelectFromExistingWorkMaterial

    Private Sub SelectFromExistingWorkMaterial_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim WMDefinitionFile As String

        WMDefinitionFile = Application.StartupPath.ToString

        WMDefinitionFile = WMDefinitionFile & "\" & My.Settings.WorkMaterialDefinitions.ToString



        Using MyReader As New  _
Microsoft.VisualBasic.FileIO.TextFieldParser(WMDefinitionFile)
            MyReader.TextFieldType = FileIO.FieldType.Delimited
            MyReader.SetDelimiters(",")
            Dim currentRow As String()
            Dim totalrowcount As Integer
            Dim commentdelimiter As String() = {"#"}

            While Not MyReader.EndOfData
                Try
                    currentRow = MyReader.ReadFields()
                    totalrowcount = currentRow.Length
                    MyReader.CommentTokens = commentdelimiter
                    Dim currentField As String

                    'put a delimeter to determine whether the file is valid


                    For Each currentField In currentRow
                        ListBox1.Items.Add(currentField)
                    Next
                Catch ex As Microsoft.VisualBasic.FileIO.MalformedLineException
                    MsgBox("Line " & ex.Message & _
                    "is not valid and will be skipped.")
                End Try
            End While
        End Using

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        NewWorkMaterial.Show()
        Me.Close()
    End Sub
End Class