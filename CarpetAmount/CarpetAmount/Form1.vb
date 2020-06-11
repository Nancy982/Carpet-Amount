'Nancy Medina
'CS105
'Spring-2020

'I pledge that I have neither given nor received help from anyone other than the instructor and TA 
'for all program components included here.

Public Class Form1

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        'Declare variables for the two lengths for the total.
        Dim intLengthX As Integer
        Dim intLengthY As Integer
        Dim intTotal As Integer

        'Collect user input for the 2 lenghts 
        intLengthX = CInt(txtLengthX.Text)
        intLengthY = CInt(txtLengthY.Text)

        'Multiply the 2 lengths and store them in the variable total
        intTotal = intLengthX * intLengthY

        'Display the total on the form 
        lblResult.Text = intTotal & " sq ft"
    End Sub
End Class
