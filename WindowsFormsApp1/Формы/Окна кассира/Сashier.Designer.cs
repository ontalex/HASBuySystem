namespace WindowsFormsApp1.Формы.Окна_кассира
{
        partial class Сashier
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
                        this.чекиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
                        this.товарыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
                        this.выйтиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
                        this.tableBox = new System.Windows.Forms.DataGridView();
                        this.btn_add = new System.Windows.Forms.Button();
                        this.btn_del = new System.Windows.Forms.Button();
                        this.btn_end = new System.Windows.Forms.Button();
                        this.label3 = new System.Windows.Forms.Label();
                        this.input_id_product = new System.Windows.Forms.TextBox();
                        this.label1 = new System.Windows.Forms.Label();
                        this.label2 = new System.Windows.Forms.Label();
                        this.counter_sessions = new System.Windows.Forms.Label();
                        this.counter_products = new System.Windows.Forms.Label();
                        this.label5 = new System.Windows.Forms.Label();
                        this.counter_cost = new System.Windows.Forms.Label();
                        this.label6 = new System.Windows.Forms.Label();
                        this.menuStrip1.SuspendLayout();
                        ((System.ComponentModel.ISupportInitialize)(this.tableBox)).BeginInit();
                        this.SuspendLayout();
                        // 
                        // menuStrip1
                        // 
                        this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
                        this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.чекиToolStripMenuItem,
            this.товарыToolStripMenuItem,
            this.выйтиToolStripMenuItem});
                        this.menuStrip1.Location = new System.Drawing.Point(0, 0);
                        this.menuStrip1.Name = "menuStrip1";
                        this.menuStrip1.Size = new System.Drawing.Size(1251, 28);
                        this.menuStrip1.TabIndex = 0;
                        this.menuStrip1.Text = "menuStrip1";
                        // 
                        // чекиToolStripMenuItem
                        // 
                        this.чекиToolStripMenuItem.Name = "чекиToolStripMenuItem";
                        this.чекиToolStripMenuItem.Size = new System.Drawing.Size(57, 24);
                        this.чекиToolStripMenuItem.Text = "Чеки";
                        this.чекиToolStripMenuItem.Click += new System.EventHandler(this.чекиToolStripMenuItem_Click);
                        // 
                        // товарыToolStripMenuItem
                        // 
                        this.товарыToolStripMenuItem.Name = "товарыToolStripMenuItem";
                        this.товарыToolStripMenuItem.Size = new System.Drawing.Size(76, 24);
                        this.товарыToolStripMenuItem.Text = "Товары";
                        this.товарыToolStripMenuItem.Click += new System.EventHandler(this.товарыToolStripMenuItem_Click);
                        // 
                        // выйтиToolStripMenuItem
                        // 
                        this.выйтиToolStripMenuItem.Name = "выйтиToolStripMenuItem";
                        this.выйтиToolStripMenuItem.Size = new System.Drawing.Size(67, 24);
                        this.выйтиToolStripMenuItem.Text = "Выйти";
                        this.выйтиToolStripMenuItem.Click += new System.EventHandler(this.выйтиToolStripMenuItem_Click);
                        // 
                        // tableBox
                        // 
                        this.tableBox.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
                        this.tableBox.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
                        this.tableBox.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
                        this.tableBox.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
                        this.tableBox.Location = new System.Drawing.Point(13, 43);
                        this.tableBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
                        this.tableBox.Name = "tableBox";
                        this.tableBox.RowHeadersWidth = 51;
                        this.tableBox.RowTemplate.Height = 24;
                        this.tableBox.Size = new System.Drawing.Size(802, 508);
                        this.tableBox.TabIndex = 10;
                        // 
                        // btn_add
                        // 
                        this.btn_add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(163)))), ((int)(((byte)(241)))));
                        this.btn_add.Font = new System.Drawing.Font("Arial", 12.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                        this.btn_add.Location = new System.Drawing.Point(841, 364);
                        this.btn_add.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
                        this.btn_add.Name = "btn_add";
                        this.btn_add.Size = new System.Drawing.Size(393, 58);
                        this.btn_add.TabIndex = 32;
                        this.btn_add.Text = "Добавить";
                        this.btn_add.UseVisualStyleBackColor = false;
                        this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
                        // 
                        // btn_del
                        // 
                        this.btn_del.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(163)))), ((int)(((byte)(241)))));
                        this.btn_del.Font = new System.Drawing.Font("Arial", 12.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                        this.btn_del.Location = new System.Drawing.Point(841, 432);
                        this.btn_del.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
                        this.btn_del.Name = "btn_del";
                        this.btn_del.Size = new System.Drawing.Size(393, 58);
                        this.btn_del.TabIndex = 33;
                        this.btn_del.Text = "Удалить";
                        this.btn_del.UseVisualStyleBackColor = false;
                        this.btn_del.Click += new System.EventHandler(this.btn_del_Click);
                        // 
                        // btn_end
                        // 
                        this.btn_end.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(163)))), ((int)(((byte)(241)))));
                        this.btn_end.Font = new System.Drawing.Font("Arial", 12.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                        this.btn_end.Location = new System.Drawing.Point(841, 500);
                        this.btn_end.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
                        this.btn_end.Name = "btn_end";
                        this.btn_end.Size = new System.Drawing.Size(393, 58);
                        this.btn_end.TabIndex = 34;
                        this.btn_end.Text = "Завершить";
                        this.btn_end.UseVisualStyleBackColor = false;
                        this.btn_end.Click += new System.EventHandler(this.btn_end_Click);
                        // 
                        // label3
                        // 
                        this.label3.AutoSize = true;
                        this.label3.Font = new System.Drawing.Font("Arial", 18.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                        this.label3.Location = new System.Drawing.Point(978, 43);
                        this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
                        this.label3.Name = "label3";
                        this.label3.Size = new System.Drawing.Size(109, 37);
                        this.label3.TabIndex = 35;
                        this.label3.Text = "Касса";
                        // 
                        // input_id_product
                        // 
                        this.input_id_product.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
                        this.input_id_product.Font = new System.Drawing.Font("Arial", 12.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                        this.input_id_product.Location = new System.Drawing.Point(841, 324);
                        this.input_id_product.Name = "input_id_product";
                        this.input_id_product.Size = new System.Drawing.Size(393, 32);
                        this.input_id_product.TabIndex = 36;
                        // 
                        // label1
                        // 
                        this.label1.AutoSize = true;
                        this.label1.Font = new System.Drawing.Font("Arial", 10.8F);
                        this.label1.Location = new System.Drawing.Point(837, 300);
                        this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
                        this.label1.Name = "label1";
                        this.label1.Size = new System.Drawing.Size(90, 21);
                        this.label1.TabIndex = 37;
                        this.label1.Text = "ID товара";
                        // 
                        // label2
                        // 
                        this.label2.AutoSize = true;
                        this.label2.Font = new System.Drawing.Font("Arial", 14.8F);
                        this.label2.Location = new System.Drawing.Point(13, 568);
                        this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
                        this.label2.Name = "label2";
                        this.label2.Size = new System.Drawing.Size(105, 28);
                        this.label2.TabIndex = 38;
                        this.label2.Text = "Сессия:";
                        // 
                        // counter_sessions
                        // 
                        this.counter_sessions.AutoSize = true;
                        this.counter_sessions.Font = new System.Drawing.Font("Arial", 14.8F);
                        this.counter_sessions.Location = new System.Drawing.Point(126, 568);
                        this.counter_sessions.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
                        this.counter_sessions.Name = "counter_sessions";
                        this.counter_sessions.Size = new System.Drawing.Size(26, 28);
                        this.counter_sessions.TabIndex = 39;
                        this.counter_sessions.Text = "0";
                        // 
                        // counter_products
                        // 
                        this.counter_products.AutoSize = true;
                        this.counter_products.Font = new System.Drawing.Font("Arial", 14.8F);
                        this.counter_products.Location = new System.Drawing.Point(962, 98);
                        this.counter_products.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
                        this.counter_products.Name = "counter_products";
                        this.counter_products.Size = new System.Drawing.Size(26, 28);
                        this.counter_products.TabIndex = 41;
                        this.counter_products.Text = "0";
                        // 
                        // label5
                        // 
                        this.label5.AutoSize = true;
                        this.label5.Font = new System.Drawing.Font("Arial", 14.8F);
                        this.label5.Location = new System.Drawing.Point(836, 98);
                        this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
                        this.label5.Name = "label5";
                        this.label5.Size = new System.Drawing.Size(118, 28);
                        this.label5.TabIndex = 40;
                        this.label5.Text = "Позиций:";
                        // 
                        // counter_cost
                        // 
                        this.counter_cost.AutoSize = true;
                        this.counter_cost.Font = new System.Drawing.Font("Arial", 14.8F);
                        this.counter_cost.Location = new System.Drawing.Point(962, 136);
                        this.counter_cost.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
                        this.counter_cost.Name = "counter_cost";
                        this.counter_cost.Size = new System.Drawing.Size(26, 28);
                        this.counter_cost.TabIndex = 43;
                        this.counter_cost.Text = "0";
                        // 
                        // label6
                        // 
                        this.label6.AutoSize = true;
                        this.label6.Font = new System.Drawing.Font("Arial", 14.8F);
                        this.label6.Location = new System.Drawing.Point(836, 136);
                        this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
                        this.label6.Name = "label6";
                        this.label6.Size = new System.Drawing.Size(97, 28);
                        this.label6.TabIndex = 42;
                        this.label6.Text = "Сумма:";
                        // 
                        // Сashier
                        // 
                        this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
                        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
                        this.BackColor = System.Drawing.Color.White;
                        this.ClientSize = new System.Drawing.Size(1251, 613);
                        this.Controls.Add(this.counter_cost);
                        this.Controls.Add(this.label6);
                        this.Controls.Add(this.counter_products);
                        this.Controls.Add(this.label5);
                        this.Controls.Add(this.counter_sessions);
                        this.Controls.Add(this.label2);
                        this.Controls.Add(this.label1);
                        this.Controls.Add(this.input_id_product);
                        this.Controls.Add(this.label3);
                        this.Controls.Add(this.btn_end);
                        this.Controls.Add(this.btn_del);
                        this.Controls.Add(this.btn_add);
                        this.Controls.Add(this.tableBox);
                        this.Controls.Add(this.menuStrip1);
                        this.MainMenuStrip = this.menuStrip1;
                        this.Name = "Сashier";
                        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
                        this.Text = "Сashier";
                        this.menuStrip1.ResumeLayout(false);
                        this.menuStrip1.PerformLayout();
                        ((System.ComponentModel.ISupportInitialize)(this.tableBox)).EndInit();
                        this.ResumeLayout(false);
                        this.PerformLayout();

                }

                #endregion

                private System.Windows.Forms.MenuStrip menuStrip1;
                private System.Windows.Forms.ToolStripMenuItem выйтиToolStripMenuItem;
                private System.Windows.Forms.ToolStripMenuItem чекиToolStripMenuItem;
                private System.Windows.Forms.ToolStripMenuItem товарыToolStripMenuItem;
                private System.Windows.Forms.DataGridView tableBox;
                private System.Windows.Forms.Button btn_add;
                private System.Windows.Forms.Button btn_del;
                private System.Windows.Forms.Button btn_end;
                private System.Windows.Forms.Label label3;
                private System.Windows.Forms.TextBox input_id_product;
                private System.Windows.Forms.Label label1;
                private System.Windows.Forms.Label label2;
                private System.Windows.Forms.Label counter_sessions;
                private System.Windows.Forms.Label counter_products;
                private System.Windows.Forms.Label label5;
                private System.Windows.Forms.Label counter_cost;
                private System.Windows.Forms.Label label6;
        }
}