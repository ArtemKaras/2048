namespace _2048_Game
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора 
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.UpDate = new System.Windows.Forms.Timer(this.components);
            this.start = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.scores = new System.Windows.Forms.Label();
            this.GameOwer = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.start)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GameOwer)).BeginInit();
            this.SuspendLayout();
            // 
            // start
            // 
            this.start.BackColor = System.Drawing.Color.SandyBrown;
            this.start.Location = new System.Drawing.Point(263, 6);
            this.start.Margin = new System.Windows.Forms.Padding(4);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(96, 34);
            this.start.TabIndex = 3;
            this.start.TabStop = false;
            this.start.Click += new System.EventHandler(this.start_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(3, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Очки:";
            // 
            // scores
            // 
            this.scores.AutoSize = true;
            this.scores.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.scores.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.scores.ForeColor = System.Drawing.Color.IndianRed;
            this.scores.Location = new System.Drawing.Point(73, 11);
            this.scores.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.scores.Name = "scores";
            this.scores.Size = new System.Drawing.Size(24, 25);
            this.scores.TabIndex = 5;
            this.scores.Text = "0";
            this.scores.Click += new System.EventHandler(this.scores_Click);
            // 
            // GameOwer
            // 
            this.GameOwer.BackColor = System.Drawing.Color.PeachPuff;
            this.GameOwer.BackgroundImage = global::_2048_Game.Properties.Resources.gm;
            this.GameOwer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.GameOwer.Enabled = false;
            this.GameOwer.Location = new System.Drawing.Point(-4, 229);
            this.GameOwer.Margin = new System.Windows.Forms.Padding(4);
            this.GameOwer.Name = "GameOwer";
            this.GameOwer.Size = new System.Drawing.Size(379, 162);
            this.GameOwer.TabIndex = 6;
            this.GameOwer.TabStop = false;
            this.GameOwer.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.SandyBrown;
            this.label2.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.label2.Enabled = false;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(279, 12);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 23);
            this.label2.TabIndex = 7;
            this.label2.Text = "Старт";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(372, 391);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.GameOwer);
            this.Controls.Add(this.scores);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.start);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "2048";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.K_D);
            ((System.ComponentModel.ISupportInitialize)(this.start)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GameOwer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer UpDate;
        private System.Windows.Forms.PictureBox start;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label scores;
        private System.Windows.Forms.PictureBox GameOwer;
        private System.Windows.Forms.Label label2;
    }
}

