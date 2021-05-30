﻿using System;
using System.Drawing;
using System.IO;
using CefSharp.WinForms;

namespace Sistema.Class
{
    public class Data
    {

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

        //----------------------
        ";

        public string ScriptAddWeb { get; } = @"";

        public string ScriptCssWeb { get; } = @"";

        public string ScriptHideElement { get; } = @"
        $('.stats-pane').hide();    //Informacoes de Exec.
        $('.sidebar').hide();       //Sidebar Side
        $('.expander').hide();      //Expander Side
        $('.status-line').hide();   //File Name OnTop

        $('.btn').hide();   //Hide All BTN
        ";

        public string ScriptShowElement { get; } = @"
        $('#new-button').show();   //show - New File (reset)

        //$('#save-button').show();   //show - Save File

        //$('#fork-button').show();   //show - Fork

        $('#run-button').show();   //show - RUN CODE

        $('#Share').show();   //show - Share Code

        //$('#togetherjs').show();   //show - Collaborate

        $('#btn').show();   //show - New

        $('#btn').show();   //show - New

        $('.stats-pane').show();   //show - Stats Panel

        ";


        #region Dracula Colors
        //DRACULA = Background
        public Color ColorBackg { get; } = Color.FromArgb(40, 42, 54);
        //DRACULA = Foreground
        public Color ColorForeg { get; } = Color.FromArgb(248, 248, 242);
        //DRACULA = Current Line
        public Color ColorCurrentLine { get; } = Color.FromArgb(68, 71, 90);
        //DRACULA = Comment
        public Color ColorComment { get; } = Color.FromArgb(98, 114, 164);
        //DRACULA = Purple
        public Color ColorPurple { get; } = Color.FromArgb(189, 147, 249);
        #endregion Dracula Colors

    }
}