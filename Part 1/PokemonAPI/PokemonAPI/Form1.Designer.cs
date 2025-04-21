namespace PokemonAPI
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
            generatePokemonButton = new Button();
            pokemonListBox = new ListBox();
            pokemonInputBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // generatePokemonButton
            // 
            generatePokemonButton.Location = new Point(88, 219);
            generatePokemonButton.Name = "generatePokemonButton";
            generatePokemonButton.Size = new Size(166, 29);
            generatePokemonButton.TabIndex = 1;
            generatePokemonButton.Text = "Generate Information";
            generatePokemonButton.UseVisualStyleBackColor = true;
            generatePokemonButton.Click += generatePokemonButton_Click;
            // 
            // pokemonListBox
            // 
            pokemonListBox.FormattingEnabled = true;
            pokemonListBox.HorizontalExtent = 50;
            pokemonListBox.HorizontalScrollbar = true;
            pokemonListBox.Location = new Point(332, 87);
            pokemonListBox.Name = "pokemonListBox";
            pokemonListBox.SelectionMode = SelectionMode.None;
            pokemonListBox.Size = new Size(411, 284);
            pokemonListBox.TabIndex = 2;
            // 
            // pokemonInputBox
            // 
            pokemonInputBox.Location = new Point(88, 186);
            pokemonInputBox.Name = "pokemonInputBox";
            pokemonInputBox.Size = new Size(166, 27);
            pokemonInputBox.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(71, 151);
            label1.Name = "label1";
            label1.Size = new Size(204, 20);
            label1.TabIndex = 4;
            label1.Text = "Enter a Pokemon Name or ID:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(237, 36);
            label2.Name = "label2";
            label2.Size = new Size(316, 20);
            label2.TabIndex = 5;
            label2.Text = "Welcome to the Pokemon Information Station!";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pokemonInputBox);
            Controls.Add(pokemonListBox);
            Controls.Add(generatePokemonButton);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button generatePokemonButton;
        private ListBox pokemonListBox;
        private TextBox pokemonInputBox;
        private Label label1;
        private Label label2;
    }
}
