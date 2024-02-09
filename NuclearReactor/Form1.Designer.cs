namespace NuclearReactor
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
            this.titleLabel = new System.Windows.Forms.Label();
            this.reactorstableLabel = new System.Windows.Forms.Label();
            this.reactor1Label = new System.Windows.Forms.Label();
            this.reactor1Image = new System.Windows.Forms.Label();
            this.Reactor2Label = new System.Windows.Forms.Label();
            this.reactor2Image = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.Font = new System.Drawing.Font("Rockwell Condensed", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(12, 0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(745, 73);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Nuclear Reactor";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
         //   this.titleLabel.Click += new System.EventHandler(this.titleLabel_Click);
            // 
            // reactorstableLabel
            // 
            this.reactorstableLabel.BackColor = System.Drawing.Color.White;
            this.reactorstableLabel.Font = new System.Drawing.Font("Rockwell Condensed", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reactorstableLabel.Location = new System.Drawing.Point(100, 350);
            this.reactorstableLabel.Name = "reactorstableLabel";
            this.reactorstableLabel.Size = new System.Drawing.Size(563, 64);
            this.reactorstableLabel.TabIndex = 1;
            this.reactorstableLabel.Text = "Reactors Stable";
            this.reactorstableLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
       //     this.reactorstableLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // reactor1Label
            // 
            this.reactor1Label.Font = new System.Drawing.Font("Rockwell Condensed", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reactor1Label.Location = new System.Drawing.Point(169, 105);
            this.reactor1Label.Name = "reactor1Label";
            this.reactor1Label.Size = new System.Drawing.Size(136, 45);
            this.reactor1Label.TabIndex = 2;
            this.reactor1Label.Text = "Reactor 1";
            this.reactor1Label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
      //      this.reactor1Label.Click += new System.EventHandler(this.label2_Click);
            // 
            // reactor1Image
            // 
            this.reactor1Image.BackColor = System.Drawing.Color.LimeGreen;
            this.reactor1Image.Font = new System.Drawing.Font("Rockwell Condensed", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reactor1Image.Location = new System.Drawing.Point(145, 150);
            this.reactor1Image.Name = "reactor1Image";
            this.reactor1Image.Size = new System.Drawing.Size(185, 117);
            this.reactor1Image.TabIndex = 3;
            this.reactor1Image.TextAlign = System.Drawing.ContentAlignment.TopCenter;
         //   this.reactor1Image.Click += new System.EventHandler(this.reactor1Image_Click);
            // 
            // Reactor2Label
            // 
            this.Reactor2Label.Font = new System.Drawing.Font("Rockwell Condensed", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Reactor2Label.Location = new System.Drawing.Point(471, 105);
            this.Reactor2Label.Name = "Reactor2Label";
            this.Reactor2Label.Size = new System.Drawing.Size(136, 45);
            this.Reactor2Label.TabIndex = 4;
            this.Reactor2Label.Text = "Reactor 2";
            this.Reactor2Label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // reactor2Image
            // 
            this.reactor2Image.BackColor = System.Drawing.Color.LimeGreen;
            this.reactor2Image.Font = new System.Drawing.Font("Rockwell Condensed", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reactor2Image.Location = new System.Drawing.Point(445, 150);
            this.reactor2Image.Name = "reactor2Image";
            this.reactor2Image.Size = new System.Drawing.Size(185, 117);
            this.reactor2Image.TabIndex = 5;
            this.reactor2Image.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // startButton
            // 
            this.startButton.Font = new System.Drawing.Font("Rockwell Condensed", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startButton.Location = new System.Drawing.Point(327, 288);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(126, 46);
            this.startButton.TabIndex = 6;
            this.startButton.Text = "Sabotage";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(769, 442);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.reactor2Image);
            this.Controls.Add(this.Reactor2Label);
            this.Controls.Add(this.reactor1Image);
            this.Controls.Add(this.reactor1Label);
            this.Controls.Add(this.reactorstableLabel);
            this.Controls.Add(this.titleLabel);
            this.Name = "Form1";
            this.Text = "Nucleartypestuff";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label reactorstableLabel;
        private System.Windows.Forms.Label reactor1Label;
        private System.Windows.Forms.Label reactor1Image;
        private System.Windows.Forms.Label Reactor2Label;
        private System.Windows.Forms.Label reactor2Image;
        private System.Windows.Forms.Button startButton;
    }
}

