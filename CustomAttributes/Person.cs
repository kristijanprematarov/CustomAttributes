namespace CustomAttributes
{
    public class Person
    {
        [FieldName("SocialSecurityNumber", Comment = "This is the primary key field")]
        public string SocialSecurityNumber { get; set; }
    }
}