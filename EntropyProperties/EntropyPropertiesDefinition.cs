using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntropyProperties
{
    public class EntropyPropertiesDefinition
    {
        private const int m = 10;
        private double[,] conditionalProbibilityMatrixAB;
        private double[,] conditionalProbibilityMatrixBA;
        private double[] symbolProbibilityA;
        private double[] symbolProbibilityB;

        #region Properties
        /// <summary>
        /// Матрица вероятностей совместного появления первичного и вторичного алфавита P(a,b)
        /// </summary>
        public double[,] ProbibilityMatrix { get; set; }

        /// <summary>
        /// Матрица условных вероятностей появления символов алфавита P(A/B)
        /// </summary>
        public double[,] ConditionalProbibilityMatrixAB { get { return conditionalProbibilityMatrixAB; } }

        /// <summary>
        /// Матрица условных вероятностей появления символов алфавита P(B/A)
        /// </summary>
        public double[,] ConditionalProbibilityMatrixBA { get { return conditionalProbibilityMatrixBA; } }

        /// <summary>
        /// Вероятности символов первичного алфавита.
        /// </summary>
        public double[] SymbolProbibilityA { get { return symbolProbibilityA; } }

        /// <summary>
        /// Вероятности вторичного первичного алфавита.
        /// </summary>
        public double[] SymbolProbibilityB { get { return symbolProbibilityB; } }

        /// <summary>
        /// Взаимная энтропия
        /// H(A,B)
        /// </summary>
        public double MutualEntropy { get; set; }

        /// <summary>
        /// Условная энтропия
        /// H(A/B)
        /// </summary>
        public double ConditionalEntropyAB { get; set; }

        /// <summary>
        /// Условная энтропия
        /// H(B/A)
        /// </summary>
        public double ConditionalEntropyBA { get; set; }

        /// <summary>
        /// Энтропия
        /// H(A)
        /// </summary>
        public double EntropyA { get; set; }

        /// <summary>
        /// Энтропия
        /// H(B)
        /// </summary>
        public double EntropyB { get; set; }

        #endregion

        public EntropyPropertiesDefinition()
        {
            // Формирование матрицы вероятностей совместного использования
            ProbibilityMatrixSimultaneous();

            // Вероятности символов первичного алфавита
            AlphabethSymbolProbibility(out symbolProbibilityA, true);
            // Вероятности символов вторичного алфавита
            AlphabethSymbolProbibility(out symbolProbibilityB, false);

            // Формирование матриц условных вероятностей первичного и вторичного алфавита
            ConditionalProbibilityMatrix(out conditionalProbibilityMatrixAB, SymbolProbibilityA);
            // Формирование матриц условных вероятностей вторичного и первичного алфавита
            ConditionalProbibilityMatrix(out conditionalProbibilityMatrixBA, SymbolProbibilityB);

            // Поиск взаимной энтропии H(A,B)
            FindEntropyAB();

            // Поиск энтропии H(A)
            EntropyA = FindEntropyX(SymbolProbibilityA);
            // Поиск энтропии H(B)
            EntropyB = FindEntropyX(SymbolProbibilityB);

            // Поиск условной энтропии H(A/B)
            ConditionalEntropyAB = FindCondEntropyXY(EntropyA);
            // Поиск условной энтропии H(B/A)
            ConditionalEntropyBA = FindCondEntropyXY(EntropyB);
        }

        #region Methods
        /// <summary>
        /// Формирование матрицы вероятностей 
        /// совместного появления первичного и вторичного алфавита
        /// </summary>
        private void ProbibilityMatrixSimultaneous()
        {
            Random r = new Random();
            int sum = 0;    
            ProbibilityMatrix = new double[m, m];

            for (var i = 0; i < m; i++)
            {
                for (var j = 0; j < m; j++)
                {
                    int newP = r.Next(10);
                    ProbibilityMatrix[i, j] = newP;
                    sum += newP;
                }
            }

            for (var i = 0; i < m; i++)
            {
                for (var j = 0; j < m; j++)
                {
                    ProbibilityMatrix[i, j] /= sum;
                }
            }
        }

        /// <summary>
        /// Формирование матрицы условных вероятностей 
        /// появления символов первичного и вторичного алфавита
        /// </summary>
        /// <param name="condProb">Матрица условных вероятностей появления символов алфавита</param>
        /// <param name="SymbolProbibility">Вероятности символов алфавита</param>
        public void ConditionalProbibilityMatrix(out double[,] condProb, double[] SymbolProbibility)
        {
            condProb = new double[m, m];
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    condProb[i, j] = ProbibilityMatrix[i, j] / SymbolProbibility[i];
                }
            }
        }

        /// <summary>
        /// Формирование вероятности символов первичного алфавита
        /// Получена на основании матрицы совместного появления
        /// <param name="probAlf"> Вероятности символов алфавита</param>
        /// </summary>
        public void AlphabethSymbolProbibility(out double[] probAlf, bool AB)
        {
            probAlf = new double[m];
            for (int i = 0; i < m; i++)
            {
                double elemAlfavita = 0;
                for (int j = 0; j < m; j++)
                {
                    elemAlfavita += AB ? ProbibilityMatrix[i, j] : ProbibilityMatrix[j, i];
                }
                probAlf[i] = elemAlfavita;
            }
        }

        /// <summary>
        /// Энтропия H(A,B)
        /// </summary>
        private void FindEntropyAB()
        {
            MutualEntropy = 0;
            for (int i = 0; i < m; i++)
                for (int j = 0; j < m; j++)
                {
                    if (ProbibilityMatrix[i, j] != 0)
                        MutualEntropy += ProbibilityMatrix[i, j] * Math.Log(ProbibilityMatrix[i, j], 2);
                }
            MutualEntropy *= -1;
        }

        /// <summary>
        /// Условная энтропия H(A/B) или H(B/A)
        /// </summary>
        /// <param name="Y">Энтропия второго</param>
        /// <returns></returns>
        private double FindCondEntropyXY(double Y)
        {
            return MutualEntropy - Y;
        }

        /// <summary>
        /// Энтропия H(X)
        /// </summary>
        /// <param name="X"></param>
        /// <param name="probX"></param>
        private double FindEntropyX(double[] probX)
        {
            double X = 0;
            for (int i = 0; i < probX.Length; i++)
            {
                X += probX[i] * Math.Log(probX[i], 2);
            }
            X *= -1;
            return X;
        }

        #endregion
    }
}
