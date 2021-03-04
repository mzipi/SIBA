Public Class iabmdoc

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnalta.Click
        accion = acciones.ingresar
        ialtadoc.Show()

        Me.Close()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnmod.Click
        accion = acciones.modificar
        If (dgvdoc.SelectedRows.Count = 0) Then
            MsgBox("Choose a row to the list and then press Modify")
        Else

            With dgvdoc.SelectedRows.Item(0)
                undocente.ci = .Cells(0).Value
                undocente.nombre_completo = .Cells(1).Value
                undocente.grado = .Cells(2).Value
                undocente.antiguedad = .Cells(3).Value
                undocente.form_acad = .Cells(4).Value
                undocente.tel = .Cells(5).Value
                undocente.categoria_docente = .Cells(6).Value

            End With
            ialtadoc.Show()
            Me.Close()

        End If


    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnbaja.Click
        accion = acciones.eliminar
        If (dgvdoc.SelectedRows.Count = 0) Then
            MsgBox("Choose a row to remove the list and then press Delete")

        Else
            With dgvdoc.SelectedRows.Item(0)
                undocente.ci = .Cells(0).Value
                undocente.nombre_completo = .Cells(1).Value
                undocente.grado = .Cells(2).Value
                undocente.antiguedad = .Cells(3).Value
                undocente.form_acad = .Cells(4).Value
                undocente.tel = .Cells(5).Value
                undocente.categoria_docente = .Cells(6).Value

            End With
            ialtadoc.Show()
            Me.Close()

        End If

    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnasigngrup.Click
        iasignargrupadoc.Show()
        Me.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnatras.Click
        imenupse.Show()
        Me.Close()



    End Sub

    Private Sub btnclose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclose.Click
        Select Case MsgBox("Do you want close this session?", MsgBoxStyle.YesNo)
            Case MsgBoxResult.Yes
                login.txtuser.Clear()
                login.txtpw.Clear()
                login.Show()
                Me.Close()
            Case MsgBoxResult.No
                Me.Hide()
                Me.Show()
        End Select
    End Sub



    Private Sub iabmdocentes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim cx As New Odbc.OdbcConnection
        Dim cm As New Odbc.OdbcCommand
        Dim da As New Odbc.OdbcDataAdapter
        Dim ds As New Data.DataSet
        cx.ConnectionString = "FileDSN=c:\itechplus_sec.dsn;UID=techplus_sec;pwd=1234"
        cx.Open()
        cm.Connection = cx
        cm.CommandText = "SELECT ci, nombre_completo,grado,antiguedad,form_acad,tel,categoria_docente FROM docentes"
        cm.ExecuteNonQuery()
        da.SelectCommand = cm
        da.Fill(ds, "docentes")
        dgvdoc.DataSource = ds.Tables("docentes")

        If (dgvdoc.Rows.Count > 1) Then
            dgvdoc.CurrentRow.Selected = False
        End If
        dgvdoc.Columns("form_acad").Visible = False
        dgvdoc.RowHeadersVisible = False
        dgvdoc.Columns(0).HeaderText = "Document"
        dgvdoc.Columns(4).HeaderText = "Academic Training"
        dgvdoc.Columns(2).HeaderText = "Grade"
        dgvdoc.Columns(3).HeaderText = "Antiquity"
        dgvdoc.Columns(1).HeaderText = "Name"
        dgvdoc.Columns(5).HeaderText = "Phone"
        dgvdoc.Columns(6).HeaderText = "Teaching Category"

        cx.Close()
    End Sub

    Private Sub txtnombre_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtnombre.Click
        txtci.Clear()

    End Sub

    Private Sub txtnombre_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtnombre.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtnombre_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtnombre.TextChanged
        txtci.Clear()
        Dim cx As New Odbc.OdbcConnection
        Dim cm As New Odbc.OdbcCommand
        Dim da As New Odbc.OdbcDataAdapter
        Dim ds As New DataSet
        cx.ConnectionString = "FileDSN=c:\itechplus_sec.dsn;UID=techplus_sec;pwd=1234"
        cx.Open()
        cm.CommandText = "SELECT ci, nombre_completo,grado,antiguedad,form_acad,tel FROM docentes where nombre_completo like '%" _
        + txtnombre.Text + "%'"
        cm.Connection = cx
        cm.ExecuteNonQuery()
        da.SelectCommand = cm
        da.Fill(ds, "docentes")
        dgvdoc.DataSource = ds.Tables("docentes")
        cx.Close()

    End Sub

    Private Sub txtci_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtci.Click
        txtnombre.Clear()

    End Sub

    Private Sub txtci_ImeModeChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtci.ImeModeChanged

    End Sub

    Private Sub txtci_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtci.KeyPress
        If (e.KeyChar < "0" Or e.KeyChar > "9") And e.KeyChar <> Chr(Keys.Back) Then
            e.KeyChar = ""
        End If
    End Sub

    Private Sub txtci_MarginChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtci.MarginChanged

    End Sub

    Private Sub txtci_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtci.TextChanged
        txtnombre.Clear()
        Dim cx As New Odbc.OdbcConnection
        Dim cm As New Odbc.OdbcCommand
        Dim da As New Odbc.OdbcDataAdapter
        Dim ds As New DataSet
        cx.ConnectionString = "FileDSN=c:\itechplus_sec.dsn;UID=techplus_sec;pwd=1234"
        cx.Open()
        cm.CommandText = "SELECT ci, nombre_completo,grado,antiguedad,form_acad,tel FROM docentes where ci like '%" + txtci.Text + "%'"
        cm.Connection = cx
        cm.ExecuteNonQuery()
        da.SelectCommand = cm
        da.Fill(ds, "docentes")
        dgvdoc.DataSource = ds.Tables("docentes")

        cx.Close()
    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub
End Class
