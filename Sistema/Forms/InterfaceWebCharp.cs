using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using System.IO;
using CefSharp.WinForms;
using CefSharp;
//using CefSharp.MinimalExample.WinForms.Controls;

namespace Sistema.Forms
{
    public partial class InterfaceWebCharp : UserControl
    {
        public Class.Data cl_data = new Class.Data();

        //APONTA ERRO DE LEITURA E MOD.
        public ChromiumWebBrowser csharpBrowser;
        //public int loaded = 0;
        //public int loadingpage = 0;

        public void InitializeChromium()
        {
            CefSettings settings = new CefSettings();

            //Inicializar + Config. 

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
            Console.WriteLine("Start Initialize: "+cl_data.BrowserUrl);
            // Load MenuHandler
            csharpBrowser.MenuHandler = new MenuHandler();



            //this.pnlWebSharp.Controls.Add(csharpBrowser);
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

        public InterfaceWebCharp()
        {
            InitializeComponent();
            InitializeChromium();
        }

        private void InterfaceWebCharp_Load(object sender, EventArgs e)
        {

        }
    }
}
