Imports System.IO

Public Class FrmExcel
    Private Sub btnThemData_Click(sender As Object, e As EventArgs) Handles btnThemData.Click

    End Sub

    Private Sub btnXuat_Click(sender As Object, e As EventArgs) Handles btnXuat.Click
        'Using sfd As SaveFileDialog = New SaveFileDialog()
        '    If sfd.ShowDialog() = DialogResult.OK Then
        '        Try
        '            Dim writer As New StreamWriter(sfd)
        '            For i As Integer = 0 To DGVSinhVien.Rows.Count - 2 Step +1
        '                For j As Integer = 0 To DGVSinhVien.Columns.Count - 1 Step +1
        '                    writer.Write(vbTab & DGVSinhVien.Rows(i).Cells(j).Value.ToString() & vbTab & "|")
        '                Next j
        '                writer.WriteLine("")
        '            Next i
        '            writer.Close()
        '            'MessageBox.Show("Data Exported")

        '            MessageBox.Show("You have successfully exported your data to an excel file.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
        '        Catch ex As Exception
        '            MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '        End Try
        '    End If
        'End Using
    End Sub

    Private Sub FrmExcel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DemoDataSet.SINHVIEN' table. You can move, or remove it, as needed.
        Me.SINHVIENTableAdapter.Fill(Me.DemoDataSet.SINHVIEN)

    End Sub

    Private Sub DGVSinhVien_DragDrop(sender As Object, e As DragEventArgs) Handles DGVSinhVien.DragDrop

    End Sub

    Private Sub DGVSinhVien_DragEnter(sender As Object, e As DragEventArgs) Handles DGVSinhVien.DragEnter

    End Sub
End Class