
Public Class abmhoras

    Private Sub Form37_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim cx As New Odbc.OdbcConnection
        Dim cm As New Odbc.OdbcCommand
        Dim da As New Odbc.OdbcDataAdapter
        Dim ds As New Data.DataSet

        cx.ConnectionString = "FileDSN=c:\itechplus_sec.dsn;UID=techplus_sec;pwd=1234"
        cx.Open()
        cm.Connection = cx
        cm.CommandText = "SELECT * from horas, turno, se_divide where horas.id_horas=se_divide.id_horas and turno.id_turno= se_divide.id_turno"
        cm.ExecuteNonQuery()
        da.SelectCommand = cm
        da.Fill(ds, "horas")
        dgvhoras.DataSource = ds.Tables("horas")

        dgvhoras.DataSource = ds.Tables("horas")
        If (dgvhoras.Rows.Count > 1) Then
            dgvhoras.CurrentRow.Selected = False

        End If

        dgvhoras.RowHeadersVisible = False
        dgvhoras.Columns(4).DefaultCellStyle.Format = "HH:mm"
        dgvhoras.Columns(3).DefaultCellStyle.Format = "HH:mm"
        dgvhoras.Columns(0).HeaderText = "ID_HORAS"
        dgvhoras.Columns(1).HeaderText = "NÚMERO DE HORA"
        dgvhoras.Columns(2).HeaderText = "DÍA"
        dgvhoras.Columns(3).HeaderText = "INICIO"
        dgvhoras.Columns(4).HeaderText = "FIN"
        dgvhoras.Columns(6).HeaderText = "TURNO"

        dgvhoras.Columns("id_turno1").Visible = False
        dgvhoras.Columns("id_horas1").Visible = False
        dgvhoras.Columns("id_turno").Visible = False
        dgvhoras.Columns("ID_HORAS").Visible = False


    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnalta.Click
        accion = acciones.ingresar
        altahoras.Show()
        Me.Close()

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnmod.Click
        accion = acciones.modificar
        If (dgvhoras.SelectedRows.Count = 0) Then
            MsgBox("Debe seleccionar un dato para modificar")
        Else
            With dgvhoras.SelectedRows.Item(0)
                unahora.id_horas = .Cells(0).Value
                unahora.num_horas = .Cells(1).Value
                unahora.dia = .Cells(2).Value
                unahora.inicio = Format(.Cells(3).Value, "HH:mm")
                unahora.fin = Format(.Cells(4).Value, "HH:mm")
                unahora.nombre_turno = .Cells(6).Value
                unahora.id_turno = .Cells(5).Value
            End With
            altahoras.Show()
            Me.Close()

        End If
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnbaja.Click
        accion = acciones.eliminar
        If (dgvhoras.SelectedRows.Count = 0) Then
            MsgBox("Debe seleccionar un dato para eliminar")
        Else
            With (dgvhoras.SelectedRows.Item(0))
                unahora.id_horas = .Cells(0).Value
                unahora.num_horas = .Cells(1).Value
                unahora.dia = .Cells(2).Value
                unahora.inicio = .Cells(3).Value
                unahora.fin = .Cells(4).Value
                unahora.nombre_turno = .Cells(6).Value

            End With
            altahoras.Show()
            Me.Close()
        End If

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bnbaja.Click
        abmturnos.Show()
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
End Class