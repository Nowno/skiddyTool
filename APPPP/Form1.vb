Imports System
Imports System.IO
Public Class Form1
    Private Sub FlatButton1_Click(sender As Object, e As EventArgs) Handles FlatButton1.Click
        Dim myfiledlog As New OpenFileDialog
        myfiledlog.InitialDirectory = "C:\"
        myfiledlog.Filter = "TextFiles *.txt*|*.txt*"
        myfiledlog.FilterIndex = 2
        myfiledlog.RestoreDirectory = True
        If myfiledlog.ShowDialog() =
               DialogResult.OK Then
                If Dir(myfiledlog.FileName) <> "" Then
                    MsgBox("Imported " & myfiledlog.FileName)

                Else
                    MsgBox("File Not found ", vbCritical)

                End If
            End If
            FlatTextBox1.Text = myfiledlog.FileName

    End Sub

    Private Sub FlatButton2_Click(sender As Object, e As EventArgs) Handles FlatButton2.Click
        Dim path As String = "C:\$Recycle.Bin"
        Dim dt As DateTime = Directory.GetLastWriteTime(path)
        MsgBox(dt)
    End Sub

    Private Sub FlatButton3_Click(sender As Object, e As EventArgs) Handles FlatButton3.Click
        If FlatTextBox1.Text = "" Then
            MsgBox("Please select a file")

        Else
            Dim findstring = IO.File.ReadAllText(FlatTextBox1.Text)
            If findstring.Contains("d[<N6") Then
                MsgBox("Found wetnoodle", MsgBoxStyle.Critical)
            End If
            If findstring.Contains("avatarsmokeweedeveryday420") Then
                MsgBox("Found magneta", MsgBoxStyle.Critical)
            Else
                MsgBox("Clean if no error")
            End If
        End If

    End Sub
End Class
