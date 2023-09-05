Imports System.Security.Cryptography
Imports System.IO
Imports System.Runtime.InteropServices

Module Program
    Sub Main(args As String())
        Dim key() As Byte = GenerateRandomKey()
        Dim iv() As Byte = GenerateRandomIV()

        Dim inputPath As String = ""
        Dim encryptedPath As String = ""
        Dim decryptedPath As String = ""

        Try
            ' Encrypt file
            EncryptFile(inputPath, encryptedPath, key, iv)

            Console.WriteLine("File has been encrypted!")

            ' Decrypt file
            DecryptFile(encryptedPath, decryptedPath, key, iv)

            Console.WriteLine("File has been decrypted!")
        Catch ex As Exception
            Console.WriteLine("Error occurred: " & ex.Message)
        End Try

        Console.WriteLine("Press any key to exit Crypta!")
        Console.ReadKey()
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
