Public Class Form1

    Private Sub Yontem1Button_Click(sender As Object, e As EventArgs) Handles Yontem1Button.Click
        Dim Sayi As Decimal
        'Sayi = Rnd()
        'Ürettilen 0 ile 1 arasındaki ondalık sayıyı daha büyük ve tam sayıya dönüştürme
        'Sayi = CInt(Rnd() * 100) '0 ile 100 arasında sayılar üretir
        'Sayi = CInt(Rnd() * 5) + 5 ' 5 ile 10 arasında sayı üretir
        Sayi = CInt(Rnd() * 1000) Mod 6 + 5 ' 5 ile 10 arasında sayı üretir
        'Büyük sayıdan küçük sayıyı çıkart +1 ekle Mod'un önüne yaz + dan sonra küçük sayıyı yaz
        SayiTextBox.Text = Sayi
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        Randomize()
    End Sub

    Private Sub Yontem2Button_Click(sender As Object, e As EventArgs) Handles Yontem2Button.Click
        Dim Sayi As Decimal
        Dim Rastgele As New Random
        'Sayi = Rastgele.Next ' negatif olmayan integer sayılar üretir
        'Sayi = Rastgele.Next(10) '0 ile 10 arasında saylar üretir
        Sayi = Rastgele.Next(10, 20) '10 ile 20 arasında saylar üretir
        SayiTextBox.Text = Sayi
    End Sub
End Class
