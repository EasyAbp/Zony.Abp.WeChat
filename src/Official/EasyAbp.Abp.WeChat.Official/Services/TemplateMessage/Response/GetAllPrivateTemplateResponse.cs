using System.Collections.Generic;
using EasyAbp.Abp.WeChat.Official.Infrastructure.Models;
using Newtonsoft.Json;

namespace EasyAbp.Abp.WeChat.Official.Services.TemplateMessage.Response
{
    public class GetAllPrivateTemplateResponse : OfficialCommonResponse
    {
        /// <summary>
        /// 模版列表数据。
        /// </summary>
        [JsonProperty("template_list")]
        public List<TemplateDefinition> TemplateList { get; set; }
    }
}