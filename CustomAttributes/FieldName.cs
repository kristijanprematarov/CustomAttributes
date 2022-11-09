using System;

namespace CustomAttributes
{
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field,
        AllowMultiple = false,
        Inherited = false)]
    public class FieldName : Attribute
    {
        public string Comment { get; set; }
        private string _name;

        public FieldName(string name)
        {
            _name = name;
        }

    }
}