'  SAP DI API 2006 Sample
'****************************************************************************
'
'  File:      StartupForm.vb
'
'  Copyright (c) SAP 
'
' THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY OF
' ANY KIND, EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO
' THE IMPLIED WARRANTIES OF MERCHANTABILITY AND/OR FITNESS FOR A
' PARTICULAR PURPOSE.
'
'****************************************************************************

Public Class StartupForm
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.Container

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents cmdLogOut As System.Windows.Forms.Button
    Friend WithEvents cmdLogIn As System.Windows.Forms.Button
    Friend WithEvents cmdApprovalTemplates As System.Windows.Forms.Button
    Friend WithEvents cmdApprovalStages As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.cmdLogOut = New System.Windows.Forms.Button
        Me.cmdLogIn = New System.Windows.Forms.Button
        Me.cmdApprovalTemplates = New System.Windows.Forms.Button
        Me.cmdApprovalStages = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'cmdLogOut
        '
        Me.cmdLogOut.Location = New System.Drawing.Point(72, 208)
        Me.cmdLogOut.Name = "cmdLogOut"
        Me.cmdLogOut.Size = New System.Drawing.Size(120, 48)
        Me.cmdLogOut.TabIndex = 0
        Me.cmdLogOut.Text = "Exit"
        '
        'cmdLogIn
        '
        Me.cmdLogIn.Location = New System.Drawing.Point(72, 16)
        Me.cmdLogIn.Name = "cmdLogIn"
        Me.cmdLogIn.Size = New System.Drawing.Size(120, 48)
        Me.cmdLogIn.TabIndex = 0
        Me.cmdLogIn.Text = "Log In Company"
        '
        'cmdApprovalTemplates
        '
        Me.cmdApprovalTemplates.Location = New System.Drawing.Point(72, 144)
        Me.cmdApprovalTemplates.Name = "cmdApprovalTemplates"
        Me.cmdApprovalTemplates.Size = New System.Drawing.Size(120, 48)
        Me.cmdApprovalTemplates.TabIndex = 0
        Me.cmdApprovalTemplates.Text = "Approval Templates"
        '
        'cmdApprovalStages
        '
        Me.cmdApprovalStages.Location = New System.Drawing.Point(72, 80)
        Me.cmdApprovalStages.Name = "cmdApprovalStages"
        Me.cmdApprovalStages.Size = New System.Drawing.Size(120, 48)
        Me.cmdApprovalStages.TabIndex = 1
        Me.cmdApprovalStages.Text = "Approval Stages"
        '
        'StartupForm
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(7, 17)
        Me.ClientSize = New System.Drawing.Size(264, 279)
        Me.Controls.Add(Me.cmdApprovalStages)
        Me.Controls.Add(Me.cmdLogOut)
        Me.Controls.Add(Me.cmdApprovalTemplates)
        Me.Controls.Add(Me.cmdLogIn)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "StartupForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Main"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub cmdLogIn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdLogIn.Click

        Dim frm As New LogInForm

        'show log in dialog
        frm.ShowDialog()

        Call InitCmdButtons(True, True, True)

    End Sub

    Private Sub cmdMsg_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdApprovalTemplates.Click

        Dim frm As New ApprovalTemplateForm

        'show message dialog
        frm.ShowDialog()

    End Sub

    Private Sub StartupForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Call InitCmdButtons(True, False, False)

    End Sub

    Private Sub InitCmdButtons(ByVal bLogIn As Boolean, ByVal bGeneral As Boolean, ByVal bLogOut As Boolean)

        cmdLogIn.Enabled = bLogIn
        cmdApprovalStages.Enabled = bGeneral
        cmdApprovalTemplates.Enabled = bGeneral
        cmdLogOut.Enabled = bLogOut

    End Sub

    Private Sub cmdLogOut_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdLogOut.Click

        Me.Close()

    End Sub


    Private Sub cmdApprovalStages_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdApprovalStages.Click

        Dim frm As New ApprovalStagesForm

        'show message dialog
        frm.ShowDialog()

    End Sub
End Class

