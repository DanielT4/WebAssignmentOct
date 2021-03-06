﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdminGUI
{
    public partial class Form1 : Form
    {

        masterEntities DataBase;

        public Form1()
        {
            InitializeComponent();

            DataBase = new masterEntities();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Education edu = new Education(){ Course = txbCourse.Text, Period = txbPeriod.Text};

            DataBase.Educations.Add(edu);
            DataBase.SaveChanges();
            UpdateLbx();
        }

        public void UpdateLbx()
        {
            lbxEducation.Items.Clear();

            foreach (Education item in DataBase.Educations)
            {
                lbxEducation.Items.Add(item);
                lbxEducation.DisplayMember = "Course";
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            
        }
    }
}
