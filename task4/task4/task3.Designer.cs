namespace task4
{
    partial class task3
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtID = new TextBox();
            txtName = new TextBox();
            txtDesc = new TextBox();
            txtPrice = new TextBox();
            txtQty = new TextBox();
            btnSave = new Button();
            button1 = new Button();
            btnCancel = new Button();
            groupBox1 = new GroupBox();
            dgvProd = new DataGridView();
            Search = new Label();
            textBox1 = new TextBox();
            label6 = new Label();
            txtAdd = new TextBox();
            btnAdd = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProd).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(36, 32);
            label1.Name = "label1";
            label1.Size = new Size(63, 15);
            label1.TabIndex = 0;
            label1.Text = "Product ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(36, 66);
            label2.Name = "label2";
            label2.Size = new Size(67, 15);
            label2.TabIndex = 1;
            label2.Text = "Description";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(36, 106);
            label3.Name = "label3";
            label3.Size = new Size(33, 15);
            label3.TabIndex = 2;
            label3.Text = "Price";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(186, 32);
            label4.Name = "label4";
            label4.Size = new Size(39, 15);
            label4.TabIndex = 3;
            label4.Text = "Name";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(311, 109);
            label5.Name = "label5";
            label5.Size = new Size(53, 15);
            label5.TabIndex = 4;
            label5.Text = "Quantity";
            // 
            // txtID
            // 
            txtID.Location = new Point(100, 29);
            txtID.Name = "txtID";
            txtID.Size = new Size(80, 23);
            txtID.TabIndex = 5;
            // 
            // txtName
            // 
            txtName.Location = new Point(248, 29);
            txtName.Name = "txtName";
            txtName.Size = new Size(320, 23);
            txtName.TabIndex = 6;
            // 
            // txtDesc
            // 
            txtDesc.Location = new Point(100, 63);
            txtDesc.Name = "txtDesc";
            txtDesc.Size = new Size(468, 23);
            txtDesc.TabIndex = 7;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(100, 106);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(205, 23);
            txtPrice.TabIndex = 8;
            // 
            // txtQty
            // 
            txtQty.Location = new Point(363, 106);
            txtQty.Name = "txtQty";
            txtQty.Size = new Size(205, 23);
            txtQty.TabIndex = 9;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(24, 8);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(97, 27);
            btnSave.TabIndex = 10;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // button1
            // 
            button1.Location = new Point(24, 48);
            button1.Name = "button1";
            button1.Size = new Size(97, 27);
            button1.TabIndex = 11;
            button1.Text = "Archive";
            button1.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(24, 91);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(97, 27);
            btnCancel.TabIndex = 12;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnCancel);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(btnSave);
            groupBox1.Location = new Point(623, 18);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(142, 133);
            groupBox1.TabIndex = 13;
            groupBox1.TabStop = false;
            // 
            // dgvProd
            // 
            dgvProd.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProd.Location = new Point(12, 196);
            dgvProd.Name = "dgvProd";
            dgvProd.Size = new Size(776, 242);
            dgvProd.TabIndex = 14;
            // 
            // Search
            // 
            Search.AutoSize = true;
            Search.Location = new Point(267, 153);
            Search.Name = "Search";
            Search.Size = new Size(42, 15);
            Search.TabIndex = 15;
            Search.Text = "Search";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(315, 150);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(205, 23);
            textBox1.TabIndex = 16;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(581, 153);
            label6.Name = "label6";
            label6.Size = new Size(36, 15);
            label6.TabIndex = 17;
            label6.Text = "Stock";
            // 
            // txtAdd
            // 
            txtAdd.Location = new Point(629, 150);
            txtAdd.Name = "txtAdd";
            txtAdd.Size = new Size(72, 23);
            txtAdd.TabIndex = 18;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(707, 147);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(81, 27);
            btnAdd.TabIndex = 13;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // task3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnAdd);
            Controls.Add(txtAdd);
            Controls.Add(label6);
            Controls.Add(textBox1);
            Controls.Add(Search);
            Controls.Add(dgvProd);
            Controls.Add(groupBox1);
            Controls.Add(txtQty);
            Controls.Add(txtPrice);
            Controls.Add(txtDesc);
            Controls.Add(txtName);
            Controls.Add(txtID);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "task3";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "task3";
            Load += task3_Load;
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvProd).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtID;
        private TextBox txtName;
        private TextBox txtDesc;
        private TextBox txtPrice;
        private TextBox txtQty;
        private Button btnSave;
        private Button button1;
        private Button btnCancel;
        private GroupBox groupBox1;
        private DataGridView dgvProd;
        private Label Search;
        private TextBox textBox1;
        private Label label6;
        private TextBox txtAdd;
        private Button btnAdd;
    }
}