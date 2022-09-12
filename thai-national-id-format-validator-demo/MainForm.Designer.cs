namespace thai_national_id_format_validator_demo
{
    partial class MainForm
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
            this.lblThaiID = new System.Windows.Forms.Label();
            this.tbxThaiID = new System.Windows.Forms.TextBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblThaiID
            // 
            this.lblThaiID.AutoSize = true;
            this.lblThaiID.Location = new System.Drawing.Point(12, 9);
            this.lblThaiID.Name = "lblThaiID";
            this.lblThaiID.Size = new System.Drawing.Size(191, 21);
            this.lblThaiID.TabIndex = 0;
            this.lblThaiID.Text = "Enter you Thai national ID:";
            // 
            // tbxThaiID
            // 
            this.tbxThaiID.Location = new System.Drawing.Point(17, 34);
            this.tbxThaiID.Name = "tbxThaiID";
            this.tbxThaiID.Size = new System.Drawing.Size(415, 29);
            this.tbxThaiID.TabIndex = 1;
            this.tbxThaiID.TextChanged += new System.EventHandler(this.tbxThaiID_TextChanged);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.ForeColor = System.Drawing.Color.Red;
            this.lblResult.Location = new System.Drawing.Point(12, 75);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(56, 21);
            this.lblResult.TabIndex = 2;
            this.lblResult.Text = "Invalid";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 115);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.tbxThaiID);
            this.Controls.Add(this.lblThaiID);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thai National ID Format Validator Demo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblThaiID;
        private TextBox tbxThaiID;
        private Label lblResult;
    }
}