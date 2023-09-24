Imports System.IO
Imports System.Text.RegularExpressions
Imports Microsoft.Win32
Imports System.Xml
Module Routines
    Public Sub Log(ByVal logline As String)
        Form_Logs.TextBox_Logs.AppendText(DateTime.Now & " - " & logline & vbNewLine)
    End Sub
End Module