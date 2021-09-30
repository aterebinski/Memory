
namespace Memory
{
    partial class UserProfile
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
            this.submitBtn = new System.Windows.Forms.Button();
            this.firstNameEdit = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.firstNameRespond = new System.Windows.Forms.Label();
            this.lastNameRespond = new System.Windows.Forms.Label();
            this.LastNameLabel = new System.Windows.Forms.Label();
            this.lastNameEdit = new System.Windows.Forms.TextBox();
            this.emailRespond = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.emailEdit = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // submitBtn
            // 
            this.submitBtn.Location = new System.Drawing.Point(532, 362);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Size = new System.Drawing.Size(94, 29);
            this.submitBtn.TabIndex = 0;
            this.submitBtn.Text = "Submit";
            this.submitBtn.UseVisualStyleBackColor = true;
            this.submitBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // firstNameEdit
            // 
            this.firstNameEdit.Location = new System.Drawing.Point(368, 147);
            this.firstNameEdit.Name = "firstNameEdit";
            this.firstNameEdit.Size = new System.Drawing.Size(125, 27);
            this.firstNameEdit.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(303, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 37);
            this.label1.TabIndex = 2;
            this.label1.Text = "User Profile";
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Location = new System.Drawing.Point(236, 150);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(80, 20);
            this.firstNameLabel.TabIndex = 3;
            this.firstNameLabel.Text = "First Name";
            // 
            // firstNameRespond
            // 
            this.firstNameRespond.AutoSize = true;
            this.firstNameRespond.Location = new System.Drawing.Point(532, 150);
            this.firstNameRespond.Name = "firstNameRespond";
            this.firstNameRespond.Size = new System.Drawing.Size(41, 20);
            this.firstNameRespond.TabIndex = 4;
            this.firstNameRespond.Text = "Error";
            // 
            // lastNameRespond
            // 
            this.lastNameRespond.AutoSize = true;
            this.lastNameRespond.Location = new System.Drawing.Point(532, 200);
            this.lastNameRespond.Name = "lastNameRespond";
            this.lastNameRespond.Size = new System.Drawing.Size(41, 20);
            this.lastNameRespond.TabIndex = 7;
            this.lastNameRespond.Text = "Error";
            // 
            // LastNameLabel
            // 
            this.LastNameLabel.AutoSize = true;
            this.LastNameLabel.Location = new System.Drawing.Point(236, 200);
            this.LastNameLabel.Name = "LastNameLabel";
            this.LastNameLabel.Size = new System.Drawing.Size(79, 20);
            this.LastNameLabel.TabIndex = 6;
            this.LastNameLabel.Text = "Last Name";
            // 
            // lastNameEdit
            // 
            this.lastNameEdit.Location = new System.Drawing.Point(368, 197);
            this.lastNameEdit.Name = "lastNameEdit";
            this.lastNameEdit.Size = new System.Drawing.Size(125, 27);
            this.lastNameEdit.TabIndex = 5;
            // 
            // emailRespond
            // 
            this.emailRespond.AutoSize = true;
            this.emailRespond.Location = new System.Drawing.Point(532, 255);
            this.emailRespond.Name = "emailRespond";
            this.emailRespond.Size = new System.Drawing.Size(41, 20);
            this.emailRespond.TabIndex = 10;
            this.emailRespond.Text = "Error";
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Location = new System.Drawing.Point(236, 255);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(52, 20);
            this.emailLabel.TabIndex = 9;
            this.emailLabel.Text = "E-Mail";
            // 
            // emailEdit
            // 
            this.emailEdit.Location = new System.Drawing.Point(368, 252);
            this.emailEdit.Name = "emailEdit";
            this.emailEdit.Size = new System.Drawing.Size(125, 27);
            this.emailEdit.TabIndex = 8;
            // 
            // UserProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.emailRespond);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.emailEdit);
            this.Controls.Add(this.lastNameRespond);
            this.Controls.Add(this.LastNameLabel);
            this.Controls.Add(this.lastNameEdit);
            this.Controls.Add(this.firstNameRespond);
            this.Controls.Add(this.firstNameLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.firstNameEdit);
            this.Controls.Add(this.submitBtn);
            this.Name = "UserProfile";
            this.Text = "User Profile";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button submitBtn;
        private System.Windows.Forms.TextBox firstNameEdit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.Label firstNameRespond;
        private System.Windows.Forms.Label lastNameRespond;
        private System.Windows.Forms.Label LastNameLabel;
        private System.Windows.Forms.TextBox lastNameEdit;
        private System.Windows.Forms.Label emailRespond;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.TextBox emailEdit;
    }
}

