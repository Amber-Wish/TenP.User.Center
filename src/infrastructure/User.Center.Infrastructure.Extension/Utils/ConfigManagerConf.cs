﻿using System;
using System.Linq;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.Json;

namespace User.Center.Infrastructure.Extension.Utils
{
    /// <summary>
    /// 配置操作类
    /// </summary>
    public class ConfigManagerConf
    {
        static IConfiguration Configuration { get; set; }

        public ConfigManagerConf(string contentPath)
        {
            //string Path = "appsettings.json";

            //配置文件 是 根据环境变量来分开了，可以这样写
            string Path = $"appsettings.{Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT")}.json";

            Configuration = new ConfigurationBuilder()
                .SetBasePath(contentPath)
                .Add(new JsonConfigurationSource
                {
                    Path = Path,
                    Optional = false,
                    ReloadOnChange = true
                }) //这样的话，可以直接读目录里的json文件，而不是 bin 文件夹下的，所以不用修改复制属性
                .Build();


        }

        /// <summary>
        /// 封装要操作的字符
        /// </summary>
        /// <param name="sections">节点配置</param>
        /// <returns></returns>
        public static string GetValue(params string[] sections)
        {
            try
            {
                if (sections.Any())
                {
                    return Configuration[string.Join(":", sections)];
                }
            }
            catch (Exception)
            {
                // ignored
            }

            return "";
        }


    }

}