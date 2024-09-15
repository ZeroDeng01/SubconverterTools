# SubconverterTools【订阅转换工具】

> 基于tindy2013/subconverter后端实现的Windows自动配置生成和订阅转换工具。
>
> 📌任何人不得使用本项目从事违法任何国家法律的事情，用户使用本项目从事的任何活动与作者无关。
>
> 📌本项目仅仅只有各类协议的订阅和链接转换的功能，不提供任何穿透GFW的技术，并且仅供学习交流使用。
>
> 📌本项目遵循MIT开源协议，但是本项目及其作者依然限制您使用本项目从事任何商业活动，您无法通过任何渠道获取本项目的商业许可。
>
> 📌本项目遵循MIT开源协议，但是任何不尊重`中华人民共和国`主权的人和狗不得直接或者间接使用本项目，包括但不限于衍生项目的代码和编译后的二进制文件、可执行程序等。

**技术框架**：.NET8 WinForms
**编译工具**：Visual Studio 2022



## 特性

- 支持多种协议完美适配[tindy2013/subconverter](https://github.com/tindy2013/subconverter)
- 内置二维码服务，移动端使用直接扫码即可
- 内置订阅转换后端服务（[tindy2013/subconverter](https://github.com/tindy2013/subconverter)），一键启动，无复杂配置，纯本地运行，数据安全有保障

## 截图

![运行截图](https://image-markdown-s3.zerodeng.net/2024/09/c49fa0891a5569df01861bad1e0b00af.png)



## 支持转换类型

| 类型                         | 作为源类型 | 作为目标类型 | 参数                |
| ---------------------------- | ---------- | ------------ | ------------------- |
| Clash                        | ✓          | ✓            | clash               |
| ClashR                       | ✓          | ✓            | clashr              |
| Quantumult (完整配置)        | ✓          | ✓            | quan                |
| Quantumult X (完整配置)      | ✓          | ✓            | quanx               |
| Loon                         | ✓          | ✓            | loon                |
| Mellow                       | ✓          | ✓            | mellow              |
| SS (SIP002)                  | ✓          | ✓            | ss                  |
| SS (软件订阅/SIP008)         | ✓          | ✓            | sssub               |
| SSD                          | ✓          | ✓            | ssd                 |
| SSR                          | ✓          | ✓            | ssr                 |
| Surfboard                    | ✓          | ✓            | surfboard           |
| Surge 2                      | ✓          | ✓            | surge&ver=2         |
| Surge 3                      | ✓          | ✓            | surge&ver=3         |
| Surge 4                      | ✓          | ✓            | surge&ver=4         |
| Trojan                       | ✓          | ✓            | trojan              |
| V2Ray                        | ✓          | ✓            | v2ray               |
| 类 TG 代理的 HTTP/Socks 链接 | ✓          | ×            | 仅支持 `&url=` 调用 |
| Mixed                        | ×          | ✓            | mixed               |
| Auto                         | ×          | ✓            | auto                |



## 相关项目

**服务后端：**[tindy2013/subconverter](https://github.com/tindy2013/subconverter)

**短链接生成：**[CareyWang/MyUrls](https://github.com/CareyWang/MyUrls)



## 贡献

欢迎提交 issue 和 pull request 来改进本项目。



## 支持项目

如果你觉得本项目对您有帮助，可以请作者喝杯咖啡！🎉

 [<img src="https://image-markdown-s3.zerodeng.net/2024/06/2f286ca99768c54ec0495347904fe31b.jpg" alt="支持" style="zoom:50%;" />](https://image-markdown-s3.zerodeng.net/2024/06/2f286ca99768c54ec0495347904fe31b.jpg)