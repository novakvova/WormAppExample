using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormStudent
{
    public partial class StudentAddForm : Form
    {
        public StudentAddForm()
        {
            
            InitializeComponent();
            InitControls();
        }
        private void InitControls()
        {
            for (int i = 1; i <= 31; i++)
            {
                MyItemComboBox item = new MyItemComboBox
                {
                    Id = i,
                    Name = i.ToString()
                };
                cbDay.Items.Add(item);
            }
            for (int i = 1; i <= 12; i++)
            {
                string fullMonthName = new DateTime(1993, i, 1)
                    .ToString("MMMM", CultureInfo.CreateSpecificCulture("uk"));
                MyItemComboBox item = new MyItemComboBox
                {
                    Id = i,
                    Name = fullMonthName
                };
                cbMonth.Items.Add(item);
            }

        }
    }
}
