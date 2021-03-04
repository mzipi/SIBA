Public Class abmSalon


    Private Sub ListView1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnalta.Click
        accion = acciones.ingresar
        altasalon.Show()
        Me.Close()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnmod.Click

        accion = acciones.modificar
        If (dgvsalon.SelectedRows.Count = 0) Then
            MsgBox("Debe seleccionar un dato para modificar")
        Else
            With dgvsalon.SelectedRows.Item(0)
                unsalon.cod_salon = .Cells(0).Value
                unsalon.tipo_salon = .Cells(1).Value
                unsalon.num_salon = .Cells(2).Value
            End With
            altasalon.Show()
            Me.Close()
        End If


    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnbaja.Click

        accion = acciones.eliminar
        If (dgvsalon.SelectedRows.Count = 0) Then
            MsgBox("Debe seleccionar un dato para eliminar")
        Else
            With dgvsalon.SelectedRows.Item(0)
                unsalon.cod_salon = .Cells(0).Value
                unsalon.tipo_salon = .Cells(1).Value
                unsalon.num_salon = .Cells(2).Value
            End With
            altasalon.Show()
            Me.Close()
        End If

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnatras.Click
        menupse.Show()
        Me.Hide()

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndefcarr.Click
        
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

    Private Sub abmSalon_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim cx As New Odbc.OdbcConnection
        Dim cm As New Odbc.OdbcCommand
        Dim da As New Odbc.OdbcDataAdapter
        Dim ds As New Data.DataSet

        cx.ConnectionString = "FileDSN=c:\itechplus_sec.dsn;UID=techplus_sec;pwd=1234"
        cx.Open()
        cm.Connection = cx
        cm.CommandText = "SELECT * FROM salon"
        cm.ExecuteNonQuery()
        da.SelectCommand = cm
        da.Fill(ds, "salon")
        dgvsalon.DataSource = ds.Tables("salon")
        If (dgvsalon.Rows.Count > 1) Then
            dgvsalon.CurrentRow.Selected = False
        End If
        dgvsalon.RowHeadersVisible = False

        dgvsalon.Columns(0).HeaderText = "Código Salón"
        dgvsalon.Columns(1).HeaderText = "Tipo de Salón"
        dgvsalon.Columns(2).HeaderText = "Número Salón"

    End Sub

End Class