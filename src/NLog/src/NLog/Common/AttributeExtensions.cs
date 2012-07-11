using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace NLog.Common
{
    public static class AttributeExtensions
    {
        public static T GetAttribute<T>(this Type type) where T : Attribute
        {
#if NETFX_CORE
            return type.GetTypeInfo().GetCustomAttribute<T>();
#else
            return (T)Attribute.GetCustomAttribute(type, typeof(T));
#endif
        }
    }
}
