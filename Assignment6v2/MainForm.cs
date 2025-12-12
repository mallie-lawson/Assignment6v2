using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;
using Microsoft.EntityFrameworkCore.Sqlite;

namespace Assignment6v2
{
    public partial class MainForm : Form
    {
        private readonly IPersonDataSource _db = new PersonContextDataSource();

        public MainForm(IPersonDataSource db)
        {
            InitializeComponent();
            _db = db;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            personBindingSource.DataSource = _db.GetPeople();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.Validate();
            personBindingSource.EndEdit();
            _db.SaveChanges();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (Add_Person addPersonsForm = new Add_Person())
            {
                if (addPersonsForm.ShowDialog() == DialogResult.OK)
                {
                    var newPerson = new Person()
                    {
                        Name = addPersonsForm.Name,
                        Phone = addPersonsForm.Phone
                    };
                    personBindingSource.Add(newPerson);
                }
            }
            ApplyFilter();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Person currentPerson = (Person)personBindingSource.Current;
            if (currentPerson == null)
                return;
            personBindingSource.RemoveCurrent();
            _db.SaveChanges();
            ApplyFilter();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            ApplyFilter();
        }

        
        private void ApplyFilter()
        {
            personBindingSource.DataSource = _db.GetPeople(txtSearch.Text);
        }
    }
}
