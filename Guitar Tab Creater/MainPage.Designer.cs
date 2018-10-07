namespace Guitar_Tab_Creater
{
    partial class MainPage
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnNewTab = new System.Windows.Forms.Button();
            this.btnNewChord = new System.Windows.Forms.Button();
            this.btnSaved = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tableLayoutPanel1.Controls.Add(this.btnNewTab, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnNewChord, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnSaved, 0, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(133, 67);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(381, 288);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btnNewTab
            // 
            this.btnNewTab.Location = new System.Drawing.Point(3, 3);
            this.btnNewTab.Name = "btnNewTab";
            this.btnNewTab.Size = new System.Drawing.Size(375, 90);
            this.btnNewTab.TabIndex = 0;
            this.btnNewTab.Text = "Create New Tab";
            this.btnNewTab.UseVisualStyleBackColor = true;
            this.btnNewTab.Click += new System.EventHandler(this.btnNewTab_Click);
            // 
            // btnNewChord
            // 
            this.btnNewChord.Location = new System.Drawing.Point(3, 99);
            this.btnNewChord.Name = "btnNewChord";
            this.btnNewChord.Size = new System.Drawing.Size(375, 90);
            this.btnNewChord.TabIndex = 1;
            this.btnNewChord.Text = "Create New Chord";
            this.btnNewChord.UseVisualStyleBackColor = true;
            this.btnNewChord.Click += new System.EventHandler(this.btnNewChord_Click);
            // 
            // btnSaved
            // 
            this.btnSaved.Location = new System.Drawing.Point(3, 195);
            this.btnSaved.Name = "btnSaved";
            this.btnSaved.Size = new System.Drawing.Size(375, 90);
            this.btnSaved.TabIndex = 2;
            this.btnSaved.Text = "View Saved";
            this.btnSaved.UseVisualStyleBackColor = true;
            this.btnSaved.Click += new System.EventHandler(this.btnSaved_Click);
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 463);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainPage";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnNewTab;
        private System.Windows.Forms.Button btnNewChord;
        private System.Windows.Forms.Button btnSaved;
    }
}

