Public Class ihorasturdir

    Private Sub horasturdir_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtid_turno.Visible = False
        dgvhorastur.Visible = False
        btnmenu.Visible = True



        cmbturno.SelectedIndex = 0
    End Sub

    Private Sub btncons_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncons.Click
        If (cmbturno.SelectedIndex <> 0) Then
            Dim cx As New Odbc.OdbcConnection
            Dim cm As New Odbc.OdbcCommand
            Dim da As New Odbc.OdbcDataAdapter
            Dim ds As New Data.DataSet
            cx.ConnectionString = "FileDSN=c:\itechplus_dir.dsn;UID=techplus_dir;pwd=1234"
            cx.Open()
            cm.Connection = cx
            cm.CommandText = "select distinct  dia,inicio,fin, nombre_turno from horas, turno,se_divide where turno.id_turno=" + txtid_turno.Text + " and horas.id_horas = se_divide.id_horas And turno.id_turno = se_divide.id_turno"


            cm.ExecuteNonQuery()
            da.SelectCommand = cm
            da.Fill(ds, "docentes")
            dgvhorastur.DataSource = ds.Tables("docentes")

            If (dgvhorastur.Rows.Count > 1) Then
                dgvhorastur.CurrentRow.Selected = False
            End If

            dgvhorastur.RowHeadersVisible = False
            dgvhorastur.Columns(0).HeaderText = "Day"
            dgvhorastur.Columns(1).DefaultCellStyle.Format = "HH:mm"
            dgvhorastur.Columns(2).DefaultCellStyle.Format = "HH:mm"

            dgvhorastur.Columns(1).HeaderText = "Start"
            dgvhorastur.Columns(2).HeaderText = "End"
            dgvhorastur.Columns(3).HeaderText = "Turns"
            dgvhorastur.Columns(1).HeaderText = "Name"

            cx.Close()
            dgvhorastur.Visible = True



        End If

    End Sub

    Private Sub btnmenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnmenu.Click
        imenupdir.Show()
        Me.Hide()


    End Sub

    Private Sub btnenv_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub btnsi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        cmbturno.SelectedIndex = 0
    End Sub

    Private Sub btnclose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclose.Click

        Select Case MsgBox("Do you want to close this session?", MsgBoxStyle.YesNo)
            Case MsgBoxResult.Yes
                btnmenu.Visible = False
                cmbturno.SelectedIndex = 0
                login.txtpass.Clear()
                login.txtusuario.Clear()
                login.Show()
                Me.Close()
            Case MsgBoxResult.No
                Me.Hide()
                Me.Show()
        End Select


    End Sub

    Private Sub cmbturno_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbturno.SelectedIndexChanged
        Dim cx2 As New Odbc.OdbcConnection
        Dim cm2 As New Odbc.OdbcCommand
        Dim lector As Odbc.OdbcDataReader
        cx2.ConnectionString = "FileDSN=c:\itechplus_dir.dsn;UID=techplus_dir;pwd=1234"
        cx2.Open()

        cm2.CommandText = "select id_turno from turno where nombre_turno='" + cmbturno.SelectedItem + "'"
        cm2.Connection = cx2
        lector = cm2.ExecuteReader()
        If lector.HasRows Then
            txtid_turno.Text = lector.GetString(0)
            cx2.Close()
        End If

    End Sub
End Class