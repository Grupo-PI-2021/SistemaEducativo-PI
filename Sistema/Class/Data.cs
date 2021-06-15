using System;
using System.Drawing;
using System.IO;

namespace Sistema.Class
{
    public class Data
    {
        //OTHERS VARS
        public string cssfontFamily = "'Lucida Console', 'Courier New', monospace";

        public string BrowserUrl { get; set; } = "https://dotnetfiddle.net/";

        //IS LOADED
        public int Loaded { get { return Loaded; } set { Loaded = value; } }
        //IS LOADING
        public int Loadingpage { get { return Loadingpage; } set { Loadingpage = value; } }
        //DEFAULT PATH (CACHE)
        //public string pathcachefd { get { return pathcachefd; } set { pathcachefd = Directory.GetCurrentDirectory() + @"\cache"; } }
        public string PathCacheFd { get; } = Directory.GetCurrentDirectory() + @"\cache";
        //DEFAULT PATH (DATA)
        public string PathData { get; } = Directory.GetCurrentDirectory() + @"\data";

        public string DataFile { get; } = Directory.GetCurrentDirectory() + @"\data\" + @"data.txt";


        public string ScriptRmvWeb { get; } = @"
        $('#sponsor-0').remove();
        $('#sponsor-1').remove();
        $('#sponsor-2').remove();
        $('#sponsor-3').remove();
        $('#sponsor-4').remove();
        $('#sponsor-5').remove();
        $('#sponsor-6').remove();
        //----------------------
        $('.carbon-wrap').remove();
        //----------------------
        $('.access-type-container').remove();
        //----------------------
        $('img').remove();
        //----------------------
        $('.logo').remove();
        //----------------------
        ";

        public string ScriptAddWeb { get; } = @"";

        public string ScriptCssWeb { get; } = @"";

        public string ScriptHideElement { get; } = @"
        $('.stats-pane').hide();    //Informacoes de Exec.
        $('.sidebar').hide();       //Sidebar Side
        $('.expander').hide();      //Expander Side
        $('.status-line').hide();   //File Name OnTop
        $('#tidyup-extra').hide();   //Button Extra Convertor
        $('#login-button').hide();   //Button LOGIN
        $('#signup-button').hide();   //Button REGISTER

        $('.btn').hide();   //Hide All BTN
        ";

        public string ScriptShowElement { get; } = @"
        $('#new-button').show();   //show - New File (reset)

        $('#save-button').hide();   //show - Save File

        //$('#fork-button').show();   //show - Fork

        $('#run-button').show();   //show - RUN CODE

        //$('#Share').show();   //show - Share Code

        //$('#togetherjs').show();   //show - Collaborate

        $('#btn').show();   //show - New

        $('#btn').show();   //show - New

        $('.stats-pane').show();   //show - Stats Panel

        ";

        //NEED UPDATE
        public string ScriptUpdateText { get; } = @"
        //$('.CodeMirror-line').css('border', '2px solid gray');
        //$('.CodeMirror-line').css('border-width', '2px 2px 2px 2px');

        //$('.pane').click(function() {
        //    location.reload();
        //});
                //$('.pane').css('border', '1px solid red');//Todos Paineis

        //        $('.CodeMirror-lines:first').text(@'
        //        using System;
        //					//Software desenvolvido por: Unifeb (SI - PI 2021/01)
        //public class Program
        //{
        //	public static void Main()
        //	{
        //		Console.WriteLine('Hello World');

        //    }
        //}
        //');
        ";

        public string ScriptStyleInvertColor { get; } = @"
            //IMPORTANTE
            //$('html').css('filter', 'invert(85%)');   //DEFAULT: HTML

            $('.content').before().css('filter', 'invert(85%)');
            $('body').css('background-color', '#222222');
            ";

        public string ScriptStyleTemaClaro { get; } = @"
            $('.content').before().css('filter', 'invert(0%)');
            $('body').css('background-color', '#dddddd');
            console.log('Tema: Claro');
            ";
        public string ScriptStyleTemaEscuro { get; } = @"
            $('.content').before().css('filter', 'invert(85%)');
            $('body').css('background-color', '#222222');
            console.log('Tema: Escuro');
            ";

        public string ScriptStyleAdjustes { get; } = @"
            $('.btn-xs:first').click();

            //IMPORTANTE
            //$('html').css('font-size', '20px');
            //$('html').css('font-family', 'Courier New');

            $('main:first').css('font-size', '20px');
            $('main:first').css('font-family', 'Courier New');

            $('.CodeMirror-lint-marker-error').css('font-family', 'Courier New');

            //RESTAURAR FILTRO DE INVERSÃO DE CORES (ALGUMAS PARTES)
            $('.navbar-center-container').css('filter', 'invert(0%)');

            //MUDAR TEXTO DOS BOTOES

            $('#run-button').text('▶️ file.Compilar();//Compilar Código');
            $('#new-button').text('📃 file.New();//Novo Arquivo');

            //MUDAR TEXTO
            //$('pre').each(function() {
            //    var text = $(this).text();
            //    $(this).text(text.replace('using System;', 'using System2;')); 
            //    });

            //$('pre').each(function() {
            //    var text = $(this).text();
            //    $(this).text(text.replace('using System2;', 'using System;')); 
            //    });
            ";

        #region MODALS

        public string ScriptModalTeste { get; } = @"
           
            ";

        #endregion MODALS


        #region Colors
        //DRACULA = Background
        public Color ColorBackg { get; } = Color.FromArgb(40, 42, 54);
        //DRACULA = Background Dark
        public Color ColorBackgDark { get; } = Color.FromArgb(34, 37, 53);
        //DRACULA = Background Light
        public Color ColorBackgLight { get; } = Color.FromArgb(50, 52, 64);
        //DRACULA = Cinza / Gray
        public Color ColorCinza { get; } = Color.FromArgb(54, 54, 54);
        //DRACULA = Foreground
        public Color ColorForeg { get; } = Color.FromArgb(248, 248, 242);
        //DRACULA = Current Line
        public Color ColorCurrentLine { get; } = Color.FromArgb(68, 71, 90);
        //DRACULA = Comment
        public Color ColorComment { get; } = Color.FromArgb(98, 114, 164);
        //??? = Purple
        public Color ColorPurple { get; } = Color.FromArgb(140, 0, 140);
        //CSHARP = Purple Light (L)
        public Color ColorC_PurpleL { get; } = Color.FromArgb(155, 79, 151);
        //CSHARP = Purple Medium (M)
        public Color ColorC_PurpleM { get; } = Color.FromArgb(128, 55, 136);
        //CSHARP = Purple High (H)
        public Color ColorC_PurpleH { get; } = Color.FromArgb(103, 33, 122);
        //EASY GREEN
        public Color ColorEasyGreen { get; } = Color.FromArgb(40, 167, 69);
        //EASY YELLOW
        public Color ColorEasyYellow { get; } = Color.FromArgb(255, 193, 7);
        //EASY RED
        public Color ColorEasyRed { get; } = Color.FromArgb(220, 53, 69);

        #endregion Colors

    }
}
