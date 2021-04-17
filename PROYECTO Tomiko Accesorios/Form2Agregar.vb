Public Class FPedidos
#Region "Parametros"
    Public par_Apenom As String
    Public par_importe As String
    Public par_cantidad As Integer
    Public par_estilo As String
    Public par_producto As String
    Public par_redsocial As String
    Public par_nrotelefono As String
    Public par_estado As String
    Public par_envio As Boolean



#End Region
    Private Sub BAceptar_Click(sender As Object, e As EventArgs) Handles BAceptar.Click
        Dim datoscorrectos As Boolean
        Dim rta As DialogResult
        Dim rtaenvio As DialogResult




        If TApellidoNombre.Text = "" Then

            MsgBox("Falta nombre", MsgBoxStyle.Critical, "ERROR")
            TApellidoNombre.Focus()
        ElseIf (Not (mtTelefono.MaskCompleted)) Then
            MsgBox("Falta completar el Telefono", MsgBoxStyle.Critical, "Error")
            mtTelefono.Focus()
        ElseIf (Not (mtImporte.MaskCompleted)) Then
            MsgBox("Debe completar el importe", MsgBoxStyle.Critical, "IMPORTE")

        ElseIf ((cbProducto.Text = "Seleccione..")) Or (cbProducto.Text = "") Then
                MsgBox("Seleccione algun producto", MsgBoxStyle.Critical, "PRODUCTO")
                cbEstilo.Focus()
            ElseIf (cbProducto.SelectedIndex = -1) Then
                rta = MsgBox("Queres agregar el producto" & cbProducto.Text, MsgBoxStyle.Question, "AGREGAR")
                If (rta = DialogResult.Yes) Then
                    cbProducto.Items.Add(cbProducto.Text) ' agrego 
                    datoscorrectos = True
                Else
                    MsgBox("Debe seleccionar un producto", MsgBoxStyle.Critical, "PRODUCTO ")
                End If

            Else
                datoscorrectos = True
        End If
        'si todo esta  correcto
        If datoscorrectos Then
            par_Apenom = TApellidoNombre.Text.Trim
            par_nrotelefono = mtTelefono.Text
            par_importe = mtImporte.Text
            par_estilo = cbEstilo.Text
            par_producto = cbProducto.Text
            par_cantidad = nudCantidad.Value
            par_envio = checkEnvio.Checked


            If rbFacebook.Checked Then
                par_redsocial = rbFacebook.Text
            Else
                par_redsocial = rbInstagram.Text

            End If



            DialogResult = DialogResult.OK


        End If

    End Sub



    Private Sub BCancelar_Click(sender As Object, e As EventArgs) Handles BCancelar.Click
        Dim rta As Integer
        rta = MsgBox("Desea no agregar pedidos a Tomiko Accs.?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "SALIR")
        If rta = MsgBoxResult.Yes Then

            DialogResult = DialogResult.Cancel

        End If

    End Sub

    Private Sub FPedidos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If (par_estado = "nuevo") Then
            TApellidoNombre.Text = ""
            mtImporte.Text = ""
            mtTelefono.Text = ""
            rbFacebook.Checked = False
            rbInstagram.Checked = False
            cbProducto.Text = "Seleccione "
            nudCantidad.Value = 1
            checkEnvio.Checked = False
            Text = "NUEVO PEDIDO"
            BAceptar.Text = "&Agregar"
            TApellidoNombre.Enabled = True
        ElseIf (par_estado = "Modifica") Then
            TApellidoNombre.Text = par_Apenom
            mtImporte.Text = par_importe
            mtTelefono.Text = par_nrotelefono
            checkEnvio.Checked = par_envio
            If rbInstagram.Checked Then
                rbInstagram.Text = par_redsocial
            ElseIf rbFacebook.Checked Then
                rbFacebook.Text = par_redsocial
            End If
            ' rbFacebook.Text = par_redsocial
            cbProducto.Text = par_producto
                cbEstilo.Text = par_estilo
                Text = "Modificar Pedido "
                BAceptar.Text = "&Modificar"
                TApellidoNombre.Enabled = True


        ElseIf (par_estado = "Existe Nombre") Then

                TApellidoNombre.Text = ""
            mtTelefono.Text = ""
            cbProducto.Text = par_producto
            Text = ""

            TApellidoNombre.Enabled = True



        End If







        cbEstilo.SelectedIndex = 0







    End Sub

    Private Sub mtTelefono_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles mtTelefono.MaskInputRejected
        MsgBox("SOLO SE PERMITEN INGRESO DE NUMEROS", MsgBoxStyle.Critical, "ERROR EN INGRESO")
    End Sub

    Private Sub mtImporte_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles mtImporte.MaskInputRejected
        MsgBox("SOLO SE PERMITEN INGRESO DE NUMEROS", MsgBoxStyle.Critical, "ERROR EN INGRESO")
    End Sub
End Class