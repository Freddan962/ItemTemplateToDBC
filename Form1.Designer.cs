namespace ItemTemplateToDBC
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.patchButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.hostField = new System.Windows.Forms.TextBox();
            this.usernameField = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.passwordField = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.portField = new System.Windows.Forms.TextBox();
            this.label77 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.status = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 205);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Created by Fractional";
            // 
            // patchButton
            // 
            this.patchButton.Location = new System.Drawing.Point(15, 164);
            this.patchButton.Name = "patchButton";
            this.patchButton.Size = new System.Drawing.Size(286, 23);
            this.patchButton.TabIndex = 3;
            this.patchButton.Text = "Patch";
            this.patchButton.UseVisualStyleBackColor = true;
            this.patchButton.Click += new System.EventHandler(this.patchButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Host";
            // 
            // hostField
            // 
            this.hostField.Location = new System.Drawing.Point(76, 10);
            this.hostField.Name = "hostField";
            this.hostField.Size = new System.Drawing.Size(225, 20);
            this.hostField.TabIndex = 5;
            // 
            // usernameField
            // 
            this.usernameField.Location = new System.Drawing.Point(76, 49);
            this.usernameField.Name = "usernameField";
            this.usernameField.Size = new System.Drawing.Size(225, 20);
            this.usernameField.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Username";
            // 
            // passwordField
            // 
            this.passwordField.Location = new System.Drawing.Point(76, 90);
            this.passwordField.Name = "passwordField";
            this.passwordField.Size = new System.Drawing.Size(225, 20);
            this.passwordField.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Password";
            // 
            // portField
            // 
            this.portField.Location = new System.Drawing.Point(76, 128);
            this.portField.Name = "portField";
            this.portField.Size = new System.Drawing.Size(225, 20);
            this.portField.TabIndex = 11;
            // 
            // label77
            // 
            this.label77.AutoSize = true;
            this.label77.Location = new System.Drawing.Point(12, 131);
            this.label77.Name = "label77";
            this.label77.Size = new System.Drawing.Size(26, 13);
            this.label77.TabIndex = 10;
            this.label77.Text = "Port";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.status});
            this.statusStrip1.Location = new System.Drawing.Point(0, 236);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(317, 22);
            this.statusStrip1.TabIndex = 12;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // status
            // 
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(0, 17);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 258);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.portField);
            this.Controls.Add(this.label77);
            this.Controls.Add(this.passwordField);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.usernameField);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.hostField);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.patchButton);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "ItemTemplateToDBC 1.0";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button patchButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox hostField;
        private System.Windows.Forms.TextBox usernameField;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox passwordField;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox portField;
        private System.Windows.Forms.Label label77;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel status;
    }
}

