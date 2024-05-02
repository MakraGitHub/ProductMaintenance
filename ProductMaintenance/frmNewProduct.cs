using ProductMaintenance.classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProductMaintenance
{
    public partial class frmNewProduct : Form
    {
        public frmNewProduct()
        {
            InitializeComponent();
        }
        private Product product = null;

        public Product GetNewProduct()
        {
            this.ShowDialog();
            return product;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            try
            {

                //blocked try to catch erro to alreth messagebox.
                if (IsValidData())
                {
                    if (rbBook.Checked)

                        product = new Book(txtCode.Text,
                            txtDescription.Text, txtAuthorOrVersion.Text, Convert.ToDecimal(txtPrice.Text));
                    else
                        product = new Software(txtCode.Text, txtDescription.Text,
                            txtAuthorOrVersion.Text,
                            Convert.ToDecimal(txtPrice.Text));
                    this.Close();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Entry Error",e.ToString());
            }
          
        }

        private bool IsValidData()
        {
            return Validator.IsPresent(txtCode) &&
                Validator.IsPresent(txtDescription) &&
                //Add new
                Validator.IsPresent(txtAuthorOrVersion) &&
                Validator.IsPresent(txtPrice) &&
                Validator.IsDecimal(txtPrice);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rbBook_CheckedChanged(object sender, EventArgs e)
        {
            if (rbBook.Checked)
            {
                lblAuthorOrVersion.Text = "Author: ";
                lblAuthorOrVersion.Tag = "Author";
            }
            else
            {
                lblAuthorOrVersion.Text = "Version: ";
                lblAuthorOrVersion.Tag = "Version";
            }
            txtCode.Focus();
        }
    }
}
