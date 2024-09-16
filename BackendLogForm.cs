using SubconverterTools.SubServer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SubconverterTools
{
    public partial class BackendLogForm : AntdUI.Window
    {
        private SubBackend _subBackend;
        public BackendLogForm(SubBackend subBackend)
        {
            InitializeComponent();
            _subBackend = subBackend;
            if (subBackend != null)
            {
                _subBackend.OutputDataReceived += SubBackend_OutputDataReceived;
                _subBackend.ErrorDataReceived += SubBackend_ErrorDataReceived;
            }
        }

        private void SubBackend_ErrorDataReceived(object sender, DataReceivedEventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("后端ERR类型输出：" + e.Data);
            if (!string.IsNullOrEmpty(e.Data))
            {
                // 处理错误输出（例如，显示在文本框中）
                Invoke((Action)(() =>
                {
                    input_log.AppendText(e.Data + Environment.NewLine);
                }));
            }
        }

        private void SubBackend_OutputDataReceived(object sender, DataReceivedEventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("后端标准类型输出：" + e.Data);
            if (!string.IsNullOrEmpty(e.Data))
            {
                // 处理错误输出（例如，显示在文本框中）
                Invoke((Action)(() =>
                {
                    input_log.AppendText(e.Data + Environment.NewLine);
                }));
            }
        }

        private void BackendLogForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            _subBackend.OutputDataReceived -= SubBackend_OutputDataReceived;
            _subBackend.ErrorDataReceived -= SubBackend_ErrorDataReceived;
        }
    }
}
