Public Class ingresogrupo2
    Public Sub New()
        InitializeComponent()

        Dim toolTip As New ToolTip
        toolTip.SetToolTip(PictureBox1, "CONSULTE DISPONIBILIDAD DE HORAS DE SALON ")

    End Sub
    Private Sub ingresogrupo2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        gbxdispact.Visible = False
        gbxdispinst.Visible = False
    End Sub

    Private Sub lblrol_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblrol.Click

    End Sub

    Private Sub lbltipou_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbltipou.Click

    End Sub

    Private Sub btnclose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclose.Click
        Select Case MsgBox("Desea cerrar sesión?", MsgBoxStyle.YesNo)
            Case MsgBoxResult.Yes
                gbxdispact.Visible = False
                gbxdispinst.Visible = False
                gbxnecsalon.Visible = True
                login.cmbpass.SelectedIndex = 0

                login.cmbnomu.SelectedIndex = 0
                login.Show()
                Me.Hide()
            Case MsgBoxResult.No
                Me.Hide()
                Me.Show()
        End Select

    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        gbxnecsalon.Visible = False
        gbxdispinst.Visible = True
        gbxdispinst.SetBounds(21, 79, 284, 252)
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        gbxdispinst.Visible = False
        gbxdispact.Visible = True

    End Sub

    Private Sub gbxdispinst_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gbxdispinst.Enter

    End Sub

    Private Sub btnsiba_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsiba.Click
        gbxdispact.Visible = False
        gbxdispinst.Visible = False
        gbxnecsalon.Visible = True

        menupse.Show()
        Me.Hide()
    End Sub

    Private Sub btnabmgrup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnabmgrup.Click
        gbxdispact.Visible = False
        gbxdispinst.Visible = False
        gbxnecsalon.Visible = True
        abmGrupo.Show()
        Me.Hide()

    End Sub

    Private Sub btnconf_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnconf.Click
        MsgBox("INGRESO EXITOSO")

    End Sub
End Class