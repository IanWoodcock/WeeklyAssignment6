Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load



    End Sub


    Private Sub btnEnterSpeed_Click(sender As Object, e As EventArgs) Handles btnEnterSpeed.Click
        Dim decSpeed As Decimal
        Dim decSumOfSpeeds As Decimal
        Dim decAverage As Decimal
        Dim strSpeed As String
        Dim strIBoxMsg As String = "Enter the number of Mbps of your home internet: "
        Dim strIBoxTitle As String = "Internet Speed: "
        Dim strNotNumericMsg As String = "Error - Enter the speed of your home Internet connection: "
        Dim strNegErrorMsg As String = "Error - Enter a valid speed: "

        Dim intMaxEntries As Integer = 10
        Dim intEntries As Integer = 1

        strSpeed = InputBox(strIBoxMsg & intEntries, strIBoxTitle)

        Do Until intEntries > intMaxEntries Or strSpeed = ""
            If IsNumeric(strSpeed) Then
                decSpeed = Convert.ToDecimal(strSpeed)
                If decSpeed > 0 Then
                    lstSpeeds.Items.Add(decSpeed)
                    decSumOfSpeeds += decSpeed
                    intEntries += 1
                    strIBoxMsg = strIBoxMsg
                Else
                    strIBoxMsg = strNegErrorMsg
                End If
            Else
                strIBoxMsg = strNotNumericMsg
            End If
            If intEntries <= intMaxEntries Then
                strSpeed = InputBox(strIBoxMsg & intEntries, strIBoxTitle)
            End If
        Loop

        If intEntries > 1 Then
            decAverage = decSumOfSpeeds / (intEntries - 1)
            lblAveSpeed.Text = decAverage.ToString("F2") & " Mbps "
        End If
    End Sub
End Class
