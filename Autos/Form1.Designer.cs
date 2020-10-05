namespace Autos
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lb_rendsz = new System.Windows.Forms.Label();
            this.lb_tip = new System.Windows.Forms.Label();
            this.lb_gyart = new System.Windows.Forms.Label();
            this.lb_telj = new System.Windows.Forms.Label();
            this.cb_teljesitmeny = new System.Windows.Forms.ComboBox();
            this.tb_rendsz = new System.Windows.Forms.TextBox();
            this.tb_gyart = new System.Windows.Forms.TextBox();
            this.bt_submit = new System.Windows.Forms.Button();
            this.tb_tipus = new System.Windows.Forms.TextBox();
            this.lib_1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lb_rendsz
            // 
            this.lb_rendsz.AutoSize = true;
            this.lb_rendsz.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lb_rendsz.Location = new System.Drawing.Point(47, 61);
            this.lb_rendsz.Name = "lb_rendsz";
            this.lb_rendsz.Size = new System.Drawing.Size(99, 20);
            this.lb_rendsz.TabIndex = 0;
            this.lb_rendsz.Text = "Rendszám:";
            // 
            // lb_tip
            // 
            this.lb_tip.AutoSize = true;
            this.lb_tip.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lb_tip.Location = new System.Drawing.Point(47, 150);
            this.lb_tip.Name = "lb_tip";
            this.lb_tip.Size = new System.Drawing.Size(57, 20);
            this.lb_tip.TabIndex = 1;
            this.lb_tip.Text = "Tipus:";
            // 
            // lb_gyart
            // 
            this.lb_gyart.AutoSize = true;
            this.lb_gyart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lb_gyart.Location = new System.Drawing.Point(47, 106);
            this.lb_gyart.Name = "lb_gyart";
            this.lb_gyart.Size = new System.Drawing.Size(100, 20);
            this.lb_gyart.TabIndex = 2;
            this.lb_gyart.Text = "Gyártmány:";
            // 
            // lb_telj
            // 
            this.lb_telj.AutoSize = true;
            this.lb_telj.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lb_telj.Location = new System.Drawing.Point(46, 200);
            this.lb_telj.Name = "lb_telj";
            this.lb_telj.Size = new System.Drawing.Size(108, 20);
            this.lb_telj.TabIndex = 3;
            this.lb_telj.Text = "Teljesítmény";
            // 
            // cb_teljesitmeny
            // 
            this.cb_teljesitmeny.FormattingEnabled = true;
            this.cb_teljesitmeny.Items.AddRange(new object[] {
            "50kw",
            "60kw",
            "70kw",
            "80kw",
            "90kw",
            "100kw"});
            this.cb_teljesitmeny.Location = new System.Drawing.Point(160, 202);
            this.cb_teljesitmeny.Name = "cb_teljesitmeny";
            this.cb_teljesitmeny.Size = new System.Drawing.Size(190, 21);
            this.cb_teljesitmeny.TabIndex = 4;
            // 
            // tb_rendsz
            // 
            this.tb_rendsz.Location = new System.Drawing.Point(160, 63);
            this.tb_rendsz.Name = "tb_rendsz";
            this.tb_rendsz.Size = new System.Drawing.Size(190, 20);
            this.tb_rendsz.TabIndex = 5;
            // 
            // tb_gyart
            // 
            this.tb_gyart.Location = new System.Drawing.Point(160, 108);
            this.tb_gyart.Name = "tb_gyart";
            this.tb_gyart.Size = new System.Drawing.Size(190, 20);
            this.tb_gyart.TabIndex = 7;
            // 
            // bt_submit
            // 
            this.bt_submit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_submit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bt_submit.Location = new System.Drawing.Point(51, 280);
            this.bt_submit.Name = "bt_submit";
            this.bt_submit.Size = new System.Drawing.Size(299, 62);
            this.bt_submit.TabIndex = 8;
            this.bt_submit.Text = "SUBMIT";
            this.bt_submit.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.bt_submit.UseVisualStyleBackColor = true;
            this.bt_submit.Click += new System.EventHandler(this.bt_submit_Click);
            // 
            // tb_tipus
            // 
            this.tb_tipus.Location = new System.Drawing.Point(160, 152);
            this.tb_tipus.Name = "tb_tipus";
            this.tb_tipus.Size = new System.Drawing.Size(190, 20);
            this.tb_tipus.TabIndex = 9;
            // 
            // lib_1
            // 
            this.lib_1.FormattingEnabled = true;
            this.lib_1.Location = new System.Drawing.Point(443, 61);
            this.lib_1.Name = "lib_1";
            this.lib_1.Size = new System.Drawing.Size(271, 290);
            this.lib_1.TabIndex = 10;
            this.lib_1.SelectedIndexChanged += new System.EventHandler(this.lib_1_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lib_1);
            this.Controls.Add(this.tb_tipus);
            this.Controls.Add(this.bt_submit);
            this.Controls.Add(this.tb_gyart);
            this.Controls.Add(this.tb_rendsz);
            this.Controls.Add(this.cb_teljesitmeny);
            this.Controls.Add(this.lb_telj);
            this.Controls.Add(this.lb_gyart);
            this.Controls.Add(this.lb_tip);
            this.Controls.Add(this.lb_rendsz);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Gépjárműrögzítő";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_rendsz;
        private System.Windows.Forms.Label lb_tip;
        private System.Windows.Forms.Label lb_gyart;
        private System.Windows.Forms.Label lb_telj;
        private System.Windows.Forms.ComboBox cb_teljesitmeny;
        private System.Windows.Forms.TextBox tb_rendsz;
        private System.Windows.Forms.TextBox tb_gyart;
        private System.Windows.Forms.Button bt_submit;
        private System.Windows.Forms.TextBox tb_tipus;
        private System.Windows.Forms.ListBox lib_1;
    }
}

