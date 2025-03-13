Public Class Form1

    Dim operacion As String

    Dim valorresultado As Nullable(Of Double) = Nothing

    Dim valor2 As Nullable(Of Double) = Nothing

    Dim sepresionaoperador As Boolean

    Private Sub button0_Click(sender As Object, e As EventArgs) Handles button0.Click
        evaluarrestriccionesparaconcatenar()
        txtresultado.Text &= "0"
    End Sub

    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        evaluarrestriccionesparaconcatenar()
        txtresultado.Text &= "1"
    End Sub

    Private Sub button2_Click(sender As Object, e As EventArgs) Handles button2.Click
        evaluarrestriccionesparaconcatenar()
        txtresultado.Text &= "2"
    End Sub

    Private Sub button3_Click(sender As Object, e As EventArgs) Handles button3.Click
        evaluarrestriccionesparaconcatenar()
        txtresultado.Text &= "3"
    End Sub

    Private Sub button4_Click(sender As Object, e As EventArgs) Handles button4.Click
        evaluarrestriccionesparaconcatenar()
        txtresultado.Text &= "4"
    End Sub

    Private Sub button5_Click(sender As Object, e As EventArgs) Handles button5.Click
        evaluarrestriccionesparaconcatenar()
        txtresultado.Text &= "5"
    End Sub

    Private Sub button6_Click(sender As Object, e As EventArgs) Handles button6.Click
        evaluarrestriccionesparaconcatenar()
        txtresultado.Text &= "6"
    End Sub

    Private Sub button7_Click(sender As Object, e As EventArgs) Handles button7.Click
        evaluarrestriccionesparaconcatenar()
        txtresultado.Text &= "7"
    End Sub

    Private Sub button8_Click(sender As Object, e As EventArgs) Handles button8.Click
        evaluarrestriccionesparaconcatenar()
        txtresultado.Text &= "8"
    End Sub

    Private Sub button9_Click(sender As Object, e As EventArgs) Handles button9.Click
        evaluarrestriccionesparaconcatenar()
        txtresultado.Text &= "9"
    End Sub

    Private Sub buttonpunto_Click(sender As Object, e As EventArgs) Handles buttonpunto.Click
        evaluarrestriccionesparaconcatenar()
        If InStr(txtresultado.Text, ".", CompareMethod.Text) = 0 Then
            txtresultado.Text &= "."
        End If

    End Sub

    Private Sub buttonigual_Click(sender As Object, e As EventArgs) Handles buttonigual.Click
        evaluayhazoperacion()
        operacion = ""
        memoria.Items.Add(valorresultado)
    End Sub

    Private Sub buttonborrar_Click(sender As Object, e As EventArgs) Handles buttonborrar.Click
        txtresultado.Text = "0"
        valorresultado = Nothing
        valor2 = Nothing
    End Sub

    Private Sub buttonentre_Click(sender As Object, e As EventArgs) Handles buttonentre.Click
        evaluayhazoperacion()
        operacion = "/"
    End Sub

    Private Sub buttonpor_Click(sender As Object, e As EventArgs) Handles buttonpor.Click
        evaluayhazoperacion()
        operacion = "*"
    End Sub

    Private Sub buttonmenos_Click(sender As Object, e As EventArgs) Handles buttonmenos.Click
        evaluayhazoperacion()
        operacion = "-"
    End Sub

    Private Sub buttonmas_Click(sender As Object, e As EventArgs) Handles buttonmas.Click
        evaluayhazoperacion()
        operacion = "+"
    End Sub

    Public Sub evaluayhazoperacion()
        sepresionaoperador = True
        valor2 = Val(txtresultado.Text)
        If valorresultado IsNot Nothing Then
            Select Case operacion
                Case "+"
                    valorresultado += valor2
                Case "-"
                    valorresultado -= valor2
                Case "*"
                    valorresultado *= valor2
                Case "/"
                    valorresultado /= valor2
            End Select
            txtresultado.Text = valorresultado
        Else
            valorresultado = valor2

        End If


    End Sub

    Public Sub evaluarrestriccionesparaconcatenar()

        If sepresionaoperador = True Then
            txtresultado.Text = ""
            sepresionaoperador = False

        ElseIf txtresultado.Text = "0" Then
            txtresultado.Text = ""
        End If
    End Sub
End Class
