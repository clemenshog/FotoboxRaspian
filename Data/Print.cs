namespace BlazorServerApp.Data
{
    public class Print
    {

        public void PrintImage(int amount, string file)
        {
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            //startInfo.UseShellExecute = true;
            startInfo.FileName = "/bin/bash";
            startInfo.Arguments = "/home/pi/print.sh lp -o media=Custom.4x6in -n " + amount + " " + file;
            process.StartInfo = startInfo;
            process.Start();
        }

    }
}
