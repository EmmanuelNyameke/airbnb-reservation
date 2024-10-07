' Program Name: Airbnb Reservation
' Date: September 20, 2024
' Author: K Bola
' Purpose: This program calculate the cost of an airbnb stay for an apartment in Orlando, Florida  
Public Class frmAirbnb
    Const _cdecPricePerNight As Decimal = 79D
    Dim strNumberOfNights As String
    Dim intNumberOfNight As Integer
    Dim decTotalCost As Decimal

    Private Sub btnDisplayCost_Click(sender As Object, e As EventArgs) Handles btnDisplayCost.Click
        strNumberOfNights = txtNumberOfNight.Text
        intNumberOfNight = Convert.ToInt32(strNumberOfNights)
        decTotalCost = intNumberOfNight * _cdecPricePerNight
        lblCost.Text = decTotalCost.ToString("C")
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtNumberOfNight.Clear()
        lblCost.Text = ""
        txtNumberOfNight.Focus()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()
    End Sub

    Private Sub frmAirbnb_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblPricePerNight.Text = "Only " & _cdecPricePerNight.ToString("C") & " Per Night"
        lblCost.Text = ""
        txtNumberOfNight.Focus()
    End Sub
End Class
