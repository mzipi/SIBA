Public Class iabmsalon


    Private Sub ListView1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnalta.Click
        accion = acciones.ingresar
        ialtasalon.Show()
        Me.Close()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnmod.Click
        accion = acciones.modificar
        With dgvsalon.SelectedRows.Item(0)
            unsalon.cod_salon = .Cells(0).Value
            unsalon.tipo_salon = .Cells(1).Value
            unsalon.num_salon = .Cells(2).Value
        End With
        ialtasalon.Show()
        Me.Close()


    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnbaja.Click
        accion = acciones.eliminar
        With dgvsalon.SelectedRows.Item(0)
            unsalon.cod_salon = .Cells(0).Value
            unsalon.tipo_salon = .Cells(1).Value
            unsalon.num_salon = .Cells(2).Value
        End With
        ialtasalon.Show()
        Me.Close()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnatras.Click
        imenupse.Show()
        Me.Hide()

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndefcarr.Click

        iabmcarr.Show()
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

    Private Sub iabmsalon_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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
    End Sub

    Private Sub lbltitulo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbltitulo.Click

    End Sub
End Class
