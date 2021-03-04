Public Class iconsultademateria

    Private Sub iconsultademateria_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CrystalReportViewer1.ReportSource = My.Application.Info.DirectoryPath + "\..\..\i4consultadelamateria.rpt"
        OpenFileDialog1.InitialDirectory = My.Application.Info.DirectoryPath + "\..\..\i4consultadelamateria.rpt("")"
    End Sub
End Class