Public Class abmGrupo

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnalta.Click
        accion = acciones.ingresar
        altagrupo.Show()
        Me.Close()
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnmod.Click
        accion = acciones.modificar
        If (dgvgrupos.SelectedRows.Count = 0) Then
            MsgBox("Para modificar seleccione una fila de la lista y luego presione modificar")
        Else

            With dgvgrupos.SelectedRows.Item(0)
                ungrupo.idg = .Cells(0).Value
                ungrupo.anio = .Cells(1).Value
                ungrupo.curso = .Cells(2).Value
                ungrupo.letra = .Cells(3).Value
                ungrupo.id_turno = .Cells(4).Value
                ungrupo.nombre_carr = .Cells(5).Value
                

            End With
            altagrupo.Show()
            Me.Close()

        End If


    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnbaja.Click
        accion = acciones.eliminar
        If (dgvgrupos.SelectedRows.Count = 0) Then
            MsgBox("Para eliminar seleccione una fila de la lista y luego presione modificar")
        Else

            With dgvgrupos.SelectedRows.Item(0)
                ungrupo.idg = .Cells(0).Value
                ungrupo.anio = .Cells(1).Value
                ungrupo.curso = .Cells(2).Value
                ungrupo.letra = .Cells(3).Value
                ungrupo.id_turno = .Cells(4).Value
                ungrupo.nombre_carr = .Cells(5).Value


            End With
            altagrupo.Show()
            Me.Close()

        End If

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnatras.Click
        abmcarreras.Show()
        Me.Hide()
    End Sub

    Private Sub btnclose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclose.Click
        Select Case MsgBox("Desea cerrar sesión?", MsgBoxStyle.YesNo)
            Case MsgBoxResult.Yes
                login.txtusuario.clear()
                login.txtpass.clear()
                login.Show()
                Me.Hide()
            Case MsgBoxResult.No
                Me.Hide()
                Me.Show()
        End Select
    End Sub

    Private Sub abmGrupo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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


        dgvgrupos.Columns(0).HeaderText = "Código Grupo"
        dgvgrupos.Columns(1).HeaderText = "Año"
        dgvgrupos.Columns(2).HeaderText = "Curso"
        dgvgrupos.Columns(3).HeaderText = "Letra"
        dgvgrupos.Columns(4).HeaderText = "Código Turno"
        dgvgrupos.Columns(5).HeaderText = "Carrera"

    End Sub

    Private Sub dgvgrupos_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvgrupos.CellContentClick

    End Sub
End Class