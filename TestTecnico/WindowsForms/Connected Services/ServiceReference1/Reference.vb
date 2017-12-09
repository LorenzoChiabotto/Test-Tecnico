﻿'------------------------------------------------------------------------------
' <auto-generated>
'     Este código fue generado por una herramienta.
'     Versión de runtime:4.0.30319.42000
'
'     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
'     se vuelve a generar el código.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On

Imports System.Data

Namespace ServiceReference1
    
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ServiceModel.ServiceContractAttribute(ConfigurationName:="ServiceReference1.ServiceSoap")>  _
    Public Interface ServiceSoap
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/GetDatos", ReplyAction:="*"),  _
         System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults:=true)>  _
        Function GetDatos() As System.Data.DataTable
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/NuevaPersonna", ReplyAction:="*"),  _
         System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults:=true)>  _
        Sub NuevaPersonna(ByVal nombre As String, ByVal nacimiento As String, ByVal sexo As String)
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/ModificarPersona", ReplyAction:="*"),  _
         System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults:=true)>  _
        Sub ModificarPersona(ByVal id As Integer, ByVal nombre As String, ByVal nacimiento As String, ByVal sexo As String)
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/BajaPersona", ReplyAction:="*"),  _
         System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults:=true)>  _
        Sub BajaPersona(ByVal id As Integer)
    End Interface
    
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")>  _
    Public Interface ServiceSoapChannel
        Inherits ServiceReference1.ServiceSoap, System.ServiceModel.IClientChannel
    End Interface
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")>  _
    Partial Public Class ServiceSoapClient
        Inherits System.ServiceModel.ClientBase(Of ServiceReference1.ServiceSoap)
        Implements ServiceReference1.ServiceSoap
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New(ByVal endpointConfigurationName As String)
            MyBase.New(endpointConfigurationName)
        End Sub
        
        Public Sub New(ByVal endpointConfigurationName As String, ByVal remoteAddress As String)
            MyBase.New(endpointConfigurationName, remoteAddress)
        End Sub
        
        Public Sub New(ByVal endpointConfigurationName As String, ByVal remoteAddress As System.ServiceModel.EndpointAddress)
            MyBase.New(endpointConfigurationName, remoteAddress)
        End Sub
        
        Public Sub New(ByVal binding As System.ServiceModel.Channels.Binding, ByVal remoteAddress As System.ServiceModel.EndpointAddress)
            MyBase.New(binding, remoteAddress)
        End Sub
        
        Public Function GetDatos() As System.Data.DataTable Implements ServiceReference1.ServiceSoap.GetDatos
            Return MyBase.Channel.GetDatos
        End Function
        
        Public Sub NuevaPersonna(ByVal nombre As String, ByVal nacimiento As String, ByVal sexo As String) Implements ServiceReference1.ServiceSoap.NuevaPersonna
            MyBase.Channel.NuevaPersonna(nombre, nacimiento, sexo)
        End Sub
        
        Public Sub ModificarPersona(ByVal id As Integer, ByVal nombre As String, ByVal nacimiento As String, ByVal sexo As String) Implements ServiceReference1.ServiceSoap.ModificarPersona
            MyBase.Channel.ModificarPersona(id, nombre, nacimiento, sexo)
        End Sub
        
        Public Sub BajaPersona(ByVal id As Integer) Implements ServiceReference1.ServiceSoap.BajaPersona
            MyBase.Channel.BajaPersona(id)
        End Sub
    End Class
End Namespace
