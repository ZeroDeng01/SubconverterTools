namespace SubconverterTools
{
    partial class BackendLogForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BackendLogForm));
            windowBar1 = new AntdUI.WindowBar();
            input_log = new AntdUI.Input();
            SuspendLayout();
            // 
            // windowBar1
            // 
            windowBar1.Dock = DockStyle.Top;
            windowBar1.Font = new Font("Microsoft YaHei UI", 12F);
            windowBar1.IconSvg = resources.GetString("windowBar1.IconSvg");
            windowBar1.IsMax = false;
            windowBar1.Location = new Point(0, 0);
            windowBar1.Name = "windowBar1";
            windowBar1.Size = new Size(909, 45);
            windowBar1.TabIndex = 0;
            windowBar1.Text = "后端运行日志";
            // 
            // input_log
            // 
            input_log.AutoScroll = true;
            input_log.BackColor = SystemColors.WindowFrame;
            input_log.Dock = DockStyle.Fill;
            input_log.ForeColor = Color.LightGreen;
            input_log.Location = new Point(0, 45);
            input_log.Multiline = true;
            input_log.Name = "input_log";
            input_log.ReadOnly = true;
            input_log.Size = new Size(909, 508);
            input_log.TabIndex = 1;
            // 
            // BackendLogForm
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(909, 553);
            Controls.Add(input_log);
            Controls.Add(windowBar1);
            Mode = AntdUI.TAMode.Light;
            Name = "BackendLogForm";
            ShowIcon = false;
            ShowInTaskbar = false;
            Text = "后端运行日志";
            FormClosing += BackendLogForm_FormClosing;
            ResumeLayout(false);
        }

        #endregion

        private AntdUI.WindowBar windowBar1;
        private AntdUI.Input input_log;
    }
}