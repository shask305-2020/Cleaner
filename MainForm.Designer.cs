
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
            this.SuspendLayout();
            // 
            // btnExit1
            // 
            this.btnExit1.Location = new System.Drawing.Point(284, 223);
            this.btnExit1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExit1.Name = "btnExit1";
            this.btnExit1.Size = new System.Drawing.Size(102, 44);
            this.btnExit1.TabIndex = 0;
            this.btnExit1.Text = "Выход";
            this.btnExit1.UseVisualStyleBackColor = true;
            this.btnExit1.Click += new System.EventHandler(this.btnExit1_Click);
            // 
            // btnOrder
            // 
            this.btnOrder.Location = new System.Drawing.Point(39, 104);
            this.btnOrder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(214, 72);
            this.btnOrder.TabIndex = 1;
            this.btnOrder.Text = "Оформленные заказы";
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // btnNewOrder
            // 
            this.btnNewOrder.Location = new System.Drawing.Point(446, 104);
            this.btnNewOrder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNewOrder.Name = "btnNewOrder";
            this.btnNewOrder.Size = new System.Drawing.Size(214, 72);
            this.btnNewOrder.TabIndex = 2;
            this.btnNewOrder.Text = "Новый заказ";
            this.btnNewOrder.UseVisualStyleBackColor = true;
            this.btnNewOrder.Click += new System.EventHandler(this.btnNewOrder_Click);
            // 
            // UserName
            // 
            this.UserName.AutoSize = true;
            this.UserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UserName.Location = new System.Drawing.Point(293, 36);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(79, 29);
            this.UserName.TabIndex = 3;
            this.UserName.Text = "label1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 296);
            this.Controls.Add(this.UserName);
            this.Controls.Add(this.btnNewOrder);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.btnExit1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
    }
}