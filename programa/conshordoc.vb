Public Class conshordoc

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Form8_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtci.Visible = False
        dgvhordoc.Visible = False


        Dim cx As New Odbc.OdbcConnection
        Dim cm As New Odbc.OdbcCommand
        Dim da As New Odbc.OdbcDataAdapter
        Dim ds As New DataSet
        Dim dr As Odbc.OdbcDataReader
        cx.ConnectionString = "FileDSN=c:\itechplus_doc.dsn;UID=techplus_doc;pwd=1234"
        cx.Open()

        cm.CommandText = "SELECT nombre_completo from docentes"
        cm.Connection = cx

        dr = cm.ExecuteReader
        cmbdocente.Items.Add("(Seleccione)")
        While dr.Read
            cmbdocente.Items.Add(dr.GetString(0))
        End While
        cmbdocente.SelectedIndex = 0
        dr.Close()
        cx.Close()

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblcons.Click

        'consulta usuario tipo docente 
        If (lbltipou.Text = "Docente") Then


            Dim cx As New Odbc.OdbcConnection
            Dim cm As New Odbc.OdbcCommand
            Dim lector As Odbc.OdbcDataReader

            cx.ConnectionString = "FileDSN=c:\itechplus_doc.dsn;UID=techplus_doc;pwd=1234"
            cx.Open()
            cm.CommandText = "SELECT ci from docentes where nombre_completo ='" + cmbdocente.SelectedItem + "'"
            cm.Connection = cx
            lector = cm.ExecuteReader()
            If lector.HasRows Then
                txtci.Text = lector.GetString(0)

                cx.Close()
            End If


            If (cmbtipo.SelectedIndex >= 2 And cmbdocente.SelectedIndex <> 0) Then
                Dim cx2 As New Odbc.OdbcConnection
                Dim cm2 As New Odbc.OdbcCommand
                Dim da As New Odbc.OdbcDataAdapter
                Dim ds As New Data.DataSet

                cx2.ConnectionString = "FileDSN=c:\itechplus_doc.dsn;UID=techplus_doc;pwd=1234"
                cx2.Open()
                cm2.Connection = cx2
                cm2.CommandText = "select d.nombre_completo,m.nombre_mat,h.dia,h.inicio||' ' ||h.fin, g.anio||g.curso||g.letra from docentes d, grupos g, asignados a, horas h, materias m,asigna aa, turno t where a.ci=d.ci and a.idg=g.idg and a.idg=aa.idg and a.cod_materia =aa.cod_materia and aa.id_horas=h.id_horas and a.cod_materia=m.cod_materia and d.ci=" + txtci.Text + " and t.nombre_turno='" + cmbtipo.SelectedItem + "'" + " and g.id_turno=t.id_turno"
                cm2.ExecuteNonQuery()
                da.SelectCommand = cm2
                da.Fill(ds, "horasdoc")
                dgvhordoc.DataSource = ds.Tables("horasdoc")

                If (dgvhordoc.Rows.Count > 1) Then
                    dgvhordoc.CurrentRow.Selected = False

                End If
                dgvhordoc.RowHeadersVisible = False
                dgvhordoc.Columns(3).DefaultCellStyle.Format = ("HH:mm")

                dgvhordoc.Columns(0).HeaderText = "Nombre Docente"
                dgvhordoc.Columns(1).HeaderText = "Materia"
                dgvhordoc.Columns(2).HeaderText = "Día"
                dgvhordoc.Columns(3).HeaderText = "Inicio-Fin"
                dgvhordoc.Columns(4).HeaderText = "Grupo"

                gbxhordoc.Visible = False
                dgvhordoc.Visible = True
                dgvhordoc.SetBounds(9, 55, 500, 270)
                cx2.Close()

            End If


            If (cmbtipo.SelectedIndex = 1 And cmbdocente.SelectedIndex <> 0) Then

                Dim cx5 As New Odbc.OdbcConnection
                Dim cm5 As New Odbc.OdbcCommand
                Dim da5 As New Odbc.OdbcDataAdapter
                Dim ds5 As New Data.DataSet

                cx5.ConnectionString = "FileDSN=c:\itechplus_doc.dsn;UID=techplus_doc;pwd=1234"
                cx5.Open()
                cm5.Connection = cx5
                cm5.CommandText = "select nombre_completo,  nombre_mat,dia, inicio||' '||fin, anio||curso||letra from docentes,asignados,materias, horas,asigna,grupos where docentes.ci = asignados.ci And materias.cod_materia = asignados.cod_materia and horas.id_horas=asigna.id_horas and asignados.idg=asigna.idg and materias.cod_materia=asigna.cod_materia and asigna.idg=grupos.idg and grupos.idg=asignados.idg and docentes.ci=" + txtci.Text

                cm5.ExecuteNonQuery()
                da5.SelectCommand = cm5
                da5.Fill(ds5, "horasdoc")
                dgvhordoc.DataSource = ds5.Tables("horasdoc")

                If (dgvhordoc.Rows.Count > 1) Then
                    dgvhordoc.CurrentRow.Selected = False

                End If

                dgvhordoc.RowHeadersVisible = False
                dgvhordoc.Columns(3).DefaultCellStyle.Format = ("HH:mm")

                dgvhordoc.Columns(0).HeaderText = "Nombre Docente"
                dgvhordoc.Columns(1).HeaderText = "Materia"
                dgvhordoc.Columns(2).HeaderText = "Día"
                dgvhordoc.Columns(3).HeaderText = "Inicio-Fin"
                dgvhordoc.Columns(4).HeaderText = "Grupo"

                gbxhordoc.Visible = False
                dgvhordoc.Visible = True
                dgvhordoc.SetBounds(9, 55, 500, 270)
                cx5.Close()

            End If

        End If
        '''''''''''''''''''''''
        'consulta usuario tipo 
        If (lbltipou.Text = "Secretario Escolar") Then


            Dim cx As New Odbc.OdbcConnection
            Dim cm As New Odbc.OdbcCommand
            Dim lector As Odbc.OdbcDataReader

            cx.ConnectionString = "FileDSN=c:\itechplus_doc.dsn;UID=techplus_doc;pwd=1234"
            cx.Open()
            cm.CommandText = "SELECT ci from docentes where nombre_completo ='" + cmbdocente.SelectedItem + "'"
            cm.Connection = cx
            lector = cm.ExecuteReader()
            If lector.HasRows Then
                txtci.Text = lector.GetString(0)

                cx.Close()
            End If


            If (cmbtipo.SelectedIndex >= 2 And cmbdocente.SelectedIndex <> 0) Then
                Dim cx2 As New Odbc.OdbcConnection
                Dim cm2 As New Odbc.OdbcCommand
                Dim da As New Odbc.OdbcDataAdapter
                Dim ds As New Data.DataSet

                cx2.ConnectionString = "FileDsn=C:\FileDSN=c:\itechplus_doc.dsn;UID=techplus_doc;pwd=1234"
                cx2.Open()
                cm2.Connection = cx2
                cm2.CommandText = "select d.nombre_completo,m.nombre_mat,h.dia,h.inicio||' ' ||h.fin, g.anio||g.curso||g.letra from docentes d, grupos g, asignados a, horas h, materias m,asigna aa, turno t where a.ci=d.ci and a.idg=g.idg and a.idg=aa.idg and a.cod_materia =aa.cod_materia and aa.id_horas=h.id_horas and a.cod_materia=m.cod_materia and d.ci=" + txtci.Text + " and t.nombre_turno='" + cmbtipo.SelectedItem + "'" + " and g.id_turno=t.id_turno"
                cm2.ExecuteNonQuery()
                da.SelectCommand = cm2
                da.Fill(ds, "horasdoc")
                dgvhordoc.DataSource = ds.Tables("horasdoc")

                If (dgvhordoc.Rows.Count > 1) Then
                    dgvhordoc.CurrentRow.Selected = False

                End If
                dgvhordoc.RowHeadersVisible = False
                dgvhordoc.Columns(3).DefaultCellStyle.Format = ("HH:mm")

                dgvhordoc.Columns(0).HeaderText = "Nombre Docente"
                dgvhordoc.Columns(1).HeaderText = "Materia"
                dgvhordoc.Columns(2).HeaderText = "Día"
                dgvhordoc.Columns(3).HeaderText = "Inicio-Fin"
                dgvhordoc.Columns(4).HeaderText = "Grupo"

                gbxhordoc.Visible = False
                dgvhordoc.Visible = True
                dgvhordoc.SetBounds(9, 55, 500, 270)
                cx2.Close()

            End If


            If (cmbtipo.SelectedIndex = 1 And cmbdocente.SelectedIndex <> 0) Then

                Dim cx5 As New Odbc.OdbcConnection
                Dim cm5 As New Odbc.OdbcCommand
                Dim da5 As New Odbc.OdbcDataAdapter
                Dim ds5 As New Data.DataSet

                cx5.ConnectionString = "FileDSN=c:\itechplus_doc.dsn;UID=techplus_doc;pwd=1234"
                cx5.Open()
                cm5.Connection = cx5
                cm5.CommandText = "select nombre_completo,  nombre_mat,dia, inicio||' '||fin, anio||curso||letra from docentes,asignados,materias, horas,asigna,grupos where docentes.ci = asignados.ci And materias.cod_materia = asignados.cod_materia and horas.id_horas=asigna.id_horas and asignados.idg=asigna.idg and materias.cod_materia=asigna.cod_materia and asigna.idg=grupos.idg and grupos.idg=asignados.idg and docentes.ci=" + txtci.Text

                cm5.ExecuteNonQuery()
                da5.SelectCommand = cm5
                da5.Fill(ds5, "horasdoc")
                dgvhordoc.DataSource = ds5.Tables("horasdoc")

                If (dgvhordoc.Rows.Count > 1) Then
                    dgvhordoc.CurrentRow.Selected = False

                End If

                dgvhordoc.RowHeadersVisible = False
                dgvhordoc.Columns(3).DefaultCellStyle.Format = ("HH:mm")

                dgvhordoc.Columns(0).HeaderText = "Nombre Docente"
                dgvhordoc.Columns(1).HeaderText = "Materia"
                dgvhordoc.Columns(2).HeaderText = "Día"
                dgvhordoc.Columns(3).HeaderText = "Inicio-Fin"
                dgvhordoc.Columns(4).HeaderText = "Grupo"

                gbxhordoc.Visible = False
                dgvhordoc.Visible = True
                dgvhordoc.SetBounds(9, 55, 500, 270)
                cx5.Close()

            End If

        End If

    End Sub

    Private Sub FlowLayoutPanel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs)

    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        
    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnatras.Click

        If (lbltipou.Text = "Docente") Then
            cmbtipo.SelectedIndex = 0
            cmbdocente.SelectedIndex = 0
            txtci.Clear()
            menupdoc.Show()
            Me.Hide()
        End If
        If (lbltipou.Text = "Secretario Escolar") Then
            cmbtipo.SelectedIndex = 0
            cmbdocente.SelectedIndex = 0
            txtci.Clear()
            menureportse.Show()
            Me.Hide()
        End If

    End Sub

    Private Sub Button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btbclose.Click
        Select Case MsgBox("Desea cerrar sesión?", MsgBoxStyle.YesNo)
            Case MsgBoxResult.Yes
                cmbtipo.SelectedIndex = 0
                cmbdocente.SelectedIndex = 0
                txtci.Clear()
                login.txtpass.clear()
                login.txtusuario.clear()
                login.Show()
                Me.Hide()
            Case MsgBoxResult.No
                Me.Hide()
                Me.Show()
        End Select
    End Sub

    Private Sub cmbtipo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
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

    Private Sub cmbdocente_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbdocente.KeyPress
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

    Private Sub cmbdocente_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbdocente.SelectedIndexChanged

    End Sub

    Private Sub Button2_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncons.Click
        dgvhordoc.Visible = False
        gbxhordoc.Visible = True
        txtci.Clear()
        cmbtipo.SelectedIndex = 0
        cmbdocente.SelectedIndex = 0

    End Sub

    Private Sub btnmenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnmenu.Click
        dgvhordoc.Visible = False
        gbxhordoc.Visible = True
        txtci.Clear()
        cmbtipo.SelectedIndex = 0
        cmbdocente.SelectedIndex = 0
        If lbltipou.Text = "Secretario Escolar" Then
            menureportse.Show()
            Me.Close()



        Else
            menupdoc.Show()
            Me.Close()
        End If

    End Sub
End Class