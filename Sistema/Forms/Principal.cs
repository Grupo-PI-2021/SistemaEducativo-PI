using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CefSharp;
using CefSharp.WinForms;

namespace Sistema
{
    public partial class Principal : Form
    {
        Class.Data cl_data = new Class.Data();

        public ChromiumWebBrowser csharpBrowser;

        public void InitializeChromium()
        {
            CefSettings settings = new CefSettings();

            /*CACHE PATH*/
            settings.CachePath = cl_data.PathCacheFd;

            /*DISABLE PROXY SERVER (PERFORMANCE)*/
            settings.CefCommandLineArgs.Add("no-proxy-server", "0");

            /*DISABLE PDF EXTENSION (PERFORMANCE)*/
            settings.CefCommandLineArgs.Add("disable-pdf-extension", "0");

            /*DISABLE EXTENSIONS (PERFORMANCE)*/
            settings.CefCommandLineArgs.Add("disable-extensions", "0");

            /*DISABLE VSYNC GPU (PERFORMANCE)*/
            settings.CefCommandLineArgs.Add("disable-gpu-vsync", "1");

            /*DISABLE FLASH (PERFORMANCE)*/
            settings.CefCommandLineArgs.Add("enable-system-flash", "0");

            //Allow JavaScript
            settings.CefCommandLineArgs.Add("allow-running-insecure-content");

            //Enable Some Configurations
            settings.CefCommandLineArgs.Add("disable-application-cache", "0");
            settings.CefCommandLineArgs.Add("disable-session-storage", "0");

            /*SET OFF SCREEN RENDER (BEST PERFORMANCE)*/
            settings.SetOffScreenRenderingBestPerformanceArgs();

            //-FIM-DA-CONFIG-

            //-INICIALIZAR-CONFIG-
            Cef.Initialize(settings);

            // Create a browser component
            csharpBrowser = new ChromiumWebBrowser(cl_data.BrowserUrl);

            // Load MenuHandler
            csharpBrowser.MenuHandler = new MenuHandler();

            this.pnlWebSharp.Controls.Add(csharpBrowser);
            csharpBrowser.Dock = DockStyle.Fill;

            //Browser Address
            //chromeBrowser.AddressChanged += Chrome_AddressChanged;
            ////Browser Loading
            //chromeBrowser.LoadingStateChanged += OnLoadingStateChanged;
            ////Browser Navigate (loading)
            ////chromeBrowser.FrameLoadStart += Chrome_FrameLoadStart;
            ////Browser Navigate 2 Loading
            //chromeBrowser.LoadingStateChanged += Chrome_LoadingStateChanged;

        }

        public Principal()
        {
            InitializeComponent();
            InitializeChromium();
        }

        public void ExecDataJs()
        {
            //SCRIPT ADD
            csharpBrowser.ExecuteScriptAsync(cl_data.ScriptAddWeb);
            //SCRIPT REMOVE
            csharpBrowser.ExecuteScriptAsync(cl_data.ScriptRmvWeb);
            //SCRIPT CSS WEB
            csharpBrowser.ExecuteScriptAsync(cl_data.ScriptCssWeb);
            //SCRIPT HIDE ELEMENTS
            csharpBrowser.ExecuteScriptAsync(cl_data.ScriptHideElement);
            //SCRIPT SHOW ELEMENTS
            csharpBrowser.ExecuteScriptAsync(cl_data.ScriptShowElement);


            pnlWebSharp.Focus();
        }

        private void Principal_Load(object sender, EventArgs e)
        {

            //VALIDATE PATH (CACHE)
            if (!File.Exists(cl_data.PathCacheFd))
            {
                Directory.CreateDirectory(cl_data.PathCacheFd);
            }
            //VALIDATE PATH (DATA)
            if (!File.Exists(cl_data.PathData))
            {
                Directory.CreateDirectory(cl_data.PathData);
            }
            if (!File.Exists(cl_data.DataFile))
            {
                File.Create(cl_data.DataFile);
            }

            //cl_data.csharpBrowser.Load(txtAdr.Text);
            csharpBrowser.Load("https://dotnetfiddle.net/#");

        }

        private void Principal_FormClosing(object sender, FormClosingEventArgs e)
        {
            Cef.Shutdown();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ExecDataJs();
        }

        private void pnlWebSharp_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtAdr_TextChanged(object sender, EventArgs e)
        {

        }
    }
}