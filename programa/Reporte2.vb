Public Class Reporte2

    Private Sub Reporte2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CrystalReportViewer1.ReportSource = My.Application.Info.DirectoryPath + "\..\..\2Reporte.rpt"
        OpenFileDialog1.InitialDirectory = My.Application.Info.DirectoryPath + "\..\..\2Reporte.rpt("")"
    End Sub
End Class