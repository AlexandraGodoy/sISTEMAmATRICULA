﻿Imports System.Data.OleDb
Public Class frmGrafica
    Private Sub frmGrafica_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim con As New OleDbConnection("Provider=Microsoft.Jet.OleDb.4.0; Data Source=E:\Programación3\SegundoParcial\basededatos\matriculaINUED(2002-2003).mdb")
        Try

            con.Open()
            MsgBox("Conectado")

            Dim query = "Select * from maestro"
            Dim adap As New OleDbDataAdapter(query, con)
            Dim dt As New DataTable
            adap.Fill(dt)

            Chart1.Series("Series1").XValueMember = "Nombre"
            Chart1.Series("Series1").YValueMembers = "EdadMaestro"
            Chart1.DataSource = dt
        Catch ex As Exception
            MsgBox("No se conectó por: " & ex.Message)
        End Try
    End Sub
End Class