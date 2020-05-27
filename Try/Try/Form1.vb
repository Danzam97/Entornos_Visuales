Public Class Form1
    Private Sub btnValidar_Click(sender As Object, e As EventArgs) Handles btnValidar.Click
        'Try Catch
        'ValidateChildren Button
        'Validating      Cajas de texto
        Try
            'Si las casillas estan sin ningun valor
            'Aplique a todos los elementos. Producto sea diferente de vacio, precio sea diferente de vacio
            If Me.ValidateChildren And txtProducto.Text <> String.Empty And txtPrecio.Text <> String.Empty And Val(txtCantidad.Text - Int(Val(txtCantidad.Text)) = 0 Then
                MessageBox.Show("Producto Ingresado", "Formulario Producto", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Revise los datos ingresados", "Error en Productos", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception

        End Try
    End Sub
End Class
