using System.Linq;
using System.Reflection;
using AutoMapper;

namespace AutoMapperTest
{
    //弃用
    public class Mappings
    {
        public static void RegisterMappings()
        {
            //获取所有IProfile实现类
            var allType =
                Assembly.GetEntryAssembly()//获取默认程序集
                .GetReferencedAssemblies()//获取所有引用程序集
                .Select(Assembly.Load)
                .SelectMany(a => a.DefinedTypes)
                .Where(type => typeof(IProfile).GetTypeInfo().IsAssignableFrom(type.AsType()));

            foreach (var typeInfo in allType)
            {
                var type = typeInfo.AsType();
                if (type.Equals(typeof(IProfile)))
                {
                    Mapper.Initialize(m=>m.AddProfiles(type));//Initialise each Profile classe
                }
            }


        }
    }
}