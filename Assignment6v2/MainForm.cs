using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;
using Microsoft.EntityFrameworkCore.Sqlite;

namespace Assignment6v2
{
    public partial class MainForm : Form
    {
        private PersonContext _db = new();

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            _db.Database.EnsureCreated();
            _db.Persons.Load();
            personBindingSource.DataSource = _db.Persons.Local.ToBindingList();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.Validate();
            personBindingSource.EndEdit();
            _db.ChangeTracker.DetectChanges();
            _db.SaveChanges();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (Add_Person addPersonsForm = new Add_Person())
            {
                if (addPersonsForm.ShowDialog() == DialogResult.OK)
                {
                    _db.Add(new Person() { Name = addPersonsForm.Name, Phone = addPersonsForm.Phone });
                    _db.SaveChanges();
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Person currentPerson = (Person)personBindingSource.Current;
            if (currentPerson == null)
                return;
            _db.Persons.Remove(currentPerson);
            _db.SaveChanges();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
