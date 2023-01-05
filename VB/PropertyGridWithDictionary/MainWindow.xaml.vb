Imports System.Collections.Generic
Imports System.Windows

Namespace PropertyGridWithDictionary

    Public Partial Class MainWindow
        Inherits Window

        Public Sub New()
            Me.InitializeComponent()
        End Sub

        Private Sub propertyGrid_Loaded(ByVal sender As Object, ByVal e As RoutedEventArgs)
            Dim dict As Dictionary(Of String, Object) = New Dictionary(Of String, Object)()
            dict.Add("FirstName", "Carolyn")
            dict.Add("LastName", "Baker")
            dict.Add("Email", "carolyn.baker@example.com")
            dict.Add("Phone", "(555)349-3010")
            dict.Add("Address", "1198 Theresa Cir")
            dict.Add("City", "Whitinsville")
            dict.Add("State", "MA")
            dict.Add("Zip", "01582")
            Dim wrapper As DictionaryWrapper(Of Object) = New DictionaryWrapper(Of Object)(dict)
            Me.propertyGrid.SelectedObject = wrapper
        End Sub
    End Class
End Namespace
