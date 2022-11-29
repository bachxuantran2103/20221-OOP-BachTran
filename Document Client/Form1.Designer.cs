namespace Document_Client
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
            this.btLoadData = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.SelectPanel = new System.Windows.Forms.Panel();
            this.lbWhereSample = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.lbOrderBy = new System.Windows.Forms.Label();
            this.tbWhere = new System.Windows.Forms.TextBox();
            this.lbWhere = new System.Windows.Forms.Label();
            this.lbFrom = new System.Windows.Forms.Label();
            this.tbSelect = new System.Windows.Forms.TextBox();
            this.lbSelect = new System.Windows.Forms.Label();
            this.btUpdateData = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SelectPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // btLoadData
            // 
            this.btLoadData.Location = new System.Drawing.Point(30, 322);
            this.btLoadData.Name = "btLoadData";
            this.btLoadData.Size = new System.Drawing.Size(172, 43);
            this.btLoadData.TabIndex = 2;
            this.btLoadData.Text = "Load Data";
            this.btLoadData.Click += new System.EventHandler(this.btLoadData_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(439, 85);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(863, 524);
            this.dataGridView1.TabIndex = 1;
            // 
            // SelectPanel
            // 
            this.SelectPanel.AutoSize = true;
            this.SelectPanel.Controls.Add(this.lbWhereSample);
            this.SelectPanel.Controls.Add(this.listBox1);
            this.SelectPanel.Controls.Add(this.lbOrderBy);
            this.SelectPanel.Controls.Add(this.tbWhere);
            this.SelectPanel.Controls.Add(this.lbWhere);
            this.SelectPanel.Controls.Add(this.lbFrom);
            this.SelectPanel.Controls.Add(this.tbSelect);
            this.SelectPanel.Controls.Add(this.lbSelect);
            this.SelectPanel.Location = new System.Drawing.Point(30, 36);
            this.SelectPanel.Name = "SelectPanel";
            this.SelectPanel.Size = new System.Drawing.Size(373, 270);
            this.SelectPanel.TabIndex = 3;
            this.SelectPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lbWhereSample
            // 
            this.lbWhereSample.AutoSize = true;
            this.lbWhereSample.Location = new System.Drawing.Point(89, 130);
            this.lbWhereSample.Name = "lbWhereSample";
            this.lbWhereSample.Size = new System.Drawing.Size(175, 20);
            this.lbWhereSample.TabIndex = 8;
            this.lbWhereSample.Text = "TABLE_NAME = \'C_Order\'";
            this.lbWhereSample.Click += new System.EventHandler(this.label1_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(85, 181);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(266, 24);
            this.listBox1.TabIndex = 7;
            // 
            // lbOrderBy
            // 
            this.lbOrderBy.AutoSize = true;
            this.lbOrderBy.Location = new System.Drawing.Point(3, 181);
            this.lbOrderBy.Name = "lbOrderBy";
            this.lbOrderBy.Size = new System.Drawing.Size(67, 20);
            this.lbOrderBy.TabIndex = 6;
            this.lbOrderBy.Text = "Order by";
            // 
            // tbWhere
            // 
            this.tbWhere.Location = new System.Drawing.Point(85, 95);
            this.tbWhere.Name = "tbWhere";
            this.tbWhere.Size = new System.Drawing.Size(270, 27);
            this.tbWhere.TabIndex = 5;
            // 
            // lbWhere
            // 
            this.lbWhere.AutoSize = true;
            this.lbWhere.Location = new System.Drawing.Point(3, 95);
            this.lbWhere.Name = "lbWhere";
            this.lbWhere.Size = new System.Drawing.Size(52, 20);
            this.lbWhere.TabIndex = 3;
            this.lbWhere.Text = "Where";
            // 
            // lbFrom
            // 
            this.lbFrom.AutoSize = true;
            this.lbFrom.Location = new System.Drawing.Point(3, 58);
            this.lbFrom.Name = "lbFrom";
            this.lbFrom.Size = new System.Drawing.Size(43, 20);
            this.lbFrom.TabIndex = 2;
            this.lbFrom.Text = "From";
            // 
            // tbSelect
            // 
            this.tbSelect.Location = new System.Drawing.Point(85, 13);
            this.tbSelect.Name = "tbSelect";
            this.tbSelect.Size = new System.Drawing.Size(270, 27);
            this.tbSelect.TabIndex = 1;
            // 
            // lbSelect
            // 
            this.lbSelect.AutoSize = true;
            this.lbSelect.Location = new System.Drawing.Point(3, 16);
            this.lbSelect.Name = "lbSelect";
            this.lbSelect.Size = new System.Drawing.Size(49, 20);
            this.lbSelect.TabIndex = 0;
            this.lbSelect.Text = "Select";
            // 
            // btUpdateData
            // 
            this.btUpdateData.Location = new System.Drawing.Point(30, 384);
            this.btUpdateData.Name = "btUpdateData";
            this.btUpdateData.Size = new System.Drawing.Size(172, 49);
            this.btUpdateData.TabIndex = 4;
            this.btUpdateData.Text = "Update Data";
            this.btUpdateData.UseVisualStyleBackColor = true;
            this.btUpdateData.Click += new System.EventHandler(this.btUpdateData_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1334, 639);
            this.Controls.Add(this.btUpdateData);
            this.Controls.Add(this.SelectPanel);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btLoadData);
            this.Name = "Form1";
            this.Text = "Document Client";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.SelectPanel.ResumeLayout(false);
            this.SelectPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btLoadData;
        private DataGridView dataGridView1;
        private Panel SelectPanel;
        private Label SelectText;
        private Label lbWhere;
        private Label lbFrom;
        private TextBox tbSelect;
        private Label lbSelect;
        private ListBox listBox1;
        private Label lbOrderBy;
        private TextBox tbWhere;
        private Label lbWhereSample;
        private Button btUpdateData;
    }
}