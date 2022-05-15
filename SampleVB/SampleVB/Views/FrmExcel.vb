Imports System.IO
Imports ClosedXML.Excel

Public Class FrmExcel
    Private Sub btnXuat_Click(sender As Object, e As EventArgs) Handles btnXuat.Click

        Try

            Dim fileDes = txtFileDich.Text
            Dim Test As String = ""

            SaveFileDialog1.FileName = ""
            With SaveFileDialog1
                If .ShowDialog() = DialogResult.OK Then
                    fileDes = .FileName
                    txtFileDich.Text = fileDes.ToString
                End If
            End With
            Dim a = ExportFile.DataGridViewToCsv(fileDes, dgvSinhVien)
            MessageBox.Show("You have successfully exported your data to an excel file", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try

    End Sub

    Private Sub btnThemDuLieu_Click(sender As Object, e As EventArgs) Handles btnThemDuLieu.Click
        Try
            Dim insertmultirows As New InsertMultiRows()
            InsertMultiRows.DataGridViewToCsv(dgvSinhVien)
            MessageBox.Show("You have successfully inserted your data to database", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try


    End Sub


    Private Sub FrmExcel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DemoDataSet.SINHVIEN' table. You can move, or remove it, as needed.
        'Me.SINHVIENTableAdapter.Fill(Me.DemoDataSet.SINHVIEN)

    End Sub

    Dim separator As String
    Private Sub DGVSinhVien_DragDrop(sender As Object, e As DragEventArgs) Handles dgvSinhVien.DragDrop
        Try

            'Dim separator As String = ";"
            Dim isTitle As Boolean
            Dim dropObjs As String() = (e.Data.GetData(DataFormats.FileDrop))
            If dropObjs.Length > 0 Then

                Dim Path = dropObjs.GetValue(0)
                txtFilePath.Text = dropObjs.GetValue(0)
                ReadFile.ReadCsvToDgv(Path, dgvSinhVien, isTitle)
            End If
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try
    End Sub

    Private Sub DGVSinhVien_DragEnter(sender As Object, e As DragEventArgs) Handles dgvSinhVien.DragEnter
        If e.Data.GetDataPresent(DataFormats.FileDrop) <> False Then
            e.Effect = DragDropEffects.Copy
        End If
    End Sub


End Class