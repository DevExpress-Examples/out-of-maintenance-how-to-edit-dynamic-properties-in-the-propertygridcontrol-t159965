using System;
using System.ComponentModel;

namespace PropertyGridWithDictionary {
    public class CustomPropertyDescriptor<T> : PropertyDescriptor {
        private Type _propertyType;

        private Type _componentType;

        private T _oldValue;

        public CustomPropertyDescriptor(Type componentType, string propertyName, Type propertyType, Attribute[] attributes)
            : base(propertyName, attributes) {
            _propertyType = propertyType;
            _componentType = componentType;
        }

        public override bool CanResetValue(object component) {
            if (_oldValue == null)
                return false;
            else
                return true;
        }

        public override Type ComponentType {
            get { return _componentType; }
        }

        public override object GetValue(object component) {
            return (component as DictionaryWrapper<T>).Dict[base.Name];
        }

        public override bool IsReadOnly {
            get { return false; }
        }

        public override Type PropertyType {
            get { return _propertyType; }
        }

        public override void ResetValue(object component) {
            SetValue(component, _oldValue);
        }

        public override void SetValue(object component, object value) {
            _oldValue = (component as DictionaryWrapper<T>).Dict[base.Name];
            (component as DictionaryWrapper<T>).Dict[base.Name] = (T)value;
        }

        public override bool ShouldSerializeValue(object component) {
            return false;
        }
    }
}