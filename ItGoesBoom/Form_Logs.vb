Public Class Form_Logs
    Private Sub Btn_Clear_Click(sender As Object, e As EventArgs) Handles Btn_Clear.Click
        TextBox_Logs.Clear()
    End Sub

    Private Sub Btn_Save_Click(sender As Object, e As EventArgs) Handles Btn_Save.Click
        'Dumps the contents of TextBox_Log into a file
        Dim myStream As IO.StreamWriter
        Dim saveFileDialog1 As New SaveFileDialog()
        saveFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*"
        saveFileDialog1.RestoreDirectory = True
        If saveFileDialog1.ShowDialog() = DialogResult.OK Then
            myStream = New IO.StreamWriter(saveFileDialog1.FileName)
            If (myStream IsNot Nothing) Then
                Dim str As String() = TextBox_Logs.Text.Split(New [Char]() {CChar(vbCrLf)})
                For Each s As String In str
                    myStream.WriteLine(s)
                Next
                myStream.Close()
                Log("Wrote copy of log to : " & saveFileDialog1.FileName)
            Else
                MsgBox("Failed to open file for writing", MsgBoxStyle.Exclamation)
            End If
        End If
    End Sub
End Class