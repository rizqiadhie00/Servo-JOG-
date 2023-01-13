Imports System.Net.Sockets
Imports System.Threading

Public Class MainForm
    '*******************************************************************************
    '* Stop polling when the form is not visible in order to reduce communications
    '* Copy this section of code to every new form created
    '*******************************************************************************
    Private NotFirstShow As Boolean
    Dim Quantity As Integer = 0
    Dim CounterR As Integer = 0
    Dim CounterF As Integer = 0
    Dim CommandTotal As String
    Dim clientSocket As New System.Net.Sockets.TcpClient()
    Dim serverStream As NetworkStream

    Dim dataAkhir2 As String
    Dim dataAkhir3 As String
    Dim Hex1 As Integer
    Dim Hex2 As Integer
    Dim finalH As Single
    Dim bit As String
    Dim buffSize As Integer



    Private Sub Form_VisibleChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.VisibleChanged
        '* Do not start comms on first show in case it was set to disable in design mode
        If NotFirstShow Then
            AdvancedHMIDrivers.Utilities.StopComsOnHidden(components, Me)
        Else
            NotFirstShow = True
        End If
    End Sub



    '***************************************************************
    '* .NET does not close hidden forms, so do it here
    '* to make sure forms are disposed and drivers close
    '***************************************************************
    Private Sub MainForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Dim index As Integer
        While index < My.Application.OpenForms.Count
            If My.Application.OpenForms(index) IsNot Me Then
                My.Application.OpenForms(index).Close()
            End If
            index += 1
        End While
    End Sub

    Public Function Hex_Change(Dex As String)
        If (Dex <> "") Then
            Dim number As String = Dex.Remove(0, 23)
            Dim number_1 As String = number.Remove(4, 7)
            Dim number_2 As String = number.Remove(0, 3)


            Hex1 = Val("&H" & number_1)
            Hex2 = Val("&H" & number_2)

            Dim var1 = BitConverter.GetBytes(Hex1)
            Dim var2 = BitConverter.GetBytes(Hex2)

            Dim temp2(4) As Byte
            temp2(0) = var1(0)
            temp2(1) = var1(1)
            temp2(2) = var2(0)
            temp2(3) = var2(1)

            finalH = BitConverter.ToSingle(temp2, 0)
        End If

        Return finalH
    End Function

    Private Sub FirstRead()
        Dim inStream2(65536) As Byte
        buffSize = clientSocket.ReceiveBufferSize
        serverStream.Read(inStream2, 0, buffSize)
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (TextBox3.Text <> "" And TextBox4.Text <> "") Then
            clientSocket.Connect(TextBox3.Text, TextBox4.Text)
        End If
        If (clientSocket.Connected = True) Then
            TextBox1.Text = "Connected ..."
            Timer1.Enabled = True

        End If
    End Sub

    Public Sub Hex_Write(DeviceNumber As String, Value As Integer)
        Dim cmd As String
        Dim Hex As String
        cmd = "500000FF03FF00001C000814010000D*" + DeviceNumber + "0001"
        Hex = Convert.ToString(Value, 16)
        Select Case Hex.Length
            Case 1
                cmd = cmd + "000" + Hex
            Case 2
                cmd = cmd + "00" + Hex
            Case 3
                cmd = cmd + "0" + Hex
            Case Else
                cmd = cmd + Hex
        End Select


        Dim command As Byte() = System.Text.Encoding.ASCII.GetBytes(cmd)
        serverStream.Write(command, 0, command.Length)
        serverStream.Flush()

    End Sub

    Public Function bit_Read(DN As String)
        Dim ASU As String = "500000FF03FF000018000804010001Y*" + DN + "0001"
        Dim command As Byte() = System.Text.Encoding.ASCII.GetBytes(ASU)
        serverStream.Write(command, 0, command.Length)
        Thread.Sleep(40)
        Dim inStream(65536) As Byte
        buffSize = clientSocket.ReceiveBufferSize
        serverStream.Read(inStream, 0, buffSize)

        Dim bit As String
        Dim Data As String
        Dim dataAkhir As String = System.Text.Encoding.ASCII.GetString(inStream)
        Data = dataAkhir.Chars(22)


        If (Data = "1") Then
            bit = 1
        ElseIf (Data = "0") Then
            bit = 0
        ElseIf (Data = "D") Then
            Data = dataAkhir.Chars(44)
            If (Data = "1") Then
                bit = 1
            ElseIf (Data = "0") Then
                bit = 0
            End If
        End If
        Return bit
    End Function
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If (clientSocket.Connected) Then
            serverStream = clientSocket.GetStream()
            Dim a, b, c, d As Short
            a = bit_Read("000049")

            b = bit_Read("000048")

            c = bit_Read("000040")

            d = bit_Read("000041")

            If (TextBox6.Text <> "") Then
                Hex_Write("000300", TextBox6.Text)
            End If



            If (a = 1) Then
                PilotLight1.Value = 1
            ElseIf (a = 0) Then
                PilotLight1.Value = 0
            End If

            If (b = 1) Then
                PilotLight3.Value = 1
            ElseIf (b = 0) Then
                PilotLight3.Value = 0
            End If

            If (c = 1) Then
                TextBox2.Text = "Ready"
            End If

            If (d = 1) Then
                TextBox5.Text = "Ready"
            End If



        End If
    End Sub


    Private Sub BasicButton2_Click(sender As Object, e As EventArgs) Handles BasicButton2.MouseDown
        Dim command As Byte() = System.Text.Encoding.ASCII.GetBytes("500000FF03FF000019000814010001M*00010000011")

        serverStream.Write(command, 0, command.Length)
        serverStream.Flush()
    End Sub

    Private Sub BasicButton2_Click2(sender As Object, e As EventArgs) Handles BasicButton2.MouseUp
        Dim command As Byte() = System.Text.Encoding.ASCII.GetBytes("500000FF03FF000019000814010001M*00010000010")

        serverStream.Write(command, 0, command.Length)
        serverStream.Flush()
    End Sub


    Private Sub BasicButton5_Click(sender As Object, e As EventArgs) Handles BasicButton5.MouseDown
        Dim command As Byte() = System.Text.Encoding.ASCII.GetBytes("500000FF03FF000019000814010001M*00010100011")

        serverStream.Write(command, 0, command.Length)
        serverStream.Flush()
    End Sub

    Private Sub BasicButton5_Click2(sender As Object, e As EventArgs) Handles BasicButton5.MouseUp
        Dim command As Byte() = System.Text.Encoding.ASCII.GetBytes("500000FF03FF000019000814010001M*00010100010")

        serverStream.Write(command, 0, command.Length)
        serverStream.Flush()
    End Sub

    Private Sub BasicButton1_Click(sender As Object, e As EventArgs) Handles BasicButton1.MouseDown
        Dim command As Byte() = System.Text.Encoding.ASCII.GetBytes("500000FF03FF000019000814010001M*00040000011")

        serverStream.Write(command, 0, command.Length)
        serverStream.Flush()
    End Sub


    Private Sub BasicButton3_Click(sender As Object, e As EventArgs) Handles BasicButton3.MouseDown
        Dim command As Byte() = System.Text.Encoding.ASCII.GetBytes("500000FF03FF000019000814010001M*00040300011")

        serverStream.Write(command, 0, command.Length)
        serverStream.Flush()
    End Sub


    Private Sub BasicButton4_Click(sender As Object, e As EventArgs) Handles BasicButton4.MouseDown
        Dim command As Byte() = System.Text.Encoding.ASCII.GetBytes("500000FF03FF000019000814010001M*00040400011")

        serverStream.Write(command, 0, command.Length)
        serverStream.Flush()
    End Sub

    Private Sub BasicButton4_Click2(sender As Object, e As EventArgs) Handles BasicButton4.MouseUp
        Dim command As Byte() = System.Text.Encoding.ASCII.GetBytes("500000FF03FF000019000814010001M*00040400010")

        serverStream.Write(command, 0, command.Length)
        serverStream.Flush()
    End Sub


    Private Sub BasicButton6_Click(sender As Object, e As EventArgs) Handles BasicButton6.Click
        Dim command As Byte() = System.Text.Encoding.ASCII.GetBytes("500000FF03FF000019000814010001M*00040000010")

        serverStream.Write(command, 0, command.Length)
        serverStream.Flush()
    End Sub

    Private Sub BasicButton7_Click(sender As Object, e As EventArgs) Handles BasicButton7.Click
        Dim command As Byte() = System.Text.Encoding.ASCII.GetBytes("500000FF03FF000019000814010001M*00040300010")

        serverStream.Write(command, 0, command.Length)
        serverStream.Flush()
    End Sub

    Private Sub BasicButton5_Click_1(sender As Object, e As EventArgs) Handles BasicButton5.Click

    End Sub
End Class
