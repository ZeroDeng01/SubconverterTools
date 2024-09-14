using AntdUI;
using SubconverterTools.Utils;
using System.Diagnostics;
using System.Text.RegularExpressions;
using System.Web;
using System.Windows.Forms;

namespace SubconverterTools
{
    public partial class Form1 : AntdUI.Window
    {
        /// <summary>
        /// 定制订阅连接
        /// </summary>
        private string customSubUrl = string.Empty;
        public Form1()
        {
            InitializeComponent();
            select_clientType.Items.AddRange(BaseData.ClientTypes.GetItem().ToArray());
            select_clientType.SelectedIndex = 0;
            select_customBackend.Items.AddRange(BaseData.CustomBackends.GetItem().ToArray());
            select_customBackend.SelectedIndex = 0;
            select_remoteConfig.Items.AddRange(BaseData.RemoteConfigs.GetItem().ToArray());
            select_remoteConfig.SelectedIndex = 0;
            select_shortUrlBackend.Items.AddRange(BaseData.ShortUrlBackends.GetItem().ToArray());
            select_shortUrlBackend.SelectedIndex = 0;
        }

        private void button_makeUrl_Click(object sender, EventArgs e)
        {
            if (!verify())
            {
                return;
            }

            #region 参数构造
            var sourceSub = input_sourceSubUrl.Text;
            sourceSub = Regex.Replace(sourceSub, @"(\n|\r|\r\n)", "|");//订阅连接
            customSubUrl = select_customBackend.SelectedValue + //添加后端服务器
                "target=" + select_clientType.SelectedValue +  //添加客户端类型
                "&url=" + Uri.EscapeDataString(sourceSub);

            // 远程配置
            if (select_remoteConfig.SelectedIndex > -1)
            {
                customSubUrl +=
                    "&config=" + Uri.EscapeDataString(select_remoteConfig.SelectedValue.ToString());
            }
            // 排除节点
            if (input_excludeRemarks.Text.Length > 0)
            {
                customSubUrl +=
                  "&exclude=" + Uri.EscapeDataString(input_excludeRemarks.Text);
            }
            // 包含节点
            if (input_includeRemarks.Text.Length > 0)
            {
                customSubUrl +=
                  "&include=" + Uri.EscapeDataString(input_includeRemarks.Text);
            }
            // 文件名称
            if (input_filename.Text.Length > 0)
            {
                customSubUrl +=
                  "&filename=" + Uri.EscapeDataString(input_filename.Text);
            }

            // check bool类型配置
            customSubUrl +=
            "&append_type=" + checkbox_appendType.Checked +
            "&emoji=" + checkbox_emoji.Checked +
            "&list=" + checkbox_nodeList.Checked +
            "&tfo=" + checkbox_tfo.Checked +
            "&scv=" + checkbox_scv.Checked +
            "&fdn=" + checkbox_fdn.Checked +
            "&expand=" + checkbox_expand.Checked +
            "&sort=" + checkbox_sort.Checked +
            "&udp=" + checkbox_udp.Checked;

            if (checkbox_surgeDoh.Checked)
            {
                customSubUrl += "&surge.doh=true";
            }
            if (checkbox_clashDoh.Checked)
            {
                customSubUrl += "&clash.doh=true";
            }
            input_subUrl.Text = customSubUrl;

            AntdUI.Modal.open(new AntdUI.Modal.Config(this, "订阅连接生成成功", customSubUrl.Substring(0, 100) + "........." + customSubUrl.Substring(customSubUrl.Length - 100), AntdUI.TType.Success)
            {
                Btns = new AntdUI.Modal.Btn[] { new AntdUI.Modal.Btn("copy", "复制连接", AntdUI.TTypeMini.Success) },
                OnBtns = btn =>
                {
                    Copy(customSubUrl);
                },
                CancelText = null,
                OkText = "知道了"
            });
            #endregion


        }

