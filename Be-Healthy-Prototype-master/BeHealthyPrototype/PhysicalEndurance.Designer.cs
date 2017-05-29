namespace BeHealthyPrototype
{
    partial class PhysicalEndurance
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
            this.question = new System.Windows.Forms.Label();
            this.answersPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.cancelButton = new System.Windows.Forms.Button();
            this.continueButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // question
            // 
            this.question.AutoSize = true;
            this.question.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.question.Location = new System.Drawing.Point(16, 32);
            this.question.Name = "question";
            this.question.Size = new System.Drawing.Size(78, 15);
            this.question.TabIndex = 0;
            this.question.Text = "KLAUSIMAS";
            // 
            // answersPanel
            // 
            this.answersPanel.Location = new System.Drawing.Point(19, 134);
            this.answersPanel.Name = "answersPanel";
            this.answersPanel.Size = new System.Drawing.Size(407, 346);
            this.answersPanel.TabIndex = 1;
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(19, 501);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(95, 46);
            this.cancelButton.TabIndex = 8;
            this.cancelButton.Text = "Atšaukti";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // continueButton
            // 
            this.continueButton.Location = new System.Drawing.Point(169, 501);
            this.continueButton.Name = "continueButton";
            this.continueButton.Size = new System.Drawing.Size(257, 76);
            this.continueButton.TabIndex = 7;
            this.continueButton.Text = "Tęsti";
            this.continueButton.UseVisualStyleBackColor = true;
            this.continueButton.Click += new System.EventHandler(this.continueButton_Click);
            // 
            // PhysicalEndurance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.answersPanel);
            this.Controls.Add(this.continueButton);
            this.Controls.Add(this.question);
            this.Name = "PhysicalEndurance";
            this.Size = new System.Drawing.Size(450, 600);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label question;
        private System.Windows.Forms.FlowLayoutPanel answersPanel;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button continueButton;
    }
}
