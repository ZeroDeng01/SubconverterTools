using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace SubconverterTools.Utils
{
    public class ShortURL
    {
        private static readonly HttpClient client = new HttpClient();
        public static string requestUrl = string.Empty;
        /// <summary>
        /// 短网址生成
        /// </summary>
        /// <param name="api">短网址API</param>
        /// <param name="longUrl">长网址</param>
        /// <returns></returns>
        public static async Task<string> Short( string longUrl, string api = "https://suo.yt")
        {
            requestUrl = api + "/short";
            // 创建表单数据
            var formData = new FormUrlEncodedContent(new[]
            {
                new KeyValuePair<string, string>("longUrl", longUrl)
             });

            try
            {
                // 发送POST请求
                var response = await client.PostAsync(requestUrl, formData);

                // 确保请求成功
                response.EnsureSuccessStatusCode();

                // 读取响应内容
                var jsonResponse = await response.Content.ReadAsStringAsync();

                // 解析JSON响应
                var result = JsonSerializer.Deserialize<ShortUrlResponse>(jsonResponse);

                // 返回短网址
                return result.ShortUrl;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"请求失败: {ex.Message}");
                return null;
            }
        }

        // 定义响应的模型
        private class ShortUrlResponse
        {
            public int Code { get; set; }
            public string ShortUrl { get; set; }
        }
    }
}
