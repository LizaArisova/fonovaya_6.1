namespace задача_6._1
{
    partial class forma
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
            this.buttonA = new System.Windows.Forms.Button();
            this.buttonB = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonA
            // 
            this.buttonA.BackColor = System.Drawing.Color.Coral;
            this.buttonA.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.buttonA.Font = new System.Drawing.Font("Bauhaus 93", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonA.ForeColor = System.Drawing.SystemColors.MenuText;
            this.buttonA.Location = new System.Drawing.Point(260, 80);
            this.buttonA.MaximumSize = new System.Drawing.Size(180, 50);
            this.buttonA.MinimumSize = new System.Drawing.Size(50, 50);
            this.buttonA.Name = "buttonA";
            this.buttonA.Size = new System.Drawing.Size(180, 50);
            this.buttonA.TabIndex = 0;
            this.buttonA.Text = "A";
            this.buttonA.UseVisualStyleBackColor = false;
            this.buttonA.UseWaitCursor = true;
            this.buttonA.Click += new System.EventHandler(this.buttonA_Click);
            // 
            // buttonB
            // 
            this.buttonB.BackColor = System.Drawing.Color.Coral;
            this.buttonB.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.buttonB.Font = new System.Drawing.Font("Bauhaus 93", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonB.ForeColor = System.Drawing.SystemColors.MenuText;
            this.buttonB.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonB.Location = new System.Drawing.Point(260, 174);
            this.buttonB.Name = "buttonB";
            this.buttonB.Size = new System.Drawing.Size(180, 50);
            this.buttonB.TabIndex = 1;
            this.buttonB.Text = "B";
            this.buttonB.UseVisualStyleBackColor = false;
            this.buttonB.UseWaitCursor = true;
            this.buttonB.Click += new System.EventHandler(this.buttonB_Click);
            // 
            // forma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(684, 361);
            this.Controls.Add(this.buttonB);
            this.Controls.Add(this.buttonA);
            this.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.Name = "forma";
            this.Text = "задача 6.1";
            this.UseWaitCursor = true;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonA;
        private System.Windows.Forms.Button buttonB;
    }
}

