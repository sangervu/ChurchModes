namespace ChurchModes
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
            this.label1 = new System.Windows.Forms.Label();
            this.cboState = new System.Windows.Forms.ComboBox();
            this.ScaleName = new System.Windows.Forms.Label();
            this.isSharp = new System.Windows.Forms.RadioButton();
            this.isFlat = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.scaleNotes = new System.Windows.Forms.Label();
            this.isNone = new System.Windows.Forms.RadioButton();
            this.dorian = new System.Windows.Forms.Button();
            this.lydian = new System.Windows.Forms.Button();
            this.phrygian = new System.Windows.Forms.Button();
            this.key = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Heading = new System.Windows.Forms.Label();
            this.locrian = new System.Windows.Forms.Button();
            this.aeolian = new System.Windows.Forms.Button();
            this.mixoLydian = new System.Windows.Forms.Button();
            this.Intervals = new System.Windows.Forms.Label();
            this.mode = new System.Windows.Forms.Label();
            this.scaleNotesKey = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.degree_I = new System.Windows.Forms.Label();
            this.degree_IV = new System.Windows.Forms.Label();
            this.degree_V = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.ionian = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(61, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(439, 32);
            this.label1.TabIndex = 4;
            this.label1.Text = "Enter the key for the Ionian mode:";
            // 
            // cboState
            // 
            this.cboState.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cboState.FormattingEnabled = true;
            this.cboState.Location = new System.Drawing.Point(634, 104);
            this.cboState.Name = "cboState";
            this.cboState.Size = new System.Drawing.Size(83, 37);
            this.cboState.TabIndex = 5;
            this.cboState.SelectedIndexChanged += new System.EventHandler(this.cboState_SelectedIndexChanged);
            // 
            // ScaleName
            // 
            this.ScaleName.AutoSize = true;
            this.ScaleName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScaleName.Location = new System.Drawing.Point(70, 454);
            this.ScaleName.Name = "ScaleName";
            this.ScaleName.Size = new System.Drawing.Size(87, 32);
            this.ScaleName.TabIndex = 12;
            this.ScaleName.Text = "Scale";
            // 
            // isSharp
            // 
            this.isSharp.AutoSize = true;
            this.isSharp.Location = new System.Drawing.Point(737, 91);
            this.isSharp.Name = "isSharp";
            this.isSharp.Size = new System.Drawing.Size(87, 24);
            this.isSharp.TabIndex = 23;
            this.isSharp.TabStop = true;
            this.isSharp.Text = "# sharp";
            this.isSharp.UseVisualStyleBackColor = true;
            this.isSharp.CheckedChanged += new System.EventHandler(this.isSharp_CheckedChanged);
            // 
            // isFlat
            // 
            this.isFlat.AutoSize = true;
            this.isFlat.Location = new System.Drawing.Point(737, 121);
            this.isFlat.Name = "isFlat";
            this.isFlat.Size = new System.Drawing.Size(69, 24);
            this.isFlat.TabIndex = 24;
            this.isFlat.TabStop = true;
            this.isFlat.Text = "b flat";
            this.isFlat.UseVisualStyleBackColor = true;
            this.isFlat.CheckedChanged += new System.EventHandler(this.isFlat_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(72, 288);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 20);
            this.label5.TabIndex = 25;
            // 
            // scaleNotes
            // 
            this.scaleNotes.AutoSize = true;
            this.scaleNotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scaleNotes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.scaleNotes.Location = new System.Drawing.Point(308, 511);
            this.scaleNotes.Name = "scaleNotes";
            this.scaleNotes.Size = new System.Drawing.Size(409, 40);
            this.scaleNotes.TabIndex = 36;
            this.scaleNotes.Text = "Scale Notes on the key";
            // 
            // isNone
            // 
            this.isNone.AutoSize = true;
            this.isNone.Location = new System.Drawing.Point(737, 151);
            this.isNone.Name = "isNone";
            this.isNone.Size = new System.Drawing.Size(70, 24);
            this.isNone.TabIndex = 38;
            this.isNone.TabStop = true;
            this.isNone.Text = "none";
            this.isNone.UseVisualStyleBackColor = true;
            this.isNone.CheckedChanged += new System.EventHandler(this.isNone_CheckedChanged);
            // 
            // dorian
            // 
            this.dorian.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dorian.Location = new System.Drawing.Point(76, 260);
            this.dorian.Name = "dorian";
            this.dorian.Size = new System.Drawing.Size(149, 48);
            this.dorian.TabIndex = 39;
            this.dorian.Text = "Dorian";
            this.dorian.UseVisualStyleBackColor = true;
            this.dorian.Click += new System.EventHandler(this.dorian_Click);
            // 
            // lydian
            // 
            this.lydian.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lydian.Location = new System.Drawing.Point(458, 260);
            this.lydian.Name = "lydian";
            this.lydian.Size = new System.Drawing.Size(149, 48);
            this.lydian.TabIndex = 40;
            this.lydian.Text = "Lydian";
            this.lydian.UseVisualStyleBackColor = true;
            this.lydian.Click += new System.EventHandler(this.lydian_Click);
            // 
            // phrygian
            // 
            this.phrygian.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phrygian.Location = new System.Drawing.Point(265, 260);
            this.phrygian.Name = "phrygian";
            this.phrygian.Size = new System.Drawing.Size(149, 48);
            this.phrygian.TabIndex = 43;
            this.phrygian.Text = "Phrygian";
            this.phrygian.UseVisualStyleBackColor = true;
            this.phrygian.Click += new System.EventHandler(this.phrygian_Click);
            // 
            // key
            // 
            this.key.AutoSize = true;
            this.key.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.key.ForeColor = System.Drawing.Color.Maroon;
            this.key.Location = new System.Drawing.Point(861, 125);
            this.key.Name = "key";
            this.key.Size = new System.Drawing.Size(53, 29);
            this.key.TabIndex = 44;
            this.key.Text = "key";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(861, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 25);
            this.label3.TabIndex = 45;
            this.label3.Text = "Key";
            // 
            // Heading
            // 
            this.Heading.AutoSize = true;
            this.Heading.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Heading.Location = new System.Drawing.Point(63, 29);
            this.Heading.Name = "Heading";
            this.Heading.Size = new System.Drawing.Size(238, 37);
            this.Heading.TabIndex = 46;
            this.Heading.Text = "Church modes";
            // 
            // locrian
            // 
            this.locrian.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.locrian.Location = new System.Drawing.Point(458, 332);
            this.locrian.Name = "locrian";
            this.locrian.Size = new System.Drawing.Size(149, 48);
            this.locrian.TabIndex = 47;
            this.locrian.Text = "Locrian";
            this.locrian.UseVisualStyleBackColor = true;
            this.locrian.Click += new System.EventHandler(this.locrian_Click);
            // 
            // aeolian
            // 
            this.aeolian.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aeolian.Location = new System.Drawing.Point(265, 332);
            this.aeolian.Name = "aeolian";
            this.aeolian.Size = new System.Drawing.Size(149, 48);
            this.aeolian.TabIndex = 48;
            this.aeolian.Text = "Aeolian";
            this.aeolian.UseVisualStyleBackColor = true;
            this.aeolian.Click += new System.EventHandler(this.aeolian_Click);
            // 
            // mixoLydian
            // 
            this.mixoLydian.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mixoLydian.Location = new System.Drawing.Point(76, 332);
            this.mixoLydian.Name = "mixoLydian";
            this.mixoLydian.Size = new System.Drawing.Size(149, 48);
            this.mixoLydian.TabIndex = 49;
            this.mixoLydian.Text = "Mixolydian";
            this.mixoLydian.UseVisualStyleBackColor = true;
            this.mixoLydian.Click += new System.EventHandler(this.mixoLydian_Click);
            // 
            // Intervals
            // 
            this.Intervals.AutoSize = true;
            this.Intervals.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Intervals.Location = new System.Drawing.Point(319, 457);
            this.Intervals.Name = "Intervals";
            this.Intervals.Size = new System.Drawing.Size(111, 29);
            this.Intervals.TabIndex = 27;
            this.Intervals.Text = "Intervals";
            // 
            // mode
            // 
            this.mode.AutoSize = true;
            this.mode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mode.Location = new System.Drawing.Point(219, 460);
            this.mode.Name = "mode";
            this.mode.Size = new System.Drawing.Size(75, 29);
            this.mode.TabIndex = 50;
            this.mode.Text = "Mode";
            // 
            // scaleNotesKey
            // 
            this.scaleNotesKey.AutoSize = true;
            this.scaleNotesKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scaleNotesKey.ForeColor = System.Drawing.Color.Maroon;
            this.scaleNotesKey.Location = new System.Drawing.Point(308, 602);
            this.scaleNotesKey.Name = "scaleNotesKey";
            this.scaleNotesKey.Size = new System.Drawing.Size(468, 40);
            this.scaleNotesKey.TabIndex = 51;
            this.scaleNotesKey.Text = "Scale Notes on the degree";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(72, 521);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(230, 29);
            this.label2.TabIndex = 52;
            this.label2.Text = "Scale on the degree";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(72, 612);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(189, 29);
            this.label4.TabIndex = 53;
            this.label4.Text = "Scale on the key";
            // 
            // degree_I
            // 
            this.degree_I.AutoSize = true;
            this.degree_I.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.degree_I.ForeColor = System.Drawing.Color.Maroon;
            this.degree_I.Location = new System.Drawing.Point(146, 679);
            this.degree_I.Name = "degree_I";
            this.degree_I.Size = new System.Drawing.Size(26, 37);
            this.degree_I.TabIndex = 56;
            this.degree_I.Text = "I";
            // 
            // degree_IV
            // 
            this.degree_IV.AutoSize = true;
            this.degree_IV.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.degree_IV.ForeColor = System.Drawing.Color.Maroon;
            this.degree_IV.Location = new System.Drawing.Point(366, 678);
            this.degree_IV.Name = "degree_IV";
            this.degree_IV.Size = new System.Drawing.Size(49, 37);
            this.degree_IV.TabIndex = 57;
            this.degree_IV.Text = "IV";
            // 
            // degree_V
            // 
            this.degree_V.AutoSize = true;
            this.degree_V.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.degree_V.ForeColor = System.Drawing.Color.Maroon;
            this.degree_V.Location = new System.Drawing.Point(566, 678);
            this.degree_V.Name = "degree_V";
            this.degree_V.Size = new System.Drawing.Size(40, 37);
            this.degree_V.TabIndex = 58;
            this.degree_V.Text = "V";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(72, 684);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 29);
            this.label7.TabIndex = 59;
            this.label7.Text = "Tonic:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(208, 684);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(161, 29);
            this.label8.TabIndex = 60;
            this.label8.Text = "Subdominant:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(446, 684);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(121, 29);
            this.label9.TabIndex = 61;
            this.label9.Text = "Dominant:";
            // 
            // ionian
            // 
            this.ionian.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ionian.Location = new System.Drawing.Point(76, 183);
            this.ionian.Name = "ionian";
            this.ionian.Size = new System.Drawing.Size(149, 48);
            this.ionian.TabIndex = 62;
            this.ionian.Text = "Ionian";
            this.ionian.UseVisualStyleBackColor = true;
            this.ionian.Click += new System.EventHandler(this.ionian_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1224, 772);
            this.Controls.Add(this.ionian);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.degree_V);
            this.Controls.Add(this.degree_IV);
            this.Controls.Add(this.degree_I);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.scaleNotesKey);
            this.Controls.Add(this.mode);
            this.Controls.Add(this.mixoLydian);
            this.Controls.Add(this.aeolian);
            this.Controls.Add(this.locrian);
            this.Controls.Add(this.Heading);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.key);
            this.Controls.Add(this.phrygian);
            this.Controls.Add(this.lydian);
            this.Controls.Add(this.dorian);
            this.Controls.Add(this.isNone);
            this.Controls.Add(this.scaleNotes);
            this.Controls.Add(this.Intervals);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.isFlat);
            this.Controls.Add(this.isSharp);
            this.Controls.Add(this.ScaleName);
            this.Controls.Add(this.cboState);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.Name = "Form1";
            this.Text = "Curch modes for New Jazz";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboState;
        private System.Windows.Forms.Label ScaleName;
        private System.Windows.Forms.RadioButton isSharp;
        private System.Windows.Forms.RadioButton isFlat;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label scaleNotes;
        private System.Windows.Forms.RadioButton isNone;
        private System.Windows.Forms.Button dorian;
        private System.Windows.Forms.Button lydian;
        private System.Windows.Forms.Button phrygian;
        private System.Windows.Forms.Label key;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Heading;
        private System.Windows.Forms.Button locrian;
        private System.Windows.Forms.Button aeolian;
        private System.Windows.Forms.Button mixoLydian;
        private System.Windows.Forms.Label Intervals;
        private System.Windows.Forms.Label mode;
        private System.Windows.Forms.Label scaleNotesKey;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label degree_I;
        private System.Windows.Forms.Label degree_IV;
        private System.Windows.Forms.Label degree_V;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button ionian;
    }
}

