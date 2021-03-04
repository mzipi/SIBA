Public Class abmMateria

    Private Sub Form31_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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
        dgvmat.Columns(0).HeaderText = "Código de Materia"
        dgvmat.Columns(1).HeaderText = "Carga Horaria"
        dgvmat.Columns(2).HeaderText = "Nombre Materia"
        dgvmat.Columns(3).HeaderText = "Tipo Materia"
        dgvmat.Columns(4).HeaderText = "Carrera"
        dgvmat.Columns(5).HeaderText = "Año de la Materia"
        cx.Close()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        accion = acciones.modificar
        If (dgvmat.SelectedRows.Count = 0) Then
            MsgBox("Para modificar seleccione una fila de la lista y luego presione modificar")
        Else

            With dgvmat.SelectedRows.Item(0)
                unamateria.cod_materia = .Cells(0).Value
                unamateria.carga_horaria = .Cells(1).Value
                unamateria.nombre_mat = .Cells(2).Value
                unamateria.tipo_mat = .Cells(3).Value
                unamateria.nombre_carr = .Cells(4).Value
                unamateria.año_mat = .Cells(5).Value
                
            End With
            altaMateria.Show()
            Me.Close()

        End If

        
        


        


    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        accion = acciones.eliminar
        If (dgvmat.SelectedRows.Count = 0) Then
            MsgBox("Para eliminar seleccione una fila de la lista y luego presione modificar")
        Else

            With dgvmat.SelectedRows.Item(0)
                unamateria.cod_materia = .Cells(0).Value
                unamateria.carga_horaria = .Cells(1).Value
                unamateria.nombre_mat = .Cells(2).Value
                unamateria.tipo_mat = .Cells(3).Value
                unamateria.nombre_carr = .Cells(4).Value
                unamateria.año_mat = .Cells(5).Value

            End With
            altaMateria.Show()
            Me.Close()

        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        accion = acciones.ingresar
        altaMateria.Show()
        Me.Close()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        asignhoramat.Show()
        Me.Hide()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        abmcarreras.Show()
        Me.Hide()
    End Sub

    
    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Select Case MsgBox("Desea cerrar sesión?", MsgBoxStyle.YesNo)
            Case MsgBoxResult.Yes

                login.txtusuario.clear()
                login.txtpass.clear()
                login.Show()
                Me.Hide()
            Case MsgBoxResult.No

                Me.Show()
        End Select
    End Sub

    Private Sub dgvmat_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvmat.CellContentClick

    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub txtnomcar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtnomcar.Click
        txtnommat.Clear()

    End Sub

    Private Sub txtnombre_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtnomcar.TextChanged
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

    Private Sub txtnommat_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtnommat.Click
        txtnomcar.Clear()
    End Sub

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

End Class