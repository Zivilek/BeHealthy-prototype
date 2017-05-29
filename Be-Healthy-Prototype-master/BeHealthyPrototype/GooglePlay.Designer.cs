namespace BeHealthyPrototype
{
    partial class GooglePlay
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
            this.payButton = new System.Windows.Forms.Button();
            this.dontPayButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // payButton
            // 
            this.payButton.Location = new System.Drawing.Point(63, 163);
            this.payButton.Name = "payButton";
            this.payButton.Size = new System.Drawing.Size(300, 81);
            this.payButton.TabIndex = 0;
            this.payButton.Text = "Apmokėti";
            this.payButton.UseVisualStyleBackColor = true;
            this.payButton.Click += new System.EventHandler(this.payButton_Click);
            // 
            // dontPayButton
            // 
            this.dontPayButton.Location = new System.Drawing.Point(63, 335);
            this.dontPayButton.Name = "dontPayButton";
            this.dontPayButton.Size = new System.Drawing.Size(300, 74);
            this.dontPayButton.TabIndex = 1;
            this.dontPayButton.Text = "Neapmokėti";
            this.dontPayButton.UseVisualStyleBackColor = true;
            this.dontPayButton.Click += new System.EventHandler(this.dontPayButton_Click);
            // 
            // GooglePlay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dontPayButton);
            this.Controls.Add(this.payButton);
            this.Name = "GooglePlay";
            this.Size = new System.Drawing.Size(450, 600);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button payButton;
        private System.Windows.Forms.Button dontPayButton;
    }
}
