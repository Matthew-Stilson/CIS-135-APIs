namespace StarWarsAPI
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
            planetRadioButton = new RadioButton();
            personRadioButton = new RadioButton();
            oneSpeciesRadioButton = new RadioButton();
            allSpeciesRadioButton = new RadioButton();
            generateButton = new Button();
            informationListBox = new ListBox();
            idTextBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // planetRadioButton
            // 
            planetRadioButton.AutoSize = true;
            planetRadioButton.Location = new Point(68, 242);
            planetRadioButton.Name = "planetRadioButton";
            planetRadioButton.Size = new Size(71, 24);
            planetRadioButton.TabIndex = 0;
            planetRadioButton.TabStop = true;
            planetRadioButton.Text = "Planet";
            planetRadioButton.UseVisualStyleBackColor = true;
            // 
            // personRadioButton
            // 
            personRadioButton.AutoSize = true;
            personRadioButton.Location = new Point(185, 242);
            personRadioButton.Name = "personRadioButton";
            personRadioButton.Size = new Size(73, 24);
            personRadioButton.TabIndex = 1;
            personRadioButton.TabStop = true;
            personRadioButton.Text = "Person";
            personRadioButton.UseVisualStyleBackColor = true;
            // 
            // oneSpeciesRadioButton
            // 
            oneSpeciesRadioButton.AutoSize = true;
            oneSpeciesRadioButton.Location = new Point(68, 281);
            oneSpeciesRadioButton.Name = "oneSpeciesRadioButton";
            oneSpeciesRadioButton.Size = new Size(111, 24);
            oneSpeciesRadioButton.TabIndex = 2;
            oneSpeciesRadioButton.TabStop = true;
            oneSpeciesRadioButton.Text = "One Species";
            oneSpeciesRadioButton.UseVisualStyleBackColor = true;
            // 
            // allSpeciesRadioButton
            // 
            allSpeciesRadioButton.AutoSize = true;
            allSpeciesRadioButton.Location = new Point(185, 281);
            allSpeciesRadioButton.Name = "allSpeciesRadioButton";
            allSpeciesRadioButton.Size = new Size(102, 24);
            allSpeciesRadioButton.TabIndex = 3;
            allSpeciesRadioButton.TabStop = true;
            allSpeciesRadioButton.Text = "All Species";
            allSpeciesRadioButton.UseVisualStyleBackColor = true;
            // 
            // generateButton
            // 
            generateButton.Location = new Point(85, 334);
            generateButton.Name = "generateButton";
            generateButton.Size = new Size(164, 29);
            generateButton.TabIndex = 4;
            generateButton.Text = "Generate Information";
            generateButton.UseVisualStyleBackColor = true;
            generateButton.Click += generateButton_Click;
            // 
            // informationListBox
            // 
            informationListBox.FormattingEnabled = true;
            informationListBox.Location = new Point(347, 61);
            informationListBox.Name = "informationListBox";
            informationListBox.Size = new Size(426, 364);
            informationListBox.TabIndex = 5;
            // 
            // idTextBox
            // 
            idTextBox.Location = new Point(109, 181);
            idTextBox.Name = "idTextBox";
            idTextBox.Size = new Size(125, 27);
            idTextBox.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(241, 24);
            label1.Name = "label1";
            label1.Size = new Size(317, 20);
            label1.TabIndex = 7;
            label1.Text = "Welcome to the Star Wars Information Station!";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(55, 122);
            label2.Name = "label2";
            label2.Size = new Size(242, 20);
            label2.TabIndex = 8;
            label2.Text = "Enter an ID (except for All Species):";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(idTextBox);
            Controls.Add(informationListBox);
            Controls.Add(generateButton);
            Controls.Add(allSpeciesRadioButton);
            Controls.Add(oneSpeciesRadioButton);
            Controls.Add(personRadioButton);
            Controls.Add(planetRadioButton);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RadioButton planetRadioButton;
        private RadioButton personRadioButton;
        private RadioButton oneSpeciesRadioButton;
        private RadioButton allSpeciesRadioButton;
        private Button generateButton;
        private ListBox informationListBox;
        private TextBox idTextBox;
        private Label label1;
        private Label label2;
    }
}