        /// <summary>
        /// 参数验证
        /// </summary>
        /// <returns></returns>
        private Boolean verify()
        {

            if (select_remoteConfig.SelectedIndex < 0)
            {
                select_remoteConfig.SelectedIndex = 0;
            }

            if (input_sourceSubUrl.Text.Trim() == string.Empty)
            {
                AntdUI.Modal.open(new AntdUI.Modal.Config(this, "参数不完整", "订阅/代理连接必填", AntdUI.TType.Warn)
                {
                    CancelText = null,
                    OkText = "知道了"
                });
                return false;
            }
            if (select_clientType.SelectedIndex < 0)
            {
                AntdUI.Modal.open(new AntdUI.Modal.Config(this, "参数不完整", "客户端类型必填", AntdUI.TType.Warn)
                {
                    CancelText = null,
                    OkText = "知道了"
                });
                return false;
            }

            if (select_customBackend.SelectedIndex < 0)
            {
                AntdUI.Modal.open(new AntdUI.Modal.Config(this, "参数不完整", "后端服务器必填", AntdUI.TType.Warn)
                {
                    CancelText = null,
                    OkText = "知道了"
                });
                return false;
            }
            return true;
        }

        /// <summary>
        /// 内容复制
        /// </summary>
        /// <param name="text"></param>
        private void Copy(string text)
        {
            Clipboard.SetText(text);
            AntdUI.Message.success(this, "复制成功", Font);
        }
        private void button_copySubUrl_Click(object sender, EventArgs e)
        {
            if (input_subUrl.Text == string.Empty)
            {
                return;
            }
            Copy(input_subUrl.Text);
        }
        private void button_copyShortUrl_Click(object sender, EventArgs e)
        {
            if (input_shortSubUrl.Text == string.Empty)
            {
                return;
            }
            Copy(input_shortSubUrl.Text);
        }

        private async void button_makeShortUrl_Click(object sender, EventArgs e)
        {
            button_makeShortUrl.Loading = true;
            try
            {
                if (input_subUrl.Text == string.Empty)
                {
                    AntdUI.Modal.open(new AntdUI.Modal.Config(this, "短链接生成失败", "订阅链接还未生成，请先生成订阅链接", AntdUI.TType.Warn)
                    {
                        CancelText = null,
                        OkText = "知道了"
                    });
                    return;
                }

                string shortUrl = await ShortURL.Short(input_subUrl.Text, select_shortUrlBackend.SelectedValue.ToString());

                if (shortUrl != null)
                {
                    input_shortSubUrl.Text = shortUrl;
                    AntdUI.Modal.open(new AntdUI.Modal.Config(this, "短链接生成成功", shortUrl, AntdUI.TType.Success)
                    {
                        Btns = new AntdUI.Modal.Btn[] { new AntdUI.Modal.Btn("copy", "复制连接", AntdUI.TTypeMini.Success) },
                        OnBtns = btn =>
                        {
                            Copy(shortUrl);
                        },
                        CancelText = null,
                        OkText = "知道了"
                    });
                }
                else
                {
                    AntdUI.Modal.open(new AntdUI.Modal.Config(this, "短链接生成失败", $"短链接生成失败，请重新尝试！或者自行前往{ShortURL.requestUrl}进行手动生成", AntdUI.TType.Error)
                    {
                        Btns = new AntdUI.Modal.Btn[] { new AntdUI.Modal.Btn("copy", "复制连接", AntdUI.TTypeMini.Success) },
                        OnBtns = btn =>
                        {
                            Copy(ShortURL.requestUrl);
                        },
                        CancelText = null,
                        OkText = "知道了"
                    });
                    return;
                }
            }
            catch (Exception ex)
            {
                AntdUI.Modal.open(new AntdUI.Modal.Config(this, "短链接生成失败", $"短链接生成失败，请重新尝试！或者自行前往{Utils.ShortURL.requestUrl}进行手动生成", AntdUI.TType.Error)
                {
                    Btns = new AntdUI.Modal.Btn[] { new AntdUI.Modal.Btn("copy", "复制连接", AntdUI.TTypeMini.Success) },
                    OnBtns = btn =>
                    {
                        Copy(ShortURL.requestUrl);
                    },
                    CancelText = null,
                    OkText = "知道了"
                });
            }
            finally
            {
                button_makeShortUrl.Loading = false;
            }

        }

