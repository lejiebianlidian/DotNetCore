using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Swashbuckle.AspNetCore.Swagger;
using static Swagger2WebAPI.SwaggerHepler.ApiVersionSetting;
using Microsoft.AspNetCore.Mvc.ApiExplorer;

namespace Swagger2WebAPI
{
    public class Startup
    {
        //public const string version = "V1";
        public const string _apiName = "测试平台";
        
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
            
            //添加api多版本控制
            typeof(ApiVersionsEnum).GetEnumNames().ToList().ForEach(version =>
            {
                //注册Swagger服务
                services.AddSwaggerGen(sg =>
                {
                    sg.SwaggerDoc(version, new Info
                    {
                        Title = $"{_apiName}接口文档",
                        Version = version,
                        Description = $"{_apiName} 接口" + version,
                        //TermsOfService = "None",
                        Contact = new Contact
                        {
                            Name = $"测试API接口-{version}",
                            Email = "visualstudio365@gmail.com",
                            Url = "http://www.google.com"
                        }
                    });

                    var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
                    var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
                    sg.IncludeXmlComments(xmlPath, true);
                });
            });


        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            //启用 Swagger
            app.UseSwagger();
            app.UseSwaggerUI(options =>
            {
                typeof(ApiVersionsEnum).GetEnumNames().OrderByDescending(e=>e).ToList().ForEach(version=> {
                    options.SwaggerEndpoint($"/swagger/{version}/swagger.json", $"{_apiName}接口 {version}");//注意,中间那段的名字 (refuge) 要和 上面 SwaggerDoc 方法定义的 名字 (refuge)一样
                    options.RoutePrefix = string.Empty;//默认值是 "swagger" ,需要这样请求:https://localhost:44384/swagger

                });
               
            });


            app.UseMvc();
        }
    }
}
