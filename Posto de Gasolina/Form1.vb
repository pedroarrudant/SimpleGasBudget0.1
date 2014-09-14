Public Class Form1

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LblAlcool.Click

    End Sub

    Private Sub btncaldesc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncaldesc.Click
        Dim A As Double, G As Double, descAlcool As Double, total As Double, descGasolina As Double, desconto As Double


        A = Convert.ToDouble(Txtalcool.Text)
        G = Convert.ToDouble(Txtgasolina.Text)


        If (A <= 20) Then
            descAlcool = (2.9 * 3) / 100
        ElseIf (A >= 21) Then
            descAlcool = (2.9 * 5) / 100
        ElseIf (G <= 20) Then
            descGasolina = (3.3 * 4) / 100
        ElseIf (G >= 21) Then
            descGasolina = (3.3 * 6) / 100
        End If
        A = A - descAlcool
        G = G - descGasolina
        total = A + G
        desconto = descAlcool + descGasolina
        Lbldesc.Text = desconto.ToString("F")
        LblvalorTotal.Text = total.ToString("F")

    End Sub

    Private Sub btnsair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsair.Click
        End
    End Sub

    Private Sub btnlimpar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnlimpar.Click
        Txtalcool.Clear()
        Txtgasolina.Clear()

    End Sub

    Private Sub Label1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
End Class
