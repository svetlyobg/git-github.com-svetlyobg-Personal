namespace computerGraphics
{
    partial class frmGrafichniFormati
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGrafichniFormati));
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btnRasterni = new System.Windows.Forms.Button();
            this.btnVektorni = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnWeb = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBox1.Location = new System.Drawing.Point(-2, 0);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(699, 153);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // btnRasterni
            // 
            this.btnRasterni.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnRasterni.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRasterni.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnRasterni.Location = new System.Drawing.Point(12, 208);
            this.btnRasterni.Name = "btnRasterni";
            this.btnRasterni.Size = new System.Drawing.Size(131, 93);
            this.btnRasterni.TabIndex = 1;
            this.btnRasterni.Text = "Растерни графични формати";
            this.btnRasterni.UseVisualStyleBackColor = true;
            this.btnRasterni.Click += new System.EventHandler(this.btnRasterni_Click);
            // 
            // btnVektorni
            // 
            this.btnVektorni.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnVektorni.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVektorni.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnVektorni.Location = new System.Drawing.Point(193, 208);
            this.btnVektorni.Name = "btnVektorni";
            this.btnVektorni.Size = new System.Drawing.Size(131, 93);
            this.btnVektorni.TabIndex = 2;
            this.btnVektorni.Text = "Векторни графични формати";
            this.btnVektorni.UseVisualStyleBackColor = true;
            this.btnVektorni.Click += new System.EventHandler(this.btnVektorni_Click);
            // 
            // btnBack
            // 
            this.btnBack.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnBack.Location = new System.Drawing.Point(555, 208);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(131, 93);
            this.btnBack.TabIndex = 13;
            this.btnBack.Text = "<- Назад";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnWeb
            // 
            this.btnWeb.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnWeb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWeb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnWeb.Location = new System.Drawing.Point(374, 208);
            this.btnWeb.Name = "btnWeb";
            this.btnWeb.Size = new System.Drawing.Size(131, 93);
            this.btnWeb.TabIndex = 14;
            this.btnWeb.Text = "WEB графични формати";
            this.btnWeb.UseVisualStyleBackColor = true;
            this.btnWeb.Click += new System.EventHandler(this.btnWeb_Click);
            // 
            // frmGrafichniFormati
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 396);
            this.Controls.Add(this.btnWeb);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnVektorni);
            this.Controls.Add(this.btnRasterni);
            this.Controls.Add(this.richTextBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmGrafichniFormati";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Модул 5 Графични формати";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btnRasterni;
        private System.Windows.Forms.Button btnVektorni;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnWeb;
    }
}