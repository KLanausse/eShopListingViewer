Imports System.IO
Imports System.Windows.Forms
Imports System.Xml

Public Class Dialog1
    Public Property ID As String
    Public fetchList = True
    Public nodeList
    's


    Private Sub Dialog1_Open(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.Load

        If fetchList Then

            'Check if the titles database is downloaded; if not, download it
            Dim FileName As String
            Dim FileExists As String
            FileName = Directory.GetCurrentDirectory() + "\samurai.ctr.shop.nintendo.net\samurai\ws\US\titles\titles%3Flimit=10000&shop_id=1.xml"
            FileExists = Dir(FileName)

            If FileExists = "" Then
                '''''''''''''''''''''''''''''''''''''''''''''''Other Urls''''''''''''''''''''''''''''''''''''''''''''
                'https://samurai.ctr.shop.nintendo.net/samurai/ws/US/contents?lang=EN&shop_id=1&_type=json&limit=1500'
                'https://samurai.ctr.shop.nintendo.net/samurai/ws/US/contents?lang=EN&shop_id=1&_type=json&limit=1265&offset=1500
                ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                My.Computer.FileSystem.CreateDirectory(Directory.GetCurrentDirectory() + "\samurai.ctr.shop.nintendo.net\samurai\ws\US\titles")
                My.Computer.Network.DownloadFile("https://samurai.ctr.shop.nintendo.net/samurai/ws/US/titles?limit=10000&shop_id=1", Directory.GetCurrentDirectory() + "\samurai.ctr.shop.nintendo.net\samurai\ws\US\titles\titles%3Flimit=10000&shop_id=1.xml")
                'My.Computer.Network.DownloadFile("https://samurai.ctr.shop.nintendo.net/samurai/ws/US/contents?lang=EN&shop_id=1&_type=json&limit=1500", Directory.GetCurrentDirectory() + "\contents1500.xml")
            End If
            'Load the list
            Dim titlesList = XDocument.Load(FileName)

            'Find and get the contentID, Name, and index
            nodeList = titlesList.Descendants("content")
            For Each node As XElement In nodeList
                Dim cIndex = node.Attribute("index").Value
                Dim contentId = node.Element("title").Attribute("id").Value
                Dim contentName = Replace(node.Element("title").<name>.Value, "<br>", " ")
                'Add them to the ListBox
                ListBox1.Items.Add(contentName + " - " + contentId)

            Next
            ListBox1.Sorted = True
            fetchList = False
        End If

    End Sub

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        If TextBox1.Text = Nothing Then
            Dim content As String = ListBox1.SelectedItem.ToString
            Dim dashIndex = ListBox1.SelectedItem.ToString.IndexOf("-") + 2
            Dim colonIndex = ListBox1.SelectedItem.ToString.IndexOf(":") + 2

            Me.ID = content.Substring(dashIndex, 14)
            Console.WriteLine(content.Substring(dashIndex, 14))


        Else
            Me.ID = TextBox1.Text
        End If

        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

End Class
