namespace WinFormsApp1
{
    partial class Form1
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
            dataGridView2 = new DataGridView();
            kerNev = new Label();
            kor = new Label();
            vezNev = new Label();
            szuletesDatum = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            newKerNev = new TextBox();
            newVezNev = new TextBox();
            newKor = new TextBox();
            Save = new Button();
            newDatum = new DateTimePicker();
            htmlbutt = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // dataGridView2
            // 
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(12, 116);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.ReadOnly = true;
            dataGridView2.RowHeadersVisible = false;
            dataGridView2.RowTemplate.Height = 25;
            dataGridView2.Size = new Size(489, 175);
            dataGridView2.TabIndex = 1;
            dataGridView2.RowEnter += dataGridView2_RowEnter;
            // 
            // kerNev
            // 
            kerNev.AutoSize = true;
            kerNev.Location = new Point(603, 20);
            kerNev.Name = "kerNev";
            kerNev.Size = new Size(0, 15);
            kerNev.TabIndex = 2;
            // 
            // kor
            // 
            kor.AutoSize = true;
            kor.Location = new Point(603, 94);
            kor.Name = "kor";
            kor.Size = new Size(0, 15);
            kor.TabIndex = 2;
            // 
            // vezNev
            // 
            vezNev.AutoSize = true;
            vezNev.Location = new Point(603, 58);
            vezNev.Name = "vezNev";
            vezNev.Size = new Size(0, 15);
            vezNev.TabIndex = 2;
            // 
            // szuletesDatum
            // 
            szuletesDatum.AutoSize = true;
            szuletesDatum.Location = new Point(603, 133);
            szuletesDatum.Name = "szuletesDatum";
            szuletesDatum.Size = new Size(0, 15);
            szuletesDatum.TabIndex = 2;
            // 
            // button1
            // 
            button1.Location = new Point(694, 297);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 3;
            button1.Text = "Edit";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(561, 355);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 4;
            button2.Text = "New";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(694, 355);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 4;
            button3.Text = "Remove";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // newKerNev
            // 
            newKerNev.Location = new Point(549, 239);
            newKerNev.Name = "newKerNev";
            newKerNev.Size = new Size(100, 23);
            newKerNev.TabIndex = 5;
            // 
            // newVezNev
            // 
            newVezNev.Location = new Point(549, 268);
            newVezNev.Name = "newVezNev";
            newVezNev.Size = new Size(100, 23);
            newVezNev.TabIndex = 5;
            // 
            // newKor
            // 
            newKor.Location = new Point(549, 297);
            newKor.Name = "newKor";
            newKor.Size = new Size(100, 23);
            newKor.TabIndex = 5;
            // 
            // Save
            // 
            Save.Location = new Point(361, 355);
            Save.Name = "Save";
            Save.Size = new Size(75, 23);
            Save.TabIndex = 6;
            Save.Text = "Save";
            Save.UseVisualStyleBackColor = true;
            Save.Click += Save_Click;
            // 
            // newDatum
            // 
            newDatum.Location = new Point(517, 326);
            newDatum.Name = "newDatum";
            newDatum.Size = new Size(156, 23);
            newDatum.TabIndex = 7;
            // 
            // htmlbutt
            // 
            htmlbutt.Location = new Point(168, 355);
            htmlbutt.Name = "htmlbutt";
            htmlbutt.Size = new Size(75, 23);
            htmlbutt.TabIndex = 8;
            htmlbutt.Text = "HTML";
            htmlbutt.UseVisualStyleBackColor = true;
            htmlbutt.Click += htmlbutt_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(htmlbutt);
            Controls.Add(newDatum);
            Controls.Add(Save);
            Controls.Add(newKor);
            Controls.Add(newVezNev);
            Controls.Add(newKerNev);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(vezNev);
            Controls.Add(szuletesDatum);
            Controls.Add(kor);
            Controls.Add(kerNev);
            Controls.Add(dataGridView2);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label kerNev;
        private Label kor;
        private Label vezNev;
        private Label szuletesDatum;
        private Button button1;
        public DataGridView dataGridView2;
        private Button button2;
        private Button button3;
        private TextBox newKerNev;
        private TextBox newVezNev;
        private TextBox newKor;
        private Button Save;
        private DateTimePicker newDatum;
        private Button htmlbutt;
    }
}