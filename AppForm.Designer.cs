namespace DiningCourtApp
{
    partial class AppForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AppForm));
            this.label1 = new System.Windows.Forms.Label();
            this.lstOut = new System.Windows.Forms.ListBox();
            this.btnEnd = new System.Windows.Forms.Button();
            this.btnEnter = new System.Windows.Forms.Button();
            this.cboFood = new System.Windows.Forms.ComboBox();
            this.cboTime = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.recLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 25);
            this.label1.TabIndex = 0;
            // 
            // lstOut
            // 
            this.lstOut.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstOut.FormattingEnabled = true;
            this.lstOut.ItemHeight = 25;
            this.lstOut.Location = new System.Drawing.Point(609, 299);
            this.lstOut.Margin = new System.Windows.Forms.Padding(6);
            this.lstOut.Name = "lstOut";
            this.lstOut.Size = new System.Drawing.Size(360, 177);
            this.lstOut.TabIndex = 21;
            // 
            // btnEnd
            // 
            this.btnEnd.Location = new System.Drawing.Point(298, 322);
            this.btnEnd.Margin = new System.Windows.Forms.Padding(6);
            this.btnEnd.Name = "btnEnd";
            this.btnEnd.Size = new System.Drawing.Size(239, 154);
            this.btnEnd.TabIndex = 20;
            this.btnEnd.Text = "Exit";
            this.btnEnd.UseVisualStyleBackColor = true;
            this.btnEnd.Click += new System.EventHandler(this.btnEnd_Click);
            // 
            // btnEnter
            // 
            this.btnEnter.Location = new System.Drawing.Point(26, 322);
            this.btnEnter.Margin = new System.Windows.Forms.Padding(6);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(260, 154);
            this.btnEnter.TabIndex = 19;
            this.btnEnter.Text = "Find me a Dining Court";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // cboFood
            // 
            this.cboFood.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFood.FormattingEnabled = true;
            this.cboFood.Items.AddRange(new object[] {
            "Chicken",
            "Beef",
            "Pork",
            "Potatoes",
            "Fish",
            "Egg",
            "Cheese",
            "Pizza",
            "Burger",
            "Noodle"});
            this.cboFood.Location = new System.Drawing.Point(299, 262);
            this.cboFood.Margin = new System.Windows.Forms.Padding(6);
            this.cboFood.Name = "cboFood";
            this.cboFood.Size = new System.Drawing.Size(238, 33);
            this.cboFood.TabIndex = 17;
            // 
            // cboTime
            // 
            this.cboTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTime.FormattingEnabled = true;
            this.cboTime.Items.AddRange(new object[] {
            "Breakfast",
            "Lunch",
            "Dinner",
            "Late Lunch"});
            this.cboTime.Location = new System.Drawing.Point(299, 197);
            this.cboTime.Margin = new System.Windows.Forms.Padding(6);
            this.cboTime.Name = "cboTime";
            this.cboTime.Size = new System.Drawing.Size(238, 33);
            this.cboTime.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 268);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(264, 25);
            this.label3.TabIndex = 14;
            this.label3.Text = "What food would you like: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 203);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(190, 25);
            this.label2.TabIndex = 13;
            this.label2.Text = "Select Meal Time: ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(608, 4);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(361, 167);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 32.75F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(0, 34);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(614, 101);
            this.label5.TabIndex = 11;
            this.label5.Text = "Purdue Dining";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(604, 203);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(310, 25);
            this.label6.TabIndex = 22;
            this.label6.Text = "Dining Court Recommendation:";
            // 
            // recLabel
            // 
            this.recLabel.AutoSize = true;
            this.recLabel.Location = new System.Drawing.Point(614, 250);
            this.recLabel.Name = "recLabel";
            this.recLabel.Size = new System.Drawing.Size(0, 25);
            this.recLabel.TabIndex = 23;
            // 
            // AppForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 491);
            this.Controls.Add(this.recLabel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lstOut);
            this.Controls.Add(this.btnEnd);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.cboFood);
            this.Controls.Add(this.cboTime);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Name = "AppForm";
            this.Text = "Purdue Dining Court Reccommender";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstOut;
        private System.Windows.Forms.Button btnEnd;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.ComboBox cboFood;
        private System.Windows.Forms.ComboBox cboTime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label recLabel;
    }
}

