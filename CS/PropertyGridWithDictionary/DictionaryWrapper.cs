using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;

namespace PropertyGridWithDictionary {
    class DictionaryWrapper<T> : ICustomTypeDescriptor {
        public Dictionary<string, T> Dict;

        private PropertyDescriptorCollection _collection;

        public DictionaryWrapper(Dictionary<string, T> dict) {
            Dict = dict;
            List<PropertyDescriptor> coll = new List<PropertyDescriptor>();
            foreach (string key in Dict.Keys)
                coll.Add(new CustomPropertyDescriptor<T>(typeof(DictionaryWrapper<T>), key, Dict[key].GetType(), new Attribute[] { }));
            _collection = new PropertyDescriptorCollection(coll.ToArray());
        }

        public AttributeCollection GetAttributes() {
            return new AttributeCollection();
        }

        public string GetClassName() {
            return "";
        }

        public string GetComponentName() {
            return "";
        }

        public TypeConverter GetConverter() {
            return new TypeConverter();
        }

        public EventDescriptor GetDefaultEvent() {
            return null;
        }

        public PropertyDescriptor GetDefaultProperty() {
            return _collection[0];
        }

        public object GetEditor(Type editorBaseType) {
            return new object();
        }

        public EventDescriptorCollection GetEvents(Attribute[] attributes) {
            return null;
        }

        public EventDescriptorCollection GetEvents() {
            return null;
        }

        public PropertyDescriptorCollection GetProperties(Attribute[] attributes) {
            return _collection;
        }

        public PropertyDescriptorCollection GetProperties() {
            return _collection;
        }

        public object GetPropertyOwner(PropertyDescriptor pd) {
            return this;
        }
    }
}