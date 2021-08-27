<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128655186/14.1.6%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T159965)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [CustomPropertyDescriptor.cs](./CS/PropertyGridWithDictionary/CustomPropertyDescriptor.cs) (VB: [CustomPropertyDescriptor.vb](./VB/PropertyGridWithDictionary/CustomPropertyDescriptor.vb))
* [DictionaryWrapper.cs](./CS/PropertyGridWithDictionary/DictionaryWrapper.cs) (VB: [DictionaryWrapper.vb](./VB/PropertyGridWithDictionary/DictionaryWrapper.vb))
* [MainWindow.xaml](./CS/PropertyGridWithDictionary/MainWindow.xaml) (VB: [MainWindow.xaml](./VB/PropertyGridWithDictionary/MainWindow.xaml))
* [MainWindow.xaml.cs](./CS/PropertyGridWithDictionary/MainWindow.xaml.cs) (VB: [MainWindow.xaml.vb](./VB/PropertyGridWithDictionary/MainWindow.xaml.vb))
<!-- default file list end -->
# How to: Edit Dynamic Properties in the PropertyGridControl


The PropertyGridControl supports the standard<a href="https://msdn.microsoft.com/en-us/library/system.componentmodel.icustomtypedescriptor%28v=vs.110%29.aspx"> ICustomTypeDescriptor</a> interface. To be able to display dynamic properties, you can implement this interface in the data source class and pass the instance of this class to <a href="https://documentation.devexpress.com/#WPF/DevExpressXpfPropertyGridPropertyGridControl_SelectedObjecttopic">PropertyGridControl.SelectedObject</a>.<br>
<p>In this example, this interface is implemented in the DictionaryWrapper<T> class. In the GetProperties methods, it returns a collection of custom <a href="https://msdn.microsoft.com/en-us/library/system.componentmodel.propertydescriptor%28v=vs.110%29.aspx">PropertyDescriptor</a> descendants.</p>

<br/>


