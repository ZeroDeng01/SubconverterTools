namespace SubconverterTools
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            windowBar1 = new AntdUI.WindowBar();
            button_github = new AntdUI.Button();
            label1 = new AntdUI.Label();
            input_sourceSubUrl = new AntdUI.Input();
            label2 = new AntdUI.Label();
            select_clientType = new AntdUI.Select();
            select_remoteConfig = new AntdUI.Select();
            label3 = new AntdUI.Label();
            select_customBackend = new AntdUI.Select();
            label4 = new AntdUI.Label();
            label5 = new AntdUI.Label();
            input_includeRemarks = new AntdUI.Input();
            input_excludeRemarks = new AntdUI.Input();
            label6 = new AntdUI.Label();
            panel1 = new AntdUI.Panel();
            checkbox_appendInfo = new AntdUI.Checkbox();
            label17 = new AntdUI.Label();
            input_remarks = new AntdUI.Input();
            label16 = new AntdUI.Label();
            input_group = new AntdUI.Input();
            checkbox_tfo = new AntdUI.Checkbox();
            label8 = new AntdUI.Label();
            input_filename = new AntdUI.Input();
            checkbox_nodeList = new AntdUI.Checkbox();
            checkbox_clashDNS = new AntdUI.Checkbox();
            checkbox_expand = new AntdUI.Checkbox();
            checkbox_fdn = new AntdUI.Checkbox();
            checkbox_sort = new AntdUI.Checkbox();
            checkbox_appendType = new AntdUI.Checkbox();
            checkbox_udp = new AntdUI.Checkbox();
            checkbox_scv = new AntdUI.Checkbox();
            checkbox_emoji = new AntdUI.Checkbox();
            label7 = new AntdUI.Label();
            input_subUrl = new AntdUI.Input();
            panel2 = new AntdUI.Panel();
            label_backendVersion = new AntdUI.Label();
            label12 = new AntdUI.Label();
            select_shortUrlBackend = new AntdUI.Select();
            label11 = new AntdUI.Label();
            label9 = new AntdUI.Label();
            label10 = new AntdUI.Label();
            input_shortSubUrl = new AntdUI.Input();
            button_makeUrl = new AntdUI.Button();
            button_makeShortUrl = new AntdUI.Button();
            button_copySubUrl = new AntdUI.Button();
            button_copyShortUrl = new AntdUI.Button();
            panel3 = new AntdUI.Panel();
            input_parseUrl = new AntdUI.Input();
            button_log = new AntdUI.Button();
            alert_subServerStatus = new AntdUI.Alert();
            button_subServerTest = new AntdUI.Button();
            button_subServerStart = new AntdUI.Button();
            button_subServerStop = new AntdUI.Button();
            label15 = new AntdUI.Label();
            alert1 = new AntdUI.Alert();
            label13 = new AntdUI.Label();
            button_parseUrl = new AntdUI.Button();
            label14 = new AntdUI.Label();
            button_qrcodeShortUrl = new AntdUI.Button();
            windowBar1.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // windowBar1
            // 
            windowBar1.Controls.Add(button_github);
            windowBar1.Dock = DockStyle.Top;
            windowBar1.Font = new Font("Microsoft YaHei UI", 11F);
            windowBar1.IconSvg = resources.GetString("windowBar1.IconSvg");
            windowBar1.IsMax = false;
            windowBar1.Location = new Point(0, 0);
            windowBar1.Margin = new Padding(2, 3, 2, 3);
            windowBar1.MaximizeBox = false;
            windowBar1.Name = "windowBar1";
            windowBar1.Size = new Size(1011, 38);
            windowBar1.SubText = "by ZeroDeng";
            windowBar1.TabIndex = 0;
            windowBar1.Text = "订阅转换工具";
            // 
            // button_github
            // 
            button_github.Font = new Font("Microsoft YaHei UI", 16F);
            button_github.IconSvg = resources.GetString("button_github.IconSvg");
            button_github.Location = new Point(891, 5);
            button_github.Margin = new Padding(2, 3, 2, 3);
            button_github.Name = "button_github";
            button_github.Shape = AntdUI.TShape.Circle;
            button_github.Size = new Size(35, 33);
            button_github.TabIndex = 38;
            button_github.Click += button_github_Click;
            // 
            // label1
            // 
            label1.Font = new Font("Microsoft YaHei UI", 10F);
            label1.ForeColor = Color.FromArgb(60, 120, 216);
            label1.Location = new Point(12, 37);
            label1.Margin = new Padding(2, 3, 2, 3);
            label1.Name = "label1";
            label1.Size = new Size(152, 26);
            label1.TabIndex = 1;
            label1.Text = "订阅/代理连接（必填）";
            // 
            // input_sourceSubUrl
            // 
            input_sourceSubUrl.AutoScroll = true;
            input_sourceSubUrl.Location = new Point(12, 62);
            input_sourceSubUrl.Margin = new Padding(2, 3, 2, 3);
            input_sourceSubUrl.Multiline = true;
            input_sourceSubUrl.Name = "input_sourceSubUrl";
            input_sourceSubUrl.PlaceholderText = "支持订阅或ss/ssr/vmess链接，多个链接每行一个或用 | 分隔";
            input_sourceSubUrl.Size = new Size(605, 70);
            input_sourceSubUrl.TabIndex = 2;
            // 
            // label2
            // 
            label2.Font = new Font("Microsoft YaHei UI", 10F);
            label2.ForeColor = Color.FromArgb(60, 120, 216);
            label2.Location = new Point(12, 138);
            label2.Margin = new Padding(2, 3, 2, 3);
            label2.Name = "label2";
            label2.Size = new Size(152, 26);
            label2.TabIndex = 3;
            label2.Text = "客户端类型（必填）";
            // 
            // select_clientType
            // 
            select_clientType.Location = new Point(12, 162);
            select_clientType.Margin = new Padding(2, 3, 2, 3);
            select_clientType.MaxCount = 10;
            select_clientType.Name = "select_clientType";
            select_clientType.PlaceholderText = "请选择客户端";
            select_clientType.Size = new Size(605, 38);
            select_clientType.TabIndex = 4;
            // 
            // select_remoteConfig
            // 
            select_remoteConfig.Location = new Point(12, 283);
            select_remoteConfig.Margin = new Padding(2, 3, 2, 3);
            select_remoteConfig.MaxCount = 10;
            select_remoteConfig.Name = "select_remoteConfig";
            select_remoteConfig.PlaceholderText = "请选择远程配置文件";
            select_remoteConfig.Size = new Size(605, 38);
            select_remoteConfig.TabIndex = 6;
            // 
            // label3
            // 
            label3.Font = new Font("Microsoft YaHei UI", 10F);
            label3.ForeColor = Color.FromArgb(60, 120, 216);
            label3.Location = new Point(11, 261);
            label3.Margin = new Padding(2, 3, 2, 3);
            label3.Name = "label3";
            label3.Size = new Size(152, 26);
            label3.TabIndex = 5;
            label3.Text = "远程配置";
            // 
            // select_customBackend
            // 
            select_customBackend.Location = new Point(12, 224);
            select_customBackend.Margin = new Padding(2, 3, 2, 3);
            select_customBackend.MaxCount = 10;
            select_customBackend.Name = "select_customBackend";
            select_customBackend.PlaceholderText = "请选择后端服务器,自定义后端请输入后端地址，例如https://test.domain.com";
            select_customBackend.Size = new Size(605, 38);
            select_customBackend.TabIndex = 8;
            select_customBackend.SelectedValueChanged += select_customBackend_SelectedValueChanged;
            // 
            // label4
            // 
            label4.Font = new Font("Microsoft YaHei UI", 10F);
            label4.ForeColor = Color.FromArgb(60, 120, 216);
            label4.Location = new Point(12, 199);
            label4.Margin = new Padding(2, 3, 2, 3);
            label4.Name = "label4";
            label4.Size = new Size(91, 26);
            label4.TabIndex = 7;
            label4.Text = "后端服务器";
            // 
            // label5
            // 
            label5.Font = new Font("Microsoft YaHei UI", 10F);
            label5.ForeColor = Color.FromArgb(60, 120, 216);
            label5.Location = new Point(12, 384);
            label5.Margin = new Padding(2, 3, 2, 3);
            label5.Name = "label5";
            label5.Size = new Size(152, 26);
            label5.TabIndex = 9;
            label5.Text = "包含节点";
            // 
            // input_includeRemarks
            // 
            input_includeRemarks.Location = new Point(11, 408);
            input_includeRemarks.Margin = new Padding(2, 3, 2, 3);
            input_includeRemarks.Name = "input_includeRemarks";
            input_includeRemarks.PlaceholderText = "节点名包含的关键字，支持正则";
            input_includeRemarks.Size = new Size(605, 39);
            input_includeRemarks.TabIndex = 10;
            // 
            // input_excludeRemarks
            // 
            input_excludeRemarks.Location = new Point(11, 474);
            input_excludeRemarks.Margin = new Padding(2, 3, 2, 3);
            input_excludeRemarks.Name = "input_excludeRemarks";
            input_excludeRemarks.PlaceholderText = "节点名不包含的关键字，支持正则";
            input_excludeRemarks.Size = new Size(605, 39);
            input_excludeRemarks.TabIndex = 12;
            // 
            // label6
            // 
            label6.Font = new Font("Microsoft YaHei UI", 10F);
            label6.ForeColor = Color.FromArgb(60, 120, 216);
            label6.Location = new Point(12, 447);
            label6.Margin = new Padding(2, 3, 2, 3);
            label6.Name = "label6";
            label6.Size = new Size(152, 26);
            label6.TabIndex = 11;
            label6.Text = "排除节点";
            // 
            // panel1
            // 
            panel1.BorderWidth = 1F;
            panel1.Controls.Add(checkbox_appendInfo);
            panel1.Controls.Add(label17);
            panel1.Controls.Add(input_remarks);
            panel1.Controls.Add(label16);
            panel1.Controls.Add(input_group);
            panel1.Controls.Add(checkbox_tfo);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(input_filename);
            panel1.Controls.Add(checkbox_nodeList);
            panel1.Controls.Add(checkbox_clashDNS);
            panel1.Controls.Add(checkbox_expand);
            panel1.Controls.Add(checkbox_fdn);
            panel1.Controls.Add(checkbox_sort);
            panel1.Controls.Add(checkbox_appendType);
            panel1.Controls.Add(checkbox_udp);
            panel1.Controls.Add(checkbox_scv);
            panel1.Controls.Add(checkbox_emoji);
            panel1.Controls.Add(label7);
            panel1.Location = new Point(644, 48);
            panel1.Margin = new Padding(2, 3, 2, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(353, 432);
            panel1.TabIndex = 13;
            panel1.Text = "panel1";
            // 
            // checkbox_appendInfo
            // 
            checkbox_appendInfo.AutoCheck = true;
            checkbox_appendInfo.Location = new Point(188, 96);
            checkbox_appendInfo.Margin = new Padding(2, 3, 2, 3);
            checkbox_appendInfo.Name = "checkbox_appendInfo";
            checkbox_appendInfo.Size = new Size(142, 25);
            checkbox_appendInfo.TabIndex = 32;
            checkbox_appendInfo.Text = "展示流量等信息";
            // 
            // label17
            // 
            label17.Font = new Font("Microsoft YaHei UI", 10F);
            label17.ForeColor = Color.FromArgb(60, 120, 216);
            label17.Location = new Point(14, 353);
            label17.Margin = new Padding(2, 3, 2, 3);
            label17.Name = "label17";
            label17.Size = new Size(210, 26);
            label17.TabIndex = 30;
            label17.Text = "备注（适用于SSR等）";
            // 
            // input_remarks
            // 
            input_remarks.Location = new Point(10, 382);
            input_remarks.Margin = new Padding(2, 3, 2, 3);
            input_remarks.Name = "input_remarks";
            input_remarks.PlaceholderText = "备注";
            input_remarks.Size = new Size(327, 39);
            input_remarks.TabIndex = 31;
            // 
            // label16
            // 
            label16.Font = new Font("Microsoft YaHei UI", 10F);
            label16.ForeColor = Color.FromArgb(60, 120, 216);
            label16.Location = new Point(17, 283);
            label16.Margin = new Padding(2, 3, 2, 3);
            label16.Name = "label16";
            label16.Size = new Size(210, 26);
            label16.TabIndex = 28;
            label16.Text = "分组名称";
            // 
            // input_group
            // 
            input_group.Location = new Point(11, 308);
            input_group.Margin = new Padding(2, 3, 2, 3);
            input_group.Name = "input_group";
            input_group.PlaceholderText = "分组名称";
            input_group.Size = new Size(327, 39);
            input_group.TabIndex = 29;
            // 
            // checkbox_tfo
            // 
            checkbox_tfo.AutoCheck = true;
            checkbox_tfo.Location = new Point(11, 123);
            checkbox_tfo.Margin = new Padding(2, 3, 2, 3);
            checkbox_tfo.Name = "checkbox_tfo";
            checkbox_tfo.Size = new Size(121, 25);
            checkbox_tfo.TabIndex = 27;
            checkbox_tfo.Text = "TCP Fast 启动";
            // 
            // label8
            // 
            label8.Font = new Font("Microsoft YaHei UI", 10F);
            label8.ForeColor = Color.FromArgb(60, 120, 216);
            label8.Location = new Point(17, 208);
            label8.Margin = new Padding(2, 3, 2, 3);
            label8.Name = "label8";
            label8.Size = new Size(210, 26);
            label8.TabIndex = 25;
            label8.Text = "配置文件名称";
            // 
            // input_filename
            // 
            input_filename.Location = new Point(11, 238);
            input_filename.Margin = new Padding(2, 3, 2, 3);
            input_filename.Name = "input_filename";
            input_filename.PlaceholderText = "配置文件名称";
            input_filename.Size = new Size(327, 39);
            input_filename.TabIndex = 26;
            // 
            // checkbox_nodeList
            // 
            checkbox_nodeList.AutoCheck = true;
            checkbox_nodeList.Location = new Point(188, 177);
            checkbox_nodeList.Margin = new Padding(2, 3, 2, 3);
            checkbox_nodeList.Name = "checkbox_nodeList";
            checkbox_nodeList.Size = new Size(121, 25);
            checkbox_nodeList.TabIndex = 24;
            checkbox_nodeList.Text = "输出为Node List";
            // 
            // checkbox_clashDNS
            // 
            checkbox_clashDNS.AutoCheck = true;
            checkbox_clashDNS.Location = new Point(188, 146);
            checkbox_clashDNS.Margin = new Padding(2, 3, 2, 3);
            checkbox_clashDNS.Name = "checkbox_clashDNS";
            checkbox_clashDNS.Size = new Size(150, 25);
            checkbox_clashDNS.TabIndex = 22;
            checkbox_clashDNS.Text = "Clash.DNS（定制）";
            // 
            // checkbox_expand
            // 
            checkbox_expand.AutoCheck = true;
            checkbox_expand.Checked = true;
            checkbox_expand.Location = new Point(188, 70);
            checkbox_expand.Margin = new Padding(2, 3, 2, 3);
            checkbox_expand.Name = "checkbox_expand";
            checkbox_expand.Size = new Size(121, 25);
            checkbox_expand.TabIndex = 20;
            checkbox_expand.Text = "规则展开";
            // 
            // checkbox_fdn
            // 
            checkbox_fdn.AutoCheck = true;
            checkbox_fdn.Location = new Point(188, 41);
            checkbox_fdn.Margin = new Padding(2, 3, 2, 3);
            checkbox_fdn.Name = "checkbox_fdn";
            checkbox_fdn.Size = new Size(121, 25);
            checkbox_fdn.TabIndex = 19;
            checkbox_fdn.Text = "过滤非法节点";
            // 
            // checkbox_sort
            // 
            checkbox_sort.AutoCheck = true;
            checkbox_sort.Location = new Point(11, 175);
            checkbox_sort.Margin = new Padding(2, 3, 2, 3);
            checkbox_sort.Name = "checkbox_sort";
            checkbox_sort.Size = new Size(121, 25);
            checkbox_sort.TabIndex = 18;
            checkbox_sort.Text = "节点排序";
            // 
            // checkbox_appendType
            // 
            checkbox_appendType.AutoCheck = true;
            checkbox_appendType.Location = new Point(11, 150);
            checkbox_appendType.Margin = new Padding(2, 3, 2, 3);
            checkbox_appendType.Name = "checkbox_appendType";
            checkbox_appendType.Size = new Size(121, 25);
            checkbox_appendType.TabIndex = 17;
            checkbox_appendType.Text = "插入节点类型";
            // 
            // checkbox_udp
            // 
            checkbox_udp.AutoCheck = true;
            checkbox_udp.Location = new Point(11, 98);
            checkbox_udp.Margin = new Padding(2, 3, 2, 3);
            checkbox_udp.Name = "checkbox_udp";
            checkbox_udp.Size = new Size(121, 25);
            checkbox_udp.TabIndex = 16;
            checkbox_udp.Text = "启用UDP";
            // 
            // checkbox_scv
            // 
            checkbox_scv.AutoCheck = true;
            checkbox_scv.Checked = true;
            checkbox_scv.Location = new Point(11, 71);
            checkbox_scv.Margin = new Padding(2, 3, 2, 3);
            checkbox_scv.Name = "checkbox_scv";
            checkbox_scv.Size = new Size(121, 25);
            checkbox_scv.TabIndex = 15;
            checkbox_scv.Text = "跳过证书验证";
            // 
            // checkbox_emoji
            // 
            checkbox_emoji.AutoCheck = true;
            checkbox_emoji.Checked = true;
            checkbox_emoji.Location = new Point(11, 41);
            checkbox_emoji.Margin = new Padding(2, 3, 2, 3);
            checkbox_emoji.Name = "checkbox_emoji";
            checkbox_emoji.Size = new Size(121, 25);
            checkbox_emoji.TabIndex = 14;
            checkbox_emoji.Text = "Emoji";
            // 
            // label7
            // 
            label7.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 134);
            label7.ForeColor = Color.FromArgb(60, 120, 216);
            label7.Location = new Point(11, 8);
            label7.Margin = new Padding(2, 3, 2, 3);
            label7.Name = "label7";
            label7.Size = new Size(152, 26);
            label7.TabIndex = 13;
            label7.Text = "高级配置";
            // 
            // input_subUrl
            // 
            input_subUrl.JoinRight = true;
            input_subUrl.Location = new Point(105, 579);
            input_subUrl.Margin = new Padding(2, 3, 2, 3);
            input_subUrl.Name = "input_subUrl";
            input_subUrl.PlaceholderText = "";
            input_subUrl.ReadOnly = true;
            input_subUrl.Size = new Size(408, 39);
            input_subUrl.TabIndex = 28;
            // 
            // panel2
            // 
            panel2.BorderWidth = 1F;
            panel2.Controls.Add(label_backendVersion);
            panel2.Controls.Add(select_remoteConfig);
            panel2.Controls.Add(label12);
            panel2.Controls.Add(select_shortUrlBackend);
            panel2.Controls.Add(label11);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(input_sourceSubUrl);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(select_customBackend);
            panel2.Controls.Add(select_clientType);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(input_includeRemarks);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(input_excludeRemarks);
            panel2.Location = new Point(9, 48);
            panel2.Margin = new Padding(2, 3, 2, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(630, 525);
            panel2.TabIndex = 29;
            panel2.Text = "panel2";
            // 
            // label_backendVersion
            // 
            label_backendVersion.Location = new Point(167, 260);
            label_backendVersion.Margin = new Padding(2, 3, 2, 3);
            label_backendVersion.Name = "label_backendVersion";
            label_backendVersion.Size = new Size(446, 24);
            label_backendVersion.TabIndex = 14;
            label_backendVersion.Text = "";
            label_backendVersion.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label12
            // 
            label12.Font = new Font("Microsoft YaHei UI", 10F);
            label12.ForeColor = Color.FromArgb(60, 120, 216);
            label12.Location = new Point(12, 321);
            label12.Margin = new Padding(2, 3, 2, 3);
            label12.Name = "label12";
            label12.Size = new Size(152, 26);
            label12.TabIndex = 15;
            label12.Text = "短链接服务器";
            // 
            // select_shortUrlBackend
            // 
            select_shortUrlBackend.Location = new Point(12, 348);
            select_shortUrlBackend.Margin = new Padding(2, 3, 2, 3);
            select_shortUrlBackend.Name = "select_shortUrlBackend";
            select_shortUrlBackend.PlaceholderText = "请选择短链接服务器";
            select_shortUrlBackend.Size = new Size(605, 38);
            select_shortUrlBackend.TabIndex = 16;
            // 
            // label11
            // 
            label11.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 134);
            label11.ForeColor = Color.FromArgb(60, 120, 216);
            label11.Location = new Point(11, 8);
            label11.Margin = new Padding(2, 3, 2, 3);
            label11.Name = "label11";
            label11.Size = new Size(152, 26);
            label11.TabIndex = 13;
            label11.Text = "基础配置";
            // 
            // label9
            // 
            label9.Font = new Font("Microsoft YaHei UI", 10F);
            label9.ForeColor = Color.FromArgb(60, 120, 216);
            label9.Location = new Point(9, 585);
            label9.Margin = new Padding(2, 3, 2, 3);
            label9.Name = "label9";
            label9.Size = new Size(101, 26);
            label9.TabIndex = 30;
            label9.Text = "定制订阅连接：";
            label9.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label10
            // 
            label10.Font = new Font("Microsoft YaHei UI", 10F);
            label10.ForeColor = Color.FromArgb(60, 120, 216);
            label10.Location = new Point(10, 633);
            label10.Margin = new Padding(2, 3, 2, 3);
            label10.Name = "label10";
            label10.Size = new Size(100, 26);
            label10.TabIndex = 32;
            label10.Text = "订阅短链接：";
            label10.TextAlign = ContentAlignment.MiddleRight;
            // 
            // input_shortSubUrl
            // 
            input_shortSubUrl.JoinRight = true;
            input_shortSubUrl.Location = new Point(104, 624);
            input_shortSubUrl.Margin = new Padding(2, 3, 2, 3);
            input_shortSubUrl.Name = "input_shortSubUrl";
            input_shortSubUrl.PlaceholderText = "";
            input_shortSubUrl.ReadOnly = true;
            input_shortSubUrl.Size = new Size(372, 39);
            input_shortSubUrl.TabIndex = 31;
            // 
            // button_makeUrl
            // 
            button_makeUrl.JoinLeft = true;
            button_makeUrl.Location = new Point(551, 579);
            button_makeUrl.Margin = new Padding(2, 3, 2, 3);
            button_makeUrl.Name = "button_makeUrl";
            button_makeUrl.Size = new Size(88, 39);
            button_makeUrl.TabIndex = 33;
            button_makeUrl.Text = "生成订阅";
            button_makeUrl.Type = AntdUI.TTypeMini.Primary;
            button_makeUrl.Click += button_makeUrl_Click;
            // 
            // button_makeShortUrl
            // 
            button_makeShortUrl.JoinLeft = true;
            button_makeShortUrl.Location = new Point(550, 624);
            button_makeShortUrl.Margin = new Padding(2, 3, 2, 3);
            button_makeShortUrl.Name = "button_makeShortUrl";
            button_makeShortUrl.Size = new Size(89, 39);
            button_makeShortUrl.TabIndex = 34;
            button_makeShortUrl.Text = "生成短链接";
            button_makeShortUrl.Type = AntdUI.TTypeMini.Primary;
            button_makeShortUrl.Click += button_makeShortUrl_Click;
            // 
            // button_copySubUrl
            // 
            button_copySubUrl.JoinLeft = true;
            button_copySubUrl.JoinRight = true;
            button_copySubUrl.Location = new Point(513, 579);
            button_copySubUrl.Margin = new Padding(2, 3, 2, 3);
            button_copySubUrl.Name = "button_copySubUrl";
            button_copySubUrl.Size = new Size(39, 39);
            button_copySubUrl.TabIndex = 35;
            button_copySubUrl.Text = "复制";
            button_copySubUrl.Type = AntdUI.TTypeMini.Warn;
            button_copySubUrl.Click += button_copySubUrl_Click;
            // 
            // button_copyShortUrl
            // 
            button_copyShortUrl.JoinLeft = true;
            button_copyShortUrl.JoinRight = true;
            button_copyShortUrl.Location = new Point(512, 624);
            button_copyShortUrl.Margin = new Padding(2, 3, 2, 3);
            button_copyShortUrl.Name = "button_copyShortUrl";
            button_copyShortUrl.Size = new Size(39, 39);
            button_copyShortUrl.TabIndex = 36;
            button_copyShortUrl.Text = "复制";
            button_copyShortUrl.Type = AntdUI.TTypeMini.Warn;
            button_copyShortUrl.Click += button_copyShortUrl_Click;
            // 
            // panel3
            // 
            panel3.BorderWidth = 1F;
            panel3.Controls.Add(input_parseUrl);
            panel3.Controls.Add(button_log);
            panel3.Controls.Add(alert_subServerStatus);
            panel3.Controls.Add(button_subServerTest);
            panel3.Controls.Add(button_subServerStart);
            panel3.Controls.Add(button_subServerStop);
            panel3.Controls.Add(label15);
            panel3.Controls.Add(alert1);
            panel3.Controls.Add(label13);
            panel3.Controls.Add(button_parseUrl);
            panel3.Controls.Add(label14);
            panel3.Location = new Point(643, 486);
            panel3.Margin = new Padding(2, 3, 2, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(355, 196);
            panel3.TabIndex = 37;
            panel3.Text = "panel3";
            // 
            // input_parseUrl
            // 
            input_parseUrl.JoinRight = true;
            input_parseUrl.Location = new Point(12, 60);
            input_parseUrl.Margin = new Padding(2, 3, 2, 3);
            input_parseUrl.Name = "input_parseUrl";
            input_parseUrl.PlaceholderText = "请输入待解析url，不支持短链接";
            input_parseUrl.Size = new Size(261, 39);
            input_parseUrl.TabIndex = 36;
            // 
            // button_log
            // 
            button_log.Location = new Point(268, 150);
            button_log.Margin = new Padding(2, 3, 2, 3);
            button_log.Name = "button_log";
            button_log.Size = new Size(75, 36);
            button_log.TabIndex = 43;
            button_log.Text = "运行日志";
            button_log.Type = AntdUI.TTypeMini.Success;
            button_log.Click += button_log_Click;
            // 
            // alert_subServerStatus
            // 
            alert_subServerStatus.Font = new Font("Microsoft YaHei UI", 9F);
            alert_subServerStatus.Icon = AntdUI.TType.Info;
            alert_subServerStatus.Location = new Point(16, 125);
            alert_subServerStatus.Margin = new Padding(2, 3, 2, 3);
            alert_subServerStatus.Name = "alert_subServerStatus";
            alert_subServerStatus.Size = new Size(324, 21);
            alert_subServerStatus.TabIndex = 42;
            alert_subServerStatus.Text = "未获取到状态";
            alert_subServerStatus.TextTitle = "";
            // 
            // button_subServerTest
            // 
            button_subServerTest.JoinLeft = true;
            button_subServerTest.JoinRight = true;
            button_subServerTest.Location = new Point(89, 150);
            button_subServerTest.Margin = new Padding(2, 3, 2, 3);
            button_subServerTest.Name = "button_subServerTest";
            button_subServerTest.Size = new Size(75, 36);
            button_subServerTest.TabIndex = 41;
            button_subServerTest.Text = "测试";
            button_subServerTest.Type = AntdUI.TTypeMini.Warn;
            button_subServerTest.Click += button_subServerTest_Click;
            // 
            // button_subServerStart
            // 
            button_subServerStart.JoinRight = true;
            button_subServerStart.Location = new Point(15, 150);
            button_subServerStart.Margin = new Padding(2, 3, 2, 3);
            button_subServerStart.Name = "button_subServerStart";
            button_subServerStart.Size = new Size(75, 36);
            button_subServerStart.TabIndex = 40;
            button_subServerStart.Text = "启动";
            button_subServerStart.Type = AntdUI.TTypeMini.Success;
            button_subServerStart.Click += button_subServerStart_Click;
            // 
            // button_subServerStop
            // 
            button_subServerStop.JoinLeft = true;
            button_subServerStop.Location = new Point(164, 150);
            button_subServerStop.Margin = new Padding(2, 3, 2, 3);
            button_subServerStop.Name = "button_subServerStop";
            button_subServerStop.Size = new Size(75, 36);
            button_subServerStop.TabIndex = 39;
            button_subServerStop.Text = "停止";
            button_subServerStop.Type = AntdUI.TTypeMini.Error;
            button_subServerStop.Click += button_subServerStop_Click;
            // 
            // label15
            // 
            label15.Font = new Font("Microsoft YaHei UI", 10F);
            label15.ForeColor = Color.FromArgb(60, 120, 216);
            label15.Location = new Point(16, 99);
            label15.Margin = new Padding(2, 3, 2, 3);
            label15.Name = "label15";
            label15.Size = new Size(135, 26);
            label15.TabIndex = 38;
            label15.Text = "本地内置后端服务";
            // 
            // alert1
            // 
            alert1.Font = new Font("Microsoft YaHei UI", 7F);
            alert1.Icon = AntdUI.TType.Warn;
            alert1.Location = new Point(122, 8);
            alert1.Margin = new Padding(2, 3, 2, 3);
            alert1.Name = "alert1";
            alert1.Size = new Size(218, 50);
            alert1.TabIndex = 37;
            alert1.Text = "实验性功能可能工作不稳定";
            alert1.TextTitle = "提示";
            // 
            // label13
            // 
            label13.Font = new Font("Microsoft YaHei UI", 10F);
            label13.ForeColor = Color.FromArgb(60, 120, 216);
            label13.Location = new Point(16, 40);
            label13.Margin = new Padding(2, 3, 2, 3);
            label13.Name = "label13";
            label13.Size = new Size(102, 26);
            label13.TabIndex = 35;
            label13.Text = "URL反向解析";
            // 
            // button_parseUrl
            // 
            button_parseUrl.JoinLeft = true;
            button_parseUrl.Location = new Point(271, 59);
            button_parseUrl.Margin = new Padding(2, 3, 2, 3);
            button_parseUrl.Name = "button_parseUrl";
            button_parseUrl.Size = new Size(75, 39);
            button_parseUrl.TabIndex = 34;
            button_parseUrl.Text = "解析";
            button_parseUrl.Type = AntdUI.TTypeMini.Primary;
            button_parseUrl.Click += button_parseUrl_Click;
            // 
            // label14
            // 
            label14.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 134);
            label14.ForeColor = Color.FromArgb(60, 120, 216);
            label14.Location = new Point(12, 4);
            label14.Margin = new Padding(2, 3, 2, 3);
            label14.Name = "label14";
            label14.Size = new Size(152, 26);
            label14.TabIndex = 27;
            label14.Text = "实验性功能";
            // 
            // button_qrcodeShortUrl
            // 
            button_qrcodeShortUrl.IconPosition = AntdUI.TAlignMini.None;
            button_qrcodeShortUrl.IconRatio = 1F;
            button_qrcodeShortUrl.IconSvg = resources.GetString("button_qrcodeShortUrl.IconSvg");
            button_qrcodeShortUrl.JoinLeft = true;
            button_qrcodeShortUrl.JoinRight = true;
            button_qrcodeShortUrl.Location = new Point(477, 624);
            button_qrcodeShortUrl.Margin = new Padding(2, 3, 2, 3);
            button_qrcodeShortUrl.Name = "button_qrcodeShortUrl";
            button_qrcodeShortUrl.Size = new Size(36, 39);
            button_qrcodeShortUrl.TabIndex = 39;
            button_qrcodeShortUrl.Type = AntdUI.TTypeMini.Success;
            button_qrcodeShortUrl.Click += button_qrcodeShortUrl_Click;
            // 
            // Form1
            // 
            AutoHandDpi = false;
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1011, 688);
            Controls.Add(input_shortSubUrl);
            Controls.Add(input_subUrl);
            Controls.Add(button_qrcodeShortUrl);
            Controls.Add(panel3);
            Controls.Add(button_copyShortUrl);
            Controls.Add(button_copySubUrl);
            Controls.Add(button_makeShortUrl);
            Controls.Add(button_makeUrl);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(windowBar1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2, 3, 2, 3);
            MaximizeBox = false;
            Name = "Form1";
            Resizable = false;
            Text = "订阅转换工具";
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            windowBar1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private AntdUI.WindowBar windowBar1;
        private AntdUI.Label label1;
        private AntdUI.Input input_sourceSubUrl;
        private AntdUI.Label label2;
        private AntdUI.Select select_clientType;
        private AntdUI.Select select_remoteConfig;
        private AntdUI.Label label3;
        private AntdUI.Select select_customBackend;
        private AntdUI.Label label4;
        private AntdUI.Label label5;
        private AntdUI.Input input_includeRemarks;
        private AntdUI.Input input_excludeRemarks;
        private AntdUI.Label label6;
        private AntdUI.Panel panel1;
        private AntdUI.Label label7;
        private AntdUI.Checkbox checkbox_nodeList;
        private AntdUI.Checkbox checkbox_clashDNS;
        private AntdUI.Checkbox checkbox_expand;
        private AntdUI.Checkbox checkbox_fdn;
        private AntdUI.Checkbox checkbox_sort;
        private AntdUI.Checkbox checkbox_appendType;
        private AntdUI.Checkbox checkbox_udp;
        private AntdUI.Checkbox checkbox_scv;
        private AntdUI.Checkbox checkbox_emoji;
        private AntdUI.Label label8;
        private AntdUI.Input input_filename;
        private AntdUI.Input input_subUrl;
        private AntdUI.Panel panel2;
        private AntdUI.Label label11;
        private AntdUI.Label label9;
        private AntdUI.Label label10;
        private AntdUI.Input input_shortSubUrl;
        private AntdUI.Button button_makeUrl;
        private AntdUI.Button button_makeShortUrl;
        private AntdUI.Checkbox checkbox_tfo;
        private AntdUI.Button button_copySubUrl;
        private AntdUI.Button button_copyShortUrl;
        private AntdUI.Label label_backendVersion;
        private AntdUI.Label label12;
        private AntdUI.Select select_shortUrlBackend;
        private AntdUI.Panel panel3;
        private AntdUI.Label label13;
        private AntdUI.Input input_parseUrl;
        private AntdUI.Button button_parseUrl;
        private AntdUI.Label label14;
        private AntdUI.Alert alert1;
        private AntdUI.Button button_github;
        private AntdUI.Button button_qrcodeShortUrl;
        private AntdUI.Label label15;
        private AntdUI.Button button_subServerTest;
        private AntdUI.Button button_subServerStart;
        private AntdUI.Button button_subServerStop;
        private AntdUI.Alert alert_subServerStatus;
        private AntdUI.Label label16;
        private AntdUI.Input input_group;
        private AntdUI.Label label17;
        private AntdUI.Input input_remarks;
        private AntdUI.Checkbox checkbox_appendInfo;
        private AntdUI.Button button_log;
    }
}
