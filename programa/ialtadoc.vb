Imports System.Math

Public Class ialtadoc

    Public Const vb_roundup1 = 1

    Public Const vb_rounddown1 = 0
    Public Sub New()
        InitializeComponent()
        Dim ttDatosci As New ToolTip
        ttci.SetToolTip(lbldatos_Ci, "You must entry only numbers. Ej: 1.111.111-8. The entry will be 11111118")
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancel.Click
        txtnombre.Clear()
        txtci.Clear()
        txtant.Clear()
        txtformac.Clear()
        txttel.Clear()
        cmbcatdoc.SelectedIndex = 0


    End Sub

    Private Sub btnclose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclose.Click
        'cierre de sesión

        Select Case MsgBox("Do you want close this session?", MsgBoxStyle.YesNo)
            Case MsgBoxResult.Yes
                txtnombre.Clear()
                txtci.Clear()
                txtant.Clear()
                txtformac.Clear()
                txttel.Clear()
                cmbcatdoc.SelectedIndex = 0
                login.txtuser.Clear()
                login.txtpw.Clear()
                login.Show()
                Me.Close()
            Case MsgBoxResult.No
                Me.Hide()
                Me.Show()
        End Select
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnaceptar.Click

        Dim controlci As Integer
        controlci = 0

        Dim control As Integer
        control = 0

        Dim grado As Double




        'controla que no existan  campos vacios
        If (txtci.Text <> "") Then
            If (txtci.Text < 5000000) Then
                MsgBox("Debe ingresar un número de cédula entre 5.000.000 y 99.999.999 incluyendo el dígito verificador")
                controlci = 1

            End If
        End If

        If (txtnombre.Text = "") Then
            MsgBox("You must enter a name for teacher")
        End If
        If (txtci.Text = "") Then
            MsgBox("You must enter a document")
        End If

        If (txttel.Text = "") Then
            MsgBox("You must enter a phone")

        End If

        If (cmbcatdoc.SelectedIndex = 0) Then
            MsgBox("You must select a teaching category")

        End If

        If (txtformac.Text = "") Then
            MsgBox("You must enter a academic training")
        End If
        If (cmbcatdoc.SelectedIndex = 0) Then
            MsgBox("You must select teacher category")
        End If





        If (cmbcatdoc.SelectedIndex <> 0 And txtant.Text <> "") Then

            If (cmbcatdoc.SelectedIndex = 2 And txtant.Text <= 13 And txtant.Text > 5) Then
                grado = ((((txtant.Text - 5) / 4)) + 1)
                calcgrado.Text = RoundToNearest(grado, 1, vb_rounddown1)

            End If

            If (cmbcatdoc.SelectedIndex = 3 And txtant.Text <= 13 And txtant.Text > 5) Then
                grado = ((((txtant.Text - 5) / 4)) + 1)
                calcgrado.Text = RoundToNearest(grado, 1, vb_rounddown1)

            End If

            If (cmbcatdoc.SelectedIndex = 2 And txtant.Text > 13) Then
                calcgrado.Text = 3
            End If
            If (cmbcatdoc.SelectedIndex = 3 And txtant.Text > 13) Then
                calcgrado.Text = 3
            End If


            If (cmbcatdoc.SelectedIndex = 1 And txtant.Text > 5 And txtant.Text <= 29) Then
                grado = ((((txtant.Text - 5) / 4)) + 1)
                calcgrado.Text = RoundToNearest(grado, 1, vb_rounddown1)
            End If
            If (cmbcatdoc.SelectedIndex = 1 And txtant.Text > 29) Then
                calcgrado.Text = 7
            End If

            If (txtant.Text < 5) Then
                calcgrado.Text = 1
            End If

        End If

        '''''''''''''''''''''''''''''


        'controla que no se repita el docente al ingresar
        If (accion = acciones.ingresar) Then
            If (txtformac.Text <> "" And txtnombre.Text <> "" And controlci <> 1 And txttel.Text <> "" And cmbcatdoc.SelectedIndex <> 0 And control <> 1 And txtant.Text <> "") Then
                Dim cx As New Odbc.OdbcConnection
                Dim cm As New Odbc.OdbcCommand
                Dim da As New Odbc.OdbcDataAdapter
                Dim ds As New Data.DataSet

                cx.ConnectionString = "FileDSN=c:\itechplus_sec.dsn;UID=techplus_sec;pwd=1234"
                cx.Open()
                cm.Connection = cx
                cm.CommandText = "SELECT ci, nombre_completo FROM docentes where ci ='" + txtci.Text + "'"
                cm.ExecuteNonQuery()
                da.SelectCommand = cm
                da.Fill(ds, "docentes")

                If ds.Tables("docentes").Rows.Count > 0 Then
                    MsgBox("Teacher entered already exists with that document")
                    control = 1
                End If
                cx.Close()
            End If
        End If

        'realiza un nuevo ingreso de docente
        If (accion = acciones.ingresar) Then
            Dim sql As String = ""
            Dim cx As New Odbc.OdbcConnection
            Dim cm As New Odbc.OdbcCommand

            If (txtformac.Text <> "" And txtnombre.Text <> "" And controlci <> 1 And txttel.Text <> "" And cmbcatdoc.SelectedIndex <> 0 And control <> 1 And txtant.Text <> "") Then
                sql = "INSERT INTO docentes (ci,nombre_completo,grado,antiguedad,tel,categoria_docente,form_acad) VALUES ('" + txtci.Text + "','"
                sql += txtnombre.Text + "'," + calcgrado.Text + ","
                sql += txtant.Text + ","
                sql += txttel.Text + ",'"
                sql += cmbcatdoc.SelectedItem + "','" + txtformac.Text + "')"
                cx.ConnectionString = "FileDSN=c:\itechplus_sec.dsn;UID=techplus_sec;pwd=1234"
                cx.Open()
                cm.Connection = cx
                cm.CommandText = sql
                cm.ExecuteNonQuery()
                cx.Close()
                btnver.Visible = True
                MsgBox("Teacher entered")

                txtnombre.Clear()
                txtci.Clear()
                txtant.Clear()
                txtformac.Clear()
                txttel.Clear()
                cmbcatdoc.SelectedIndex = 0

                control = 0

            End If

        End If





        'controla que no tenga datos asociados

        If (accion = acciones.eliminar) Then
            Dim cx As New Odbc.OdbcConnection
            Dim cm As New Odbc.OdbcCommand
            Dim da As New Odbc.OdbcDataAdapter
            Dim ds As New Data.DataSet

            cx.ConnectionString = "FileDSN=c:\itechplus_sec.dsn;UID=techplus_sec;pwd=1234"
            cx.Open()
            cm.Connection = cx
            cm.CommandText = "SELECT ci FROM asignados where ci =" + txtci.Text
            cm.ExecuteNonQuery()
            da.SelectCommand = cm
            da.Fill(ds, "cidoc")

            If ds.Tables("cidoc").Rows.Count > 0 Then
                MsgBox("Existen grupos asignados a este docente. Debe eliminar los grupos asociados al docente para luego eliminar al docente")
                iabmdoc.Show()
                Me.Close()

                control = 1

            End If
            cx.Close()
        End If





        'modifica los datos de los docentes ingresados
        If (accion = acciones.modificar) Then
            If (txtnombre.Text <> "" And controlci <> 1 And txttel.Text <> "" And cmbcatdoc.SelectedIndex <> 0 And control <> 1 And txtant.Text <> "") Then
                Dim sql As String = ""
                Dim cx As New Odbc.OdbcConnection
                Dim cm As New Odbc.OdbcCommand

                sql = "UPDATE docentes SET "
                sql += "ci = " + txtci.Text + ","
                sql += "nombre_completo='" + txtnombre.Text + "',"
                sql += "grado=" + calcgrado.Text + ","
                sql += "antiguedad=" + txtant.Text + ","
                sql += "tel=" + txttel.Text + ","
                sql += "categoria_docente='" + cmbcatdoc.SelectedItem + " ',"
                sql += "form_acad='" + txtformac.Text + "'"
                sql += "where ci = " + undocente.ci.ToString
                MsgBox("Docente modificado exitosamente")
                cx.ConnectionString = "FileDSN=c:\itechplus_sec.dsn;UID=techplus_sec;pwd=1234"
                cx.Open()
                cm.Connection = cx
                cm.CommandText = sql
                cm.ExecuteNonQuery()
                cx.Close()

                iabmdoc.Show()
                Me.Close()

            End If
        End If
        'elimina los datos del docente seleccionado

        If (accion = acciones.eliminar) Then

            If (control <> 1) Then
                Dim sql As String = ""
                Dim cx As New Odbc.OdbcConnection
                Dim cm As New Odbc.OdbcCommand
                Select Case MsgBox("Are you sure to eliminate this teacher" + txtnombre.Text + "?", MsgBoxStyle.YesNo)
                    Case MsgBoxResult.Yes
                        sql = "DELETE FROM docentes WHERE CI = " + txtci.Text
                        cx.ConnectionString = "FileDSN=c:\itechplus_sec.dsn;UID=techplus_sec;pwd=1234"
                        cx.Open()
                        cm.Connection = cx
                        cm.CommandText = sql
                        cm.ExecuteNonQuery()
                        MsgBox("Teacher deleted succesfully ")

                        cx.Close()
                        iabmdoc.Show()
                        Me.Close()
                    Case MsgBoxResult.No
                        iabmdoc.Show()
                        Me.Close()
                End Select
            End If
        End If

    End Sub

    Private Sub Button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        iabmdoc.Show()
        Me.Close()

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnfin.Click

        txtnombre.Clear()
        txtci.Clear()
        txtant.Clear()
        txtformac.Clear()
        txttel.Clear()
        cmbcatdoc.SelectedIndex = 0
        iabmdoc.Show()
        Me.Close()


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

    End Sub

    Private Sub txtant_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtant.KeyPress

        If (e.KeyChar < "0" Or e.KeyChar > "9") And e.KeyChar <> Chr(Keys.Back) Then
            e.KeyChar = ""
        End If
    End Sub

    Private Sub txtant_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtant.TextChanged

    End Sub

    Private Sub cmbgrado_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbcatdoc.KeyPress
        If (e.KeyChar < "0" Or e.KeyChar > "9") And e.KeyChar <> Chr(Keys.Back) Then
            e.KeyChar = ""
        End If
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbcatdoc.SelectedIndexChanged

    End Sub

    Private Sub txttel_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txttel.KeyPress
        If (e.KeyChar < "0" Or e.KeyChar > "9") And e.KeyChar <> Chr(Keys.Back) Then
            e.KeyChar = ""
        End If
    End Sub

    Private Sub txttel_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txttel.TextChanged

    End Sub

    Private Sub altaDocente_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        btnmenu.Visible = False
        calcgrado.Visible = False
        btnver.Visible = False
        btncont.Visible = False
        dgvdoc.Visible = False
        txtcedula.Visible = False
        calcgrado.Visible = False


        Select Case accion
            Case acciones.ingresar
                gbxedit.Visible = False
                gbxdoc.SetBounds(15, 55, 250, 308)
                cmbcatdoc.SelectedIndex = 0
                btnaceptar.Text = "Insert"
                lbltitulo.Text = "ENTRY TEACHERS"

            Case acciones.modificar
                gbxedit.Visible = True
                btnaceptar.Text = "Modify"
                lbltitulo.Text = "CHANGE TEACHERS"

                With undocente
                    txtci.Text = .ci
                    txtnombre.Text = .nombre_completo
                    calcgrado.Text = .grado
                    txtant.Text = .antiguedad
                    txtformac.Text = .form_acad
                    txttel.Text = .tel
                    cmbcatdoc.SelectedItem = .categoria_docente
                End With
                txtci.Enabled = False
                txtnombre.Enabled = False
                cmbcatdoc.Enabled = False
                txtant.Enabled = False
                txtformac.Enabled = False
                txttel.Enabled = False
                calcgrado.Enabled = False


            Case acciones.eliminar
                gbxedit.Visible = False
                gbxdoc.SetBounds(15, 55, 250, 260)
                btnaceptar.Text = "Delete"
                lbltitulo.Text = "LOW TEACHERS"

                With undocente
                    txtci.Text = .ci
                    txtnombre.Text = .nombre_completo
                    calcgrado.Text = .grado
                    txtant.Text = .antiguedad
                    txtformac.Text = .form_acad
                    txttel.Text = .tel
                    cmbcatdoc.SelectedItem = .categoria_docente

                End With
                txtci.Enabled = False
                txtnombre.Enabled = False
                cmbcatdoc.Enabled = False
                txtant.Enabled = False
                txtformac.Enabled = False
                txttel.Enabled = False
                calcgrado.Enabled = False

        End Select



    End Sub

    Private Sub txtci_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtci.KeyPress
        If (e.KeyChar < "0" Or e.KeyChar > "9") And e.KeyChar <> Chr(Keys.Back) Then
            e.KeyChar = ""
        End If
    End Sub

    Private Sub txtci_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtci.TextChanged

    End Sub

    Private Sub cmbestfun_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If (e.KeyChar < "0" Or e.KeyChar > "9") And e.KeyChar <> Chr(Keys.Back) Then
            e.KeyChar = ""
        End If
        If (e.KeyChar < "0" Or e.KeyChar > "9") And e.KeyChar <> Chr(Keys.Back) Then
            e.KeyChar = ""
        End If
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub



    Private Sub cmbestfun_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim grado As Double
        If (cmbcatdoc.SelectedIndex = 2 And txtant.Text <= 13) Then
            grado = ((((txtant.Text - 5) / 4)) + 1)
            calcgrado.Text = RoundToNearest(grado, 1, vb_rounddown1)

        End If

        If (cmbcatdoc.SelectedIndex = 3 And txtant.Text <= 13) Then
            grado = ((((txtant.Text - 5) / 4)) + 1)
            calcgrado.Text = RoundToNearest(grado, 1, vb_rounddown1)

        End If

        If (cmbcatdoc.SelectedIndex = 2 And txtant.Text > 13) Then
            calcgrado.Text = 3
        End If
        If (cmbcatdoc.SelectedIndex = 3 And txtant.Text > 13) Then
            calcgrado.Text = 3
        End If

        If (cmbcatdoc.SelectedIndex = 1) Then
            grado = ((((txtant.Text - 5) / 4)) + 1)
            calcgrado.Text = RoundToNearest(grado, 1, vb_rounddown1)
        End If

    End Sub

    Function RoundToNearest(ByVal Amt As Double, ByVal RoundAmt As Object, ByVal Direction As Integer) As Double

        On Error Resume Next

        Dim Temp As Double

        Temp = Amt / RoundAmt

        If Int(Temp) = Temp Then

            RoundToNearest = Amt

        Else

            If Direction = vb_rounddown1 Then

                Temp = Int(Temp)

            Else

                Temp = Int(Temp) + 1

            End If

            RoundToNearest = Temp * RoundAmt

        End If

    End Function




    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click
        txtnombre.Enabled = True

    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        txtci.Enabled = True
    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click
        txtant.Enabled = True
        cmbcatdoc.Enabled = True

    End Sub

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.Click
        txtformac.Enabled = True

    End Sub

    Private Sub Label6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label6.Click
        txttel.Enabled = True

    End Sub


    Private Sub ttci_Popup(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PopupEventArgs) Handles ttci.Popup

    End Sub

    Private Sub btnver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnver.Click


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
        cx.close()

        dgvdoc.Visible = True
        dgvdoc.SetBounds(15, 57, 490, 280)
        dgvdoc.RowHeadersVisible = False
        dgvdoc.Columns("form_acad").Visible = False
        dgvdoc.Columns(0).HeaderText = "Document"
        dgvdoc.Columns(4).HeaderText = "Academic Training"
        dgvdoc.Columns(2).HeaderText = "Grade"
        dgvdoc.Columns(3).HeaderText = "Antiquity"
        dgvdoc.Columns(1).HeaderText = "Name"
        dgvdoc.Columns(5).HeaderText = "Phone"
        dgvdoc.Columns(6).HeaderText = "Teaching Category"
        dgvdoc.RowHeadersVisible = False




        btnver.Visible = False
        btnmenu.Visible = True

        btncont.Visible = True
        dgvdoc.CurrentCell = dgvdoc.Rows(dgvdoc.Rows.Count - 2).Cells(0)
    End Sub

    Private Sub btncont_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncont.Click
        dgvdoc.Visible = False
        btncont.Visible = False
        btnmenu.Visible = False


    End Sub

    Private Sub dgvdoc_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvdoc.CellContentClick

    End Sub

    Private Sub btnmenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnmenu.Click
        iabmdoc.Show()
        Me.Close()

    End Sub

    Private Sub btnmenu_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnmenu.Click
        iabmdoc.Show()
        Me.Close()

    End Sub
End Class

