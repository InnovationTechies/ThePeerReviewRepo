using PeerReviewSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PeerReviewSystem
{
    public partial class frmAddQuestions : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            ReviewRepository reviewRepository = new ReviewRepository();
            Questions questions = new Questions();

            questions.Question = txtQuestion.Text;
            questions.RoleID =Convert.ToInt32(drpRole.SelectedValue);
            reviewRepository.InsertQuestion(questions);

            Response.Redirect(Request.RawUrl);

        }
    }
}