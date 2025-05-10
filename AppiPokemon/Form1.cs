using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AppiPokemon
{
    public partial class Form1 : Form
    {
        private HttpClient client = new HttpClient();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private async void btBuscar_Click(object sender, EventArgs e)
        {
            string pokemonName = txtNombre.Text.ToLower();
            string url = $"https://pokeapi.co/api/v2/pokemon/{pokemonName}";

            try
            {
                string response = await client.GetStringAsync(url);
                JObject json = JObject.Parse(response);

                IBLPeso.Text = $"Peso: {json["weight"]}";
                IBLAltura.Text = $"Altura: {json["height"]}";
                IBLTipo.Text = $"Tipo: {json["types"][0]["type"]["name"]}";
                string imagenUrl = json["sprites"]["front_default"]?.ToString();
                pictureBox1.Load(imagenUrl);
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se encontro la informacion del pokemon: " + ex.Message);
            }
        }

        private void bttxt_Click(object sender, EventArgs e)
        {
            string nombre = bttxt.Text;
            string peso = IBLPeso.Text;
            string altura = IBLAltura.Text;
            string tipo = IBLTipo.Text;
            string imagenUrl = pictureBox1.ImageLocation;

            if (string.IsNullOrWhiteSpace(nombre))
            {
                MessageBox.Show("Busca un Pokémon antes de exportar.");
                return;
            }

            string texto = $"{nombre}\n{peso}\n{altura}\n{tipo}\nImagen: {imagenUrl}";

            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Archivo de texto (.txt)|.txt";
                saveFileDialog.Title = "Guardar información del Pokémon";
                saveFileDialog.FileName = "pokemon_info.txt";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        System.IO.File.WriteAllText(saveFileDialog.FileName, texto);
                        MessageBox.Show("¡Información exportada con éxito!");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al guardar el archivo: " + ex.Message);
                    }
                }
            }
        }

        private void btLB_Click(object sender, EventArgs e)
        {
            txtNombre.Text = string.Empty;

            IBLPeso.Text = "Peso:";
            IBLAltura.Text = "Altura:";
            IBLTipo.Text = "Tipo:";

            pictureBox1.Image = null;
        }

        private async void btAG_Click(object sender, EventArgs e)
        {
            string url = "https://api.thecatapi.com/v1/images/search";

            try
            {
                string response = await client.GetStringAsync(url);
                JArray json = JArray.Parse(response);
                string imageUrl = json[0]["url"].ToString();

                pictureBox1.Load(imageUrl);
                IBLPeso.Text = "Peso:";
                IBLAltura.Text = "Altura:";
                IBLTipo.Text = "Tipo: Gato!";
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo obtener la imagen del gato: " + ex.Message);
            }
        }
    }
}
