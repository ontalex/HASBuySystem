namespace WindowsFormsApp1.Формы.Окна_кассира
{
    partial class ProductsCashir
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
                        this.menuStrip1 = new System.Windows.Forms.MenuStrip();
                        this.кассаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
                        this.чекиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
                        this.tableBox = new System.Windows.Forms.DataGridView();
                        this.label3 = new System.Windows.Forms.Label();
                        this.search_input = new System.Windows.Forms.TextBox();
                        this.menuStrip1.SuspendLayout();
                        ((System.ComponentModel.ISupportInitialize)(this.tableBox)).BeginInit();
                        this.SuspendLayout();
                        // 
                        // menuStrip1
                        // 
                        this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
                        this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.кассаToolStripMenuItem,
            this.чекиToolStripMenuItem});
                        this.menuStrip1.Location = new System.Drawing.Point(0, 0);
                        this.menuStrip1.Name = "menuStrip1";
                        this.menuStrip1.Size = new System.Drawing.Size(1262, 28);
                        this.menuStrip1.TabIndex = 0;
                        this.menuStrip1.Text = "menuStrip1";
                        // 
                        // кассаToolStripMenuItem
                        // 
                        this.кассаToolStripMenuItem.Name = "кассаToolStripMenuItem";
                        this.кассаToolStripMenuItem.Size = new System.Drawing.Size(60, 26);
                        this.кассаToolStripMenuItem.Text = "касса";
                        this.кассаToolStripMenuItem.Click += new System.EventHandler(this.кассаToolStripMenuItem_Click);
                        // 
                        // чекиToolStripMenuItem
                        // 
                        this.чекиToolStripMenuItem.Name = "чекиToolStripMenuItem";
                        this.чекиToolStripMenuItem.Size = new System.Drawing.Size(57, 26);
                        this.чекиToolStripMenuItem.Text = "Чеки";
                        this.чекиToolStripMenuItem.Click += new System.EventHandler(this.чекиToolStripMenuItem_Click);
                        // 
                        // tableBox
                        // 
                        this.tableBox.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
                        this.tableBox.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
                        this.tableBox.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
                        this.tableBox.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
                        this.tableBox.Location = new System.Drawing.Point(13, 123);
                        this.tableBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
                        this.tableBox.Name = "tableBox";
                        this.tableBox.RowHeadersWidth = 51;
                        this.tableBox.RowTemplate.Height = 24;
                        this.tableBox.Size = new System.Drawing.Size(1236, 536);
                        this.tableBox.TabIndex = 11;
                        // 
                        // label3
                        // 
                        this.label3.AutoSize = true;
                        this.label3.Font = new System.Drawing.Font("Arial", 18.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                        this.label3.Location = new System.Drawing.Point(13, 56);
                        this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
                        this.label3.Name = "label3";
                        this.label3.Size = new System.Drawing.Size(157, 36);
                        this.label3.TabIndex = 14;
                        this.label3.Text = "Продукты";
                        // 
                        // search_input
                        // 
                        this.search_input.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
                        this.search_input.Font = new System.Drawing.Font("Arial", 14.8F);
                        this.search_input.Location = new System.Drawing.Point(177, 58);
                        this.search_input.Name = "search_input";
                        this.search_input.Size = new System.Drawing.Size(1072, 36);
                        this.search_input.TabIndex = 19;
                        // 
                        // ProductsCashir
                        // 
                        this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
                        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
                        this.BackColor = System.Drawing.Color.White;
                        this.ClientSize = new System.Drawing.Size(1262, 673);
                        this.Controls.Add(this.search_input);
                        this.Controls.Add(this.label3);
                        this.Controls.Add(this.tableBox);
                        this.Controls.Add(this.menuStrip1);
                        this.MainMenuStrip = this.menuStrip1;
                        this.Name = "ProductsCashir";
                        this.Text = "ProductsCashir";
                        this.menuStrip1.ResumeLayout(false);
                        this.menuStrip1.PerformLayout();
                        ((System.ComponentModel.ISupportInitialize)(this.tableBox)).EndInit();
                        this.ResumeLayout(false);
                        this.PerformLayout();

        }

                #endregion

                private System.Windows.Forms.MenuStrip menuStrip1;
                private System.Windows.Forms.ToolStripMenuItem кассаToolStripMenuItem;
                private System.Windows.Forms.ToolStripMenuItem чекиToolStripMenuItem;
                private System.Windows.Forms.DataGridView tableBox;
                private System.Windows.Forms.Label label3;
                private System.Windows.Forms.TextBox search_input;
        }
}