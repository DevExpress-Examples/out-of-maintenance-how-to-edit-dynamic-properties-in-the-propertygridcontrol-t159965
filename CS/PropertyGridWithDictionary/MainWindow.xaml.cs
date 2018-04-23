using System;
using System.Collections.Generic;
using System.Windows;

namespace PropertyGridWithDictionary {
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
        }
        private void propertyGrid_Loaded(object sender, RoutedEventArgs e) {
            Dictionary<string, object> dict = new Dictionary<string, object>();
            dict.Add("FirstName", "Carolyn");
            dict.Add("LastName", "Baker");
            dict.Add("Email", "carolyn.baker@example.com");
            dict.Add("Phone", "(555)349-3010");
            dict.Add("Address", "1198 Theresa Cir");
            dict.Add("City", "Whitinsville");
            dict.Add("State", "MA");
            dict.Add("Zip", "01582");
            DictionaryWrapper<object> wrapper = new DictionaryWrapper<object>(dict);
            propertyGrid.SelectedObject = wrapper;
        }
    }
}