using System;
using System.Collections;
using System.Collections.Generic;

namespace Alkl.DeviceHub.Common
{
    public class TypedObject : Dictionary<string, ITypedObject>, ITypedObject
    {
        private readonly dynamic _value;
        
        public Type Type { get; }

        public TypedObject(IDictionary<string, ITypedObject> properties)
            : base(properties)
        {
            _value = null;
            Type = typeof(IDictionary);
        }
        
        public TypedObject(bool value)
        {
            _value = value;
            Type = typeof(bool);
        }
        
        public TypedObject(int value)
        {
            _value = value;
            Type = typeof(int);
        }
        
        public TypedObject( double value)
        {
            _value = value;
            Type = typeof(double);
        }
        
        public TypedObject(string value)
        {
            _value = value;
            Type = typeof(string);
        }

        public static implicit operator TypedObject(bool value)
        {
            return new TypedObject(value);
        }

        public static implicit operator TypedObject(int value)
        {
            return new TypedObject(value);
        }

        public static implicit operator TypedObject(double value)
        {
            return new TypedObject(value);
        }

        public static implicit operator TypedObject(string value)
        {
            return new TypedObject(value);
        }

        public bool? GetBool()
        {
            return Type == typeof(bool) ? _value : null;
        }

        public int? GetInt()
        {
            return Type == typeof(int) ? _value : null;
        }

        public double? GetDouble()
        {
            return Type == typeof(double) ? _value : null;
        }

        public string GetString()
        {
            return Type == typeof(string) ? _value : null;
        }
    }
}