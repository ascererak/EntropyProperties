using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntropyProperties
{
    public partial class EntropyProperties : Form
    {
        private const int m = 10;
        private EntropyPropertiesDefinition properties;

        public EntropyProperties()
        {
            InitializeComponent();
        }

        private void EntropyProperties_Load(object sender, EventArgs e)
        {
            properties = new EntropyPropertiesDefinition();
            dgvMatrix.RowHeadersWidth = 81;
            dgvProbPrimary.RowHeadersWidth = 81;
            dgvProbSecondary.RowHeadersWidth = 81;
            FillProbibilities(dgvProbPrimary, properties.SymbolProbibilityA);
            FillProbibilities(dgvProbSecondary, properties.SymbolProbibilityB);
            FillEntropy();
        }

        private void btnMutualProb_Click(object sender, EventArgs e)
        {
            FillMatrix(properties.ProbibilityMatrix, ',');
        }

        private void btnCondProbAB_Click(object sender, EventArgs e)
        {
            FillMatrix(properties.ConditionalProbibilityMatrixAB, '/');
        }

        private void btnCondProbBA_Click(object sender, EventArgs e)
        {
            FillMatrix(properties.ConditionalProbibilityMatrixBA, '/');
        }

        private void FillProbibilities(DataGridView dgv, double[] vector)
        {
            for (int i = 0; i < m; i++)
            {
                dgv[i, 0].Value = Math.Round(vector[i], 5).ToString();
            }
        }

        private void FillMatrix(double[,] matrix, char divider)
        {
            dgvMatrix.RowCount = 10;
            dgvMatrix.RowHeadersWidth = 81;
            for (int i = 0; i < m; i++)
            {
                dgvMatrix.Rows[i].HeaderCell.Value = $"p(a{i+1}{divider}b1)";

                for (int j = 0; j < m; j++)
                {
                    dgvMatrix.Columns[j].HeaderCell.Value = $"p(a1{divider}b{j + 1})";

                    dgvMatrix[j, i].Value = Math.Round(matrix[i, j], 5).ToString();
                }
            }
        }

        private void FillEntropy()
        {
            int mutual = 0;
            int condAB = 1;
            int condBA = 2;
            int entrA = 3;
            int entrB = 4;

            dgvEntropy[mutual, 0].Value = Math.Round(properties.MutualEntropy, 5).ToString();
            dgvEntropy[condAB, 0].Value = Math.Round(properties.ConditionalEntropyAB, 5).ToString();
            dgvEntropy[condBA, 0].Value = Math.Round(properties.ConditionalEntropyBA, 5).ToString();
            dgvEntropy[entrA, 0].Value = Math.Round(properties.EntropyA, 5).ToString();
            dgvEntropy[entrB, 0].Value = Math.Round(properties.EntropyB, 5).ToString();
        }
    }
}
