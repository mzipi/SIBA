
Public Class abmhoras

    Private Sub Form37_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim cx As New Odbc.OdbcConnection
        Dim cm As New Odbc.OdbcCommand
        Dim da As New Odbc.OdbcDataAdapter
        Dim ds As New Data.DataSet

        cx.ConnectionString = "FileDsn=C:\sibapro.dsn;UID=developer;PWD=developer"
        cx.Open()
        cm.Connection = cx
        cm.CommandText = "SELECT * FROM horas"
        cm.ExecuteNonQuery()
        da.SelectCommand = cm
        da.Fill(ds, "horas")
        dgvhoras.DataSource = ds.Tables("horas")
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnalta.Click
        accion = acciones.ingresar
        altahoras.Show()
        Me.Close()

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnmod.Click
        accion = acciones.modificar
        With dgvhoras.SelectedRows.Item(0)
            unahora.id_horas = .Cells(0).Value
            unahora.num_horas = .Cells(1).Value
            unahora.dia = .Cells(2).Value
            unahora.inicio = .Cells(3).Value
            unahora.fin = .Cells(4).Value

        End With
        altahoras.Show()
        Me.Close()


    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnbaja.Click
        accion = acciones.eliminar
        With dgvhoras.SelectedRows.Item(0)
            unahora.id_horas = .Cells(0).Value
            unahora.num_horas = .Cells(1).Value
            unahora.dia = .Cells(2).Value
            unahora.inicio = .Cells(3).Value
            unahora.fin = .Cells(4).Value

        End With
        altahoras.Show()
        Me.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bnbaja.Click
        abmturnos.Show()
        Me.Close()
    End Sub

    Private Sub btnclose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclose.Click
        Select Case MsgBox("Desea cerrar sesión?", MsgBoxStyle.YesNo)
            Case MsgBoxResult.Yes

                login.cmbnomu.SelectedIndex = 0
                login.cmbpass.SelectedIndex = 0
                login.Show()
                Me.Close()
            Case MsgBoxResult.No
                Me.Hide()
                Me.Show()
        End Select
    End Sub
End Class