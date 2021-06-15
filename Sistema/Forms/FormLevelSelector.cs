using System;
using System.Windows.Forms;
using System.IO;

namespace Sistema.Forms
{
    public partial class FormLevelSelector : Form
    {
        public FormLevelSelector()
        {
            InitializeComponent();
        }

        //   LEVELS-LICAO    //
        //1=404 //4=425 //7=508
        //2=416 //5=428 //8=300
        //3=418 //6=500 //9=202

        Class.Data cl_data = new Class.Data();
        bool select = false;
        public string _DataFile = Directory.GetCurrentDirectory() + @"/data/data.txt";
        public string _CachePath = Directory.GetCurrentDirectory() + @"/cache/";

        private void FormLevelSelector_Load(object sender, EventArgs e)
        {
            btnLvl1.BackColor = cl_data.ColorEasyGreen;
            btnLvl2.BackColor = cl_data.ColorEasyGreen;
            btnLvl3.BackColor = cl_data.ColorEasyYellow;
            btnLvl4.BackColor = cl_data.ColorEasyYellow;
            btnLvl5.BackColor = cl_data.ColorEasyRed;
            this.BackColor = cl_data.ColorBackg;

            //CLEAR CACHE - BROWSER

            //PATH
            try
            {
                Directory.Delete(_CachePath, true);
            }catch(Exception a)
            {
                Console.WriteLine("INFO: (Delete Cache) - " + a.ToString());
            }


        }

        private void btnCarregar_Click(object sender, EventArgs e)
        {
            if(select)
            {
            this.Hide();
            Forms.PrincipalFundo frmPrincipalFundo = new Forms.PrincipalFundo();
            frmPrincipalFundo.ShowDialog();
            }
            else
            {
                MessageBox.Show("Favor, escolha um nível antes!", "AVISO!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(4);
        }

        private void btnLvl1_Click(object sender, EventArgs e)
        {
            string cryptedTxt = File.ReadAllText(_DataFile);
            const string lvl = "Nível: 1";
            cryptedTxt = "!level:404##;";
            
            File.WriteAllText(_DataFile, cryptedTxt);
            select = true;
            MessageBox.Show("Você selecionou; " + lvl, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnCarregar.BackColor = cl_data.ColorC_PurpleL;
        }

        private void btnLvl2_Click(object sender, EventArgs e)
        {
            string cryptedTxt = File.ReadAllText(_DataFile);
            const string lvl = "Nível: 2";
            cryptedTxt = "!level:416##;";
            File.WriteAllText(_DataFile, cryptedTxt);
            select = true;
            MessageBox.Show("Você selecionou; " + lvl, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnCarregar.BackColor = cl_data.ColorC_PurpleL;
        }

        private void btnLvl5_Click(object sender, EventArgs e)
        {
            string cryptedTxt = File.ReadAllText(_DataFile);
            const string lvl = "Nível: 5";
            cryptedTxt = "!level:428##;";
            File.WriteAllText(_DataFile, cryptedTxt);
            select = true;
            MessageBox.Show("Você selecionou; " + lvl, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnCarregar.BackColor = cl_data.ColorC_PurpleL;
        }

        private void btnLvl3_Click(object sender, EventArgs e)
        {
            string cryptedTxt = File.ReadAllText(_DataFile);
            const string lvl = "Nível: 3";
            cryptedTxt = "!level:418##;";
            File.WriteAllText(_DataFile, cryptedTxt);
            select = true;
            MessageBox.Show("Você selecionou; " + lvl, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnCarregar.BackColor = cl_data.ColorC_PurpleL;
        }

        private void btnLvl4_Click(object sender, EventArgs e)
        {
            string cryptedTxt = File.ReadAllText(_DataFile);
            const string lvl = "Nível: 4";
            cryptedTxt = "!level:425##;";
            File.WriteAllText(_DataFile, cryptedTxt);
            select = true;
            MessageBox.Show("Você selecionou; " + lvl, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnCarregar.BackColor = cl_data.ColorC_PurpleL;
        }
    }
}