        private async void select_customBackend_SelectedValueChanged(object sender, ObjectNEventArgs e)
        {
            label_backendVersion.Text = "获取后端版本中...";
            string version = await BackendVersion.GetVersionAsync(select_customBackend.SelectedValue.ToString());
            label_backendVersion.Text = version == string.Empty ? "获取后端版本失败" : "后端版本：" + version;
        }

        private void button_parseUrl_Click(object sender, EventArgs e)
        {

            if (input_parseUrl.Text.Trim() == string.Empty)
            {
                AntdUI.Modal.open(new AntdUI.Modal.Config(this, "参数不完整", "请填写待解析URL", AntdUI.TType.Warn)
                {
                    CancelText = null,
                    OkText = "知道了"
                });
                return;
            }

            button_parseUrl.Loading = true;
            var inputUrl = input_parseUrl.Text;

            // 解析URL
            var uri = new Uri(inputUrl);
            // 提取基础 URL
            var customBackend = uri.GetLeftPart(UriPartial.Path);
            select_customBackend.SelectedValue = customBackend + "?";
            // 提取参数
            var queryParams = HttpUtility.ParseQueryString(uri.Query);

            // 从查询参数中获取值并更新控件
            select_clientType.SelectedValue = queryParams["target"];
            input_sourceSubUrl.Text = Uri.UnescapeDataString(queryParams["url"]);

            // 解析可选参数
            if (queryParams["config"] != null)
            {
                select_remoteConfig.SelectedValue = Uri.UnescapeDataString(queryParams["config"]);
            }
            input_excludeRemarks.Text = Uri.UnescapeDataString(queryParams["exclude"] ?? string.Empty);
            input_includeRemarks.Text = Uri.UnescapeDataString(queryParams["include"] ?? string.Empty);
            input_filename.Text = Uri.UnescapeDataString(queryParams["filename"] ?? string.Empty);

            // 解析布尔类型参数
            checkbox_appendType.Checked = bool.TryParse(queryParams["append_type"], out bool appendTypeValue) && appendTypeValue;
            checkbox_emoji.Checked = bool.TryParse(queryParams["emoji"], out bool emojiValue) && emojiValue;
            checkbox_nodeList.Checked = bool.TryParse(queryParams["list"], out bool listValue) && listValue;
            checkbox_tfo.Checked = bool.TryParse(queryParams["tfo"], out bool tfoValue) && tfoValue;
            checkbox_scv.Checked = bool.TryParse(queryParams["scv"], out bool scvValue) && scvValue;
            checkbox_fdn.Checked = bool.TryParse(queryParams["fdn"], out bool fdnValue) && fdnValue;
            checkbox_expand.Checked = bool.TryParse(queryParams["expand"], out bool expandValue) && expandValue;
            checkbox_sort.Checked = bool.TryParse(queryParams["sort"], out bool sortValue) && sortValue;
            checkbox_udp.Checked = bool.TryParse(queryParams["udp"], out bool udpValue) && udpValue;

            // 解析额外的DOH参数
            checkbox_surgeDoh.Checked = queryParams["surge.doh"] == "true";
            checkbox_clashDoh.Checked = queryParams["clash.doh"] == "true";
            button_parseUrl.Loading = false;
        }

        private void button_github_Click(object sender, EventArgs e)
        {
            string url = "https://github.com/ZeroDeng01/SubconverterTools";
            try
            {
                // 使用默认浏览器打开指定网址
                Process.Start(new ProcessStartInfo
                {
                    FileName = url,
                    UseShellExecute = true
                });
            }
            catch (Exception ex)
            {
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            AntdUI.Notification.warn(this, "温馨提示", "作者不对本软件的稳定性负责，本软件所提供的服务器来源于网络，建议自己搭建后端服务器!", AntdUI.TAlignFrom.TR, Font);
        }
    }
}
