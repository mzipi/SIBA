Public Class iReporte2

    Private Sub iReporte2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CrystalReportViewer1.ReportSource = My.Application.Info.DirectoryPath + "\..\..\i2Reporte.rpt"
        OpenFileDialog1.InitialDirectory = My.Application.Info.DirectoryPath + "\..\..\i2Reporte.rpt("")"
    End Sub
End Class