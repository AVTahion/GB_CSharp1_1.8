using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Task_3
{
    public partial class Form1 : Form
    {
        TrueFalse database;
        public Form1()
        {
            InitializeComponent();
        }

        private void miNew_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                database = new TrueFalse(sfd.FileName);
                database.Add("123", true);
                database.Save();
                nudNumber.Minimum = 1;
                nudNumber.Maximum = 1;
                nudNumber.Value = 1;
            };

        }

        private void miExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void nudNumber_ValueChanged(object sender, EventArgs e)
        {
            if (database == null) nudNumber.Value = 0;
            else
            {
                tBoxQuestion.Text = database[(int)nudNumber.Value - 1].text;
                cBoxTrue.Checked = database[(int)nudNumber.Value - 1].trueFalse;
            }
        }

        private void btnAddQuest_Click(object sender, EventArgs e)
        {
            if (database == null)
            {
                MessageBox.Show("Создайте новую базу данных", "Сообщение");
                return;
            }
            database.Add((database.Count + 1).ToString(), true);
            nudNumber.Maximum = database.Count;
            nudNumber.Value = database.Count;

        }

        private void btnDelQuest_Click(object sender, EventArgs e)
        {
            if (nudNumber.Maximum == 1 || database == null) return;
            database.Remove((int)nudNumber.Value);
            nudNumber.Maximum--;
            if (nudNumber.Value > 1) nudNumber.Value = nudNumber.Value;
        }

        private void btnSaveQuest_Click(object sender, EventArgs e)
        {
            if (database == null) return;
            database[(int)nudNumber.Value - 1].text = tBoxQuestion.Text;
            database[(int)nudNumber.Value - 1].trueFalse = cBoxTrue.Checked;
        }

        private void miOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                database = new TrueFalse(ofd.FileName);
                database.Load();
                nudNumber.Minimum = 1;
                nudNumber.Maximum = database.Count;
                nudNumber.Value = 1;
            }
        }

        private void miSave_Click(object sender, EventArgs e)
        {
            if (database != null) database.Save();
            else MessageBox.Show("База данных не создана");
        }

        private void cBoxTrue_CheckedChanged(object sender, EventArgs e)
        {
            if (database == null) cBoxTrue.Checked = false;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("автор: Александр Кушмилов\nверсия 1.0 \nCopyright © 2019");
        }

        private void miSaveAs_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                if (database != null) database.Save(saveFileDialog.FileName);
            }
            else MessageBox.Show("База данных не создана");
        }

    }
}
