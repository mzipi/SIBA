Public Class abmbajasdoc

    Private Sub btnbaja_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnbaja.Click
        accion = acciones.modificar
        If (dgvhrsvac.SelectedRows.Count = 0) Then
            MsgBox("Para modificar seleccione una fila de la lista y luego presione modificar")
        Else

            With dgvhrsvac.SelectedRows.Item(0)
                bajadoc.ci = .Cells(0).Value
                bajadoc.nombre_docente = .Cells(1).Value
                bajadoc.cod_materia = .Cells(4).Value
                bajadoc.idg = .Cells(3).Value
                bajadoc.estado_funcional = .Cells(7).Value
                bajadoc.estado = .Cells(6).Value
                bajadoc.grupo = .Cells(8).Value
                bajadoc.nombre_mat = .Cells(2).Value




            





            End With
            altaDocente.Show()
            Me.Close()

        End If



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

    Private Sub btnalta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnbaja.Click
        bajasdocentes.Show()
        Me.Close()

    End Sub

    Private Sub btnatras_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnatras.Click
        menupadm.Show()
        Me.Hide()

    End Sub

    Private Sub abmhrsvacantes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim cx As New Odbc.OdbcConnection
        Dim cm As New Odbc.OdbcCommand
        Dim da As New Odbc.OdbcDataAdapter
        Dim ds As New Data.DataSet

        cx.ConnectionString = "FileDSN=c:\itechplus_adm.dsn;UID=techplus_adm;pwd=1234"
        cx.Open()
        cm.Connection = cx
        cm.CommandText = "select docentes.ci, nombre_completo,nombre_mat,grupos.idg,materias.cod_materia, fecha,estado,estado_funcional,anio||curso||letra  from docentes, asignados, materias,grupos where docentes.ci= asignados.ci and asignados.idg=grupos.idg and materias.cod_materia = asignados.cod_materia"

        cm.ExecuteNonQuery()
        da.SelectCommand = cm
        da.Fill(ds, "docentes")
        dgvhrsvac.DataSource = ds.Tables("docentes")

        If (dgvhrsvac.Rows.Count > 1) Then
            dgvhrsvac.CurrentRow.Selected = False

        End If

        dgvhrsvac.RowHeadersVisible = False

        dgvhrsvac.Columns("Código").Visible = False
        dgvhrsvac.Columns("Código Mat").Visible = False
        dgvhrsvac.Columns("Ci").Visible = False
        dgvhrsvac.Columns("Fecha").Visible = False
        dgvhrsvac.Columns(0).HeaderText = "Cédula Id."
        dgvhrsvac.Columns(1).HeaderText = "Nombre Docente"
        dgvhrsvac.Columns(2).HeaderText = "Materia "
        dgvhrsvac.Columns(3).HeaderText = "Código"
        dgvhrsvac.Columns(4).HeaderText = "Código Mat"
        dgvhrsvac.Columns(5).HeaderText = "Fecha"

        dgvhrsvac.Columns(6).HeaderText = "Estado"
        dgvhrsvac.Columns(7).HeaderText = "Estado Funcional"
        dgvhrsvac.Columns(8).HeaderText = "Grupo"

    End Sub


End Class