Imports System.IO
Imports System.Net

Public Class Viewer
    Public Property version As String = "0.3"
    'MM/DD/YYYY
    Public Property creationDate As String = "3/3/2022 - 11:23 EST"

    'Public Vars
    Public currThumb = 1
    Public thumbnails(1) As String


    Private Sub Form1_Open(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.Load

        ' Ignore SSL Errors
        System.Net.ServicePointManager.ServerCertificateValidationCallback =
  Function(se As Object,
  cert As System.Security.Cryptography.X509Certificates.X509Certificate,
  chain As System.Security.Cryptography.X509Certificates.X509Chain,
  sslerror As System.Net.Security.SslPolicyErrors) True

        'Restore SSL Certificate Validation Checking
        'System.Net.ServicePointManager.ServerCertificateValidationCallback = Nothing

    End Sub

    'Toolbars
    Private Sub OpenToolStripMenuItem_Click(sender As Object, e As EventArgs)
        'Vars
        Dim metadata As XDocument
        Dim webErr As Boolean



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

            displayData(metadata)

        Else
            gameThumbnail.ImageLocation = Nothing
            T_softTitle_01.Text = Nothing
            P_rating_00.ImageLocation = Nothing
            description.Text = Nothing
            BottomScreen.Size = New Size(320, BottomScreen.Height)

        End If


    End Sub

    Private Sub OpenXMLToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Dim metadata As XDocument
        OpenFileDialog1.Filter = "XML|*.xml"
        OpenFileDialog1.ShowDialog()
        Try
            metadata = XDocument.Load(OpenFileDialog1.FileName())
            displayData(metadata)
        Catch ex As Exception
            MsgBox("Error reading XML", vbCritical Or vbOK, "Error")
        End Try

    End Sub


    Private Sub GameThumbnail_Click(sender As Object, e As EventArgs) Handles gameThumbnail.Click
        currThumb += 1
        If currThumb > thumbnails.Length Then
            currThumb = 1
        End If
        gameThumbnail.ImageLocation = thumbnails(currThumb - 1)

    End Sub


    'Image Painting
    Sub Form_Paint1(s As Object, e As PaintEventArgs) Handles TopScreen.Paint
        paintTransparentImages({
            P_titleBack_00,
            P_line_00,
            P_Shadow_00,
            P_Line_01,
            P_Line_02
        }, e)
    End Sub

    Sub Form_Paint2(s As Object, e As PaintEventArgs) Handles StatusBar.Paint
        paintTransparentImages({
            InternetBar
        }, e)
    End Sub



    'Functions
    Function paintTransparentImages(pictureBoxes As Array, e As PaintEventArgs)
        For Each item As Object In pictureBoxes
            Dim r As New Rectangle(item.Location.X, item.Location.Y, item.Width, item.Height)
            e.Graphics.DrawImage(item.Image, r)
            item.Visible = False
        Next
    End Function

    Function displayData(metadata As XDocument)

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

        'Set Title, discription
        T_softTitle_01.Text = metadata.<eshop>.<title>.<name>.Value
        description.Text = Replace(metadata.<eshop>.<title>.<description>.Value, "<br>", vbNewLine)

        'ESBR Rating
        If metadata.<eshop>.<title>.<rating_info>.Value = "" Then
            P_rating_00.ImageLocation = ""
            P_rating_00.Visible = False
            W_BG_00.Visible = False
            P_Line_01.Width = 264
            P_Line_02.Width = 264
        Else
            P_rating_00.ImageLocation = metadata.<eshop>.<title>.<rating_info>.<rating>.<icons>.Descendants("icon")(0).Attribute("url").Value
            P_Line_01.Width = 212
            P_Line_02.Width = 212
            P_rating_00.Visible = True
            W_BG_00.Visible = True
        End If

        'Platform 
        PlatformLabel.Text = metadata.<eshop>.<title>.<platform>.<name>.Value
        BottomScreen.AutoScroll = True
        BottomScreen.Size = New Size(320 + SystemInformation.VerticalScrollBarWidth + 2, BottomScreen.Height)

        'Retail Price
        T_price_00.Text = metadata.<eshop>.<title>.<price_on_retail>.Value

        'Star Rating
        Dim sRating As Double = metadata.<eshop>.<title>.<star_rating_info>.<score>.Value
        Console.WriteLine(Math.Round(sRating))

        Return 0
    End Function

End Class
