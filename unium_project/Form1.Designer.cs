﻿namespace unium_project
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
            this.timerTurn = new System.Windows.Forms.Timer(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.textBoxErr = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_place
            // 
            this.btn_place.Location = new System.Drawing.Point(932, 12);
            this.btn_place.Name = "btn_place";
            this.btn_place.Size = new System.Drawing.Size(75, 23);
            this.btn_place.TabIndex = 4;
            this.btn_place.Text = "stage 1";
            this.btn_place.UseVisualStyleBackColor = true;
            this.btn_place.Click += new System.EventHandler(this.btn_place_Click);
            // 
            // buttonNext
            // 
            this.buttonNext.Location = new System.Drawing.Point(932, 41);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(75, 23);
            this.buttonNext.TabIndex = 5;
            this.buttonNext.Text = "stage 2";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.button2_Click);
            // 
            // labelCell
            // 
            this.labelCell.AutoSize = true;
            this.labelCell.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCell.Location = new System.Drawing.Point(159, 608);
            this.labelCell.Name = "labelCell";
            this.labelCell.Size = new System.Drawing.Size(100, 24);
            this.labelCell.TabIndex = 6;
            this.labelCell.Text = "count cells";
            this.labelCell.Click += new System.EventHandler(this.labelCell_Click);
            // 
            // progressBarCells
            // 
            this.progressBarCells.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.progressBarCells.Location = new System.Drawing.Point(157, 635);
            this.progressBarCells.Name = "progressBarCells";
            this.progressBarCells.Size = new System.Drawing.Size(180, 30);
            this.progressBarCells.Step = 1;
            this.progressBarCells.TabIndex = 7;
            this.progressBarCells.Click += new System.EventHandler(this.progressBarCells_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(932, 98);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 48);
            this.button3.TabIndex = 8;
            this.button3.Text = "clear";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // labelFood
            // 
            this.labelFood.AutoSize = true;
            this.labelFood.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFood.Location = new System.Drawing.Point(405, 608);
            this.labelFood.Name = "labelFood";
            this.labelFood.Size = new System.Drawing.Size(99, 24);
            this.labelFood.TabIndex = 9;
            this.labelFood.Text = "count food";
            this.labelFood.Click += new System.EventHandler(this.labelFood_Click);
            // 
            // progressBarFood
            // 
            this.progressBarFood.Location = new System.Drawing.Point(405, 635);
            this.progressBarFood.Name = "progressBarFood";
            this.progressBarFood.Size = new System.Drawing.Size(180, 30);
            this.progressBarFood.Step = 1;
            this.progressBarFood.TabIndex = 10;
            this.progressBarFood.Click += new System.EventHandler(this.progressBarFood_Click);
            // 
            // progressBarLoad
            // 
            this.progressBarLoad.Location = new System.Drawing.Point(117, 216);
            this.progressBarLoad.Name = "progressBarLoad";
            this.progressBarLoad.Size = new System.Drawing.Size(577, 28);
            this.progressBarLoad.TabIndex = 11;
            this.progressBarLoad.Click += new System.EventHandler(this.progressBarLoad_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(1045, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(297, 576);
            this.dataGridView1.TabIndex = 12;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(932, 383);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "group";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // timerTurn
            // 
            this.timerTurn.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(932, 310);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 14;
            this.button2.Text = "test";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(934, 186);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "elements";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(934, 231);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "empty elements";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(932, 70);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 22);
            this.button4.TabIndex = 18;
            this.button4.Text = "stage 3";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // textBoxErr
            // 
            this.textBoxErr.Location = new System.Drawing.Point(932, 264);
            this.textBoxErr.Name = "textBoxErr";
            this.textBoxErr.Size = new System.Drawing.Size(100, 20);
            this.textBoxErr.TabIndex = 20;
            this.textBoxErr.TextChanged += new System.EventHandler(this.textBoxErr_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 677);
            this.Controls.Add(this.textBoxErr);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
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
        private System.Windows.Forms.Timer timerTurn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox textBoxErr;
    }
}

