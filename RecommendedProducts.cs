using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuirenMainForm
{
    public partial class RecommendedProducts : Form
    {
        private string morningRoutine;
        private string eveningRoutine;
        public RecommendedProducts(string morningRoutine, string eveningRoutine)
        {

            InitializeComponent();
            this.morningRoutine = morningRoutine;
            this.eveningRoutine = eveningRoutine;
        }
        private void RecommendedProducts_Load(object sender, EventArgs e)
        {
            DisplayRecommendedProducts();
            picture1.Image = Image.FromFile(@"C:\Users\Administrator\Desktop\Suiren\Morning Routine\cleanser_gentle.jpg");
            picture1.SizeMode = PictureBoxSizeMode.StretchImage;
            picture2.Image = Image.FromFile(@"C:\Users\Administrator\Desktop\Suiren\Morning Routine\cleanser_salicylic.jpg");
            picture2.SizeMode = PictureBoxSizeMode.StretchImage;
            picture3.Image = Image.FromFile(@"C:\Users\Administrator\Desktop\Suiren\Night Routine\cleanser_oil_based.jpg");
            picture3.SizeMode = PictureBoxSizeMode.StretchImage;
            picture4.Image = Image.FromFile(@"C:\Users\Administrator\Desktop\Suiren\Night Routine\serum_bakuchiol.jpg");
            picture4.SizeMode = PictureBoxSizeMode.StretchImage;
            picture5.Image = Image.FromFile(@"C:\Users\Administrator\Desktop\Suiren\Night Routine\treatment_retinol_layering.jpg");
            picture5.SizeMode = PictureBoxSizeMode.StretchImage;

        }
        private void DisplayRecommendedProducts() 
        {
            

        }

        private void btn5_Click(object sender, EventArgs e)
        {
            string message =
                "📌 **Product Information**\n\n" +
                "🔹 **Product Name:** The Inkey List Retinol + CeraVe PM Lotion\n" +
                "💰 **Price:** ₱1,000.00 (Combined Estimate)\n" +
                "🛒 **Where to Buy:** Available online via Shopee, Lazada, Watsons.\n\n" +
                "🔍 **General Purpose:**\n" +
                "Combines retinol benefits with CeraVe’s hydrating PM lotion for anti-aging.\n\n" +
                "🧴 **How to Use:**\n" +
                "Apply retinol serum first, followed by PM lotion nightly.";
            MessageBox.Show(message, "Product Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            string message =
                "📌 **Product Information**\n\n" +
                "🔹 **Product Name:** CeraVe Moisturizing Cream\n" +
                "💰 **Price:** ₱1,100.00 (Estimated)\n" +
                "🛒 **Where to Buy:** Available at drugstores and online platforms like Shopee and Lazada.\n\n" +
                "🔍 **General Purpose:**\n" +
                "Provides all-day hydration and helps restore protective skin barrier.\n\n" +
                "🧴 **How to Use:**\n" +
                "Apply liberally as needed on face and body.";
            MessageBox.Show(message, "Product Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            string message =
                "📌 **Product Information**\n\n" +
                "🔹 **Product Name:** CeraVe Foaming Facial Cleanser\n" +
                "💰 **Price:** ₱850.00 (Estimated)\n" +
                "🛒 **Where to Buy:** Available at Watsons, Mercury Drug, Shopee, and Lazada.\n\n" +
                "🔍 **General Purpose:**\n" +
                "Cleanses and removes oil without disrupting the protective skin barrier. Best for normal to oily skin.\n\n" +
                "🧴 **How to Use:**\n" +
                "Use morning and night. Massage onto wet skin and rinse thoroughly.";
            MessageBox.Show(message, "Product Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            string message =
                "📌 **Product Information**\n\n" +
                "🔹 **Product Name:** CeraVe SA Cleanser for Acne-Prone Skin\n" +
                "💰 **Price:** ₱900.00 (Estimated)\n" +
                "🛒 **Where to Buy:** Available at Watsons, Mercury Drug, and online via Shopee or Lazada.\n\n" +
                "🔍 **General Purpose:**\n" +
                "Formulated with salicylic acid, this cleanser gently exfoliates and unclogs pores without over-drying the skin. Ideal for acne-prone and rough skin types.\n\n" +
                "🧴 **How to Use:**\n" +
                "Use daily on wet skin. Gently massage into the skin in a circular motion, then rinse thoroughly.";

            MessageBox.Show(message, "Product Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            string message =
                "📌 **Product Information**\n\n" +
                "🔹 **Product Name:** CeraVe Hydrating Facial Cleanser\n" +
                "💰 **Price:** ₱850.00 (Estimated)\n" +
                "🛒 **Where to Buy:** Available at Watsons, Mercury Drug, and online via Shopee or Lazada.\n\n" +
                "🔍 **General Purpose:**\n" +
                "This gentle cleanser helps remove dirt, oil, and makeup without stripping the skin's natural barrier. Ideal for normal to dry skin, it contains ceramides and hyaluronic acid to hydrate and protect.\n\n" +
                "🧴 **How to Use:**\n" +
                "Use twice daily — apply to wet skin, gently massage in circular motions, then rinse thoroughly with lukewarm water.";

            MessageBox.Show(message, "Product Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AllProducts allProductsForm = new AllProducts();

            MainFrame mainFrame = this.TopLevelControl as MainFrame;
            if (mainFrame != null)
            {
                mainFrame.LoadFormInPanel(allProductsForm);
            }
        }
    }
}
