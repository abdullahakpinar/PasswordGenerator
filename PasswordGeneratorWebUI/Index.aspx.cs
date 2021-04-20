using PasswordGenerator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PasswordGeneratorWebUI
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnPasswordGenerate_Click(object sender, EventArgs e)
        {
            PasswordGeneratorRequest request = new PasswordGeneratorRequest();
            request.MinLength = int.Parse(txtMinLength.Text);
            request.MaxLength = int.Parse(txtMaxLength.Text);
            request.IsUpperChars = chkUpperChars.Checked;
            request.IsLowerChars = chkLowerChars.Checked;
            request.IsNumberChars = chkNumberChars.Checked;
            request.IsSpecialChars = chkSpecialChars.Checked;
            request.AllowChars = txtAllowChars.Text.Trim();
            request.DenyChars = txtDenyChars.Text.Trim();
            txtGeneratedPassword.Text = PasswordGenerate.CreateRandomPassword(request);
        }

        protected void TxtMinLength_TextChanged(object sender, EventArgs e)
        {
            CheckLengthDifference(txtMinLength);
        }

        protected void TxtMaxLength_TextChanged(object sender, EventArgs e)
        {
            CheckLengthDifference(txtMaxLength);
        }

        private void CheckLengthDifference(TextBox txt)
        {
            if (!string.IsNullOrEmpty(txtMinLength.Text) && !string.IsNullOrEmpty(txtMaxLength.Text))
            {
                int minLength = int.Parse(txtMinLength.Text);
                int maxLength = int.Parse(txtMaxLength.Text);
                if (minLength > maxLength)
                {
                    txtMaxLength.Text = (maxLength + 1).ToString();
                }
                else if (maxLength < minLength)
                {
                    txtMinLength.Text = (minLength + 1).ToString();
                }
            }
            else if (!string.IsNullOrEmpty(txt.Text))
            {
                if (int.Parse(txt.Text) < 0)
                {
                    txt.Text = "1";
                }
            }
        }
    }
}