using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace MegaDesk2
{
    public partial class SearchQuotes : Form
    {
        public SearchQuotes()
        {
            InitializeComponent();
            this.LoadJson2();
        }

        private void SearchQuotes_FormClosed(object sender, FormClosedEventArgs e)
        {
            ((Form)this.Tag).Show();
        }

        public void LoadJson2()
        {
            using (StreamReader r = new StreamReader("quotes.json"))
            {
                string json = r.ReadToEnd();
                dynamic array = JsonConvert.DeserializeObject(json);

                dataGridSearch.DataSource = array;
            }
        }

        private void comFilterSurface_SelectedValueChanged(object sender, EventArgs e)
        {
            string selectedValue = comFilterSurface.Text;
            this.FilterQuotesBySurfaceMaterial(selectedValue);
        }

        public void FilterQuotesBySurfaceMaterial(string surface)
        {
            List<object> filteredQuotes = new List<object>();

            using (StreamReader r = new StreamReader("quotes.json"))
            {
                string json = r.ReadToEnd();
                dynamic array = JsonConvert.DeserializeObject(json);
                foreach (dynamic quote in array)
                {
                    Console.WriteLine(surface);
                    if (surface == "All")
                    {
                        filteredQuotes.Add(quote);
                    } else if (quote.surfaceMaterial == surface)
                    {
                        filteredQuotes.Add(quote);
                    }
                }
            }

            dataGridSearch.DataSource = filteredQuotes;
        }
    }
}
