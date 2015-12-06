namespace CleanMyKeyboard
{
    partial class FullscreenForm
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
            this.centerPanel = new System.Windows.Forms.Panel();
            this.tLabel = new System.Windows.Forms.Label();
            this.iLabel = new System.Windows.Forms.Label();
            this.xLabel = new System.Windows.Forms.Label();
            this.eLabel = new System.Windows.Forms.Label();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.centerPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // centerPanel
            // 
            this.centerPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.centerPanel.BackColor = System.Drawing.Color.Black;
            this.centerPanel.Controls.Add(this.tLabel);
            this.centerPanel.Controls.Add(this.iLabel);
            this.centerPanel.Controls.Add(this.xLabel);
            this.centerPanel.Controls.Add(this.eLabel);
            this.centerPanel.Controls.Add(this.descriptionLabel);
            this.centerPanel.Location = new System.Drawing.Point(83, 102);
            this.centerPanel.Name = "centerPanel";
            this.centerPanel.Size = new System.Drawing.Size(630, 220);
            this.centerPanel.TabIndex = 0;
            // 
            // tLabel
            // 
            this.tLabel.AutoSize = true;
            this.tLabel.BackColor = System.Drawing.Color.Transparent;
            this.tLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tLabel.Location = new System.Drawing.Point(466, 66);
            this.tLabel.Name = "tLabel";
            this.tLabel.Size = new System.Drawing.Size(130, 135);
            this.tLabel.TabIndex = 4;
            this.tLabel.Text = "T";
            // 
            // iLabel
            // 
            this.iLabel.AutoSize = true;
            this.iLabel.BackColor = System.Drawing.Color.Transparent;
            this.iLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iLabel.Location = new System.Drawing.Point(354, 66);
            this.iLabel.Name = "iLabel";
            this.iLabel.Size = new System.Drawing.Size(90, 135);
            this.iLabel.TabIndex = 3;
            this.iLabel.Text = "I";
            // 
            // xLabel
            // 
            this.xLabel.AutoSize = true;
            this.xLabel.BackColor = System.Drawing.Color.Transparent;
            this.xLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xLabel.Location = new System.Drawing.Point(192, 66);
            this.xLabel.Name = "xLabel";
            this.xLabel.Size = new System.Drawing.Size(137, 135);
            this.xLabel.TabIndex = 2;
            this.xLabel.Text = "X";
            // 
            // eLabel
            // 
            this.eLabel.AutoSize = true;
            this.eLabel.BackColor = System.Drawing.Color.Transparent;
            this.eLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eLabel.Location = new System.Drawing.Point(37, 66);
            this.eLabel.Name = "eLabel";
            this.eLabel.Size = new System.Drawing.Size(137, 135);
            this.eLabel.TabIndex = 1;
            this.eLabel.Text = "E";
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.BackColor = System.Drawing.Color.Transparent;
            this.descriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionLabel.ForeColor = System.Drawing.Color.Silver;
            this.descriptionLabel.Location = new System.Drawing.Point(178, 22);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(267, 29);
            this.descriptionLabel.TabIndex = 0;
            this.descriptionLabel.Text = "Type EXIT to terminate.";
            // 
            // FullscreenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(807, 497);
            this.ControlBox = false;
            this.Controls.Add(this.centerPanel);
            this.MaximizeBox = false;
            this.Name = "FullscreenForm";
            this.ShowIcon = false;
            this.Text = "Clean My Keyboard";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FullscreenForm_FormClosing);
            this.Load += new System.EventHandler(this.FullscreenForm_Load);
            this.ResizeEnd += new System.EventHandler(this.FullscreenForm_ResizeEnd);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FullscreenForm_KeyPress);
            this.centerPanel.ResumeLayout(false);
            this.centerPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel centerPanel;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.Label tLabel;
        private System.Windows.Forms.Label iLabel;
        private System.Windows.Forms.Label xLabel;
        private System.Windows.Forms.Label eLabel;
    }
}

