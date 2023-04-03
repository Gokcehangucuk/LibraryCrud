using System.Security.Cryptography.X509Certificates;
using Book.DAL.Entity;
using Book.Model.Models;

namespace Book_
{
    public partial class Form1 : Form
    {
        BookDBContext _db = new BookDBContext();
        int index;
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string kitapAdý = comboBox1.Items[comboBox1.SelectedIndex].ToString();
            var list = _db.Kitaps.
                Join(_db.YazarKitaps, x => x.BookId, y => y.BookId, (x, y) => new { Kitap = x, YazarKitap = y }).
                Join(_db.Yazars, xy => xy.YazarKitap.WriterId, w => w.WriterId, (xy, w) => new { KitapYIndex = xy, Yazar = w }).Select(x => new
                {
                    KitapAdi = x.KitapYIndex.Kitap.Name,
                    SayfaSayisi = x.KitapYIndex.Kitap.NumberOfPages,
                    Fiyatý = x.KitapYIndex.Kitap.Price,
                    Yazari = x.Yazar.FirstName + " " + x.Yazar.LastName
                }).ToList();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = list.Where(x => x.KitapAdi == kitapAdý).ToList();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string yazarAdi = comboBox2.Items[comboBox2.SelectedIndex].ToString();
            var list = _db.Kitaps.
                Join(_db.YazarKitaps, x => x.BookId, y => y.BookId, (x, y) => new { Kitap = x, YazarKitap = y }).
                Join(_db.Yazars, xy => xy.YazarKitap.WriterId, w => w.WriterId, (xy, w) => new { KitapYIndex = xy, Yazar = w }).Select(x => new
                {
                    KitapAdi = x.KitapYIndex.Kitap.Name,
                    SayfaSayisi = x.KitapYIndex.Kitap.NumberOfPages,
                    Fiyatý = x.KitapYIndex.Kitap.Price,
                    Yazari = x.Yazar.FirstName + " " + x.Yazar.LastName
                }).ToList();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = list.Where(x => x.Yazari == yazarAdi).ToList();

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            var list = _db.Kitaps.Where(x => x.Name.Contains(textBox2.Text)).ToList();
            dataGridView1.DataSource = list.ToList();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = _db.Yazars.Where(x => x.FirstName.Equals(textBox1.Text) || x.LastName.Equals(textBox1.Text)).ToList();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == null)
            {
                Yazar yazar = new Yazar()
                {
                    FirstName = textBox1.Text,
                    LastName = txtYazarSoyad.Text,
                };
                comboBox2.Items.Add(yazar.FirstName + " " + yazar.LastName);
            }
            else if (textBox2.Text == null)
            {
                Kitap kitap = new Kitap()
                {
                    Name = textBox1.Text,
                    NumberOfPages = Convert.ToInt32(txtKitapSayfaSayisi.Text),
                    Price = Convert.ToDecimal(txtKitapFiyatý)
                };
                comboBox1.Items.Add(kitap.Name);
            }
            else
            {
                Kitap kitap = new Kitap()
                {
                    Name = textBox1.Text,
                    NumberOfPages = Convert.ToInt32(txtKitapSayfaSayisi.Text),
                    Price = Convert.ToDecimal(txtKitapFiyatý)
                };
                Yazar yazar = new Yazar()
                {
                    FirstName = textBox1.Text,
                    LastName = txtYazarSoyad.Text,
                };
                YazarKitap yazarKitap = new YazarKitap()
                {
                    BookId = kitap.BookId,
                    WriterId = yazar.WriterId,
                };
                comboBox2.Items.Add(yazar.FirstName + " " + yazar.LastName);
                comboBox1.Items.Add(kitap.Name);
            }
        }

        private void txtYazarSoyad_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string kitapAdi = dataGridView1.Rows[index].Cells[0].Value.ToString();
            var kitapId=_db.Kitaps.Where(k => k.Name==kitapAdi).FirstOrDefault().BookId;
            var kitap=_db.Kitaps.Where(k => k.Name==kitapAdi).FirstOrDefault();
            _db.YazarKitaps.RemoveRange(_db.YazarKitaps.Where(x => x.BookId ==kitapId ));
            _db.Kitaps.Remove(kitap);
            _db.SaveChanges();
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            _db.SaveChanges();
            dataGridView1.Refresh();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.ReadOnly = false;
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
        }
    }
}