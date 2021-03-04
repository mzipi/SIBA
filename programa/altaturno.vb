Public Class altaturno

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnatras.Click
        txtcod.Clear()
        txtnombre.Clear()
        

    End Sub

    Private Sub btnclose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclose.Click
        Select Case MsgBox("Desea cerrar sesión?", MsgBoxStyle.YesNo)
            Case MsgBoxResult.Yes
                txtcod.Clear()
                txtnombre.Clear()
                login.txtusuario.clear()

                login.txtpass.clear()
                login.Show()
                Me.Close()
            Case MsgBoxResult.No
                Me.Hide()
                Me.Show()
        End Select
    End Sub

    Private Sub btningresar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnaceptar.Click

        Dim control As Integer
        control = 0
        Dim controlnombre As Integer
        controlnombre = 0
        Dim controlturno As Integer
        controlturno = 0

        If (txtnombre.Text <> "Matutino" Or txtnombre.Text <> "Vespertino" Or txtnombre.Text <> "Nocturno") Then
            MsgBox("Ingrese 'Matutino' 'Vespertino' o 'Nocturno' como nombre de Turno")
            controlturno = 1
        End If
        If (txtcod.Text = "") Then
            MsgBox("Debe ingresar un código para el turno")
        End If
        If (txtnombre.Text = "") Then
            MsgBox("Debe ingresar un nombre para el turno")
        End If


        'controla que no se repita el codigo de turno al ingresar
        If (accion = acciones.ingresar And txtnombre.Text <> "" And txtcod.Text <> "" And controlturno <> 1) Then
            Dim cx As New Odbc.OdbcConnection
            Dim cm As New Odbc.OdbcCommand
            Dim da As New Odbc.OdbcDataAdapter
            Dim ds As New Data.DataSet

            cx.ConnectionString = "FileDSN=c:\itechplus_sec.dsn;UID=techplus_sec;pwd=1234"
            cx.Open()
            cm.Connection = cx
            cm.CommandText = "SELECT id_turno FROM turno where id_turno =" + txtcod.Text
            cm.ExecuteNonQuery()
            da.SelectCommand = cm
            da.Fill(ds, "turno")

            If ds.Tables("turno").Rows.Count > 0 Then
                MsgBox("Código de turno ya existente, debe ingresar un código distinto")
                control = 1
            End If
            cx.Close()
        End If


        'controla que no se repita el nombre del de turno al ingresar
        If (accion = acciones.ingresar And txtnombre.Text <> "") Then
            Dim cx As New Odbc.OdbcConnection
            Dim cm As New Odbc.OdbcCommand
            Dim da As New Odbc.OdbcDataAdapter
            Dim ds As New Data.DataSet

            cx.ConnectionString = "FileDSN=c:\itechplus_sec.dsn;UID=techplus_sec;pwd=1234"
            cx.Open()
            cm.Connection = cx
            cm.CommandText = "SELECT nombre_turno FROM turno where nombre_turno='" + txtnombre.Text + "'"
            cm.ExecuteNonQuery()
            da.SelectCommand = cm
            da.Fill(ds, "turno_nombre")

            If ds.Tables("turno_nombre").Rows.Count > 0 Then
                MsgBox("Nombre de turno ya existente, debe ingresar un nombre distinto")
                controlnombre = 1
            End If
            cx.Close()
        End If





        'controla no tengo datos asociados al momento de eliminar


        If (accion = acciones.eliminar) Then
            Dim cx As New Odbc.OdbcConnection
            Dim cm As New Odbc.OdbcCommand
            Dim da As New Odbc.OdbcDataAdapter
            Dim ds As New Data.DataSet

            cx.ConnectionString = "FileDSN=c:\itechplus_sec.dsn;UID=techplus_sec;pwd=1234"
            cx.Open()
            cm.Connection = cx
            cm.CommandText = "SELECT * FROM se_divide where id_turno =" + txtcod.Text
            cm.ExecuteNonQuery()
            da.SelectCommand = cm
            da.Fill(ds, "turno")

            If ds.Tables("turno").Rows.Count > 0 Then
                MsgBox("Existen datos asociados a este Turno. Debe eliminar las horas correspondientes al turno para luego eliminar el turno")
                control = 1
            End If
            cx.Close()
        End If







        'Ingreso de turno    
        If accion = acciones.ingresar Then
            Dim sql As String = ""
            Dim cx As New Odbc.OdbcConnection
            Dim cm As New Odbc.OdbcCommand

            If (txtcod.Text <> "" And txtnombre.Text <> "" And control <> 1 And controlnombre <> 1 And controlturno <> 1) Then
                sql = "INSERT INTO turno VALUES (" + txtcod.Text + ",'"
                sql += txtnombre.Text + "')"

                cx.ConnectionString = "FileDSN=c:\itechplus_sec.dsn;UID=techplus_sec;pwd=1234"
                cx.Open()
                cm.Connection = cx
                cm.CommandText = sql
                cm.ExecuteNonQuery()
                MsgBox("Turno ingresado exitosamente")
                control = 0
                cx.Close()
                abmturnos.Show()
                Me.Close()

            End If
        End If
        'Modificación de turnos

        If (accion = acciones.modificar) Then
            If (txtcod.Text <> "" And txtnombre.Text <> "" And control <> 1) Then

                Dim sql As String = ""
                Dim cx As New Odbc.OdbcConnection
                Dim cm As New Odbc.OdbcCommand

                sql = "UPDATE se_divide SET "
                sql += "id_turno= " + txtcod.Text
                sql += " where se_divide.id_turno = " + unturno.id_turno.ToString


                cx.ConnectionString = "FileDSN=c:\itechplus_sec.dsn;UID=techplus_sec;pwd=1234"
                cx.Open()
                cm.Connection = cx
                cm.CommandText = sql
                cm.ExecuteNonQuery()

                sql = "UPDATE turno SET "
                sql += "id_turno = " + txtcod.Text + " ,"
                sql += "nombre_turno='" + txtnombre.Text + "'"
                sql += " WHERE id_turno = " + unturno.id_turno.ToString
                MsgBox("Turno modificado exitosamente")

                cm.Connection = cx
                cm.CommandText = sql
                cm.ExecuteNonQuery()
                cx.Close()
                abmturnos.Show()
                Me.Close()
                control = 0

            End If
        End If
        ' eliminación de turno
        If (accion = acciones.eliminar) Then

            If (control <> 1) Then
                Dim sql As String = ""
                Dim cx As New Odbc.OdbcConnection
                Dim cm As New Odbc.OdbcCommand

                Select Case MsgBox("Está seguro de eliminar el turno " + txtcod.Text + "?", MsgBoxStyle.YesNo)
                    Case MsgBoxResult.Yes
                        sql = "DELETE FROM turno WHERE id_turno= " + txtcod.Text
                        cx.ConnectionString = "FileDSN=c:\itechplus_sec.dsn;UID=techplus_sec;pwd=1234"
                        cx.Open()
                        cm.Connection = cx
                        cm.CommandText = sql
                        cm.ExecuteNonQuery()
                        MsgBox("Turno eliminado exitosamente")
                        cx.Close()
                        abmturnos.Show()
                        Me.Close()

                    Case MsgBoxResult.No
                        abmturnos.Show()
                        Me.Close()
                End Select
            End If
        End If
    End Sub

    Private Sub txtcod_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtcod.KeyPress
        If (e.KeyChar < "0" Or e.KeyChar > "9") And e.KeyChar <> Chr(Keys.Back) Then
            e.KeyChar = ""
        End If
    End Sub

    Private Sub txtcod_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtcod.TextChanged
        
    End Sub

    Private Sub txtnombre_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtnombre.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtnombre_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtnombre.TextChanged

    End Sub

    Private Sub altaturno_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


        Select Case accion
            Case acciones.ingresar
                btnaceptar.Text = "Ingresar"
                lbltitulo.Text = "INGRESO DE TURNO"
            Case acciones.modificar
                txtcod.Enabled = False
                btnaceptar.Text = "Modificar"
                lbltitulo.Text = "MODIFICACIÓN DE TURNO"


                With unturno
                    txtcod.Text = .id_turno
                    txtnombre.Text = .nom_turno
                   
                End With
            Case acciones.eliminar
                btnaceptar.Text = "Eliminar"
                lbltitulo.Text = "BAJA DE TURNO"


                With unturno
                    txtcod.Text = .id_turno
                    txtnombre.Text = .nom_turno
                End With
                txtnombre.Enabled = False
                txtcod.Enabled = False
        End Select
    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnmenu.Click
        txtcod.Clear()
        txtnombre.Clear()
        abmturnos.Show()
        Me.Close()

    End Sub
End Class