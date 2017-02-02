using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PizzaExpress.Web
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void orderButton_Click(object sender, EventArgs e)
        {
            if (nameTextBox.Text.Trim().Length == 0)
            {
                errorLabel.Text = "Please enter a name.";
                errorLabel.Visible = true;
                return;
            }

            if (addressTextBox.Text.Trim().Length == 0)
            {
                errorLabel.Text = "Please enter an address.";
                errorLabel.Visible = true;
                return;
            }

            if (postCodeTextBox.Text.Trim().Length == 0)
            {
                errorLabel.Text = "Please enter a postcode.";
                errorLabel.Visible = true;
                return;
            }

            if (phoneTextBox.Text.Trim().Length == 0)
            {
                errorLabel.Text = "Please enter a phone number.";
                errorLabel.Visible = true;
                return;
            }

            if (emailTextBox.Text.Trim().Length == 0)
            {
                errorLabel.Text = "Please enter an email address.";
                errorLabel.Visible = true;
                return;
            }
            try
            {
                var order = buildOrder();
                Domain.OrderManager.CreateOrder(order);
                Response.Redirect("Success.aspx");
            }
            catch (Exception ex)
            {
                errorLabel.Text = ex.Message;
                errorLabel.Visible = true;
                return;
            }

        }

        protected void recalcCost(object sender, EventArgs e)
        {
            if (sizeDropDownList.SelectedValue == String.Empty) return;
            if (crustDropDownList.SelectedValue == String.Empty) return;
            var order = buildOrder();

            try
            {
                totalLabel.Text = Domain.PizzaPriceManager.CalculateCost(order).ToString("C");
            }
            catch (Exception)
            {
                //
            }
            
                     
        }

        private void validateForm()
        {
            if (nameTextBox.Text.Trim().Length == 0)
            {
                errorLabel.Text = "Please enter a name.";
                errorLabel.Visible = true;
                return;
            }

            if (addressTextBox.Text.Trim().Length == 0)
            {
                errorLabel.Text = "Please enter an address.";
                errorLabel.Visible = true;
                return;
            }

            if (postCodeTextBox.Text.Trim().Length == 0)
            {
                errorLabel.Text = "Please enter a postcode.";
                errorLabel.Visible = true;
                return;
            }

            if (phoneTextBox.Text.Trim().Length == 0)
            {
                errorLabel.Text = "Please enter a phone number.";
                errorLabel.Visible = true;
                return;
            }

            if (emailTextBox.Text.Trim().Length == 0)
            {
                errorLabel.Text = "Please enter an email address.";
                errorLabel.Visible = true;
                return;
            }
        }

        private DTO.OrderDTO buildOrder()
        {
            var order = new DTO.OrderDTO(); ;
            order.Size = determineSize();
            order.Crust = determineCrust();
            order.PaymentType = determinePayment();
            order.Pepperoni = pepperoniCheckBox.Checked;
            order.Onions = onionsCheckBox.Checked;
            order.GreenPeppers = greenPeppersCheckBox.Checked;
            order.Sausage = sausageCheckBox.Checked;
            order.Name = nameTextBox.Text;
            order.Address = addressTextBox.Text;
            order.PostCode = postCodeTextBox.Text;
            order.Phone = phoneTextBox.Text;
            order.Email = emailTextBox.Text;
            return order;
        }

        private DTO.Enums.SizeType determineSize()
        {
            DTO.Enums.SizeType size;
            if(!Enum.TryParse(sizeDropDownList.SelectedValue, out size)) throw new Exception("Could not determine selected size!");
            return size;
        }

        private DTO.Enums.CrustType determineCrust()
        {
            DTO.Enums.CrustType crust;
            if (!Enum.TryParse(crustDropDownList.SelectedValue, out crust)) throw new Exception("Could not determine selected crust!");
            return crust;
        }

        private DTO.Enums.PaymentType determinePayment()
        {
            DTO.Enums.PaymentType payment;
            if (cashRadioButton.Checked) payment = DTO.Enums.PaymentType.Cash; 
            else payment = DTO.Enums.PaymentType.Credit;
            return payment;
        }

        protected void loginButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("OrderManagement.aspx");
        }
    }
}