Public Class NewWorkMaterial

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Then
            MsgBox("Please enter a name for the material")

        Else
            Try
                Form1.wmk = TextBox2.Text
                Form1.wma = TextBox3.Text
                Form1.wmlambda = TextBox4.Text

                'WorkMaterialDefinition.Label1.Enabled = True
                'WorkMaterialDefinition.Label10.Enabled = False
                'WorkMaterialDefinition.Label12.Enabled = False
                'WorkMaterialDefinition.Label2.Enabled = False
                'WorkMaterialDefinition.Label3.Enabled = False
                'WorkMaterialDefinition.Label5.Enabled = False
                ''WorkMaterialDefinition.Label6.Enabled = False
                'WorkMaterialDefinition.Label8.Enabled = False

                Me.Close()

            Catch ex As Exception
                Form1.wmk = 0
                Form1.wma = 0
                Form1.wmlambda = 0

                MsgBox("Please redefine material properties")
            End Try
        End If
       

       
    End Sub

    Private Sub NewWorkMaterial_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.TopMost = True
    End Sub

    Private Sub TextBox2_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox2.Enter
        TextBox2.Text = ""
    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2.TextChanged

    End Sub

   

   
    Private Sub TextBox3_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox3.Enter
        TextBox3.Text = ""
    End Sub

    Private Sub TextBox4_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox4.Enter
        TextBox4.Text = ""
    End Sub
End Class