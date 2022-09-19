namespace FormStudenti
{
    partial class Form1
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
            this.listBoxIspis = new System.Windows.Forms.ListBox();
            this.buttonNoviStudent = new System.Windows.Forms.Button();
            this.buttonObrisiStudenta = new System.Windows.Forms.Button();
            this.buttonSviObrisi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxIspis
            // 
            this.listBoxIspis.FormattingEnabled = true;
            this.listBoxIspis.Location = new System.Drawing.Point(12, 93);
            this.listBoxIspis.Name = "listBoxIspis";
            this.listBoxIspis.Size = new System.Drawing.Size(273, 199);
            this.listBoxIspis.TabIndex = 0;
            // 
            // buttonNoviStudent
            // 
            this.buttonNoviStudent.Location = new System.Drawing.Point(12, 48);
            this.buttonNoviStudent.Name = "buttonNoviStudent";
            this.buttonNoviStudent.Size = new System.Drawing.Size(139, 23);
            this.buttonNoviStudent.TabIndex = 1;
            this.buttonNoviStudent.Text = "Dodaj novog studenta";
            this.buttonNoviStudent.UseVisualStyleBackColor = true;
            this.buttonNoviStudent.Click += new System.EventHandler(this.buttonNoviStudent_Click);
            // 
            // buttonObrisiStudenta
            // 
            this.buttonObrisiStudenta.Location = new System.Drawing.Point(292, 185);
            this.buttonObrisiStudenta.Name = "buttonObrisiStudenta";
            this.buttonObrisiStudenta.Size = new System.Drawing.Size(101, 23);
            this.buttonObrisiStudenta.TabIndex = 2;
            this.buttonObrisiStudenta.Text = "Obrisi studenta";
            this.buttonObrisiStudenta.UseVisualStyleBackColor = true;
            // 
            // buttonSviObrisi
            // 
            this.buttonSviObrisi.Location = new System.Drawing.Point(12, 309);
            this.buttonSviObrisi.Name = "buttonSviObrisi";
            this.buttonSviObrisi.Size = new System.Drawing.Size(75, 23);
            this.buttonSviObrisi.TabIndex = 3;
            this.buttonSviObrisi.Text = "ObrisiSveStudente";
            this.buttonSviObrisi.UseVisualStyleBackColor = true;
            this.buttonSviObrisi.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 380);
            this.Controls.Add(this.buttonSviObrisi);
            this.Controls.Add(this.buttonObrisiStudenta);
            this.Controls.Add(this.buttonNoviStudent);
            this.Controls.Add(this.listBoxIspis);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxIspis;
        private System.Windows.Forms.Button buttonNoviStudent;
        private System.Windows.Forms.Button buttonObrisiStudenta;
        private System.Windows.Forms.Button buttonSviObrisi;
    }
}

