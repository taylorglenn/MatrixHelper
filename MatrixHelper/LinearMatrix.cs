using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MatrixHelper
{
    public class LinearMatrix
    {
        private double[][] _matrix;
        private Stack<double[][]> linearMatrixStack = new Stack<double[][]>();
        public int _rows { get; set; }
        public int _columns { get; set; }

        public LinearMatrix(int rows, int columns)
        {
            _matrix = new double[rows][];
            for(int i = 0; i < rows; i++)
            {
                _matrix[i] = new double[columns];
            }
            _rows = rows;
            _columns = columns;
        }
        private void pushToStack(double[][] jaggedArray)
        {
            linearMatrixStack.Push(jaggedArray);
        }
        public void Undo()
        {
            if (linearMatrixStack.Count > 1)
            {
                _matrix = linearMatrixStack.Pop();
            }
        }
        public void EraseAllRows()
        {
            for(int i = 0; i < _matrix.Length; i++)
            {
                for(int j = 0; j < _matrix[0].Length; j++)
                {
                    _matrix[i][j] = 0;
                }
            }
            linearMatrixStack.Push(_matrix);
        }
        public void SetRow(int rowIndex, double[] value)
        {
            _matrix[rowIndex] = value;
        }
        public double[] ReturnRow(int rowIndex)
        {
            return _matrix[rowIndex];
        }
        public double[][] ReturnMatrix()
        {
            return _matrix;
        }
        public int ReturnNumberOfRows()
        {
            return _matrix.Length;
        }
        public int ReturnNumberOfColumns()
        {
            return _matrix[0].Length;
        }
        public void SetElement(int rowIndex, int columnIndex, double value)
        {
            _matrix[rowIndex][columnIndex] = value;
        }
        public double GetElement(int rowIndex, int columnIndex)
        {
            return _matrix[rowIndex][columnIndex];
        }
        public void SetMatrix(double[][] jaggedMatrix)
        {
            for (int row = 0; row < _matrix.Length; row++)
            {
                for (int column = 0; column < _matrix[0].Length; column++)
                {
                    _matrix[row][column] = jaggedMatrix[row][column];
                }
            }
            linearMatrixStack.Push(_matrix);
        }
        public double[] ReturnMultipleOfRow(int rowIndex, double multiple)
        {
            double[] output = new double[_matrix[rowIndex].Length];
            for(int i = 0; i < _matrix[rowIndex].Length; i++)
            {
                output[i] = _matrix[rowIndex][i] * multiple;
            }
            return output;
        }
        public void MultiplyRow(int rowIndex, double multiple)
        {
            for (int i = 0; i < _matrix[rowIndex].Length; i++)
            {
                _matrix[rowIndex][i] *= multiple;
            }
            linearMatrixStack.Push(_matrix);
        }
        public double[] ReturnSumOfRows(int rowIndex1, int rowIndex2)
        {
            double[] output = new double[_matrix[rowIndex1].Length]; //All rows will always have same length
            for(int i = 0; i < _matrix[rowIndex1].Length; i++)
            {
                output[i] = _matrix[rowIndex1][i] + _matrix[rowIndex2][i];
            }
            return output;
        }
        public void SumRows(int rowIndex1, int rowIndex2, int rowReplaceIndex, double row1Multipler = 1)
        {
            double[] tempArray = new double[_matrix[rowIndex1].Length];
            for(int i = 0; i < _matrix[rowIndex1].Length; i++)
            {
                double sum = (_matrix[rowIndex1][i] * row1Multipler) + _matrix[rowIndex2][i];
                tempArray[i] = sum;
            }
            _matrix[rowReplaceIndex] = tempArray;
            linearMatrixStack.Push(_matrix);
        }
        public void SwitchRows(int rowIndex1, int rowIndex2)
        {
            double[] holdingRow = new double[_matrix[0].Length];
            holdingRow = _matrix[rowIndex1];
            _matrix[rowIndex1] = _matrix[rowIndex2];
            _matrix[rowIndex2] = holdingRow;
            linearMatrixStack.Push(_matrix);
        }
        //I'm not really using the below two methods right now.  I may use them later.  Don't delete for now.
        public void SaveMatrixToFile(string fileDirectory, string fileName)
        {
            string directoryString = Path.GetFullPath(fileDirectory);
            if (!(Directory.Exists(directoryString)))
            {
                Directory.CreateDirectory(directoryString);
            }
            string filePath = Path.Combine(directoryString, fileName);
            if(!(File.Exists(filePath)))
            {
                File.Create(filePath).Dispose();
            }
            using (StreamWriter appendTextObject = File.AppendText(filePath))
            {
                appendTextObject.WriteLine(DateTime.Now.ToString("yyyyMMddHHmmss"));
                for (int row = 0; row < _matrix.Length; row++)
                {
                    for (int column = 0; column < _matrix[0].Length; column++)
                    {
                         if (column > 0) { appendTextObject.Write(",\t"); }
                         appendTextObject.Write(_matrix[row][column].ToString());
                    }
                    appendTextObject.WriteLine("");
                }
            }            
        }
        public void openMatrixFromFile(string fileDirectory, string fileName)
        {
            if (File.Exists(Path.Combine(fileDirectory, fileName)))
            {
                //todo: load file at path and put last matrix into _matrix
            }
        }
    }
}
