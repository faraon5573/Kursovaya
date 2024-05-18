namespace Курсовая
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label4 = new System.Windows.Forms.Label();
            this.number = new System.Windows.Forms.ComboBox();
            this.Create = new System.Windows.Forms.Button();
            this.matrixA = new System.Windows.Forms.DataGridView();
            this.matrixB = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.x0 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.eps = new System.Windows.Forms.TextBox();
            this.decide = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.result = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.matrixA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.matrixB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.x0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.result)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(12, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(193, 26);
            this.label4.TabIndex = 25;
            this.label4.Text = "Размер матрицы:";
            // 
            // number
            // 
            this.number.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.number.FormattingEnabled = true;
            this.number.Items.AddRange(new object[] {
            "3",
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.number.Location = new System.Drawing.Point(211, 15);
            this.number.Name = "number";
            this.number.Size = new System.Drawing.Size(121, 21);
            this.number.TabIndex = 26;
            // 
            // Create
            // 
            this.Create.Location = new System.Drawing.Point(338, 15);
            this.Create.Name = "Create";
            this.Create.Size = new System.Drawing.Size(171, 23);
            this.Create.TabIndex = 29;
            this.Create.Text = "Создать матрицу";
            this.Create.UseVisualStyleBackColor = true;
            this.Create.Click += new System.EventHandler(this.Create_Click);
            // 
            // matrixA
            // 
            this.matrixA.AllowUserToAddRows = false;
            this.matrixA.AllowUserToDeleteRows = false;
            this.matrixA.AllowUserToResizeRows = false;
            this.matrixA.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.matrixA.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.matrixA.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.matrixA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.matrixA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.matrixA.ColumnHeadersVisible = false;
            this.matrixA.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.matrixA.EnableHeadersVisualStyles = false;
            this.matrixA.Location = new System.Drawing.Point(17, 44);
            this.matrixA.Name = "matrixA";
            this.matrixA.RowHeadersVisible = false;
            this.matrixA.Size = new System.Drawing.Size(526, 220);
            this.matrixA.TabIndex = 30;
            // 
            // matrixB
            // 
            this.matrixB.AllowUserToAddRows = false;
            this.matrixB.AllowUserToDeleteRows = false;
            this.matrixB.AllowUserToResizeRows = false;
            this.matrixB.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.matrixB.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.matrixB.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.matrixB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.matrixB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.matrixB.ColumnHeadersVisible = false;
            this.matrixB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.matrixB.EnableHeadersVisualStyles = false;
            this.matrixB.Location = new System.Drawing.Point(549, 44);
            this.matrixB.Name = "matrixB";
            this.matrixB.RowHeadersVisible = false;
            this.matrixB.Size = new System.Drawing.Size(107, 220);
            this.matrixB.TabIndex = 31;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 267);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(275, 26);
            this.label2.TabIndex = 32;
            this.label2.Text = "Начальные значения X   :";
            // 
            // x0
            // 
            this.x0.AllowUserToAddRows = false;
            this.x0.AllowUserToDeleteRows = false;
            this.x0.AllowUserToResizeRows = false;
            this.x0.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.x0.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.x0.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.x0.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.x0.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.x0.ColumnHeadersVisible = false;
            this.x0.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.x0.EnableHeadersVisualStyles = false;
            this.x0.Location = new System.Drawing.Point(12, 296);
            this.x0.Name = "x0";
            this.x0.RowHeadersVisible = false;
            this.x0.Size = new System.Drawing.Size(639, 23);
            this.x0.TabIndex = 36;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 322);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 26);
            this.label3.TabIndex = 37;
            this.label3.Text = "Точность ε";
            // 
            // eps
            // 
            this.eps.Location = new System.Drawing.Point(140, 328);
            this.eps.Name = "eps";
            this.eps.Size = new System.Drawing.Size(100, 20);
            this.eps.TabIndex = 38;
            this.eps.Text = "0,001";
            this.eps.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.eps_KeyPress);
            // 
            // decide
            // 
            this.decide.Location = new System.Drawing.Point(17, 351);
            this.decide.Name = "decide";
            this.decide.Size = new System.Drawing.Size(75, 23);
            this.decide.TabIndex = 39;
            this.decide.Text = "Решить";
            this.decide.UseVisualStyleBackColor = true;
            this.decide.Click += new System.EventHandler(this.decide_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 377);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(259, 26);
            this.label1.TabIndex = 40;
            this.label1.Text = "Результат производных";
            // 
            // result
            // 
            this.result.AllowUserToAddRows = false;
            this.result.AllowUserToDeleteRows = false;
            this.result.AllowUserToResizeRows = false;
            this.result.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.result.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.result.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.result.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.result.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.result.ColumnHeadersVisible = false;
            this.result.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.result.EnableHeadersVisualStyles = false;
            this.result.Location = new System.Drawing.Point(12, 406);
            this.result.Name = "result";
            this.result.RowHeadersVisible = false;
            this.result.RowTemplate.ReadOnly = true;
            this.result.Size = new System.Drawing.Size(312, 163);
            this.result.TabIndex = 41;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(257, 267);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(14, 16);
            this.label5.TabIndex = 42;
            this.label5.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 581);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.result);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.decide);
            this.Controls.Add(this.eps);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.x0);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.matrixB);
            this.Controls.Add(this.matrixA);
            this.Controls.Add(this.Create);
            this.Controls.Add(this.number);
            this.Controls.Add(this.label4);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Решение СЛАУ методом Зейделя";
            ((System.ComponentModel.ISupportInitialize)(this.matrixA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.matrixB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.x0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.result)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox number;
        private System.Windows.Forms.Button Create;
        private System.Windows.Forms.DataGridView matrixA;
        private System.Windows.Forms.DataGridView matrixB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView x0;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox eps;
        private System.Windows.Forms.Button decide;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView result;
        private System.Windows.Forms.Label label5;
    }
}

