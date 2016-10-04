using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using MatrixHelper;
using System.IO;

namespace MatrixHelperTests
{
    [TestFixture]
    class LinearMatrixTests
    {
        public static double[][] _testData = new double[][]
        {
            new double[] {2, 1, -3, -4},
            new double[] {4, -2, 1, 9},
            new double[] {3, 5, -2, 5},
        };
        LinearMatrix _testMatrix;
        string _upperLevelFolderName;
        string _pathString;
        string _testFileName;
        string _pathWithFile;
        List<string> _linesInFile;

        [SetUp]
        public void SetUp()
        {
            _testMatrix = new LinearMatrix(_testData.Length, _testData[0].Length);
            for (int row = 0; row < _testMatrix.ReturnNumberOfRows(); row++)
            {
                for (int column = 0; column < _testMatrix.ReturnNumberOfColumns(); column++)
                {
                    _testMatrix.SetElement(row, column, _testData[row][column]);
                }
            }
            _upperLevelFolderName = @"c:\MatrixLog\";
            _pathString = Path.GetFullPath(_upperLevelFolderName);
            Directory.CreateDirectory(_pathString);
            _testFileName = "testMatrixFile.txt";
            _pathWithFile = Path.Combine(_pathString, _testFileName);
            File.Create(_pathWithFile).Dispose();
            _linesInFile = new List<string> { "1,\t2,\t3" , "4,\t5,\t6", "7,\t8,\t9" };
            using (StreamWriter _testFile = File.CreateText(_pathWithFile))
            {
                foreach (string line in _linesInFile)
                {
                    _testFile.WriteLine(line);
                }
            }
        }
        [Test]
        public void EraseAllRowsTest()
        {
            //Fill matrix with random data
            Random randomNumber = new Random();
            for (int row = 0; row < _testMatrix.ReturnNumberOfRows(); row++)
            {
                for (int column = 0; column < _testMatrix.ReturnNumberOfColumns(); column++)
                {
                    _testMatrix.SetElement(row, column, randomNumber.Next(1,999));
                }
            }
            _testMatrix.EraseAllRows();
            bool nonZeroFound = false;
            for(int i = 0; i < _testMatrix.ReturnNumberOfRows(); i++)
            {
                for(int j = 0; j < _testMatrix.ReturnNumberOfColumns(); j++)
                {
                    if(_testMatrix.ReturnMatrix()[i][j] != 0)
                    {
                        nonZeroFound = true;
                    }
                }
            }
            Assert.IsFalse(nonZeroFound);
        }
        
        [Test]
        public void SetRowTest()
        {
            double[] testDouble = new double[_testData[0].Length];
            for(int i = 0; i < _testData[0].Length; i++)
            {
                testDouble[i] = i;
            }
            _testMatrix.SetRow(1, testDouble);
            Assert.AreEqual(testDouble, _testMatrix.ReturnRow(1));
        }

        [Test]
        public void ReturnRowTest()
        {
            for (int i = 0; i < _testData.Length; i++)
            {
                Assert.AreEqual(_testData[i], _testMatrix.ReturnRow(i));
            }
        }

        [Test]
        public void ReturnMatrixTest()
        {
            Assert.AreEqual(_testData, _testMatrix.ReturnMatrix());
        }

        [Test]
        public void ReturnNumberOfRowsTest()
        {
            Assert.AreEqual(_testData.Length, _testMatrix.ReturnNumberOfRows());
        }

        [Test]
        public void ReturnNumberOfColumnsTest()
        {
            Assert.AreEqual(_testData[0].Length, _testMatrix.ReturnNumberOfColumns());
        }

        [Test]
        public void SetAndGetElementTest()
        {
            _testMatrix.SetElement(1, 3, 6.45);
            Assert.AreEqual(6.45, _testMatrix.GetElement(1, 3));
        }

        [Test]
        public void ReturnMultipleOfRowAndMultiplyRowTest()
        {
            double multiple = 4;
            for(int row = 0; row < _testData.Length; row++)
            {
                for (int column = 0; column < _testData[0].Length; column++)
                {
                    _testData[row][column] *= multiple;
                }
                double[] testRow = _testMatrix.GetMultipleOfRow(row, multiple);
                Assert.AreEqual(_testData[row], testRow);
                _testMatrix.MultiplyRow(row, multiple);
                Assert.AreEqual(_testData[row], _testMatrix.ReturnRow(row));
            }
        }

        [Test]
        public void ReturnSumOfRowsAndSumRowsTest()
        {
            //This test only uses rows 0 and 1 from the test data and test matrix.
            double[] testRow = new double[_testData[0].Length];
            for(int i = 0; i < _testData[0].Length; i++)
            {
                testRow[i] = _testData[0][i] + _testData[1][i];
            }
            Assert.AreEqual(testRow, _testMatrix.GetSumOfRows(0, 1));
            _testMatrix.SumRows(0, 1, 1);
            Assert.AreEqual(testRow, _testMatrix.ReturnRow(1));
        }

        [Test]
        public void SaveMatrixToFileTest()
        {
            string fileDirectoryPath = Path.GetFullPath("c:\\MatrixLog\\");
            string fileName = "testFile.txt";
            _testMatrix.SaveMatrixToFile(fileDirectoryPath, fileName);
            Assert.IsTrue(File.Exists(Path.Combine(fileDirectoryPath, fileName)));
        }

        [TearDown]
        public void TearDown()
        {
            GC.Collect();
            GC.WaitForPendingFinalizers();
            File.Delete(_pathWithFile);
        }
    }
}
