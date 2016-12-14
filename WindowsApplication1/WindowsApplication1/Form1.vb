Public Class Form1
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim cap, strok, vtank, rpm, kelvin, sayi As Integer
        Dim bar, cc, mtank, time, mcc, verim, b, joule, kw, k As Double
        Dim a, c As Integer


        Const pi = 3.1416
        sayi = NumericUpDown1.Text
        cap = TextBox1.Text
        strok = TextBox2.Text
        bar = ComboBox3.Text
        kelvin = TextBox4.Text
        rpm = ComboBox2.Text
        vtank = ComboBox1.Text
        cc = ((cap ^ 2) * strok * pi) / 4000
        mtank = (bar * vtank) / (0.287 * 10 * kelvin)
        mcc = cc / 1000000
        verim = TrackBar1.Value
        time = mtank / (mcc * rpm * sayi * (verim / 100))
        a = Math.Floor(time)
        b = time - a
        c = 60 * b

        Label13.Text = cc
        Label12.Text = mtank
        Label17.Text = a
        Label18.Text = c

        'kg başına kj hesabı
        If RadioButton1.Checked Then
            k = 1.4
        End If
        If RadioButton2.Checked Then
            k = 1.3
        End If

        joule = (((bar / 0.9) ^ ((k - 1) / k)) - 1) * ((k * 0.287 * kelvin) / (k - 1))



            kw = (joule * mtank) / (time * 60)
        Label20.Text = kw


    End Sub

    Private Sub TrackBar1_Click(sender As Object, e As EventArgs) Handles TrackBar1.Click
        Button2.PerformClick()
    End Sub

    Private Sub TrackBar1_Scroll(sender As Object, e As EventArgs) Handles TrackBar1.Scroll
        Dim verim As Integer


        verim = TrackBar1.Value
        Label16.Text = verim

    End Sub




End Class
