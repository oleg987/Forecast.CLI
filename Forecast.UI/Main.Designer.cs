
namespace Forecast.UI
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lb_city = new System.Windows.Forms.Label();
            this.lb_temp = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lb_hum = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lb_pres = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_get = new System.Windows.Forms.Button();
            this.lb_set = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lb_rize = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "City: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(-157, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "City: ";
            // 
            // lb_city
            // 
            this.lb_city.AutoSize = true;
            this.lb_city.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_city.Location = new System.Drawing.Point(60, 13);
            this.lb_city.Name = "lb_city";
            this.lb_city.Size = new System.Drawing.Size(59, 19);
            this.lb_city.TabIndex = 2;
            this.lb_city.Text = "No data";
            // 
            // lb_temp
            // 
            this.lb_temp.AutoSize = true;
            this.lb_temp.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_temp.Location = new System.Drawing.Point(60, 32);
            this.lb_temp.Name = "lb_temp";
            this.lb_temp.Size = new System.Drawing.Size(59, 19);
            this.lb_temp.TabIndex = 4;
            this.lb_temp.Text = "No data";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(13, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Temp:";
            // 
            // lb_hum
            // 
            this.lb_hum.AutoSize = true;
            this.lb_hum.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_hum.Location = new System.Drawing.Point(60, 71);
            this.lb_hum.Name = "lb_hum";
            this.lb_hum.Size = new System.Drawing.Size(59, 19);
            this.lb_hum.TabIndex = 8;
            this.lb_hum.Text = "No data";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(13, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 19);
            this.label6.TabIndex = 7;
            this.label6.Text = "Hum:";
            // 
            // lb_pres
            // 
            this.lb_pres.AutoSize = true;
            this.lb_pres.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_pres.Location = new System.Drawing.Point(60, 52);
            this.lb_pres.Name = "lb_pres";
            this.lb_pres.Size = new System.Drawing.Size(59, 19);
            this.lb_pres.TabIndex = 6;
            this.lb_pres.Text = "No data";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(13, 52);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 19);
            this.label8.TabIndex = 5;
            this.label8.Text = "Pres:";
            // 
            // btn_get
            // 
            this.btn_get.Location = new System.Drawing.Point(13, 132);
            this.btn_get.Name = "btn_get";
            this.btn_get.Size = new System.Drawing.Size(75, 23);
            this.btn_get.TabIndex = 9;
            this.btn_get.Text = "Get";
            this.btn_get.UseVisualStyleBackColor = true;
            this.btn_get.Click += new System.EventHandler(this.btn_get_Click);
            // 
            // lb_set
            // 
            this.lb_set.AutoSize = true;
            this.lb_set.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_set.Location = new System.Drawing.Point(60, 110);
            this.lb_set.Name = "lb_set";
            this.lb_set.Size = new System.Drawing.Size(59, 19);
            this.lb_set.TabIndex = 13;
            this.lb_set.Text = "No data";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(13, 110);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(32, 19);
            this.label10.TabIndex = 12;
            this.label10.Text = "Set:";
            // 
            // lb_rize
            // 
            this.lb_rize.AutoSize = true;
            this.lb_rize.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_rize.Location = new System.Drawing.Point(60, 91);
            this.lb_rize.Name = "lb_rize";
            this.lb_rize.Size = new System.Drawing.Size(59, 19);
            this.lb_rize.TabIndex = 11;
            this.lb_rize.Text = "No data";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(13, 91);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(38, 19);
            this.label12.TabIndex = 10;
            this.label12.Text = "Rize:";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lb_set);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lb_rize);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.btn_get);
            this.Controls.Add(this.lb_hum);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lb_pres);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lb_temp);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lb_city);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Main";
            this.Text = "Forecast App";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lb_city;
        private System.Windows.Forms.Label lb_temp;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lb_hum;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lb_pres;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_get;
        private System.Windows.Forms.Label lb_set;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lb_rize;
        private System.Windows.Forms.Label label12;
    }
}

