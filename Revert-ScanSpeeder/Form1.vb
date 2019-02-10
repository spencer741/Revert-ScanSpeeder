Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Call ShowDialog.
        Dim result As DialogResult = FolderBrowserDialog1.ShowDialog()

        ' Test result.
        If result = Windows.Forms.DialogResult.OK Then
            ' Do something.
            Dim path As String = FolderBrowserDialog1.SelectedPath
            'Dim image As Bitmap = New Bitmap(Drawing.Image.FromFile(path))
        End If
    End Sub


End Class
