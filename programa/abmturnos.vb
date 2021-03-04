Public Class abmturnos

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnalta.Click
        accion = acciones.ingresar
        If (dgvturnos.RowCount = 1) Then
            MsgBox("Se ingresara el primer turno")
        End If
        altaturno.Show()
        Me.Close()

    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnbaja.Click
        accion = acciones.eliminar
        If (dgvturnos.SelectedRows.Count = 0) Then
            MsgBox("Debe seleccionar un dato para eliminar")
        Else
            With dgvturnos.SelectedRows.Item(0)
                unturno.id_turno = .Cells(0).Value
                unturno.nom_turno = .Cells(1).Value
            End With
            altaturno.Show()
            Me.Close()

        End If

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnmod.Click
        accion = acciones.modificar
        If (dgvturnos.SelectedRows.Count = 0) Then
            MsgBox("Debe seleccionar un dato para modificar")
        Else
            With dgvturnos.SelectedRows.Item(0)
                unturno.id_turno = .Cells(0).Value
                unturno.nom_turno = .Cells(1).Value
            End With
            altaturno.Show()
            Me.Close()

        End If
        
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnatras.Click
        menupse.Show()
        Me.Hide()

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndefhoras.Click
        abmhoras.Show()
        Me.Close()


    End Sub

    Private Sub btnclose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclose.Click
        Select Case MsgBox("Desea cerrar sesión?", MsgBoxStyle.YesNo)
            Case MsgBoxResult.Yes

                login.txtusuario.clear()
                login.txtpass.clear()
                login.Show()
                Me.Close()
            Case MsgBoxResult.No
                Me.Hide()
                Me.Show()
        End Select
    End Sub

    Private Sub abmturnos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dgvturnos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

        Dim cx As New Odbc.OdbcConnection
        Dim cm As New Odbc.OdbcCommand
        Dim da As New Odbc.OdbcDataAdapter
        Dim ds As New Data.DataSet
        cx.ConnectionString = "FileDSN=c:\itechplus_sec.dsn;UID=techplus_sec;pwd=1234"
        cx.Open()
        cm.Connection = cx
        cm.CommandText = "SELECT * FROM turno"
        cm.ExecuteNonQuery()
        da.SelectCommand = cm
        da.Fill(ds, "turno")

        dgvturnos.DataSource = ds.Tables("turno")
        If (dgvturnos.Rows.Count > 1) Then
            dgvturnos.CurrentRow.Selected = False

        End If

        dgvturnos.RowHeadersVisible = False
        dgvturnos.Columns(1).HeaderText = "Nombre de Turno"
        dgvturnos.Columns(0).HeaderText = "Código Turno"

        cx.Close()
    End Sub

    Private Sub dgvturnos_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvturnos.CellContentClick

    End Sub
End Class