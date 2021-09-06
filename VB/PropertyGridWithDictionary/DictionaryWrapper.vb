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
				coll.Add(New CustomPropertyDescriptor(Of T)(GetType(DictionaryWrapper(Of T)), key, Me.Dict(key).GetType(), New Attribute() {}))
			Next key
			_collection = New PropertyDescriptorCollection(coll.ToArray())
		End Sub

		Public Function GetAttributes() As AttributeCollection
			Return New AttributeCollection()
		End Function

		Public Function GetClassName() As String
			Return ""
		End Function

		Public Function GetComponentName() As String
			Return ""
		End Function

		Public Function GetConverter() As TypeConverter
			Return New TypeConverter()
		End Function

		Public Function GetDefaultEvent() As EventDescriptor
			Return Nothing
		End Function

		Public Function GetDefaultProperty() As PropertyDescriptor
			Return _collection(0)
		End Function

		Public Function GetEditor(ByVal editorBaseType As Type) As Object
			Return New Object()
		End Function

		Public Function GetEvents(ByVal attributes() As Attribute) As EventDescriptorCollection
			Return Nothing
		End Function

		Public Function GetEvents() As EventDescriptorCollection
			Return Nothing
		End Function

		Public Function GetProperties(ByVal attributes() As Attribute) As PropertyDescriptorCollection
			Return _collection
		End Function

		Public Function GetProperties() As PropertyDescriptorCollection
			Return _collection
		End Function

		Public Function GetPropertyOwner(ByVal pd As PropertyDescriptor) As Object
			Return Me
		End Function
	End Class
End Namespace