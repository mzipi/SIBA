Public Class modMateria

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Form30_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cmbtipo.SelectedIndex = 2
        cmbcargah.SelectedIndex = 5
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnatras.Click

        abmMateria.ltvmatcar.SelectedItems.Clear()
        abmMateria.Show()
        Me.Hide()
    End Sub

    Private Sub lblclose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblclose.Click
        Select Case MsgBox("Desea cerrar sesión?", MsgBoxStyle.YesNo)
            Case MsgBoxResult.Yes
                abmMateria.ltvmatcar.SelectedItems.Clear()
                login.cmbpass.SelectedIndex = 0
                login.cmbnomu.SelectedIndex = 0

                login.Show()
                Me.Hide()
            Case MsgBoxResult.No
                Me.Hide()
                Me.Show()
        End Select
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnmod.Click
        If (txtcod.Text = "") Then
            MsgBox("Debe ingresar un código")
        End If
        If (txtnombre.Text = "") Then
            MsgBox("Debe ingresar un nombre")
        End If
        If (cmbtipo.SelectedIndex = 0) Then
            MsgBox("Debe seleccionar un tipo de materia")
        End If
        If (cmbcargah.SelectedIndex = 0) Then
            MsgBox("Debe seleccionar una carga horaria para la materia")
        End If
        If (txtnomcar.Text = "") Then
            MsgBox("Debe ingresar un nombre de carrera")
        End If

        If txtcod.Text <> "" And txtnombre.Text <> "" And cmbtipo.SelectedIndex <> 0 And cmbcargah.SelectedIndex <> 0 And txtnomcar.Text <> "" Then
            abmMateria.ltvmatcar.SelectedItems.Clear()
            MsgBox("Modificación exitosa")
            abmMateria.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub txtcod_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtcod.TextChanged

    End Sub

    Private Sub txtnombre_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtnombre.TextChanged

    End Sub
End Class