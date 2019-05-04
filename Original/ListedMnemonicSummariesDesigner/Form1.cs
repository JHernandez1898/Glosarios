using ListedMnemonicSummaries;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListedMnemonicSummariesDesigner
{
    public partial class Form1 : Form
    {
        string strLanguage = "";

        public Form1()
        {
            InitializeComponent();
            LanguageFileManager.SaveLanguage("Español");
            LanguageFileManager.SaveLanguage("English");
        }

        private void txtOriginal_TextChanged(object sender, EventArgs e)
        {
            lblSummarized.Text = Rewriter.Rewrite(txtOriginal.Text,strLanguage);

            switch (cboSyntax.SelectedItem.ToString().Replace(".synx", ""))
            {
                case "Español":
                    lblCharCountOriginal.Text = "Caracteres: " + txtOriginal.Text.Count();
                    lblCharCountSummarized.Text = "Caracteres: " + lblSummarized.Text.Count();
                    break;
                default:
                case "English":
                    lblCharCountOriginal.Text = "Char count: " + txtOriginal.Text.Count();
                    lblCharCountSummarized.Text = "Char count: " + lblSummarized.Text.Count();
                    break;
            }
            
        }

        private void btnCopyClipboard_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(lblSummarized.Text);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (string strFile in System.IO.Directory.GetFiles(@"Syntax\","*.synx"))
                cboSyntax.Items.Add(System.IO.Path.GetFileName(strFile));            
            if (cboSyntax.Items.Count > 0)
                cboSyntax.SelectedIndex = 0;
            strLanguage = cboSyntax.SelectedItem.ToString().Replace(".synx",""); 

        }

        private void cboSyntax_SelectedValueChanged(object sender, EventArgs e)
        {
            strLanguage = cboSyntax.SelectedItem.ToString().Replace(".synx", "");
            lblSummarized.Text = Rewriter.Rewrite(txtOriginal.Text, strLanguage);
            Translate();
        }

        private void Translate()
        {
            switch (cboSyntax.SelectedItem.ToString().Replace(".synx", ""))
            {
                case "Español":
                    Text = "Diseñador de Resumen Mnemotécnico Listado";
                    lblCurrentConcept.Text = "Concepto a agregar";
                    lblOriginalText.Text = "Texto original";
                    lblSummarizedTextPreview.Text = "Vista previa del texto resumido";
                    lblSyntax.Text = @"Seleccione la sintaxis de Syntax/*.synx";
                    lblTopic.Text = "Tema general (nombre de archivo)";
                    btnCopyClipboard.Text = "Copiar al portapapeles";
                    btnPaste.Text = "Pegar desde portapapeles";
                    btnAdd.Text = "Agregar al final del archivo";
                    lblCharCountOriginal.Text = "Caracteres: " + txtOriginal.Text.Count();
                    lblCharCountSummarized.Text = "Caracteres: " + lblSummarized.Text.Count();
                    btnOpen.Text = "Abrir " + txtTopic.Text + ".txt";
                    btnFolder.Text = "Abrir carpeta de Resúmenes Mnemotécnicos Listados";
                    break;
                default:
                case "English":
                    Text = "Listed Mnemonic Summary Designer";
                    lblCurrentConcept.Text = "Current concept";
                    lblOriginalText.Text = "Original text";
                    lblSummarizedTextPreview.Text = "Summarized text preview";
                    lblSyntax.Text = @"Select language syntax from /Syntax/*.synx";
                    lblTopic.Text = "Topic (filename)";
                    btnCopyClipboard.Text = "Copy to clipboard";
                    btnPaste.Text = "Paste from clipboard";
                    btnAdd.Text = "Add to the bottom of the file";
                    lblCharCountOriginal.Text = "Char count: " + txtOriginal.Text.Count();
                    lblCharCountSummarized.Text = "Char count: " + lblSummarized.Text.Count();
                    btnOpen.Text = "Open " + txtTopic.Text + ".txt";
                    btnFolder.Text = "Open Listed Mnemonic Summaries folder";                                     
                    break;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ListedTextFileManager.Write(txtTopic.Text, txtCurrentConcept.Text.ToUpper() +". "+ Rewriter.Rewrite(txtOriginal.Text, strLanguage), strLanguage);
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            switch (cboSyntax.SelectedItem.ToString().Replace(".synx", ""))
            {
                case "Español":
                    if (System.IO.File.Exists(@"Resúmenes Mnemotécnicos Listados\" + txtTopic.Text + ".txt"))
                        System.Diagnostics.Process.Start(@"Resúmenes Mnemotécnicos Listados\" + txtTopic.Text + ".txt");
                    else
                        MessageBox.Show(txtTopic.Text + ".txt no existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);                    
                    break;
                default:
                case "English":
                    if (System.IO.File.Exists(@"Listed Mnemonic Summaries\" + txtTopic.Text + ".txt"))
                        System.Diagnostics.Process.Start(@"Listed Mnemonic Summaries\" + txtTopic.Text + ".txt");
                    else
                        MessageBox.Show(txtTopic.Text + ".txt doesn't exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
        }

        private void btnFolder_Click(object sender, EventArgs e)
        {
            switch (cboSyntax.SelectedItem.ToString().Replace(".synx", ""))
            {
                case "Español":
                    System.Diagnostics.Process.Start(@"Resúmenes Mnemotécnicos Listados\");
                    break;
                default:
                case "English":
                    System.Diagnostics.Process.Start(@"Listed Mnemonic Summaries\");
                    break;
            }
        }

        private void txtTopic_TextChanged(object sender, EventArgs e)
        {
            switch (cboSyntax.SelectedItem.ToString().Replace(".synx", ""))
            {
                case "Español":                    
                    btnOpen.Text = "Abrir " + txtTopic.Text + ".txt";
                    break;
                default:
                case "English":                    
                    btnOpen.Text = "Open " + txtTopic.Text + ".txt";
                    break;
            }
        }

        private void btnPaste_Click(object sender, EventArgs e)
        {
            txtOriginal.Text = Clipboard.GetText();
        }
    }
}
