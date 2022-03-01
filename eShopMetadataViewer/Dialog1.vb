Imports System.IO
Imports System.Windows.Forms
Imports System.Xml

Public Class Dialog1
    Public Property ID As String

    's


    Private Sub Dialog1_Open(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.Load

        'Check if the titles database is downloaded; if not, download it
        Dim FileName As String
        Dim FileExists As String
        FileName = Directory.GetCurrentDirectory() + "\titles.xml"
        FileExists = Dir(FileName)

        If FileExists = "" Then
            My.Computer.Network.DownloadFile("https://samurai.ctr.shop.nintendo.net/samurai/ws/US/titles?limit=1000000", Directory.GetCurrentDirectory() + "\titles.xml")
        End If
        'Load the list
        Dim titlesList = XDocument.Load("https://samurai.ctr.shop.nintendo.net/samurai/ws/US/titles?limit=1000000")

        'Find and get the contentID and Name
        Dim nodeList = titlesList.Descendants("title")
        For Each node As XElement In nodeList
            Dim contentId = node.Attribute("id").Value
            Dim contentName = node.<name>.Value
            Dim combined As String
            'Add them to the ListBox
            ListBox1.Items.Add(contentName + " - " + contentId)

        Next
        ListBox1.Sorted = True
    End Sub

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        If TextBox1.Text = Nothing Then
            Dim content As String = ListBox1.SelectedItem.ToString
            Dim dashIndex = ListBox1.SelectedItem.ToString.IndexOf("-") + 2

            Me.ID = content.Substring(dashIndex)
            Console.WriteLine(content.Substring(dashIndex))
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
