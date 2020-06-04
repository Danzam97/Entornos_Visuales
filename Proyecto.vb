Public Class Form1
    Private precioRenta As Integer
    Private precioRetorno As Integer
    Private total As Integer
    Public Sub btnRentar_Click(sender As Object, e As EventArgs) Handles btnRentar.Click
        Try

            'Seleccion
            If cmbRenta.SelectedItem = "Chevrolet Spark 2014" Then
                precioRenta = 5000
                txtGarantia.Text = precioRenta
                btnContinuar.Enabled = True
            End If
            If cmbRenta.SelectedItem = "Ford Mustang 2018" Then
                precioRenta = 15000
                txtGarantia.Text = precioRenta
                btnContinuar.Enabled = True
            End If
            If cmbRenta.SelectedItem = "Cadillac SRX 2015" Then
                precioRenta = 12000
                txtGarantia.Text = precioRenta
                btnContinuar.Enabled = True
            End If
            If cmbRenta.SelectedItem = "Mitsubishi Outlander 2016" Then
                precioRenta = 10000
                txtGarantia.Text = precioRenta
                btnContinuar.Enabled = True
            End If
            If cmbRenta.SelectedItem = "Toyota CHR 2019" Then
                precioRenta = 20000
                txtGarantia.Text = precioRenta
                btnContinuar.Enabled = True
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub btnConcluir_Click(sender As Object, e As EventArgs) Handles btnConcluir.Click
        Dim dias As Long
        Dim daño As Integer
        total = 0
        dias = DateDiff(DateInterval.Day, dtDevolucion.Value.Date, dtRetorno.Value.Date)
        Try

            For i = 1 To dias Step 1
                If cmbDev.SelectedItem = "Chevrolet Spark 2014" Then
                    total = total + 800
                End If
                If cmbDev.SelectedItem = "Ford Mustang 2018" Then
                    total = total + 1500
                End If
                If cmbDev.SelectedItem = "Cadillac SRX 2015" Then
                    total = total + 1000
                End If
                If cmbDev.SelectedItem = "Mitsubishi Outlander 2016" Then
                    total = total + 1200
                End If
                If cmbDev.SelectedItem = "Toyota CHR 2019" Then
                    total = total + 1800
                End If
            Next
            If chkSi.Checked = True Then
                chkNo.Enabled = False
                daño = InputBox("Ingrese cuanto costara la reparacion de los daños")
                total = total + daño
            Else
                chkNo.Enabled = True
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub chkRenta_CheckedChanged(sender As Object, e As EventArgs) Handles chkRenta.CheckedChanged
        'cast sender

        Dim senderCheck As CheckBox = DirectCast(sender, CheckBox)

        'loop through all checkboxes
        For Each checkbox In {chkRenta, chkDev}

            'only apply changes to non-sender  boxes
            If checkbox IsNot senderCheck Then

                'set property to opposite of sender so you can renable when unchecked
                checkbox.Enabled = Not senderCheck.Checked
            End If
        Next

        If chkRenta.Checked = True Then
            cmbRenta.Enabled = True
            txtGarantia.Enabled = True
            dtRenta.Enabled = True
            dtDevolucion.Enabled = False
            dtRetorno.Enabled = False
            cmbDev.Enabled = False
        Else
            cmbRenta.Enabled = False
            btnRentar.Enabled = False
            txtGarantia.Enabled = False
            cmbRenta.SelectedItem = ""
            txtGarantia.Clear()
        End If
    End Sub

    Private Sub chkDev_CheckedChanged(sender As Object, e As EventArgs) Handles chkDev.CheckedChanged
        'cast sender
        Dim senderCheck As CheckBox = DirectCast(sender, CheckBox)

        'loop through all checkboxes
        For Each checkbox In {chkDev, chkRenta}

            'only apply changes to non-sender  boxes
            If checkbox IsNot senderCheck Then

                'set property to opposite of sender so you can renable when unchecked
                checkbox.Enabled = Not senderCheck.Checked
            End If
        Next
        If chkDev.Checked = True Then
            cmbDev.Enabled = True
            dtRetorno.Enabled = True
            dtDevolucion.Enabled = True
            btnContinuar.Enabled = True
            dtRenta.Enabled = False
            btnConcluir.Enabled = True
            cmbRenta.Enabled = False
        Else
            cmbDev.Enabled = False
            btnContinuar.Enabled = False
            btnConcluir.Enabled = False
            cmbDev.SelectedItem = ""
        End If
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        End
    End Sub

    Private Sub chkNo_CheckedChanged(sender As Object, e As EventArgs) Handles chkNo.CheckedChanged
        If chkNo.Checked = True Then
            chkSi.Enabled = False
        Else
            chkSi.Enabled = True
        End If
    End Sub

    Private Sub btnContinuar_Click(sender As Object, e As EventArgs) Handles btnContinuar.Click
        Form2.Show()
        Me.Hide()
    End Sub
End Class
