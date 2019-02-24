using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntropyProperties
{
    public class EntropyPropertiesDefinition
    {
        #region Properties
        /// <summary>
        /// Матрица вероятностей совместного появления первичного и вторичного алфавита
        /// </summary>
        public double[,] ProbibilityMatrix { get; set; }

        /// <summary>
        /// Матрицу условных вероятностей появления символов алфавита
        /// </summary>
        public double[,] ConditionalProbibilityMatrix { get; set; }

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

        #region Methods
        /// <summary>
        /// Формирование матрицы вероятностей 
        /// совместного появления первичного и вторичного алфавита
        /// </summary>
        public void ProbibilityMatrixSimultaneous()
        {

        }

        /// <summary>
        /// Формирование матрицы условных вероятностей 
        /// появления символов первичного и вторичного алфавита
        /// </summary>
        public void ConditionalProbibilityMatrixPrimarySecondary()
        {

        }

        /// <summary>
        /// Формирование матрицы условных вероятностей 
        /// появления символов вторичного и первичного алфавита
        /// </summary>
        public void ConditionalProbibilityMatrixSecondaryPrimary()
        {

        }

        /// <summary>
        /// Формирование вероятности символов первичного алфавита
        /// Получена на основании матрицы совместного появления
        /// </summary>
        public void PrimaryAlphabethSymbolProbibility()
        {

        }

        /// <summary>
        /// Формирование вероятности символов вторичного алфавита
        /// Получена на основании матрицы совместного появления
        /// </summary>
        public void SecondaryAlphabethSymbolProbibility()
        {

        }
        #endregion
    }
}
