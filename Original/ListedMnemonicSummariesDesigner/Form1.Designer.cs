namespace ListedMnemonicSummariesDesigner
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtOriginal = new System.Windows.Forms.RichTextBox();
            this.lblSummarized = new System.Windows.Forms.Label();
            this.lblSummarizedTextPreview = new System.Windows.Forms.Label();
            this.lblOriginalText = new System.Windows.Forms.Label();
            this.lblSyntax = new System.Windows.Forms.Label();
            this.cboSyntax = new System.Windows.Forms.ComboBox();
            this.btnCopyClipboard = new System.Windows.Forms.Button();
            this.lblTopic = new System.Windows.Forms.Label();
            this.txtTopic = new System.Windows.Forms.TextBox();
            this.lblCurrentConcept = new System.Windows.Forms.Label();
            this.txtCurrentConcept = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblCharCountOriginal = new System.Windows.Forms.Label();
            this.lblCharCountSummarized = new System.Windows.Forms.Label();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnFolder = new System.Windows.Forms.Button();
            this.btnPaste = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtOriginal
            // 
            this.txtOriginal.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.txtOriginal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtOriginal.ForeColor = System.Drawing.Color.White;
            this.txtOriginal.Location = new System.Drawing.Point(12, 148);
            this.txtOriginal.Name = "txtOriginal";
            this.txtOriginal.Size = new System.Drawing.Size(234, 130);
            this.txtOriginal.TabIndex = 9;
            this.txtOriginal.Text = "";
            this.txtOriginal.TextChanged += new System.EventHandler(this.txtOriginal_TextChanged);
            // 
            // lblSummarized
            // 
            this.lblSummarized.AutoSize = true;
            this.lblSummarized.ForeColor = System.Drawing.Color.White;
            this.lblSummarized.Location = new System.Drawing.Point(252, 148);
            this.lblSummarized.MaximumSize = new System.Drawing.Size(230, 130);
            this.lblSummarized.Name = "lblSummarized";
            this.lblSummarized.Size = new System.Drawing.Size(87, 13);
            this.lblSummarized.TabIndex = 10;
            this.lblSummarized.Text = "Summarized text.";
            // 
            // lblSummarizedTextPreview
            // 
            this.lblSummarizedTextPreview.AutoSize = true;
            this.lblSummarizedTextPreview.ForeColor = System.Drawing.Color.White;
            this.lblSummarizedTextPreview.Location = new System.Drawing.Point(252, 128);
            this.lblSummarizedTextPreview.MaximumSize = new System.Drawing.Size(230, 130);
            this.lblSummarizedTextPreview.Name = "lblSummarizedTextPreview";
            this.lblSummarizedTextPreview.Size = new System.Drawing.Size(124, 13);
            this.lblSummarizedTextPreview.TabIndex = 8;
            this.lblSummarizedTextPreview.Text = "Summarized text preview";
            // 
            // lblOriginalText
            // 
            this.lblOriginalText.AutoSize = true;
            this.lblOriginalText.ForeColor = System.Drawing.Color.White;
            this.lblOriginalText.Location = new System.Drawing.Point(8, 126);
            this.lblOriginalText.MaximumSize = new System.Drawing.Size(230, 130);
            this.lblOriginalText.Name = "lblOriginalText";
            this.lblOriginalText.Size = new System.Drawing.Size(62, 13);
            this.lblOriginalText.TabIndex = 7;
            this.lblOriginalText.Text = "Original text";
            // 
            // lblSyntax
            // 
            this.lblSyntax.AutoSize = true;
            this.lblSyntax.ForeColor = System.Drawing.Color.White;
            this.lblSyntax.Location = new System.Drawing.Point(8, 9);
            this.lblSyntax.MaximumSize = new System.Drawing.Size(230, 130);
            this.lblSyntax.Name = "lblSyntax";
            this.lblSyntax.Size = new System.Drawing.Size(213, 13);
            this.lblSyntax.TabIndex = 1;
            this.lblSyntax.Text = "Select language syntax from /Syntax/*.synx";
            // 
            // cboSyntax
            // 
            this.cboSyntax.BackColor = System.Drawing.SystemColors.Menu;
            this.cboSyntax.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSyntax.FormattingEnabled = true;
            this.cboSyntax.Location = new System.Drawing.Point(239, 7);
            this.cboSyntax.Name = "cboSyntax";
            this.cboSyntax.Size = new System.Drawing.Size(244, 21);
            this.cboSyntax.TabIndex = 2;
            this.cboSyntax.SelectedValueChanged += new System.EventHandler(this.cboSyntax_SelectedValueChanged);
            // 
            // btnCopyClipboard
            // 
            this.btnCopyClipboard.Location = new System.Drawing.Point(281, 302);
            this.btnCopyClipboard.Name = "btnCopyClipboard";
            this.btnCopyClipboard.Size = new System.Drawing.Size(175, 23);
            this.btnCopyClipboard.TabIndex = 14;
            this.btnCopyClipboard.Text = "Copy to clipboard";
            this.btnCopyClipboard.UseVisualStyleBackColor = true;
            this.btnCopyClipboard.Click += new System.EventHandler(this.btnCopyClipboard_Click);
            // 
            // lblTopic
            // 
            this.lblTopic.AutoSize = true;
            this.lblTopic.ForeColor = System.Drawing.Color.White;
            this.lblTopic.Location = new System.Drawing.Point(8, 33);
            this.lblTopic.MaximumSize = new System.Drawing.Size(230, 130);
            this.lblTopic.Name = "lblTopic";
            this.lblTopic.Size = new System.Drawing.Size(82, 13);
            this.lblTopic.TabIndex = 3;
            this.lblTopic.Text = "Topic (filename)";
            // 
            // txtTopic
            // 
            this.txtTopic.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.txtTopic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTopic.ForeColor = System.Drawing.Color.White;
            this.txtTopic.Location = new System.Drawing.Point(11, 53);
            this.txtTopic.Name = "txtTopic";
            this.txtTopic.Size = new System.Drawing.Size(472, 20);
            this.txtTopic.TabIndex = 4;
            this.txtTopic.TextChanged += new System.EventHandler(this.txtTopic_TextChanged);
            // 
            // lblCurrentConcept
            // 
            this.lblCurrentConcept.AutoSize = true;
            this.lblCurrentConcept.ForeColor = System.Drawing.Color.White;
            this.lblCurrentConcept.Location = new System.Drawing.Point(8, 78);
            this.lblCurrentConcept.MaximumSize = new System.Drawing.Size(230, 130);
            this.lblCurrentConcept.Name = "lblCurrentConcept";
            this.lblCurrentConcept.Size = new System.Drawing.Size(83, 13);
            this.lblCurrentConcept.TabIndex = 5;
            this.lblCurrentConcept.Text = "Current concept";
            // 
            // txtCurrentConcept
            // 
            this.txtCurrentConcept.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.txtCurrentConcept.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCurrentConcept.ForeColor = System.Drawing.Color.White;
            this.txtCurrentConcept.Location = new System.Drawing.Point(11, 97);
            this.txtCurrentConcept.Name = "txtCurrentConcept";
            this.txtCurrentConcept.Size = new System.Drawing.Size(472, 20);
            this.txtCurrentConcept.TabIndex = 6;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(8, 335);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(475, 23);
            this.btnAdd.TabIndex = 15;
            this.btnAdd.Text = "Add to the bottom of the file";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblCharCountOriginal
            // 
            this.lblCharCountOriginal.AutoSize = true;
            this.lblCharCountOriginal.ForeColor = System.Drawing.Color.White;
            this.lblCharCountOriginal.Location = new System.Drawing.Point(151, 281);
            this.lblCharCountOriginal.MaximumSize = new System.Drawing.Size(230, 130);
            this.lblCharCountOriginal.Name = "lblCharCountOriginal";
            this.lblCharCountOriginal.Size = new System.Drawing.Size(63, 13);
            this.lblCharCountOriginal.TabIndex = 11;
            this.lblCharCountOriginal.Text = "Word count";
            this.lblCharCountOriginal.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblCharCountSummarized
            // 
            this.lblCharCountSummarized.AutoSize = true;
            this.lblCharCountSummarized.ForeColor = System.Drawing.Color.White;
            this.lblCharCountSummarized.Location = new System.Drawing.Point(382, 281);
            this.lblCharCountSummarized.MaximumSize = new System.Drawing.Size(230, 130);
            this.lblCharCountSummarized.Name = "lblCharCountSummarized";
            this.lblCharCountSummarized.Size = new System.Drawing.Size(63, 13);
            this.lblCharCountSummarized.TabIndex = 12;
            this.lblCharCountSummarized.Text = "Word count";
            this.lblCharCountSummarized.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(8, 362);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(199, 23);
            this.btnOpen.TabIndex = 16;
            this.btnOpen.Text = "Open file";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnFolder
            // 
            this.btnFolder.Location = new System.Drawing.Point(213, 362);
            this.btnFolder.Name = "btnFolder";
            this.btnFolder.Size = new System.Drawing.Size(270, 23);
            this.btnFolder.TabIndex = 17;
            this.btnFolder.Text = "Open Listed Mnemonic Summaries folder";
            this.btnFolder.UseVisualStyleBackColor = true;
            this.btnFolder.Click += new System.EventHandler(this.btnFolder_Click);
            // 
            // btnPaste
            // 
            this.btnPaste.Location = new System.Drawing.Point(39, 302);
            this.btnPaste.Name = "btnPaste";
            this.btnPaste.Size = new System.Drawing.Size(175, 23);
            this.btnPaste.TabIndex = 13;
            this.btnPaste.Text = "Paste from clipboard";
            this.btnPaste.UseVisualStyleBackColor = true;
            this.btnPaste.Click += new System.EventHandler(this.btnPaste_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(493, 391);
            this.Controls.Add(this.btnPaste);
            this.Controls.Add(this.btnFolder);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.lblCharCountSummarized);
            this.Controls.Add(this.lblCharCountOriginal);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtCurrentConcept);
            this.Controls.Add(this.lblCurrentConcept);
            this.Controls.Add(this.txtTopic);
            this.Controls.Add(this.lblTopic);
            this.Controls.Add(this.btnCopyClipboard);
            this.Controls.Add(this.cboSyntax);
            this.Controls.Add(this.lblSyntax);
            this.Controls.Add(this.lblOriginalText);
            this.Controls.Add(this.lblSummarizedTextPreview);
            this.Controls.Add(this.lblSummarized);
            this.Controls.Add(this.txtOriginal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listed Mnemonic Summary Designer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox txtOriginal;
        private System.Windows.Forms.Label lblSummarized;
        private System.Windows.Forms.Label lblSummarizedTextPreview;
        private System.Windows.Forms.Label lblOriginalText;
        private System.Windows.Forms.Label lblSyntax;
        private System.Windows.Forms.ComboBox cboSyntax;
        private System.Windows.Forms.Button btnCopyClipboard;
        private System.Windows.Forms.Label lblTopic;
        private System.Windows.Forms.TextBox txtTopic;
        private System.Windows.Forms.Label lblCurrentConcept;
        private System.Windows.Forms.TextBox txtCurrentConcept;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblCharCountOriginal;
        private System.Windows.Forms.Label lblCharCountSummarized;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnFolder;
        private System.Windows.Forms.Button btnPaste;
    }
}

