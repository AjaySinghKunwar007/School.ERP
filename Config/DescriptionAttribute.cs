using System.Reflection;

namespace Optimum.ERP.Models.Config
{
    public class DescriptionAttribute : Attribute
    {
        public string Description { get; set; }

        public int Order { get; set; }
    }
    public static class AttributeExtension
    {
        public static bool HasAttribute(this FieldInfo target, Type attribType)
        {
            return target.GetCustomAttributes(attribType, inherit: false).Length != 0;
        }
    }
}
