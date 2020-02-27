namespace PujcDesktopApp
{
    partial class dashBoardForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dashBoardForm));
            this.dashBoardHeader = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dashBoardHeader
            // 
            this.dashBoardHeader.AutoSize = true;
            this.dashBoardHeader.Font = new System.Drawing.Font("Segoe UI Light", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashBoardHeader.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.dashBoardHeader.Location = new System.Drawing.Point(12, 9);
            this.dashBoardHeader.Name = "dashBoardHeader";
            this.dashBoardHeader.Size = new System.Drawing.Size(200, 50);
            this.dashBoardHeader.TabIndex = 4;
            this.dashBoardHeader.Text = "Dash Board";
            // 
            // dashBoardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1292, 1013);
            this.Controls.Add(this.dashBoardHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "dashBoardForm";
            this.Text = "Dash Board";
            this.Load += new System.EventHandler(this.dashBoardForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label dashBoardHeader;
    }
}

