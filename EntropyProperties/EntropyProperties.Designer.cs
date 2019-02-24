namespace EntropyProperties
{
    partial class EntropyProperties
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
            this.dgvMatrix = new System.Windows.Forms.DataGridView();
            this.btnMutualProb = new System.Windows.Forms.Button();
            this.btnCondProbAB = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCondProbBA = new System.Windows.Forms.Button();
            this.dgvProbPrimary = new System.Windows.Forms.DataGridView();
            this.dgvProbSecondary = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvEntropy = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridViewTextBoxColumn21 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn22 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn23 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn24 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn25 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn20 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatrix)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProbPrimary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProbSecondary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntropy)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMatrix
            // 
            this.dgvMatrix.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMatrix.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cl1,
            this.cl2,
            this.cl3,
            this.cl4,
            this.cl5,
            this.cl6,
            this.cl7,
            this.cl8,
            this.cl9,
            this.cl10});
            this.dgvMatrix.Location = new System.Drawing.Point(12, 28);
            this.dgvMatrix.Name = "dgvMatrix";
            this.dgvMatrix.Size = new System.Drawing.Size(684, 245);
            this.dgvMatrix.TabIndex = 0;
            // 
            // btnMutualProb
            // 
            this.btnMutualProb.Location = new System.Drawing.Point(292, 290);
            this.btnMutualProb.Name = "btnMutualProb";
            this.btnMutualProb.Size = new System.Drawing.Size(126, 81);
            this.btnMutualProb.TabIndex = 1;
            this.btnMutualProb.Text = "Вероятности совместного появления";
            this.btnMutualProb.UseVisualStyleBackColor = true;
            this.btnMutualProb.Click += new System.EventHandler(this.btnMutualProb_Click);
            // 
            // btnCondProbAB
            // 
            this.btnCondProbAB.Location = new System.Drawing.Point(12, 290);
            this.btnCondProbAB.Name = "btnCondProbAB";
            this.btnCondProbAB.Size = new System.Drawing.Size(126, 81);
            this.btnCondProbAB.TabIndex = 1;
            this.btnCondProbAB.Text = "Условные вероятности появления символов первичного и вторичного алфавита";
            this.btnCondProbAB.UseVisualStyleBackColor = true;
            this.btnCondProbAB.Click += new System.EventHandler(this.btnCondProbAB_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 388);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Вероятности символов первичного алфавита";
            // 
            // btnCondProbBA
            // 
            this.btnCondProbBA.Location = new System.Drawing.Point(570, 290);
            this.btnCondProbBA.Name = "btnCondProbBA";
            this.btnCondProbBA.Size = new System.Drawing.Size(126, 81);
            this.btnCondProbBA.TabIndex = 1;
            this.btnCondProbBA.Text = "Условные вероятности появления символов вторичного и первичного алфавита";
            this.btnCondProbBA.UseVisualStyleBackColor = true;
            this.btnCondProbBA.Click += new System.EventHandler(this.btnCondProbBA_Click);
            // 
            // dgvProbPrimary
            // 
            this.dgvProbPrimary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProbPrimary.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10});
            this.dgvProbPrimary.Location = new System.Drawing.Point(12, 404);
            this.dgvProbPrimary.Name = "dgvProbPrimary";
            this.dgvProbPrimary.Size = new System.Drawing.Size(684, 49);
            this.dgvProbPrimary.TabIndex = 0;
            // 
            // dgvProbSecondary
            // 
            this.dgvProbSecondary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProbSecondary.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewTextBoxColumn15,
            this.dataGridViewTextBoxColumn16,
            this.dataGridViewTextBoxColumn17,
            this.dataGridViewTextBoxColumn18,
            this.dataGridViewTextBoxColumn19,
            this.dataGridViewTextBoxColumn20});
            this.dgvProbSecondary.Location = new System.Drawing.Point(12, 486);
            this.dgvProbSecondary.Name = "dgvProbSecondary";
            this.dgvProbSecondary.Size = new System.Drawing.Size(684, 47);
            this.dgvProbSecondary.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 470);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(237, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Вероятности символов вторичного алфавита";
            // 
            // dgvEntropy
            // 
            this.dgvEntropy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEntropy.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn21,
            this.dataGridViewTextBoxColumn22,
            this.dataGridViewTextBoxColumn23,
            this.dataGridViewTextBoxColumn24,
            this.dataGridViewTextBoxColumn25});
            this.dgvEntropy.Location = new System.Drawing.Point(209, 557);
            this.dgvEntropy.Name = "dgvEntropy";
            this.dgvEntropy.Size = new System.Drawing.Size(293, 46);
            this.dgvEntropy.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(210, 541);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Энтропия";
            // 
            // dataGridViewTextBoxColumn21
            // 
            this.dataGridViewTextBoxColumn21.HeaderText = "H(A,B)";
            this.dataGridViewTextBoxColumn21.Name = "dataGridViewTextBoxColumn21";
            this.dataGridViewTextBoxColumn21.Width = 50;
            // 
            // dataGridViewTextBoxColumn22
            // 
            this.dataGridViewTextBoxColumn22.HeaderText = "H(A/B)";
            this.dataGridViewTextBoxColumn22.Name = "dataGridViewTextBoxColumn22";
            this.dataGridViewTextBoxColumn22.Width = 50;
            // 
            // dataGridViewTextBoxColumn23
            // 
            this.dataGridViewTextBoxColumn23.HeaderText = "H(B/A)";
            this.dataGridViewTextBoxColumn23.Name = "dataGridViewTextBoxColumn23";
            this.dataGridViewTextBoxColumn23.Width = 50;
            // 
            // dataGridViewTextBoxColumn24
            // 
            this.dataGridViewTextBoxColumn24.HeaderText = "H(A)";
            this.dataGridViewTextBoxColumn24.Name = "dataGridViewTextBoxColumn24";
            this.dataGridViewTextBoxColumn24.Width = 50;
            // 
            // dataGridViewTextBoxColumn25
            // 
            this.dataGridViewTextBoxColumn25.HeaderText = "H(B)";
            this.dataGridViewTextBoxColumn25.Name = "dataGridViewTextBoxColumn25";
            this.dataGridViewTextBoxColumn25.Width = 50;
            // 
            // cl1
            // 
            this.cl1.HeaderText = "p(a1,b1)";
            this.cl1.MinimumWidth = 20;
            this.cl1.Name = "cl1";
            this.cl1.Width = 60;
            // 
            // cl2
            // 
            this.cl2.HeaderText = "p(a1,b2)";
            this.cl2.Name = "cl2";
            this.cl2.Width = 60;
            // 
            // cl3
            // 
            this.cl3.HeaderText = "p(a1,b3)";
            this.cl3.Name = "cl3";
            this.cl3.Width = 60;
            // 
            // cl4
            // 
            this.cl4.HeaderText = "p(a1,b4)";
            this.cl4.Name = "cl4";
            this.cl4.Width = 60;
            // 
            // cl5
            // 
            this.cl5.HeaderText = "p(a1,b5)";
            this.cl5.Name = "cl5";
            this.cl5.Width = 60;
            // 
            // cl6
            // 
            this.cl6.HeaderText = "p(a1,b6)";
            this.cl6.Name = "cl6";
            this.cl6.Width = 60;
            // 
            // cl7
            // 
            this.cl7.HeaderText = "p(a1,b7)";
            this.cl7.Name = "cl7";
            this.cl7.Width = 60;
            // 
            // cl8
            // 
            this.cl8.HeaderText = "p(a1,b8)";
            this.cl8.Name = "cl8";
            this.cl8.Width = 60;
            // 
            // cl9
            // 
            this.cl9.HeaderText = "p(a1,b9)";
            this.cl9.Name = "cl9";
            this.cl9.Width = 60;
            // 
            // cl10
            // 
            this.cl10.HeaderText = "p(a1,b10)";
            this.cl10.Name = "cl10";
            this.cl10.Width = 60;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "p(a1)";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 60;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "p(a2)";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 60;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "p(a3)";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 60;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "p(a4)";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 60;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "p(a5)";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 60;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "p(a6)";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 60;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.HeaderText = "p(a7)";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 60;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.HeaderText = "p(a8)";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 60;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.HeaderText = "p(a9)";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.Width = 60;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.HeaderText = "p(a10)";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.Width = 60;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.HeaderText = "p(b1)";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.Width = 60;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.HeaderText = "p(b2)";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.Width = 60;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.HeaderText = "p(b3)";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.Width = 60;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.HeaderText = "p(b4)";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.Width = 60;
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.HeaderText = "p(b5)";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            this.dataGridViewTextBoxColumn15.Width = 60;
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.HeaderText = "p(b6)";
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            this.dataGridViewTextBoxColumn16.Width = 60;
            // 
            // dataGridViewTextBoxColumn17
            // 
            this.dataGridViewTextBoxColumn17.HeaderText = "p(b7)";
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            this.dataGridViewTextBoxColumn17.Width = 60;
            // 
            // dataGridViewTextBoxColumn18
            // 
            this.dataGridViewTextBoxColumn18.HeaderText = "p(b8)";
            this.dataGridViewTextBoxColumn18.Name = "dataGridViewTextBoxColumn18";
            this.dataGridViewTextBoxColumn18.Width = 60;
            // 
            // dataGridViewTextBoxColumn19
            // 
            this.dataGridViewTextBoxColumn19.HeaderText = "p(b9)";
            this.dataGridViewTextBoxColumn19.Name = "dataGridViewTextBoxColumn19";
            this.dataGridViewTextBoxColumn19.Width = 60;
            // 
            // dataGridViewTextBoxColumn20
            // 
            this.dataGridViewTextBoxColumn20.HeaderText = "p(b10)";
            this.dataGridViewTextBoxColumn20.Name = "dataGridViewTextBoxColumn20";
            this.dataGridViewTextBoxColumn20.Width = 60;
            // 
            // EntropyProperties
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 609);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCondProbBA);
            this.Controls.Add(this.btnCondProbAB);
            this.Controls.Add(this.dgvEntropy);
            this.Controls.Add(this.btnMutualProb);
            this.Controls.Add(this.dgvProbSecondary);
            this.Controls.Add(this.dgvProbPrimary);
            this.Controls.Add(this.dgvMatrix);
            this.Name = "EntropyProperties";
            this.Text = "Entropy Properties";
            this.Load += new System.EventHandler(this.EntropyProperties_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatrix)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProbPrimary)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProbSecondary)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntropy)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMatrix;
        private System.Windows.Forms.Button btnMutualProb;
        private System.Windows.Forms.Button btnCondProbAB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCondProbBA;
        private System.Windows.Forms.DataGridView dgvProbPrimary;
        private System.Windows.Forms.DataGridView dgvProbSecondary;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvEntropy;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn21;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn22;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn23;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn24;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn25;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl2;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl3;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl4;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl5;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl6;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl7;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl8;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl9;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn19;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn20;
    }
}

