﻿'created by: Perez, J.P.
'BSIT-3F
'Group 5

Imports MySql.Data.MySqlClient

Public Class AdmRegister
    Dim connect As MySqlConnection
    'localhost
    'Dim constring As String = "server = localhost; userid = root; DATABASE = votingsystem_perez"

    'online db
    Dim constring As String = "server=db4free.net; userid=patricc; password=votingsystem; database=voting_system; port=3306; old guids = true;"

    Dim cmd As MySqlCommand

    'pang clear sa form
    Public Sub Clearballot()
        firstname.Clear()
        middlename.Clear()
        lastname.Clear()
        cboxCourse.SelectedIndex = -1
        cboxYear.SelectedIndex = -1
        email.Clear()
        pass.Clear()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If firstname.Text = "" Or lastname.Text = "" Or middlename.Text = "" Or cboxCourse.Text = "" Or cboxYear.Text = "" Or email.Text = "" Or pass.Text = "" Then
            MessageBox.Show("fill up all fields to continue.", "Error!")
        Else
            Try
                connect = New MySqlConnection(constring)
                connect.Open()
                Dim SQL As String =
                    "INSERT INTO voters (First_name, Last_name, Middle_name, Course, Yr, Email, Pass) 
                values('" & firstname.Text & "','" & lastname.Text & "','" & middlename.Text & "','" & cboxCourse.Text & "','" & cboxYear.Text & "','" & email.Text & "', '" & pass.Text & "');"
                Dim cmd = New MySqlCommand(SQL, connect)
                Dim i As Integer = cmd.ExecuteNonQuery

                If i <> 0 Or firstname.Text IsNot "" Then
                    MsgBox("Student registered successfully!", vbInformation, "Admin")
                    'Call Clearballot()
                    'shows if registration is successful
                Else
                    MsgBox("Error!", vbCritical, "Admin")
                End If
                Call Clearballot()
                connect.Close()

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
        'Call Clearballot()

    End Sub

    'return
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        AdmMenu.Show()
        Call Clearballot()
        Me.Hide()
    End Sub

    Private Sub stdnum_KeyPress(sender As Object, e As KeyPressEventArgs)
        'para number lang input
        '    If IsNumeric(stdnum.Text) Then
        'Do nothing 
        '   Else
        'display error message
        '           MsgBox("Only numbers are allowed", vbCritical, "Error!")
        'clear textbox 
        '   stdnum.Clear()
        'End If
    End Sub

End Class