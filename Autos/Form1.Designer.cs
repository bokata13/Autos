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
            this.tb_rendsz = new System.Windows.Forms.TextBox();
            this.tb_gyart = new System.Windows.Forms.TextBox();
            this.bt_submit = new System.Windows.Forms.Button();
            this.tb_tipus = new System.Windows.Forms.TextBox();
            this.lib_1 = new System.Windows.Forms.ListBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
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
            this.lib_1.Location = new System.Drawing.Point(552, 63);
            this.lib_1.Name = "lib_1";
            this.lib_1.Size = new System.Drawing.Size(207, 290);
            this.lib_1.TabIndex = 10;
            this.lib_1.SelectedIndexChanged += new System.EventHandler(this.lib_1_SelectedIndexChanged);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(161, 199);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            150,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            54,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(189, 20);
            this.numericUpDown1.TabIndex = 11;
            this.numericUpDown1.Value = new decimal(new int[] {
            54,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.CausesValidation = false;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(356, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "(Formátum: ABC123)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(356, 199);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "Kw";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.lib_1);
            this.Controls.Add(this.tb_tipus);
            this.Controls.Add(this.bt_submit);
            this.Controls.Add(this.tb_gyart);
            this.Controls.Add(this.tb_rendsz);
            this.Controls.Add(this.lb_telj);
            this.Controls.Add(this.lb_gyart);
            this.Controls.Add(this.lb_tip);
            this.Controls.Add(this.lb_rendsz);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Gépjárműrögzítő";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_rendsz;
        private System.Windows.Forms.Label lb_tip;
        private System.Windows.Forms.Label lb_gyart;
        private System.Windows.Forms.Label lb_telj;
        private System.Windows.Forms.TextBox tb_rendsz;
        private System.Windows.Forms.TextBox tb_gyart;
        private System.Windows.Forms.Button bt_submit;
        private System.Windows.Forms.TextBox tb_tipus;
        private System.Windows.Forms.ListBox lib_1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

