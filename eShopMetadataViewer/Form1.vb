﻿Imports System.IO
Imports System.Net

Public Class Viewer
    'Public Vars
    Public currThumb = 1
    Public thumbnails(1) As String

    Private Sub Viewer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Form1_Open(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.Load


    End Sub


    Private Sub OpenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem.Click
        'Vars
        Dim metadata As XDocument
        Dim webErr As Boolean

        ' Ignore SSL Errors
        System.Net.ServicePointManager.ServerCertificateValidationCallback =
  Function(se As Object,
  cert As System.Security.Cryptography.X509Certificates.X509Certificate,
  chain As System.Security.Cryptography.X509Certificates.X509Chain,
  sslerror As System.Net.Security.SslPolicyErrors) True


        'Load metadata
        Dialog1.ShowDialog()

        'Load content metadata
        Try
            metadata = XDocument.Load("https://samurai.ctr.shop.nintendo.net/samurai/ws/US/title/" + Dialog1.ID + "/?shop_id=1")
            webErr = False
        Catch ex As WebException
            Using reader As New StreamReader(ex.Response.GetResponseStream())
                metadata = XDocument.Parse(reader.ReadToEnd())
                MsgBox(metadata.<eshop>.<error>.<message>.Value, vbCritical Or vbOK, "Error " + metadata.<eshop>.<error>.<code>.Value)
            End Using
            webErr = True
        End Try

        'Setup page with the Metadata info
        If Not webErr Then

            'Find and get the Thumbnails
            Dim thumbList = metadata.Descendants("thumbnail")
            Dim thumbnailCount = 0
            For Each node As XElement In thumbList
                thumbnailCount += 1
                Array.Resize(thumbnails, thumbnailCount)
                thumbnails(thumbnailCount - 1) = node.Attribute("url").Value
                Console.WriteLine(thumbnails(thumbnailCount - 1))
                Console.WriteLine(thumbnailCount)
            Next
            '   Set Game Image
            Dim image = thumbnails(0)
            currThumb = 1
            gameThumbnail.ImageLocation = image

            'Set Title and discription
            T_softTitle_01.Text = metadata.<eshop>.<title>.<name>.Value
            description.Text = Replace(metadata.<eshop>.<title>.<description>.Value, "<br>", vbNewLine)
            'ESBR Rating
            P_rating_00.SizeMode = PictureBoxSizeMode.StretchImage
            P_rating_00.ImageLocation = metadata.<eshop>.<title>.<rating_info>.<rating>.<icons>.Descendants("icon")(0).Attribute("url").Value
            'Platform 
            PlatformLabel.Text = metadata.<eshop>.<title>.<platform>.<name>.Value
            BottomScreen.AutoScroll = True
            BottomScreen.Size = New Size(320 + SystemInformation.VerticalScrollBarWidth + 2, BottomScreen.Height)
        Else
            gameThumbnail.ImageLocation = Nothing
            T_softTitle_01.Text = Nothing
            P_rating_00.ImageLocation = Nothing
            description.Text = Nothing
            BottomScreen.Size = New Size(320, BottomScreen.Height)

        End If

        'Restore SSL Certificate Validation Checking
        'System.Net.ServicePointManager.ServerCertificateValidationCallback = Nothing
    End Sub

    Private Sub GameThumbnail_Click(sender As Object, e As EventArgs) Handles gameThumbnail.Click
        currThumb += 1
        If currThumb > thumbnails.Length Then
            currThumb = 1
        End If
        gameThumbnail.ImageLocation = thumbnails(currThumb - 1)

    End Sub
End Class
