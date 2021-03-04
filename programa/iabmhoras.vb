Public Class iabmhoras

    Private Sub iambhoras_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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
        dgvhoras.Columns(1).HeaderText = "NUMBER OF HOUR"
        dgvhoras.Columns(2).HeaderText = "DAY"
        dgvhoras.Columns(3).HeaderText = "START"
        dgvhoras.Columns(4).HeaderText = "END"
        dgvhoras.Columns(6).HeaderText = "TURN"

        dgvhoras.Columns("id_turno1").Visible = False
        dgvhoras.Columns("id_horas1").Visible = False
        dgvhoras.Columns("id_turno").Visible = False
        dgvhoras.Columns("ID_HORAS").Visible = False


    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnalta.Click
        accion = acciones.ingresar
        ialtahoras.Show()
        Me.Close()

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnmod.Click
        accion = acciones.modificar
        If (dgvhoras.SelectedRows.Count = 0) Then
            MsgBox("You must enter data to modify")
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
            ialtahoras.Show()
            Me.Close()

        End If
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnbaja.Click
        accion = acciones.eliminar
        If (dgvhoras.SelectedRows.Count = 0) Then
            MsgBox("Choose a row to remove the list and then press Delete")

        Else
            With (dgvhoras.SelectedRows.Item(0))
                unahora.id_horas = .Cells(0).Value
                unahora.num_horas = .Cells(1).Value
                unahora.dia = .Cells(2).Value
                unahora.inicio = .Cells(3).Value
                unahora.fin = .Cells(4).Value
                unahora.nombre_turno = .Cells(6).Value

            End With
            ialtahoras.Show()
            Me.Close()
        End If

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bnbaja.Click
        iabmturnos.Show()
        Me.Close()
    End Sub

    Private Sub btnclose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclose.Click
        Select Case MsgBox("Do you want close this session?", MsgBoxStyle.YesNo)
            Case MsgBoxResult.Yes

                login.txtusuario.Clear()
                login.txtpass.Clear()
                login.Show()
                Me.Close()
            Case MsgBoxResult.No
                Me.Hide()
                Me.Show()
        End Select
    End Sub
End Class
  