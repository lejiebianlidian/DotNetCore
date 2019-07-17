using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ApiExplorer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static Swagger2WebAPI.SwaggerHepler.ApiVersionSetting;

namespace Swagger2WebAPI.SwaggerHepler
{
    /// <summary>
    /// 自定义路由/api/{version}/[controller]/[action]
    /// </summary>
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, AllowMultiple = true, Inherited = true)]
    public class RouteAttributeSetting:RouteAttribute, IApiDescriptionGroupNameProvider
    {
        public string GroupName { get; set; }

        public RouteAttributeSetting(string actionName="[action]"):base("/api/{version}/[controller]/"+actionName)
        {

        }
        public RouteAttributeSetting(ApiVersionsEnum version, string actionName = "[action]") : base($"/api/{version.ToString()}/[controller]/{actionName}")
        {
            GroupName = version.ToString();
        }


    }
}
