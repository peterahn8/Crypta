Imports System.Security.Cryptography
Imports System.IO
Imports System.Runtime.InteropServices

Module Program
    Sub Main(args As String())
        Dim key() As Byte = GenerateRandomKey()
        Dim iv() As Byte = GenerateRandomIV()

        Dim inputPath As String = ""
        Dim encryptedPath As String = ""
        Dim decrypedPath As String = ""

        Try
            EncryptFile(inputPath, encryptedPath, key, iv)

        Catch ex As Exception

        End Try
    End Sub

    Function GenerateRandomKey() As Byte()

    End Function

    Function GenerateRandomIV() As Byte()

    End Function

    Sub EncryptFile(inputPath As String, outputPath As String, key As Byte(), iv As Byte())

    End Sub

    Sub DecryptFile(inputPath As String, outputPath As String, key As Byte(), iv As Byte())

    End Sub
End Module
