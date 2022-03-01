Imports System.Net

Public Class Viewer

    Private Sub Viewer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

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

        Try
            metadata = XDocument.Load("https://samurai.ctr.shop.nintendo.net/samurai/ws/US/title/" + Dialog1.ID + "/?shop_id=2")
            webErr = False
        Catch ex As WebException When DirectCast(ex.Response, HttpWebResponse).StatusCode = HttpStatusCode.NotFound
            MsgBox("This software is currently unavailable.", vbOK, "Error 3021")
            webErr = True
        End Try


        If Not webErr Then
            'Set Game Image
            Dim image = metadata.<eshop>.<title>.<icon_url>.Value
            gameImage.ImageLocation = image
            T_softTitle_01.Text = metadata.<eshop>.<title>.<name>.Value
            description.Text = Replace(metadata.<eshop>.<title>.<description>.Value, "<br>", vbNewLine)
            BottomScreen.AutoScroll = True
        Else
            gameImage.ImageLocation = Nothing
            T_softTitle_01.Text = "Title"
        End If

        'Restore SSL Certificate Validation Checking
        'System.Net.ServicePointManager.ServerCertificateValidationCallback = Nothing
    End Sub

End Class
