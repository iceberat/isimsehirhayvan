
namespace isimsehirhayvan
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtisim = new System.Windows.Forms.TextBox();
            this.txtşehir = new System.Windows.Forms.TextBox();
            this.txthayvan = new System.Windows.Forms.TextBox();
            this.btnharfal = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblharf = new System.Windows.Forms.Label();
            this.btnkontrol = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lblsüre = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblpuan = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtisim
            // 
            this.txtisim.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtisim.Location = new System.Drawing.Point(135, 194);
            this.txtisim.Name = "txtisim";
            this.txtisim.Size = new System.Drawing.Size(196, 30);
            this.txtisim.TabIndex = 0;
            // 
            // txtşehir
            // 
            this.txtşehir.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtşehir.Location = new System.Drawing.Point(337, 194);
            this.txtşehir.Name = "txtşehir";
            this.txtşehir.Size = new System.Drawing.Size(196, 30);
            this.txtşehir.TabIndex = 1;
            // 
            // txthayvan
            // 
            this.txthayvan.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txthayvan.Location = new System.Drawing.Point(539, 194);
            this.txthayvan.Name = "txthayvan";
            this.txthayvan.Size = new System.Drawing.Size(196, 30);
            this.txthayvan.TabIndex = 2;
            // 
            // btnharfal
            // 
            this.btnharfal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnharfal.Location = new System.Drawing.Point(90, 70);
            this.btnharfal.Name = "btnharfal";
            this.btnharfal.Size = new System.Drawing.Size(75, 29);
            this.btnharfal.TabIndex = 3;
            this.btnharfal.Text = "Harf al";
            this.btnharfal.UseVisualStyleBackColor = true;
            this.btnharfal.Click += new System.EventHandler(this.btnharfal_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(25, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "HARF : ";
            // 
            // lblharf
            // 
            this.lblharf.AutoSize = true;
            this.lblharf.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblharf.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblharf.Location = new System.Drawing.Point(111, 26);
            this.lblharf.Name = "lblharf";
            this.lblharf.Size = new System.Drawing.Size(28, 29);
            this.lblharf.TabIndex = 5;
            this.lblharf.Text = "A";
            // 
            // btnkontrol
            // 
            this.btnkontrol.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnkontrol.Location = new System.Drawing.Point(396, 230);
            this.btnkontrol.Name = "btnkontrol";
            this.btnkontrol.Size = new System.Drawing.Size(75, 29);
            this.btnkontrol.TabIndex = 6;
            this.btnkontrol.Text = "Kontrol";
            this.btnkontrol.UseVisualStyleBackColor = true;
            this.btnkontrol.Click += new System.EventHandler(this.btnkontrol_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(13, 290);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(371, 176);
            this.label3.TabIndex = 7;
            this.label3.Text = resources.GetString("label3.Text");
            // 
            // lblsüre
            // 
            this.lblsüre.AutoSize = true;
            this.lblsüre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblsüre.Location = new System.Drawing.Point(180, 79);
            this.lblsüre.Name = "lblsüre";
            this.lblsüre.Size = new System.Drawing.Size(85, 20);
            this.lblsüre.TabIndex = 8;
            this.lblsüre.Text = "SÜRE : 90";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(200, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "İSİM";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(392, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "ŞEHİR";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(598, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "HAYVAN";
            // 
            // lblpuan
            // 
            this.lblpuan.AutoSize = true;
            this.lblpuan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblpuan.Location = new System.Drawing.Point(299, 79);
            this.lblpuan.Name = "lblpuan";
            this.lblpuan.Size = new System.Drawing.Size(65, 20);
            this.lblpuan.TabIndex = 12;
            this.lblpuan.Text = "PUAN : ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(956, 475);
            this.Controls.Add(this.lblpuan);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblsüre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnkontrol);
            this.Controls.Add(this.lblharf);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnharfal);
            this.Controls.Add(this.txthayvan);
            this.Controls.Add(this.txtşehir);
            this.Controls.Add(this.txtisim);
            this.Name = "Form1";
            this.Text = "İSİM ŞEHİR HAYVAN OYUNU";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtisim;
        private System.Windows.Forms.TextBox txtşehir;
        private System.Windows.Forms.TextBox txthayvan;
        private System.Windows.Forms.Button btnharfal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblharf;
        private System.Windows.Forms.Button btnkontrol;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblsüre;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblpuan;
    }
}

