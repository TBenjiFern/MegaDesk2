using System;
using System.Reflection;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.Json;

namespace MegaDesk2
{
    public partial class AddQuote : Form
    {
        public bool closer;
        public AddQuote()
        {
            InitializeComponent();
            closer = false;
            List<DesktopMaterial> materials = Enum.GetValues(typeof(DesktopMaterial)).Cast<DesktopMaterial>().ToList();
            materialComboBox.DataSource = materials;

            materialComboBox.SelectedIndex = -1;

            List<Shipping> shipping = Enum.GetValues(typeof(Shipping)).Cast<Shipping>().ToList();
            List<string> shippingDescriptions = new List<string>();

            foreach (Shipping item in shipping)
            {
                var description = EnumExtensionMethods.GetDescription(item);
                shippingDescriptions.Add(description);
            }

            deliveryComboBox.DataSource = shippingDescriptions;

            deliveryComboBox.SelectedIndex = -1;

            numDrawersNumeric.Text = String.Empty;
            widthNumeric.Text = String.Empty;
            depthNumeric.Text = String.Empty;

        }


        private void AddQuote_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (closer == false)
            {
               ((Form)this.Tag).Show();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void value_enter(object sender, EventArgs e)
        {
            NumericUpDown valueBox = sender as NumericUpDown;

            if (valueBox != null)
            {
                int lengthOfAnswer = valueBox.Value.ToString().Length;
                valueBox.Select(0, lengthOfAnswer);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var desk = new Desk
            {
                Depth = (int)depthNumeric.Value,
                Width = (int)widthNumeric.Value,
                NumDrawers = (int)numDrawersNumeric.Value,
                DesktopMaterial = (DesktopMaterial)materialComboBox.SelectedValue
            };

            var deskQuote = new DeskQuote
            {
                Desk = desk,
                CustomerName = customerName.Text,
                QuoteDate = DateTime.Now,
                Shipping = (Shipping)deliveryComboBox.SelectedIndex
            };

            try
            {
                var price = deskQuote.CalcTotalPrice();

                deskQuote.DeskPrice = price;

                GetDeskQuote.DeskQuote = deskQuote;

                // JSON add quote to file
                SendToJSON(deskQuote);

                var displayQuote = new DisplayQuote();
                displayQuote.Tag = (Form)this.Tag;
                displayQuote.Show();
                closer = true;
                this.Close();

            }
            catch (Exception err)
            {
                MessageBox.Show("There was an error creating the quote. {0}", err.InnerException.ToString());
            }
        }

        public void SendToJSON(DeskQuote deskQuote)
        {
            var quotesFileName = @"quotes.json";
            List<DeskQuote> deskQuotes = new List<DeskQuote>();

            if (File.Exists(quotesFileName))
            {
                using (StreamReader reader = new StreamReader(quotesFileName))
                {
                    string quotes = reader.ReadToEnd();

                    if (quotes.Length > 0)
                    {
                        deskQuotes = JsonSerializer.Deserialize<List<DeskQuote>>(quotes);
                    }
                }
            }

            deskQuotes.Add(deskQuote);

            SaveQuotes(deskQuotes);


        }

        public void SaveQuotes(List<DeskQuote> deskQuotes)
        {
            var quotesFileName = @"quotes.json";
            var serializedQuotes = JsonSerializer.Serialize(deskQuotes);
            File.WriteAllText(quotesFileName, serializedQuotes);
        }
    }

    public static class GetDeskQuote
    {
        public static DeskQuote DeskQuote { get; set; }
    }


    public static class EnumExtensionMethods
    {
        public static string GetDescription(this Enum GenericEnum)
        {
            Type genericEnumType = GenericEnum.GetType();
            MemberInfo[] memberInfo = genericEnumType.GetMember(GenericEnum.ToString());
            if ((memberInfo != null && memberInfo.Length > 0))
            {
                var _Attribs = memberInfo[0].GetCustomAttributes(typeof(System.ComponentModel.DescriptionAttribute), false);
                if ((_Attribs != null && _Attribs.Count() > 0))
                {
                    return ((System.ComponentModel.DescriptionAttribute)_Attribs.ElementAt(0)).Description;
                }
            }
            return GenericEnum.ToString();
        }

    }
}
