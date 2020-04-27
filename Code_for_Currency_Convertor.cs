Imports System.IO
Imports System.Text.RegularExpressions

Private Sub doCalculate()
        ' Need the scraping
        Dim Str As System.IO.Stream
        Dim srRead As System.IO.StreamReader
        Dim strAmount As String

        strAmount = currencyAmount.Text


        ' Get values from the textboxes
        Dim strFrom() As String = Split(currencyFrom.Text, " - ")
        Dim strTo() As String = Split(currencyTo.Text, " - ")

        ' Web fetching variables
        Dim req As System.Net.WebRequest = System.Net.WebRequest.Create("http://www.xe.com/ucc/convert.cgi?Amount=" + strAmount + "&From=" + strFrom(1) + "&To=" + strTo(1) + "YER&image.x=47&image.y=19&image=Submit")
        Dim resp As System.Net.WebResponse = req.GetResponse

        Str = resp.GetResponseStream
        srRead = New System.IO.StreamReader(Str)


        ' Match the response
        Try
            Dim myMatches As MatchCollection
            Dim myRegExp As New Regex("([0-9]+\.[0-9]+ " + strTo(1) + ")")

            myMatches = myRegExp.Matches(srRead.ReadToEnd)

            ' Search for all the words in the string
            Dim sucessfulMatch As Match
            For Each sucessfulMatch In myMatches
                mainText.Text = sucessfulMatch.Value
            Next
        Catch ex As Exception
            mainText.Text = "Unable to connect to XE"
        Finally
            ' Close the streams
            srRead.close()
            Str.Close()
        End Try
        convertToLabel.Text = strAmount + " " + strFrom(0) + " Converts To: "
    End Sub
    Private Sub convertButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles convertButton.Click
        ' Check if the currency is a number
        If Not IsNumeric(currencyAmount.Text) Then
            MsgBox("Please enter a valid amount!", MsgBoxStyle.Information, "Invalid Input")
            currencyAmount.Focus()
            Return
        End If

        doCalculate()
    End Sub

    Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        currencyFrom.selectedIndex = 0
        currencyTo.SelectedIndex = 1
    End Sub
End Class

