namespace EntityFrameworkLab4
{
    partial class FormMain
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.labelAllJumpers = new System.Windows.Forms.Label();
            this.labelAllCountries = new System.Windows.Forms.Label();
            this.labelJumperFirstName = new System.Windows.Forms.Label();
            this.labelJumperLastName = new System.Windows.Forms.Label();
            this.labelJumperBirthdate = new System.Windows.Forms.Label();
            this.labelJumperCountryId = new System.Windows.Forms.Label();
            this.dateTimePickerJumper = new System.Windows.Forms.DateTimePicker();
            this.textBoxJumperFirstName = new System.Windows.Forms.TextBox();
            this.textBoxJumperLastName = new System.Windows.Forms.TextBox();
            this.textBoxJumperCountryId = new System.Windows.Forms.TextBox();
            this.labelCountryName = new System.Windows.Forms.Label();
            this.labelCountryRecord = new System.Windows.Forms.Label();
            this.textBoxCountryName = new System.Windows.Forms.TextBox();
            this.textBoxCountryRecord = new System.Windows.Forms.TextBox();
            this.buttonJumperAdd = new System.Windows.Forms.Button();
            this.buttonCountryAdd = new System.Windows.Forms.Button();
            this.buttonJumperDelete = new System.Windows.Forms.Button();
            this.buttonJumperUpdate = new System.Windows.Forms.Button();
            this.buttonJumperShow = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 383);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(473, 284);
            this.dataGridView1.TabIndex = 0;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(510, 381);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(473, 286);
            this.dataGridView2.TabIndex = 1;
            // 
            // labelAllJumpers
            // 
            this.labelAllJumpers.AutoSize = true;
            this.labelAllJumpers.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelAllJumpers.Location = new System.Drawing.Point(116, 330);
            this.labelAllJumpers.Name = "labelAllJumpers";
            this.labelAllJumpers.Size = new System.Drawing.Size(235, 29);
            this.labelAllJumpers.TabIndex = 2;
            this.labelAllJumpers.Text = "Wszyscy skoczkowie";
            // 
            // labelAllCountries
            // 
            this.labelAllCountries.AutoSize = true;
            this.labelAllCountries.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelAllCountries.Location = new System.Drawing.Point(635, 330);
            this.labelAllCountries.Name = "labelAllCountries";
            this.labelAllCountries.Size = new System.Drawing.Size(178, 29);
            this.labelAllCountries.TabIndex = 3;
            this.labelAllCountries.Text = "Wszystkie kraje";
            // 
            // labelJumperFirstName
            // 
            this.labelJumperFirstName.AutoSize = true;
            this.labelJumperFirstName.Location = new System.Drawing.Point(65, 19);
            this.labelJumperFirstName.Name = "labelJumperFirstName";
            this.labelJumperFirstName.Size = new System.Drawing.Size(33, 17);
            this.labelJumperFirstName.TabIndex = 4;
            this.labelJumperFirstName.Text = "Imię";
            // 
            // labelJumperLastName
            // 
            this.labelJumperLastName.AutoSize = true;
            this.labelJumperLastName.Location = new System.Drawing.Point(31, 54);
            this.labelJumperLastName.Name = "labelJumperLastName";
            this.labelJumperLastName.Size = new System.Drawing.Size(67, 17);
            this.labelJumperLastName.TabIndex = 5;
            this.labelJumperLastName.Text = "Nazwisko";
            // 
            // labelJumperBirthdate
            // 
            this.labelJumperBirthdate.AutoSize = true;
            this.labelJumperBirthdate.Location = new System.Drawing.Point(9, 96);
            this.labelJumperBirthdate.Name = "labelJumperBirthdate";
            this.labelJumperBirthdate.Size = new System.Drawing.Size(89, 17);
            this.labelJumperBirthdate.TabIndex = 6;
            this.labelJumperBirthdate.Text = "Data urodzin";
            // 
            // labelJumperCountryId
            // 
            this.labelJumperCountryId.AutoSize = true;
            this.labelJumperCountryId.Location = new System.Drawing.Point(44, 133);
            this.labelJumperCountryId.Name = "labelJumperCountryId";
            this.labelJumperCountryId.Size = new System.Drawing.Size(54, 17);
            this.labelJumperCountryId.TabIndex = 7;
            this.labelJumperCountryId.Text = "Id kraju";
            // 
            // dateTimePickerJumper
            // 
            this.dateTimePickerJumper.Location = new System.Drawing.Point(132, 96);
            this.dateTimePickerJumper.Name = "dateTimePickerJumper";
            this.dateTimePickerJumper.Size = new System.Drawing.Size(166, 22);
            this.dateTimePickerJumper.TabIndex = 8;
            // 
            // textBoxJumperFirstName
            // 
            this.textBoxJumperFirstName.Location = new System.Drawing.Point(132, 16);
            this.textBoxJumperFirstName.Name = "textBoxJumperFirstName";
            this.textBoxJumperFirstName.Size = new System.Drawing.Size(166, 22);
            this.textBoxJumperFirstName.TabIndex = 9;
            // 
            // textBoxJumperLastName
            // 
            this.textBoxJumperLastName.Location = new System.Drawing.Point(132, 54);
            this.textBoxJumperLastName.Name = "textBoxJumperLastName";
            this.textBoxJumperLastName.Size = new System.Drawing.Size(166, 22);
            this.textBoxJumperLastName.TabIndex = 10;
            // 
            // textBoxJumperCountryId
            // 
            this.textBoxJumperCountryId.Location = new System.Drawing.Point(132, 133);
            this.textBoxJumperCountryId.Name = "textBoxJumperCountryId";
            this.textBoxJumperCountryId.Size = new System.Drawing.Size(166, 22);
            this.textBoxJumperCountryId.TabIndex = 11;
            // 
            // labelCountryName
            // 
            this.labelCountryName.AutoSize = true;
            this.labelCountryName.Location = new System.Drawing.Point(470, 14);
            this.labelCountryName.Name = "labelCountryName";
            this.labelCountryName.Size = new System.Drawing.Size(85, 17);
            this.labelCountryName.TabIndex = 12;
            this.labelCountryName.Text = "Nazwa kraju";
            // 
            // labelCountryRecord
            // 
            this.labelCountryRecord.AutoSize = true;
            this.labelCountryRecord.Location = new System.Drawing.Point(466, 67);
            this.labelCountryRecord.Name = "labelCountryRecord";
            this.labelCountryRecord.Size = new System.Drawing.Size(89, 17);
            this.labelCountryRecord.TabIndex = 13;
            this.labelCountryRecord.Text = "Rekord kraju";
            // 
            // textBoxCountryName
            // 
            this.textBoxCountryName.Location = new System.Drawing.Point(598, 14);
            this.textBoxCountryName.Name = "textBoxCountryName";
            this.textBoxCountryName.Size = new System.Drawing.Size(162, 22);
            this.textBoxCountryName.TabIndex = 14;
            // 
            // textBoxCountryRecord
            // 
            this.textBoxCountryRecord.Location = new System.Drawing.Point(598, 67);
            this.textBoxCountryRecord.Name = "textBoxCountryRecord";
            this.textBoxCountryRecord.Size = new System.Drawing.Size(162, 22);
            this.textBoxCountryRecord.TabIndex = 15;
            // 
            // buttonJumperAdd
            // 
            this.buttonJumperAdd.Location = new System.Drawing.Point(132, 178);
            this.buttonJumperAdd.Name = "buttonJumperAdd";
            this.buttonJumperAdd.Size = new System.Drawing.Size(166, 23);
            this.buttonJumperAdd.TabIndex = 16;
            this.buttonJumperAdd.Text = "Dodaj skoczka";
            this.buttonJumperAdd.UseVisualStyleBackColor = true;
            // 
            // buttonCountryAdd
            // 
            this.buttonCountryAdd.Location = new System.Drawing.Point(598, 114);
            this.buttonCountryAdd.Name = "buttonCountryAdd";
            this.buttonCountryAdd.Size = new System.Drawing.Size(162, 23);
            this.buttonCountryAdd.TabIndex = 17;
            this.buttonCountryAdd.Text = "Dodaj kraj";
            this.buttonCountryAdd.UseVisualStyleBackColor = true;
            // 
            // buttonJumperDelete
            // 
            this.buttonJumperDelete.Location = new System.Drawing.Point(12, 673);
            this.buttonJumperDelete.Name = "buttonJumperDelete";
            this.buttonJumperDelete.Size = new System.Drawing.Size(150, 29);
            this.buttonJumperDelete.TabIndex = 18;
            this.buttonJumperDelete.Text = "Usuń skoczka";
            this.buttonJumperDelete.UseVisualStyleBackColor = true;
            // 
            // buttonJumperUpdate
            // 
            this.buttonJumperUpdate.Location = new System.Drawing.Point(168, 673);
            this.buttonJumperUpdate.Name = "buttonJumperUpdate";
            this.buttonJumperUpdate.Size = new System.Drawing.Size(147, 29);
            this.buttonJumperUpdate.TabIndex = 19;
            this.buttonJumperUpdate.Text = "Edytuj skoczka";
            this.buttonJumperUpdate.UseVisualStyleBackColor = true;
            this.buttonJumperUpdate.Click += new System.EventHandler(this.buttonJumperUpdate_Click);
            // 
            // buttonJumperShow
            // 
            this.buttonJumperShow.Location = new System.Drawing.Point(321, 673);
            this.buttonJumperShow.Name = "buttonJumperShow";
            this.buttonJumperShow.Size = new System.Drawing.Size(164, 29);
            this.buttonJumperShow.TabIndex = 20;
            this.buttonJumperShow.Text = "Wyświetl informacje";
            this.buttonJumperShow.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(819, 673);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(164, 29);
            this.button1.TabIndex = 23;
            this.button1.Text = "Wyświetl informacje";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(666, 673);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(147, 29);
            this.button2.TabIndex = 22;
            this.button2.Text = "Edytuj skoczka";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(510, 673);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(150, 29);
            this.button3.TabIndex = 21;
            this.button3.Text = "Usuń skoczka";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1058, 746);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.buttonJumperShow);
            this.Controls.Add(this.buttonJumperUpdate);
            this.Controls.Add(this.buttonJumperDelete);
            this.Controls.Add(this.buttonCountryAdd);
            this.Controls.Add(this.buttonJumperAdd);
            this.Controls.Add(this.textBoxCountryRecord);
            this.Controls.Add(this.textBoxCountryName);
            this.Controls.Add(this.labelCountryRecord);
            this.Controls.Add(this.labelCountryName);
            this.Controls.Add(this.textBoxJumperCountryId);
            this.Controls.Add(this.textBoxJumperLastName);
            this.Controls.Add(this.textBoxJumperFirstName);
            this.Controls.Add(this.dateTimePickerJumper);
            this.Controls.Add(this.labelJumperCountryId);
            this.Controls.Add(this.labelJumperBirthdate);
            this.Controls.Add(this.labelJumperLastName);
            this.Controls.Add(this.labelJumperFirstName);
            this.Controls.Add(this.labelAllCountries);
            this.Controls.Add(this.labelAllJumpers);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormMain";
            this.Text = "FormMain";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label labelAllJumpers;
        private System.Windows.Forms.Label labelAllCountries;
        private System.Windows.Forms.Label labelJumperFirstName;
        private System.Windows.Forms.Label labelJumperLastName;
        private System.Windows.Forms.Label labelJumperBirthdate;
        private System.Windows.Forms.Label labelJumperCountryId;
        private System.Windows.Forms.DateTimePicker dateTimePickerJumper;
        private System.Windows.Forms.TextBox textBoxJumperFirstName;
        private System.Windows.Forms.TextBox textBoxJumperLastName;
        private System.Windows.Forms.TextBox textBoxJumperCountryId;
        private System.Windows.Forms.Label labelCountryName;
        private System.Windows.Forms.Label labelCountryRecord;
        private System.Windows.Forms.TextBox textBoxCountryName;
        private System.Windows.Forms.TextBox textBoxCountryRecord;
        private System.Windows.Forms.Button buttonJumperAdd;
        private System.Windows.Forms.Button buttonCountryAdd;
        private System.Windows.Forms.Button buttonJumperDelete;
        private System.Windows.Forms.Button buttonJumperUpdate;
        private System.Windows.Forms.Button buttonJumperShow;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

