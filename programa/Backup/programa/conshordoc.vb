Public Class conshordoc

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Form8_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        cmbturno.SelectedIndex = 0

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblcons.Click
        If txtnombre.Text = "" Then
            MsgBox("Debe ingresar nombre")
        End If
        If txtci.Text = "" Then
            MsgBox("Debe ingresar código del docente")
        End If
        If cmbturno.SelectedIndex = 0 Then
            MsgBox("Debe seleccionar un turno")
        End If
        If (txtnombre.Text <> "" And txtci.Text <> "" And cmbturno.SelectedIndex <> 0) Then
            repDoc.lblnomcompleto.Text = txtnombre.Text
            repDoc.lblcoddoc.Text = txtci.Text
            repDoc.lblidturno.Text = cmbturno.SelectedItem
            repDoc.Show()
            txtci.Clear()
            txtnombre.Clear()
            cmbturno.SelectedIndex = 0
            Me.Hide()

        End If



    End Sub

    Private Sub FlowLayoutPanel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs)

    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblcodoc.Click

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If (txtnombre.Text = 37) Then
            txtci.Visible = False
            lblrol.Visible = True

        End If
    End Sub

    Private Sub txtcod_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtci.KeyPress
        If (e.KeyChar < "0" Or e.KeyChar > "9") And e.KeyChar <> Chr(Keys.Back) Then
            e.KeyChar = ""
        End If
    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtci.TextChanged

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnatras.Click

        If (lbltipou.Text = "Docente") Then
            cmbturno.SelectedIndex = 0
            txtnombre.Clear()
            txtci.Clear()
            menupdoc.Show()
            Me.Hide()
        End If
        If (lbltipou.Text = "Secretario Escolar") Then
            cmbturno.SelectedIndex = 0
            txtnombre.Clear()
            txtci.Clear()
            menureportse.Show()
            Me.Hide()
        End If

    End Sub

    Private Sub Button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btbclose.Click
        Select Case MsgBox("Desea cerrar sesión?", MsgBoxStyle.YesNo)
            Case MsgBoxResult.Yes
                cmbturno.SelectedIndex = 0
                txtnombre.Clear()
                txtci.Clear()
                login.cmbpass.SelectedIndex = 0
                login.cmbnomu.SelectedIndex = 0
                login.Show()
                Me.Hide()
            Case MsgBoxResult.No
                Me.Hide()
                Me.Show()
        End Select
    End Sub

    Private Sub cmbturno_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbturno.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
        If (e.KeyChar < "0" Or e.KeyChar > "9") And e.KeyChar <> Chr(Keys.Back) Then
            e.KeyChar = ""
        End If
    End Sub

    Private Sub cmbturno_ParentChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbturno.ParentChanged

    End Sub

    Private Sub cmbturno_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbturno.SelectedIndexChanged

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
End Class