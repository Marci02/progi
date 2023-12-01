namespace WinFormsApp1.Froms
{
    partial class Edit
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            kerNev = new TextBox();
            vezNev = new TextBox();
            kor = new TextBox();
            szulDatum = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // kerNev
            // 
            kerNev.Location = new Point(161, 36);
            kerNev.Name = "kerNev";
            kerNev.Size = new Size(100, 23);
            kerNev.TabIndex = 0;
            // 
            // vezNev
            // 
            vezNev.Location = new Point(161, 74);
            vezNev.Name = "vezNev";
            vezNev.Size = new Size(100, 23);
            vezNev.TabIndex = 0;
            // 
            // kor
            // 
            kor.Location = new Point(161, 112);
            kor.Name = "kor";
            kor.Size = new Size(100, 23);
            kor.TabIndex = 0;
            // 
            // szulDatum
            // 
            szulDatum.Location = new Point(161, 150);
            szulDatum.Name = "szulDatum";
            szulDatum.Size = new Size(100, 23);
            szulDatum.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(174, 188);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 1;
            button1.Text = "Módosítás";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Edit
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(422, 247);
            Controls.Add(button1);
            Controls.Add(szulDatum);
            Controls.Add(kor);
            Controls.Add(vezNev);
            Controls.Add(kerNev);
            Name = "Edit";
            Text = "Edit";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox kerNev;
        private TextBox vezNev;
        private TextBox kor;
        private TextBox szulDatum;
        private Button button1;
    }
}