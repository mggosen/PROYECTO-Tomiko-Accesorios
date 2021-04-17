<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FPedidos
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FPedidos))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.gbPedido = New System.Windows.Forms.GroupBox()
        Me.checkEnvio = New System.Windows.Forms.CheckBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cbProducto = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.nudCantidad = New System.Windows.Forms.NumericUpDown()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.mtImporte = New System.Windows.Forms.MaskedTextBox()
        Me.rbInstagram = New System.Windows.Forms.RadioButton()
        Me.rbFacebook = New System.Windows.Forms.RadioButton()
        Me.cbEstilo = New System.Windows.Forms.ComboBox()
        Me.mtTelefono = New System.Windows.Forms.MaskedTextBox()
        Me.TApellidoNombre = New System.Windows.Forms.TextBox()
        Me.BAceptar = New System.Windows.Forms.Button()
        Me.BCancelar = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbPedido.SuspendLayout()
        CType(Me.nudCantidad, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(331, 66)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(176, 118)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Gabriola", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Purple
        Me.Label1.Location = New System.Drawing.Point(364, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(117, 54)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "PEDIDOS"
        '
        'gbPedido
        '
        Me.gbPedido.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.gbPedido.Controls.Add(Me.checkEnvio)
        Me.gbPedido.Controls.Add(Me.Label8)
        Me.gbPedido.Controls.Add(Me.cbProducto)
        Me.gbPedido.Controls.Add(Me.Label7)
        Me.gbPedido.Controls.Add(Me.nudCantidad)
        Me.gbPedido.Controls.Add(Me.Label6)
        Me.gbPedido.Controls.Add(Me.Label5)
        Me.gbPedido.Controls.Add(Me.Label4)
        Me.gbPedido.Controls.Add(Me.Label3)
        Me.gbPedido.Controls.Add(Me.Label2)
        Me.gbPedido.Controls.Add(Me.mtImporte)
        Me.gbPedido.Controls.Add(Me.rbInstagram)
        Me.gbPedido.Controls.Add(Me.rbFacebook)
        Me.gbPedido.Controls.Add(Me.cbEstilo)
        Me.gbPedido.Controls.Add(Me.mtTelefono)
        Me.gbPedido.Controls.Add(Me.TApellidoNombre)
        Me.gbPedido.Font = New System.Drawing.Font("Source Serif Pro Semibold", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbPedido.ForeColor = System.Drawing.Color.Black
        Me.gbPedido.Location = New System.Drawing.Point(113, 190)
        Me.gbPedido.Name = "gbPedido"
        Me.gbPedido.Size = New System.Drawing.Size(615, 279)
        Me.gbPedido.TabIndex = 2
        Me.gbPedido.TabStop = False
        Me.gbPedido.Text = "Pedido Cliente"
        '
        'checkEnvio
        '
        Me.checkEnvio.AutoSize = True
        Me.checkEnvio.Location = New System.Drawing.Point(81, 239)
        Me.checkEnvio.Name = "checkEnvio"
        Me.checkEnvio.Size = New System.Drawing.Size(87, 21)
        Me.checkEnvio.TabIndex = 16
        Me.checkEnvio.Text = "Con Envio"
        Me.checkEnvio.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(16, 142)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(61, 17)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Producto"
        '
        'cbProducto
        '
        Me.cbProducto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cbProducto.FormattingEnabled = True
        Me.cbProducto.Items.AddRange(New Object() {"Anillo basico", "Anillo con dije", "Argollitas anchas", "Argollitas simples", "Cuff (aritos)", "Hebilla", "Pañuelo multicolor", "Pulsera "})
        Me.cbProducto.Location = New System.Drawing.Point(151, 134)
        Me.cbProducto.Name = "cbProducto"
        Me.cbProducto.Size = New System.Drawing.Size(150, 25)
        Me.cbProducto.Sorted = True
        Me.cbProducto.TabIndex = 13
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(350, 134)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(39, 17)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Cant:"
        '
        'nudCantidad
        '
        Me.nudCantidad.Location = New System.Drawing.Point(395, 131)
        Me.nudCantidad.Maximum = New Decimal(New Integer() {6, 0, 0, 0})
        Me.nudCantidad.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudCantidad.Name = "nudCantidad"
        Me.nudCantidad.Size = New System.Drawing.Size(37, 25)
        Me.nudCantidad.TabIndex = 11
        Me.nudCantidad.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(311, 212)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(159, 17)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Comunicacion a traves de:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(16, 187)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(54, 17)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Importe"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(16, 100)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 17)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Estilo"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(16, 62)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 17)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Telefono"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 29)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(115, 17)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Nombre y Apellido"
        '
        'mtImporte
        '
        Me.mtImporte.Location = New System.Drawing.Point(151, 179)
        Me.mtImporte.Mask = "099,00"
        Me.mtImporte.Name = "mtImporte"
        Me.mtImporte.Size = New System.Drawing.Size(92, 25)
        Me.mtImporte.TabIndex = 5
        '
        'rbInstagram
        '
        Me.rbInstagram.AutoSize = True
        Me.rbInstagram.Location = New System.Drawing.Point(495, 239)
        Me.rbInstagram.Name = "rbInstagram"
        Me.rbInstagram.Size = New System.Drawing.Size(79, 21)
        Me.rbInstagram.TabIndex = 4
        Me.rbInstagram.Text = "Facebook"
        Me.rbInstagram.UseVisualStyleBackColor = True
        '
        'rbFacebook
        '
        Me.rbFacebook.AutoSize = True
        Me.rbFacebook.Location = New System.Drawing.Point(495, 208)
        Me.rbFacebook.Name = "rbFacebook"
        Me.rbFacebook.Size = New System.Drawing.Size(85, 21)
        Me.rbFacebook.TabIndex = 3
        Me.rbFacebook.Text = "Instagram"
        Me.rbFacebook.UseVisualStyleBackColor = True
        '
        'cbEstilo
        '
        Me.cbEstilo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbEstilo.FormattingEnabled = True
        Me.cbEstilo.Items.AddRange(New Object() {"Acero quirurgico", "Bijou", "Plata 925"})
        Me.cbEstilo.Location = New System.Drawing.Point(151, 92)
        Me.cbEstilo.Name = "cbEstilo"
        Me.cbEstilo.Size = New System.Drawing.Size(150, 25)
        Me.cbEstilo.Sorted = True
        Me.cbEstilo.TabIndex = 2
        '
        'mtTelefono
        '
        Me.mtTelefono.Location = New System.Drawing.Point(151, 61)
        Me.mtTelefono.Mask = "(999)999-9999"
        Me.mtTelefono.Name = "mtTelefono"
        Me.mtTelefono.Size = New System.Drawing.Size(171, 25)
        Me.mtTelefono.TabIndex = 1
        '
        'TApellidoNombre
        '
        Me.TApellidoNombre.Location = New System.Drawing.Point(151, 23)
        Me.TApellidoNombre.Name = "TApellidoNombre"
        Me.TApellidoNombre.Size = New System.Drawing.Size(171, 25)
        Me.TApellidoNombre.TabIndex = 0
        '
        'BAceptar
        '
        Me.BAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BAceptar.ForeColor = System.Drawing.Color.Green
        Me.BAceptar.Location = New System.Drawing.Point(746, 398)
        Me.BAceptar.Name = "BAceptar"
        Me.BAceptar.Size = New System.Drawing.Size(75, 23)
        Me.BAceptar.TabIndex = 3
        Me.BAceptar.Text = "Aceptar"
        Me.BAceptar.UseVisualStyleBackColor = True
        '
        'BCancelar
        '
        Me.BCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BCancelar.ForeColor = System.Drawing.Color.Red
        Me.BCancelar.Location = New System.Drawing.Point(746, 446)
        Me.BCancelar.Name = "BCancelar"
        Me.BCancelar.Size = New System.Drawing.Size(75, 23)
        Me.BCancelar.TabIndex = 4
        Me.BCancelar.Text = "Cancelar"
        Me.BCancelar.UseVisualStyleBackColor = True
        '
        'FPedidos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(867, 481)
        Me.Controls.Add(Me.BCancelar)
        Me.Controls.Add(Me.BAceptar)
        Me.Controls.Add(Me.gbPedido)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "FPedidos"
        Me.Text = "PEDIDOS"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbPedido.ResumeLayout(False)
        Me.gbPedido.PerformLayout()
        CType(Me.nudCantidad, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents gbPedido As GroupBox
    Friend WithEvents rbInstagram As RadioButton
    Friend WithEvents rbFacebook As RadioButton
    Friend WithEvents cbEstilo As ComboBox
    Friend WithEvents mtTelefono As MaskedTextBox
    Friend WithEvents TApellidoNombre As TextBox
    Friend WithEvents mtImporte As MaskedTextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents cbProducto As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents nudCantidad As NumericUpDown
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents BAceptar As Button
    Friend WithEvents BCancelar As Button
    Friend WithEvents checkEnvio As CheckBox
End Class
