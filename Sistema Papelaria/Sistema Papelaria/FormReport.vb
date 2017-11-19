Public Class FormReport

    Private Sub FormReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'papelariaDBDataSet.tb_compra' table. You can move, or remove it, as needed.
        Me.tb_compraTableAdapter.Fill(Me.papelariaDBDataSet.tb_compra)

        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub VendedorQueryToolStripButton_Click(sender As Object, e As EventArgs) Handles VendedorQueryToolStripButton.Click
        Try
            Me.tb_compraTableAdapter.vendedorQuery(Me.papelariaDBDataSet.tb_compra, VendedorToolStripTextBox.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub
End Class