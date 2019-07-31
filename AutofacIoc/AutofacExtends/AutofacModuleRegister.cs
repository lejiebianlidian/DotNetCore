using System;
using System.Data;
using System.Reflection;
using Autofac;
using Autofac.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using Service;
using Assembly = System.Reflection.Assembly;

namespace AutofacIoc.AutofacExtends
{

    public class AutofacModuleRegister:Autofac.Module
    {
        /// <summary>
        /// 重写Autofac管道Load方法,在这里注册注入
        /// </summary>
        /// <param name="builder"></param>
        protected override void Load(ContainerBuilder builder)
        {
            //注册Service中的对象,Service中的类要以Service结尾，否则注册失败
            builder.RegisterAssemblyTypes(GeAssemblyNyName("Service")).Where(a => a.Name.EndsWith("Service"))
                .AsImplementedInterfaces();
            //注册Repository中的对象,Repository中的类以Repository结尾,否则注册失败
            builder.RegisterAssemblyTypes(GeAssemblyNyName("Repostitory")).Where(a => a.Name.EndsWith("Repository"))
                .AsImplementedInterfaces();

            //一个接口多个实现，可以通过单个注册获取到所有的实现
            //单个注册
            builder.RegisterType<AliPayService>().Named<IPayService>(typeof(AliPayService).Name);
            builder.RegisterType<WxPayService>().Named<IPayService>(typeof(WxPayService).Name);
        }

        /// <summary>
        /// 根据程序集名称获取程序集
        /// </summary>
        /// <param name="AssemblyName">程序集名称</param>
        /// <returns></returns>
        public static Assembly GeAssemblyNyName(String assemblyName)
        {
            return Assembly.Load(assemblyName);
        }

    }
}