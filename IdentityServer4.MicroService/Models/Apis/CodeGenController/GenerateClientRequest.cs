﻿using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace IdentityServer4.MicroService.Models.Apis.CodeGenController
{
    public class GenerateClientRequest
    {
        /// <summary>
        /// 包平台
        /// </summary>
        public PackagePlatform platform { get; set; }

        /// <summary>
        /// 语言(可选：angular2)
        /// </summary>
        public Language language { get; set; }

        /// <summary>
        /// 模板名称
        /// </summary>
        public string template { get; set; }

        /// <summary>
        /// SDK生成设置
        /// </summary>
        public string packageOptions { get; set; }

        /// <summary>
        /// swagger 文档地址
        /// </summary>
        [Required(ErrorMessage ="请填写swagger文档地址")]
        public string swaggerUrl { get; set; }
    }

    public enum Language
    {
        /// <summary>
        /// angular2
        /// </summary>
        [EnumMember(Value = "angular2")]
        angular2 = 0,
    }

    public enum PackagePlatform
    {
        /// <summary>
        /// Js包平台：NPM，网址：https://www.npmjs.com/
        /// </summary>
        [EnumMember(Value = "npm")]
        npm = 0,

        /// <summary>
        /// C#包平台：nuget，网址：https://www.nuget.org/
        /// </summary>
        [EnumMember(Value = "nuget")]
        nuget = 1,

        /// <summary>
        /// Android包平台：gradle，网址：https://gradle.org/ 
        /// </summary>
        [EnumMember(Value = "gradle")]
        gradle = 2,

        /// <summary>
        /// IOS包平台：SPM,网址：https://swift.org/package-manager/ 
        /// </summary>
        [EnumMember(Value = "spm")]
        spm = 3,
    }
}