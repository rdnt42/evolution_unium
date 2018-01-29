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
            this.components = new System.ComponentModel.Container();
            this.btn_place = new System.Windows.Forms.Button();
            this.buttonNext = new System.Windows.Forms.Button();
            this.labelCell = new System.Windows.Forms.Label();
            this.progressBarCells = new System.Windows.Forms.ProgressBar();
            this.button3 = new System.Windows.Forms.Button();
            this.labelFood = new System.Windows.Forms.Label();
            this.progressBarFood = new System.Windows.Forms.ProgressBar();
            this.progressBarLoad = new System.Windows.Forms.ProgressBar();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_place
            // 
            this.btn_place.Location = new System.Drawing.Point(608, 14);
            this.btn_place.Name = "btn_place";
            this.btn_place.Size = new System.Drawing.Size(75, 23);
            this.btn_place.TabIndex = 4;
            this.btn_place.Text = "start";
            this.btn_place.UseVisualStyleBackColor = true;
            this.btn_place.Click += new System.EventHandler(this.btn_place_Click);
            // 
            // buttonNext
            // 
            this.buttonNext.Location = new System.Drawing.Point(716, 14);
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
            this.labelCell.Location = new System.Drawing.Point(607, 174);
            this.labelCell.Name = "labelCell";
            this.labelCell.Size = new System.Drawing.Size(100, 24);
            this.labelCell.TabIndex = 6;
            this.labelCell.Text = "count cells";
            // 
            // progressBarCells
            // 
            this.progressBarCells.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.progressBarCells.Location = new System.Drawing.Point(608, 201);
            this.progressBarCells.Name = "progressBarCells";
            this.progressBarCells.Size = new System.Drawing.Size(180, 30);
            this.progressBarCells.Step = 1;
            this.progressBarCells.TabIndex = 7;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(608, 54);
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
            this.labelFood.Location = new System.Drawing.Point(608, 246);
            this.labelFood.Name = "labelFood";
            this.labelFood.Size = new System.Drawing.Size(99, 24);
            this.labelFood.TabIndex = 9;
            this.labelFood.Text = "count food";
            // 
            // progressBarFood
            // 
            this.progressBarFood.Location = new System.Drawing.Point(608, 273);
            this.progressBarFood.Name = "progressBarFood";
            this.progressBarFood.Size = new System.Drawing.Size(180, 30);
            this.progressBarFood.Step = 1;
            this.progressBarFood.TabIndex = 10;
            // 
            // progressBarLoad
            // 
            this.progressBarLoad.Location = new System.Drawing.Point(608, 126);
            this.progressBarLoad.Name = "progressBarLoad";
            this.progressBarLoad.Size = new System.Drawing.Size(176, 23);
            this.progressBarLoad.TabIndex = 11;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(826, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(332, 576);
            this.dataGridView1.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(716, 520);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "group";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // timer1
            // 
            this.timer1.Interval = 20;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(612, 520);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 14;
            this.button2.Text = "test";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1201, 600);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.progressBarLoad);
            this.Controls.Add(this.progressBarFood);
            this.Controls.Add(this.labelFood);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.progressBarCells);
            this.Controls.Add(this.labelCell);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.btn_place);
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Evolution";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_place;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Label labelCell;
        private System.Windows.Forms.ProgressBar progressBarCells;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label labelFood;
        private System.Windows.Forms.ProgressBar progressBarFood;
        private System.Windows.Forms.ProgressBar progressBarLoad;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button2;
    }
}

