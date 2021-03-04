Public Class iabmcarr

    Private Sub btnalta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnalta.Click
        accion = acciones.ingresar
        ialtacarr.Show()
        Me.Close()
    End Sub

    Private Sub btnmod_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnmod.Click
        accion = acciones.modificar
        If (dgvcarreras.SelectedRows.Count = 0) Then
            MsgBox("Choose a row to the list and then press Modify")
        Else

            With dgvcarreras.SelectedRows.Item(0)
                unacarrera.nombre_carr = .Cells(0).Value
                unacarrera.duracion = .Cells(1).Value
            End With
            If (unacarrera.nombre_carr = "") Then
                MsgBox("You must select a row with data")
            End If
            If (unacarrera.nombre_carr <> "") Then
                ialtacarr.Show()
                Me.Close()
            End If
        End If
    End Sub

    Private Sub btnbaja_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnbaja.Click
        accion = acciones.eliminar
        If (dgvcarreras.SelectedRows.Count = 0) Then
            MsgBox("Choose a row to remove the list and then press Delete")
        Else
            With dgvcarreras.SelectedRows.Item(0)
                unacarrera.nombre_carr = .Cells(0).Value
                unacarrera.duracion = .Cells(1).Value
            End With
            ialtacarr.Show()
            Me.Close()
        End If
    End Sub

    Private Sub btnasignmat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnasignmat.Click
        iabmMat.Show()
        Me.Hide()
    End Sub

    Private Sub btninggrup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btninggrup.Click
        iabmGrupo.Show()
        Me.Hide()
    End Sub

    Private Sub btnatras_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnatras.Click
        imenupse.Show()
        Me.Hide()
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

    Private Sub dgvcarreras_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvcarreras.CellContentClick

    End Sub

    Private Sub iabmcarr_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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
        dgvcarreras.Columns(0).HeaderText = "Name Career"
        dgvcarreras.Columns(1).HeaderText = "Duration"

        cx.Close()
    End Sub

    Private Sub pbxlogo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbxlogo.Click

    End Sub

    Private Sub lbltipou_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbltipou.Click

    End Sub

    Private Sub lbldesarrollo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbldesarrollo.Click

    End Sub
End Class