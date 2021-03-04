Public Class iabmusuarios


    Private Sub lbltipou_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbltipou.Click

    End Sub

    Private Sub btnclose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclose.Click
        Select Case MsgBox("Do you want close this session?", MsgBoxStyle.YesNo)
            Case MsgBoxResult.Yes

                login.txtusuario.Clear()
                login.txtpass.Clear()
                login.Show()
                Me.Close()
            Case MsgBoxResult.No
                Me.Hide()
                Me.Show()
        End Select
    End Sub

    Private Sub btnalta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnalta.Click

        accion = acciones.ingresar
        If (dgvusuarios.RowCount = 1) Then
            MsgBox("Will be enters the first user")
        End If
        iingdatosusuarios.Show()
        Me.Close()

    End Sub

    Private Sub btnmod_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnmod.Click
        accion = acciones.modificar
        ingdatosusuarios.txtnombreusuario.Text = ingdatosusuarios.txtnomusua.Text
        If (dgvusuarios.SelectedRows.Count = 0) Then
            MsgBox("Will be enters the first user")
        Else
            With dgvusuarios.SelectedRows.Item(0)
                unusuario.nombre_usuario = .Cells(0).Value
                unusuario.nombre_apellido = .Cells(1).Value
                unusuario.perfil_usuario = .Cells(2).Value
                unusuario.ced_id = .Cells(4).Value
                unusuario.email = .Cells(3).Value
                unusuario.contraseña = .Cells(5).Value



            End With
            iingdatosusuarios.Show()
            Me.Close()

        End If


    End Sub

    Private Sub btnbaja_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnbaja.Click
        accion = acciones.eliminar
        If (dgvusuarios.SelectedRows.Count = 0) Then
            MsgBox("You must select a row with data")
        Else
            With dgvusuarios.SelectedRows.Item(0)
                unusuario.nombre_usuario = .Cells(0).Value
                unusuario.contraseña = .Cells(5).Value
                unusuario.ced_id = .Cells(4).Value
                unusuario.perfil_usuario = .Cells(2).Value
                unusuario.email = .Cells(3).Value
                unusuario.nombre_apellido = .Cells(1).Value
            End With

            iingdatosusuarios.Show()
            Me.Close()

        End If

    End Sub

    Private Sub btnatras_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnatras.Click
        imenurepei.Show()
        Me.Close()
    End Sub

    Private Sub iabmusuario_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim cx As New Odbc.OdbcConnection
        Dim cm As New Odbc.OdbcCommand
        Dim da As New Odbc.OdbcDataAdapter
        Dim ds As New Data.DataSet

        cx.ConnectionString = "FileDsn=C:\itechplus_enc.dsn;UID=techplus_enc;PWD=1234"
        cx.Open()
        cm.Connection = cx
        cm.CommandText = "SELECT nombre_usuario, nombre_apellido,perfil_usuario,email,ced_id,contrasenia  FROM usuarios"
        cm.ExecuteNonQuery()
        da.SelectCommand = cm
        da.Fill(ds, "usuarios")

        dgvusuarios.DataSource = ds.Tables("Usuarios")
        If (dgvusuarios.Rows.Count > 1) Then
            dgvusuarios.CurrentRow.Selected = False
        End If
        dgvusuarios.RowHeadersVisible = False
        dgvusuarios.Columns("contrasenia").Visible = False
        dgvusuarios.Columns(0).HeaderText = "Username"
        dgvusuarios.Columns(4).HeaderText = "Document"
        dgvusuarios.Columns(2).HeaderText = "Profile"
        dgvusuarios.Columns(3).HeaderText = "Email"
        dgvusuarios.Columns(1).HeaderText = "Name"

    End Sub

    Private Sub cmbnombre_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtnomusua.TextChanged
        txtnombre.Clear()
        Dim cx As New Odbc.OdbcConnection
        Dim cm As New Odbc.OdbcCommand
        Dim da As New Odbc.OdbcDataAdapter
        Dim ds As New DataSet
        cx.ConnectionString = "FileDsn=C:\itechplus_enc.dsn;UID=techplus_enc;PWD=1234"
        cx.Open()
        cm.CommandText = "SELECT * FROM usuarios where nombre_usuario like '%" _
        + txtnomusua.Text + "%'"
        cm.Connection = cx
        cm.ExecuteNonQuery()
        da.SelectCommand = cm
        da.Fill(ds, "usuarios")
        dgvusuarios.DataSource = ds.Tables("usuarios")

    End Sub

    Private Sub txtnombre_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtnombre.TextChanged
        txtnomusua.Clear()
        Dim cx As New Odbc.OdbcConnection
        Dim cm As New Odbc.OdbcCommand
        Dim da As New Odbc.OdbcDataAdapter
        Dim ds As New DataSet
        cx.ConnectionString = "FileDsn=C:\itechplus_enc.dsn;UID=techplus_enc;PWD=1234"
        cx.Open()
        cm.CommandText = "SELECT * FROM usuarios where nombre_apellido like '%" _
        + txtnombre.Text + "%'"
        cm.Connection = cx
        cm.ExecuteNonQuery()
        da.SelectCommand = cm
        da.Fill(ds, "usuarios")
        dgvusuarios.DataSource = ds.Tables("usuarios")

    End Sub

    Private Sub dgvusuarios_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvusuarios.CellContentClick

    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub
End Class
   