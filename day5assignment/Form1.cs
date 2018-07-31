using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace day5assignment
{
    public partial class Form1 : Form
    {
        studentinformationEntities db = new studentinformationEntities();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'studentinformationDataSet.studentinformation' table. You can move, or remove it, as needed.
            this.studentinformationTableAdapter.Fill(this.studentinformationDataSet.studentinformation);

        }

        private void txtnane_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            int rollno = Convert.ToInt32(txtrollno.Text);
            string name = txtnane.Text;
            string gender = "";
            if (rbfemale.Checked)
                gender = rbfemale.Text;
            if (rbmale.Checked)
                gender = rbmale.Text;
            DateTime dob = dtpdate.Value;
            string department = cbdepartment.SelectedItem.ToString();
            string course = cbcourse.SelectedItem.ToString();
            string semester = cbsemester.SelectedItem.ToString();
            string saddress = txtaddress.Text;
            int phonenumber = Convert.ToInt32(txtphone.Text);

            MessageBox.Show(rollno + "\n" + name + "\n" + dob + "\n" + gender + "\n" + department + "\n" + course + "\n" + semester + "\n" + saddress + "\n" + phonenumber);
            //insert data to db through entity framework
            studentinformation si = new studentinformation();
            si.Rollno = rollno;
            si.name = name;
            si.gender = gender;
            si.dob = dob;
            si.department = department;
            si.course = course;
            si.semester = semester;
            si.saddress = saddress;
            si.phonenumber = phonenumber;
            db.studentinformations.Add(si);
            var res = db.SaveChanges();
            if (res > 0)
                MessageBox.Show("data inserted");



        }

        private void btnselect_Click(object sender, EventArgs e)
        {
            lbselect.Items.Clear();
            foreach (var t in db.studentinformations)
            {
                //  lbselect.Items.Add(t.Id);
                lbselect.Items.Add(t.Rollno);
                lbselect.Items.Add(t.name);
                lbselect.Items.Add(t.gender);
                lbselect.Items.Add(t.dob);
                lbselect.Items.Add(t.department);
                lbselect.Items.Add(t.course);
                lbselect.Items.Add(t.semester);
                lbselect.Items.Add(t.saddress);
                lbselect.Items.Add(t.phonenumber);


                lbselect.Items.Add("*******");

            }
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            //textbox
            string saddress = txtaddress.Text;
            int phonenumber = Convert.ToInt32(txtphone.Text);
            //combo box
            string department = cbdepartment.SelectedItem.ToString();
            string courses = cbcourse.SelectedItem.ToString();
            string semester = cbsemester.SelectedItem.ToString();
            int rollno = Convert.ToInt32(txtrollno.Text);

            var olddata = db.studentinformations.Where(x => x.Rollno == rollno).SingleOrDefault();
            olddata.department = department;
            olddata.course = courses;
            olddata.semester = semester;
            olddata.saddress = saddress;

            var res = db.SaveChanges();
            if (res > 0)
                MessageBox.Show("data updated");

        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            int rollno = Convert.ToInt32(txtrollno.Text);
            var del = (from t in db.studentinformations
                       where t.Rollno == rollno
                       select t).SingleOrDefault();
            db.studentinformations.Remove(del);
            var res = db.SaveChanges();
            if(res > 0)
            {
                MessageBox.Show("data deleted");
            }

        }
    }
}
