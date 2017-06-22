namespace Solid_builder
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
            this.label_x = new System.Windows.Forms.Label();
            this.label_y = new System.Windows.Forms.Label();
            this.label_z = new System.Windows.Forms.Label();
            this.var_x = new System.Windows.Forms.TextBox();
            this.var_y = new System.Windows.Forms.TextBox();
            this.var_z = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_x
            // 
            this.label_x.AutoSize = true;
            this.label_x.Location = new System.Drawing.Point(32, 33);
            this.label_x.Name = "label_x";
            this.label_x.Size = new System.Drawing.Size(20, 13);
            this.label_x.TabIndex = 0;
            this.label_x.Text = "X=";
            // 
            // label_y
            // 
            this.label_y.AutoSize = true;
            this.label_y.Location = new System.Drawing.Point(32, 66);
            this.label_y.Name = "label_y";
            this.label_y.Size = new System.Drawing.Size(20, 13);
            this.label_y.TabIndex = 1;
            this.label_y.Text = "Y=";
            // 
            // label_z
            // 
            this.label_z.AutoSize = true;
            this.label_z.Location = new System.Drawing.Point(32, 101);
            this.label_z.Name = "label_z";
            this.label_z.Size = new System.Drawing.Size(20, 13);
            this.label_z.TabIndex = 2;
            this.label_z.Text = "Z=";
            // 
            // var_x
            // 
            this.var_x.Location = new System.Drawing.Point(58, 30);
            this.var_x.Name = "var_x";
            this.var_x.Size = new System.Drawing.Size(100, 20);
            this.var_x.TabIndex = 3;
            this.var_x.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.var_x_KeyPress);
            // 
            // var_y
            // 
            this.var_y.Location = new System.Drawing.Point(58, 59);
            this.var_y.Name = "var_y";
            this.var_y.Size = new System.Drawing.Size(100, 20);
            this.var_y.TabIndex = 4;
            this.var_y.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.var_y_KeyPress);
            // 
            // var_z
            // 
            this.var_z.Location = new System.Drawing.Point(58, 98);
            this.var_z.Name = "var_z";
            this.var_z.Size = new System.Drawing.Size(100, 20);
            this.var_z.TabIndex = 5;
            this.var_z.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.var_z_KeyPress);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(391, 33);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Get app";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 218);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.var_z);
            this.Controls.Add(this.var_y);
            this.Controls.Add(this.var_x);
            this.Controls.Add(this.label_z);
            this.Controls.Add(this.label_y);
            this.Controls.Add(this.label_x);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(512, 256);
            this.MinimumSize = new System.Drawing.Size(512, 256);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_x;
        private System.Windows.Forms.Label label_y;
        private System.Windows.Forms.Label label_z;
        private System.Windows.Forms.TextBox var_x;
        private System.Windows.Forms.TextBox var_y;
        private System.Windows.Forms.TextBox var_z;
        private System.Windows.Forms.Button button1;
    }
}

