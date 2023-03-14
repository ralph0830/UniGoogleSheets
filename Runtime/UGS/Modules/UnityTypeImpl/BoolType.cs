namespace GoogleSheet.Type
{
    [Type(typeof(bool), new string[] { "bool", "Bool" })]
    public class BoolType : IType
    {
        public object DefaultValue => false;
        public object Read(string value)
        {
            switch (value)
            {
                case "true":
                    return true;
                case "1":
                    return true;
                case "false":
                    return false;
                case "0":
                    return false;
                default:
                    return false;
            }
        }

        public string Write(object value)
        {
            bool b = (bool)value;
            return b ? "true" : "false";
        }
    }
}

