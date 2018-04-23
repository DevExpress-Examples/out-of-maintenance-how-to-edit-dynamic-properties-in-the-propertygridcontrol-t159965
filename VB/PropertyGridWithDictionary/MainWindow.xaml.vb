Imports System
Imports System.Collections.Generic
Imports System.Windows

Namespace PropertyGridWithDictionary
    Partial Public Class MainWindow
        Inherits Window

        Public Sub New()
            InitializeComponent()
        End Sub
        Private Sub propertyGrid_Loaded(ByVal sender As Object, ByVal e As RoutedEventArgs)
            Dim dict As New Dictionary(Of String, Object)()
            dict.Add("FirstName", "Carolyn")
            dict.Add("LastName", "Baker")
            dict.Add("Email", "carolyn.baker@example.com")
            dict.Add("Phone", "(555)349-3010")
            dict.Add("Address", "1198 Theresa Cir")
            dict.Add("City", "Whitinsville")
            dict.Add("State", "MA")
            dict.Add("Zip", "01582")
            Dim wrapper As New DictionaryWrapper(Of Object)(dict)
            propertyGrid.SelectedObject = wrapper
        End Sub
    End Class
End Namespace