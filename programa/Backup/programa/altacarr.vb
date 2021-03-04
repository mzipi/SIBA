Public Class altaCarrera

    Private Sub Label6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbltitulo.Click

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnatras.Click
        txtnombre.Clear()
        cmbdur.SelectedIndex = 0

        abmcarreras.Show()
        Me.Close()

    End Sub

    Private Sub altaCarrera_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Select Case accion
            Case acciones.ingresar
                btnaceptar.Text = "Ingresar"
                lbltitulo.Text = "INGRESO DE CARRERA"

            Case acciones.modificar
                btnaceptar.Text = "Modificar"
                lbltitulo.Text = "MODIFICACIÓN DE CARRERA"


                With unacarrera
                    txtnombre.Text = .nombre_carr
                    cmbdur.SelectedItem = .duracion
                End With
            Case acciones.eliminar
                btnaceptar.Text = "Eliminar"
                lbltitulo.Text = "BAJA DE CARRERA"


                With unacarrera
                    txtnombre.Text = .nombre_carr
                    cmbdur.SelectedItem = .duracion
                End With
                txtnombre.Enabled = False
                cmbdur.Enabled = False
        End Select
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnaceptar.Click
        If (txtnombre.Text = "") Then
            MsgBox("Debe ingresar un nombre de carrera")
        End If
        If (cmbdur.SelectedIndex = 0) Then
            MsgBox("Debe seleccionar una duración")
        End If
        If (txtnombre.Text <> "" And cmbdur.SelectedIndex <> 0) Then

            Dim sql As String = ""
            Dim cx As New Odbc.OdbcConnection
            Dim cm As New Odbc.OdbcCommand


            Select Case accion
                Case acciones.ingresar
                    sql = "INSERT INTO carreras VALUES ('" + txtnombre.Text + "',"
                    sql += cmbdur.SelectedItem + ")"

                    MsgBox("Carrera ingresada exitosamente")
                Case acciones.modificar
                    sql = "UPDATE carreras SET "
                    sql += "nombre_carr = '" + txtnombre.Text + " ',"
                    sql += "duracion=" + cmbdur.SelectedItem + ""
                    sql += " WHERE nombre_carr = '" + unacarrera.nombre_carr.ToString + "'"
                    MsgBox("Carrera modificada exitosamente")
                Case acciones.eliminar
                    sql = "DELETE FROM carreras WHERE nombre_carr= '" + txtnombre.Text + "'"
                    MsgBox("Carrera eliminada exitosamente")
            End Select
            cx.ConnectionString = "FileDsn=c:\sibapro.dsn;UID=developer;PWD=developer"
            cx.Open()
            cm.Connection = cx
            cm.CommandText = sql
            cm.ExecuteNonQuery()
            abmcarreras.Show()
            Me.Close()


        End If
    End Sub

    Private Sub btnclose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclose.Click
        Select Case MsgBox("Desea cerrar sesión?", MsgBoxStyle.YesNo)
            Case MsgBoxResult.Yes
                txtnombre.Clear()
                cmbdur.SelectedIndex = 0

                login.cmbnomu.SelectedIndex = 0
                login.cmbpass.SelectedIndex = 0
                login.Show()
                Me.Hide()
            Case MsgBoxResult.No
                Me.Hide()
                Me.Show()
        End Select
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

    Private Sub cmbdur_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbdur.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
        If (e.KeyChar < "0" Or e.KeyChar > "9") And e.KeyChar <> Chr(Keys.Back) Then
            e.KeyChar = ""
        End If
    End Sub

    Private Sub cmbdur_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbdur.SelectedIndexChanged

    End Sub
End Class