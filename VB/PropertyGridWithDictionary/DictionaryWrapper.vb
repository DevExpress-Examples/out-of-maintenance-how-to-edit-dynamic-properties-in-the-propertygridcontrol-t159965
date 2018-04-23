Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.ComponentModel

Namespace PropertyGridWithDictionary
    Friend Class DictionaryWrapper(Of T)
        Implements ICustomTypeDescriptor

        Public Dict As Dictionary(Of String, T)

        Private _collection As PropertyDescriptorCollection

        Public Sub New(ByVal dict As Dictionary(Of String, T))
            Me.Dict = dict
            Dim coll As New List(Of PropertyDescriptor)()
            For Each key As String In Me.Dict.Keys
                coll.Add(New CustomPropertyDescriptor(Of T)(GetType(DictionaryWrapper(Of T)), key, Me.Dict(key).GetType(), New Attribute() { }))
            Next key
            _collection = New PropertyDescriptorCollection(coll.ToArray())
        End Sub

        Public Function GetAttributes() As AttributeCollection Implements ICustomTypeDescriptor.GetAttributes
            Return New AttributeCollection()
        End Function

        Public Function GetClassName() As String Implements ICustomTypeDescriptor.GetClassName
            Return ""
        End Function

        Public Function GetComponentName() As String Implements ICustomTypeDescriptor.GetComponentName
            Return ""
        End Function

        Public Function GetConverter() As TypeConverter Implements ICustomTypeDescriptor.GetConverter
            Return New TypeConverter()
        End Function

        Public Function GetDefaultEvent() As EventDescriptor Implements ICustomTypeDescriptor.GetDefaultEvent
            Return Nothing
        End Function

        Public Function GetDefaultProperty() As PropertyDescriptor Implements ICustomTypeDescriptor.GetDefaultProperty
            Return _collection(0)
        End Function

        Public Function GetEditor(ByVal editorBaseType As Type) As Object Implements ICustomTypeDescriptor.GetEditor
            Return New Object()
        End Function

        Public Function GetEvents(ByVal attributes() As Attribute) As EventDescriptorCollection Implements ICustomTypeDescriptor.GetEvents
            Return Nothing
        End Function

        Public Function GetEvents() As EventDescriptorCollection Implements ICustomTypeDescriptor.GetEvents
            Return Nothing
        End Function

        Public Function GetProperties(ByVal attributes() As Attribute) As PropertyDescriptorCollection Implements ICustomTypeDescriptor.GetProperties
            Return _collection
        End Function

        Public Function GetProperties() As PropertyDescriptorCollection Implements ICustomTypeDescriptor.GetProperties
            Return _collection
        End Function

        Public Function GetPropertyOwner(ByVal pd As PropertyDescriptor) As Object Implements ICustomTypeDescriptor.GetPropertyOwner
            Return Me
        End Function
    End Class
End Namespace