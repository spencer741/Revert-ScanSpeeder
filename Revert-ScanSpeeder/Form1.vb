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

            Dim fri As FileInfo

            'initiate looping sequence
            For Each fri In fiArr
                If fri.Extension.Equals(cbo_Extensions.SelectedItem) Or fri.Extension.Equals(cbo_Extensions.SelectedItem.ToString.ToUpper) Then
                    'Label1.Text = "Processing file: " + fri.FullName
                    Label1.Text = "Processing folder: " + path
                    ProcessImage(fri, path)
                End If
            Next fri

        End If
    End Sub
    'TODO: old test pic was 72 dpi. New image was 96 dpi. Old was 24 bit depth. New is 32 bit depth. Why?
    Private Sub ProcessImage(fri As FileInfo, path As String)


        Dim image As Bitmap = New Bitmap(Drawing.Image.FromFile(fri.FullName))
        Dim imageSize As Size = image.Size
        Dim imageWidth As Short = imageSize.Width
        Dim imageHeight As Short = imageSize.Height
        Dim pixelColor As Color

        Dim newImage As Bitmap = New Bitmap(imageWidth, imageHeight)  'Test to recreate image

        'Setting proper resolutions
        Dim VR As Single = image.VerticalResolution
        Dim HR As Single = image.HorizontalResolution

        'Handle image resolutions
        Dim HVR As Single

        If cbo_DPI.SelectedIndex = 0 Then
            'It's not setting the right resolution....not dropping in here
            newImage.SetResolution(72, 72)
        Else
            HVR = cbo_DPI.SelectedItem
            'Single(cbo_DPI.SelectedItem)
            newImage.SetResolution(HVR, HVR)
        End If

        'Scan vertically
        For pw = 0 To imageWidth - 1
            For ph = 0 To imageHeight - 1
                pixelColor = image.GetPixel(pw, ph) 'use LockBits for efficiency later if needed
                newImage.SetPixel(pw, ph, pixelColor) 'Test to recreate image
            Next
        Next
        newImage.Save(path + "\\" + "newImage.jpg")
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbo_DPI.SelectedIndex = 0
    End Sub
End Class
