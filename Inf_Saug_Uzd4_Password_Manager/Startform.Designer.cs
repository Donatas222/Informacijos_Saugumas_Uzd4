
namespace Inf_Saug_Uzd4_Password_Manager
{
    partial class Startform
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
            this.LoginButton = new System.Windows.Forms.Button();
            this.RegisterButton = new System.Windows.Forms.Button();
            this.MainFieldPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.UpdatePassButton = new System.Windows.Forms.Button();
            this.NewPassButton = new System.Windows.Forms.Button();
            this.DeletePassButton = new System.Windows.Forms.Button();
            this.FindPassButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LoginButton
            // 
            this.LoginButton.Location = new System.Drawing.Point(234, 357);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(148, 41);
            this.LoginButton.TabIndex = 0;
            this.LoginButton.Text = "Prisijungimas";
            this.LoginButton.UseVisualStyleBackColor = true;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // RegisterButton
            // 
            this.RegisterButton.Location = new System.Drawing.Point(409, 357);
            this.RegisterButton.Name = "RegisterButton";
            this.RegisterButton.Size = new System.Drawing.Size(148, 41);
            this.RegisterButton.TabIndex = 1;
            this.RegisterButton.Text = "Registracija";
            this.RegisterButton.UseVisualStyleBackColor = true;
            this.RegisterButton.Click += new System.EventHandler(this.RegisterButton_Click);
            // 
            // MainFieldPanel
            // 
            this.MainFieldPanel.AutoScroll = true;
            this.MainFieldPanel.Location = new System.Drawing.Point(0, 1);
            this.MainFieldPanel.Name = "MainFieldPanel";
            this.MainFieldPanel.Size = new System.Drawing.Size(800, 350);
            this.MainFieldPanel.TabIndex = 4;
            this.MainFieldPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.MainFieldPanel_Paint);
            // 
            // UpdatePassButton
            // 
            this.UpdatePassButton.Location = new System.Drawing.Point(162, 404);
            this.UpdatePassButton.Name = "UpdatePassButton";
            this.UpdatePassButton.Size = new System.Drawing.Size(148, 41);
            this.UpdatePassButton.TabIndex = 6;
            this.UpdatePassButton.Text = "Update password";
            this.UpdatePassButton.UseVisualStyleBackColor = true;
            this.UpdatePassButton.Visible = false;
            this.UpdatePassButton.Click += new System.EventHandler(this.UpdatePassButton_Click);
            // 
            // NewPassButton
            // 
            this.NewPassButton.Location = new System.Drawing.Point(8, 403);
            this.NewPassButton.Name = "NewPassButton";
            this.NewPassButton.Size = new System.Drawing.Size(148, 41);
            this.NewPassButton.TabIndex = 5;
            this.NewPassButton.Text = "New password";
            this.NewPassButton.UseVisualStyleBackColor = true;
            this.NewPassButton.Visible = false;
            this.NewPassButton.Click += new System.EventHandler(this.NewPassButton_Click);
            // 
            // DeletePassButton
            // 
            this.DeletePassButton.Location = new System.Drawing.Point(470, 403);
            this.DeletePassButton.Name = "DeletePassButton";
            this.DeletePassButton.Size = new System.Drawing.Size(148, 41);
            this.DeletePassButton.TabIndex = 8;
            this.DeletePassButton.Text = "Delete password";
            this.DeletePassButton.UseVisualStyleBackColor = true;
            this.DeletePassButton.Visible = false;
            this.DeletePassButton.Click += new System.EventHandler(this.DeletePassButton_Click);
            // 
            // FindPassButton
            // 
            this.FindPassButton.Location = new System.Drawing.Point(316, 404);
            this.FindPassButton.Name = "FindPassButton";
            this.FindPassButton.Size = new System.Drawing.Size(148, 41);
            this.FindPassButton.TabIndex = 7;
            this.FindPassButton.Text = "Find password";
            this.FindPassButton.UseVisualStyleBackColor = true;
            this.FindPassButton.Visible = false;
            this.FindPassButton.Click += new System.EventHandler(this.FindPassButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButton.Location = new System.Drawing.Point(640, 403);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(148, 41);
            this.ExitButton.TabIndex = 9;
            this.ExitButton.Text = "IŠEITI";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Visible = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // Startform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.DeletePassButton);
            this.Controls.Add(this.FindPassButton);
            this.Controls.Add(this.UpdatePassButton);
            this.Controls.Add(this.NewPassButton);
            this.Controls.Add(this.MainFieldPanel);
            this.Controls.Add(this.RegisterButton);
            this.Controls.Add(this.LoginButton);
            this.Name = "Startform";
            this.Text = "Slaptažodžių valdymo sistema";
            this.Load += new System.EventHandler(this.Startform_Load);
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.FlowLayoutPanel MainFieldPanel;
        public System.Windows.Forms.Button UpdatePassButton;
        public System.Windows.Forms.Button NewPassButton;
        public System.Windows.Forms.Button DeletePassButton;
        public System.Windows.Forms.Button FindPassButton;
        public System.Windows.Forms.Button LoginButton;
        public System.Windows.Forms.Button RegisterButton;
        public System.Windows.Forms.Button ExitButton;
    }
}

