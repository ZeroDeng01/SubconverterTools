using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubconverterTools.SubServer
{
    /// <summary>
    /// 订阅生成后端服务
    /// </summary>
    public class SubBackend
    {
        private Process _process;

        /// <summary>
        /// 输出事件
        /// </summary>
        public event DataReceivedEventHandler OutputDataReceived;
        /// <summary>
        /// 错误事件
        /// </summary>
        public event DataReceivedEventHandler ErrorDataReceived;

        private string ExecutablePath =System.AppDomain.CurrentDomain.BaseDirectory +@"/subconverter/subconverter.exe";
        /// <summary>
        /// 启动
        /// </summary>
        public void Start()
        {
            // 初始化进程
            _process = new Process();
            _process.StartInfo.FileName = ExecutablePath;
            _process.StartInfo.UseShellExecute = false; // 不使用外壳程序启动
            _process.StartInfo.RedirectStandardOutput = true; // 重定向标准输出
            _process.StartInfo.RedirectStandardError = true; // 重定向标准错误
            _process.StartInfo.CreateNoWindow = true; // 不创建窗口
            _process.StartInfo.StandardOutputEncoding = Encoding.UTF8; // 设置输出编码为 UTF-8
            _process.StartInfo.StandardErrorEncoding = Encoding.UTF8; // 设置错误输出编码为 UTF-8

            // 订阅输出事件
            _process.OutputDataReceived += (sender, e) =>
            {
                OutputDataReceived?.Invoke(sender, e);
            };
            _process.ErrorDataReceived += (sender, e) =>
            {
                ErrorDataReceived?.Invoke(sender, e);
            };

            // 启动进程
            _process.Start();

            // 开始读取输出
            _process.BeginOutputReadLine();
            _process.BeginErrorReadLine();
        }
        /// <summary>
        /// 停止
        /// </summary>
        public void Stop()
        {
            if (_process != null && !_process.HasExited)
            {
                _process.Kill(); // 结束进程
                _process.Dispose(); // 释放资源
                _process = null; // 清空引用
            }
        }
        /// <summary>
        /// 运行状态
        /// </summary>
        public bool IsRunning => _process != null && !_process.HasExited;
    }
}
