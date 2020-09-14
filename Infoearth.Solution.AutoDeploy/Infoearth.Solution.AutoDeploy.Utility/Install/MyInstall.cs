using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Infoearth.Solution.AutoDeploy.Utility.Install
{
    internal class MyInstaller
    {
        private BackgroundWorker _bgWorker = null;

        public bool Canceled { get; set; }

        public void Install(BackgroundWorker bgWorker, string msiFileName)
        {
            _bgWorker = bgWorker;

            NativeMethods.MyMsiInstallUIHandler oldHandler = null;
            try
            {
                string logPath = "test.log";
                NativeMethods.MsiEnableLog(NativeMethods.LogMode.Verbose, logPath, 0u);
                NativeMethods.MsiSetInternalUI(0, IntPtr.Zero);

                oldHandler = NativeMethods.MsiSetExternalUI(new NativeMethods.MyMsiInstallUIHandler(MsiProgressHandler),
                                                    NativeMethods.LogMode.ExternalUI,
                                                    IntPtr.Zero);
                string param = "ACTION=INSTALL";
                _bgWorker.ReportProgress(0, "正在安装 ...");
                NativeMethods.MsiInstallProduct(msiFileName, param);
            }
            catch (Exception e)
            {
                // todo
            }
            finally
            {
                // 一定要把默认的handler设回去。
                if (oldHandler != null)
                {
                    NativeMethods.MsiSetExternalUI(oldHandler, NativeMethods.LogMode.None, IntPtr.Zero);
                }
            }
        }

        //最重要的就是这个方法了，这里仅演示了如何cancel一个安装，更多详情请参考MSDN文档
        private int MsiProgressHandler(IntPtr context, int messageType, string message)
        {
            if (this.Canceled)
            {
                if (_bgWorker != null)
                {
                    _bgWorker.ReportProgress(0, "正在取消安装 ...");
                }
                // 这个返回值会告诉msi, cancel当前的安装
                return 1;
            }
            return 0;
        }
    }

    internal static class NativeMethods
    {
        [DllImport("msi.dll", CharSet = CharSet.Auto)]
        internal static extern int MsiSetInternalUI(int dwUILevel, IntPtr phWnd);

        [DllImport("msi.dll", CharSet = CharSet.Auto)]
        internal static extern MyMsiInstallUIHandler MsiSetExternalUI([MarshalAs(UnmanagedType.FunctionPtr)] MyMsiInstallUIHandler puiHandler, NativeMethods.LogMode dwMessageFilter, IntPtr pvContext);

        [DllImport("msi.dll", CharSet = CharSet.Auto)]
        internal static extern uint MsiInstallProduct([MarshalAs(UnmanagedType.LPWStr)] string szPackagePath, [MarshalAs(UnmanagedType.LPWStr)] string szCommandLine);

        [DllImport("msi.dll", CharSet = CharSet.Auto)]
        internal static extern uint MsiEnableLog(NativeMethods.LogMode dwLogMode, [MarshalAs(UnmanagedType.LPWStr)] string szLogFile, uint dwLogAttributes);

        internal delegate int MyMsiInstallUIHandler(IntPtr context, int messageType, [MarshalAs(UnmanagedType.LPWStr)] string message);

        [Flags]
        internal enum LogMode : uint
        {
            None = 0u,
            Verbose = 4096u,
            ExternalUI = 20239u
        }
    }
}
