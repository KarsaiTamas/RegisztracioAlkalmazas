namespace RegisztracioAlkalmazas
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
            this.Nev_Label = new System.Windows.Forms.Label();
            this.Szul_Cim_Label = new System.Windows.Forms.Label();
            this.Nem_Label = new System.Windows.Forms.Label();
            this.Ferfi_RadioButton = new System.Windows.Forms.RadioButton();
            this.No_RadioButton = new System.Windows.Forms.RadioButton();
            this.Nev_TextBox = new System.Windows.Forms.TextBox();
            this.Kedvenc_Hobbi_Label = new System.Windows.Forms.Label();
            this.Uj_Hobbi_Label = new System.Windows.Forms.Label();
            this.Uj_Hobbi_TextBox = new System.Windows.Forms.TextBox();
            this.Hozzaad_Button = new System.Windows.Forms.Button();
            this.Betolt_Button = new System.Windows.Forms.Button();
            this.Ment_Button = new System.Windows.Forms.Button();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.Hobbik_ListBox = new System.Windows.Forms.ListBox();
            this.Szul_DateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // Nev_Label
            // 
            this.Nev_Label.AutoSize = true;
            this.Nev_Label.Location = new System.Drawing.Point(13, 13);
            this.Nev_Label.Name = "Nev_Label";
            this.Nev_Label.Size = new System.Drawing.Size(30, 13);
            this.Nev_Label.TabIndex = 0;
            this.Nev_Label.Text = "Név:";
            // 
            // Szul_Cim_Label
            // 
            this.Szul_Cim_Label.AutoSize = true;
            this.Szul_Cim_Label.Location = new System.Drawing.Point(13, 41);
            this.Szul_Cim_Label.Name = "Szul_Cim_Label";
            this.Szul_Cim_Label.Size = new System.Drawing.Size(54, 13);
            this.Szul_Cim_Label.TabIndex = 1;
            this.Szul_Cim_Label.Text = "Szül. cím:";
            // 
            // Nem_Label
            // 
            this.Nem_Label.AutoSize = true;
            this.Nem_Label.Location = new System.Drawing.Point(13, 74);
            this.Nem_Label.Name = "Nem_Label";
            this.Nem_Label.Size = new System.Drawing.Size(32, 13);
            this.Nem_Label.TabIndex = 2;
            this.Nem_Label.Text = "Nem:";
            // 
            // Ferfi_RadioButton
            // 
            this.Ferfi_RadioButton.AutoSize = true;
            this.Ferfi_RadioButton.Location = new System.Drawing.Point(94, 74);
            this.Ferfi_RadioButton.Name = "Ferfi_RadioButton";
            this.Ferfi_RadioButton.Size = new System.Drawing.Size(31, 17);
            this.Ferfi_RadioButton.TabIndex = 3;
            this.Ferfi_RadioButton.TabStop = true;
            this.Ferfi_RadioButton.Text = "F";
            this.Ferfi_RadioButton.UseVisualStyleBackColor = true;
            // 
            // No_RadioButton
            // 
            this.No_RadioButton.AutoSize = true;
            this.No_RadioButton.Location = new System.Drawing.Point(161, 74);
            this.No_RadioButton.Name = "No_RadioButton";
            this.No_RadioButton.Size = new System.Drawing.Size(33, 17);
            this.No_RadioButton.TabIndex = 4;
            this.No_RadioButton.TabStop = true;
            this.No_RadioButton.Text = "N";
            this.No_RadioButton.UseVisualStyleBackColor = true;
            // 
            // Nev_TextBox
            // 
            this.Nev_TextBox.Location = new System.Drawing.Point(94, 10);
            this.Nev_TextBox.Name = "Nev_TextBox";
            this.Nev_TextBox.Size = new System.Drawing.Size(100, 20);
            this.Nev_TextBox.TabIndex = 6;
            // 
            // Kedvenc_Hobbi_Label
            // 
            this.Kedvenc_Hobbi_Label.AutoSize = true;
            this.Kedvenc_Hobbi_Label.Location = new System.Drawing.Point(200, 13);
            this.Kedvenc_Hobbi_Label.Name = "Kedvenc_Hobbi_Label";
            this.Kedvenc_Hobbi_Label.Size = new System.Drawing.Size(82, 13);
            this.Kedvenc_Hobbi_Label.TabIndex = 8;
            this.Kedvenc_Hobbi_Label.Text = "Kedvenc hobbi:";
            // 
            // Uj_Hobbi_Label
            // 
            this.Uj_Hobbi_Label.AutoSize = true;
            this.Uj_Hobbi_Label.Location = new System.Drawing.Point(128, 143);
            this.Uj_Hobbi_Label.Name = "Uj_Hobbi_Label";
            this.Uj_Hobbi_Label.Size = new System.Drawing.Size(49, 13);
            this.Uj_Hobbi_Label.TabIndex = 9;
            this.Uj_Hobbi_Label.Text = "Új hobbi:";
            // 
            // Uj_Hobbi_TextBox
            // 
            this.Uj_Hobbi_TextBox.Location = new System.Drawing.Point(199, 140);
            this.Uj_Hobbi_TextBox.Name = "Uj_Hobbi_TextBox";
            this.Uj_Hobbi_TextBox.Size = new System.Drawing.Size(120, 20);
            this.Uj_Hobbi_TextBox.TabIndex = 10;
            // 
            // Hozzaad_Button
            // 
            this.Hozzaad_Button.Location = new System.Drawing.Point(245, 177);
            this.Hozzaad_Button.Name = "Hozzaad_Button";
            this.Hozzaad_Button.Size = new System.Drawing.Size(75, 23);
            this.Hozzaad_Button.TabIndex = 11;
            this.Hozzaad_Button.Text = "Hozzáad";
            this.Hozzaad_Button.UseVisualStyleBackColor = true;
            // 
            // Betolt_Button
            // 
            this.Betolt_Button.Location = new System.Drawing.Point(245, 217);
            this.Betolt_Button.Name = "Betolt_Button";
            this.Betolt_Button.Size = new System.Drawing.Size(75, 23);
            this.Betolt_Button.TabIndex = 12;
            this.Betolt_Button.Text = "Betöltés";
            this.Betolt_Button.UseVisualStyleBackColor = true;
            // 
            // Ment_Button
            // 
            this.Ment_Button.Location = new System.Drawing.Point(161, 217);
            this.Ment_Button.Name = "Ment_Button";
            this.Ment_Button.Size = new System.Drawing.Size(75, 23);
            this.Ment_Button.TabIndex = 13;
            this.Ment_Button.Text = "Mentés";
            this.Ment_Button.UseVisualStyleBackColor = true;
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.Filter = "szöveges dukumentum|*.txt|minden file|*.*";
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            this.openFileDialog.Filter = "szöveges dukumentum|*.txt|minden file|*.*";
            // 
            // Hobbik_ListBox
            // 
            this.Hobbik_ListBox.FormattingEnabled = true;
            this.Hobbik_ListBox.Items.AddRange(new object[] {
            "Uszás",
            "Horgászat",
            "Futás"});
            this.Hobbik_ListBox.Location = new System.Drawing.Point(199, 29);
            this.Hobbik_ListBox.Name = "Hobbik_ListBox";
            this.Hobbik_ListBox.Size = new System.Drawing.Size(120, 95);
            this.Hobbik_ListBox.TabIndex = 14;
            // 
            // Szul_DateTimePicker
            // 
            this.Szul_DateTimePicker.Location = new System.Drawing.Point(82, 41);
            this.Szul_DateTimePicker.Name = "Szul_DateTimePicker";
            this.Szul_DateTimePicker.Size = new System.Drawing.Size(111, 20);
            this.Szul_DateTimePicker.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 252);
            this.Controls.Add(this.Szul_DateTimePicker);
            this.Controls.Add(this.Hobbik_ListBox);
            this.Controls.Add(this.Ment_Button);
            this.Controls.Add(this.Betolt_Button);
            this.Controls.Add(this.Hozzaad_Button);
            this.Controls.Add(this.Uj_Hobbi_TextBox);
            this.Controls.Add(this.Uj_Hobbi_Label);
            this.Controls.Add(this.Kedvenc_Hobbi_Label);
            this.Controls.Add(this.Nev_TextBox);
            this.Controls.Add(this.No_RadioButton);
            this.Controls.Add(this.Ferfi_RadioButton);
            this.Controls.Add(this.Nem_Label);
            this.Controls.Add(this.Szul_Cim_Label);
            this.Controls.Add(this.Nev_Label);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Nev_Label;
        private System.Windows.Forms.Label Szul_Cim_Label;
        private System.Windows.Forms.Label Nem_Label;
        private System.Windows.Forms.RadioButton Ferfi_RadioButton;
        private System.Windows.Forms.RadioButton No_RadioButton;
        private System.Windows.Forms.TextBox Nev_TextBox;
        private System.Windows.Forms.Label Kedvenc_Hobbi_Label;
        private System.Windows.Forms.Label Uj_Hobbi_Label;
        private System.Windows.Forms.TextBox Uj_Hobbi_TextBox;
        private System.Windows.Forms.Button Hozzaad_Button;
        private System.Windows.Forms.Button Betolt_Button;
        private System.Windows.Forms.Button Ment_Button;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.ListBox Hobbik_ListBox;
        private System.Windows.Forms.DateTimePicker Szul_DateTimePicker;
    }
}

