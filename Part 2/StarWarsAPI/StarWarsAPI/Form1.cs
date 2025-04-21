using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace StarWarsAPI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Lists different information depending on which of four radio buttons is active.
        private async void generateButton_Click(object sender, EventArgs e)
        {
            informationListBox.Items.Clear();

            if (planetRadioButton.Checked)
            {
                GeneratePlanet();
            }
            else if (personRadioButton.Checked)
            {
                GeneratePerson();
            }
            else if (oneSpeciesRadioButton.Checked)
            {
                GenerateOneSpecies();
            }
            else if (allSpeciesRadioButton.Checked)
            {
                GenerateAllSpecies();
            }
        }

        public async void GeneratePlanet()
        {
            string planetID = idTextBox.Text;
            long checkInteger = 0;
            bool isNumeric = long.TryParse(planetID, out checkInteger);

            //Ensures that the input is numeric, then checks if the ID is in the applicable range, before listing planet information.
            if (isNumeric == true)
            {
                if (Convert.ToInt32(planetID) >= 1 && Convert.ToInt32(planetID) <= 61)
                {
                    Planet userPlanet = await JSONHelper.ListPlanetInfo(planetID);
                    informationListBox.Items.Add("Name: " + userPlanet.name);
                    informationListBox.Items.Add("Rotation Period: " + userPlanet.rotation_period + " hours");
                    informationListBox.Items.Add("Orbital Period: " + userPlanet.orbital_period + " days");
                    informationListBox.Items.Add("Diameter: " + userPlanet.diameter + " kilometers");
                    informationListBox.Items.Add("Climate: " + userPlanet.climate);
                    informationListBox.Items.Add("Gravity: " + userPlanet.gravity + " Gs");
                    informationListBox.Items.Add("Terrain: " + userPlanet.terrain);
                    informationListBox.Items.Add("Surface Water: " + userPlanet.surface_water + "%");
                    informationListBox.Items.Add("Population: " + userPlanet.population);
                }
                else
                {
                    MessageBox.Show("For planets, the valid ID range is 1 through 61");
                }
            }
            else
            {
                MessageBox.Show("Please enter only an ID number.");
            }
        }
        public async void GeneratePerson()
        {
            string personID = idTextBox.Text;
            string planetID = "";
            string starshipID = "";
            long checkInteger = 0;
            bool isNumeric = long.TryParse(personID, out checkInteger);

            //Ensures that the input is numeric, then checks if the ID is in the applicable range, before listing person information.
            if (isNumeric == true)
            {
                if (Convert.ToInt32(personID) >= 1 && Convert.ToInt32(personID) <= 87)
                {
                    Person userPerson = await JSONHelper.ListPersonInfo(personID);
                    informationListBox.Items.Add("Name: " + userPerson.name);
                    informationListBox.Items.Add("Height: " + userPerson.height + " centimeters");
                    informationListBox.Items.Add("Mass: " + userPerson.mass + " kilograms");
                    informationListBox.Items.Add("Hair Color: " + userPerson.hair_color);
                    informationListBox.Items.Add("Skin Color: " + userPerson.skin_color);
                    informationListBox.Items.Add("Eye Color: " + userPerson.eye_color);
                    informationListBox.Items.Add("Birth Year: " + userPerson.birth_year);
                    informationListBox.Items.Add("Gender: " + userPerson.gender);

                    //Generates the homeworld by pulling the planetID from the end of the given URI, then finding the associated planet name.
                    Uri homeworldURI = new Uri(userPerson.homeworld);
                    planetID = homeworldURI.Segments.LastOrDefault();
                    Planet userPlanet = await JSONHelper.ListPlanetInfo(planetID);
                    informationListBox.Items.Add("Homeworld: " + userPlanet.name);

                    //Same as above, but iterates through the userPerson.starships list and says if the length is 0.
                    informationListBox.Items.Add("");
                    informationListBox.Items.Add("Starships:");
                    if (userPerson.starships.Count > 0)
                    {
                        foreach (string starships in userPerson.starships)
                        {
                            Uri starshipsURI = new Uri(starships);
                            starshipID = starshipsURI.Segments.LastOrDefault();
                            Starship userStarship = await JSONHelper.ListStarshipInfo(starshipID);
                            informationListBox.Items.Add(userStarship.name);
                        }
                    }
                    else
                    {
                        informationListBox.Items.Add("None");
                    }
                }
                else
                {
                    MessageBox.Show("For people, the valid ID range is 1 through 87");
                }
            }
            else
            {
                MessageBox.Show("Please enter only an ID number.");
            }
        }

        public async void GenerateOneSpecies()
        {
            string speciesID = idTextBox.Text;
            string planetID = "";
            long checkInteger = 0;
            bool isNumeric = long.TryParse(speciesID, out checkInteger);

            //Ensures that the input is numeric, then checks if the ID is in the applicable range, before listing person information.
            if (isNumeric == true)
            {
                if (Convert.ToInt32(speciesID) >= 1 && Convert.ToInt32(speciesID) <= 37)
                {
                    Species userSpecies = await JSONHelper.ListSpeciesInfo(Convert.ToInt32(speciesID));
                    informationListBox.Items.Add("Name: " + userSpecies.name);
                    informationListBox.Items.Add("Classification: " + userSpecies.classification);
                    informationListBox.Items.Add("Designation: " + userSpecies.designation);
                    informationListBox.Items.Add("Average Height: " + userSpecies.average_height + " centimeters");
                    informationListBox.Items.Add("Skin Colors: " + userSpecies.skin_colors);
                    informationListBox.Items.Add("Hair Colors: " + userSpecies.hair_colors);
                    informationListBox.Items.Add("Eye Colors: " + userSpecies.eye_colors);
                    informationListBox.Items.Add("Average Lifespan: " + userSpecies.average_lifespan + " years");
                    informationListBox.Items.Add("Language: " + userSpecies.language);

                    //Generates the homeworld by pulling the planetID from the end of the given URI, then finding the associated planet name.
                    try
                    {
                        Uri homeworldURI = new Uri(userSpecies.homeworld);
                        planetID = homeworldURI.Segments.LastOrDefault();
                        Planet userPlanet = await JSONHelper.ListPlanetInfo(planetID);
                        informationListBox.Items.Add("Homeworld: " + userPlanet.name);
                    }
                    catch
                    {
                        informationListBox.Items.Add("Homeworld: Unknown");
                    }
                    informationListBox.Items.Add("");
                }
                else
                {
                    MessageBox.Show("For species, the valid ID range is 1 through 37");
                }
            }
            else
            {
                MessageBox.Show("Please enter only an ID number.");
            }
        }

        //Does the same process as GenerateOneSpecies(), but instead of the user inputting an ID, it automatically determines the ID range and lists them all.
        //It determines the range by pulling the AllSpecies.count variable, then repeats GenerateOneSpecies() that many times with a for loop.
        public async void GenerateAllSpecies()
        {
            string planetID = "";

            AllSpecies speciesCount = await JSONHelper.ListAllSpeciesInfo();
            for (int species = 1; species <= speciesCount.count; species++)
            {
                Species userSpecies = await JSONHelper.ListSpeciesInfo(species);
                informationListBox.Items.Add("Name: " + userSpecies.name);
                informationListBox.Items.Add("Classification: " + userSpecies.classification);
                informationListBox.Items.Add("Designation: " + userSpecies.designation);
                informationListBox.Items.Add("Average Height: " + userSpecies.average_height + " centimeters");
                informationListBox.Items.Add("Skin Colors: " + userSpecies.skin_colors);
                informationListBox.Items.Add("Hair Colors: " + userSpecies.hair_colors);
                informationListBox.Items.Add("Eye Colors: " + userSpecies.eye_colors);
                informationListBox.Items.Add("Average Lifespan: " + userSpecies.average_lifespan + " years");
                informationListBox.Items.Add("Language: " + userSpecies.language);

                //Generates the homeworld by pulling the planetID from the end of the given URI, then finding the associated planet name.
                try
                {
                    Uri homeworldURI = new Uri(userSpecies.homeworld);
                    planetID = homeworldURI.Segments.LastOrDefault();
                    Planet userPlanet = await JSONHelper.ListPlanetInfo(planetID);
                    informationListBox.Items.Add("Homeworld: " + userPlanet.name);
                }
                catch
                {
                    informationListBox.Items.Add("Homeworld: Unknown");
                }
                informationListBox.Items.Add("");
            }
        }
    }
}
