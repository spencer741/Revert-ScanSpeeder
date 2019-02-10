Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Call ShowDialog.
        Dim result As DialogResult = OpenFileDialog1.ShowDialog()

        ' Test result.
        If result = Windows.Forms.DialogResult.OK Then
            ' Do something.
            Dim path As String = OpenFileDialog1.FileName
            Dim image As Bitmap = New Bitmap(Drawing.Image.FromFile(path))
        End If
    End Sub

    Private Sub OpenFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk

    End Sub

End Class
