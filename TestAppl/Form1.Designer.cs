namespace TestAppl
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.start = new System.Windows.Forms.Button();
            this.reset = new System.Windows.Forms.Button();
            this.TimeLabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.loadButton = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // start
            // 
            this.start.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.start.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.start.Location = new System.Drawing.Point(199, 243);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(183, 72);
            this.start.TabIndex = 0;
            this.start.Text = "Start";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // reset
            // 
            this.reset.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.reset.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.reset.Location = new System.Drawing.Point(388, 243);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(183, 72);
            this.reset.TabIndex = 3;
            this.reset.Text = "Reset";
            this.reset.UseVisualStyleBackColor = true;
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // TimeLabel
            // 
            this.TimeLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TimeLabel.AutoSize = true;
            this.TimeLabel.Font = new System.Drawing.Font("Tempus Sans ITC", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TimeLabel.Location = new System.Drawing.Point(81, 114);
            this.TimeLabel.Name = "TimeLabel";
            this.TimeLabel.Size = new System.Drawing.Size(648, 126);
            this.TimeLabel.TabIndex = 4;
            this.TimeLabel.Text = "00:00:00:00";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // loadButton
            // 
            this.loadButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.loadButton.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.loadButton.Location = new System.Drawing.Point(199, 321);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(183, 72);
            this.loadButton.TabIndex = 5;
            this.loadButton.Text = "Load";
            this.loadButton.UseVisualStyleBackColor = true;
            this.loadButton.Click += new System.EventHandler(this.loadButton_Click);
            // 
            // save
            // 
            this.save.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.save.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.save.Location = new System.Drawing.Point(388, 321);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(183, 72);
            this.save.TabIndex = 6;
            this.save.Text = "Save";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.save);
            this.Controls.Add(this.loadButton);
            this.Controls.Add(this.TimeLabel);
            this.Controls.Add(this.reset);
            this.Controls.Add(this.start);
            this.Name = "Form1";
            this.Text = "Application";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button start;
        private Button reset;
        private Label TimeLabel;
        private System.Windows.Forms.Timer timer1;
        private Button loadButton;
        private Button save;
    }
}