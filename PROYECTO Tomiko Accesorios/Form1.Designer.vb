<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FAccesorios
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FAccesorios))
        Me.BCerrar = New System.Windows.Forms.Button()
        Me.lbPedidos = New System.Windows.Forms.ListBox()
        Me.BAgregar = New System.Windows.Forms.Button()
        Me.BEliminar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbfilredsocial = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbfilApenom = New System.Windows.Forms.ComboBox()
        Me.Lcantpedidos = New System.Windows.Forms.Label()
        Me.BModificar = New System.Windows.Forms.Button()
        Me.BAcercaDe = New System.Windows.Forms.Button()
        Me.BFiltrar = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.gbBuscar = New System.Windows.Forms.GroupBox()
        Me.rbTodos = New System.Windows.Forms.RadioButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.rbSinenvio = New System.Windows.Forms.RadioButton()
        Me.rbConenvio = New System.Windows.Forms.RadioButton()
        Me.rtObservaciones = New System.Windows.Forms.RichTextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DialogGuardar = New System.Windows.Forms.SaveFileDialog()
        Me.DialogAbrir = New System.Windows.Forms.OpenFileDialog()
        Me.BcargarRich = New System.Windows.Forms.Button()
        Me.BguardarRich = New System.Windows.Forms.Button()
        Me.Bobservaciones = New System.Windows.Forms.Button()
        Me.BLimpiar = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbBuscar.SuspendLayout()
        Me.SuspendLayout()
        '
        'BCerrar
        '
        Me.BCerrar.BackColor = System.Drawing.Color.MediumSlateBlue
        Me.BCerrar.Font = New System.Drawing.Font("Source Serif Pro Semibold", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.BCerrar.Location = New System.Drawing.Point(851, 444)
        Me.BCerrar.Name = "BCerrar"
        Me.BCerrar.Size = New System.Drawing.Size(75, 23)
        Me.BCerrar.TabIndex = 0
        Me.BCerrar.Text = "&Cerrar"
        Me.BCerrar.UseVisualStyleBackColor = False
        '
        'lbPedidos
        '
        Me.lbPedidos.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lbPedidos.Font = New System.Drawing.Font("Source Serif Pro Semibold", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.lbPedidos.FormattingEnabled = True
        Me.lbPedidos.ItemHeight = 16
        Me.lbPedidos.Location = New System.Drawing.Point(33, 12)
        Me.lbPedidos.Name = "lbPedidos"
        Me.lbPedidos.Size = New System.Drawing.Size(689, 100)
        Me.lbPedidos.TabIndex = 1
        '
        'BAgregar
        '
        Me.BAgregar.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BAgregar.Font = New System.Drawing.Font("Source Serif Pro Semibold", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.BAgregar.Location = New System.Drawing.Point(290, 374)
        Me.BAgregar.Name = "BAgregar"
        Me.BAgregar.Size = New System.Drawing.Size(101, 23)
        Me.BAgregar.TabIndex = 2
        Me.BAgregar.Text = "Agregar Pedido"
        Me.BAgregar.UseVisualStyleBackColor = False
        '
        'BEliminar
        '
        Me.BEliminar.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BEliminar.Font = New System.Drawing.Font("Source Serif Pro Semibold", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.BEliminar.Location = New System.Drawing.Point(290, 412)
        Me.BEliminar.Name = "BEliminar"
        Me.BEliminar.Size = New System.Drawing.Size(101, 23)
        Me.BEliminar.TabIndex = 3
        Me.BEliminar.Text = "&Eliminar Pedido"
        Me.BEliminar.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Source Serif Pro", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(6, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 21)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Cliente"
        '
        'cbfilredsocial
        '
        Me.cbfilredsocial.FormattingEnabled = True
        Me.cbfilredsocial.Items.AddRange(New Object() {"Todos"})
        Me.cbfilredsocial.Location = New System.Drawing.Point(99, 85)
        Me.cbfilredsocial.Name = "cbfilredsocial"
        Me.cbfilredsocial.Size = New System.Drawing.Size(160, 23)
        Me.cbfilredsocial.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Source Serif Pro", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(6, 87)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 21)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Red Social"
        '
        'cbfilApenom
        '
        Me.cbfilApenom.FormattingEnabled = True
        Me.cbfilApenom.Items.AddRange(New Object() {"Todos"})
        Me.cbfilApenom.Location = New System.Drawing.Point(99, 30)
        Me.cbfilApenom.Name = "cbfilApenom"
        Me.cbfilApenom.Size = New System.Drawing.Size(160, 23)
        Me.cbfilApenom.TabIndex = 7
        '
        'Lcantpedidos
        '
        Me.Lcantpedidos.AutoSize = True
        Me.Lcantpedidos.Font = New System.Drawing.Font("Source Serif Pro Semibold", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lcantpedidos.Location = New System.Drawing.Point(728, 25)
        Me.Lcantpedidos.Name = "Lcantpedidos"
        Me.Lcantpedidos.Size = New System.Drawing.Size(160, 16)
        Me.Lcantpedidos.TabIndex = 8
        Me.Lcantpedidos.Text = "Cantidad de pedidos Totales:"
        Me.Lcantpedidos.Visible = False
        '
        'BModificar
        '
        Me.BModificar.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BModificar.Font = New System.Drawing.Font("Source Serif Pro Semibold", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.BModificar.Location = New System.Drawing.Point(560, 373)
        Me.BModificar.Name = "BModificar"
        Me.BModificar.Size = New System.Drawing.Size(106, 24)
        Me.BModificar.TabIndex = 9
        Me.BModificar.Text = "Modificar Pedido"
        Me.BModificar.UseVisualStyleBackColor = False
        '
        'BAcercaDe
        '
        Me.BAcercaDe.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BAcercaDe.Font = New System.Drawing.Font("Source Serif Pro Semibold", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.BAcercaDe.Location = New System.Drawing.Point(560, 424)
        Me.BAcercaDe.Name = "BAcercaDe"
        Me.BAcercaDe.Size = New System.Drawing.Size(106, 43)
        Me.BAcercaDe.TabIndex = 10
        Me.BAcercaDe.Text = "Acerca de Tomiko"
        Me.BAcercaDe.UseVisualStyleBackColor = False
        '
        'BFiltrar
        '
        Me.BFiltrar.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.BFiltrar.Location = New System.Drawing.Point(265, 107)
        Me.BFiltrar.Name = "BFiltrar"
        Me.BFiltrar.Size = New System.Drawing.Size(75, 23)
        Me.BFiltrar.TabIndex = 11
        Me.BFiltrar.Text = "Filtrar"
        Me.BFiltrar.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(397, 353)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(157, 127)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 12
        Me.PictureBox1.TabStop = False
        '
        'gbBuscar
        '
        Me.gbBuscar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.gbBuscar.Controls.Add(Me.rbTodos)
        Me.gbBuscar.Controls.Add(Me.Label3)
        Me.gbBuscar.Controls.Add(Me.rbSinenvio)
        Me.gbBuscar.Controls.Add(Me.rbConenvio)
        Me.gbBuscar.Controls.Add(Me.Label1)
        Me.gbBuscar.Controls.Add(Me.cbfilApenom)
        Me.gbBuscar.Controls.Add(Me.Label2)
        Me.gbBuscar.Controls.Add(Me.cbfilredsocial)
        Me.gbBuscar.Controls.Add(Me.BFiltrar)
        Me.gbBuscar.Enabled = False
        Me.gbBuscar.Font = New System.Drawing.Font("Source Sans Pro Semibold", 8.999999!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbBuscar.Location = New System.Drawing.Point(33, 155)
        Me.gbBuscar.Name = "gbBuscar"
        Me.gbBuscar.Size = New System.Drawing.Size(358, 188)
        Me.gbBuscar.TabIndex = 13
        Me.gbBuscar.TabStop = False
        Me.gbBuscar.Text = "Buscar por:"
        '
        'rbTodos
        '
        Me.rbTodos.AutoSize = True
        Me.rbTodos.Checked = True
        Me.rbTodos.Location = New System.Drawing.Point(146, 130)
        Me.rbTodos.Name = "rbTodos"
        Me.rbTodos.Size = New System.Drawing.Size(53, 19)
        Me.rbTodos.TabIndex = 21
        Me.rbTodos.TabStop = True
        Me.rbTodos.Text = "Todos"
        Me.rbTodos.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Source Serif Pro", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Label3.Location = New System.Drawing.Point(6, 138)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 21)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Pedidos "
        '
        'rbSinenvio
        '
        Me.rbSinenvio.AutoSize = True
        Me.rbSinenvio.Font = New System.Drawing.Font("Source Serif Pro", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.rbSinenvio.Location = New System.Drawing.Point(193, 155)
        Me.rbSinenvio.Name = "rbSinenvio"
        Me.rbSinenvio.Size = New System.Drawing.Size(91, 25)
        Me.rbSinenvio.TabIndex = 16
        Me.rbSinenvio.TabStop = True
        Me.rbSinenvio.Text = "Sin Envio"
        Me.rbSinenvio.UseVisualStyleBackColor = True
        '
        'rbConenvio
        '
        Me.rbConenvio.AutoSize = True
        Me.rbConenvio.Font = New System.Drawing.Font("Source Serif Pro", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.rbConenvio.Location = New System.Drawing.Point(91, 155)
        Me.rbConenvio.Name = "rbConenvio"
        Me.rbConenvio.Size = New System.Drawing.Size(96, 25)
        Me.rbConenvio.TabIndex = 15
        Me.rbConenvio.Text = "Con Envio"
        Me.rbConenvio.UseVisualStyleBackColor = True
        '
        'rtObservaciones
        '
        Me.rtObservaciones.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.rtObservaciones.Font = New System.Drawing.Font("Source Serif Pro Semibold", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.rtObservaciones.Location = New System.Drawing.Point(604, 222)
        Me.rtObservaciones.Name = "rtObservaciones"
        Me.rtObservaciones.Size = New System.Drawing.Size(322, 109)
        Me.rtObservaciones.TabIndex = 14
        Me.rtObservaciones.Text = ""
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label4.Font = New System.Drawing.Font("Source Sans Pro Semibold", 9.749999!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(665, 174)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(202, 42)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "OBSERVACIONES DE PEDIDOS"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DialogGuardar
        '
        Me.DialogGuardar.DefaultExt = "rtf"
        Me.DialogGuardar.Filter = "Texto Enriquecido |*.rtf|Todos los archivos |*.*"
        Me.DialogGuardar.Title = "Guardar"
        '
        'DialogAbrir
        '
        Me.DialogAbrir.DefaultExt = "rtf"
        Me.DialogAbrir.FileName = "OpenFileDialog1"
        Me.DialogAbrir.Filter = "Texto Enriquecido |*.rtf|Todos los archivos |*.*"
        Me.DialogAbrir.Title = "Cargar"
        '
        'BcargarRich
        '
        Me.BcargarRich.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BcargarRich.Location = New System.Drawing.Point(873, 192)
        Me.BcargarRich.Name = "BcargarRich"
        Me.BcargarRich.Size = New System.Drawing.Size(82, 26)
        Me.BcargarRich.TabIndex = 17
        Me.BcargarRich.Text = "Mostrar Obs."
        Me.BcargarRich.UseVisualStyleBackColor = False
        Me.BcargarRich.Visible = False
        '
        'BguardarRich
        '
        Me.BguardarRich.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BguardarRich.Location = New System.Drawing.Point(574, 192)
        Me.BguardarRich.Name = "BguardarRich"
        Me.BguardarRich.Size = New System.Drawing.Size(85, 24)
        Me.BguardarRich.TabIndex = 18
        Me.BguardarRich.Text = "Agregar Obs."
        Me.BguardarRich.UseVisualStyleBackColor = False
        Me.BguardarRich.Visible = False
        '
        'Bobservaciones
        '
        Me.Bobservaciones.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Bobservaciones.Location = New System.Drawing.Point(728, 89)
        Me.Bobservaciones.Name = "Bobservaciones"
        Me.Bobservaciones.Size = New System.Drawing.Size(93, 23)
        Me.Bobservaciones.TabIndex = 19
        Me.Bobservaciones.Text = "Observaciones"
        Me.Bobservaciones.UseVisualStyleBackColor = False
        '
        'BLimpiar
        '
        Me.BLimpiar.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BLimpiar.Font = New System.Drawing.Font("Source Serif Pro Semibold", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.BLimpiar.Location = New System.Drawing.Point(33, 353)
        Me.BLimpiar.Name = "BLimpiar"
        Me.BLimpiar.Size = New System.Drawing.Size(63, 28)
        Me.BLimpiar.TabIndex = 20
        Me.BLimpiar.Text = "&Limpiar"
        Me.BLimpiar.UseVisualStyleBackColor = False
        Me.BLimpiar.Visible = False
        '
        'FAccesorios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(965, 479)
        Me.Controls.Add(Me.BLimpiar)
        Me.Controls.Add(Me.Bobservaciones)
        Me.Controls.Add(Me.BguardarRich)
        Me.Controls.Add(Me.BcargarRich)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.rtObservaciones)
        Me.Controls.Add(Me.gbBuscar)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.BAcercaDe)
        Me.Controls.Add(Me.BModificar)
        Me.Controls.Add(Me.Lcantpedidos)
        Me.Controls.Add(Me.BEliminar)
        Me.Controls.Add(Me.BAgregar)
        Me.Controls.Add(Me.lbPedidos)
        Me.Controls.Add(Me.BCerrar)
        Me.Name = "FAccesorios"
        Me.Text = "TOMIKO ACCESORIOS"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbBuscar.ResumeLayout(False)
        Me.gbBuscar.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BCerrar As Button
    Friend WithEvents lbPedidos As ListBox
    Friend WithEvents BAgregar As Button
    Friend WithEvents BEliminar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents cbfilredsocial As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents cbfilApenom As ComboBox
    Friend WithEvents Lcantpedidos As Label
    Friend WithEvents BModificar As Button
    Friend WithEvents BAcercaDe As Button
    Friend WithEvents BFiltrar As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents gbBuscar As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents rbSinenvio As RadioButton
    Friend WithEvents rbConenvio As RadioButton
    Friend WithEvents rtObservaciones As RichTextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents DialogGuardar As SaveFileDialog
    Friend WithEvents DialogAbrir As OpenFileDialog
    Friend WithEvents BcargarRich As Button
    Friend WithEvents BguardarRich As Button
    Friend WithEvents Bobservaciones As Button
    Friend WithEvents BLimpiar As Button
    Friend WithEvents rbTodos As RadioButton
End Class
