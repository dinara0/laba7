
namespace laba7
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.Coord_label = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ShowColor_button = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonCircle = new System.Windows.Forms.Button();
            this.buttonSquare = new System.Windows.Forms.Button();
            this.buttonTriangle = new System.Windows.Forms.Button();
            this.buttonLine = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.buttonGroup = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Coord_label
            // 
            this.Coord_label.AutoSize = true;
            this.Coord_label.Location = new System.Drawing.Point(3, 9);
            this.Coord_label.Name = "Coord_label";
            this.Coord_label.Size = new System.Drawing.Size(94, 20);
            this.Coord_label.TabIndex = 1;
            this.Coord_label.Text = "Coord_label";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.Coord_label);
            this.panel1.Location = new System.Drawing.Point(104, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1083, 565);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Panel1_MouseMove);
            // 
            // ShowColor_button
            // 
            this.ShowColor_button.Location = new System.Drawing.Point(30, 567);
            this.ShowColor_button.Name = "ShowColor_button";
            this.ShowColor_button.Size = new System.Drawing.Size(126, 54);
            this.ShowColor_button.TabIndex = 3;
            this.ShowColor_button.Text = "выбрать цвет";
            this.ShowColor_button.UseVisualStyleBackColor = true;
            this.ShowColor_button.Click += new System.EventHandler(this.ShowCircle_button_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(163, 567);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 54);
            this.button1.TabIndex = 4;
            this.button1.Text = "выделить\r\n";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // buttonCircle
            // 
            this.buttonCircle.Location = new System.Drawing.Point(7, 27);
            this.buttonCircle.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonCircle.Name = "buttonCircle";
            this.buttonCircle.Size = new System.Drawing.Size(94, 54);
            this.buttonCircle.TabIndex = 5;
            this.buttonCircle.Text = "круг";
            this.buttonCircle.UseVisualStyleBackColor = true;
            this.buttonCircle.Click += new System.EventHandler(this.buttonCircle_Click);
            // 
            // buttonSquare
            // 
            this.buttonSquare.Location = new System.Drawing.Point(7, 90);
            this.buttonSquare.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonSquare.Name = "buttonSquare";
            this.buttonSquare.Size = new System.Drawing.Size(94, 54);
            this.buttonSquare.TabIndex = 6;
            this.buttonSquare.Text = "квадрат";
            this.buttonSquare.UseVisualStyleBackColor = true;
            this.buttonSquare.Click += new System.EventHandler(this.buttonSquare_Click);
            // 
            // buttonTriangle
            // 
            this.buttonTriangle.Location = new System.Drawing.Point(7, 153);
            this.buttonTriangle.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonTriangle.Name = "buttonTriangle";
            this.buttonTriangle.Size = new System.Drawing.Size(94, 54);
            this.buttonTriangle.TabIndex = 7;
            this.buttonTriangle.Text = "треугольник";
            this.buttonTriangle.UseVisualStyleBackColor = true;
            this.buttonTriangle.Click += new System.EventHandler(this.buttonTriangle_Click);
            // 
            // buttonLine
            // 
            this.buttonLine.Location = new System.Drawing.Point(7, 216);
            this.buttonLine.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonLine.Name = "buttonLine";
            this.buttonLine.Size = new System.Drawing.Size(94, 54);
            this.buttonLine.TabIndex = 8;
            this.buttonLine.Text = "линия";
            this.buttonLine.UseVisualStyleBackColor = true;
            this.buttonLine.Click += new System.EventHandler(this.buttonLine_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonLine);
            this.groupBox1.Controls.Add(this.buttonCircle);
            this.groupBox1.Controls.Add(this.buttonTriangle);
            this.groupBox1.Controls.Add(this.buttonSquare);
            this.groupBox1.Location = new System.Drawing.Point(2, 113);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(104, 276);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // buttonGroup
            // 
            this.buttonGroup.Location = new System.Drawing.Point(302, 567);
            this.buttonGroup.Name = "buttonGroup";
            this.buttonGroup.Size = new System.Drawing.Size(130, 53);
            this.buttonGroup.TabIndex = 5;
            this.buttonGroup.Text = "группировать";
            this.buttonGroup.UseVisualStyleBackColor = true;
            this.buttonGroup.Click += new System.EventHandler(this.buttonGroup_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1251, 635);
            this.Controls.Add(this.buttonGroup);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ShowColor_button);
            this.Controls.Add(this.panel1);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label Coord_label;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button ShowColor_button;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonCircle;
        private System.Windows.Forms.Button buttonSquare;
        private System.Windows.Forms.Button buttonTriangle;
        private System.Windows.Forms.Button buttonLine;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button buttonGroup;
    }
}

