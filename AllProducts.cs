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
    public partial class AllProducts : Form
    {
        public AllProducts()
        {
            InitializeComponent();
        }

        private void AllProducts_Load(object sender, EventArgs e)
        {
            picture1.Image = Image.FromFile(@"C:\Users\Administrator\Desktop\Suiren\Morning Routine\cleanser_gentle.jpg");
            picture1.SizeMode = PictureBoxSizeMode.StretchImage;
            picture2.Image = Image.FromFile(@"C:\Users\Administrator\Desktop\Suiren\Morning Routine\cleanser_salicylic.jpg");
            picture2.SizeMode = PictureBoxSizeMode.StretchImage;
            picture3.Image = Image.FromFile(@"C:\Users\Administrator\Desktop\Suiren\Morning Routine\serum_vitamin_c.jpg");
            picture3.SizeMode = PictureBoxSizeMode.StretchImage;
            picture4.Image = Image.FromFile(@"C:\Users\Administrator\Desktop\Suiren\Morning Routine\toner_hydrating.jpg");
            picture4.SizeMode = PictureBoxSizeMode.StretchImage;
            picture5.Image = Image.FromFile(@"C:\Users\Administrator\Desktop\Suiren\Morning Routine\serum_antioxidant.jpg");
            picture5.SizeMode = PictureBoxSizeMode.StretchImage;
            picture6.Image = Image.FromFile(@"C:\Users\Administrator\Desktop\Suiren\Morning Routine\toner_oil_control.jpg");
            picture6.SizeMode = PictureBoxSizeMode.StretchImage;
            picture7.Image = Image.FromFile(@"C:\Users\Administrator\Desktop\Suiren\Morning Routine\exfoliant_bha.jpg");
            picture7.SizeMode = PictureBoxSizeMode.StretchImage;
            picture8.Image = Image.FromFile(@"C:\Users\Administrator\Desktop\Suiren\Morning Routine\vitamin_c_spf.jpg");
            picture8.SizeMode = PictureBoxSizeMode.StretchImage;
            picture9.Image = Image.FromFile(@"C:\Users\Administrator\Desktop\Suiren\Morning Routine\toner_exfoliating.jpg");
            picture9.SizeMode = PictureBoxSizeMode.StretchImage;
            picture10.Image = Image.FromFile(@"C:\Users\Administrator\Desktop\Suiren\Morning Routine\moisturizer_gel.jpg");
            picture10.SizeMode = PictureBoxSizeMode.StretchImage;
            picture11.Image = Image.FromFile(@"C:\Users\Administrator\Desktop\Suiren\Morning Routine\serum_hydrating.jpg");
            picture11.SizeMode = PictureBoxSizeMode.StretchImage;
            picture12.Image = Image.FromFile(@"C:\Users\Administrator\Desktop\Suiren\Morning Routine\toner_balancing.jpg");
            picture12.SizeMode = PictureBoxSizeMode.StretchImage;
            picture13.Image = Image.FromFile(@"C:\Users\Administrator\Desktop\Suiren\Morning Routine\cleanser_calming.jpg");
            picture13.SizeMode = PictureBoxSizeMode.StretchImage;
            picture14.Image = Image.FromFile(@"C:\Users\Administrator\Desktop\Suiren\Morning Routine\sunscreen_noncomedogenic.jpg");
            picture14.SizeMode = PictureBoxSizeMode.StretchImage;
            picture15.Image = Image.FromFile(@"C:\Users\Administrator\Desktop\Suiren\Morning Routine\serum_brightening.jpg");
            picture15.SizeMode = PictureBoxSizeMode.StretchImage;
            picture16.Image = Image.FromFile(@"C:\Users\Administrator\Desktop\Suiren\Morning Routine\serum_niacinamide.jpg");
            picture16.SizeMode = PictureBoxSizeMode.StretchImage;
            picture17.Image = Image.FromFile(@"C:\Users\Administrator\Desktop\Suiren\Morning Routine\exfoliant_pha.jpg");
            picture17.SizeMode = PictureBoxSizeMode.StretchImage;
            picture18.Image = Image.FromFile(@"C:\Users\Administrator\Desktop\Suiren\Morning Routine\serum_azelaic_acid.jpg");
            picture18.SizeMode = PictureBoxSizeMode.StretchImage;
            picture19.Image = Image.FromFile(@"C:\Users\Administrator\Desktop\Suiren\Morning Routine\serum_peptide.jpg");
            picture19.SizeMode = PictureBoxSizeMode.StretchImage;
            picture20.Image = Image.FromFile(@"C:\Users\Administrator\Desktop\Suiren\Morning Routine\serum_hyaluronic_acid.jpg");
            picture20.SizeMode = PictureBoxSizeMode.StretchImage;
            picture21.Image = Image.FromFile(@"C:\Users\Administrator\Desktop\Suiren\Morning Routine\moisturizer_hypoallergenic.jpg");
            picture21.SizeMode = PictureBoxSizeMode.StretchImage;

            picture22.Image = Image.FromFile(@"C:\Users\Administrator\Desktop\Suiren\Night Routine\cleanser_oil_based.jpg");
            picture22.SizeMode = PictureBoxSizeMode.StretchImage;
            picture23.Image = Image.FromFile(@"C:\Users\Administrator\Desktop\Suiren\Night Routine\serum_retinol.jpg");
            picture23.SizeMode = PictureBoxSizeMode.StretchImage;
            picture24.Image = Image.FromFile(@"C:\Users\Administrator\Desktop\Suiren\Night Routine\serum_niacinamide.jpg");
            picture24.SizeMode = PictureBoxSizeMode.StretchImage;
            picture25.Image = Image.FromFile(@"C:\Users\Administrator\Desktop\Suiren\Night Routine\moisturizer_ceramide.jpg");
            picture25.SizeMode = PictureBoxSizeMode.StretchImage;
            picture26.Image = Image.FromFile(@"C:\Users\Administrator\Desktop\Suiren\Night Routine\serum_bakuchiol.jpg");
            picture26.SizeMode = PictureBoxSizeMode.StretchImage;
            picture27.Image = Image.FromFile(@"C:\Users\Administrator\Desktop\Suiren\Night Routine\mask_clay.jpg");
            picture27.SizeMode = PictureBoxSizeMode.StretchImage;
            picture28.Image = Image.FromFile(@"C:\Users\Administrator\Desktop\Suiren\Night Routine\night_cream_brightening.jpg");
            picture28.SizeMode = PictureBoxSizeMode.StretchImage;
            picture29.Image = Image.FromFile(@"C:\Users\Administrator\Desktop\Suiren\Night Routine\night_cream_oil_free.jpg");
            picture29.SizeMode = PictureBoxSizeMode.StretchImage;
            picture30.Image = Image.FromFile(@"C:\Users\Administrator\Desktop\Suiren\Night Routine\moisturizer_emollient.jpg");
            picture30.SizeMode = PictureBoxSizeMode.StretchImage;
            picture31.Image = Image.FromFile(@"C:\Users\Administrator\Desktop\Suiren\Night Routine\treatment_spot.jpg");
            picture31.SizeMode = PictureBoxSizeMode.StretchImage;
            picture32.Image = Image.FromFile(@"C:\Users\Administrator\Desktop\Suiren\Night Routine\treatment_area_specific.jpg");
            picture32.SizeMode = PictureBoxSizeMode.StretchImage;
            picture33.Image = Image.FromFile(@"C:\Users\Administrator\Desktop\Suiren\Night Routine\cream_cica.jpg");
            picture33.SizeMode = PictureBoxSizeMode.StretchImage;
            picture34.Image = Image.FromFile(@"C:\Users\Administrator\Desktop\Suiren\Night Routine\mask_detox.jpg");
            picture34.SizeMode = PictureBoxSizeMode.StretchImage;
            picture35.Image = Image.FromFile(@"C:\Users\Administrator\Desktop\Suiren\Night Routine\exfoliant_aha_bha.jpg");
            picture35.SizeMode = PictureBoxSizeMode.StretchImage;
            picture36.Image = Image.FromFile(@"C:\Users\Administrator\Desktop\Suiren\Night Routine\treatment_bpo.jpg");
            picture36.SizeMode = PictureBoxSizeMode.StretchImage;
            picture37.Image = Image.FromFile(@"C:\Users\Administrator\Desktop\Suiren\Night Routine\retinoid_gentle.jpg");
            picture37.SizeMode = PictureBoxSizeMode.StretchImage;
            picture38.Image = Image.FromFile(@"C:\Users\Administrator\Desktop\Suiren\Night Routine\acid_mandelic.jpg");
            picture38.SizeMode = PictureBoxSizeMode.StretchImage;
            picture39.Image = Image.FromFile(@"C:\Users\Administrator\Desktop\Suiren\Night Routine\treatment_retinol_layering.jpg");
            picture39.SizeMode = PictureBoxSizeMode.StretchImage;
            picture40.Image = Image.FromFile(@"C:\Users\Administrator\Desktop\Suiren\Night Routine\mask_sleeping.jpg");
            picture40.SizeMode = PictureBoxSizeMode.StretchImage;
            picture41.Image = Image.FromFile(@"C:\Users\Administrator\Desktop\Suiren\Night Routine\barrier_cream.jpg");
            picture41.SizeMode = PictureBoxSizeMode.StretchImage;
            picture42.Image = Image.FromFile(@"C:\Users\Administrator\Desktop\Suiren\Night Routine\product_sunscreen.jpg");
            picture42.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void btn14_Click(object sender, EventArgs e)
        {
            string message =
                "📌 **Product Information**\n\n" +
                "🔹 **Product Name:** Some By Mi Galactomyces Pure Vitamin C Glow Serum\n" +
                "💰 **Price:** ₱990.00 (Estimated)\n" +
                "🛒 **Where to Buy:** Available on BeautyMNL, Shopee, and Lazada.\n\n" +
                "🔍 **General Purpose:**\n" +
                "Brightens dull skin and helps fade dark spots with galactomyces and pure vitamin C.\n\n" +
                "🧴 **How to Use:**\n" +
                "Apply a few drops after toner and before moisturizer in your nighttime routine.";

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

        private void btn4_Click(object sender, EventArgs e)
        {
            string message =
                "📌 **Product Information**\n\n" +
                "🔹 **Product Name:** Klairs Supple Preparation Toner\n" +
                "💰 **Price:** ₱920.00 (Estimated)\n" +
                "🛒 **Where to Buy:** Available on BeautyMNL, Shopee, and Althea Korea.\n\n" +
                "🔍 **General Purpose:**\n" +
                "Balances pH level and deeply hydrates the skin. Prepares the skin to absorb serums and creams more effectively.\n\n" +
                "🧴 **How to Use:**\n" +
                "After cleansing, dispense onto a cotton pad or hands and gently pat into the skin.";

            MessageBox.Show(message, "Product Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            string message =
                "📌 **Product Information**\n\n" +
                "🔹 **Product Name:** La Roche-Posay Pure Vitamin C10\n" +
                "💰 **Price:** ₱2,450.00 (Estimated)\n" +
                "🛒 **Where to Buy:** Available in dermatology clinics, Lazada, Shopee, and official La Roche-Posay resellers.\n\n" +
                "🔍 **General Purpose:**\n" +
                "Brightens skin and reduces the appearance of fine lines with pure Vitamin C, salicylic acid, and neurosensine for sensitive skin.\n\n" +
                "🧴 **How to Use:**\n" +
                "Apply in the morning on face and neck, followed by sunscreen. Use a few drops and gently massage into skin.";

            MessageBox.Show(message, "Product Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            string message =
                "📌 **Product Information**\n\n" +
                "🔹 **Product Name:** SkinCeuticals C E Ferulic\n" +
                "💰 **Price:** ₱9,500.00 (Estimated)\n" +
                "🛒 **Where to Buy:** Available at authorized SkinCeuticals retailers and dermatology clinics.\n\n" +
                "🔍 **General Purpose:**\n" +
                "Combines Vitamin C, E, and ferulic acid to protect against environmental damage and improve signs of aging.\n\n" +
                "🧴 **How to Use:**\n" +
                "Apply 4-5 drops to a dry face, neck, and chest every morning before sunscreen.";

            MessageBox.Show(message, "Product Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            string message =
                "📌 **Product Information**\n\n" +
                "🔹 **Product Name:** Pixi Clarity Tonic\n" +
                "💰 **Price:** ₱1,290.00 (Estimated)\n" +
                "🛒 **Where to Buy:** Available at SM Beauty, Sephora PH, and online on Shopee or Lazada.\n\n" +
                "🔍 **General Purpose:**\n" +
                "Clarifies skin and minimizes pores with a blend of salicylic acid, glycolic acid, and lactic acid. Suitable for blemish-prone skin.\n\n" +
                "🧴 **How to Use:**\n" +
                "Use daily after cleansing. Apply with a cotton pad across face and neck, avoiding the eye area.";

            MessageBox.Show(message, "Product Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            string message =
                "📌 **Product Information**\n\n" +
                "🔹 **Product Name:** The Ordinary Glycol Acid 7% Toning Solution\n" +
                "💰 **Price:** ₱800.00 (Estimated)\n" +
                "🛒 **Where to Buy:** Available via Deciem, Shopee, and Lazada.\n\n" +
                "🔍 **General Purpose:**\n" +
                "Exfoliates skin surface to improve texture and clarity. Suita for dull and uneven skin.\n\n" +
                "🧴 **How to Use:**\n" +
                "Use ideally in the PM, no more than once per day. Apply with a cotton pad across the face and neck.";

            MessageBox.Show(message, "Product Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            string message =
                "📌 **Product Information**\n\n" +
                "🔹 **Product Name:** Neutrogena Bright Boost Moisturizer SPF 30\n" +
                "💰 **Price:** ₱1,100.00 (Estimated)\n" +
                "🛒 **Where to Buy:** Available at Watsons, Mercury Drug, Shopee, ann\n" +
                "🔍 **General Purpose:**\n" +
                "Boosts skin radiance and protects from sun damage with SPF. Includes Neoglucosamine, AHA, and PHA.\n\n" +
                "🧴 **How to Use:**\n" +
                "Apply evenly on th face and neck as the last step in your morning skincare routine.";

            MessageBox.Show(message, "Product Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn10_Click(object sender, EventArgs e)
        {
            string message =
                "📌 **Product Information**\n\n" +
                "🔹 **Product Name:** The Ordinary Hyaluronic Acid 2% + B5\n" +
                "💰 **Price:** ₱700.00 (Estimated)\n" +
                "🛒 **Where to Buy:** Available via Deciem, Shopee, and Lazada.\n\n" +
                "🔍 **General Purpose:**\n" +
                "Hydrates the skin by drawing moisture into the outer layers and enhances surface smoothness.\n\n" +
                "🧴 **How to Use:**\n" +
                "Apply a few drops to the face in the morning and evening before creams.";

            MessageBox.Show(message, "Product Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn15_Click(object sender, EventArgs e)
        {
            string message =
                "📌 **Product Information**\n\n" +
                "🔹 **Product Name:** The Ordinary Niacinamide 10% + Zinc 1%\n" +
                "💰 **Price:** ₱650.00 (Estimated)\n" +
                "🛒 **Where to Buy:** Available via Deciem, Shopee, and Lazada.\n\n" +
                "🔍 **General Purpose:**\n" +
                "Minimizes pores, controls sebum, and reduces blemishes. Suitable for oily and acne-prone skin.\n\n" +
                "🧴 **How to Use:**\n" +
                "Use in the morning and evening before creams. Avoid combining with vitamin C.";

            MessageBox.Show(message, "Product Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn13_Click(object sender, EventArgs e)
        {
            string message =
                "📌 **Product Information**\n\n" +
                "🔹 **Product Name:** EltaMD UV Clear Broad-Spectrum SPF 46\n" +
                "💰 **Price:** ₱2,300.00 (Estimated)\n" +
                "🛒 **Where to Buy:** Available via authorized dermatology clinics, Shopee, and Lazada.\n\n" +
                "🔍 **General Purpose:**\n" +
                "Lightweight sunscreen formulated for sensitive or acne-prone skin. Contains niacinamide and hyaluronic acid.\n\n" +
                "🧴 **How to Use:**\n" +
                "Apply liberally to face 15 minutes before sun exposure. Reapply every 2 hours or after swimming.";

            MessageBox.Show(message, "Product Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn12_Click(object sender, EventArgs e)
        {
            string message =
                "📌 **Product Information**\n\n" +
                "🔹 **Product Name:** Vanicream Gentle Facial Cleanser\n" +
                "💰 **Price:** ₱950.00 (Estimated)\n" +
                "🛒 **Where to Buy:** Available at Mercury Drug, Healthy Options, and online via Shopee or Lazada.\n\n" +
                "🔍 **General Purpose:**\n" +
                "A mild, non-irritating cleanser for sensitive skin. Free from dyes, fragrance, parabens, and other common irritants.\n\n" +
                "🧴 **How to Use:**\n" +
                "Use morning and night. Apply to damp skin, massage gently, and rinse thoroughly.";

            MessageBox.Show(message, "Product Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn11_Click(object sender, EventArgs e)
        {
            string message =
                "📌 **Product Information**\n\n" +
                "🔹 **Product Name:** Etude House SoonJung pH 5.5 Relief Toner\n" +
                "💰 **Price:** ₱600.00 (Estimated)\n" +
                "🛒 **Where to Buy:** Available at Etude House stores and Shopee.\n\n" +
                "🔍 **General Purpose:**\n" +
                "Soothes and strengthens sensitive skin with panthenol and madecassoside. Low pH for barrier protection.\n\n" +
                "🧴 **How to Use:**\n" +
                "Apply with a cotton pad or palms after cleansing. Gently pat for absorption.";

            MessageBox.Show(message, "Product Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn20_Click(object sender, EventArgs e)
        {
            string message =
                "📌 **Product Information**\n\n" +
                "🔹 **Product Name:** Aveeno Calm + Restore Moisturizer\n" +
                "💰 **Price:** ₱1,200.00 (Estimated)\n" +
                "🛒 **Where to Buy:** Available at Watsons, Mercury Drug, and online platforms.\n\n" +
                "🔍 **General Purpose:**\n" +
                "Designed for sensitive skin to restore moisture and soothe irritation.\n\n" +
                "🧴 **How to Use:**\n" +
                "Apply to clean skin as needed, morning and night.";

            MessageBox.Show(message, "Product Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn19_Click(object sender, EventArgs e)
        {
            string message =
                "📌 **Product Information**\n\n" +
                "🔹 **Product Name:** La Roche-Posay Hyalu B5 Serum\n" +
                "💰 **Price:** ₱2,400.00 (Estimated)\n" +
                "🛒 **Where to Buy:** Available at selected dermatology clinics, Watsons, and online.\n\n" +
                "🔍 **General Purpose:**\n" +
                "Hydrating serum with hyaluronic acid and vitamin B5 to plump and soothe skin.\n\n" +
                "🧴 **How to Use:**\n" +
                "Use morning and/or evening before moisturizer.";

            MessageBox.Show(message, "Product Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn18_Click(object sender, EventArgs e)
        {
            string message =
                "📌 **Product Information**\n\n" +
                "🔹 **Product Name:** The INKEY List Collagen Booster\n" +
                "💰 **Price:** ₱950.00 (Estimated)\n" +
                "🛒 **Where to Buy:** Available on Cult Beauty, Shopee, and Lazada.\n\n" +
                "🔍 **General Purpose:**\n" +
                "Supports natural collagen production, making skin appear plumper and firmer.\n\n" +
                "🧴 **How to Use:**\n" +
                "Apply a pea-sized amount to cleansed skin before serums and moisturizers.";

            MessageBox.Show(message, "Product Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn17_Click(object sender, EventArgs e)
        {
            string message =
                "📌 **Product Information**\n\n" +
                "🔹 **Product Name:** The Ordinary Azelaic Acid Suspension 10%\n" +
                "💰 **Price:** ₱700.00 (Estimated)\n" +
                "🛒 **Where to Buy:** Available via Deciem, Shopee, and Lazada.\n\n" +
                "🔍 **General Purpose:**\n" +
                "Brightens skin tone, improves skin texture, and reduces the look of blemishes.\n\n" +
                "🧴 **How to Use:**\n" +
                "Apply to face once or twice daily, avoiding eyes and mouth.";

            MessageBox.Show(message, "Product Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn16_Click(object sender, EventArgs e)
        {
            string message =
                "📌 **Product Information**\n\n" +
                "🔹 **Product Name:** Glow Recipe Watermelon Glow PHA+BHA Toner\n" +
                "💰 **Price:** ₱2,000.00 (Estimated)\n" +
                "🛒 **Where to Buy:** Available at Sephora Philippines and online stores like Shopee.\n\n" +
                "🔍 **General Purpose:**\n" +
                "Hydrating toner that smoothens skin and refines pores using gentle exfoliants.\n\n" +
                "🧴 **How to Use:**\n" +
                "After cleansing, dispense into hands or cotton pad and pat into skin. Use daily.";

            MessageBox.Show(message, "Product Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn25_Click(object sender, EventArgs e)
        {
            string message =
                "📌 **Product Information**\n\n" +
                "🔹 **Product Name:** The Ordinary Alpha Arbutin 2% + HA\n" +
                "💰 **Price:** ₱700.00 (Estimated)\n" +
                "🛒 **Where to Buy:** Available online via Deciem, Shopee, Lazada.\n\n" +
                "🔍 **General Purpose:**\n" +
                "Targets hyperpigmentation and dark spots with hyaluronic acid for hydration.\n\n" +
                "🧴 **How to Use:**\n" +
                "Use a few drops on face in the morning and evening as part of skincare routine.";
            MessageBox.Show(message, "Product Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn24_Click(object sender, EventArgs e)
        {
            string message =
                "📌 **Product Information**\n\n" +
                "🔹 **Product Name:** The Ordinary Niacinamide 10% + Zinc 1%\n" +
                "💰 **Price:** ₱590.00 (Estimated)\n" +
                "🛒 **Where to Buy:** Available at Deciem, Shopee, and Lazada.\n\n" +
                "🔍 **General Purpose:**\n" +
                "Reduces the appearance of skin blemishes and congestion.\n\n" +
                "🧴 **How to Use:**\n" +
                "Apply to entire face morning and evening before heavier creams.";
            MessageBox.Show(message, "Product Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn23_Click(object sender, EventArgs e)
        {
            string message =
                "📌 **Product Information**\n\n" +
                "🔹 **Product Name:** The Ordinary Retinol 0.5% in Squalane\n" +
                "💰 **Price:** ₱600.00 (Estimated)\n" +
                "🛒 **Where to Buy:** Available on Deciem, Shopee, and Lazada.\n\n" +
                "🔍 **General Purpose:**\n" +
                "Targets signs of aging and improves skin texture and tone.\n\n" +
                "🧴 **How to Use:**\n" +
                "Use at night after water-based serums, followed by moisturizer. Avoid sunlight exposure.";
            MessageBox.Show(message, "Product Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn22_Click(object sender, EventArgs e)
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

        private void btn21_Click(object sender, EventArgs e)
        {
            string message =
                "📌 **Product Information**\n\n" +
                "🔹 **Product Name:** Heimish All Clean Balm\n" +
                "💰 **Price:** ₱750.00 (Estimated)\n" +
                "🛒 **Where to Buy:** Available at Althea, Shopee, and Lazada.\n\n" +
                "🔍 **General Purpose:**\n" +
                "A sherbet-type balm cleanser that melts away makeup and sunscreen without irritation.\n\n" +
                "🧴 **How to Use:**\n" +
                "Scoop out balm, massage onto dry face, add water to emulsify, then rinse off.";

            MessageBox.Show(message, "Product Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn30_Click(object sender, EventArgs e)
        {
            string message =
                "📌 **Product Information**\n\n" +
                "🔹 **Product Name:** Olay Luminous Overnight Mask\n" +
                "💰 **Price:** ₱1,300.00 (Estimated)\n" +
                "🛒 **Where to Buy:** Available at Watsons, department stores, and online.\n\n" +
                "🔍 **General Purpose:**\n" +
                "Hydrates and brightens skin overnight for glowing complexion.\n\n" +
                "🧴 **How to Use:**\n" +
                "Apply at night as final step of skincare. Do not rinse.";
            MessageBox.Show(message, "Product Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn29_Click(object sender, EventArgs e)
        {
            string message =
                "📌 **Product Information**\n\n" +
                "🔹 **Product Name:** Pixi Glow Tonic\n" +
                "💰 **Price:** ₱1,090.00 (Estimated)\n" +
                "🛒 **Where to Buy:** Available at Sephora, Shopee, and Lazada.\n\n" +
                "🔍 **General Purpose:**\n" +
                "Exfoliating toner with glycolic acid to brighten and smooth skin.\n\n" +
                "🧴 **How to Use:**\n" +
                "Use with cotton pad on clean skin, preferably at night. Avoid eye area.";
            MessageBox.Show(message, "Product Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn28_Click(object sender, EventArgs e)
        {
            string message =
                "📌 **Product Information**\n\n" +
                "🔹 **Product Name:** Aztec Secret Indian Healing Clay\n" +
                "💰 **Price:** ₱550.00 (Estimated)\n" +
                "🛒 **Where to Buy:** Available on iHerb, Shopee, and Lazada.\n\n" +
                "🔍 **General Purpose:**\n" +
                "Deep pore cleansing mask with natural calcium bentonite clay.\n\n" +
                "🧴 **How to Use:**\n" +
                "Mix with apple cider vinegar or water, apply to face, leave on 10–15 mins, rinse off.";
            MessageBox.Show(message, "Product Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn27_Click(object sender, EventArgs e)
        {
            string message =
                "📌 **Product Information**\n\n" +
                "🔹 **Product Name:** BYBI Bakuchiol Booster\n" +
                "💰 **Price:** ₱1,300.00 (Estimated)\n" +
                "🛒 **Where to Buy:** Available at Sephora, Shopee, and Lazada.\n\n" +
                "🔍 **General Purpose:**\n" +
                "Natural retinol alternative to reduce fine lines and boost collagen.\n\n" +
                "🧴 **How to Use:**\n" +
                "Use alone or mix 2-3 drops into serum or moisturizer at night.";
            MessageBox.Show(message, "Product Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn26_Click(object sender, EventArgs e)
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

        private void btn35_Click(object sender, EventArgs e)
        {
            string message =
                "📌 **Product Information**\n\n" +
                "🔹 **Product Name:** Origins Clear Improvement Active Charcoal Mask\n" +
                "💰 **Price:** ₱1,500.00 (Estimated)\n" +
                "🛒 **Where to Buy:** Available at Origins, Sephora, and online.\n\n" +
                "🔍 **General Purpose:**\n" +
                "Deep-cleans pores and removes impurities using activated charcoal.\n\n" +
                "🧴 **How to Use:**\n" +
                "Use 1–2 times a week. Apply, leave for 10 minutes, then rinse.";
            MessageBox.Show(message, "Product Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn34_Click(object sender, EventArgs e)
        {
            string message =
                "📌 **Product Information**\n\n" +
                "🔹 **Product Name:** Etude House SoonJung Cica Relief Cream\n" +
                "💰 **Price:** ₱750.00 (Estimated)\n" +
                "🛒 **Where to Buy:** Etude House stores, Shopee, Lazada.\n\n" +
                "🔍 **General Purpose:**\n" +
                "Soothing cream that calms irritation with Centella Asiatica and panthenol.\n\n" +
                "🧴 **How to Use:**\n" +
                "Apply as the final step of skincare to calm sensitive skin.";
            MessageBox.Show(message, "Product Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn33_Click(object sender, EventArgs e)
        {
            string message =
                "📌 **Product Information**\n\n" +
                "🔹 **Product Name:** Clean & Clear Advantage Acne Spot Treatment\n" +
                "💰 **Price:** ₱300.00 (Estimated)\n" +
                "🛒 **Where to Buy:** Watsons, Mercury Drug, Shopee, Lazada.\n\n" +
                "🔍 **General Purpose:**\n" +
                "Treats and reduces the appearance of pimples quickly.\n\n" +
                "🧴 **How to Use:**\n" +
                "Apply a thin layer directly onto pimples 1–3 times daily.";
            MessageBox.Show(message, "Product Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn32_Click(object sender, EventArgs e)
        {
            string message =
                "📌 **Product Information**\n\n" +
                "🔹 **Product Name:** First Aid Beauty Ultra Repair Cream\n" +
                "💰 **Price:** ₱1,700.00 (Estimated)\n" +
                "🛒 **Where to Buy:** Available at Sephora, Shopee, and Lazada.\n\n" +
                "🔍 **General Purpose:**\n" +
                "Intensely hydrates dry, distressed skin and eczema with colloidal oatmeal.\n\n" +
                "🧴 **How to Use:**\n" +
                "Apply as needed to face and body, especially on dry patches.";
            MessageBox.Show(message, "Product Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn31_Click(object sender, EventArgs e)
        {
            string message =
                "📌 **Product Information**\n\n" +
                "🔹 **Product Name:** Neutrogena Oil-Free Moisture\n" +
                "💰 **Price:** ₱650.00 (Estimated)\n" +
                "🛒 **Where to Buy:** Available at Watsons, Mercury Drug, Shopee, and Lazada.\n\n" +
                "🔍 **General Purpose:**\n" +
                "Lightweight moisturizer ideal for oily and combination skin.\n\n" +
                "🧴 **How to Use:**\n" +
                "Apply after cleansing and toning, morning and evening.";
            MessageBox.Show(message, "Product Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn40_Click(object sender, EventArgs e)
        {
            string message =
                "📌 **Product Information**\n\n" +
                "🔹 **Product Name:** Laneige Water Sleeping Mask\n" +
                "💰 **Price:** ₱1,400.00 (Estimated)\n" +
                "🛒 **Where to Buy:** Laneige stores, Sephora, Shopee, Lazada.\n\n" +
                "🔍 **General Purpose:**\n" +
                "Overnight gel mask that deeply hydrates and refreshes tired skin.\n\n" +
                "🧴 **How to Use:**\n" +
                "Apply a generous layer at night after moisturizer. Rinse in morning.";
            MessageBox.Show(message, "Product Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn39_Click(object sender, EventArgs e)
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

        private void btn38_Click(object sender, EventArgs e)
        {
            string message =
                "📌 **Product Information**\n\n" +
                "🔹 **Product Name:** By Wishtrend Mandelic Acid 5% Skin Prep Water\n" +
                "💰 **Price:** ₱1,200.00 (Estimated)\n" +
                "🛒 **Where to Buy:** Wishtrend website, Shopee, Lazada.\n\n" +
                "🔍 **General Purpose:**\n" +
                "Gentle exfoliator suitable for sensitive skin, helps with pigmentation and texture.\n\n" +
                "🧴 **How to Use:**\n" +
                "Apply with cotton pad after cleansing 3–4 times a week.";
            MessageBox.Show(message, "Product Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn37_Click(object sender, EventArgs e)
        {
            string message =
                "📌 **Product Information**\n\n" +
                "🔹 **Product Name:** Differin Adapalene Gel 0.1%\n" +
                "💰 **Price:** ₱850.00 (Estimated)\n" +
                "🛒 **Where to Buy:** Mercury Drug, Shopee, and Lazada.\n\n" +
                "🔍 **General Purpose:**\n" +
                "Prescription-strength retinoid for treating acne.\n\n" +
                "🧴 **How to Use:**\n" +
                "Use a thin layer at night after cleansing. Avoid eyes and lips.";
            MessageBox.Show(message, "Product Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn36_Click(object sender, EventArgs e)
        {
            string message =
                "📌 **Product Information**\n\n" +
                "🔹 **Product Name:** CosRx AHA/BHA Clarifying Treatment Toner\n" +
                "💰 **Price:** ₱750.00 (Estimated)\n" +
                "🛒 **Where to Buy:** Available at Watsons, Shopee, and Lazada.\n\n" +
                "🔍 **General Purpose:**\n" +
                "Gently exfoliates to clear pores, smooth texture, and even skin tone.\n\n" +
                "🧴 **How to Use:**\n" +
                "Spray on cotton pad and sweep over face after cleansing.";
            MessageBox.Show(message, "Product Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn42_Click(object sender, EventArgs e)
        {

        }

        private void btn41_Click(object sender, EventArgs e)
        {
            string message =
                "📌 **Product Information**\n\n" +
                "🔹 **Product Name:** La Roche-Posay Cicaplast Baume B5\n" +
                "💰 **Price:** ₱900.00 (Estimated)\n" +
                "🛒 **Where to Buy:** Mercury Drug, Watsons, Shopee, Lazada.\n\n" +
                "🔍 **General Purpose:**\n" +
                "Multi-purpose soothing balm for irritated or dry skin. Suitable for sensitive skin.\n\n" +
                "🧴 **How to Use:**\n" +
                "Apply twice daily to affected areas. Can be used on face and body.";
            MessageBox.Show(message, "Product Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            string message =
                "📌 **Product Information**\n\n" +
                "🔹 **Product Name:** Paula's Choice Skin Perfecting 2% BHA\n" +
                "💰 **Price:** ₱1,650.00 (Estimated)\n" +
                "🛒 **Where to Buy:** Available on Paula’s Choice website, BeautyMNL, Shopee, and Lazada.\n\n" +
                "🔍 **General Purpose:**\n" +
                "Exfoliates inside the pores to clear up breakouts and blackheads. Ideal for oily and acne-prone skin.\n\n" +
                "🧴 **How to Use:**\n" +
                "Apply once or twice daily after cleansing and toning. No need to rinse off. Follow with moisturizer.";

            MessageBox.Show(message, "Product Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void SearchItem_TextChanged(object sender, EventArgs e)
        {

        }

        private void picture26_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            RecommendedProducts recommendedForm = new RecommendedProducts("morning", "evening");

            // Get reference to the parent MainFrame
            MainFrame mainFrame = this.TopLevelControl as MainFrame;
            if (mainFrame != null)
            {
                // Load RecommendedProducts into panel2 of MainFrame
                mainFrame.LoadFormInPanel(recommendedForm);
            }
        }
    }
}
