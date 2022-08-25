Imports System
Imports EmailLib
Imports EmailLib.Services
Imports NETCore.MailKit.Core

Module Program
    Sub Main(args As String())

        Dim message As Message = New Message()
        message.Body = "Привіт <b>козак</b>!"
        message.Subject = "Мені уже 18 :)"
        message.To = "novakvova@gmail.com"

        Dim sender As SmtpEmailService = New SmtpEmailService()
        sender.Send(message)


    End Sub
End Module
