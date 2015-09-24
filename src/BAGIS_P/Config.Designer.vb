'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.34209
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict Off
Option Explicit On

Imports ESRI.ArcGIS.ArcMapUI
Imports ESRI.ArcGIS.Desktop.AddIns
Imports ESRI.ArcGIS.Framework
Imports System
Imports System.Collections.Generic

Namespace My
    
    '''<summary>
    '''A class for looking up declarative information in the associated configuration xml file (.esriaddinx).
    '''</summary>
    Friend Module ThisAddIn
        
        Friend ReadOnly Property Name() As String
            Get
                Return "BAGIS_P"
            End Get
        End Property
        
        Friend ReadOnly Property AddInID() As String
            Get
                Return "{1d026ddc-9aa9-4e39-84ac-7bb57a97d4b2}"
            End Get
        End Property
        
        Friend ReadOnly Property Company() As String
            Get
                Return "Portland State University"
            End Get
        End Property
        
        Friend ReadOnly Property Version() As String
            Get
                Return "1.8.0"
            End Get
        End Property
        
        Friend ReadOnly Property Description() As String
            Get
                Return "Generate parameters from BAGIS-H for model"
            End Get
        End Property
        
        Friend ReadOnly Property Author() As String
            Get
                Return "Lesley Bross and Geoffrey Duh"
            End Get
        End Property
        
        Friend ReadOnly Property [Date]() As String
            Get
                Return "9/24/2015"
            End Get
        End Property
        
        '''<summary>
        '''A class for looking up Add-in id strings declared in the associated configuration xml file (.esriaddinx).
        '''</summary>
        Friend Class IDs
            
            '''<summary>
            '''Returns 'Portland_State_University_BAGIS_P_BtnGroupProfile', the id declared for Add-in Button class 'BtnPublicProfileBuilder'
            '''</summary>
            Friend Shared ReadOnly Property BtnPublicProfileBuilder() As String
                Get
                    Return "Portland_State_University_BAGIS_P_BtnGroupProfile"
                End Get
            End Property
            
            '''<summary>
            '''Returns 'Portland_State_University_BAGIS_P_BtnDataLayerManager', the id declared for Add-in Button class 'BtnDataManager'
            '''</summary>
            Friend Shared ReadOnly Property BtnDataManager() As String
                Get
                    Return "Portland_State_University_BAGIS_P_BtnDataLayerManager"
                End Get
            End Property
            
            '''<summary>
            '''Returns 'Portland_State_University_BAGIS_P_BtnParameterManager', the id declared for Add-in Button class 'BtnLocalProfileBuilder'
            '''</summary>
            Friend Shared ReadOnly Property BtnLocalProfileBuilder() As String
                Get
                    Return "Portland_State_University_BAGIS_P_BtnParameterManager"
                End Get
            End Property
            
            '''<summary>
            '''Returns 'Portland_State_University_BAGIS_P_BtnLocalDataManager', the id declared for Add-in Button class 'BtnLocalDataManager'
            '''</summary>
            Friend Shared ReadOnly Property BtnLocalDataManager() As String
                Get
                    Return "Portland_State_University_BAGIS_P_BtnLocalDataManager"
                End Get
            End Property
            
            '''<summary>
            '''Returns 'Portland_State_University_BAGIS_P_BtnPublicMethodEditor', the id declared for Add-in Button class 'BtnPublicMethodEditor'
            '''</summary>
            Friend Shared ReadOnly Property BtnPublicMethodEditor() As String
                Get
                    Return "Portland_State_University_BAGIS_P_BtnPublicMethodEditor"
                End Get
            End Property
            
            '''<summary>
            '''Returns 'Portland_State_University_BAGIS_P_BtnParameterViewer', the id declared for Add-in Button class 'BtnParameterViewer'
            '''</summary>
            Friend Shared ReadOnly Property BtnParameterViewer() As String
                Get
                    Return "Portland_State_University_BAGIS_P_BtnParameterViewer"
                End Get
            End Property
            
            '''<summary>
            '''Returns 'Portland_State_University_BAGIS_P_BtnAbout', the id declared for Add-in Button class 'BtnAbout'
            '''</summary>
            Friend Shared ReadOnly Property BtnAbout() As String
                Get
                    Return "Portland_State_University_BAGIS_P_BtnAbout"
                End Get
            End Property
            
            '''<summary>
            '''Returns 'Portland_State_University_BAGIS_P_BtnHelp', the id declared for Add-in Button class 'BtnHelp'
            '''</summary>
            Friend Shared ReadOnly Property BtnHelp() As String
                Get
                    Return "Portland_State_University_BAGIS_P_BtnHelp"
                End Get
            End Property
            
            '''<summary>
            '''Returns 'Portland_State_University_BAGIS_P_BtnExportParametersEwsf', the id declared for Add-in Button class 'BtnExportParametersEwsf'
            '''</summary>
            Friend Shared ReadOnly Property BtnExportParametersEwsf() As String
                Get
                    Return "Portland_State_University_BAGIS_P_BtnExportParametersEwsf"
                End Get
            End Property
            
            '''<summary>
            '''Returns 'Portland_State_University_BAGIS_P_BtnSubAOIIdTool', the id declared for Add-in Button class 'BtnSubAOIIdTool'
            '''</summary>
            Friend Shared ReadOnly Property BtnSubAOIIdTool() As String
                Get
                    Return "Portland_State_University_BAGIS_P_BtnSubAOIIdTool"
                End Get
            End Property
            
            '''<summary>
            '''Returns 'Portland_State_University_BAGIS_P_BtnTimberlineTool', the id declared for Add-in Button class 'BtnTimberlineTool'
            '''</summary>
            Friend Shared ReadOnly Property BtnTimberlineTool() As String
                Get
                    Return "Portland_State_University_BAGIS_P_BtnTimberlineTool"
                End Get
            End Property
            
            '''<summary>
            '''Returns 'Portland_State_University_BAGIS_P_IdentifyTool', the id declared for Add-in Tool class 'IdentifyTool'
            '''</summary>
            Friend Shared ReadOnly Property IdentifyTool() As String
                Get
                    Return "Portland_State_University_BAGIS_P_IdentifyTool"
                End Get
            End Property
            
            '''<summary>
            '''Returns 'Portland_State_University_BAGIS_P_BtnParameterDescription', the id declared for Add-in Button class 'BtnParameterDescription'
            '''</summary>
            Friend Shared ReadOnly Property BtnParameterDescription() As String
                Get
                    Return "Portland_State_University_BAGIS_P_BtnParameterDescription"
                End Get
            End Property
            
            '''<summary>
            '''Returns 'Portland_State_University_BAGIS_P_BagisPExtension', the id declared for Add-in Extension class 'BagisPExtension'
            '''</summary>
            Friend Shared ReadOnly Property BagisPExtension() As String
                Get
                    Return "Portland_State_University_BAGIS_P_BagisPExtension"
                End Get
            End Property
            
            '''<summary>
            '''Returns 'Portland_State_University_BAGIS_P_FrmTimberlineTool', the id declared for Add-in DockableWindow class 'FrmTimberlineTool+AddinImpl'
            '''</summary>
            Friend Shared ReadOnly Property FrmTimberlineTool() As String
                Get
                    Return "Portland_State_University_BAGIS_P_FrmTimberlineTool"
                End Get
            End Property
        End Class
    End Module
    
Friend Module ArcMap
  Private s_app As ESRI.ArcGIS.Framework.IApplication
  Private s_docEvent As ESRI.ArcGIS.ArcMapUI.IDocumentEvents_Event

  Public ReadOnly Property Application() As ESRI.ArcGIS.Framework.IApplication
    Get
      If s_app Is Nothing Then
        s_app = TryCast(Internal.AddInStartupObject.GetHook(Of ESRI.ArcGIS.ArcMapUI.IMxApplication)(), ESRI.ArcGIS.Framework.IApplication)
      End If

      Return s_app
    End Get
  End Property

  Public ReadOnly Property Document() As ESRI.ArcGIS.ArcMapUI.IMxDocument
    Get
      If Application IsNot Nothing Then
        Return TryCast(Application.Document, ESRI.ArcGIS.ArcMapUI.IMxDocument)
      End If

      Return Nothing
    End Get
  End Property
  Public ReadOnly Property ThisApplication() As ESRI.ArcGIS.ArcMapUI.IMxApplication
    Get
      Return TryCast(Application, ESRI.ArcGIS.ArcMapUI.IMxApplication)
    End Get
  End Property
  Public ReadOnly Property DockableWindowManager() As ESRI.ArcGIS.Framework.IDockableWindowManager
    Get
      Return TryCast(Application, ESRI.ArcGIS.Framework.IDockableWindowManager)
    End Get
  End Property

  Public ReadOnly Property Events() As ESRI.ArcGIS.ArcMapUI.IDocumentEvents_Event
    Get
      s_docEvent = TryCast(Document, ESRI.ArcGIS.ArcMapUI.IDocumentEvents_Event)
      Return s_docEvent
    End Get
  End Property
End Module

Namespace Internal
  <ESRI.ArcGIS.Desktop.AddIns.StartupObjectAttribute(), _
   Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), _
   Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute()> _
  Partial Public Class AddInStartupObject
    Inherits ESRI.ArcGIS.Desktop.AddIns.AddInEntryPoint

    Private m_addinHooks As List(Of Object)
    Private Shared _sAddInHostManager As AddInStartupObject

    Public Sub New()

    End Sub

    <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
    Protected Overrides Function Initialize(ByVal hook As Object) As Boolean
      Dim createSingleton As Boolean = _sAddInHostManager Is Nothing
      If createSingleton Then
        _sAddInHostManager = Me
        m_addinHooks = New List(Of Object)
        m_addinHooks.Add(hook)
      ElseIf Not _sAddInHostManager.m_addinHooks.Contains(hook) Then
        _sAddInHostManager.m_addinHooks.Add(hook)
      End If

      Return createSingleton
    End Function

    <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
    Protected Overrides Sub Shutdown()
      _sAddInHostManager = Nothing
      m_addinHooks = Nothing
    End Sub

    <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
    Friend Shared Function GetHook(Of T As Class)() As T
      If _sAddInHostManager IsNot Nothing Then
        For Each o As Object In _sAddInHostManager.m_addinHooks
          If TypeOf o Is T Then
            Return DirectCast(o, T)
          End If
        Next
      End If

      Return Nothing
    End Function

    ''' <summary>
    ''' Expose this instance of Add-in class externally
    ''' </summary>
    Public Shared Function GetThis() As AddInStartupObject
      Return _sAddInHostManager
    End Function

  End Class
End Namespace

End Namespace
