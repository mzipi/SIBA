Imports system.data.Odbc

Public Class abmcarreras

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnalta.Click
        accion = acciones.ingresar
        altaCarrera.Show()
        Me.Close()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnmod.Click
        accion = acciones.modificar
        With dgvcarreras.SelectedRows.Item(0)
            unacarrera.nombre_carr = .Cells(0).Value
            unacarrera.duracion = .Cells(1).Value
        End With
        altaCarrera.Show()
        Me.Close()

    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnbaja.Click
        accion = acciones.eliminar
        With dgvcarreras.SelectedRows.Item(0)
            unacarrera.nombre_carr = .Cells(0).Value
            unacarrera.duracion = .Cells(1).Value
        End With
        altaCarrera.Show()
        Me.Close()
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
                login.cmbnomu.SelectedIndex = 0
                login.cmbpass.SelectedIndex = 0

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

        cx.ConnectionString = "FileDsn=C:\sibapro.dsn;UID=developer;PWD=developer"
        cx.Open()
        cm.Connection = cx
        cm.CommandText = "SELECT * FROM carreras"
        cm.ExecuteNonQuery()
        da.SelectCommand = cm
        da.Fill(ds, "carreras")
        dgvcarreras.DataSource = ds.Tables("carreras")
    End Sub
End Class