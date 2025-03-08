namespace Pokedex
{
    public partial class Form1 : Form
    {
        private List<Pokemon> pokemonsList = new List<Pokemon>();
        public Form1()
        {
            InitializeComponent();
        }
        private void displayPokemon(Pokemon pokemon)
        {
            this.pictureBox1.Text = pokemon.Name;
            using (var ms = new MemoryStream(pokemon.getImage()))
            {
                this.pictureBox1.Image = Image.FromStream(ms);
            }
            if (pokemon.Type2 == Poketype.None)
            {
                this.TypePoke2.Visible = false;
            }
            else
            {
                this.TypePoke2.Visible = true;
            }
            this.NamePokeLB.Text = pokemon.Name;
            this.TypePoke1.Text = pokemon.Type1.ToString();
            this.TypePoke2.Text = pokemon.Type2.ToString();
            this.HPdis.Text = pokemon.HP.ToString();
            this.ATKdis.Text = pokemon.Attack.ToString();
            this.Defdis.Text = pokemon.Defense.ToString();
            this.spcATKdiss.Text = pokemon.SpecialAttack.ToString();
            this.spcDefdiss.Text = pokemon.SpecialDefense.ToString();
            this.Speeddiss.Text = pokemon.speed.ToString();
            this.Totaldiss.Text = pokemon.Total.ToString();
            this.Speciesdis.Text = pokemon.Species.ToString();
            this.weightdis.Text = pokemon.Weight.ToString();
            this.heightdis.Text = pokemon.Height.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Pickachu pickachu = new Pickachu();
            this.displayPokemon(pickachu);
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            Pickachu pickachu = new Pickachu();
            this.pokemonsList.Add(pickachu);
            this.displayPokemon(pickachu);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Mewtwo mewtwo = new Mewtwo();
            this.pokemonsList.Add(mewtwo);
            this.displayPokemon(mewtwo);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Charmander charmander = new Charmander();
            this.pokemonsList.Add(charmander);
            this.displayPokemon(charmander);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Arceus arceus = new Arceus();
            this.pokemonsList.Add(arceus);
            this.displayPokemon(arceus);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Togepi togepi = new Togepi();
            this.pokemonsList.Add(togepi);
            this.displayPokemon(togepi);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Snorlax snorlax = new Snorlax();
            this.pokemonsList.Add(snorlax);
            this.displayPokemon(snorlax);
        }
    }
}
