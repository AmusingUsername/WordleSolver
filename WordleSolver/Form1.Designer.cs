namespace WordleSolver
{
    partial class FormWordleSolver
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
            this.buttonSolve = new System.Windows.Forms.Button();
            this.textBoxGoodLetters = new System.Windows.Forms.TextBox();
            this.textBoxLetters = new System.Windows.Forms.TextBox();
            this.radioButtonGoodLetters = new System.Windows.Forms.RadioButton();
            this.radioButtonBadLetters = new System.Windows.Forms.RadioButton();
            this.labelGoodLetters = new System.Windows.Forms.Label();
            this.labelGoodInstructions = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxSolutions = new System.Windows.Forms.TextBox();
            this.labelSolutions = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonSolve
            // 
            this.buttonSolve.Location = new System.Drawing.Point(451, 100);
            this.buttonSolve.Name = "buttonSolve";
            this.buttonSolve.Size = new System.Drawing.Size(75, 23);
            this.buttonSolve.TabIndex = 0;
            this.buttonSolve.Text = "Solve";
            this.buttonSolve.UseVisualStyleBackColor = true;
            this.buttonSolve.Click += new System.EventHandler(this.buttonSolve_Click);
            // 
            // textBoxGoodLetters
            // 
            this.textBoxGoodLetters.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxGoodLetters.Location = new System.Drawing.Point(12, 95);
            this.textBoxGoodLetters.MaxLength = 5;
            this.textBoxGoodLetters.Name = "textBoxGoodLetters";
            this.textBoxGoodLetters.Size = new System.Drawing.Size(144, 22);
            this.textBoxGoodLetters.TabIndex = 1;
            this.textBoxGoodLetters.TextChanged += new System.EventHandler(this.textBoxGoodLetters_TextChanged);
            // 
            // textBoxLetters
            // 
            this.textBoxLetters.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxLetters.Location = new System.Drawing.Point(12, 39);
            this.textBoxLetters.MaxLength = 26;
            this.textBoxLetters.Name = "textBoxLetters";
            this.textBoxLetters.Size = new System.Drawing.Size(514, 22);
            this.textBoxLetters.TabIndex = 2;
            this.textBoxLetters.TextChanged += new System.EventHandler(this.textBoxLetters_TextChanged);
            // 
            // radioButtonGoodLetters
            // 
            this.radioButtonGoodLetters.AutoSize = true;
            this.radioButtonGoodLetters.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonGoodLetters.ForeColor = System.Drawing.SystemColors.ControlText;
            this.radioButtonGoodLetters.Location = new System.Drawing.Point(12, 12);
            this.radioButtonGoodLetters.Name = "radioButtonGoodLetters";
            this.radioButtonGoodLetters.Size = new System.Drawing.Size(148, 21);
            this.radioButtonGoodLetters.TabIndex = 3;
            this.radioButtonGoodLetters.Text = "Remaining Letters:";
            this.radioButtonGoodLetters.UseVisualStyleBackColor = true;
            this.radioButtonGoodLetters.CheckedChanged += new System.EventHandler(this.radioButtonGoodLetters_CheckedChanged);
            // 
            // radioButtonBadLetters
            // 
            this.radioButtonBadLetters.AutoSize = true;
            this.radioButtonBadLetters.Checked = true;
            this.radioButtonBadLetters.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonBadLetters.Location = new System.Drawing.Point(184, 12);
            this.radioButtonBadLetters.Name = "radioButtonBadLetters";
            this.radioButtonBadLetters.Size = new System.Drawing.Size(170, 21);
            this.radioButtonBadLetters.TabIndex = 4;
            this.radioButtonBadLetters.TabStop = true;
            this.radioButtonBadLetters.Text = "Known Bad Letters:";
            this.radioButtonBadLetters.UseVisualStyleBackColor = true;
            this.radioButtonBadLetters.CheckedChanged += new System.EventHandler(this.radioButtonBadLetters_CheckedChanged);
            // 
            // labelGoodLetters
            // 
            this.labelGoodLetters.AutoSize = true;
            this.labelGoodLetters.Location = new System.Drawing.Point(9, 75);
            this.labelGoodLetters.Name = "labelGoodLetters";
            this.labelGoodLetters.Size = new System.Drawing.Size(91, 17);
            this.labelGoodLetters.TabIndex = 5;
            this.labelGoodLetters.Text = "Good Letters";
            // 
            // labelGoodInstructions
            // 
            this.labelGoodInstructions.AutoSize = true;
            this.labelGoodInstructions.Location = new System.Drawing.Point(247, 98);
            this.labelGoodInstructions.Name = "labelGoodInstructions";
            this.labelGoodInstructions.Size = new System.Drawing.Size(270, 17);
            this.labelGoodInstructions.TabIndex = 6;
            this.labelGoodInstructions.Text = "(X = eliminated, Y = match,  ? = unknown)";
            this.labelGoodInstructions.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBox1.Location = new System.Drawing.Point(36, 123);
            this.textBox1.MaxLength = 5;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(120, 22);
            this.textBox1.TabIndex = 7;
            this.textBox1.Text = "?????";
            this.textBox1.Visible = false;
            this.textBox1.TextChanged += new System.EventHandler(this.textBoxGoodPositions_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "W:";
            this.label1.Visible = false;
            // 
            // textBox3
            // 
            this.textBox3.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBox3.Location = new System.Drawing.Point(36, 179);
            this.textBox3.MaxLength = 5;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(120, 22);
            this.textBox3.TabIndex = 9;
            this.textBox3.Text = "?????";
            this.textBox3.Visible = false;
            this.textBox3.TextChanged += new System.EventHandler(this.textBoxGoodPositions_TextChanged);
            // 
            // textBox4
            // 
            this.textBox4.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBox4.Location = new System.Drawing.Point(36, 207);
            this.textBox4.MaxLength = 5;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(120, 22);
            this.textBox4.TabIndex = 10;
            this.textBox4.Text = "?????";
            this.textBox4.Visible = false;
            this.textBox4.TextChanged += new System.EventHandler(this.textBoxGoodPositions_TextChanged);
            // 
            // textBox5
            // 
            this.textBox5.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBox5.Location = new System.Drawing.Point(36, 235);
            this.textBox5.MaxLength = 5;
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(120, 22);
            this.textBox5.TabIndex = 11;
            this.textBox5.Text = "?????";
            this.textBox5.Visible = false;
            this.textBox5.TextChanged += new System.EventHandler(this.textBoxGoodPositions_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBox2.Location = new System.Drawing.Point(36, 151);
            this.textBox2.MaxLength = 5;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(120, 22);
            this.textBox2.TabIndex = 12;
            this.textBox2.Text = "?????";
            this.textBox2.Visible = false;
            this.textBox2.TextChanged += new System.EventHandler(this.textBoxGoodPositions_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "W:";
            this.label2.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 17);
            this.label3.TabIndex = 14;
            this.label3.Text = "W:";
            this.label3.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(8, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 17);
            this.label4.TabIndex = 15;
            this.label4.Text = "W:";
            this.label4.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(9, 238);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 17);
            this.label5.TabIndex = 16;
            this.label5.Text = "W:";
            this.label5.Visible = false;
            // 
            // textBoxSolutions
            // 
            this.textBoxSolutions.Location = new System.Drawing.Point(11, 298);
            this.textBoxSolutions.Multiline = true;
            this.textBoxSolutions.Name = "textBoxSolutions";
            this.textBoxSolutions.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxSolutions.Size = new System.Drawing.Size(515, 243);
            this.textBoxSolutions.TabIndex = 17;
            // 
            // labelSolutions
            // 
            this.labelSolutions.AutoSize = true;
            this.labelSolutions.Location = new System.Drawing.Point(8, 278);
            this.labelSolutions.Name = "labelSolutions";
            this.labelSolutions.Size = new System.Drawing.Size(125, 17);
            this.labelSolutions.TabIndex = 18;
            this.labelSolutions.Text = "Potential Solutions";
            // 
            // FormWordleSolver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 553);
            this.Controls.Add(this.labelSolutions);
            this.Controls.Add(this.textBoxSolutions);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.labelGoodLetters);
            this.Controls.Add(this.radioButtonBadLetters);
            this.Controls.Add(this.radioButtonGoodLetters);
            this.Controls.Add(this.textBoxLetters);
            this.Controls.Add(this.textBoxGoodLetters);
            this.Controls.Add(this.buttonSolve);
            this.Controls.Add(this.labelGoodInstructions);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormWordleSolver";
            this.Text = "Wordle Solver";
            this.Shown += new System.EventHandler(this.FormWordleSolver_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSolve;
        private System.Windows.Forms.TextBox textBoxGoodLetters;
        private System.Windows.Forms.TextBox textBoxLetters;
        private System.Windows.Forms.RadioButton radioButtonGoodLetters;
        private System.Windows.Forms.RadioButton radioButtonBadLetters;
        private System.Windows.Forms.Label labelGoodLetters;
        private System.Windows.Forms.Label labelGoodInstructions;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxSolutions;
        private System.Windows.Forms.Label labelSolutions;
    }
}

