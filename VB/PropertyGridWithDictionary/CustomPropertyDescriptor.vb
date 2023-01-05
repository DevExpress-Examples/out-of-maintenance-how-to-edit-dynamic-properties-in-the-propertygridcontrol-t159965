Imports System
Imports System.ComponentModel

Namespace PropertyGridWithDictionary

    Public Class CustomPropertyDescriptor(Of T)
        Inherits PropertyDescriptor

        Private _propertyType As Type

        Private _componentType As Type

        Private _oldValue As T

        Public Sub New(ByVal componentType As Type, ByVal propertyName As String, ByVal propertyType As Type, ByVal attributes As Attribute())
            MyBase.New(propertyName, attributes)
            _propertyType = propertyType
            _componentType = componentType
        End Sub

        Public Overrides Function CanResetValue(ByVal component As Object) As Boolean
            If _oldValue Is Nothing Then
                Return False
            Else
                Return True
            End If
        End Function

        Public Overrides ReadOnly Property ComponentType As Type
            Get
                Return _componentType
            End Get
        End Property

        Public Overrides Function GetValue(ByVal component As Object) As Object
            Return TryCast(component, DictionaryWrapper(Of T)).Dict(Name)
        End Function

        Public Overrides ReadOnly Property IsReadOnly As Boolean
            Get
                Return False
            End Get
        End Property

        Public Overrides ReadOnly Property PropertyType As Type
            Get
                Return _propertyType
            End Get
        End Property

        Public Overrides Sub ResetValue(ByVal component As Object)
            SetValue(component, _oldValue)
        End Sub

        Public Overrides Sub SetValue(ByVal component As Object, ByVal value As Object)
            _oldValue = TryCast(component, DictionaryWrapper(Of T)).Dict(Name)
            TryCast(component, DictionaryWrapper(Of T)).Dict(Name) = CType(value, T)
        End Sub

        Public Overrides Function ShouldSerializeValue(ByVal component As Object) As Boolean
            Return False
        End Function
    End Class
End Namespace
