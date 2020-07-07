namespace book
{
    partial class Form_Details
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
            this.components = new System.ComponentModel.Container();
            BunifuAnimatorNS.Animation animation1 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Details));
            this.label4 = new System.Windows.Forms.Label();
            this.txt_price = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_auther = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_name = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_pictuer = new System.Windows.Forms.PictureBox();
            this.txt_rate = new Bunifu.Framework.UI.BunifuRating();
            this.txt_date = new Bunifu.Framework.UI.BunifuDatepicker();
            this.txt_cat = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuTransition1 = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.txt_pictuer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label4.Location = new System.Drawing.Point(411, 279);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = ": التصنيف";
            // 
            // txt_price
            // 
            this.txt_price.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_price.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_price.ForeColor = System.Drawing.Color.White;
            this.txt_price.HintForeColor = System.Drawing.Color.Empty;
            this.txt_price.HintText = "";
            this.txt_price.isPassword = false;
            this.txt_price.LineFocusedColor = System.Drawing.Color.Blue;
            this.txt_price.LineIdleColor = System.Drawing.Color.Gray;
            this.txt_price.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txt_price.LineThickness = 3;
            this.txt_price.Location = new System.Drawing.Point(237, 202);
            this.txt_price.Margin = new System.Windows.Forms.Padding(4);
            this.txt_price.Name = "txt_price";
            this.txt_price.Size = new System.Drawing.Size(163, 29);
            this.txt_price.TabIndex = 13;
            this.txt_price.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Location = new System.Drawing.Point(423, 211);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = ": السعر";
            // 
            // txt_auther
            // 
            this.txt_auther.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_auther.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_auther.ForeColor = System.Drawing.Color.White;
            this.txt_auther.HintForeColor = System.Drawing.Color.Empty;
            this.txt_auther.HintText = "";
            this.txt_auther.isPassword = false;
            this.txt_auther.LineFocusedColor = System.Drawing.Color.Blue;
            this.txt_auther.LineIdleColor = System.Drawing.Color.Gray;
            this.txt_auther.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txt_auther.LineThickness = 3;
            this.txt_auther.Location = new System.Drawing.Point(237, 135);
            this.txt_auther.Margin = new System.Windows.Forms.Padding(4);
            this.txt_auther.Name = "txt_auther";
            this.txt_auther.Size = new System.Drawing.Size(163, 29);
            this.txt_auther.TabIndex = 11;
            this.txt_auther.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_auther.OnValueChanged += new System.EventHandler(this.txt_auther_OnValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Location = new System.Drawing.Point(420, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = ": المؤلف";
            // 
            // txt_name
            // 
            this.txt_name.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_name.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_name.ForeColor = System.Drawing.Color.White;
            this.txt_name.HintForeColor = System.Drawing.Color.Empty;
            this.txt_name.HintText = "";
            this.txt_name.isPassword = false;
            this.txt_name.LineFocusedColor = System.Drawing.Color.Blue;
            this.txt_name.LineIdleColor = System.Drawing.Color.Gray;
            this.txt_name.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txt_name.LineThickness = 3;
            this.txt_name.Location = new System.Drawing.Point(237, 78);
            this.txt_name.Margin = new System.Windows.Forms.Padding(4);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(163, 29);
            this.txt_name.TabIndex = 9;
            this.txt_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_name.OnValueChanged += new System.EventHandler(this.txt_name_OnValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(400, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = ": أسم الكتاب";
            // 
            // txt_pictuer
            // 
            this.bunifuTransition1.SetDecoration(this.txt_pictuer, BunifuAnimatorNS.DecorationType.None);
            this.txt_pictuer.Image = ((System.Drawing.Image)(resources.GetObject("txt_pictuer.Image")));
            this.txt_pictuer.Location = new System.Drawing.Point(59, 220);
            this.txt_pictuer.Name = "txt_pictuer";
            this.txt_pictuer.Size = new System.Drawing.Size(113, 151);
            this.txt_pictuer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.txt_pictuer.TabIndex = 21;
            this.txt_pictuer.TabStop = false;
            // 
            // txt_rate
            // 
            this.txt_rate.BackColor = System.Drawing.Color.Transparent;
            this.txt_rate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_rate.ForeColor = System.Drawing.Color.DimGray;
            this.txt_rate.Location = new System.Drawing.Point(46, 144);
            this.txt_rate.Margin = new System.Windows.Forms.Padding(5);
            this.txt_rate.Name = "txt_rate";
            this.txt_rate.Size = new System.Drawing.Size(142, 34);
            this.txt_rate.TabIndex = 19;
            this.txt_rate.Value = 0;
            // 
            // txt_date
            // 
            this.txt_date.BackColor = System.Drawing.Color.DimGray;
            this.txt_date.BorderRadius = 0;
            this.txt_date.ForeColor = System.Drawing.Color.White;
            this.txt_date.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.txt_date.FormatCustom = null;
            this.txt_date.Location = new System.Drawing.Point(17, 78);
            this.txt_date.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.txt_date.Name = "txt_date";
            this.txt_date.Size = new System.Drawing.Size(199, 35);
            this.txt_date.TabIndex = 20;
            this.txt_date.Value = new System.DateTime(2020, 4, 21, 22, 49, 49, 50);
            // 
            // txt_cat
            // 
            this.txt_cat.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_cat.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cat.ForeColor = System.Drawing.Color.White;
            this.txt_cat.HintForeColor = System.Drawing.Color.Empty;
            this.txt_cat.HintText = "";
            this.txt_cat.isPassword = false;
            this.txt_cat.LineFocusedColor = System.Drawing.Color.Blue;
            this.txt_cat.LineIdleColor = System.Drawing.Color.Gray;
            this.txt_cat.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txt_cat.LineThickness = 3;
            this.txt_cat.Location = new System.Drawing.Point(237, 268);
            this.txt_cat.Margin = new System.Windows.Forms.Padding(4);
            this.txt_cat.Name = "txt_cat";
            this.txt_cat.Size = new System.Drawing.Size(163, 29);
            this.txt_cat.TabIndex = 13;
            this.txt_cat.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(2, 2);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(34, 32);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 22;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // bunifuTransition1
            // 
            this.bunifuTransition1.AnimationType = BunifuAnimatorNS.AnimationType.ScaleAndHorizSlide;
            this.bunifuTransition1.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.bunifuTransition1.DefaultAnimation = animation1;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 15;
            this.bunifuElipse1.TargetControl = this;
            // 
            // Form_Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(492, 399);
            this.Controls.Add(this.bunifuImageButton1);
            this.Controls.Add(this.txt_pictuer);
            this.Controls.Add(this.txt_rate);
            this.Controls.Add(this.txt_date);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_cat);
            this.Controls.Add(this.txt_price);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_auther);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.label1);
            this.bunifuTransition1.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "Form_Details";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_Details";
            ((System.ComponentModel.ISupportInitialize)(this.txt_pictuer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        public Bunifu.Framework.UI.BunifuMaterialTextbox txt_price;
        private System.Windows.Forms.Label label3;
        public Bunifu.Framework.UI.BunifuMaterialTextbox txt_auther;
        private System.Windows.Forms.Label label2;
        public Bunifu.Framework.UI.BunifuMaterialTextbox txt_name;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.PictureBox txt_pictuer;
        public Bunifu.Framework.UI.BunifuRating txt_rate;
        public Bunifu.Framework.UI.BunifuDatepicker txt_date;
        public Bunifu.Framework.UI.BunifuMaterialTextbox txt_cat;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private BunifuAnimatorNS.BunifuTransition bunifuTransition1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
    }
}