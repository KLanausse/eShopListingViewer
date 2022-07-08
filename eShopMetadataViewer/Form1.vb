Imports System.IO
Imports System.Net
Imports System.Security.Cryptography.X509Certificates

Public Class Viewer
    Public Property version As String = "0.5.2"
    'MM/DD/YYYY
    Public Property CreationDate As String = "3/9/2022 - 1:40 PM EST"

    'Public Vars
    Public currThumb = 1
    Public thumbnails(1) As String
    Public hasCerts As Boolean = False
    Public currData As XDocument
    Public clientCerts As X509Certificate2Collection = New X509Certificate2Collection()


    Private Sub Form1_Open(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.Load

        ' Ignore SSL Errors
        System.Net.ServicePointManager.ServerCertificateValidationCallback = Function(se As Object, cert As X509Certificate, chain As System.Security.Cryptography.X509Certificates.X509Chain, sslerror As System.Net.Security.SslPolicyErrors) True


        'Restore SSL Certificate Validation Checking
        'System.Net.ServicePointManager.ServerCertificateValidationCallback = Nothing

        'Check for ctr_olive.p12 and/or ctr-common-1.p12
        Dim Files = {Directory.GetCurrentDirectory() + "\ctr_olive.p12", Directory.GetCurrentDirectory() + "\ctr-common-1.p12"}
        For Each file In Files
            Dim FileExists = Dir(file)
            If FileExists IsNot "" Then
                hasCerts = True
                'Miiverse ctr_olive.p12 pass g8Ba#Mqj$z39
                Try
                    clientCerts.Import(file, "alpine", X509KeyStorageFlags.MachineKeySet And X509KeyStorageFlags.PersistKeySet)
                Catch ex As Exception
                    clientCerts.Import(file, "g8Ba#Mqj$z39", X509KeyStorageFlags.MachineKeySet And X509KeyStorageFlags.PersistKeySet)
                End Try

            End If
        Next
        If Not hasCerts Then
            MsgBox("Some title information won't be able to be retrieved because the 3DS Client Certificates are missing", vbExclamation Or vbOKOnly, "Certs Missing")
        End If



    End Sub

    'Toolbars
    '   Load
    Private Sub OpenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FromDatabaseToolStripMenuItem.Click
        'Vars
        Dim metadata As XDocument
        Dim webErr As Boolean



        'Load metadata
        Dialog1.ShowDialog()

        If Dialog1.DialogResult() = System.Windows.Forms.DialogResult.OK Then

            'Load content metadata
            Try
                'Check if the title metadata is downloaded; if not, download it
                Dim FileName As String
                Dim FileExists As String
                FileName = Directory.GetCurrentDirectory() + "\samurai.ctr.shop.nintendo.net\samurai\ws\US\title\" + Dialog1.ID + "\%3Fshop_id=1.xml"
                FileExists = Dir(FileName)

                If FileExists = "" Then
                    My.Computer.FileSystem.CreateDirectory(Directory.GetCurrentDirectory() + "\samurai.ctr.shop.nintendo.net\samurai\ws\US\title\" + Dialog1.ID)
                    My.Computer.Network.DownloadFile("https://samurai.ctr.shop.nintendo.net/samurai/ws/US/title/" + Dialog1.ID + "/?shop_id=1", Directory.GetCurrentDirectory() + "\samurai.ctr.shop.nintendo.net\samurai\ws\US\title\" + Dialog1.ID + "\%3Fshop_id=1.xml")

                End If
                'Orignal
                metadata = XDocument.Load(FileName)
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

                DisplayData(metadata)

            Else
                gameThumbnail.ImageLocation = Nothing
                T_softTitle_01.Text = Nothing
                P_rating_00.ImageLocation = Nothing
                description.Text = Nothing
                BottomScreen.Size = New Size(320, BottomScreen.Height)

            End If

        End If

    End Sub

    Private Sub OpenXMLToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FromXMLFIleToolStripMenuItem.Click
        Dim metadata As XDocument
        OpenFileDialog1.Filter = "XML|*.xml"
        OpenFileDialog1.ShowDialog()

        Try
            metadata = XDocument.Load(OpenFileDialog1.FileName())
            DisplayData(metadata)
        Catch ex As Exception
            MsgBox("Error reading XML", vbCritical Or vbOKOnly, "Error")
        End Try

    End Sub
    '   Save
    Private Sub SaveMetadataToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveMetadataToolStripMenuItem.Click
        If currData IsNot Nothing Then
            SaveFileDialog1.Filter = "XML (*.xml*)|*.xml"

            'Make filename valid
            Const csInvalidChars As String = ":\/?*<>|""" + vbNewLine 'You suck NewLine >:( Made me waste 
            Dim ValidFileName = Replace(currData.<eshop>.<title>.<name>.Value, "<br>", " ") + " - " + currData.<eshop>.<title>.<product_code>.Value
            For lThisChar = 1 To Len(csInvalidChars)
                ValidFileName = Replace(ValidFileName, Mid(csInvalidChars, lThisChar, 1), "")
            Next

            'Save and Write File
            SaveFileDialog1.FileName = ValidFileName
            If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
                My.Computer.FileSystem.WriteAllText(SaveFileDialog1.FileName, currData.ToString(), True)
            End If
        Else
            MsgBox("No content loaded!", vbExclamation Or vbOKOnly, "Can't Export")
        End If
    End Sub

    'UI Stuff
    Private Sub GameThumbnail_Click(sender As Object, e As EventArgs) Handles gameThumbnail.Click
        currThumb += 1
        If currThumb > thumbnails.Length Then
            currThumb = 1
        End If
        gameThumbnail.ImageLocation = thumbnails(currThumb - 1)

    End Sub


    'Image Painting
    Sub Top_Screen_Paint(s As Object, e As PaintEventArgs) Handles TopScreen.Paint
        PaintTransparentImages({
            P_titleBack_00,
            P_Shadow_00,
            P_Line_01,
            P_Line_02
        }, e)
    End Sub

    Private Sub P_titleBack_00_Paint(sender As Object, e As PaintEventArgs) Handles P_titleBack_00.Paint
        PaintTransparentImages({P_StatusBar_Shadow, P_titeBack_Shadow, P_Shadow_01}, e)
    End Sub


    Sub Form_Paint2(s As Object, e As PaintEventArgs) Handles StatusBar.Paint
        PaintTransparentImages({
            InternetBar
        }, e)
    End Sub



    'Functions
    Function PaintTransparentImages(pictureBoxes As Array, e As PaintEventArgs)
        For Each item As Object In pictureBoxes
            Dim r As New Rectangle(item.Location.X, item.Location.Y, item.Width, item.Height)
            e.Graphics.DrawImage(item.Image, r)
            item.Visible = False
        Next

        Return 0
    End Function

    Function DisplayData(metadata As XDocument)
        currData = metadata

        'Find and get the Thumbnails
        Dim thumbList = metadata.Descendants("thumbnail")
        Dim thumbnailCount = 0
        For Each node As XElement In thumbList
            thumbnailCount += 1
            Array.Resize(thumbnails, thumbnailCount)
            thumbnails(thumbnailCount - 1) = node.Attribute("url").Value
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

        If metadata.<eshop>.<title>.<price_on_retail>.Value IsNot Nothing Then
            T_price_00.Text = T_price_00.Text + " (Retail)"

        End If

        'Star Rating
        Dim Stars = {eShopMetadataViewer.My.Resources.Resources.star_00, eShopMetadataViewer.My.Resources.Resources.star_01, eShopMetadataViewer.My.Resources.Resources.star_02, eShopMetadataViewer.My.Resources.Resources.star_03, eShopMetadataViewer.My.Resources.Resources.star_04, eShopMetadataViewer.My.Resources.Resources.star_05}
        Dim sRating As Integer = metadata.<eshop>.<title>.<star_rating_info>.<score>.Value

        If sRating = Nothing Then
            star_rating.Visible = False
            T_star_00.Visible = False
        Else
            star_rating.Visible = True
            T_star_00.Visible = True
            star_rating.Image = Stars(Math.Round(sRating))
            T_star_00.Text = "(" + metadata.<eshop>.<title>.<star_rating_info>.<votes>.Value + ")"
        End If

        'Release Date
        T_Day_01.Text = Replace(metadata.<eshop>.<title>.<release_date_on_eshop>.Value, "-", "/")

        'Price

        If hasCerts Then
            'https://stackoverflow.com/questions/39528973/force-httpwebrequest-to-send-client-certificate
            Dim pricingData As XDocument
            Dim titleID As String
            Dim URL As String
            titleID = metadata.<eshop>.Descendants("title").First().Attribute("id").Value
            URL = "ninja.ctr.shop.nintendo.net\ninja\ws\US\titles\online_prices%3Ftitle%5B%5D=" + titleID + "&lang=EN&include_coupon=false&coupon_id=0&shop_id=1&_type=json"

            Try
                'Check if the title metadata is downloaded; if not, download it
                Dim FileName As String
                Dim FileExists As String
                FileName = Directory.GetCurrentDirectory() + "\" + URL
                FileExists = Dir(FileName)

                If FileExists = "" Then

                    My.Computer.FileSystem.CreateDirectory(Directory.GetCurrentDirectory() + "\ninja.ctr.shop.nintendo.net\ninja\ws\US\titles")

                    Dim req As HttpWebRequest = WebRequest.Create("https:\\" + URL)
                    req.ClientCertificates = clientCerts
                    req.Method = "GET"
                    Dim resp As WebResponse = req.GetResponse()
                    Dim stream As Stream = resp.GetResponseStream()
                    Using reader As StreamReader = New StreamReader(stream)

                        Dim line As String = reader.ReadLine()
                        Dim fs As FileStream = File.Create(Directory.GetCurrentDirectory() + "\" + URL + ".xml")
                    End Using
                    stream.Close()

                End If
                pricingData = XDocument.Load(FileName + ".xml")
            Catch ex As WebException
                Using reader As New StreamReader(ex.Response.GetResponseStream())
                    metadata = XDocument.Parse(reader.ReadToEnd())
                    MsgBox(metadata.<eshop>.<error>.<message>.Value, vbCritical Or vbOK, "Error " + metadata.<eshop>.<error>.<code>.Value)
                End Using
            End Try

            T_price_00.Text = pricingData.<eshop>.<online_prices>.<online_price>.<price>.<regular_price>.<amount>.Value

        End If

        Return 0
    End Function
End Class
