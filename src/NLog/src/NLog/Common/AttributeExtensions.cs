using System;
#if NETFX_CORE
using System.Linq;
using System.Reflection;
#endif

namespace NLog.Common
{
    /// <summary>
    /// 
    /// </summary>
    public static class AttributeExtensions
    {
        public static bool IsDefined(this Type type, Type childType)
        {
#if NETFX_CORE
            return type.GetTypeInfo().IsDefined(childType, false);
#else
            return type.IsDefined(typeof(TClassAttributeType), false);
#endif
        }

#if NETFX_CORE
        public static MethodInfo[] GetMethods(this Type type)
        {
            return type.GetTypeInfo().DeclaredMethods.ToArray();
        }
#endif

        public static bool IsPrimitive(this Type type)
        {
#if NETFX_CORE
            return type.GetTypeInfo().IsPrimitive;
#else
            return type.IsPrimitive;
#endif
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="type"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static T GetAttribute<T>(this Type type) where T : Attribute
        {
#if NETFX_CORE
            return type.GetTypeInfo().GetCustomAttribute<T>();
#else
            return (T)Attribute.GetCustomAttribute(type, typeof(T));
#endif
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="type"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static T[] GetAttributes<T>(this Type type) where T : Attribute
        {
#if NETFX_CORE
            return type.GetTypeInfo().GetCustomAttributes<T>().ToArray();
#else
            return (T[])type.GetCustomAttributes(typeof(T), false);
#endif
        }
    }
}
