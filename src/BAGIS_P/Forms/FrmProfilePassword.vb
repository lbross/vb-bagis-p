﻿Imports System.Windows.Forms

Public Class FrmProfilePassword

    Dim m_adminPassword As String = "NWCC_PSU"
    Dim m_frmProfile As FrmProfileBuilder
    Dim m_frmDataManager As FrmDataManager
    Dim m_frmAddData As FrmAddData

    Public Sub New()
        InitializeComponent()
        TxtPassword.Focus()
    End Sub

    Private Sub BtnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub

    Private Sub BtnEnter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEnter.Click
        Dim pExt As BagisPExtension = BagisPExtension.GetExtension
        If TxtPassword.Text.Equals(m_adminPassword) Then
            'Set admin role to true in BagisP extension
            pExt.ProfileAdministrator = True
            Me.Close()
        Else
            pExt.ProfileAdministrator = False
            MessageBox.Show("The password you supplied was invalid", "Invalid Password", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
End Class