namespace Prince
{
    partial class Category
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
            this.catdesc = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.catid = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.catname = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // catdesc
            // 
            this.catdesc.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.catdesc.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.catdesc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.catdesc.HintForeColor = System.Drawing.Color.Empty;
            this.catdesc.HintText = "";
            this.catdesc.isPassword = false;
            this.catdesc.LineFocusedColor = System.Drawing.Color.Blue;
            this.catdesc.LineIdleColor = System.Drawing.Color.Black;
            this.catdesc.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.catdesc.LineThickness = 3;
            this.catdesc.Location = new System.Drawing.Point(319, 303);
            this.catdesc.Margin = new System.Windows.Forms.Padding(4);
            this.catdesc.Name = "catdesc";
            this.catdesc.Size = new System.Drawing.Size(370, 44);
            this.catdesc.TabIndex = 8;
            this.catdesc.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.catdesc.OnValueChanged += new System.EventHandler(this.bunifuMaterialTextbox2_OnValueChanged);
            // 
            // catid
            // 
            this.catid.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.catid.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.catid.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.catid.HintForeColor = System.Drawing.Color.Empty;
            this.catid.HintText = "";
            this.catid.isPassword = false;
            this.catid.LineFocusedColor = System.Drawing.Color.Blue;
            this.catid.LineIdleColor = System.Drawing.Color.Black;
            this.catid.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.catid.LineThickness = 3;
            this.catid.Location = new System.Drawing.Point(316, 114);
            this.catid.Margin = new System.Windows.Forms.Padding(4);
            this.catid.Name = "catid";
            this.catid.Size = new System.Drawing.Size(370, 44);
            this.catid.TabIndex = 7;
            this.catid.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(64, 310);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(188, 37);
            this.label3.TabIndex = 6;
            this.label3.Text = "Description";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(61, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 37);
            this.label2.TabIndex = 5;
            this.label2.Text = "ID";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.PeachPuff;
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.Color.OrangeRed;
            this.button7.Location = new System.Drawing.Point(304, 400);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(103, 43);
            this.button7.TabIndex = 31;
            this.button7.Text = "ADD";
            this.button7.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.PeachPuff;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.OrangeRed;
            this.button1.Location = new System.Drawing.Point(544, 400);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 43);
            this.button1.TabIndex = 32;
            this.button1.Text = "DELETE";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.PeachPuff;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.OrangeRed;
            this.button2.Location = new System.Drawing.Point(426, 400);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(103, 43);
            this.button2.TabIndex = 33;
            this.button2.Text = "UPDATE";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(196, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(475, 42);
            this.label1.TabIndex = 34;
            this.label1.Text = "PRODUCT CATEGORIES";
            // 
            // catname
            // 
            this.catname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.catname.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.catname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.catname.HintForeColor = System.Drawing.Color.Empty;
            this.catname.HintText = "";
            this.catname.isPassword = false;
            this.catname.LineFocusedColor = System.Drawing.Color.Blue;
            this.catname.LineIdleColor = System.Drawing.Color.Black;
            this.catname.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.catname.LineThickness = 3;
            this.catname.Location = new System.Drawing.Point(320, 206);
            this.catname.Margin = new System.Windows.Forms.Padding(4);
            this.catname.Name = "catname";
            this.catname.Size = new System.Drawing.Size(370, 44);
            this.catname.TabIndex = 36;
            this.catname.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.catname.OnValueChanged += new System.EventHandler(this.bunifuMaterialTextbox3_OnValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(65, 213);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 37);
            this.label4.TabIndex = 35;
            this.label4.Text = "Name";
            // 
            // Category
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 646);
            this.Controls.Add(this.catname);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.catdesc);
            this.Controls.Add(this.catid);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Category";
            this.Text = "Category";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuMaterialTextbox catdesc;
        private Bunifu.Framework.UI.BunifuMaterialTextbox catid;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox catname;
        private System.Windows.Forms.Label label4;
    }
}