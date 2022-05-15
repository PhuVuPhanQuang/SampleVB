

Imports System.ComponentModel
Imports System.Threading

Public Class frmCopy
    Dim filePath1 As String
    Dim filePath2 As String

    Private Sub FrmCopy_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        If BackgroundWorker1.IsBusy Then
            BackgroundWorker1.CancelAsync()
        End If
    End Sub

    Private Sub btnPath1_Click(sender As Object, e As EventArgs) Handles btnPath1.Click
        OpenFileDialog1.Title = "Select a file to copy"
        OpenFileDialog1.FileName = ""
        With OpenFileDialog1
            If .ShowDialog() = DialogResult.OK Then
                filePath1 = .FileName
                txtPath1.Text = filePath1.ToString
            End If
        End With
    End Sub

    Private Sub btnPath2_Click(sender As Object, e As EventArgs) Handles btnPath2.Click
        FolderBrowserDialog1.Description = "Select destiny directory"
        With FolderBrowserDialog1
            If .ShowDialog() = DialogResult.OK Then
                filePath2 = .SelectedPath
                txtPath2.Text = filePath2.ToString
            End If
        End With
    End Sub

    Private Sub btnCopy_Click(sender As Object, e As EventArgs) Handles btnCopy.Click
        btnPath1.Enabled = False
        btnPath2.Enabled = False
        BackgroundWorker1.RunWorkerAsync()
        'Timer1.Start()
    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork

        'Dim thread As New Thread(AddressOf DoStuff)
        'thread.Start()
        Dim worker As BackgroundWorker = TryCast(sender, BackgroundWorker)
        pbLoading.Minimum = 0
        pbLoading.Maximum = 100
        Dim parts As String() = filePath1.Split(New Char() {"\"c})
        Dim filename As String = parts(parts.Count - 1)
        Dim streamRead As New System.IO.FileStream(filePath1, System.IO.FileMode.Open)
        Dim streameWrite As New System.IO.FileStream(filePath2 + "\" + filename, IO.FileMode.Create, IO.FileAccess.Write, IO.FileShare.None)
        Dim lnglen As Long = streamRead.Length - 1
        Dim cur As Long = 0

        Dim byteBuffer(100) As Byte
        Dim intBytesRead As Integer
        'setTextboxTxt("Copy bytes: (0/" + (lnglen * 100).ToString + ")", txtPath1)
        While streamRead.Position < lnglen
            If (worker.CancellationPending = True) Then
                e.Cancel = True
                Exit While
            End If
            Console.WriteLine(streamRead.Position)
            'setTextboxTxt("Copy bytes: (" + CInt(streamRead.Position).ToString + "/" + (lnglen * 100).ToString + ")", txtPath2)
            intBytesRead = (streamRead.Read(byteBuffer, 0, 100))
            streameWrite.Write(byteBuffer, 0, intBytesRead)
            Dim per = CInt(streamRead.Position / lnglen * 100)
            worker.ReportProgress(per)
            Me.BeginInvoke(Sub() lblLoading.Text = per)


            Console.WriteLine(per)
        End While

        streameWrite.Flush()
        streameWrite.Close()
        streamRead.Close()

    End Sub
    Public Sub DoStuff()
        For i = 0 To 100
            Me.BeginInvoke(Sub() Me.pbLoading.PerformStep())
            'pbLoading.Value = pbLoading.Value + 1
            'lblLoading.Text = pbLoading.Value & "% Completing...."
        Next
    End Sub



    'Private Sub setTextboxTxt(ByVal text As String, ByVal txt As TextBox)
    '    If txt.InvokeRequired Then
    '        txt.Invoke(New setTextBoxTxtInvoker(AddressOf setTextboxTxt), text, txt)
    '    Else
    '        txt.Text = text
    '    End If
    'End Sub
    'Private Delegate Sub setTextBoxTxtInvoker(ByVal text As String, ByVal txt As TextBox)

    Private Sub BackgroundWorker1_ProgressChanged(sender As Object, e As System.ComponentModel.ProgressChangedEventArgs) Handles BackgroundWorker1.ProgressChanged
        pbLoading.Value = e.ProgressPercentage
    End Sub

    'Private Sub BackgroundWorker1_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
    '    If e.Cancelled = True Then
    '        Timer1.Stop()
    '        MsgBox("Copy cannceled!")
    '    End If
    '    btnPath1.Enabled = True
    '    btnPath2.Enabled = True
    'End Sub

    'Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
    '    If pbLoading.Value >= 100 Then
    '        pbLoading.Value = 0
    '        Timer1.Stop()
    '        MsgBox("Copy Complete!")
    '    Else
    '        pbLoading.Value = pbLoading.Value + 1
    '        lblLoading.Text = pbLoading.Value & "% Completing...."
    '    End If

    'End Sub

End Class