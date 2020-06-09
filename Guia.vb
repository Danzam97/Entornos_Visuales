Public Class Almacenes
    Private Sub btnMenu_Click(sender As Object, e As EventArgs) Handles btnMenu.Click
        MainMenu.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim almacen, suma As Integer
        Dim promedio As Double
        suma = 0
        For i = 1 To 10 Step 1
            almacen = InputBox("Ingrese las ventas mensuales de este almacen", i)
            suma = suma + almacen
            If i = 1 Then
                txtAlmacen1.Text = almacen
            ElseIf i = 2 Then
                txtAlmacen2.Text = almacen
            ElseIf i = 3 Then
                txtAlmacen3.Text = almacen
            ElseIf i = 4 Then
                txtAlmacen4.Text = almacen
            ElseIf i = 5 Then
                txtAlmacen5.Text = almacen
            ElseIf i = 6 Then
                txtAlmacen6.Text = almacen
            ElseIf i = 7 Then
                txtAlmacen7.Text = almacen
            ElseIf i = 8 Then
                txtAlmacen8.Text = almacen
            ElseIf i = 9 Then
                txtAlmacen9.Text = almacen
            ElseIf i = 10 Then
                txtAlmacen10.Text = almacen
            End If
        Next
        promedio = suma / 10
        txtPromedio.Text = promedio

        If Val(txtAlmacen1.Text) > promedio Then
            txtMayores.Text &= "Almacen "
            txtMayores.Text &= 1
            txtMayores.Text &= Environment.NewLine
            txtMayores.SelectionStart = txtMayores.Text.Length
        End If

        If Val(txtAlmacen2.Text) > promedio Then
            txtMayores.Text &= "Almacen "
            txtMayores.Text &= 2
            txtMayores.Text &= Environment.NewLine
            txtMayores.SelectionStart = txtMayores.Text.Length
        End If
        If Val(txtAlmacen3.Text) > promedio Then
            txtMayores.Text &= "Almacen "
            txtMayores.Text &= 3
            txtMayores.Text &= Environment.NewLine
            txtMayores.SelectionStart = txtMayores.Text.Length
        End If
        If Val(txtAlmacen4.Text) > promedio Then
            txtMayores.Text &= "Almacen "
            txtMayores.Text &= 4
            txtMayores.Text &= Environment.NewLine
            txtMayores.SelectionStart = txtMayores.Text.Length
        End If
        If Val(txtAlmacen5.Text) > promedio Then
            txtMayores.Text &= "Almacen "
            txtMayores.Text &= 5
            txtMayores.Text &= Environment.NewLine
            txtMayores.SelectionStart = txtMayores.Text.Length
        End If
        If Val(txtAlmacen6.Text) > promedio Then
            txtMayores.Text &= "Almacen "
            txtMayores.Text &= 6
            txtMayores.Text &= Environment.NewLine
            txtMayores.SelectionStart = txtMayores.Text.Length
        End If
        If Val(txtAlmacen7.Text) > promedio Then
            txtMayores.Text &= "Almacen "
            txtMayores.Text &= 7
            txtMayores.Text &= Environment.NewLine
            txtMayores.SelectionStart = txtMayores.Text.Length
        End If
        If Val(txtAlmacen8.Text) > promedio Then
            txtMayores.Text &= "Almacen "
            txtMayores.Text &= 8
            txtMayores.Text &= Environment.NewLine
            txtMayores.SelectionStart = txtMayores.Text.Length
        End If
        If Val(txtAlmacen9.Text) > promedio Then
            txtMayores.Text &= "Almacen "
            txtMayores.Text &= 9
            txtMayores.Text &= Environment.NewLine
            txtMayores.SelectionStart = txtMayores.Text.Length
        End If
        If Val(txtAlmacen10.Text) > promedio Then
            txtMayores.Text &= "Almacen "
            txtMayores.Text &= 10
            txtMayores.Text &= Environment.NewLine
            txtMayores.SelectionStart = txtMayores.Text.Length
        End If
    End Sub
End Class