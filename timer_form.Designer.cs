namespace timer
{
    partial class timer_form
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(timer_form));
            this.timer_log = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.timermin = new System.Windows.Forms.Timer(this.components);
            this.HH = new System.Windows.Forms.TextBox();
            this.MM = new System.Windows.Forms.TextBox();
            this.SS = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // timer_log
            // 
            this.timer_log.AutoSize = true;
            this.timer_log.Font = new System.Drawing.Font("American Captain", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timer_log.ForeColor = System.Drawing.Color.Orange;
            this.timer_log.Location = new System.Drawing.Point(200, 121);
            this.timer_log.Name = "timer_log";
            this.timer_log.Size = new System.Drawing.Size(351, 115);
            this.timer_log.TabIndex = 3;
            this.timer_log.Text = "00:00:00";
            this.timer_log.Click += new System.EventHandler(this.timer_log_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SaddleBrown;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.DarkOrange;
            this.button1.Location = new System.Drawing.Point(259, 346);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(207, 78);
            this.button1.TabIndex = 4;
            this.button1.Text = "Вкл/Выкл";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // timermin
            // 
            this.timermin.Tick += new System.EventHandler(this.timermin_Tick);
            // 
            // HH
            // 
            this.HH.BackColor = System.Drawing.SystemColors.MenuText;
            this.HH.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HH.ForeColor = System.Drawing.Color.OrangeRed;
            this.HH.Location = new System.Drawing.Point(220, 86);
            this.HH.Name = "HH";
            this.HH.Size = new System.Drawing.Size(78, 29);
            this.HH.TabIndex = 5;
            this.HH.Text = "0";
            this.HH.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.HH_KeyPress);
            // 
            // MM
            // 
            this.MM.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.MM.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MM.ForeColor = System.Drawing.Color.OrangeRed;
            this.MM.Location = new System.Drawing.Point(330, 86);
            this.MM.Name = "MM";
            this.MM.Size = new System.Drawing.Size(78, 29);
            this.MM.TabIndex = 6;
            this.MM.Text = "0";
            this.MM.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MM_KeyPress);
            // 
            // SS
            // 
            this.SS.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.SS.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SS.ForeColor = System.Drawing.Color.OrangeRed;
            this.SS.Location = new System.Drawing.Point(440, 86);
            this.SS.Name = "SS";
            this.SS.Size = new System.Drawing.Size(78, 29);
            this.SS.TabIndex = 7;
            this.SS.Text = "0";
            this.SS.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SS_KeyPress);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.SaddleBrown;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.ForeColor = System.Drawing.Color.DarkOrange;
            this.button2.Location = new System.Drawing.Point(259, 251);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(207, 78);
            this.button2.TabIndex = 8;
            this.button2.Text = "Зафиксировать значение";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // timer_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(769, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.SS);
            this.Controls.Add(this.MM);
            this.Controls.Add(this.HH);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.timer_log);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "timer_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Таймер";
            this.Load += new System.EventHandler(this.timer_form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label timer_log;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer timermin;
        private System.Windows.Forms.TextBox HH;
        private System.Windows.Forms.TextBox MM;
        private System.Windows.Forms.TextBox SS;
        private System.Windows.Forms.Button button2;
    }
}