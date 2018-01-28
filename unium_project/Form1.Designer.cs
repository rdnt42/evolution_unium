namespace unium_project
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
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxTest = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBoxTest2 = new System.Windows.Forms.TextBox();
            this.btn_place = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.labelCell = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(614, 189);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 52);
            this.button1.TabIndex = 0;
            this.button1.Text = "CREATE";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxTest
            // 
            this.textBoxTest.Location = new System.Drawing.Point(741, 189);
            this.textBoxTest.Name = "textBoxTest";
            this.textBoxTest.Size = new System.Drawing.Size(119, 20);
            this.textBoxTest.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(614, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(246, 158);
            this.dataGridView1.TabIndex = 2;
            // 
            // textBoxTest2
            // 
            this.textBoxTest2.Location = new System.Drawing.Point(741, 221);
            this.textBoxTest2.Name = "textBoxTest2";
            this.textBoxTest2.Size = new System.Drawing.Size(119, 20);
            this.textBoxTest2.TabIndex = 3;
            // 
            // btn_place
            // 
            this.btn_place.Location = new System.Drawing.Point(614, 291);
            this.btn_place.Name = "btn_place";
            this.btn_place.Size = new System.Drawing.Size(75, 23);
            this.btn_place.TabIndex = 4;
            this.btn_place.Text = "start";
            this.btn_place.UseVisualStyleBackColor = true;
            this.btn_place.Click += new System.EventHandler(this.btn_place_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(727, 291);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "next";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // labelCell
            // 
            this.labelCell.AutoSize = true;
            this.labelCell.Location = new System.Drawing.Point(626, 331);
            this.labelCell.Name = "labelCell";
            this.labelCell.Size = new System.Drawing.Size(35, 13);
            this.labelCell.TabIndex = 6;
            this.labelCell.Text = "label1";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(614, 361);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(246, 72);
            this.progressBar1.Step = 1;
            this.progressBar1.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 607);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.labelCell);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn_place);
            this.Controls.Add(this.textBoxTest2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBoxTest);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxTest;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBoxTest2;
        private System.Windows.Forms.Button btn_place;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label labelCell;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}

