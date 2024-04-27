namespace TestWork
{
    partial class TestWork
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            labelHelp = new Label();
            labelEndD = new Label();
            labelBeginD = new Label();
            dateTimePickerEnd = new DateTimePicker();
            dateTimePickerBegin = new DateTimePicker();
            labelCountD = new Label();
            textBoxWorkD = new TextBox();
            buttonSolv = new Button();
            openFileDialogExcel = new OpenFileDialog();
            buttonExcel = new Button();
            SuspendLayout();
            // 
            // labelHelp
            // 
            labelHelp.Anchor = AnchorStyles.None;
            labelHelp.AutoSize = true;
            labelHelp.Font = new Font("Calibri", 14F);
            labelHelp.Location = new Point(12, 9);
            labelHelp.Name = "labelHelp";
            labelHelp.Size = new Size(318, 138);
            labelHelp.TabIndex = 11;
            labelHelp.Text = "Для расчёта количества рабочих дней\r\nмежду начальной и конечной датами:\r\nвыберите таблицу с праздничными\r\nднями, выберите необходимые даты\r\nи нажмите на кнопку для вычисления\r\nрезультата.";
            // 
            // labelEndD
            // 
            labelEndD.Anchor = AnchorStyles.None;
            labelEndD.AutoSize = true;
            labelEndD.BackColor = SystemColors.Control;
            labelEndD.Font = new Font("Calibri", 14F);
            labelEndD.Location = new Point(257, 191);
            labelEndD.Name = "labelEndD";
            labelEndD.Size = new Size(126, 23);
            labelEndD.TabIndex = 13;
            labelEndD.Text = "Конечная дата";
            // 
            // labelBeginD
            // 
            labelBeginD.Anchor = AnchorStyles.None;
            labelBeginD.AutoSize = true;
            labelBeginD.BackColor = SystemColors.Control;
            labelBeginD.Font = new Font("Calibri", 14F);
            labelBeginD.Location = new Point(12, 191);
            labelBeginD.Name = "labelBeginD";
            labelBeginD.Size = new Size(136, 23);
            labelBeginD.TabIndex = 12;
            labelBeginD.Text = "Начальная дата";
            // 
            // dateTimePickerEnd
            // 
            dateTimePickerEnd.Anchor = AnchorStyles.None;
            dateTimePickerEnd.Font = new Font("Calibri", 14F);
            dateTimePickerEnd.Location = new Point(257, 228);
            dateTimePickerEnd.MaxDate = new DateTime(2021, 12, 31, 0, 0, 0, 0);
            dateTimePickerEnd.MinDate = new DateTime(2021, 1, 2, 0, 0, 0, 0);
            dateTimePickerEnd.Name = "dateTimePickerEnd";
            dateTimePickerEnd.Size = new Size(200, 30);
            dateTimePickerEnd.TabIndex = 15;
            dateTimePickerEnd.Value = new DateTime(2021, 12, 31, 0, 0, 0, 0);
            dateTimePickerEnd.ValueChanged += dateTimePickerEnd_ValueChanged;
            // 
            // dateTimePickerBegin
            // 
            dateTimePickerBegin.Anchor = AnchorStyles.None;
            dateTimePickerBegin.Font = new Font("Calibri", 14F);
            dateTimePickerBegin.Location = new Point(12, 228);
            dateTimePickerBegin.MaxDate = new DateTime(2021, 12, 30, 0, 0, 0, 0);
            dateTimePickerBegin.MinDate = new DateTime(2021, 1, 1, 0, 0, 0, 0);
            dateTimePickerBegin.Name = "dateTimePickerBegin";
            dateTimePickerBegin.Size = new Size(200, 30);
            dateTimePickerBegin.TabIndex = 14;
            dateTimePickerBegin.Value = new DateTime(2021, 1, 1, 0, 0, 0, 0);
            dateTimePickerBegin.ValueChanged += dateTimePickerBegin_ValueChanged;
            // 
            // labelCountD
            // 
            labelCountD.Anchor = AnchorStyles.None;
            labelCountD.AutoSize = true;
            labelCountD.BackColor = SystemColors.Control;
            labelCountD.Font = new Font("Calibri", 16F);
            labelCountD.Location = new Point(12, 304);
            labelCountD.Name = "labelCountD";
            labelCountD.Size = new Size(173, 27);
            labelCountD.TabIndex = 18;
            labelCountD.Text = "Количество дней";
            // 
            // textBoxWorkD
            // 
            textBoxWorkD.Anchor = AnchorStyles.None;
            textBoxWorkD.BackColor = SystemColors.Control;
            textBoxWorkD.BorderStyle = BorderStyle.FixedSingle;
            textBoxWorkD.Font = new Font("Calibri", 16F);
            textBoxWorkD.Location = new Point(204, 301);
            textBoxWorkD.Name = "textBoxWorkD";
            textBoxWorkD.ReadOnly = true;
            textBoxWorkD.Size = new Size(41, 34);
            textBoxWorkD.TabIndex = 17;
            // 
            // buttonSolv
            // 
            buttonSolv.Anchor = AnchorStyles.None;
            buttonSolv.BackColor = SystemColors.Window;
            buttonSolv.Enabled = false;
            buttonSolv.Font = new Font("Calibri", 16F);
            buttonSolv.Location = new Point(321, 279);
            buttonSolv.Name = "buttonSolv";
            buttonSolv.Size = new Size(136, 63);
            buttonSolv.TabIndex = 16;
            buttonSolv.Text = "Вычислить";
            buttonSolv.UseVisualStyleBackColor = false;
            buttonSolv.Click += buttonSolv_Click;
            // 
            // openFileDialogExcel
            // 
            openFileDialogExcel.FileName = "openFileDialogExcel";
            // 
            // buttonExcel
            // 
            buttonExcel.Anchor = AnchorStyles.None;
            buttonExcel.BackColor = SystemColors.Window;
            buttonExcel.Font = new Font("Calibri", 16F);
            buttonExcel.Location = new Point(336, 12);
            buttonExcel.Name = "buttonExcel";
            buttonExcel.Size = new Size(136, 63);
            buttonExcel.TabIndex = 19;
            buttonExcel.Text = "Выбрать таблицу";
            buttonExcel.UseVisualStyleBackColor = false;
            buttonExcel.Click += buttonExcel_Click;
            // 
            // TestWork
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 361);
            Controls.Add(buttonExcel);
            Controls.Add(labelCountD);
            Controls.Add(textBoxWorkD);
            Controls.Add(buttonSolv);
            Controls.Add(dateTimePickerEnd);
            Controls.Add(dateTimePickerBegin);
            Controls.Add(labelEndD);
            Controls.Add(labelBeginD);
            Controls.Add(labelHelp);
            MinimumSize = new Size(500, 400);
            Name = "TestWork";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelHelp;
        private Label labelEndD;
        private Label labelBeginD;
        private DateTimePicker dateTimePickerEnd;
        private DateTimePicker dateTimePickerBegin;
        private Label labelCountD;
        private TextBox textBoxWorkD;
        private Button buttonSolv;
        private OpenFileDialog openFileDialogExcel;
        private Button buttonExcel;
    }
}
