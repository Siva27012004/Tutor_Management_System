using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EndSem.Tutor
{
    public partial class GetStudentData : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.Form["tutorId"] != null)
            {
                int tutorId = Convert.ToInt32(Request.Form["tutorId"]);
                // Fetch student data for the selected tutor from the database
                DataTable dt = FetchStudentDataByTutor(tutorId);

                // Render the student data as HTML and send it as the response
                Response.Clear();
                Response.Write(RenderStudentDataAsHtml(dt));
                Response.End();
            }
        }

        private string RenderStudentDataAsHtml(DataTable dt)
        {
            throw new NotImplementedException();
        }

        private DataTable FetchStudentDataByTutor(int tutorId)
        {
            throw new NotImplementedException();
        }
    }
}