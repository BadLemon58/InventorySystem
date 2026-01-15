namespace InventorySystemManaement
{
    partial class ChangePassword
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
            this.lblOldPass = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtboxOldPass = new System.Windows.Forms.TextBox();
            this.txtboxNewPass = new System.Windows.Forms.TextBox();
            this.txtboxConfirmPass = new System.Windows.Forms.TextBox();
            this.btnChangePass = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblOldPass
            // 
            this.lblOldPass.AutoSize = true;
            this.lblOldPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOldPass.Location = new System.Drawing.Point(96, 77);
            this.lblOldPass.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOldPass.Name = "lblOldPass";
            this.lblOldPass.Size = new System.Drawing.Size(153, 20);
            this.lblOldPass.TabIndex = 0;
            this.lblOldPass.Text = "Enter Old Password:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(89, 118);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter New Password:\r\n";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(108, 161);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Confirm Password:";
            // 
            // txtboxOldPass
            // 
            this.txtboxOldPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxOldPass.Location = new System.Drawing.Point(266, 71);
            this.txtboxOldPass.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtboxOldPass.Name = "txtboxOldPass";
            this.txtboxOldPass.Size = new System.Drawing.Size(164, 26);
            this.txtboxOldPass.TabIndex = 3;
            this.txtboxOldPass.TextChanged += new System.EventHandler(this.txtboxOldPass_TextChanged);
            // 
            // txtboxNewPass
            // 
            this.txtboxNewPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxNewPass.Location = new System.Drawing.Point(266, 115);
            this.txtboxNewPass.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtboxNewPass.Name = "txtboxNewPass";
            this.txtboxNewPass.Size = new System.Drawing.Size(164, 26);
            this.txtboxNewPass.TabIndex = 4;
            this.txtboxNewPass.TextChanged += new System.EventHandler(this.txtboxNewPass_TextChanged);
            // 
            // txtboxConfirmPass
            // 
            this.txtboxConfirmPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxConfirmPass.Location = new System.Drawing.Point(266, 158);
            this.txtboxConfirmPass.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtboxConfirmPass.Name = "txtboxConfirmPass";
            this.txtboxConfirmPass.Size = new System.Drawing.Size(164, 26);
            this.txtboxConfirmPass.TabIndex = 5;
            this.txtboxConfirmPass.TextChanged += new System.EventHandler(this.txtboxConfirmPass_TextChanged);
            // 
            // btnChangePass
            // 
            this.btnChangePass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangePass.Location = new System.Drawing.Point(112, 249);
            this.btnChangePass.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnChangePass.Name = "btnChangePass";
            this.btnChangePass.Size = new System.Drawing.Size(137, 23);
            this.btnChangePass.TabIndex = 6;
            this.btnChangePass.Text = "Change Password";
            this.btnChangePass.UseVisualStyleBackColor = true;
            this.btnChangePass.Click += new System.EventHandler(this.btnChangePass_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(292, 249);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(137, 23);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // ChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnChangePass);
            this.Controls.Add(this.txtboxConfirmPass);
            this.Controls.Add(this.txtboxNewPass);
            this.Controls.Add(this.txtboxOldPass);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblOldPass);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ChangePassword";
            this.Text = "ChangePassword";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOldPass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtboxOldPass;
        private System.Windows.Forms.TextBox txtboxNewPass;
        private System.Windows.Forms.TextBox txtboxConfirmPass;
        private System.Windows.Forms.Button btnChangePass;
        private System.Windows.Forms.Button btnCancel;
    }
}