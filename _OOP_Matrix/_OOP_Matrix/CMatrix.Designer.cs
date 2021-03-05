
namespace _OOP_Matrix
{
    partial class CMatrix
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
            this.textBoxRow1 = new System.Windows.Forms.TextBox();
            this.textBoxColumns1 = new System.Windows.Forms.TextBox();
            this.buttonCreate = new System.Windows.Forms.Button();
            this.buttonCalc = new System.Windows.Forms.Button();
            this.buttonFill = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxRow1
            // 
            this.textBoxRow1.Location = new System.Drawing.Point(573, 518);
            this.textBoxRow1.Name = "textBoxRow1";
            this.textBoxRow1.Size = new System.Drawing.Size(50, 20);
            this.textBoxRow1.TabIndex = 1;
            // 
            // textBoxColumns1
            // 
            this.textBoxColumns1.Location = new System.Drawing.Point(629, 518);
            this.textBoxColumns1.Name = "textBoxColumns1";
            this.textBoxColumns1.Size = new System.Drawing.Size(50, 20);
            this.textBoxColumns1.TabIndex = 2;
            // 
            // buttonCreate
            // 
            this.buttonCreate.Location = new System.Drawing.Point(686, 518);
            this.buttonCreate.Name = "buttonCreate";
            this.buttonCreate.Size = new System.Drawing.Size(75, 20);
            this.buttonCreate.TabIndex = 3;
            this.buttonCreate.Text = "Создать";
            this.buttonCreate.UseVisualStyleBackColor = true;
            this.buttonCreate.Click += new System.EventHandler(this.buttonCreate_Click);
            // 
            // buttonCalc
            // 
            this.buttonCalc.Location = new System.Drawing.Point(687, 518);
            this.buttonCalc.Name = "buttonCalc";
            this.buttonCalc.Size = new System.Drawing.Size(74, 20);
            this.buttonCalc.TabIndex = 6;
            this.buttonCalc.Text = "Вычислить";
            this.buttonCalc.UseVisualStyleBackColor = true;
            this.buttonCalc.Click += new System.EventHandler(this.buttonCalc_Click);
            // 
            // buttonFill
            // 
            this.buttonFill.Location = new System.Drawing.Point(687, 518);
            this.buttonFill.Name = "buttonFill";
            this.buttonFill.Size = new System.Drawing.Size(74, 20);
            this.buttonFill.TabIndex = 7;
            this.buttonFill.Text = "Заполнить";
            this.buttonFill.UseVisualStyleBackColor = true;
            this.buttonFill.Click += new System.EventHandler(this.buttonFill_Click);
            // 
            // CMatrix
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 544);
            this.Controls.Add(this.buttonFill);
            this.Controls.Add(this.buttonCalc);
            this.Controls.Add(this.buttonCreate);
            this.Controls.Add(this.textBoxColumns1);
            this.Controls.Add(this.textBoxRow1);
            this.Name = "CMatrix";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxRow1;
        private System.Windows.Forms.TextBox textBoxColumns1;
        private System.Windows.Forms.Button buttonCreate;
        private System.Windows.Forms.Button buttonCalc;
        private System.Windows.Forms.Button buttonFill;
    }
}

