﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;

namespace VIPS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            webBrowser1.Navigate("http://test.de");
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            PAGEANALYZERLib.LayoutAnalyzer2 myAnalyzer = new PAGEANALYZERLib.LayoutAnalyzer2();
            myAnalyzer.Initialize(0);
            SHDocVw.IWebBrowser2 axbrowser = webBrowser1.ActiveXInstance as SHDocVw.IWebBrowser2;
            myAnalyzer.Analyze4(axbrowser.Document, 5);
            MSXML2.IXMLDOMDocument result = myAnalyzer.FOMPage as MSXML2.IXMLDOMDocument;
            RebuildPage(XDocument.Parse(result.xml));
        }

        private void RebuildPage(XDocument result)
        {
            // do something
        }
    }
}