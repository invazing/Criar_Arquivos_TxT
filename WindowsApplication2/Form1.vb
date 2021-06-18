Public Class Form1
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim fileExists As Boolean
        fileExists = My.Computer.FileSystem.FileExists("C:\Users\Public\Desktop\TranspenTI.txt")
        If fileExists = False Then
            If MessageBox.Show("O Relatorio não esta criado deseja criar ?", "logfile", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                My.Computer.FileSystem.WriteAllText("C:\Users\Public\Desktop\TranspenTI.txt", String.Empty, False)
            End If
        End If
    End Sub
    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    End Sub
End Class
