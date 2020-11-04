namespace rehber
{
    partial class Form2
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
            this.txtNo = new System.Windows.Forms.RichTextBox();
            this.txtSoyad = new System.Windows.Forms.RichTextBox();
            this.txtAd = new System.Windows.Forms.RichTextBox();
            this.adRenk = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNo = new System.Windows.Forms.Label();
            this.lblSoyad = new System.Windows.Forms.Label();
            this.lblAd = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lblYazi1 = new System.Windows.Forms.Label();
            this.soyadRenk = new System.Windows.Forms.ComboBox();
            this.noRenk = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtNo
            // 
            this.txtNo.Location = new System.Drawing.Point(115, 110);
            this.txtNo.Margin = new System.Windows.Forms.Padding(2);
            this.txtNo.Name = "txtNo";
            this.txtNo.Size = new System.Drawing.Size(134, 25);
            this.txtNo.TabIndex = 33;
            this.txtNo.Text = "";
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(115, 75);
            this.txtSoyad.Margin = new System.Windows.Forms.Padding(2);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(134, 28);
            this.txtSoyad.TabIndex = 32;
            this.txtSoyad.Text = "";
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(115, 41);
            this.txtAd.Margin = new System.Windows.Forms.Padding(2);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(134, 28);
            this.txtAd.TabIndex = 31;
            this.txtAd.Text = "";
            // 
            // adRenk
            // 
            this.adRenk.FormattingEnabled = true;
            this.adRenk.Items.AddRange(new object[] {
            "kırmızı",
            "mavi",
            "yeşil"});
            this.adRenk.Location = new System.Drawing.Point(289, 41);
            this.adRenk.Margin = new System.Windows.Forms.Padding(2);
            this.adRenk.Name = "adRenk";
            this.adRenk.Size = new System.Drawing.Size(102, 28);
            this.adRenk.TabIndex = 28;
            this.adRenk.SelectedIndexChanged += new System.EventHandler(this.adRenk_SelectedIndexChanged);
            this.adRenk.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.adRenk_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(302, 8);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 27;
            this.label1.Text = "Renkler";
            // 
            // lblNo
            // 
            this.lblNo.AutoSize = true;
            this.lblNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblNo.Location = new System.Drawing.Point(28, 116);
            this.lblNo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNo.Name = "lblNo";
            this.lblNo.Size = new System.Drawing.Size(38, 20);
            this.lblNo.TabIndex = 26;
            this.lblNo.Text = "No:";
            // 
            // lblSoyad
            // 
            this.lblSoyad.AutoSize = true;
            this.lblSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSoyad.Location = new System.Drawing.Point(28, 80);
            this.lblSoyad.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSoyad.Name = "lblSoyad";
            this.lblSoyad.Size = new System.Drawing.Size(66, 20);
            this.lblSoyad.TabIndex = 25;
            this.lblSoyad.Text = "Soyad:";
            // 
            // lblAd
            // 
            this.lblAd.AutoSize = true;
            this.lblAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAd.Location = new System.Drawing.Point(29, 48);
            this.lblAd.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(37, 20);
            this.lblAd.TabIndex = 24;
            this.lblAd.Text = "Ad:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Violet;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(144, 171);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(154, 29);
            this.button1.TabIndex = 34;
            this.button1.Text = "Ekle";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button1_MouseClick);
            // 
            // lblYazi1
            // 
            this.lblYazi1.AutoSize = true;
            this.lblYazi1.Font = new System.Drawing.Font("Rod", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblYazi1.Location = new System.Drawing.Point(28, 212);
            this.lblYazi1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblYazi1.Name = "lblYazi1";
            this.lblYazi1.Size = new System.Drawing.Size(0, 13);
            this.lblYazi1.TabIndex = 35;
            // 
            // soyadRenk
            // 
            this.soyadRenk.FormattingEnabled = true;
            this.soyadRenk.Items.AddRange(new object[] {
            "kırmızı",
            "mavi",
            "yeşil"});
            this.soyadRenk.Location = new System.Drawing.Point(289, 72);
            this.soyadRenk.Margin = new System.Windows.Forms.Padding(2);
            this.soyadRenk.Name = "soyadRenk";
            this.soyadRenk.Size = new System.Drawing.Size(102, 28);
            this.soyadRenk.TabIndex = 36;
            this.soyadRenk.SelectedIndexChanged += new System.EventHandler(this.soyadRenk_SelectedIndexChanged);
            this.soyadRenk.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.soyadRenk_KeyPress);
            // 
            // noRenk
            // 
            this.noRenk.FormattingEnabled = true;
            this.noRenk.Items.AddRange(new object[] {
            "kırmızı",
            "mavi",
            "yeşil"});
            this.noRenk.Location = new System.Drawing.Point(289, 109);
            this.noRenk.Margin = new System.Windows.Forms.Padding(2);
            this.noRenk.Name = "noRenk";
            this.noRenk.Size = new System.Drawing.Size(102, 28);
            this.noRenk.TabIndex = 37;
            this.noRenk.SelectedIndexChanged += new System.EventHandler(this.noRenk_SelectedIndexChanged);
            this.noRenk.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.noRenk_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(141, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 20);
            this.label2.TabIndex = 38;
            this.label2.Text = "Bilgiler";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(417, 257);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.noRenk);
            this.Controls.Add(this.soyadRenk);
            this.Controls.Add(this.lblYazi1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtNo);
            this.Controls.Add(this.txtSoyad);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.adRenk);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblNo);
            this.Controls.Add(this.lblSoyad);
            this.Controls.Add(this.lblAd);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox txtNo;
        private System.Windows.Forms.RichTextBox txtSoyad;
        private System.Windows.Forms.RichTextBox txtAd;
        private System.Windows.Forms.ComboBox adRenk;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNo;
        private System.Windows.Forms.Label lblSoyad;
        private System.Windows.Forms.Label lblAd;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblYazi1;
        private System.Windows.Forms.ComboBox soyadRenk;
        private System.Windows.Forms.ComboBox noRenk;
        private System.Windows.Forms.Label label2;
    }
}