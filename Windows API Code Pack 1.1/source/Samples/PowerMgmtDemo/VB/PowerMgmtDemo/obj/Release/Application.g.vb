﻿#ExternalChecksum("..\..\Application.xaml","{8829d00f-11b8-4213-878b-770e8597ac16}","CAE1EA8EF52251ECA93D85462EF6D0009CDD7E9C654C5A17E1CD732C1C373034")
'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.42000
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict Off
Option Explicit On

Imports System
Imports System.Diagnostics
Imports System.Windows
Imports System.Windows.Automation
Imports System.Windows.Controls
Imports System.Windows.Controls.Primitives
Imports System.Windows.Data
Imports System.Windows.Documents
Imports System.Windows.Ink
Imports System.Windows.Input
Imports System.Windows.Markup
Imports System.Windows.Media
Imports System.Windows.Media.Animation
Imports System.Windows.Media.Effects
Imports System.Windows.Media.Imaging
Imports System.Windows.Media.Media3D
Imports System.Windows.Media.TextFormatting
Imports System.Windows.Navigation
Imports System.Windows.Shapes

Namespace Microsoft.WindowsAPICodePack.Samples.PowerMgmtDemoApp
    
    '''<summary>
    '''App
    '''</summary>
    Partial Public Class App
        Inherits System.Windows.Application
        
        '''<summary>
        '''InitializeComponent
        '''</summary>
        <System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")>  _
        Public Sub InitializeComponent()
            
            #ExternalSource("..\..\Application.xaml",6)
            Me.StartupUri = New System.Uri("Window1.xaml", System.UriKind.Relative)
            
            #End ExternalSource
        End Sub
        
        '''<summary>
        '''Application Entry Point.
        '''</summary>
        <System.STAThreadAttribute(),  _
         System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")>  _
        Public Shared Sub Main()
            Dim app As Microsoft.WindowsAPICodePack.Samples.PowerMgmtDemoApp.App = New Microsoft.WindowsAPICodePack.Samples.PowerMgmtDemoApp.App()
            app.InitializeComponent
            app.Run
        End Sub
    End Class
End Namespace

