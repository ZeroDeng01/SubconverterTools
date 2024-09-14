using AntdUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubconverterTools.BaseData
{


    public class ClientTypes
    {

        /// <summary>
        /// 客户端列表
        /// </summary>
        /// <returns></returns>
        public static List<SelectItem> GetItem() {
            var clientTypes = new List<SelectItem>
            {
                new SelectItem("Clash新参数", "clash&new_name=true"),
                new SelectItem("ClashR新参数", "clashr&new_name=true"),
                new SelectItem("Clash", "clash"),
                new SelectItem("Surge4", "surge&ver=4"),
                new SelectItem("Surge3", "surge&ver=3"),
                new SelectItem("Surge2", "surge&ver=2"),
                new SelectItem("Quantumult", "when"),
                new SelectItem("QuantumultX", "quanx"),
                new SelectItem("Mellow", "mellow"),
                new SelectItem("Surfboard", "surfboard"),
                new SelectItem("Loon", "loon"),
                new SelectItem("singbox", "singbox"),
                new SelectItem("ss", "ss"),
                new SelectItem("ssd", "ssd"),
                new SelectItem("sssub", "sssub"),
                new SelectItem("ssr", "ssr"),
                new SelectItem("Class", "Classer"),
                new SelectItem("V2Ray", "v2ray"),
                new SelectItem("Trojan", "trojan"),
            };
            return clientTypes;
        }

    }
}
