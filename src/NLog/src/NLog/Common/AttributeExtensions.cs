using System;
#if NETFX_CORE
using System.Collections.Generic;
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
        public static ConstructorInfo GetConstructor(this Type type, Type[] types)
        {
#if NETFX_CORE
            return type.GetTypeInfo().DeclaredConstructors.FirstOrDefault();
#else
            return type.GetConstructor(emptyTypes);
#endif
        }

        public static bool IsDefined(this Type type, Type childType)
        {
#if NETFX_CORE
            return type.GetTypeInfo().IsDefined(childType, false);
#else
            return type.IsDefined(typeof(TClassAttributeType), false);
#endif
        }

        public static bool IsEnum(this Type type)
        {
#if NETFX_CORE
            return type.GetTypeInfo().IsEnum;
#else
            return type.IsEnum;
#endif
        }

#if NETFX_CORE
        public static bool IsDefined(this Type type, Type childType, bool inherit)
        {
            return type.GetTypeInfo().IsDefined(childType, inherit);
        }
#endif


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

        public static T GetAttribute<T>(this Type type) where T : Attribute
        {
#if NETFX_CORE
            return type.GetTypeInfo().GetCustomAttribute<T>();
#else
            return (T)Attribute.GetCustomAttribute(type, typeof(T));
#endif
        }

        public static T GetAttribute<T>(this PropertyInfo propertyInfo) where T : Attribute
        {
#if NETFX_CORE
            return propertyInfo.GetCustomAttribute<T>();
#else
            return (T)Attribute.GetCustomAttribute(propertyInfo, typeof(T));
#endif
        }

        public static T[] GetAttributes<T>(this Type type) where T : Attribute
        {
#if NETFX_CORE
            return type.GetTypeInfo().GetCustomAttributes<T>().ToArray();
#else
            return (T[])type.GetCustomAttributes(typeof(T), false);
#endif
        }

        public static PropertyInfo GetProperty(this Type type, string propertyName)
        {
#if NETFX_CORE
            return type.GetTypeInfo().DeclaredProperties
                       .FirstOrDefault(p => p.Name.Equals(propertyName, StringComparison.OrdinalIgnoreCase));
#else
            return type.GetProperty(propertyName, BindingFlags.IgnoreCase | BindingFlags.Public | BindingFlags.Instance);
#endif
        }

        public static bool IsAssignableFrom(this Type type, Type otherType)
        {
#if NETFX_CORE
            return type.GetTypeInfo().IsAssignableFrom(otherType.GetTypeInfo());
#else
            return type.IsAssignableFrom(otherType);
#endif            
        }

        public static MethodInfo GetMethod(this Type type, string methodName)
        {
#if NETFX_CORE
            return type.GetTypeInfo().DeclaredMethods
                       .FirstOrDefault(p => p.Name.Equals(methodName, StringComparison.OrdinalIgnoreCase));
#else
            return type.GetMethod(methodName, BindingFlags.Public | BindingFlags.Static, null, new Type[] { typeof(string) }, null);
#endif
        }

        public static FieldInfo GetField(this Type type, string fieldName)
        {
#if NETFX_CORE
            return type.GetTypeInfo().DeclaredFields.FirstOrDefault(c => c.Name.Equals(fieldName, StringComparison.OrdinalIgnoreCase));
#else
            return type.GetField(fieldName, BindingFlags.IgnoreCase | BindingFlags.Static | BindingFlags.FlattenHierarchy | BindingFlags.Public)
#endif
        }

        public static IEnumerable<PropertyInfo> GetProperties(this Type type)
        {
#if NETFX_CORE
            return type.GetTypeInfo().DeclaredProperties;
#else
            return type.GetProperties(BindingFlags.Public | BindingFlags.Instance);
#endif
        }
    }
}
