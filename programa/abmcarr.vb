Imports system.data.Odbc

Public Class abmcarreras

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnalta.Click
        accion = acciones.ingresar
        altaCarrera.Show()
        Me.Close()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnmod.Click
        accion = acciones.modificar
        If (dgvcarreras.SelectedRows.Count = 0) Then
            MsgBox("Para modificar seleccione una fila de la lista y luego presione modificar")
        Else

            With dgvcarreras.SelectedRows.Item(0)
                unacarrera.nombre_carr = .Cells(0).Value
                unacarrera.duracion = .Cells(1).Value
            End With
            If (unacarrera.nombre_carr = "") Then
                MsgBox("Debe seleccionar una fila con datos")
            End If
            If (unacarrera.nombre_carr <> "") Then
                altaCarrera.Show()
                Me.Close()
            End If
        End If
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnbaja.Click
        accion = acciones.eliminar
        If (dgvcarreras.SelectedRows.Count = 0) Then
            MsgBox("Para eliminar seleccione una fila de la lista y luego presione eliminar")
        Else
            With dgvcarreras.SelectedRows.Item(0)
                unacarrera.nombre_carr = .Cells(0).Value
                unacarrera.duracion = .Cells(1).Value
            End With
            altaCarrera.Show()
            Me.Close()
        End If

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btninggrup.Click
        abmGrupo.Show()
        Me.Hide()
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnasignmat.Click
        abmMateria.Show()
        Me.Hide()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnatras.Click
        menupse.Show()
        Me.Hide()
    End Sub


    Private Sub btnclose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclose.Click

        Select Case MsgBox("Desea cerrar sesión?", MsgBoxStyle.YesNo)
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

    Private Sub abmcarreras_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim cx As New Odbc.OdbcConnection
        Dim cm As New Odbc.OdbcCommand
        Dim da As New Odbc.OdbcDataAdapter
        Dim ds As New Data.DataSet

        cx.ConnectionString = "FileDSN=c:\itechplus_sec.dsn;UID=techplus_sec;pwd=1234"
        cx.Open()
        cm.Connection = cx
        cm.CommandText = "SELECT * FROM carreras"
        cm.ExecuteNonQuery()
        da.SelectCommand = cm
        da.Fill(ds, "carreras")
        dgvcarreras.DataSource = ds.Tables("carreras")
        If (dgvcarreras.Rows.Count > 1) Then
            dgvcarreras.CurrentRow.Selected = False
        End If
        dgvcarreras.RowHeadersVisible = False
        dgvcarreras.Columns(0).HeaderText = "Nombre Carrera"
        dgvcarreras.Columns(1).HeaderText = "Duración"

        cx.Close()
    End Sub

    Private Sub dgvcarreras_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvcarreras.CellContentClick

    End Sub
End Class