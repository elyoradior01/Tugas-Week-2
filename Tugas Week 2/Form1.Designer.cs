namespace Tugas_Week_2
{
    partial class FormCoba
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblInputData = new System.Windows.Forms.Label();
            this.txtBox1 = new System.Windows.Forms.TextBox();
            this.btnProses = new System.Windows.Forms.Button();
            this.lblGanti = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblInputData
            // 
            this.lblInputData.AutoSize = true;
            this.lblInputData.Location = new System.Drawing.Point(36, 34);
            this.lblInputData.Name = "lblInputData";
            this.lblInputData.Size = new System.Drawing.Size(105, 25);
            this.lblInputData.TabIndex = 0;
            this.lblInputData.Text = "Input Data: ";
            // 
            // txtBox1
            // 
            this.txtBox1.Location = new System.Drawing.Point(36, 79);
            this.txtBox1.Name = "txtBox1";
            this.txtBox1.Size = new System.Drawing.Size(441, 31);
            this.txtBox1.TabIndex = 1;
            // 
            // btnProses
            // 
            this.btnProses.Location = new System.Drawing.Point(36, 143);
            this.btnProses.Name = "btnProses";
            this.btnProses.Size = new System.Drawing.Size(112, 34);
            this.btnProses.TabIndex = 2;
            this.btnProses.Text = "Proses";
            this.btnProses.UseVisualStyleBackColor = true;
            this.btnProses.Click += new System.EventHandler(this.btnProses_Click);
            // 
            // lblGanti
            // 
            this.lblGanti.AutoSize = true;
            this.lblGanti.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblGanti.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblGanti.Location = new System.Drawing.Point(32, 206);
            this.lblGanti.Name = "lblGanti";
            this.lblGanti.Size = new System.Drawing.Size(125, 32);
            this.lblGanti.TabIndex = 3;
            this.lblGanti.Text = "[EMPTY]";
            // 
            // FormCoba
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblGanti);
            this.Controls.Add(this.btnProses);
            this.Controls.Add(this.txtBox1);
            this.Controls.Add(this.lblInputData);
            this.Name = "FormCoba";
            this.Text = "Form Pengaturan Warna";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblInputData;
        private TextBox txtBox1;
        private Button btnProses;
        private Label lblGanti;
    }
}