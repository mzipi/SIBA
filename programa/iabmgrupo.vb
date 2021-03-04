Public Class iabmgrupo

    Private Sub lbltitulo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbltitulo.Click

    End Sub

    Private Sub btnalta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnalta.Click
        accion = acciones.ingresar
        ialtagrupo.Show()
        Me.Close()
    End Sub

    Private Sub btnmod_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnmod.Click
        accion = acciones.modificar
        If (dgvgrupos.SelectedRows.Count = 0) Then
            MsgBox("Choose a row to the list and then press Modify")
        Else

            With dgvgrupos.SelectedRows.Item(0)
                ungrupo.idg = .Cells(0).Value
                ungrupo.anio = .Cells(1).Value
                ungrupo.curso = .Cells(2).Value
                ungrupo.letra = .Cells(3).Value
                ungrupo.id_turno = .Cells(4).Value
                ungrupo.nombre_carr = .Cells(5).Value


            End With
            ialtagrupo.Show()
            Me.Close()

        End If


    End Sub

    Private Sub btnbaja_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnbaja.Click
        accion = acciones.eliminar
        If (dgvgrupos.SelectedRows.Count = 0) Then
            MsgBox("Choose a row to remove the list and then press Delete")
        Else

            With dgvgrupos.SelectedRows.Item(0)
                ungrupo.idg = .Cells(0).Value
                ungrupo.anio = .Cells(1).Value
                ungrupo.curso = .Cells(2).Value
                ungrupo.letra = .Cells(3).Value
                ungrupo.id_turno = .Cells(4).Value
                ungrupo.nombre_carr = .Cells(5).Value


            End With
            ialtagrupo.Show()
            Me.Close()

        End If
    End Sub

    Private Sub btnclose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclose.Click
        Select Case MsgBox("Do you want close this session?", MsgBoxStyle.YesNo)
            Case MsgBoxResult.Yes
                login.txtusuario.Clear()
                login.txtpass.Clear()
                login.Show()
                Me.Hide()
            Case MsgBoxResult.No
                Me.Hide()
                Me.Show()
        End Select
    End Sub

    Private Sub btnatras_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnatras.Click
        iabmcarr.Show()
        Me.Hide()
    End Sub

    Private Sub iabmgrupo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim cx As New Odbc.OdbcConnection
        Dim cm As New Odbc.OdbcCommand
        Dim da As New Odbc.OdbcDataAdapter
        Dim ds As New Data.DataSet

        cx.ConnectionString = "FileDSN=c:\itechplus_sec.dsn;UID=techplus_sec;pwd=1234"
        cx.Open()
        cm.Connection = cx
        cm.CommandText = "SELECT * FROM grupos"
        cm.ExecuteNonQuery()
        da.SelectCommand = cm
        da.Fill(ds, "grupos")
        dgvgrupos.DataSource = ds.Tables("grupos")

        If (dgvgrupos.Rows.Count > 1) Then
            dgvgrupos.CurrentRow.Selected = False

        End If

        dgvgrupos.RowHeadersVisible = False


        dgvgrupos.Columns(0).HeaderText = "Group Code"
        dgvgrupos.Columns(1).HeaderText = "Year"
        dgvgrupos.Columns(2).HeaderText = "Course"
        dgvgrupos.Columns(3).HeaderText = "Letter"
        dgvgrupos.Columns(4).HeaderText = "Turn Code"
        dgvgrupos.Columns(5).HeaderText = "Career"
    End Sub

    Private Sub dgvgrupos_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvgrupos.CellContentClick

    End Sub
End Class