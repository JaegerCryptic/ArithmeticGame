///-------------------------------------------------------------------------------------------------
// file:	StudentForm.cs
//
// summary:	Implements the student Windows Form
///-------------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArithmeticGame
{
    ///-------------------------------------------------------------------------------------------------
    /// <summary>   Form for viewing the student. </summary>
    ///
    /// <remarks>   Jaege, 17/09/2018. </remarks>
    ///-------------------------------------------------------------------------------------------------

    public partial class StudentForm : Form
    {
        /// <summary>   The answer. </summary>
        StudentQuestion Answer = new StudentQuestion();
        /// <summary>   The question. </summary>
        StudentConnection Question = new StudentConnection();

        ///-------------------------------------------------------------------------------------------------
        /// <summary>   Default constructor. </summary>
        ///
        /// <remarks>   Jaege, 17/09/2018. </remarks>
        ///-------------------------------------------------------------------------------------------------

        public StudentForm()
        {
            InitializeComponent();
            Thread.Sleep(100);


            Question.SetPackageAsync(txtQuestion);
            Question.UpdateControlState(btnSubmit);
        }

        ///-------------------------------------------------------------------------------------------------
        /// <summary>   Event handler. Called by StudentForm for load events. </summary>
        ///
        /// <remarks>   Jaege, 17/09/2018. </remarks>
        ///
        /// <param name="sender">   Source of the event. </param>
        /// <param name="e">        Event information. </param>
        ///-------------------------------------------------------------------------------------------------

        private void StudentForm_Load(object sender, EventArgs e)
        {
            btnSubmit.Enabled = false;
        }

        ///-------------------------------------------------------------------------------------------------
        /// <summary>   Event handler. Called by btnSubmit for click events. </summary>
        ///
        /// <remarks>   Jaege, 17/09/2018. </remarks>
        ///
        /// <param name="sender">   Source of the event. </param>
        /// <param name="e">        Event information. </param>
        ///-------------------------------------------------------------------------------------------------

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            Answer.CheckAnswer(txtStudentAnswer, Question.instructorAnswer, Question);
        }

        ///-------------------------------------------------------------------------------------------------
        /// <summary>   Event handler. Called by panel1 for paint events. </summary>
        ///
        /// <remarks>   Jaege, 17/09/2018. </remarks>
        ///
        /// <param name="sender">   Source of the event. </param>
        /// <param name="e">        Paint event information. </param>
        ///-------------------------------------------------------------------------------------------------

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
