<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.chkRenta = New System.Windows.Forms.CheckBox()
        Me.chkDev = New System.Windows.Forms.CheckBox()
        Me.mtDev = New System.Windows.Forms.GroupBox()
        Me.dtRenta = New System.Windows.Forms.DateTimePicker()
        Me.btnContinuar = New System.Windows.Forms.Button()
        Me.btnRentar = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtGarantia = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbRenta = New System.Windows.Forms.ComboBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.dtDevolucion = New System.Windows.Forms.DateTimePicker()
        Me.dtRetorno = New System.Windows.Forms.DateTimePicker()
        Me.btnConcluir = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.chkNo = New System.Windows.Forms.CheckBox()
        Me.chkSi = New System.Windows.Forms.CheckBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmbDev = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.Tip = New System.Windows.Forms.ToolTip(Me.components)
        Me.mtDev.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'chkRenta
        '
        Me.chkRenta.AutoSize = True
        Me.chkRenta.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.chkRenta.Location = New System.Drawing.Point(94, 36)
        Me.chkRenta.Name = "chkRenta"
        Me.chkRenta.Size = New System.Drawing.Size(156, 25)
        Me.chkRenta.TabIndex = 0
        Me.chkRenta.Text = "Renta de Auto"
        Me.chkRenta.UseVisualStyleBackColor = True
        '
        'chkDev
        '
        Me.chkDev.AutoSize = True
        Me.chkDev.Location = New System.Drawing.Point(67, 36)
        Me.chkDev.Name = "chkDev"
        Me.chkDev.Size = New System.Drawing.Size(203, 25)
        Me.chkDev.TabIndex = 1
        Me.chkDev.Text = "Devolucion de Auto"
        Me.chkDev.UseVisualStyleBackColor = True
        '
        'mtDev
        '
        Me.mtDev.BackColor = System.Drawing.Color.Purple
        Me.mtDev.Controls.Add(Me.dtRenta)
        Me.mtDev.Controls.Add(Me.btnRentar)
        Me.mtDev.Controls.Add(Me.Label7)
        Me.mtDev.Controls.Add(Me.txtGarantia)
        Me.mtDev.Controls.Add(Me.Label4)
        Me.mtDev.Controls.Add(Me.Label2)
        Me.mtDev.Controls.Add(Me.cmbRenta)
        Me.mtDev.Controls.Add(Me.chkRenta)
        Me.mtDev.Font = New System.Drawing.Font("Modern No. 20", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mtDev.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.mtDev.Location = New System.Drawing.Point(97, 75)
        Me.mtDev.Name = "mtDev"
        Me.mtDev.Size = New System.Drawing.Size(333, 580)
        Me.mtDev.TabIndex = 2
        Me.mtDev.TabStop = False
        Me.mtDev.Text = "Renta"
        '
        'dtRenta
        '
        Me.dtRenta.Enabled = False
        Me.dtRenta.Location = New System.Drawing.Point(6, 213)
        Me.dtRenta.Name = "dtRenta"
        Me.dtRenta.Size = New System.Drawing.Size(321, 27)
        Me.dtRenta.TabIndex = 13
        '
        'btnContinuar
        '
        Me.btnContinuar.BackColor = System.Drawing.Color.Indigo
        Me.btnContinuar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnContinuar.Enabled = False
        Me.btnContinuar.Font = New System.Drawing.Font("Modern No. 20", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnContinuar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnContinuar.Location = New System.Drawing.Point(102, 507)
        Me.btnContinuar.Name = "btnContinuar"
        Me.btnContinuar.Size = New System.Drawing.Size(116, 42)
        Me.btnContinuar.TabIndex = 12
        Me.btnContinuar.Text = "Continuar"
        Me.btnContinuar.UseVisualStyleBackColor = False
        '
        'btnRentar
        '
        Me.btnRentar.BackColor = System.Drawing.Color.Indigo
        Me.btnRentar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRentar.Enabled = False
        Me.btnRentar.Location = New System.Drawing.Point(113, 267)
        Me.btnRentar.Name = "btnRentar"
        Me.btnRentar.Size = New System.Drawing.Size(116, 42)
        Me.btnRentar.TabIndex = 11
        Me.btnRentar.Text = "Rentar"
        Me.btnRentar.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label7.Location = New System.Drawing.Point(90, 340)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(149, 21)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Precio garantía:"
        '
        'txtGarantia
        '
        Me.txtGarantia.Enabled = False
        Me.txtGarantia.Location = New System.Drawing.Point(113, 383)
        Me.txtGarantia.Name = "txtGarantia"
        Me.txtGarantia.Size = New System.Drawing.Size(118, 27)
        Me.txtGarantia.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label4.Location = New System.Drawing.Point(47, 151)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(228, 50)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Ingrese la fecha en la que se rento el auto:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(49, 76)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(249, 21)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Elija el automovil a rentar:"
        '
        'cmbRenta
        '
        Me.cmbRenta.Enabled = False
        Me.cmbRenta.FormattingEnabled = True
        Me.cmbRenta.Items.AddRange(New Object() {"Chevrolet Spark 2014", "Mitsubishi Outlander 2016", "Cadillac SRX 2015", "Ford Mustang 2018", "Toyota CHR 2019"})
        Me.cmbRenta.Location = New System.Drawing.Point(51, 107)
        Me.cmbRenta.Name = "cmbRenta"
        Me.cmbRenta.Size = New System.Drawing.Size(247, 29)
        Me.cmbRenta.TabIndex = 1
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Purple
        Me.GroupBox2.Controls.Add(Me.dtDevolucion)
        Me.GroupBox2.Controls.Add(Me.btnContinuar)
        Me.GroupBox2.Controls.Add(Me.dtRetorno)
        Me.GroupBox2.Controls.Add(Me.btnConcluir)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.chkNo)
        Me.GroupBox2.Controls.Add(Me.chkSi)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.cmbDev)
        Me.GroupBox2.Controls.Add(Me.chkDev)
        Me.GroupBox2.Font = New System.Drawing.Font("Modern No. 20", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox2.Location = New System.Drawing.Point(488, 75)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(333, 580)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Devolucion"
        '
        'dtDevolucion
        '
        Me.dtDevolucion.Enabled = False
        Me.dtDevolucion.Location = New System.Drawing.Point(6, 213)
        Me.dtDevolucion.Name = "dtDevolucion"
        Me.dtDevolucion.Size = New System.Drawing.Size(321, 27)
        Me.dtDevolucion.TabIndex = 14
        '
        'dtRetorno
        '
        Me.dtRetorno.Enabled = False
        Me.dtRetorno.Location = New System.Drawing.Point(6, 310)
        Me.dtRetorno.Name = "dtRetorno"
        Me.dtRetorno.Size = New System.Drawing.Size(321, 27)
        Me.dtRetorno.TabIndex = 15
        '
        'btnConcluir
        '
        Me.btnConcluir.BackColor = System.Drawing.Color.Indigo
        Me.btnConcluir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnConcluir.Enabled = False
        Me.btnConcluir.Location = New System.Drawing.Point(102, 415)
        Me.btnConcluir.Name = "btnConcluir"
        Me.btnConcluir.Size = New System.Drawing.Size(121, 66)
        Me.btnConcluir.TabIndex = 12
        Me.btnConcluir.Text = "Concluir retorno"
        Me.btnConcluir.UseVisualStyleBackColor = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(45, 361)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(225, 21)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "¿El auto presenta daños?"
        '
        'chkNo
        '
        Me.chkNo.AutoSize = True
        Me.chkNo.Location = New System.Drawing.Point(177, 385)
        Me.chkNo.Name = "chkNo"
        Me.chkNo.Size = New System.Drawing.Size(56, 25)
        Me.chkNo.TabIndex = 10
        Me.chkNo.Text = "No"
        Me.chkNo.UseVisualStyleBackColor = True
        '
        'chkSi
        '
        Me.chkSi.AutoSize = True
        Me.chkSi.Location = New System.Drawing.Point(91, 385)
        Me.chkSi.Name = "chkSi"
        Me.chkSi.Size = New System.Drawing.Size(50, 25)
        Me.chkSi.TabIndex = 9
        Me.chkSi.Text = "Si"
        Me.chkSi.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(53, 243)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(223, 50)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Ingrese la fecha en la que se retorno el auto:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(59, 151)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(222, 50)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Ingrese la fecha en la que se rento el auto:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(53, 61)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(228, 50)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Elija el automovil a devolver:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cmbDev
        '
        Me.cmbDev.Enabled = False
        Me.cmbDev.FormattingEnabled = True
        Me.cmbDev.IntegralHeight = False
        Me.cmbDev.Items.AddRange(New Object() {"Chevrolet Spark 2014", "Mitsubishi Outlander 2016", "Cadillac SRX 2015", "Ford Mustang 2018", "Toyota CHR 2019"})
        Me.cmbDev.Location = New System.Drawing.Point(42, 107)
        Me.cmbDev.Name = "cmbDev"
        Me.cmbDev.Size = New System.Drawing.Size(250, 29)
        Me.cmbDev.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Purple
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Font = New System.Drawing.Font("Impact", 14.0!)
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(318, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(206, 52)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Escoja una opcion"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnSalir
        '
        Me.btnSalir.BackColor = System.Drawing.Color.Purple
        Me.btnSalir.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnSalir.Location = New System.Drawing.Point(665, 661)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(115, 46)
        Me.btnSalir.TabIndex = 5
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.BackgroundImage = Global.Proyecto.My.Resources.Resources._11c6bab89a46e2ff235c5ac7ad154f47
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(979, 719)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.mtDev)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "Rent-A-Car"
        Me.mtDev.ResumeLayout(False)
        Me.mtDev.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents chkRenta As CheckBox
    Friend WithEvents chkDev As CheckBox
    Friend WithEvents mtDev As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cmbRenta As ComboBox
    Friend WithEvents cmbDev As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtGarantia As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents chkNo As CheckBox
    Friend WithEvents chkSi As CheckBox
    Friend WithEvents btnRentar As Button
    Friend WithEvents btnConcluir As Button
    Friend WithEvents btnSalir As Button
    Friend WithEvents Tip As ToolTip
    Friend WithEvents btnContinuar As Button
    Friend WithEvents dtRenta As DateTimePicker
    Friend WithEvents dtDevolucion As DateTimePicker
    Friend WithEvents dtRetorno As DateTimePicker
End Class
