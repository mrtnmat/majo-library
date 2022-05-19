using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace majo_library
{
    public partial class Form1 : Form
    {
        Library lib = new();
        public Form1()
        {
            InitializeComponent();
            lib.AddBook(new Book("Titolo", "Autore"));
            lib.AddBook(new Book("Il libro del C#", "Grancesco Fagliardo"));
            dgvBooks.AutoGenerateColumns = true;
            dgvBooks.DataSource = lib.Catalog.Values.ToList();
        }
    }
}
