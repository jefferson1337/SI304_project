Public Class frmCalculadora

    Public valor As Double
    Public funcao As String

    Private Sub btnDivisao_Click(sender As Object, e As EventArgs) Handles btnDivisao.Click
        valor = txtResultado.Text
        txtResultado.Text = ""
        funcao = "divide"
    End Sub

    Private Sub btnLimpar_Click(sender As Object, e As EventArgs) Handles btnLimpar.Click
        txtResultado.Text = ""
    End Sub

    Private Sub btnMultiplicacao_Click(sender As Object, e As EventArgs) Handles btnMultiplicacao.Click
        valor = txtResultado.Text
        txtResultado.Text = ""
        funcao = "multiplica"
    End Sub

    Private Sub btnNum0_Click(sender As Object, e As EventArgs) Handles btnNum0.Click
        txtResultado.Text = txtResultado.Text & "0"
    End Sub

    Private Sub btnNum1_Click(sender As Object, e As EventArgs) Handles btnNum1.Click
        txtResultado.Text = txtResultado.Text & "1"
    End Sub

    Private Sub btnNum2_Click(sender As Object, e As EventArgs) Handles btnNum2.Click
        txtResultado.Text = txtResultado.Text & "2"
    End Sub

    Private Sub btnNum3_Click(sender As Object, e As EventArgs) Handles btnNum3.Click
        txtResultado.Text = txtResultado.Text & "3"
    End Sub

    Private Sub btnNum4_Click(sender As Object, e As EventArgs) Handles btnNum4.Click
        txtResultado.Text = txtResultado.Text & "4"
    End Sub

    Private Sub btnNum5_Click(sender As Object, e As EventArgs) Handles btnNum5.Click
        txtResultado.Text = txtResultado.Text & "5"
    End Sub

    Private Sub btnNum6_Click(sender As Object, e As EventArgs) Handles btnNum6.Click
        txtResultado.Text = txtResultado.Text & "6"
    End Sub

    Private Sub btnNum7_Click(sender As Object, e As EventArgs) Handles btnNum7.Click
        txtResultado.Text = txtResultado.Text & "7"
    End Sub

    Private Sub btnNum8_Click(sender As Object, e As EventArgs) Handles btnNum8.Click
        txtResultado.Text = txtResultado.Text & "8"
    End Sub

    Private Sub btnNum9_Click(sender As Object, e As EventArgs) Handles btnNum9.Click
        txtResultado.Text = txtResultado.Text & "9"
    End Sub

    Private Sub btnSoma_Click(sender As Object, e As EventArgs) Handles btnSoma.Click
        valor = txtResultado.Text
        txtResultado.Text = ""
        funcao = "soma"
    End Sub

    Private Sub btnSubtracao_Click(sender As Object, e As EventArgs) Handles btnSubtracao.Click
        valor = txtResultado.Text
        txtResultado.Text = ""
        funcao = "subtrai"
    End Sub

    Private Sub btnVirgula_Click(sender As Object, e As EventArgs) Handles btnVirgula.Click
        txtResultado.Text = txtResultado.Text & ","
    End Sub

    Private Sub btnIgual_Click(sender As Object, e As EventArgs) Handles btnIgual.Click
        Select Case funcao
            Case "soma"
                valor = valor + txtResultado.Text
                txtResultado.Text = valor
            Case "subtrai"
                valor = valor - txtResultado.Text
                txtResultado.Text = valor
            Case "multiplica"
                valor = valor * txtResultado.Text
                txtResultado.Text = valor
            Case "divide"
                If txtResultado.Text = "0" Then
                    txtResultado.Text = "ERRO: divisão por 0"
                Else
                    valor = valor / txtResultado.Text
                    txtResultado.Text = valor
                End If

        End Select

    End Sub

    Private Sub frmCalculadora_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class

