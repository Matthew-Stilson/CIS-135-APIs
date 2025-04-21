using PokeAPI;

namespace PokemonAPI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /*Allows a user to specify either a pokemon name or ID number, then passes the name/number to the GeneratePokemon method.
          This is accomplished by first trying a number, then a name.
          If neither can be found, an error message box is shown instead.
        */ 
        private async void generatePokemonButton_Click(object sender, EventArgs e)
        {
            pokemonListBox.Items.Clear();
            string pokemonInput = pokemonInputBox.Text;
            try
            {
                PokemonSpecies pokemon = await DataFetcher.GetApiObject<PokemonSpecies>(Convert.ToInt32(pokemonInput));
                GeneratePokemon(pokemon);
            }
            catch
            {
                try
                {
                    PokemonSpecies pokemon = await DataFetcher.GetNamedApiObject<PokemonSpecies>(pokemonInput);
                    GeneratePokemon(pokemon);
                }
                catch
                {
                    MessageBox.Show("Please enter either a Pokemon name or ID number.");
                }
            }
        }

        //Shows pokemon information. It is given a name/ID when the generatePokemonButton is clicked.
        public void GeneratePokemon(PokemonSpecies pokemon)
        {
            string flavorText;

            pokemonListBox.Items.Add("Name: " + pokemon.Name.ToUpper());
            pokemonListBox.Items.Add("ID Number: " + pokemon.ID.ToString());
            pokemonListBox.Items.Add("Base Happiness: " + pokemon.BaseHappiness.ToString());
            pokemonListBox.Items.Add("Capture Rate: " + pokemon.CaptureRate.ToString());
            try
            {
                pokemonListBox.Items.Add("Habitat: " + pokemon.Habitat.Name.ToUpper());
            }
            catch
            {
                pokemonListBox.Items.Add("Habitat: UNKNOWN");
            }
            pokemonListBox.Items.Add("Growth Rate: " + pokemon.GrowthRate.Name.ToUpper());
            pokemonListBox.Items.Add("Egg Group 1: " + pokemon.EggGroups[0].Name.ToUpper());

            //Displays a second egg group if the pokemon has one. Otherwise, displays "NONE".
            try
            {
                pokemonListBox.Items.Add("Egg Group 2: " + pokemon.EggGroups[1].Name.ToUpper());
            }
            catch
            {
                pokemonListBox.Items.Add("Egg Group 2: NONE");
            }

            //Adds a flavor text and only displays 6 words per line.
            pokemonListBox.Items.Add("");
            pokemonListBox.Items.Add("Flavor Text:");
            flavorText = pokemon.FlavorTexts[0].FlavorText;
            if (flavorText.Length > 6)
            {
                string[] flavorTextSentences = flavorText.Split(' ');
                for (int i = 0; i < flavorTextSentences.Length; i += 6)
                {
                    int count = Math.Min(6, flavorTextSentences.Length - i);
                    var flavorTextSegment = new ArraySegment<string>(flavorTextSentences, i, count);
                    pokemonListBox.Items.Add(string.Join(" ", flavorTextSegment));
                }
            }
            else
            {
                pokemonListBox.Items.Add(flavorText);
            }
        }
    }
}
