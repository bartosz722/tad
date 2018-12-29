namespace RTadeusiewicz.NN.Example03
{
    partial class TeachingPanel
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TeachingPanel));
            this.label1 = new System.Windows.Forms.Label();
            this.uiStepNumber = new System.Windows.Forms.Label();
            this.uiComment = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.uiOutputBefore = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.uiCorrectBefore = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.uiErrorBefore = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.uiDataBefore = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.uiOutputAfter = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.uiCorrectAfter = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.uiErrorAfter = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.uiDataAfter = new System.Windows.Forms.DataGridView();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.uiTeachMore = new System.Windows.Forms.Button();
            this.uiReset = new System.Windows.Forms.Button();
            this.uiShowHistory = new System.Windows.Forms.Button();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.uiTeachingRatio = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.explanationToolTip1 = new RTadeusiewicz.NN.Controls.ExplanationToolTip();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uiDataBefore)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uiDataAfter)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uiTeachingRatio)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(4, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Teaching";
            // 
            // uiStepNumber
            // 
            this.uiStepNumber.AutoSize = true;
            this.uiStepNumber.Location = new System.Drawing.Point(18, 28);
            this.uiStepNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.uiStepNumber.Name = "uiStepNumber";
            this.uiStepNumber.Size = new System.Drawing.Size(42, 18);
            this.uiStepNumber.TabIndex = 1;
            this.uiStepNumber.Text = "Step:";
            // 
            // uiComment
            // 
            this.uiComment.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uiComment.AutoEllipsis = true;
            this.uiComment.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.uiComment.Location = new System.Drawing.Point(112, 28);
            this.uiComment.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.uiComment.Name = "uiComment";
            this.uiComment.Size = new System.Drawing.Size(670, 18);
            this.uiComment.TabIndex = 2;
            this.uiComment.Text = "Comment:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel2);
            this.groupBox1.Controls.Add(this.uiDataBefore);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(4, 4);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel1.SetRowSpan(this.groupBox1, 2);
            this.groupBox1.Size = new System.Drawing.Size(784, 217);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Before teaching";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.AutoSize = true;
            this.tableLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel2.ColumnCount = 6;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Controls.Add(this.uiOutputBefore, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label3, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.uiCorrectBefore, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.label4, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.uiErrorBefore, 5, 0);
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(9, 177);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(758, 32);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // uiOutputBefore
            // 
            this.uiOutputBefore.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uiOutputBefore.BackColor = System.Drawing.SystemColors.Control;
            this.uiOutputBefore.ForeColor = System.Drawing.SystemColors.ControlText;
            this.uiOutputBefore.Location = new System.Drawing.Point(68, 4);
            this.uiOutputBefore.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.uiOutputBefore.Name = "uiOutputBefore";
            this.uiOutputBefore.ReadOnly = true;
            this.uiOutputBefore.Size = new System.Drawing.Size(167, 24);
            this.uiOutputBefore.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Green;
            this.label3.Location = new System.Drawing.Point(243, 8);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 8, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Correct output:";
            // 
            // uiCorrectBefore
            // 
            this.uiCorrectBefore.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uiCorrectBefore.BackColor = System.Drawing.SystemColors.Control;
            this.uiCorrectBefore.ForeColor = System.Drawing.Color.Green;
            this.uiCorrectBefore.Location = new System.Drawing.Point(358, 4);
            this.uiCorrectBefore.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.uiCorrectBefore.Name = "uiCorrectBefore";
            this.uiCorrectBefore.ReadOnly = true;
            this.uiCorrectBefore.Size = new System.Drawing.Size(167, 24);
            this.uiCorrectBefore.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(533, 8);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 8, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 18);
            this.label4.TabIndex = 4;
            this.label4.Text = "Error:";
            // 
            // uiErrorBefore
            // 
            this.uiErrorBefore.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uiErrorBefore.BackColor = System.Drawing.SystemColors.Control;
            this.uiErrorBefore.ForeColor = System.Drawing.Color.Red;
            this.uiErrorBefore.Location = new System.Drawing.Point(587, 4);
            this.uiErrorBefore.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.uiErrorBefore.Name = "uiErrorBefore";
            this.uiErrorBefore.ReadOnly = true;
            this.uiErrorBefore.Size = new System.Drawing.Size(167, 24);
            this.uiErrorBefore.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 8);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 8, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Output:";
            // 
            // uiDataBefore
            // 
            this.uiDataBefore.AllowUserToAddRows = false;
            this.uiDataBefore.AllowUserToDeleteRows = false;
            this.uiDataBefore.AllowUserToResizeRows = false;
            this.uiDataBefore.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uiDataBefore.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.uiDataBefore.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.uiDataBefore.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.uiDataBefore.ColumnHeadersVisible = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.uiDataBefore.DefaultCellStyle = dataGridViewCellStyle1;
            this.uiDataBefore.Location = new System.Drawing.Point(9, 26);
            this.uiDataBefore.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.uiDataBefore.MultiSelect = false;
            this.uiDataBefore.Name = "uiDataBefore";
            this.uiDataBefore.ReadOnly = true;
            this.uiDataBefore.RowHeadersVisible = false;
            this.uiDataBefore.Size = new System.Drawing.Size(766, 138);
            this.uiDataBefore.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(4, 49);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 61F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.00001F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(792, 439);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tableLayoutPanel3);
            this.groupBox2.Controls.Add(this.uiDataAfter);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(4, 229);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(784, 156);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "After teaching";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.AutoSize = true;
            this.tableLayoutPanel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel3.ColumnCount = 6;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.Controls.Add(this.uiOutputAfter, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.label5, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.uiCorrectAfter, 3, 0);
            this.tableLayoutPanel3.Controls.Add(this.label6, 4, 0);
            this.tableLayoutPanel3.Controls.Add(this.uiErrorAfter, 5, 0);
            this.tableLayoutPanel3.Controls.Add(this.label7, 0, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(9, 115);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(761, 32);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // uiOutputAfter
            // 
            this.uiOutputAfter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uiOutputAfter.BackColor = System.Drawing.SystemColors.Control;
            this.uiOutputAfter.ForeColor = System.Drawing.SystemColors.ControlText;
            this.uiOutputAfter.Location = new System.Drawing.Point(68, 4);
            this.uiOutputAfter.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.uiOutputAfter.Name = "uiOutputAfter";
            this.uiOutputAfter.ReadOnly = true;
            this.uiOutputAfter.Size = new System.Drawing.Size(168, 24);
            this.uiOutputAfter.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Green;
            this.label5.Location = new System.Drawing.Point(244, 8);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 8, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 18);
            this.label5.TabIndex = 2;
            this.label5.Text = "Correct output:";
            // 
            // uiCorrectAfter
            // 
            this.uiCorrectAfter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uiCorrectAfter.BackColor = System.Drawing.SystemColors.Control;
            this.uiCorrectAfter.ForeColor = System.Drawing.Color.Green;
            this.uiCorrectAfter.Location = new System.Drawing.Point(359, 4);
            this.uiCorrectAfter.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.uiCorrectAfter.Name = "uiCorrectAfter";
            this.uiCorrectAfter.ReadOnly = true;
            this.uiCorrectAfter.Size = new System.Drawing.Size(168, 24);
            this.uiCorrectAfter.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(535, 8);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 8, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 18);
            this.label6.TabIndex = 4;
            this.label6.Text = "Error:";
            // 
            // uiErrorAfter
            // 
            this.uiErrorAfter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uiErrorAfter.BackColor = System.Drawing.SystemColors.Control;
            this.uiErrorAfter.ForeColor = System.Drawing.Color.Red;
            this.uiErrorAfter.Location = new System.Drawing.Point(589, 4);
            this.uiErrorAfter.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.uiErrorAfter.Name = "uiErrorAfter";
            this.uiErrorAfter.ReadOnly = true;
            this.uiErrorAfter.Size = new System.Drawing.Size(168, 24);
            this.uiErrorAfter.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 8);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 8, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 18);
            this.label7.TabIndex = 0;
            this.label7.Text = "Output:";
            // 
            // uiDataAfter
            // 
            this.uiDataAfter.AllowUserToAddRows = false;
            this.uiDataAfter.AllowUserToDeleteRows = false;
            this.uiDataAfter.AllowUserToResizeRows = false;
            this.uiDataAfter.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uiDataAfter.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.uiDataAfter.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.uiDataAfter.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.uiDataAfter.ColumnHeadersVisible = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.uiDataAfter.DefaultCellStyle = dataGridViewCellStyle2;
            this.uiDataAfter.Location = new System.Drawing.Point(9, 26);
            this.uiDataAfter.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.uiDataAfter.MultiSelect = false;
            this.uiDataAfter.Name = "uiDataAfter";
            this.uiDataAfter.ReadOnly = true;
            this.uiDataAfter.RowHeadersVisible = false;
            this.uiDataAfter.Size = new System.Drawing.Size(766, 76);
            this.uiDataAfter.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel1.Controls.Add(this.uiTeachMore);
            this.flowLayoutPanel1.Controls.Add(this.uiReset);
            this.flowLayoutPanel1.Controls.Add(this.uiShowHistory);
            this.flowLayoutPanel1.Controls.Add(this.tableLayoutPanel4);
            this.flowLayoutPanel1.Controls.Add(this.explanationToolTip1);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(189, 390);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 0, 9, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(594, 49);
            this.flowLayoutPanel1.TabIndex = 5;
            // 
            // uiTeachMore
            // 
            this.uiTeachMore.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uiTeachMore.AutoSize = true;
            this.uiTeachMore.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.uiTeachMore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.uiTeachMore.Location = new System.Drawing.Point(472, 4);
            this.uiTeachMore.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.uiTeachMore.Name = "uiTeachMore";
            this.uiTeachMore.Size = new System.Drawing.Size(118, 41);
            this.uiTeachMore.TabIndex = 5;
            this.uiTeachMore.Text = "Teach more!";
            this.uiTeachMore.UseVisualStyleBackColor = true;
            this.uiTeachMore.Click += new System.EventHandler(this.uiTeachMore_Click);
            // 
            // uiReset
            // 
            this.uiReset.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uiReset.AutoSize = true;
            this.uiReset.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.uiReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.uiReset.Location = new System.Drawing.Point(349, 4);
            this.uiReset.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.uiReset.Name = "uiReset";
            this.uiReset.Size = new System.Drawing.Size(115, 41);
            this.uiReset.TabIndex = 1;
            this.uiReset.Text = "Restart teaching";
            this.uiReset.UseVisualStyleBackColor = true;
            this.uiReset.Click += new System.EventHandler(this.uiReset_Click);
            // 
            // uiShowHistory
            // 
            this.uiShowHistory.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uiShowHistory.AutoSize = true;
            this.uiShowHistory.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.uiShowHistory.Location = new System.Drawing.Point(276, 4);
            this.uiShowHistory.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.uiShowHistory.Name = "uiShowHistory";
            this.uiShowHistory.Size = new System.Drawing.Size(65, 41);
            this.uiShowHistory.TabIndex = 9;
            this.uiShowHistory.Text = "History";
            this.uiShowHistory.UseVisualStyleBackColor = true;
            this.uiShowHistory.Click += new System.EventHandler(this.uiShowHistory_Click);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel4.AutoSize = true;
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel4.Controls.Add(this.uiTeachingRatio, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.label8, 0, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(46, 4);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(4, 4, 45, 4);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(181, 41);
            this.tableLayoutPanel4.TabIndex = 5;
            // 
            // uiTeachingRatio
            // 
            this.uiTeachingRatio.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.uiTeachingRatio.AutoSize = true;
            this.uiTeachingRatio.DecimalPlaces = 3;
            this.uiTeachingRatio.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.uiTeachingRatio.Location = new System.Drawing.Point(117, 8);
            this.uiTeachingRatio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.uiTeachingRatio.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.uiTeachingRatio.Name = "uiTeachingRatio";
            this.uiTeachingRatio.Size = new System.Drawing.Size(60, 24);
            this.uiTeachingRatio.TabIndex = 6;
            this.uiTeachingRatio.Value = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(4, 10);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 3);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 18);
            this.label8.TabIndex = 7;
            this.label8.Text = "Teaching ratio:";
            // 
            // explanationToolTip1
            // 
            this.explanationToolTip1.Location = new System.Drawing.Point(4, 4);
            this.explanationToolTip1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.explanationToolTip1.Name = "explanationToolTip1";
            this.explanationToolTip1.Size = new System.Drawing.Size(34, 41);
            this.explanationToolTip1.TabIndex = 8;
            this.explanationToolTip1.ToolTipText = resources.GetString("explanationToolTip1.ToolTipText");
            // 
            // TeachingPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.uiComment);
            this.Controls.Add(this.uiStepNumber);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "TeachingPanel";
            this.Size = new System.Drawing.Size(801, 493);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uiDataBefore)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uiDataAfter)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uiTeachingRatio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label uiStepNumber;
        private System.Windows.Forms.Label uiComment;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView uiDataBefore;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox uiOutputBefore;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox uiCorrectBefore;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox uiErrorBefore;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TextBox uiOutputAfter;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox uiCorrectAfter;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox uiErrorAfter;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView uiDataAfter;
        private System.Windows.Forms.Button uiTeachMore;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button uiReset;
        private System.Windows.Forms.NumericUpDown uiTeachingRatio;
        private System.Windows.Forms.Label label8;
        private RTadeusiewicz.NN.Controls.ExplanationToolTip explanationToolTip1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Button uiShowHistory;
    }
}
