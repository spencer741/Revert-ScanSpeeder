Imports System.IO

Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_BrowseFolder.Click

        If cbo_Extensions.SelectedItem = "" Then
            MsgBox("Please select an extension first!")
        Else
            FindFolderDialog()
        End If
    End Sub

    Private Sub FindFolderDialog()
        Dim result As DialogResult = FolderBrowserDialog1.ShowDialog()
        If result = Windows.Forms.DialogResult.OK Then
            Dim path As String = FolderBrowserDialog1.SelectedPath

            Dim di As New DirectoryInfo(path)

            ' Get a reference to each file in that directory.
            Dim fiArr As FileInfo() = di.GetFiles()

            ' Display the names of the files.
            Dim fri As FileInfo

            'initiate looping sequence
            For Each fri In fiArr
                If fri.Extension.Equals(cbo_Extensions.SelectedItem) Then
                    Label1.Text += fri.Extension
                End If
            Next fri
            'Dim image As Bitmap = New Bitmap(Drawing.Image.FromFile(path))
        End If
    End Sub

End Class
