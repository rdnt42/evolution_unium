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
            this.buttonNext = new System.Windows.Forms.Button();
            this.labelCell = new System.Windows.Forms.Label();
            this.progressBarCells = new System.Windows.Forms.ProgressBar();
            this.button3 = new System.Windows.Forms.Button();
            this.labelFood = new System.Windows.Forms.Label();
            this.progressBarFood = new System.Windows.Forms.ProgressBar();
            this.progressBarLoad = new System.Windows.Forms.ProgressBar();
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
            this.btn_place.Location = new System.Drawing.Point(619, 291);
            this.btn_place.Name = "btn_place";
            this.btn_place.Size = new System.Drawing.Size(75, 23);
            this.btn_place.TabIndex = 4;
            this.btn_place.Text = "start";
            this.btn_place.UseVisualStyleBackColor = true;
            this.btn_place.Click += new System.EventHandler(this.btn_place_Click);
            // 
            // buttonNext
            // 
            this.buttonNext.Location = new System.Drawing.Point(727, 291);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(75, 23);
            this.buttonNext.TabIndex = 5;
            this.buttonNext.Text = "next";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.button2_Click);
            // 
            // labelCell
            // 
            this.labelCell.AutoSize = true;
            this.labelCell.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCell.Location = new System.Drawing.Point(618, 451);
            this.labelCell.Name = "labelCell";
            this.labelCell.Size = new System.Drawing.Size(100, 24);
            this.labelCell.TabIndex = 6;
            this.labelCell.Text = "count cells";
            // 
            // progressBarCells
            // 
            this.progressBarCells.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.progressBarCells.Location = new System.Drawing.Point(619, 478);
            this.progressBarCells.Name = "progressBarCells";
            this.progressBarCells.Size = new System.Drawing.Size(180, 30);
            this.progressBarCells.Step = 1;
            this.progressBarCells.TabIndex = 7;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(619, 331);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(183, 36);
            this.button3.TabIndex = 8;
            this.button3.Text = "clear";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // labelFood
            // 
            this.labelFood.AutoSize = true;
            this.labelFood.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFood.Location = new System.Drawing.Point(619, 523);
            this.labelFood.Name = "labelFood";
            this.labelFood.Size = new System.Drawing.Size(99, 24);
            this.labelFood.TabIndex = 9;
            this.labelFood.Text = "count food";
            // 
            // progressBarFood
            // 
            this.progressBarFood.Location = new System.Drawing.Point(619, 550);
            this.progressBarFood.Name = "progressBarFood";
            this.progressBarFood.Size = new System.Drawing.Size(180, 30);
            this.progressBarFood.Step = 1;
            this.progressBarFood.TabIndex = 10;
            // 
            // progressBarLoad
            // 
            this.progressBarLoad.Location = new System.Drawing.Point(619, 403);
            this.progressBarLoad.Name = "progressBarLoad";
            this.progressBarLoad.Size = new System.Drawing.Size(176, 23);
            this.progressBarLoad.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(911, 599);
            this.Controls.Add(this.progressBarLoad);
            this.Controls.Add(this.progressBarFood);
            this.Controls.Add(this.labelFood);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.progressBarCells);
            this.Controls.Add(this.labelCell);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.btn_place);
            this.Controls.Add(this.textBoxTest2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBoxTest);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Evolution";
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
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Label labelCell;
        private System.Windows.Forms.ProgressBar progressBarCells;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label labelFood;
        private System.Windows.Forms.ProgressBar progressBarFood;
        private System.Windows.Forms.ProgressBar progressBarLoad;
    }
}

