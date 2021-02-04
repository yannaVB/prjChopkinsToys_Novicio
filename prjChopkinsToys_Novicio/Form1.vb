Public Class Form1
    Private Sub BtnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Const strPROMPT As String = "Enter Shipping Fee:"
        Const strTITLE As String = "Shipping"

        Const dec12Pack As Decimal = 14.99D
        Const dec5Pack As Decimal = 6.99D
        Const dec2Pack As Decimal = 2.5D

        Dim int12Pack As Integer
        Dim int5pack As Integer
        Dim int2Pack As Integer
        Dim intTotalOrders As Integer

        Dim decTotalAmount As Decimal
        Dim dec12Total As Decimal
        Dim dec5Total As Decimal
        Dim dec2Total As Decimal
        Dim decShipping As Decimal
        'shipping'
        decShipping = Convert.ToDecimal(InputBox(strPROMPT, strTITLE))
        txtShipping.Text = decShipping.ToString("C2")

        Integer.TryParse(txt12pack1.Text, int12Pack)
        Integer.TryParse(txt5pack1.Text, int5pack)
        Integer.TryParse(txt2pack1.Text, int2Pack)
        intTotalOrders = int12Pack + int5pack + int2Pack
        txtSalesTotal.Text = intTotalOrders.ToString

        dec12Total = int12Pack * dec12Pack
        dec5Total = int5pack * dec5Pack
        dec2Total = int2Pack * dec2Pack

        txt12pack2.Text = dec12Total.ToString("C2")
        txt5pack2.Text = dec5Total.ToString("C2")
        txt2pack2.Text = dec2Total.ToString("C2")

        decTotalAmount = dec12Total + dec5Total + dec2Total + decShipping
        txtSalesTotal2.Text = decTotalAmount.ToString("C2")
        txtSalesTotal.Text = intTotalOrders.ToString()


    End Sub

    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Application.CurrentCulture = New Globalization.CultureInfo("en-US")
    End Sub

    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txt12pack1.Clear()
        txt12pack2.Clear()
        txt5pack1.Clear()
        txt5pack2.Clear()
        txt2pack2.Clear()
        txt2pack1.Clear()
        txtSalesTotal.Clear()
        txtSalesTotal2.Clear()
        txtShipping.Clear()

    End Sub
End Class
