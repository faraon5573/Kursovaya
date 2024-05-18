using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Курсовая
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void eps_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Разрешены только цифры, запятая и клавиша Backspace
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ',')
            {
                e.Handled = true;
            }

            // Проверка на точку в числе
            if (e.KeyChar == ',' && (sender as TextBox).Text.IndexOf(',') > -1)
            {
                e.Handled = true;
            }

            // Проверка на количество знаков после запятой
            if (e.KeyChar == ',' && (sender as TextBox).Text.Split(',').Length > 1)
            {
                e.Handled = true;
            }
        }

        private void Create_Click(object sender, EventArgs e)
        {
            try
            {
                if (number.SelectedIndex == -1)
                {
                    MessageBox.Show("Выберите число из раскрывающегося списка!");
                    number.DroppedDown = true;
                }
                else
                {
                    matrixA.Rows.Clear();
                    matrixA.Columns.Clear();
                    int a = int.Parse(number.Text);
                    for (int i = 0; i < a; i++)
                    {
                        matrixA.Columns.Add("", "");
                    }
                    for (int j = 0; j < a; j++)
                    {
                        matrixA.Rows.Add();
                    }

                    matrixB.Rows.Clear();
                    matrixB.Columns.Clear();
                    matrixB.Columns.Add("", "");
                    for (int j = 0; j < a; j++)
                    {
                        matrixB.Rows.Add();
                    }

                    x0.Rows.Clear();
                    x0.Columns.Clear();
                    for (int i = 0; i < a; i++)
                    {
                        x0.Columns.Add("", "");
                    }
                    x0.Rows.Add();

                    result.Rows.Clear();
                    result.Columns.Clear();
                }



            }
            catch { }
        }

        private void decide_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidateDataGridView(matrixA) || !ValidateDataGridView(matrixB) || !ValidateDataGridView(x0))
                {
                    return;
                }

                int n = matrixA.RowCount;
                if (n == 0)
                {
                    MessageBox.Show("Необходимо создать матрицу.");
                    number.DroppedDown = true;
                    return;
                }
                double[,] A = new double[n, n];
                double[,] B = new double[n, 1];
                double[] X = new double[n];
                double[] X0 = new double[n];
                double epsilon;

                // Заполнение матрицы A и вектора B из matrixA и matrixB
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        A[i, j] = Convert.ToDouble(matrixA.Rows[i].Cells[j].Value);
                        if (i == j && A[i, j] == 0)
                        {
                            MessageBox.Show("В матрице A на диагонали должны быть числа, числа дожны быть не равно нулю.");
                            return;
                        }
                    }
                    B[i, 0] = Convert.ToDouble(matrixB.Rows[i].Cells[0].Value);
                    if (B[i, 0] == 0)
                    {
                        MessageBox.Show("В матрице B должны быть числа, числа дожны быть не равно нулю.");
                        return;
                    }
                }

                // Инициализация вектора X
                for (int i = 0; i < n; i++)
                {
                    if (x0.Rows.Count > i && x0.Columns.Count > 0 && x0.Rows[i].Cells[0].Value != null)
                    {
                        X[i] = Convert.ToDouble(x0.Rows[i].Cells[0].Value); // Теперь используем одномерный индекс
                    }
                    else
                    {
                        // Если начальные приближения не заданы, используем нулевые значения
                        X[i] = 0;
                    }
                }

                // Получение точности ε
                epsilon = Convert.ToDouble(eps.Text);

                // Метод Зейделя
                double[] X_prev = new double[n];
                bool converged = false;

                for (int iteration = 0; iteration < 1000 && !converged; iteration++) // Ограничение на количество итераций
                {
                    Array.Copy(X, X_prev, n);

                    for (int i = 0; i < n; i++)
                    {
                        double sum = 0;
                        for (int j = 0; j < n; j++)
                        {
                            if (j != i)
                            {
                                sum += A[i, j] * X[j];
                            }
                        }
                        X[i] = (B[i, 0] - sum) / A[i, i];
                    }

                    // Проверка сходимости
                    converged = true;
                    for (int i = 0; i < n; i++)
                    {
                        if (Math.Abs(X[i] - X_prev[i]) > epsilon)
                        {
                            converged = false;
                            break;
                        }
                    }
                }

                // Вывод результата в result
                result.Rows.Clear();
                result.Columns.Clear();
                result.Columns.Add("", "");
                for (int i = 0; i < n; i++)
                {
                    result.Rows.Add(Math.Round(X[i], 6).ToString());
                }
            }
            catch
            {
            }
        }
        private bool ValidateDataGridView(DataGridView dataGridView)
        {
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.Value != null && !double.TryParse(cell.Value.ToString(), out _))
                    {
                        // Очищаем ячейку с некорректным символом
                        cell.Value = string.Empty;
                        // Выводим сообщение об ошибке
                        MessageBox.Show($"Некорректный символ в ячейке ({cell.RowIndex}, {cell.ColumnIndex})");
                    }
                }
            }
            return true;
        }
    }
}
