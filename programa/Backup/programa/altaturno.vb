Public Class altaturno

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnatras.Click
        txtcod.Clear()
        txtnombre.Clear()
        abmturnos.Show()
        Me.Close()


    End Sub

    Private Sub btnclose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclose.Click
        Select Case MsgBox("Desea cerrar sesión?", MsgBoxStyle.YesNo)
            Case MsgBoxResult.Yes
                txtcod.Clear()
                txtnombre.Clear()
                login.cmbnomu.SelectedIndex = 0

                login.cmbpass.SelectedIndex = 0
                login.Show()
                Me.Close()
            Case MsgBoxResult.No
                Me.Hide()
                Me.Show()
        End Select
    End Sub

    Private Sub btningresar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnaceptar.Click
        If (txtcod.Text = "") Then
            MsgBox("Debe ingresar un código para el turno")
        End If
        If (txtnombre.Text = "") Then
            MsgBox("Debe ingresar un nombre para el turno")
        End If
        If (txtcod.Text <> "" And txtnombre.Text <> "") Then

            Dim sql As String = ""
            Dim cx As New Odbc.OdbcConnection
            Dim cm As New Odbc.OdbcCommand


            Select Case accion
                Case acciones.ingresar
                    sql = "INSERT INTO turno VALUES (" + txtcod.Text + ",'"
                    sql += txtnombre.Text + "')"

                    MsgBox("Turno ingresado exitosamente")
                Case acciones.modificar
                    sql = "UPDATE turno SET "
                    sql += "id_turno = " + txtcod.Text + " ,"
                    sql += "nombre_turno='" + txtnombre.Text + "'"
                    sql += " WHERE id_turno = " + unturno.id_turno.ToString
                    MsgBox("Turno modificado exitosamente")
                Case acciones.eliminar
                    sql = "DELETE FROM carreras WHERE id_turno= " + txtcod.Text
                    MsgBox("Turno eliminado exitosamente")
            End Select
            cx.ConnectionString = "FileDsn=c:\sibapro.dsn;UID=developer;PWD=developer"
            cx.Open()
            cm.Connection = cx
            cm.CommandText = sql
            cm.ExecuteNonQuery()
            abmturnos.Show()
            Me.Close()
            
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
End Class