Option Strict On
Option Infer Off
Option Explicit On

'Name Ice cream haven
'Purpose: Display images for different flavors of Ice cream
'Programmer: Will Young on 2/6


Public Class frmMain
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstFlavors.SelectedIndexChanged
        If lstFlavors.SelectedItem Is "Vanilla" Then
            picImage.Image = My.Resources.vanilla
        ElseIf lstFlavors.SelectedItem Is "Chocolate" Then
            picImage.Image = My.Resources.choco
        ElseIf lstFlavors.SelectedItem Is "Strawberry" Then
            picImage.Image = My.Resources.straw
        ElseIf lstFlavors.SelectedItem Is "Rocky Road" Then
            picImage.Image = My.Resources.rocky
        ElseIf lstFlavors.SelectedItem Is "Oreo" Then
            picImage.Image = My.Resources.oreo
        End If
    End Sub
End Class


