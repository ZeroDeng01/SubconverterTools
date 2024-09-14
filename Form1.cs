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
        /// ���ƶ�������
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

            #region ��������
            var sourceSub = input_sourceSubUrl.Text;
            sourceSub = Regex.Replace(sourceSub, @"(\n|\r|\r\n)", "|");//��������
            customSubUrl = select_customBackend.SelectedValue + //��Ӻ�˷�����
                "target=" + select_clientType.SelectedValue +  //��ӿͻ�������
                "&url=" + Uri.EscapeDataString(sourceSub);

            // Զ������
            if (select_remoteConfig.SelectedIndex > -1)
            {
                customSubUrl +=
                    "&config=" + Uri.EscapeDataString(select_remoteConfig.SelectedValue.ToString());
            }
            // �ų��ڵ�
            if (input_excludeRemarks.Text.Length > 0)
            {
                customSubUrl +=
                  "&exclude=" + Uri.EscapeDataString(input_excludeRemarks.Text);
            }
            // �����ڵ�
            if (input_includeRemarks.Text.Length > 0)
            {
                customSubUrl +=
                  "&include=" + Uri.EscapeDataString(input_includeRemarks.Text);
            }
            // �ļ�����
            if (input_filename.Text.Length > 0)
            {
                customSubUrl +=
                  "&filename=" + Uri.EscapeDataString(input_filename.Text);
            }

            // check bool��������
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

            AntdUI.Modal.open(new AntdUI.Modal.Config(this, "�����������ɳɹ�", customSubUrl.Substring(0, 100) + "........." + customSubUrl.Substring(customSubUrl.Length - 100), AntdUI.TType.Success)
            {
                Btns = new AntdUI.Modal.Btn[] { new AntdUI.Modal.Btn("copy", "��������", AntdUI.TTypeMini.Success) },
                OnBtns = btn =>
                {
                    Copy(customSubUrl);
                },
                CancelText = null,
                OkText = "֪����"
            });
            #endregion


        }

        /// <summary>
        /// ������֤
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
                AntdUI.Modal.open(new AntdUI.Modal.Config(this, "����������", "����/�������ӱ���", AntdUI.TType.Warn)
                {
                    CancelText = null,
                    OkText = "֪����"
                });
                return false;
            }
            if (select_clientType.SelectedIndex < 0)
            {
                AntdUI.Modal.open(new AntdUI.Modal.Config(this, "����������", "�ͻ������ͱ���", AntdUI.TType.Warn)
                {
                    CancelText = null,
                    OkText = "֪����"
                });
                return false;
            }

            if (select_customBackend.SelectedIndex < 0)
            {
                AntdUI.Modal.open(new AntdUI.Modal.Config(this, "����������", "��˷���������", AntdUI.TType.Warn)
                {
                    CancelText = null,
                    OkText = "֪����"
                });
                return false;
            }
            return true;
        }

        /// <summary>
        /// ���ݸ���
        /// </summary>
        /// <param name="text"></param>
        private void Copy(string text)
        {
            Clipboard.SetText(text);
            AntdUI.Message.success(this, "���Ƴɹ�", Font);
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
                    AntdUI.Modal.open(new AntdUI.Modal.Config(this, "����������ʧ��", "�������ӻ�δ���ɣ��������ɶ�������", AntdUI.TType.Warn)
                    {
                        CancelText = null,
                        OkText = "֪����"
                    });
                    return;
                }

                string shortUrl = await ShortURL.Short(input_subUrl.Text, select_shortUrlBackend.SelectedValue.ToString());

                if (shortUrl != null)
                {
                    input_shortSubUrl.Text = shortUrl;
                    AntdUI.Modal.open(new AntdUI.Modal.Config(this, "���������ɳɹ�", shortUrl, AntdUI.TType.Success)
                    {
                        Btns = new AntdUI.Modal.Btn[] { new AntdUI.Modal.Btn("copy", "��������", AntdUI.TTypeMini.Success) },
                        OnBtns = btn =>
                        {
                            Copy(shortUrl);
                        },
                        CancelText = null,
                        OkText = "֪����"
                    });
                }
                else
                {
                    AntdUI.Modal.open(new AntdUI.Modal.Config(this, "����������ʧ��", $"����������ʧ�ܣ������³��ԣ���������ǰ��{ShortURL.requestUrl}�����ֶ�����", AntdUI.TType.Error)
                    {
                        Btns = new AntdUI.Modal.Btn[] { new AntdUI.Modal.Btn("copy", "��������", AntdUI.TTypeMini.Success) },
                        OnBtns = btn =>
                        {
                            Copy(ShortURL.requestUrl);
                        },
                        CancelText = null,
                        OkText = "֪����"
                    });
                    return;
                }
            }
            catch (Exception ex)
            {
                AntdUI.Modal.open(new AntdUI.Modal.Config(this, "����������ʧ��", $"����������ʧ�ܣ������³��ԣ���������ǰ��{Utils.ShortURL.requestUrl}�����ֶ�����", AntdUI.TType.Error)
                {
                    Btns = new AntdUI.Modal.Btn[] { new AntdUI.Modal.Btn("copy", "��������", AntdUI.TTypeMini.Success) },
                    OnBtns = btn =>
                    {
                        Copy(ShortURL.requestUrl);
                    },
                    CancelText = null,
                    OkText = "֪����"
                });
            }
            finally
            {
                button_makeShortUrl.Loading = false;
            }

        }

        private async void select_customBackend_SelectedValueChanged(object sender, ObjectNEventArgs e)
        {
            label_backendVersion.Text = "��ȡ��˰汾��...";
            string version = await BackendVersion.GetVersionAsync(select_customBackend.SelectedValue.ToString());
            label_backendVersion.Text = version == string.Empty ? "��ȡ��˰汾ʧ��" : "��˰汾��" + version;
        }

        private void button_parseUrl_Click(object sender, EventArgs e)
        {

            if (input_parseUrl.Text.Trim() == string.Empty)
            {
                AntdUI.Modal.open(new AntdUI.Modal.Config(this, "����������", "����д������URL", AntdUI.TType.Warn)
                {
                    CancelText = null,
                    OkText = "֪����"
                });
                return;
            }

            button_parseUrl.Loading = true;
            var inputUrl = input_parseUrl.Text;

            // ����URL
            var uri = new Uri(inputUrl);
            // ��ȡ���� URL
            var customBackend = uri.GetLeftPart(UriPartial.Path);
            select_customBackend.SelectedValue = customBackend + "?";
            // ��ȡ����
            var queryParams = HttpUtility.ParseQueryString(uri.Query);

            // �Ӳ�ѯ�����л�ȡֵ�����¿ؼ�
            select_clientType.SelectedValue = queryParams["target"];
            input_sourceSubUrl.Text = Uri.UnescapeDataString(queryParams["url"]);

            // ������ѡ����
            if (queryParams["config"] != null)
            {
                select_remoteConfig.SelectedValue = Uri.UnescapeDataString(queryParams["config"]);
            }
            input_excludeRemarks.Text = Uri.UnescapeDataString(queryParams["exclude"] ?? string.Empty);
            input_includeRemarks.Text = Uri.UnescapeDataString(queryParams["include"] ?? string.Empty);
            input_filename.Text = Uri.UnescapeDataString(queryParams["filename"] ?? string.Empty);

            // �����������Ͳ���
            checkbox_appendType.Checked = bool.TryParse(queryParams["append_type"], out bool appendTypeValue) && appendTypeValue;
            checkbox_emoji.Checked = bool.TryParse(queryParams["emoji"], out bool emojiValue) && emojiValue;
            checkbox_nodeList.Checked = bool.TryParse(queryParams["list"], out bool listValue) && listValue;
            checkbox_tfo.Checked = bool.TryParse(queryParams["tfo"], out bool tfoValue) && tfoValue;
            checkbox_scv.Checked = bool.TryParse(queryParams["scv"], out bool scvValue) && scvValue;
            checkbox_fdn.Checked = bool.TryParse(queryParams["fdn"], out bool fdnValue) && fdnValue;
            checkbox_expand.Checked = bool.TryParse(queryParams["expand"], out bool expandValue) && expandValue;
            checkbox_sort.Checked = bool.TryParse(queryParams["sort"], out bool sortValue) && sortValue;
            checkbox_udp.Checked = bool.TryParse(queryParams["udp"], out bool udpValue) && udpValue;

            // ���������DOH����
            checkbox_surgeDoh.Checked = queryParams["surge.doh"] == "true";
            checkbox_clashDoh.Checked = queryParams["clash.doh"] == "true";
            button_parseUrl.Loading = false;
        }

        private void button_github_Click(object sender, EventArgs e)
        {
            string url = "https://github.com/ZeroDeng01/SubconverterTools";
            try
            {
                // ʹ��Ĭ���������ָ����ַ
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
            AntdUI.Notification.warn(this, "��ܰ��ʾ", "���߲��Ա�������ȶ��Ը��𣬱�������ṩ�ķ�������Դ�����磬�����Լ����˷�����!", AntdUI.TAlignFrom.TR, Font);
        }
    }
}
