namespace Yılan
{
    partial class yılan
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.baslamapnl = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.skorlbl = new System.Windows.Forms.Label();
            this.kolay = new System.Windows.Forms.RadioButton();
            this.zor = new System.Windows.Forms.RadioButton();
            this.skor = new System.Windows.Forms.Button();
            this.adtext = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.yardımbtn = new System.Windows.Forms.Button();
            this.yilanalanı = new System.Windows.Forms.Panel();
            this.baslamapnl.SuspendLayout();
            this.yilanalanı.SuspendLayout();
            this.SuspendLayout();
            // 
            // baslamapnl
            // 
            this.baslamapnl.Controls.Add(this.label1);
            this.baslamapnl.Enabled = false;
            this.baslamapnl.Location = new System.Drawing.Point(94, 51);
            this.baslamapnl.Name = "baslamapnl";
            this.baslamapnl.Size = new System.Drawing.Size(479, 264);
            this.baslamapnl.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Enabled = false;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(3, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(454, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Oyunu başlatmak için b tuşuna basınız";
            this.label1.Visible = false;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "skor:";
            // 
            // skorlbl
            // 
            this.skorlbl.AutoSize = true;
            this.skorlbl.Location = new System.Drawing.Point(57, 10);
            this.skorlbl.Name = "skorlbl";
            this.skorlbl.Size = new System.Drawing.Size(16, 17);
            this.skorlbl.TabIndex = 3;
            this.skorlbl.Text = "0";
            // 
            // kolay
            // 
            this.kolay.AutoSize = true;
            this.kolay.Location = new System.Drawing.Point(172, 358);
            this.kolay.Name = "kolay";
            this.kolay.Size = new System.Drawing.Size(62, 21);
            this.kolay.TabIndex = 4;
            this.kolay.TabStop = true;
            this.kolay.Text = "kolay";
            this.kolay.UseVisualStyleBackColor = true;
            this.kolay.Visible = false;
            this.kolay.CheckedChanged += new System.EventHandler(this.kolay_CheckedChanged);
            // 
            // zor
            // 
            this.zor.AutoSize = true;
            this.zor.Location = new System.Drawing.Point(328, 358);
            this.zor.Name = "zor";
            this.zor.Size = new System.Drawing.Size(49, 21);
            this.zor.TabIndex = 5;
            this.zor.TabStop = true;
            this.zor.Text = "zor";
            this.zor.UseVisualStyleBackColor = true;
            this.zor.Visible = false;
            this.zor.CheckedChanged += new System.EventHandler(this.zor_CheckedChanged);
            // 
            // skor
            // 
            this.skor.Location = new System.Drawing.Point(544, 436);
            this.skor.Name = "skor";
            this.skor.Size = new System.Drawing.Size(145, 30);
            this.skor.TabIndex = 6;
            this.skor.Text = "skor görüntüle";
            this.skor.UseVisualStyleBackColor = true;
            this.skor.Click += new System.EventHandler(this.skor_Click);
            // 
            // adtext
            // 
            this.adtext.Location = new System.Drawing.Point(158, 436);
            this.adtext.Multiline = true;
            this.adtext.Name = "adtext";
            this.adtext.Size = new System.Drawing.Size(189, 30);
            this.adtext.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(363, 436);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(145, 30);
            this.button1.TabIndex = 8;
            this.button1.Text = "kişiyi ekle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // yardımbtn
            // 
            this.yardımbtn.Location = new System.Drawing.Point(12, 436);
            this.yardımbtn.Name = "yardımbtn";
            this.yardımbtn.Size = new System.Drawing.Size(128, 30);
            this.yardımbtn.TabIndex = 9;
            this.yardımbtn.Text = "yardım";
            this.yardımbtn.UseVisualStyleBackColor = true;
            this.yardımbtn.Click += new System.EventHandler(this.yardımbtn_Click);
            // 
            // yilanalanı
            // 
            this.yilanalanı.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.yilanalanı.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.yilanalanı.Controls.Add(this.zor);
            this.yilanalanı.Controls.Add(this.kolay);
            this.yilanalanı.Controls.Add(this.baslamapnl);
            this.yilanalanı.Location = new System.Drawing.Point(12, 30);
            this.yilanalanı.Name = "yilanalanı";
            this.yilanalanı.Size = new System.Drawing.Size(700, 400);
            this.yilanalanı.TabIndex = 10;
            // 
            // yılan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 476);
            this.Controls.Add(this.yilanalanı);
            this.Controls.Add(this.yardımbtn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.adtext);
            this.Controls.Add(this.skor);
            this.Controls.Add(this.skorlbl);
            this.Controls.Add(this.label2);
            this.Name = "yılan";
            this.Text = "Yılan Oyunu";
            this.Load += new System.EventHandler(this.yılan_Load);
            this.baslamapnl.ResumeLayout(false);
            this.baslamapnl.PerformLayout();
            this.yilanalanı.ResumeLayout(false);
            this.yilanalanı.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel baslamapnl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label skorlbl;
        private System.Windows.Forms.RadioButton kolay;
        private System.Windows.Forms.RadioButton zor;
        private System.Windows.Forms.Button skor;
        private System.Windows.Forms.TextBox adtext;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button yardımbtn;
        private System.Windows.Forms.Panel yilanalanı;
    }
}

