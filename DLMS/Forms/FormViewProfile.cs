using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using DLMS.CustomClasses;

namespace DLMS.Forms
{
    public partial class FormViewProfile : Form
    {
        // Make form rounded
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // height of ellipse
            int nHeightEllipse // width of ellipse
        );

        public FormViewProfile()
        {
            InitializeComponent();
            // Make form rounded
            FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));

            // Display the data
            labelHeaderName.Text = $"{Student.FName} {Student.LName}";
            labelHeaderCourse.Text = Student.Course;
            labelHeaderCampus.Text = Student.Campus;
            labelCampusValue.Text = Student.Campus;
            labelAcadLvlValue.Text = Student.AcadLvl;
            labelSectionValue.Text = Student.Section;
            labelYearLvlValue.Text = Student.YearLvl;
            labelStudIDValue.Text = Student.StudentID.ToString();
            labelEmailValue.Text = Student.Email;
        }
    }
}
