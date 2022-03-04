Imports System.IO
Imports System.Net
Imports System.Security.Cryptography.X509Certificates

Public Class Viewer
    Public Property version As String = "0.4.5"
    'MM/DD/YYYY
    Public Property CreationDate As String = "3/4/2022 - 9:23 EST"

    'Public Vars
    Public currThumb = 1
    Public thumbnails(1) As String
    Public hasCerts As Boolean = True
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
                clientCerts.Import(file, "alpine", X509KeyStorageFlags.MachineKeySet And X509KeyStorageFlags.PersistKeySet)
            End If
        Next
        If Not hasCerts Then
            MsgBox("Some tite information won't be able to be retrieved because the 3DS Client Certificates are missing", vbExclamation Or vbOKOnly, "Certs Missing")
        End If



    End Sub

    'Toolbars
    Private Sub OpenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FromDatabaseToolStripMenuItem.Click
        'Vars
        Dim metadata As XDocument
        Dim webErr As Boolean



        'Load metadata
        Dialog1.ShowDialog()

        If Dialog1.DialogResult() = System.Windows.Forms.DialogResult.OK Then

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
    '   'Save
    Private Sub SaveMetadataToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveMetadataToolStripMenuItem.Click
        If currData IsNot Nothing Then
            SaveFileDialog1.Filter = "XML (*.xml*)|*.xml"

            'Make filename valid
            Const csInvalidChars As String = ":\/?*<>|"""
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
    Sub Form_Paint1(s As Object, e As PaintEventArgs) Handles TopScreen.Paint
        PaintTransparentImages({
            P_titleBack_00,
            P_line_00,
            P_Shadow_00,
            P_Line_01,
            P_Line_02
        }, e)
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
        T_price_00.Text = metadata.<eshop>.<title>.<price_on_retail>.Value + " (Retail)"

        'Star Rating
        Dim sRating As Double = metadata.<eshop>.<title>.<star_rating_info>.<score>.Value
        Console.WriteLine(Math.Round(sRating))

        'Release Date
        T_Day_01.Text = Replace(metadata.<eshop>.<title>.<release_date_on_eshop>.Value, "-", "/")

        'Price
        If hasCerts Then
            'https://stackoverflow.com/questions/39528973/force-httpwebrequest-to-send-client-certificate
            Dim req As HttpWebRequest = WebRequest.Create("https://ninja.ctr.shop.nintendo.net/ninja/ws/US/titles/online_prices?title%5B%5D=" + metadata.<eshop>.Descendants("title").First().Attribute("id").Value + "&lang=EN&include_coupon=false&coupon_id=0&shop_id=1&_type=json")
            req.ClientCertificates = clientCerts
            req.Method = "GET"
            Dim resp As WebResponse = req.GetResponse()
            Dim stream As Stream = resp.GetResponseStream()
            Using reader As StreamReader = New StreamReader(stream)

                Dim line As String = reader.ReadLine()
                Dim pricingData As XDocument
                If line IsNot Nothing Then

                    pricingData = XDocument.Parse(line)
                    Console.WriteLine(pricingData)
                    T_price_00.Text = pricingData.<eshop>.<online_prices>.<online_price>.<price>.<regular_price>.<amount>.Value

                End If
            End Using
            stream.Close()
        End If

        Return 0
    End Function
End Class
