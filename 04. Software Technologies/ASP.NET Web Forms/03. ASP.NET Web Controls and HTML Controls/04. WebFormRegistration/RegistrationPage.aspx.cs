using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace _04.WebFormRegistration
{
    public partial class RegistrationPage : System.Web.UI.Page
    {
        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            string firstNameInput = tbFirstName.Text;
            string lastNameInput = tbLastName.Text;
            string facultyNumberInput = tbFacultyNumber.Text;
            string universitySelection = ddlUniversity.SelectedValue;
            string specialtySelection = ddlSpecialty.SelectedValue;
            string coursesSelection = ddlCourses.SelectedValue;

            var nameHeader = new HtmlGenericControl("h3");
            nameHeader.InnerText = String.Format("Name: {0}", System.Web.HttpUtility.HtmlEncode(firstNameInput + " " + lastNameInput));

            var facultyNumberHeader = new HtmlGenericControl("h4");
            facultyNumberHeader.InnerText = String.Format("Faculty: {0}", System.Web.HttpUtility.HtmlEncode(facultyNumberInput));

            var universityHeader = new HtmlGenericControl("h4");
            universityHeader.InnerText = String.Format("University: {0}", universitySelection);

            var specialtyHeader = new HtmlGenericControl("h4");
            specialtyHeader.InnerText = String.Format("Specialty: {0}", specialtySelection);

            var coursesHeader = new HtmlGenericControl("h4");
            coursesHeader.InnerText = String.Format("Courses: {0}", coursesSelection);

            registrationBox.Visible = false;

            submittedForm.Controls.Add(nameHeader);
            submittedForm.Controls.Add(facultyNumberHeader);
            submittedForm.Controls.Add(universityHeader);
            submittedForm.Controls.Add(specialtyHeader);
            submittedForm.Controls.Add(coursesHeader);
        }
    }
}