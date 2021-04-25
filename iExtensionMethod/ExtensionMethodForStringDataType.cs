namespace iExtensionMethod
{
    /// <summary>
    /// Implementation of Extension Method for string data type
    /// </summary>
     static class ExtensionMethodForStringDataType
    {
        public static bool IsNationalNumberExtension(this string input)
        {
            return input.Length == 10 ? true : false;
        }
    }
}
