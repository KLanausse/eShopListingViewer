namespace eShopListingViewer
{
    partial class Viewer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Viewer));
            this.BottomScreen = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // BottomScreen
            // 
            this.BottomScreen.BackColor = System.Drawing.Color.Ivory;
            this.BottomScreen.Font = new System.Drawing.Font("FOT-RodinNTLG Pro DB", 12F, System.Drawing.FontStyle.Bold);
            this.BottomScreen.Location = new System.Drawing.Point(40, 264);
            this.BottomScreen.Name = "BottomScreen";
            this.BottomScreen.Size = new System.Drawing.Size(320, 240);
            this.BottomScreen.TabIndex = 0;
            // 
            // Viewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.ClientSize = new System.Drawing.Size(400, 504);
            this.Controls.Add(this.BottomScreen);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(416, 543);
            this.MinimumSize = new System.Drawing.Size(416, 543);
            this.Name = "Viewer";
            this.Text = "eShop Listing Viewer";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel BottomScreen;
    }
}

