Public Class iabmMat

    Private Sub txtnommat_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtnommat.TextChanged
        txtnomcar.Clear()
        Dim cx As New Odbc.OdbcConnection
        Dim cm As New Odbc.OdbcCommand
        Dim da As New Odbc.OdbcDataAdapter
        Dim ds As New DataSet
        cx.ConnectionString = "FileDSN=c:\itechplus_sec.dsn;UID=techplus_sec;pwd=1234"
        cx.Open()
        cm.CommandText = "SELECT * FROM materias where nombre_mat like '%" _
        + txtnommat.Text + "%'"
        cm.Connection = cx
        cm.ExecuteNonQuery()
        da.SelectCommand = cm
        da.Fill(ds, "materias")
        dgvmat.DataSource = ds.Tables("materias")
        cx.Close()
    End Sub

    Private Sub txtnomcar_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtnomcar.TextChanged
        txtnommat.Clear()
        Dim cx As New Odbc.OdbcConnection
        Dim cm As New Odbc.OdbcCommand
        Dim da As New Odbc.OdbcDataAdapter
        Dim ds As New DataSet
        cx.ConnectionString = "FileDSN=c:\itechplus_sec.dsn;UID=techplus_sec;pwd=1234"
        cx.Open()
        cm.CommandText = "SELECT * FROM materias where nombre_carr like '%" _
        + txtnomcar.Text + "%'"
        cm.Connection = cx
        cm.ExecuteNonQuery()
        da.SelectCommand = cm
        da.Fill(ds, "materias")
        dgvmat.DataSource = ds.Tables("materias")
        cx.Close()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Select Case MsgBox("Do you want close this session?", MsgBoxStyle.YesNo)
            Case MsgBoxResult.Yes

                login.txtusuario.Clear()
                login.txtpass.Clear()
                login.Show()
                Me.Hide()
            Case MsgBoxResult.No

                Me.Show()
        End Select
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        accion = acciones.ingresar
        ialtaMat.Show()
        Me.Close()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        accion = acciones.modificar
        If (dgvmat.SelectedRows.Count = 0) Then
            MsgBox("Choose a row to the list and then press Modify")
        Else

            With dgvmat.SelectedRows.Item(0)
                unamateria.cod_materia = .Cells(0).Value
                unamateria.carga_horaria = .Cells(1).Value
                unamateria.nombre_mat = .Cells(2).Value
                unamateria.tipo_mat = .Cells(3).Value
                unamateria.nombre_carr = .Cells(4).Value
                unamateria.año_mat = .Cells(5).Value

            End With
            ialtaMat.Show()
            Me.Close()
        End If
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        accion = acciones.eliminar
        If (dgvmat.SelectedRows.Count = 0) Then
            MsgBox("Choose a row to remove the list and then press Delete")
        Else

            With dgvmat.SelectedRows.Item(0)
                unamateria.cod_materia = .Cells(0).Value
                unamateria.carga_horaria = .Cells(1).Value
                unamateria.nombre_mat = .Cells(2).Value
                unamateria.tipo_mat = .Cells(3).Value
                unamateria.nombre_carr = .Cells(4).Value
                unamateria.año_mat = .Cells(5).Value

            End With
            ialtaMat.Show()
            Me.Close()

        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        asignhoramat.Show()
        Me.Hide()
    End Sub




    Private Sub iabmMat_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim cx As New Odbc.OdbcConnection
        Dim cm As New Odbc.OdbcCommand
        Dim da As New Odbc.OdbcDataAdapter
        Dim ds As New Data.DataSet

        cx.ConnectionString = "FileDSN=c:\itechplus_sec.dsn;UID=techplus_sec;pwd=1234"
        cx.Open()
        cm.Connection = cx
        cm.CommandText = "SELECT * FROM materias"
        cm.ExecuteNonQuery()
        da.SelectCommand = cm
        da.Fill(ds, "materias")

        dgvmat.DataSource = ds.Tables("materias")
        If (dgvmat.Rows.Count > 1) Then
            dgvmat.CurrentRow.Selected = False

        End If

        dgvmat.RowHeadersVisible = False
        dgvmat.Columns(0).HeaderText = "Subjects Code"
        dgvmat.Columns(1).HeaderText = "Workload"
        dgvmat.Columns(2).HeaderText = "Subjects Name"
        dgvmat.Columns(3).HeaderText = "Subjects Type"
        dgvmat.Columns(4).HeaderText = "Career"
        dgvmat.Columns(5).HeaderText = "Year of subjects"
        cx.Close()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        iabmcarr.Show()
        Me.Close()
    End Sub
End Class