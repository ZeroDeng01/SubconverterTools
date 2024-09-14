using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubconverterTools.Utils
{
    public class BackendVersion
    {
        private static readonly HttpClient client = new HttpClient();
        public static async Task<string> GetVersionAsync(string api)
        {
            string requestUrl = api.Replace("sub?", "version"); // 替换为你的 URL

            try
            {
                // 发送 GET 请求
                var response = await client.GetAsync(requestUrl);

                // 确保请求成功
                response.EnsureSuccessStatusCode();

                // 读取响应内容
                var responseText = await response.Content.ReadAsStringAsync();

                // 校验返回内容
                if (IsValidVersionResponse(responseText))
                {
                    return responseText; // 返回完整内容
                }
                else
                {
                    return string.Empty; // 返回空字符串表示内容不符合预期
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"请求失败: {ex.Message}");
                return string.Empty; // 返回空字符串表示请求失败
            }
        }
        private static bool IsValidVersionResponse(string responseText)
        {
            // 校验内容格式，简单示例：检查是否包含 "subconverter"
            return responseText.StartsWith("subconverter");
        }
    }
}
