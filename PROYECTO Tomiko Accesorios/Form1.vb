Public Class FAccesorios

    Public Structure tipo_pedido
        Dim Apenom As String
        Dim importe As Decimal
        Dim cantidad As Integer
        Dim producto As String ' lo que vende
        Dim estilo As String ' bijou, plata 925 o acero
        Dim redsocial As String  'radio buton
        Dim nrotelefono As String
        Dim envio As Boolean ' checked

    End Structure
    Dim tope As Integer = 100
    Dim ultimo As Integer = -1
    Dim arpedido(tope) As tipo_pedido

    'declaracion de formularios
    Dim fpedidos As FPedidos
    Dim facerca As FormAcercaDe

    'creacion de formularios, le asigne la variable
    Private Sub FAccesorios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ultimo = -1
        fpedidos = New FPedidos()
        facerca = New FormAcercaDe()
        BcargarRich.Visible = True


    End Sub

    Private Sub BAgregar_Click(sender As Object, e As EventArgs) Handles BAgregar.Click
        'Lcantidadlistbox.Visible = True
        Lcantpedidos.Visible = True
        gbBuscar.Enabled = True

        Dim nuevopedido As tipo_pedido
        Dim rta As DialogResult
        Dim agregarpedido As Boolean
        nuevopedido.Apenom = FPedidos.par_Apenom
        nuevopedido.redsocial = FPedidos.par_redsocial


        'TOPE
        If (ultimo = tope) Then
            rta = MsgBox("No hay mas lugar, desea agregar más capacidad?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "PEDIDO")
            If (rta = DialogResult.Yes) Then
                tope = tope + 4
                ReDim Preserve arpedido(tope)
            Else
                MsgBox("No se pueden agregar más pedidos", MsgBoxStyle.Critical, "SIN CAPACIDAD")
            End If
        End If

        'ENTRA AL ARREGLO, ya que ultimo es menor al tope 
        If (ultimo < tope) Then
            agregarpedido = False ' en algun momento cancela , para no agregar repetidos
            fpedidos.par_estado = "nuevo"
            fpedidos.ShowDialog()

            Do
                If FPedidos.DialogResult = DialogResult.OK Then
                    If Existe(arpedido, ultimo, FPedidos.par_Apenom) Then
                        MsgBox("El pedido de " & FPedidos.par_Apenom & "ya existe", MsgBoxStyle.Critical, "Pedido")

                        FPedidos.par_estado = "Existe Nombre"
                        FPedidos.ShowDialog()
                    Else
                        agregarpedido = True


                    End If
                End If

            Loop Until (FPedidos.DialogResult <> DialogResult.OK) Or agregarpedido

            If agregarpedido Then
                nuevopedido.Apenom = FPedidos.par_Apenom
                'cbfilApenom.Items.Add(nuevopedido.Apenom)
                nuevopedido.nrotelefono = FPedidos.par_nrotelefono
                nuevopedido.estilo = FPedidos.par_estilo
                nuevopedido.producto = FPedidos.par_producto
                nuevopedido.importe = FPedidos.par_importe
                nuevopedido.redsocial = fpedidos.par_redsocial
                nuevopedido.envio = fpedidos.par_envio


                'cbfilredsocial.Items.Add(nuevopedido.redsocial)
                nuevopedido.cantidad = fpedidos.par_cantidad
                ' que no se repita el añadir items al combobox.
                If (Not cbfilApenom.Items.Contains(nuevopedido.Apenom)) Then

                    cbfilApenom.Items.Add(nuevopedido.Apenom)
                End If
                If (Not cbfilredsocial.Items.Contains(nuevopedido.redsocial)) Then
                    cbfilredsocial.Items.Add(nuevopedido.redsocial)

                End If

                MsgBox("Pedido Agregado a la lista!!!", MsgBoxStyle.Exclamation, "EXITOSO")
                insertar(arpedido, ultimo, nuevopedido)

                    actualizar()




                End If


            End If
    End Sub

    'FUNCION QUE ME MUESTRA LA CADENA EN EL LIST BOX, ES LO QUE DESEO MOSTRAR AL USUARIO. SE PUEDE MODIFICAR.
    Private Function datospedido(pedido As tipo_pedido) As String
        Dim cadena As String = ""

        cadena = "Nombre Cliente: " & pedido.Apenom & "- FB/IG: " & pedido.redsocial & " - " '& pedido.envio
        cadena = cadena & "- Producto: " & pedido.producto & "- Cantidad: " & Convert.ToString(pedido.cantidad)
        If (pedido.envio) Then
            cadena = cadena & "--> Pedido con Envio "
        Else
            cadena = cadena & "--> Pedido sin Envio "


        End If


        Return cadena

    End Function


    Private Sub Listar()
        Dim i As Integer
        Dim cadena As String
        Dim pedido As tipo_pedido
        lbPedidos.Items.Clear()




        For i = 0 To ultimo

            pedido = arpedido(i)



            cadena = datospedido(pedido)
            lbPedidos.Items.Add(cadena) 'añado al list box


        Next i

    End Sub

    Private Sub Listara(clientesel As String, catsel As String, enviosel As String)
        Dim i As Integer
        Dim cadena As String
        Dim pedido As tipo_pedido
        Dim catok As Boolean = False
        Dim clienteok As Boolean = False
        Dim enviook As Boolean = False
        lbPedidos.Items.Clear()




        For i = 0 To ultimo
            pedido = arpedido(i)
            If (clientesel = "Todos") Then
                clienteok = True

            ElseIf pedido.Apenom = clientesel Then

                clienteok = True
            End If
            If (catsel = "Todos") Then
                catok = True

            ElseIf pedido.redsocial = catsel Then

                catok = True
            End If
            Select Case enviosel
                Case "Todos" : enviook = True
                Case "Sin Envio" : enviook = Not pedido.envio
                Case "Con Envio" : enviook = pedido.envio


            End Select


            'If (enviosel = "Todos") Then
            '    enviook = True

            'ElseIf (enviosel = "Sin Envio") Then

            '    enviook = True
            'ElseIf pedido.envio = enviook Then
            '    enviook = True
            'End If

            If (clienteok) And (catok) And (enviook) Then

                cadena = datospedido(pedido)
                lbPedidos.Items.Add(cadena) 'añado al list box
            End If



        Next i

    End Sub




    Private Sub actualizar()
        Dim clientesel As String
        Dim catsel As String
        Dim enviosel As String


        Listar() '(producto, cbfilApenom.Text, cbfilredsocial.Text)

        Lcantpedidos.Text = "Cantidad de Pedidos:" & ultimo + 1
        'Lcantidadlistbox.Text = "Cantidad de pedidos Totales: " & lbPedidos.Items.Count


        ' Lcantpedidos.Text = "Cantidad de pedidos:  "

    End Sub





    Private Sub insertar(ByRef arlista() As tipo_pedido, ByRef ultimo As Integer, nuevopedido As tipo_pedido)

        arlista(ultimo + 1) = nuevopedido
        ultimo = ultimo + 1
    End Sub
    Private Function Existe(ByRef lista() As tipo_pedido, ByRef ultimo As Integer, nombre As String) As Boolean

        Dim pos As Integer = 0
        While (pos <= ultimo) AndAlso (lista(pos).Apenom <> nombre)

            pos = pos + 1


        End While

        Return (pos <= ultimo)
    End Function

    Private Sub BCerrar_Click(sender As Object, e As EventArgs) Handles BCerrar.Click
        Dim rta As Integer
        rta = MsgBox("Desea salir de Pedidos Tomiko?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "SALIR")
        If rta = MsgBoxResult.Yes Then

            Close()


        End If

    End Sub

    Private Sub BFiltrar_Click(sender As Object, e As EventArgs) Handles BFiltrar.Click
        Dim pos As Integer
        Dim cadena As String
        Dim clientesel As String
        Dim catsel As String
        Dim enviosel As String
        'Dim clientesel As String


        lbPedidos.Items.Clear()
        BLimpiar.Visible = True

        If (cbfilApenom.Text = "Todos") And (cbfilredsocial.Text = "Todos") And (rbTodos.Checked) Then

            Listara(clientesel, catsel, enviosel)
            'Listar()
        Else
            clientesel = cbfilApenom.Text
            catsel = cbfilredsocial.Text
            If rbConenvio.Checked Then
                enviosel = "Con Envio"


            ElseIf rbSinenvio.Checked Then
                enviosel = "Sin Envio"
            Else
                enviosel = "Todos"

            End If

            Listara(clientesel, catsel, enviosel)
            'Listar()
        End If
    End Sub

    Private Sub BModificar_Click(sender As Object, e As EventArgs) Handles BModificar.Click


        Dim pedido As tipo_pedido
        Dim pos As Integer
        BLimpiar.Visible = False
        If (lbPedidos.SelectedIndex = -1) Then
            MsgBox("Seleccione un pedido ", MsgBoxStyle.Critical, "PEDIDOS")
            lbPedidos.Focus()
        Else
            pos = buscarpedido(arpedido, ultimo, lbPedidos.SelectedItem)
            If (pos = -1) Then

                MsgBox("Pedido no encontrado", MsgBoxStyle.Critical, "PEDIDO")

            Else
                pos = lbPedidos.SelectedIndex
                pedido = arpedido(pos)  ' para no perder lo guardo en una variable
                fpedidos.par_estado = "Modifica"
                fpedidos.par_Apenom = pedido.Apenom
                fpedidos.par_cantidad = pedido.cantidad
                fpedidos.par_envio = pedido.envio
                fpedidos.par_redsocial = pedido.redsocial
                fpedidos.par_importe = pedido.importe
                fpedidos.par_estilo = pedido.estilo
                fpedidos.par_producto = pedido.producto
                fpedidos.par_nrotelefono = pedido.nrotelefono
                fpedidos.ShowDialog()
                If fpedidos.DialogResult = DialogResult.OK Then
                    pedido.producto = fpedidos.par_producto
                    pedido.estilo = fpedidos.par_estilo
                    pedido.Apenom = fpedidos.par_Apenom
                    pedido.envio = fpedidos.par_envio
                    pedido.redsocial = fpedidos.par_redsocial
                    pedido.importe = fpedidos.par_importe
                    pedido.producto = fpedidos.par_producto
                    pedido.nrotelefono = fpedidos.par_nrotelefono
                    pedido.cantidad = fpedidos.par_cantidad

                    arpedido(pos) = pedido ' lo modificado lo vuelvo asignar en esa posicion 
                    actualizar()

                End If

            End If

        End If


    End Sub

    Private Function buscarpedido(ByRef lista() As tipo_pedido, ByRef ultimo As Integer, listaseleccion As String) As Integer

        Dim pos As Integer
        Dim cadena As String
        Dim pedido As tipo_pedido
        Dim encontro As Boolean
        encontro = False
        While (pos <= ultimo) And (Not encontro)
            pedido = lista(pos)
            cadena = datospedido(pedido)
            ' compara lo que selecciono con la cadena
            If listaseleccion = cadena Then
                encontro = True


            Else
                pos = pos + 1

            End If


        End While

        If (pos > ultimo) Then
            pos = -1



        End If

        Return (pos)
    End Function

    Private Sub Eliminarpedido(ByRef pedido() As tipo_pedido, ByRef ultimo As Integer, nombre As String)

        Dim posicion As Integer = 0
        Dim i As Integer
        'me busca el nombre 
        While (posicion <= ultimo) AndAlso (pedido(posicion).Apenom <> nombre)

            posicion = posicion + 1


        End While
        'modifico el arreglo
        If (posicion <= ultimo) Then
            For i = posicion To ultimo - 1
                pedido(i) = pedido(i + 1)

            Next i

            ultimo = ultimo - 1
        End If


    End Sub

    Private Sub BEliminar_Click(sender As Object, e As EventArgs) Handles BEliminar.Click
        Dim nombre As String
        Dim respuesta As DialogResult
        BLimpiar.Visible = False

        If (lbPedidos.SelectedIndex = -1) Then
            MsgBox("No selecciono ningun pedido, SELECIONE UNO ", MsgBoxStyle.Critical, "ERROR")
            lbPedidos.Focus()

        Else
            nombre = arpedido(lbPedidos.SelectedIndex).Apenom ' nombre cliente
            respuesta = MsgBox("Segura que desea eliminar el pedido de : " & nombre & "?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "PEDIDO")

            If (respuesta = DialogResult.Yes) Then
                cbfilApenom.SelectedIndex = -1
                cbfilredsocial.SelectedIndex = -1
                ' cbfilApenom.Items.RemoveAt(cbfilApenom.SelectedIndex)

                Eliminarpedido(arpedido, ultimo, nombre)
                actualizar()
                MsgBox("Se elimino el pedido correctamente!!!", MsgBoxStyle.Critical, "PEDIDO ELIMINADO")
            Else
                MsgBox("No se elimino el pedido de la lista!!!", MsgBoxStyle.Critical, "PEDIDO NO ELIMINADO")

            End If

        End If



    End Sub

    Private Sub Lcantpedidos_Click(sender As Object, e As EventArgs) Handles Lcantpedidos.Click
        Dim respuestareset As Integer

        respuestareset = MsgBox("¿Desear eliminar todos los pedidos?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ELIMINAR PEDIDOS")

        If (respuestareset = MsgBoxResult.Yes) Then
            ultimo = -1 ' vacio

            cbfilApenom.Items.Clear()
            cbfilredsocial.Items.Clear()
            cbfilApenom.SelectedIndex = -1
            cbfilredsocial.SelectedIndex = -1
            actualizar()

        End If

    End Sub

    Private Sub cbfilApenom_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbfilApenom.SelectedIndexChanged
        'actualizar()
    End Sub

    Private Sub cbfilredsocial_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbfilredsocial.SelectedIndexChanged
        ' actualizar()
    End Sub

    Private Sub BAcercaDe_Click(sender As Object, e As EventArgs) Handles BAcercaDe.Click
        facerca.ShowDialog()
    End Sub

    Private Sub BcargarRich_Click(sender As Object, e As EventArgs) Handles BcargarRich.Click
        If DialogAbrir.ShowDialog() = DialogResult.OK Then

            rtObservaciones.LoadFile(DialogAbrir.FileName)  'nombre del archivo 

        End If
    End Sub

    Private Sub BguardarRich_Click(sender As Object, e As EventArgs) Handles BguardarRich.Click
        If DialogGuardar.ShowDialog() = DialogResult.OK Then

            rtObservaciones.SaveFile(DialogGuardar.FileName)
        End If
        rtObservaciones.Clear()
    End Sub

    Private Sub Bobservaciones_Click(sender As Object, e As EventArgs) Handles Bobservaciones.Click

        If (lbPedidos.SelectedIndex = -1) Then
            MsgBox("No selecciono ningun pedido, SELECIONE UNO ", MsgBoxStyle.Critical, "ERROR")
            lbPedidos.Focus()
        Else
            BguardarRich.Visible = True
            BcargarRich.Visible = True

            rtObservaciones.AppendText(lbPedidos.SelectedItem)
        End If
    End Sub

    Private Sub BLimpiar_Click(sender As Object, e As EventArgs) Handles BLimpiar.Click
        BLimpiar.Visible = False
        actualizar()

        cbfilApenom.SelectedIndex = -1
        cbfilredsocial.SelectedIndex = -1
        rbConenvio.Checked = False
        rbSinenvio.Checked = False
        rbTodos.Checked = True


    End Sub

    Private Sub DialogGuardar_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles DialogGuardar.FileOk

    End Sub
End Class
