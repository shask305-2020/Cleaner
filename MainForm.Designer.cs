
namespace ChimChi
{
    partial class MainForm
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
            this.btnExit1 = new System.Windows.Forms.Button();
            this.btnOrder = new System.Windows.Forms.Button();
            this.btnNewOrder = new System.Windows.Forms.Button();
            this.UserName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnExit1
            // 
            this.btnExit1.Location = new System.Drawing.Point(213, 181);
            this.btnExit1.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnExit1.Name = "btnExit1";
            this.btnExit1.Size = new System.Drawing.Size(77, 36);
            this.btnExit1.TabIndex = 0;
            this.btnExit1.Text = "Выход";
            this.btnExit1.UseVisualStyleBackColor = true;
            this.btnExit1.Click += new System.EventHandler(this.btnExit1_Click);
            // 
            // btnOrder
            // 
            this.btnOrder.Location = new System.Drawing.Point(29, 84);
            this.btnOrder.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(161, 58);
            this.btnOrder.TabIndex = 1;
            this.btnOrder.Text = "Оформленные заказы";
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // btnNewOrder
            // 
            this.btnNewOrder.Location = new System.Drawing.Point(335, 84);
            this.btnNewOrder.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnNewOrder.Name = "btnNewOrder";
            this.btnNewOrder.Size = new System.Drawing.Size(161, 58);
            this.btnNewOrder.TabIndex = 2;
            this.btnNewOrder.Text = "Новый заказ";
            this.btnNewOrder.UseVisualStyleBackColor = true;
            this.btnNewOrder.Click += new System.EventHandler(this.btnNewOrder_Click);
            // 
            // UserName
            // 
            this.UserName.AutoSize = true;
            this.UserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UserName.Location = new System.Drawing.Point(164, 22);
            this.UserName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(139, 24);
            this.UserName.TabIndex = 3;
            this.UserName.Text = "Пользователь";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(26, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Имя пользователя:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 240);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UserName);
            this.Controls.Add(this.btnNewOrder);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.btnExit1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Главная";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit1;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Button btnNewOrder;
        private System.Windows.Forms.Label UserName;
        private System.Windows.Forms.Label label1;
    }
}