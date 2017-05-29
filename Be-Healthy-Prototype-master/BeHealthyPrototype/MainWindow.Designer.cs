namespace BeHealthyPrototype
{
    partial class MainWindow
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.activBookButton = new System.Windows.Forms.Button();
            this.activatePremiumButton = new System.Windows.Forms.Button();
            this.calcKMIbutton = new System.Windows.Forms.Button();
            this.enterLevelButton = new System.Windows.Forms.Button();
            this.getProgramButton = new System.Windows.Forms.Button();
            this.helpButton = new System.Windows.Forms.Button();
            this.logoutButton = new System.Windows.Forms.Button();
            this.uploadButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // activBookButton
            // 
            this.activBookButton.Location = new System.Drawing.Point(66, 54);
            this.activBookButton.Name = "activBookButton";
            this.activBookButton.Size = new System.Drawing.Size(300, 33);
            this.activBookButton.TabIndex = 0;
            this.activBookButton.Text = "Užsakyti premium versiją";
            this.activBookButton.UseVisualStyleBackColor = true;
            this.activBookButton.Click += new System.EventHandler(this.activBookButton_Click);
            // 
            // activatePremiumButton
            // 
            this.activatePremiumButton.Location = new System.Drawing.Point(66, 121);
            this.activatePremiumButton.Name = "activatePremiumButton";
            this.activatePremiumButton.Size = new System.Drawing.Size(300, 33);
            this.activatePremiumButton.TabIndex = 1;
            this.activatePremiumButton.Text = "Aktyvuoti premium versiją";
            this.activatePremiumButton.UseVisualStyleBackColor = true;
            this.activatePremiumButton.Click += new System.EventHandler(this.activatePremiumButton_Click);
            // 
            // calcKMIbutton
            // 
            this.calcKMIbutton.Location = new System.Drawing.Point(66, 250);
            this.calcKMIbutton.Name = "calcKMIbutton";
            this.calcKMIbutton.Size = new System.Drawing.Size(300, 33);
            this.calcKMIbutton.TabIndex = 2;
            this.calcKMIbutton.Text = "Skaičiuoti KMI";
            this.calcKMIbutton.UseVisualStyleBackColor = true;
            this.calcKMIbutton.Click += new System.EventHandler(this.calcKMIbutton_Click);
            // 
            // enterLevelButton
            // 
            this.enterLevelButton.Location = new System.Drawing.Point(66, 319);
            this.enterLevelButton.Name = "enterLevelButton";
            this.enterLevelButton.Size = new System.Drawing.Size(300, 33);
            this.enterLevelButton.TabIndex = 3;
            this.enterLevelButton.Text = "Įvesti fizinio pajėgumo lygį";
            this.enterLevelButton.UseVisualStyleBackColor = true;
            this.enterLevelButton.Click += new System.EventHandler(this.enterLevelButton_Click);
            // 
            // getProgramButton
            // 
            this.getProgramButton.Location = new System.Drawing.Point(66, 380);
            this.getProgramButton.Name = "getProgramButton";
            this.getProgramButton.Size = new System.Drawing.Size(300, 33);
            this.getProgramButton.TabIndex = 4;
            this.getProgramButton.Text = "Gauti asmeninę programą";
            this.getProgramButton.UseVisualStyleBackColor = true;
            this.getProgramButton.Click += new System.EventHandler(this.getProgramButton_Click);
            // 
            // helpButton
            // 
            this.helpButton.Location = new System.Drawing.Point(66, 438);
            this.helpButton.Name = "helpButton";
            this.helpButton.Size = new System.Drawing.Size(300, 33);
            this.helpButton.TabIndex = 5;
            this.helpButton.Text = "Pagalba";
            this.helpButton.UseVisualStyleBackColor = true;
            this.helpButton.Click += new System.EventHandler(this.helpButton_Click);
            // 
            // logoutButton
            // 
            this.logoutButton.Location = new System.Drawing.Point(66, 499);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(300, 33);
            this.logoutButton.TabIndex = 6;
            this.logoutButton.Text = "Atsijungti";
            this.logoutButton.UseVisualStyleBackColor = true;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // uploadButton
            // 
            this.uploadButton.Location = new System.Drawing.Point(66, 188);
            this.uploadButton.Name = "uploadButton";
            this.uploadButton.Size = new System.Drawing.Size(300, 33);
            this.uploadButton.TabIndex = 7;
            this.uploadButton.Text = "Įkelti ligos istoriją";
            this.uploadButton.UseVisualStyleBackColor = true;
            this.uploadButton.Click += new System.EventHandler(this.uploadButton_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.uploadButton);
            this.Controls.Add(this.logoutButton);
            this.Controls.Add(this.helpButton);
            this.Controls.Add(this.getProgramButton);
            this.Controls.Add(this.enterLevelButton);
            this.Controls.Add(this.calcKMIbutton);
            this.Controls.Add(this.activatePremiumButton);
            this.Controls.Add(this.activBookButton);
            this.Name = "MainWindow";
            this.Size = new System.Drawing.Size(450, 600);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button activBookButton;
        private System.Windows.Forms.Button activatePremiumButton;
        private System.Windows.Forms.Button calcKMIbutton;
        private System.Windows.Forms.Button enterLevelButton;
        private System.Windows.Forms.Button getProgramButton;
        private System.Windows.Forms.Button helpButton;
        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.Button uploadButton;
    }
}
