using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;

namespace _1percentHabits
{
    public partial class HabitBuilder : Form
    {
        public HabitBuilder()
        {
            InitializeComponent();
        }
        int index = 0;
        string path;
        List<string> habits;
        List<List<string>> habitsSplit = new List<List<string>>();//[0]habit --- [1]size --- [2]time/quantity
        List<string> habit = new List<string>();

        private void Form1_Load(object sender, EventArgs e)
        {
            path = Path.Combine(Environment.GetFolderPath(System.Environment.SpecialFolder.UserProfile), "habits.txt");

            if (!File.Exists(path))
            {
                File.Create(path).Close();
            }
            
            habits = File.ReadAllLines(path).ToList();

            for (int i = 0; i < habits.Count; i++)
            {
                List<string> split = habits[i].Split().ToList();
                habitsSplit.Add(split);
                lbHabits.Items.Add(split[0]);
            }
        }

        private void lbHabits_SelectedIndexChanged(object sender, EventArgs e)
        {
            index = lbHabits.SelectedIndex;
            if (index == -1) return;

            btnEditHabit.Visible = true;
            btnPlusPercent.Visible = true;
            btnMinusPercent.Visible = true;
            habit = habitsSplit[index];
            lblHabit.Text = habit[0];

            refreshLabel();
        }
        
        private void btnAddNewHabit_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtName.Text) || String.IsNullOrEmpty(numValue.Text)) return;

            habit = new List<string>();
            habit.Add(txtName.Text);
            habit.Add(numValue.Text);
            habit.Add(cmbType.Text);

            gbHabit.Visible = false;
            gbHabit.Text = "Add New Habit";
            btnAddNewHabit.Visible = false;

            habitsSplit.Add(habit);
            refresh();
        }

        private void btnOpenAddNew_Click(object sender, EventArgs e)
        {
            gbHabit.Visible = true;
            btnAddNewHabit.Visible = true;
        }

        private void btnEditHabit_Click(object sender, EventArgs e)
        {
            btnSaveChanges.Visible = true;
            btnDelete.Visible = true;
            btnAddNewHabit.Visible = false;
            txtName.Text = habit[0];
            numValue.Text = habit[1];
            cmbType.Text = habit[2];

            gbHabit.Visible = true;
            gbHabit.Text = "Edit Habit";
            btnSaveChanges.Visible = true;
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            habitsSplit[lbHabits.SelectedIndex][0] = txtName.Text;
            habitsSplit[lbHabits.SelectedIndex][1] = numValue.Text;
            habitsSplit[lbHabits.SelectedIndex][2] = cmbType.Text;

            gbHabit.Visible = false;
            btnSaveChanges.Visible = false;

            refresh();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you sure to delete this item?",
                                     "Confirm Deletion",
                                     MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                habitsSplit.RemoveAt(lbHabits.SelectedIndex);
                gbHabit.Visible = false;
                btnSaveChanges.Visible = false;

                refresh();
            }
        }

        private void btnPlusPercent_Click(object sender, EventArgs e)
        {
            float newValue = Convert.ToSingle(habit[1]);
            newValue *= 1.01f;

            habitsSplit[index][1] = newValue.ToString();

            refreshLabel();
        }

        private void btnMinusPercent_Click(object sender, EventArgs e)
        {
            float newValue = Convert.ToSingle(habit[1]);
            newValue /= 1.01f;

            habitsSplit[index][1] = newValue.ToString();

            refreshLabel();
        }

        private string convertToMinutes()
        {
            float time = Convert.ToSingle(habitsSplit[index][1]);

            float decimalHours = time / 60; 

            double hours = Math.Floor(decimalHours);

            float decimalHour = decimalHours % 1;

            float decimalMinutes = decimalHour * 60;

            double minutes = Math.Floor(decimalMinutes);

            float decimalMinute = decimalMinutes % 1;

            float decimalSeconds = decimalMinute * 60;

            double seconds = Math.Floor(decimalSeconds);

            return $"{hours} Hours\n{minutes} Minutes\n{seconds} Seconds";
        }

        private void refresh()
        {
            lbHabits.Items.Clear();
            for (int i = 0; i < habitsSplit.Count; i++)
            {
                lbHabits.Items.Add(habitsSplit[i][0]);
            }
            txtName.Text = "";
            numValue.Text = "";
            cmbType.Text = "";
            lblHabit.Text = "Select Habit";
            lblInstruction.Text = "";

            index = -1;

            btnEditHabit.Visible = false;
            btnDelete.Visible = false;
            btnSaveChanges.Visible = false;
            btnAddNewHabit.Visible = true;
            btnPlusPercent.Visible = false;
            btnMinusPercent.Visible = false;
        }

        private void refreshLabel()
        {
            switch (habit[2])
            {
                case "time":
                    lblInstruction.Text = "Do this habit for:\n" + convertToMinutes();
                    break;
                case "distance":
                    lblInstruction.Text = "Travel for:\n" + Math.Round(Convert.ToDouble(habit[1]), 2) + "km";
                    break;
                case "quantity":
                    lblInstruction.Text = "Complete this habit \n" + Math.Floor(Convert.ToDouble(habit[1])) + " times";
                    break;
            }
        }


        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            habits.Clear();

            for (int i = 0; i < habitsSplit.Count; i++)
            {
                habits.Add(string.Join(" ", habitsSplit[i].ToArray()));
            }
            File.WriteAllLines(path, habits);
        }

        /*
         How to convert decimal minutes to time format
         Convert 78.6 minutes to hh:mm:ss

         78.6 minutes can be converted to hours by dividing 78.6 minutes / 60 minutes/hour = 1.31 hours
         1.31 hours can be broken down to 1 hour plus 0.31 hours - 1 hour

         0.31 hours * 60 minutes/hour = 18.6 minutes - 18 minutes
         0.6 minutes * 60 seconds/minute = 36 seconds - 36 seconds
         01:18:36
        */
    }
}
