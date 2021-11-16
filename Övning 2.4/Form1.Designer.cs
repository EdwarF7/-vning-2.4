
namespace Övning_2._4
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSkapaLinje = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSkapaCirkel = new System.Windows.Forms.Button();
            this.tbxHöjd = new System.Windows.Forms.TextBox();
            this.btnSkapaTriangel = new System.Windows.Forms.Button();
            this.tbxBredd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnArea = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lbxFigurer = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxArea = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSkapaLinje);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnSkapaCirkel);
            this.groupBox1.Controls.Add(this.tbxHöjd);
            this.groupBox1.Controls.Add(this.btnSkapaTriangel);
            this.groupBox1.Controls.Add(this.tbxBredd);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(334, 267);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Skapa";
            // 
            // btnSkapaLinje
            // 
            this.btnSkapaLinje.Location = new System.Drawing.Point(86, 219);
            this.btnSkapaLinje.Name = "btnSkapaLinje";
            this.btnSkapaLinje.Size = new System.Drawing.Size(164, 38);
            this.btnSkapaLinje.TabIndex = 6;
            this.btnSkapaLinje.Text = "Skapa Linje";
            this.btnSkapaLinje.UseVisualStyleBackColor = true;
            this.btnSkapaLinje.Click += new System.EventHandler(this.btnSkapaLinje_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bredd";
            // 
            // btnSkapaCirkel
            // 
            this.btnSkapaCirkel.Location = new System.Drawing.Point(86, 175);
            this.btnSkapaCirkel.Name = "btnSkapaCirkel";
            this.btnSkapaCirkel.Size = new System.Drawing.Size(164, 38);
            this.btnSkapaCirkel.TabIndex = 5;
            this.btnSkapaCirkel.Text = "Skapa Cirkel";
            this.btnSkapaCirkel.UseVisualStyleBackColor = true;
            this.btnSkapaCirkel.Click += new System.EventHandler(this.btnSkapaCirkel_Click);
            // 
            // tbxHöjd
            // 
            this.tbxHöjd.Location = new System.Drawing.Point(86, 89);
            this.tbxHöjd.Multiline = true;
            this.tbxHöjd.Name = "tbxHöjd";
            this.tbxHöjd.Size = new System.Drawing.Size(164, 33);
            this.tbxHöjd.TabIndex = 3;
            // 
            // btnSkapaTriangel
            // 
            this.btnSkapaTriangel.Location = new System.Drawing.Point(86, 131);
            this.btnSkapaTriangel.Name = "btnSkapaTriangel";
            this.btnSkapaTriangel.Size = new System.Drawing.Size(164, 38);
            this.btnSkapaTriangel.TabIndex = 4;
            this.btnSkapaTriangel.Text = "Skapa Triangel";
            this.btnSkapaTriangel.UseVisualStyleBackColor = true;
            this.btnSkapaTriangel.Click += new System.EventHandler(this.btnSkapaTriangel_Click);
            // 
            // tbxBredd
            // 
            this.tbxBredd.Location = new System.Drawing.Point(86, 50);
            this.tbxBredd.Multiline = true;
            this.tbxBredd.Name = "tbxBredd";
            this.tbxBredd.Size = new System.Drawing.Size(164, 33);
            this.tbxBredd.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Höjd";
            // 
            // btnArea
            // 
            this.btnArea.Location = new System.Drawing.Point(99, 309);
            this.btnArea.Name = "btnArea";
            this.btnArea.Size = new System.Drawing.Size(164, 38);
            this.btnArea.TabIndex = 7;
            this.btnArea.Text = "Sammanlagd Area";
            this.btnArea.UseVisualStyleBackColor = true;
            this.btnArea.Click += new System.EventHandler(this.btnArea_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(353, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 18);
            this.label3.TabIndex = 7;
            this.label3.Text = "Figurlista";
            // 
            // lbxFigurer
            // 
            this.lbxFigurer.FormattingEnabled = true;
            this.lbxFigurer.ItemHeight = 16;
            this.lbxFigurer.Location = new System.Drawing.Point(353, 53);
            this.lbxFigurer.Name = "lbxFigurer";
            this.lbxFigurer.Size = new System.Drawing.Size(222, 228);
            this.lbxFigurer.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(350, 293);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 18);
            this.label4.TabIndex = 7;
            this.label4.Text = "Sammanlagd area";
            // 
            // tbxArea
            // 
            this.tbxArea.Location = new System.Drawing.Point(353, 314);
            this.tbxArea.Multiline = true;
            this.tbxArea.Name = "tbxArea";
            this.tbxArea.Size = new System.Drawing.Size(220, 33);
            this.tbxArea.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 360);
            this.Controls.Add(this.tbxArea);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbxFigurer);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnArea);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSkapaLinje;
        private System.Windows.Forms.Button btnSkapaCirkel;
        private System.Windows.Forms.Button btnSkapaTriangel;
        private System.Windows.Forms.TextBox tbxHöjd;
        private System.Windows.Forms.TextBox tbxBredd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnArea;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lbxFigurer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbxArea;
    }
}

