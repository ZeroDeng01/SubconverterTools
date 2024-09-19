using AntdUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubconverterTools.BaseData
{
    /// <summary>
    /// 配置列表
    /// </summary>
    public class RemoteConfigs
    {
        /// <summary>
        /// 配置列表
        /// </summary>
        /// <returns></returns>
        public static List<SelectItem> GetItem()
        {
            var remoteConfigs = new List<SelectItem>
            {
                new SelectItem("不选，系统默认", "https://raw.githubusercontent.com/tindy2013/subconverter/master/base/config/example_external_config.ini"),
                new SelectItem("ACL4SSR"){ Enable=false},

                new SelectItem("ACL4SSR_Online 默认版 分组比较全(与Github同步)", "https://raw.githubusercontent.com/ACL4SSR/ACL4SSR/master/Clash/config/ACL4SSR_Online.ini"),
                new SelectItem("[个人定制]ACL4SSR_Online_Full_NoCountry 无国家分类", "https://raw.githubusercontent.com/ZeroDeng01/ACL4SSR/refs/heads/master/Clash/config/ACL4SSR_Online_Full%20_NoCountry.ini"),
                new SelectItem("ACL4SSR_Online_AdblockPlus 更多去广告(与Github同步)", "https://raw.githubusercontent.com/ACL4SSR/ACL4SSR/master/Clash/config/ACL4SSR_Online_AdblockPlus.ini"),
                new SelectItem("ACL4SSR_Online_Full 全分组 重度用户使用(与Github同步)", "https://raw.githubusercontent.com/ACL4SSR/ACL4SSR/master/Clash/config/ACL4SSR_Online_Full.ini"),
                new SelectItem("ACL4SSR_Online_Full_AdblockPlus 全分组 重度用户使用 更多去广告(与Github同步)", "https://raw.githubusercontent.com/ACL4SSR/ACL4SSR/master/Clash/config/ACL4SSR_Online_Full_AdblockPlus.ini"),
                new SelectItem("ACL4SSR_Online_Full_Google 全分组 重度用户使用 谷歌细分(与Github同步)", "https://raw.githubusercontent.com/ACL4SSR/ACL4SSR/master/Clash/config/ACL4SSR_Online_Full_Google.ini"),
                new SelectItem("ACL4SSR_Online_Full_MultiMode 全分组 多模式 重度用户使用(与Github同步)", "https://raw.githubusercontent.com/ACL4SSR/ACL4SSR/master/Clash/config/ACL4SSR_Online_Full_MultiMode.ini"),
                new SelectItem("ACL4SSR_Online_Full_NoAuto 全分组 无自动测速 重度用户使用(与Github同步)", "https://raw.githubusercontent.com/ACL4SSR/ACL4SSR/master/Clash/config/ACL4SSR_Online_Full_NoAuto.ini"),
                new SelectItem("ACL4SSR_Online_Full_Netflix 全分组 重度用户使用 奈飞全量(与Github同步)", "https://raw.githubusercontent.com/ACL4SSR/ACL4SSR/master/Clash/config/ACL4SSR_Online_Full_Netflix.ini"),
                new SelectItem("ACL4SSR_Online_Mini 精简版(与Github同步)", "https://raw.githubusercontent.com/ACL4SSR/ACL4SSR/master/Clash/config/ACL4SSR_Online_Mini.ini"),
                new SelectItem("ACL4SSR_Online_Mini_Ai 精简版 带OpenAi(与Github同步)", "https://raw.githubusercontent.com/ACL4SSR/ACL4SSR/master/Clash/config/ACL4SSR_Online_Mini_Ai.ini"),
                new SelectItem("ACL4SSR_Online_Mini_AdblockPlus 精简版 更多去广告(与Github同步)", "https://raw.githubusercontent.com/ACL4SSR/ACL4SSR/master/Clash/config/ACL4SSR_Online_Mini_AdblockPlus.ini"),
                new SelectItem("ACL4SSR_Online_Mini_Fallback 精简版 带故障转移(与Github同步)", "https://raw.githubusercontent.com/ACL4SSR/ACL4SSR/master/Clash/config/ACL4SSR_Online_Mini_Fallback.ini"),
                new SelectItem("ACL4SSR_Online_Mini_MultiCountry 精简版 带港美日国家(与Github同步)", "https://raw.githubusercontent.com/ACL4SSR/ACL4SSR/master/Clash/config/ACL4SSR_Online_Mini_MultiCountry.ini"),
                new SelectItem("ACL4SSR_Online_Mini_MultiMode 精简版 自动测速、故障转移、负载均衡(与Github同步)", "https://raw.githubusercontent.com/ACL4SSR/ACL4SSR/master/Clash/config/ACL4SSR_Online_Mini_MultiMode.ini"),
                new SelectItem("ACL4SSR_Online_Mini_NoAuto 精简版 不带自动测速(与Github同步)", "https://raw.githubusercontent.com/ACL4SSR/ACL4SSR/master/Clash/config/ACL4SSR_Online_Mini_NoAuto.ini"),
                new SelectItem("ACL4SSR_Online_NoAuto 无自动测速(与Github同步)", "https://raw.githubusercontent.com/ACL4SSR/ACL4SSR/master/Clash/config/ACL4SSR_Online_NoAuto.ini"),
                new SelectItem("ACL4SSR_Online_NoReject 无广告拦截规则(与Github同步)", "https://raw.githubusercontent.com/ACL4SSR/ACL4SSR/master/Clash/config/ACL4SSR_Online_NoReject.ini"),
                new SelectItem("ACL4SSR_Online_MultiCountry 多国分组(与Github同步)", "https://raw.githubusercontent.com/ACL4SSR/ACL4SSR/master/Clash/config/ACL4SSR_Online_MultiCountry.ini"),
                new SelectItem("ACL4SSR_Online_NoAuto 无自动测速(与Github同步)", "https://raw.githubusercontent.com/ACL4SSR/ACL4SSR/master/Clash/config/ACL4SSR_Online_NoAuto.ini"),
                new SelectItem("ACL4SSR 默认版 分组比较全", "https://raw.githubusercontent.com/ACL4SSR/ACL4SSR/master/Clash/config/ACL4SSR.ini"),
                new SelectItem("ACL4SSR_Mini 精简版", "https://raw.githubusercontent.com/ACL4SSR/ACL4SSR/master/Clash/config/ACL4SSR_Mini.ini"),
                new SelectItem("ACL4SSR_Mini_NoAuto 精简版+无自动测速", "https://raw.githubusercontent.com/ACL4SSR/ACL4SSR/master/Clash/config/ACL4SSR_Mini_NoAuto.ini"),
                new SelectItem("ACL4SSR_Mini_Fallback 精简版+fallback", "https://raw.githubusercontent.com/ACL4SSR/ACL4SSR/master/Clash/config/ACL4SSR_Mini_Fallback.ini"),
                new SelectItem("ACL4SSR_BackCN 回国", "https://raw.githubusercontent.com/ACL4SSR/ACL4SSR/master/Clash/config/ACL4SSR_BackCN.ini"),
                new SelectItem("ACL4SSR_NoApple 无苹果分流", "https://raw.githubusercontent.com/ACL4SSR/ACL4SSR/master/Clash/config/ACL4SSR_NoApple.ini"),
                new SelectItem("ACL4SSR_NoAuto 无自动测速 ", "https://raw.githubusercontent.com/ACL4SSR/ACL4SSR/master/Clash/config/ACL4SSR_NoAuto.ini"),
                new SelectItem("ACL4SSR_NoAuto_NoApple 无自动测速&无苹果分流", "https://raw.githubusercontent.com/ACL4SSR/ACL4SSR/master/Clash/config/ACL4SSR_NoAuto_NoApple.ini"),
                new SelectItem("ACL4SSR_NoMicrosoft 无微软分流", "https://raw.githubusercontent.com/ACL4SSR/ACL4SSR/master/Clash/config/ACL4SSR_NoMicrosoft.ini"),
                new SelectItem("ACL4SSR_WithGFW GFW列表", "https://raw.githubusercontent.com/ACL4SSR/ACL4SSR/master/Clash/config/ACL4SSR_WithGFW.ini"),


                new SelectItem("Universal"){ Enable=false},
                new SelectItem("No-Urltest", "https://cdn.jsdelivr.net/gh/SleepyHeeead/subconverter-config@master/remote-config/universal/no-urltest.ini"),
                new SelectItem("Urltest", "https://cdn.jsdelivr.net/gh/SleepyHeeead/subconverter-config@master/remote-config/universal/urltest.ini"),

                new SelectItem("Customized"){ Enable=false},
                new SelectItem("Nirvana", "https://raw.githubusercontent.com/Mazetsz/ACL4SSR/master/Clash/config/V2rayPro.ini"),
                new SelectItem("V2Pro", "https://raw.githubusercontent.com/Mazeorz/airports/master/Clash/V2Pro.ini"),
                new SelectItem("史迪仔-自动测速", "https://raw.githubusercontent.com/Mazeorz/airports/master/Clash/Stitch.ini"),
                new SelectItem("史迪仔-负载均衡", "https://raw.githubusercontent.com/Mazeorz/airports/master/Clash/Stitch-Balance.ini"),
                new SelectItem("Maying", "https://cdn.jsdelivr.net/gh/SleepyHeeead/subconverter-config@master/remote-config/customized/maying.ini"),
                new SelectItem("Ytoo", "https://cdn.jsdelivr.net/gh/SleepyHeeead/subconverter-config@master/remote-config/customized/ytoo.ini"),
                new SelectItem("FlowerCloud", "https://cdn.jsdelivr.net/gh/SleepyHeeead/subconverter-config@master/remote-config/customized/flowercloud.ini"),
                new SelectItem("NyanCAT", "https://cdn.jsdelivr.net/gh/SleepyHeeead/subconverter-config@master/remote-config/customized/nyancat.ini"),
                new SelectItem("Nexitally", "https://cdn.jsdelivr.net/gh/SleepyHeeead/subconverter-config@master/remote-config/customized/nexitally.ini"),
                new SelectItem("SoCloud", "https://cdn.jsdelivr.net/gh/SleepyHeeead/subconverter-config@master/remote-config/customized/socloud.ini"),
                new SelectItem("ARK", "https://cdn.jsdelivr.net/gh/SleepyHeeead/subconverter-config@master/remote-config/customized/ark.ini"),
                new SelectItem("ssrCloud", "https://cdn.jsdelivr.net/gh/SleepyHeeead/subconverter-config@master/remote-config/customized/ssrcloud.ini"),

                new SelectItem("Special"){ Enable=false},
                new SelectItem("NeteaseUnblock(仅规则，No-Urltest)", "https://cdn.jsdelivr.net/gh/SleepyHeeead/subconverter-config@master/remote-config/special/netease.ini"),
                new SelectItem("Basic(仅GEOIP CN + Final)", "https://cdn.jsdelivr.net/gh/SleepyHeeead/subconverter-config@master/remote-config/special/basic.ini"),
                   


                /**
                new SelectItem("默认", new List<SelectItem>
                {
                    new SelectItem("不选，由接口提供方提供", "https://raw.githubusercontent.com/ACL4SSR/ACL4SSR/master/Clash/config/ACL4SSR_Online.ini")
                }),
                new SelectItem("ACL4SSR")
                { 
                    Sub =  new List<Object>
                    {
                        new SelectItem("ACL4SSR_Online 默认版 分组比较全(与Github同步)", "https://raw.githubusercontent.com/ACL4SSR/ACL4SSR/master/Clash/config/ACL4SSR_Online.ini"),
                        new SelectItem("ACL4SSR_Online_AdblockPlus 更多去广告(与Github同步)", "https://raw.githubusercontent.com/ACL4SSR/ACL4SSR/master/Clash/config/ACL4SSR_Online_AdblockPlus.ini"),
                        new SelectItem("ACL4SSR_Online_MultiCountry 多国分组(与Github同步)", "https://raw.githubusercontent.com/ACL4SSR/ACL4SSR/master/Clash/config/ACL4SSR_Online_MultiCountry.ini"),
                        new SelectItem("ACL4SSR_Online_NoAuto 无自动测速(与Github同步)", "https://raw.githubusercontent.com/ACL4SSR/ACL4SSR/master/Clash/config/ACL4SSR_Online_NoAuto.ini"),
                        new SelectItem("ACL4SSR_Online_NoReject 无广告拦截规则(与Github同步)", "https://raw.githubusercontent.com/ACL4SSR/ACL4SSR/master/Clash/config/ACL4SSR_Online_NoReject.ini"),
                        new SelectItem("ACL4SSR_Online_Mini 精简版(与Github同步)", "https://raw.githubusercontent.com/ACL4SSR/ACL4SSR/master/Clash/config/ACL4SSR_Online_Mini.ini"),
                        new SelectItem("ACL4SSR_Online_Mini_AdblockPlus.ini 精简版 更多去广告(与Github同步)", "https://raw.githubusercontent.com/ACL4SSR/ACL4SSR/master/Clash/config/ACL4SSR_Online_Mini_AdblockPlus.ini"),
                        new SelectItem("ACL4SSR_Online_Mini_NoAuto.ini 精简版 不带自动测速(与Github同步)", "https://raw.githubusercontent.com/ACL4SSR/ACL4SSR/master/Clash/config/ACL4SSR_Online_Mini_NoAuto.ini"),
                        new SelectItem("ACL4SSR_Online_Mini_Fallback.ini 精简版 带故障转移(与Github同步)", "https://raw.githubusercontent.com/ACL4SSR/ACL4SSR/master/Clash/config/ACL4SSR_Online_Mini_Fallback.ini"),
                        new SelectItem("ACL4SSR_Online_Mini_MultiMode.ini 精简版 自动测速、故障转移、负载均衡(与Github同步)", "https://raw.githubusercontent.com/ACL4SSR/ACL4SSR/master/Clash/config/ACL4SSR_Online_Mini_MultiMode.ini"),
                        new SelectItem("ACL4SSR_Online_Mini_MultiCountry.ini 精简版 带港美日国家(与Github同步)", "https://raw.githubusercontent.com/ACL4SSR/ACL4SSR/master/Clash/config/ACL4SSR_Online_Mini_MultiCountry.ini"),
                        new SelectItem("ACL4SSR_Online_Full 全分组 重度用户使用(与Github同步)", "https://raw.githubusercontent.com/ACL4SSR/ACL4SSR/master/Clash/config/ACL4SSR_Online_Full.ini"),
                        new SelectItem("ACL4SSR_Online_Full_MultiMode.ini 全分组 多模式 重度用户使用(与Github同步)", "https://raw.githubusercontent.com/ACL4SSR/ACL4SSR/master/Clash/config/ACL4SSR_Online_Full_MultiMode.ini"),
                        new SelectItem("ACL4SSR_Online_Full_NoAuto.ini 全分组 无自动测速 重度用户使用(与Github同步)", "https://raw.githubusercontent.com/ACL4SSR/ACL4SSR/master/Clash/config/ACL4SSR_Online_Full_NoAuto.ini"),
                        new SelectItem("ACL4SSR_Online_Full_AdblockPlus 全分组 重度用户使用 更多去广告(与Github同步)", "https://raw.githubusercontent.com/ACL4SSR/ACL4SSR/master/Clash/config/ACL4SSR_Online_Full_AdblockPlus.ini"),
                        new SelectItem("ACL4SSR_Online_Full_Netflix 全分组 重度用户使用 奈飞全量(与Github同步)", "https://raw.githubusercontent.com/ACL4SSR/ACL4SSR/master/Clash/config/ACL4SSR_Online_Full_Netflix.ini"),
                        new SelectItem("ACL4SSR_Online_Full_Google 全分组 重度用户使用 谷歌细分(与Github同步)", "https://raw.githubusercontent.com/ACL4SSR/ACL4SSR/master/Clash/config/ACL4SSR_Online_Full_Google.ini"),
                        new SelectItem("ACL4SSR 默认版 分组比较全", "https://raw.githubusercontent.com/ACL4SSR/ACL4SSR/master/Clash/config/ACL4SSR.ini"),
                        new SelectItem("ACL4SSR_Mini 精简版", "https://raw.githubusercontent.com/ACL4SSR/ACL4SSR/master/Clash/config/ACL4SSR_Mini.ini"),
                        new SelectItem("ACL4SSR_Mini_NoAuto.ini 精简版+无自动测速", "https://raw.githubusercontent.com/ACL4SSR/ACL4SSR/master/Clash/config/ACL4SSR_Mini_NoAuto.ini"),
                        new SelectItem("ACL4SSR_Mini_Fallback.ini 精简版+fallback", "https://raw.githubusercontent.com/ACL4SSR/ACL4SSR/master/Clash/config/ACL4SSR_Mini_Fallback.ini"),
                        new SelectItem("ACL4SSR_BackCN 回国", "https://raw.githubusercontent.com/ACL4SSR/ACL4SSR/master/Clash/config/ACL4SSR_BackCN.ini"),
                        new SelectItem("ACL4SSR_NoApple 无苹果分流", "https://raw.githubusercontent.com/ACL4SSR/ACL4SSR/master/Clash/config/ACL4SSR_NoApple.ini"),
                        new SelectItem("ACL4SSR_NoAuto 无自动测速 ", "https://raw.githubusercontent.com/ACL4SSR/ACL4SSR/master/Clash/config/ACL4SSR_NoAuto.ini"),
                        new SelectItem("ACL4SSR_NoAuto_NoApple 无自动测速&无苹果分流", "https://raw.githubusercontent.com/ACL4SSR/ACL4SSR/master/Clash/config/ACL4SSR_NoAuto_NoApple.ini"),
                        new SelectItem("ACL4SSR_NoMicrosoft 无微软分流", "https://raw.githubusercontent.com/ACL4SSR/ACL4SSR/master/Clash/config/ACL4SSR_NoMicrosoft.ini"),
                        new SelectItem("ACL4SSR_WithGFW GFW列表", "https://raw.githubusercontent.com/ACL4SSR/ACL4SSR/master/Clash/config/ACL4SSR_WithGFW.ini")
                    }
                },
                new SelectItem("universal")
                {
                    Sub =  new List<Object>
                    {
                        new SelectItem("No-Urltest", "https://cdn.jsdelivr.net/gh/SleepyHeeead/subconverter-config@master/remote-config/universal/no-urltest.ini"),
                        new SelectItem("Urltest", "https://cdn.jsdelivr.net/gh/SleepyHeeead/subconverter-config@master/remote-config/universal/urltest.ini")
                    }
                },
                new SelectItem("customized")
                {
                    Sub =  new List<Object>
                    {
                        new SelectItem("Nirvana", "https://raw.githubusercontent.com/Mazetsz/ACL4SSR/master/Clash/config/V2rayPro.ini"),
                        new SelectItem("V2Pro", "https://raw.githubusercontent.com/Mazeorz/airports/master/Clash/V2Pro.ini"),
                        new SelectItem("史迪仔-自动测速", "https://raw.githubusercontent.com/Mazeorz/airports/master/Clash/Stitch.ini"),
                        new SelectItem("史迪仔-负载均衡", "https://raw.githubusercontent.com/Mazeorz/airports/master/Clash/Stitch-Balance.ini"),
                        new SelectItem("Maying", "https://cdn.jsdelivr.net/gh/SleepyHeeead/subconverter-config@master/remote-config/customized/maying.ini"),
                        new SelectItem("Ytoo", "https://cdn.jsdelivr.net/gh/SleepyHeeead/subconverter-config@master/remote-config/customized/ytoo.ini"),
                        new SelectItem("FlowerCloud", "https://cdn.jsdelivr.net/gh/SleepyHeeead/subconverter-config@master/remote-config/customized/flowercloud.ini"),
                        new SelectItem("NyanCAT", "https://cdn.jsdelivr.net/gh/SleepyHeeead/subconverter-config@master/remote-config/customized/nyancat.ini"),
                        new SelectItem("Nexitally", "https://cdn.jsdelivr.net/gh/SleepyHeeead/subconverter-config@master/remote-config/customized/nexitally.ini"),
                        new SelectItem("SoCloud", "https://cdn.jsdelivr.net/gh/SleepyHeeead/subconverter-config@master/remote-config/customized/socloud.ini"),
                        new SelectItem("ARK", "https://cdn.jsdelivr.net/gh/SleepyHeeead/subconverter-config@master/remote-config/customized/ark.ini"),
                        new SelectItem("ssrCloud", "https://cdn.jsdelivr.net/gh/SleepyHeeead/subconverter-config@master/remote-config/customized/ssrcloud.ini")
                    }
                },
                new SelectItem("Special")
                {
                    Sub =  new List<Object>
                    {
                        new SelectItem("NeteaseUnblock(仅规则，No-Urltest)", "https://cdn.jsdelivr.net/gh/SleepyHeeead/subconverter-config@master/remote-config/special/netease.ini"),
                        new SelectItem("Basic(仅GEOIP CN + Final)", "https://cdn.jsdelivr.net/gh/SleepyHeeead/subconverter-config@master/remote-config/special/basic.ini")
                    }
                },
                **/
            };
            return remoteConfigs;
        }
    }
}
