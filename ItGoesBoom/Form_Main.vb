Public Class Form_Main
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub LogsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogsToolStripMenuItem.Click
        Form_Logs.Show()
    End Sub

    Private Sub BulletLibraryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BulletLibraryToolStripMenuItem.Click
        Form_Bullets.Show()
    End Sub

    Private Sub BrassLibraryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BrassLibraryToolStripMenuItem.Click
        Form_Brass.Show()
    End Sub

    Private Sub PowderLibraryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PowderLibraryToolStripMenuItem.Click
        Form_Powders.Show()
    End Sub

    Private Sub PrimerLibraryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrimerLibraryToolStripMenuItem.Click
        Form_Primers.Show()
    End Sub

End Class
