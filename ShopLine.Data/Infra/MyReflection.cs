using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace ShopLine.Data.Infra
{
    public static class MyReflection
    {
        public static List<Type> GetClassByParentName(Type parentType)  
        {
            List<Type> className = new List<Type>();
            Assembly assembly = Assembly.GetExecutingAssembly();
            Type[] types = assembly.GetTypes();
            IEnumerable<Type> subclasses = types.Where(t => t.BaseType == parentType && t.Namespace == "ShopLine.Domain.Entity");

            foreach (Type type in subclasses)
            {
                className.Add(type);
            }
            return className;
        }
    }
}
