using System.Numerics;

namespace Lab3_decisions_6th_sem_TOPSIS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Block of system variables
        /// </summary>
        List<CriterionItem> criteriaList;   // For list of criteria
        string[] alternativesList;          // For list of alternatives
        bool isDataReady = false;           // To store info whether data is ready for TOPSIS or not

        /// <summary>
        /// Function to collect data for TOPSIS METHOD
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void updateTableButton_Click(object sender, EventArgs e)
        {
            // Define criteria and alternatives arrays
            var numberOfCriteria = criteriaDatagrid.Rows.Count - 1;
            var numberOfAlternatives = alternativesDatagrid.Rows.Count - 1;

            // Set variable as not ready
            isDataReady = false;
            

            // If there is no criteria and no alternatives, return
            if (numberOfCriteria == 0 || numberOfAlternatives == 0)
            {
                MessageBox.Show("Для этого у вас должен быть хотя бы один критерий и одна альтернатива");
                return;
            }

            criteriaList = new List<CriterionItem>();
            alternativesList = new string[numberOfAlternatives];

            comparisonDatagrid.Rows.Clear();
            comparisonDatagrid.Columns.Clear();

            // Fill criteria array with criteria
            for (int i = 0; i < numberOfCriteria; i++)
            {
                if (criteriaDatagrid.Rows[i].Cells[0].Value == null ||
                    criteriaDatagrid.Rows[i].Cells[1].Value == null ||
                    criteriaDatagrid.Rows[i].Cells[2].Value == null)
                {
                    return;
                }

                string? criterionName = (string?)criteriaDatagrid.Rows[i].Cells[0].Value;
                double criterionWeight = Convert.ToDouble(criteriaDatagrid.Rows[i].Cells[1].Value);
                bool criterionPositivness = (bool)criteriaDatagrid.Rows[i].Cells[2].Value;

                // Create new CriterionItem value with criteria data and add it to list
                var criterion = new CriterionItem(criterionName, criterionWeight, criterionPositivness);
                criteriaList.Add(criterion);

                // Add this criteria's column to the comparison table
                var column = new DataGridViewTextBoxColumn();
                column.HeaderText = criterionName;
                comparisonDatagrid.Columns.Add(column);
            }

            // fill alternatives array with alternatives
            for (int i = 0; i < numberOfAlternatives; i++)
            {
                alternativesList[i] = (string)alternativesDatagrid.Rows[i].Cells[0].Value;
            }

            // Fill comparison table with alternatives string
            foreach (var name in alternativesList)
            {
                var row = new DataGridViewRow();
                row.HeaderCell.Value = name;
                comparisonDatagrid.Rows.Add(row);
            }

            comparisonDatagrid.RowHeadersWidth = 220;

            isDataReady = true;
        }


        public void makeTopsis(List<CriterionItem> criteria, string[] alternatives, string[,] comparisonTable)
        {
            if (!isDataReady)
            {
                MessageBox.Show("Судя по всему, вы ещё не заполняли таблицу");
            }


        }

        /// <summary>
        /// Function to insert test data to all three tables. It allows user to avoid boring part
        /// </summary>
        private void insertTestDataButton_Click(object sender, EventArgs e)
        {
            // Data samples
            var criteriaNames = new string[] { "Цена", "Объём памяти", "Камера", "Дизайн" };
            var criteriaWeights = new string[] { "0.4", "0.2", "0.2", "0.2" };
            var alternativesNames = new string[] { "Смартфон А", "Смартфон В", "Смартфон С", "Смартфон D", "Смартфон Е" };

            var comparisonData = new string[,]
            {
                { "30000", "64", "3", "10" },
                { "24000", "64", "5", "4" },
                { "36000", "128", "6", "3" },
                { "33000", "128", "7", "7" },
                { "27000", "256", "9", "6" }
            };



            // Refill datagrids with empty rows
            criteriaDatagrid.Rows.Clear();
            alternativesDatagrid.Rows.Clear();

            criteriaDatagrid.Rows.Add(4);
            alternativesDatagrid.Rows.Add(5);

            // Fill datagrids
            for (int i = 0; i < 4; i++)
            {
                criteriaDatagrid.Rows[i].Cells[0].Value = criteriaNames[i];
                criteriaDatagrid.Rows[i].Cells[1].Value = criteriaWeights[i];
                criteriaDatagrid.Rows[i].Cells[2].Value = true;

                alternativesDatagrid.Rows[i].Cells[0].Value = alternativesNames[i];
            }

            alternativesDatagrid.Rows[4].Cells[0].Value = "Смартфон Е";
            criteriaDatagrid.Rows[0].Cells[2].Value = false;


            // Update comparison table
            comparisonDatagrid.Rows.Clear();
            comparisonDatagrid.Columns.Clear();
            updateTableButton_Click(null, null);
            
            // Fill comparison table
            for (int i = 0; i < comparisonData.GetLength(0); i++)
            {
                for (int j = 0; j < comparisonData.GetLength(1); j++)
                {
                    comparisonDatagrid.Rows[i].Cells[j].Value = comparisonData[i, j];
                }
            }

        }

        // Main topsis function
        private void runTopsisButton_Click(object sender, EventArgs e)
        {
            // Get data from comparison table
            var rowCount = comparisonDatagrid.Rows.Count;
            var columnCount = comparisonDatagrid.Columns.Count;

            var comparison = new double[rowCount, columnCount];

            for (int i = 0; i < rowCount; i++)
            {
                for (int j = 0; j < columnCount; j++)
                {
                    try
                    {
                        comparison[i, j] = Convert.ToDouble(comparisonDatagrid.Rows[i].Cells[j].Value);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Произошла ошибка. Текст: {ex.Message}");
                        return;
                    }
                }
            }

            // Calculate normalized matrix
            var comparisonNormalized = new double[rowCount, columnCount];

            for (int i = 0; i < rowCount; i++)
            {
                for (int j = 0; j < columnCount; j++)
                {
                    double sumOfDegrees = 0;
                    for (int k = 0; k < rowCount; k++)
                    {
                        sumOfDegrees += Math.Pow(comparison[k, j], 2);
                    }

                    comparisonNormalized[i, j] = comparison[i, j] / Math.Sqrt(sumOfDegrees);
                }
            }

            // Weight normalized comparison matrix
            var comparisonWeighted = new double[rowCount, columnCount];
            for (int i = 0; i < rowCount; i++)
            {
                for (int j = 0; j < columnCount; j++)
                {
                    comparisonWeighted[i, j] = comparisonNormalized[i, j] * criteriaList[j].criterionWeight;
                }
            }

            // Find best and worse solutions
            var perfectSolution = new double[columnCount];
            var imperfectSolution = new double[columnCount];

            for (int i = 0 ; i < columnCount; i++)
            {
                var minMax = getMinMaxFromColumn(comparisonWeighted, i);

                if (criteriaList[i].criterionPositivness)
                {
                    perfectSolution[i] = minMax.max;
                    imperfectSolution[i] = minMax.min;
                }
                else
                {
                    perfectSolution[i] = minMax.min;
                    imperfectSolution[i] = minMax.max;
                }
            }

            // Find distance to perfect and imperfect alternative for each real alternative
            var distances = new (double distanceToPerfect, double distanceToImperfect)[rowCount];

            for (var i = 0; i < rowCount; i++)
            {
                double sumOfDiffSquaredPerf = 0;
                double sumOfDiffSquaredImperf = 0;

                for (var j = 0; j < columnCount; j++)
                {
                    sumOfDiffSquaredPerf += Math.Pow(perfectSolution[j] - comparisonWeighted[i, j], 2);
                    sumOfDiffSquaredImperf += Math.Pow(imperfectSolution[j] - comparisonWeighted[i, j], 2);
                }
                distances[i].distanceToPerfect = Math.Sqrt(sumOfDiffSquaredPerf);
                distances[i].distanceToImperfect = Math.Sqrt(sumOfDiffSquaredImperf);

            }

            // Calculate result score for each alternative
            var result = new double[rowCount];

            for (int i = 0; i < rowCount; i++)
            {
                result[i] = distances[i].distanceToImperfect / (distances[i].distanceToPerfect + distances[i].distanceToImperfect);
            }

            // Get max alt's result and max alt's name
            var maxValue = result.Max();
            var maxValueIndex = result.ToList().IndexOf(maxValue);
            var bestAlternativeName = alternativesList[maxValueIndex];

            // Print it in labels
            bestAlternativeLabel.Text = bestAlternativeName;
            bestAlternativeResultLabel.Text = Math.Round(maxValue, 5).ToString();

            // Print all alternatives with their results to datagrid
            resultDatagrid.Rows.Clear();
            for (var i = 0; i < rowCount; i++)
            {
                resultDatagrid.Rows.Add();
                resultDatagrid.Rows[i].Cells[0].Value = alternativesList[i];
                resultDatagrid.Rows[i].Cells[1].Value = Math.Round(result[i], 5).ToString();

                if (i == maxValueIndex)
                {
                    resultDatagrid.Rows[i].Cells[0].Style.BackColor = Color.LightGreen;
                    resultDatagrid.Rows[i].Cells[1].Style.BackColor = Color.LightGreen;
                }
            }

        }
        /// <summary>
        /// Function to get min and max value from column of 2d array
        /// </summary>
        /// <param name="array"></param>
        /// <param name="column"></param>
        /// <returns>Returns turple with min and max values from column</returns>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public static (double min, double max) getMinMaxFromColumn(double[,] array, int column)
        {
            if (array == null)
                throw new ArgumentNullException(nameof(array));

            var rows = array.GetLength(0);
            var cols = array.GetLength(1);

            if (column < 0 || column >= cols)
                throw new ArgumentOutOfRangeException(nameof(column), "Column index is out of range");

            double min = double.MaxValue;
            double max = double.MinValue;

            for (int i = 0; i < rows; i++)
            {
                var value = array[i, column];
                if (value < min)
                    min = value;
                if (value > max)
                    max = value;
            }

            return (min, max);
        }

    }

    public class CriterionItem
    {
        public string criterionName { get; set; }
        public double criterionWeight { get; set; }
        public bool criterionPositivness { get; set; }

        public CriterionItem(string criterionName, double criterionWeight, bool criterionPositivness)
        {
            this.criterionName = criterionName;
            this.criterionWeight = criterionWeight;
            this.criterionPositivness = criterionPositivness;
        }
    }
}
