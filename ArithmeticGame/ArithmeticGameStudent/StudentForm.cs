using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArithmeticGame
{
    public partial class StudentForm : Form
    {
        StudentQuestion Answer = new StudentQuestion();

        public StudentForm()
        {
            InitializeComponent();
            Answer = new StudentQuestion(txtQuestion);
        }

        private void StudentForm_Load(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {

        }
    }
}
