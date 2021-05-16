
namespace XMLTreeVisualization
{
    partial class MainForm
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button_visualization = new System.Windows.Forms.Button();
            this.button_download = new System.Windows.Forms.Button();
            this.textBox_link = new System.Windows.Forms.TextBox();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_visualization
            // 
            this.button_visualization.Location = new System.Drawing.Point(368, 10);
            this.button_visualization.Name = "button_visualization";
            this.button_visualization.Size = new System.Drawing.Size(97, 20);
            this.button_visualization.TabIndex = 0;
            this.button_visualization.Text = "Visualization Tree";
            this.button_visualization.UseVisualStyleBackColor = true;
            this.button_visualization.Click += new System.EventHandler(this.button_visualization_Click);
            // 
            // button_download
            // 
            this.button_download.Location = new System.Drawing.Point(266, 10);
            this.button_download.Name = "button_download";
            this.button_download.Size = new System.Drawing.Size(97, 20);
            this.button_download.TabIndex = 1;
            this.button_download.Text = "Download XML";
            this.button_download.UseVisualStyleBackColor = true;
            this.button_download.Click += new System.EventHandler(this.button_download_Click);
            // 
            // textBox_link
            // 
            this.textBox_link.Location = new System.Drawing.Point(105, 10);
            this.textBox_link.Name = "textBox_link";
            this.textBox_link.Size = new System.Drawing.Size(156, 20);
            this.textBox_link.TabIndex = 2;
            // 
            // treeView1
            // 
            this.treeView1.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.treeView1.Location = new System.Drawing.Point(10, 36);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(455, 316);
            this.treeView1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "URL on XML file:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 361);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.textBox_link);
            this.Controls.Add(this.button_download);
            this.Controls.Add(this.button_visualization);
            this.MinimumSize = new System.Drawing.Size(495, 400);
            this.Name = "MainForm";
            this.Text = "XML Tree Visualization";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label label1;

        #endregion

        private System.Windows.Forms.Button button_visualization;
        private System.Windows.Forms.Button button_download;
        private System.Windows.Forms.TextBox textBox_link;
        private System.Windows.Forms.TreeView treeView1;
    }
}

