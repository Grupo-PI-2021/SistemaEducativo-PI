using System;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using CefSharp;
using CefSharp.WinForms;

namespace Sistema.Forms
{
    public partial class Principal : Form
    {
        Class.Data cl_data = new Class.Data();
        public ChromiumWebBrowser csharpBrowser;

        private bool mouseDown;
        private Point lastLocation;

        int licao = 1;
        int level = 1;
        string licaotxt = "";
        bool temaEscuro = true;

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
            settings.CefCommandLineArgs.Add("disable-application-cache", "1");
            settings.CefCommandLineArgs.Add("disable-session-storage", "1");

            /*SET OFF SCREEN RENDER (BEST PERFORMANCE)*/
            settings.SetOffScreenRenderingBestPerformanceArgs();

            //-FIM-DA-CONFIG-

            //-INICIALIZAR-CONFIG-
            Cef.Initialize(settings);

            // Create a browser component
            csharpBrowser = new ChromiumWebBrowser(cl_data.BrowserUrl);

            // Load MenuHandler
            csharpBrowser.MenuHandler = new MenuHandler();

            //Add Controls
            this.pnlWebSharp.Controls.Add(csharpBrowser);
            //csharpBrowser.Dock = DockStyle.Fill;

            //Browser Address
            //chromeBrowser.AddressChanged += Chrome_AddressChanged;

            //Browser Loading
            csharpBrowser.LoadingStateChanged += OnLoadingStateChanged;

        }

        public Principal()
        {
            InitializeComponent();
            InitializeChromium();
        }

        private void OnLoadingStateChanged(object sender, LoadingStateChangedEventArgs args)
        {
            if (!args.IsLoading)
            {
                //Pagina Carregada.

            }
            else
            {

            }
        }

        public void ExecDataJs()
        {
            Thread.Sleep(500);

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
            //SCRIPT UPDATE TEXT
            csharpBrowser.ExecuteScriptAsync(cl_data.ScriptUpdateText);

            //SCRIPT CSS 01 - ADJUSTER
            csharpBrowser.ExecuteScriptAsync(cl_data.ScriptStyleAdjustes);
            //SCRIPT CSS 02 - INVERTER-A
            csharpBrowser.ExecuteScriptAsync(cl_data.ScriptStyleInvertColor);

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

            grpCenter.BringToFront();
            grpCenter.Visible = true;

            timerProgressBarLoading.Start();

            //Read LEVEL
            string _DataFile = System.IO.File.ReadAllText(Directory.GetCurrentDirectory() + @"/data/data.txt");

            _DataFile = _DataFile.Replace("!level:", "");
            _DataFile = _DataFile.Replace("##;", "");

            int valuelvl = Convert.ToInt32(_DataFile);

            //DECRYPT-LEVEL
            //   LEVELS-LICAO    //
            //1=404 //4=425 //7=508
            //2=416 //5=428 //8=300
            //3=418 //6=500 //9=202
            if(valuelvl == 404)
            {
                valuelvl = 1;
            }
            else if (valuelvl == 416)
            {
                valuelvl = 2;
            }
            else if (valuelvl == 418)
            {
                valuelvl = 3;
            }
            else if (valuelvl == 425)
            {
                valuelvl = 4;
            }
            else if (valuelvl == 428)
            {
                valuelvl = 5;
            }

            level = valuelvl;

            //Cores
            btnAvancarLicao.BackColor = cl_data.ColorC_PurpleH;
            btnFinish.BackColor = cl_data.ColorC_PurpleH;
            btnSaida.BackColor = cl_data.ColorC_PurpleH;
        }

        private void Principal_FormClosing(object sender, FormClosingEventArgs e)
        {
            Cef.Shutdown();
            Thread.Sleep(1000);
            Environment.Exit(4);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ExecDataJs();
        }
        private void rbtnComecar_Click(object sender, EventArgs e)
        {
            this.rbtnComecar.Enabled = false;
            this.rbtnComecar.Hide();
            grpCenter.Visible = false;
            grpEsconde.Visible = false;
            chkTema.Enabled = true;
            grpEsconde.Hide();

            Thread.Sleep(500);

            pnlWebSharp.Visible = true;
            pnlWebSharp.BringToFront();

            ExecDataJs();

            //csharpBrowser.Load("https://dotnetfiddle.net/#");
        }

        private void timerProgressBarLoading_Tick(object sender, EventArgs e)
        {
            string ldlA = "Loading...";
            string ldlB = "Loading.";
            string ldlC = "Loading..";
            if (progressBarLoading.Value != progressBarLoading.Maximum)
            {
                if(progressBarLoading.Value >= 5)
                lblProgressLoading.Text = ldlB + progressBarLoading.Value + "%";

                if (progressBarLoading.Value >= 25)
                    lblProgressLoading.Text = ldlC + progressBarLoading.Value + "%";

                if (progressBarLoading.Value >= 45)
                    lblProgressLoading.Text = ldlA + progressBarLoading.Value + "%";

                if (progressBarLoading.Value >= 65)
                    lblProgressLoading.Text = ldlB + progressBarLoading.Value + "%";

                if (progressBarLoading.Value >= 75)
                    lblProgressLoading.Text = ldlC + progressBarLoading.Value + "%";

                if (progressBarLoading.Value >= 85)
                    lblProgressLoading.Text = ldlA + progressBarLoading.Value + "%";

                progressBarLoading.Value += 1;
            }
            else
            {
                lblProgressLoading.Text = "Loaded... 100%";
                rbtnComecar.Enabled = true;
                timerProgressBarLoading.Stop();
            }
        }
        private void btnSaida_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("public string description = ''Saindo da Aplicação...''\nConsole.WriteLine(description);\n//Saindo da Aplicação...", "string title = ''Aviso!'';", MessageBoxButtons.OK, MessageBoxIcon.Information); ;
            MessageBox.Show("public string description = ''Saindo da Aplicação...''", "string title = ''Aviso!'';", MessageBoxButtons.OK, MessageBoxIcon.Information); ;

            Cef.Shutdown();
            Environment.Exit(4);
        }

        private void btnAvancarLicao_Click(object sender, EventArgs e)
        {
            string localpasta = Directory.GetCurrentDirectory() + @"/atividades/ATV0" + level.ToString() + "/licao0"+licao.ToString()+".txt";
            ofdAtividade.FileName = localpasta;
            licaotxt = File.ReadAllText(ofdAtividade.FileName);

            Forms.FormModal frmModal = new Forms.FormModal(licaotxt);

            frmModal.Location = new Point(this.grpCenter.Location.X + 320, this.grpCenter.Location.Y + 32);
            frmModal.ShowDialog();
            licao++;
        }

        private void pageCodePrincipal_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }
        private void pageCodePrincipal_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);
                this.Update();
            }
        }
        private void pageCodePrincipal_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void chkTema_CheckedChanged(object sender, EventArgs e)
        {
            if (chkTema.Checked)
            {
                csharpBrowser.ExecuteScriptAsync(cl_data.ScriptStyleTemaClaro);
            }
            else
            {
                csharpBrowser.ExecuteScriptAsync(cl_data.ScriptStyleTemaEscuro);
            }
        }

        private void btnFinish_Click(object sender, EventArgs e)
        {
            DialogResult dialogFinish = MessageBox.Show("Deseja finalizar o Nível? \n\nObs.: É necessário, programar o que se pede do nível para finalizar.", "Finalizar Nível", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dialogFinish == DialogResult.Yes)
            {

            }
            else
            {

            }
        }
    }
}