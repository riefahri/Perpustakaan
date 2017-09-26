﻿Imports System.Data
Imports System.Data.OleDb
Public Class AboutMe

    Private Sub AboutMe_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim ApplicationTitle As String
        If My.Application.Info.Title <> "" Then
            ApplicationTitle = My.Application.Info.Title
        Else
            ApplicationTitle = System.IO.Path.GetFileNameWithoutExtension(My.Application.Info.AssemblyName)
        End If
        Me.Text = String.Format("About {0}", ApplicationTitle)
        ' Initialize all of the text displayed on the About Box.
        ' TODO: Customize the application's assembly information in the "Application" pane of the project 
        '    properties dialog (under the "Project" menu).
        Me.Label1.Text = My.Application.Info.ProductName
        Me.Label2.Text = String.Format("Version {0}", My.Application.Info.Version.ToString)
        Me.Label3.Text = My.Application.Info.Copyright
        Me.Label4.Text = My.Application.Info.CompanyName
        Me.TextBox1.Text = My.Application.Info.Description
    End Sub

End Class