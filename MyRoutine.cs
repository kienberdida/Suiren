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
            public partial class MyRoutine : Form
            {

                private string skinType;
                private string skinTone;
                private string skinConcerns;
                private string skincareGoals;
                private string morningRoutine = "";
                private string eveningRoutine = "";
                

                public MyRoutine(string skinType, string skinTone, string skinConcerns, string skincareGoals)
                {
                    InitializeComponent();
                    this.skinType = skinType;
                    this.skinTone = skinTone;
                    this.skinConcerns = skinConcerns;
                    this.skincareGoals = skincareGoals;
                }

                private void textBox2_TextChanged(object sender, EventArgs e)
                {

                }

                private void checkBox2_CheckedChanged(object sender, EventArgs e)
                {

                }
                public void LoadFormIntoPanel(Form form)
                {
                    panel2.Controls.Clear();
                    form.TopLevel = false;
                    form.FormBorderStyle = FormBorderStyle.None;
                    form.Dock = DockStyle.Fill;
                    panel2.Controls.Add(form);
                    form.Show();
                }
                private void MyRoutine_Load(object sender, EventArgs e)
                {
                    skinType = string.Join(", ", SkinType.selectedSkinTypes);
                    skinTone = string.Join(", ", SkinTone.selectedSkinTones);
                    skinConcerns = string.Join(", ", SkinConcerns.selectedSkinConcerns);
                    skincareGoals = string.Join(", ", SkincareGoals.selectedSkincareGoals);
                    string allergies = string.Join(", ", SkinAllergies.selectedSkinAllergies);
                    string lifestyle = $"Makeup: {LifestyleFactor.wearsMakeup}, Climate: {LifestyleFactor.climate}, Sleep: {LifestyleFactor.hoursOfSleep}, Outdoors: {LifestyleFactor.worksOutdoors}";

                    morningRoutine += "\n Gentle facial cleanser\n→ Use every morning. Massage into damp skin for 60 seconds. Rinse with lukewarm water.\n";
                    eveningRoutine += "\n- Double cleanse (oil-based + water-based)\n→ Start with oil-based cleanser to remove makeup/sunscreen. Follow with water-based cleanser to cleanse skin.\n";

                    if (skinConcerns.Contains("Acne/Pimples"))
                    {
                        morningRoutine += "\n\n- Salicylic acid cleanser\n→ Use in the morning if skin tolerates it. Massage for 30–60 seconds. Rinse thoroughly.\n";
                        eveningRoutine += "\n\n Retinol serum (2–3x/week)\n→ Use at night after cleansing. Start with 1–2x/week. Follow with moisturizer.\n";
                    }
                    if (skinConcerns.Contains("Dark Spots"))
                    {
                        morningRoutine += "\n\n Vitamin C serum\n→ Apply 2–3 drops in the morning after toner. Gently press into skin. Follow with SPF.\n";
                        eveningRoutine += "\n\n Niacinamide or Alpha Arbutin\n→ Use after toner at night. Apply evenly and follow with moisturizer.\n";
                    }
                    if (skinConcerns.Contains("Dry Patches"))
                    {
                        morningRoutine += "\n\n- Hydrating toner\n→ Apply using hands or cotton pad. Pat gently until absorbed.\n\n";
                        eveningRoutine += "\n\n- Ceramide moisturizer\n→ Use as the last step at night. Apply a dime-sized amount. Massage gently.\n\n";
                    }
                    if (skinConcerns.Contains("Wrinkles"))
                    {
                        morningRoutine += "\n\n- Antioxidant serum\n→ Apply in the morning after cleansing. Wait 1 minute before moisturizer.\n\n";
                        eveningRoutine += "\n\n- Retinol or Bakuchiol serum\n→ Use at night after toner. Start slow (2x/week). Follow with thick moisturizer.\n\n";
                    }
                    if (skinConcerns.Contains("Oiliness"))
                    {
                        morningRoutine += "\n\n Oil-control toner\n→ Use after cleansing. Apply with a cotton pad. Focus on oily areas.\n\n";
                        eveningRoutine += "\n\n- Clay mask (2x/week)\n→ Apply thin layer on clean skin. Avoid eyes. Leave for 10–15 min. Rinse off.\n\n";
                    }
                    if (skinConcerns.Contains("Large Pores"))
                    {
                        morningRoutine += "\n\n- BHA exfoliant (2–3x/week)\n→ Use in the morning after toner. Apply with cotton pad. Avoid overuse.\n\n";
                        eveningRoutine += "\n\n- Niacinamide serum\n→ Apply after toner. Use 2–3 drops. Helps tighten pores over time.\n\n";
                    }
                    if (skinConcerns.Contains("Uneven Skin Tone"))
                    {
                        morningRoutine += "\n\n- Vitamin C + SPF\n→ Use Vitamin C serum after toner. Follow with broad-spectrum SPF 50.\n\n";
                        eveningRoutine += "\n\n- Glycolic acid (1–2x/week)\n→ Apply at night after cleansing. Use sparingly to avoid irritation.\n\n";
                    }
                    if (skinConcerns.Contains("Dullness"))
                    {
                        morningRoutine += "\n\n- Exfoliating toner (1–2x/week\n→ Use gently in the morning after cleansing. Avoid using with retinol.\n\n";
                        eveningRoutine += "\n\n Brightening night cream\n→ Apply after serum. Use circular motions to massage into skin.\n\n";
                    }

                    if (skinType.Contains("Oily"))
                    {
                        morningRoutine += "\n\n- Lightweight gel moisturizer\n→ Apply after serum in the morning. Absorbs quickly and hydrates without clogging.\n\n";
                        eveningRoutine += "\n\n- Oil-free night cream\n→ Use as last step in your nighttime routine. Avoid thick creams.\n\n";
                    }
                    if (skinType.Contains("Dry"))
                    {
                        morningRoutine += "\n\n- Hydrating serum\n→ Apply after toner on damp skin. Use 2–3 drops and pat in.\n\n";
                        eveningRoutine += "\n\n- Rich emollient moisturizer\n→ Apply a generous amount to seal in moisture overnight.\n\n";
                    }
                    if (skinType.Contains("Combination"))
                    {
                        morningRoutine += "\n\n Balancing toner\n\n";
                        eveningRoutine += "\n\n- Spot treat oily/dry areas\n\n";
                    }
                    if (skinType.Contains("Sensitive"))
                    {
                        morningRoutine += "\n\n Fragrance-free, calming cleanser\n→ Use in the morning. Avoid hot water and harsh rubbing.\n→ Apply with cotton pad or hands. Focus on T-zone and dry patches.\n\n";
                        eveningRoutine += "\n\n Cica cream or aloe-based product\n→ Use to soothe redness. Apply generously where needed.\n→ Use light moisturizers for oily zones, heavier creams for dry areas.\n\n";
                    }

                    if (skincareGoals.Contains("Clear Skin"))
                    {
                        morningRoutine += "\n\n Non-comedogenic sunscreen\n→ Apply generously in the morning. Reapply every 2 hours if outdoors.\n\n";
                        eveningRoutine += "\n\n- Detox mask weekly\n→ Use to clear pores. Apply evenly, rinse after 10–15 min.\n\n";
                    }
                    if (skincareGoals.Contains("Glowing Skin"))
                    {
                        morningRoutine += "\n\n- Vitamin C or brightening serum\n→ Use in AM. Apply after toner. Follow with SPF.\n\n";
                        eveningRoutine += "\n\n- AHA/BHA exfoliant (2x/week)\n→ Apply at night after cleansing. Do not mix with retinol.\n\n";
                    }
                    if (skincareGoals.Contains("Acne-Free Skin"))
                    {
                        morningRoutine += "\n\n- Niacinamide serum\n→ Apply daily in the morning. Helps regulate oil and fade blemishes.\n\n";
                        eveningRoutine += "\n\n- Spot treatment with BPO\n→ Dab on active pimples only. Use clean hands. Follow with moisturizer.\n\n";
                    }
                    if (skincareGoals.Contains("Smooth Texture"))
                    {
                        morningRoutine += "\n\n- PHA exfoliant (2–3x/week)\n→ Apply after cleansing. Less irritating than AHA/BHA. Don't rinse off.\n\n";
                        eveningRoutine += "\n\n- Gentle retinoid\n→ Apply a pea-sized amount. Avoid eyes and lips. Follow with thick moisturizer.\n\n";
                    }
                    if (skincareGoals.Contains("Even Tone"))
                    {
                        morningRoutine += "\n\n- Azelaic Acid or Vitamin C\n→ Apply once daily. Azelaic at night if using Vitamin C in morning.\n\n";
                        eveningRoutine += "\n\n- Mandelic Acid (night)\n→ Use at night. Very gentle chemical exfoliant for sensitive skin.\n\n";
                    }
                    if (skincareGoals.Contains("Anti-Aging"))
                    {
                        morningRoutine += "\n\n- Peptide serum\n→ Apply in morning after toner. Helps with firmness. Follow with SPF.\n\n";
                        eveningRoutine += "\n\n- Retinol + hydration layering\n→ Use sandwich method: moisturizer → retinol → moisturizer.\n\n";
                    }
                    if (skincareGoals.Contains("Hydration"))
                    {
                        morningRoutine += "\n\n- Hyaluronic acid serum\n→ Apply on damp skin. Pat until absorbed. Follow with cream.\n\n";
                        eveningRoutine += "\n\n Overnight sleeping mask\n→ Use 2–3x/week. Apply as last step. Leave on overnight, rinse in morning.\n\n";
                    }

                    if (SkinAllergies.selectedSkinAllergies.Contains("Fragrance") ||
                        SkinAllergies.selectedSkinAllergies.Contains("Itchiness") ||
                        SkinAllergies.selectedSkinAllergies.Contains("Redness"))
                    {
                        morningRoutine += "\n\n- Use only hypoallergenic, fragrance-free products\n→ Choose gentle formulas. Patch test new products.\n\n";
                        eveningRoutine += "\n\n Apply calming barrier cream\n→ Use as last step. Helps reduce redness and protect skin.\n\n";
                    }
                    richTextBox2.Text = morningRoutine;
                    richTextBox1.Text = eveningRoutine;
                    Day1.Checked = Properties.Settings.Default.Day1Checked;
                    Day2.Checked = Properties.Settings.Default.Day2Checked;
                    Day3.Checked = Properties.Settings.Default.Day3Checked;
                    Day4.Checked = Properties.Settings.Default.Day4Checked;
                    Day5.Checked = Properties.Settings.Default.Day5Checked;
                    Day6.Checked = Properties.Settings.Default.Day6Checked;
                    Day7.Checked = Properties.Settings.Default.Day7Checked;
        }

                private void RecommendedProducts_Click(object sender, EventArgs e)
                {

                }

                private void textboxMorningRoutine_TextChanged(object sender, EventArgs e)
                {

                }

                private void richTextBox2_TextChanged(object sender, EventArgs e)
                {

                }

                private void richTextBox1_TextChanged(object sender, EventArgs e)
                {

                }

                private void MorningFullRoutineBtn_Click(object sender, EventArgs e)
                {
                    MainFrame mainFrame = this.TopLevelControl as MainFrame;
                        if (mainFrame != null)
                        {
                            Form3 form3 = new Form3(
                                "Oily",       // Replace with actual value or field
                                "Fair",
                                "Acne",
                                "None",
                                "Clear Skin",
                                "Active",
                                "John Doe",
                                "28",
                                "Male",
                                "1996-05-04"
                            );

                            mainFrame.LoadFormInPanel(form3);
                        }
        }

                private void NightFullRoutineBtn_Click(object sender, EventArgs e)
                {
                    MainFrame mainFrame = this.TopLevelControl as MainFrame;
                    if (mainFrame != null)
                    {
                        Form3 form3 = new Form3(
                            "Oily",
                            "Fair",
                            "Acne",
                            "None",
                            "Clear Skin",
                            "Active",
                            "John Doe",
                            "28",
                            "Male",
                            "1996-05-04"
                        );

                        mainFrame.LoadFormInPanel(form3);
                    }
                }

        private void TimelineProgressBtn_Click(object sender, EventArgs e)
        {

        }

        private void Day1_CheckedChanged(object sender, EventArgs e)
        {
            if (Day1.Checked)
            {
                MessageBox.Show("🌞 Day 1: What a good start! We'll keep you updated until you reach your desired goals.", "Progress Encouragement", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Properties.Settings.Default.Day1Checked = true;
            }
            else
            {
                Properties.Settings.Default.Day1Checked = false;
            }

            Properties.Settings.Default.Save();
        }

        private void Day2_CheckedChanged(object sender, EventArgs e)
        {
            if (Day2.Checked)
            {
                MessageBox.Show("🌤️ Day 2: You're doing amazing! Consistency is the secret to glowing skin.");
                Properties.Settings.Default.Day2Checked = true;
            }
            else
            {
                Properties.Settings.Default.Day2Checked = false;
            }
            Properties.Settings.Default.Save();
        }

        private void Day3_CheckedChanged(object sender, EventArgs e)
        {
            if (Day3.Checked)
            {
                MessageBox.Show("☀️ Day 3: Keep up the good work! Great skin is on its way.");
                Properties.Settings.Default.Day3Checked = true;
            }
            else
            {
                Properties.Settings.Default.Day3Checked = false;
            }
            Properties.Settings.Default.Save();
        }

        private void Day4_CheckedChanged(object sender, EventArgs e)
        {
            if (Day4.Checked)
            {
                MessageBox.Show("🌈 Day 4: Look at you go! Halfway there to forming a habit.");
                Properties.Settings.Default.Day4Checked = true;
            }
            else
            {
                Properties.Settings.Default.Day4Checked = false;
            }
            Properties.Settings.Default.Save();
        }

        private void Day6_CheckedChanged(object sender, EventArgs e)
        {
            if (Day5.Checked)
            {
                MessageBox.Show("🌟 Day 5: Amazing progress! Your skin already loves you.");
                Properties.Settings.Default.Day5Checked = true;
            }
            else
            {
                Properties.Settings.Default.Day5Checked = false;
            }
            Properties.Settings.Default.Save();
        }

        private void Day5_CheckedChanged(object sender, EventArgs e)
        {
            if (Day6.Checked)
            {
                MessageBox.Show("✨ Day 6: Just one more day! You're building something beautiful.");
                Properties.Settings.Default.Day6Checked = true;
            }
            else
            {
                Properties.Settings.Default.Day6Checked = false;
            }
            Properties.Settings.Default.Save();
        }

        private void Day7_CheckedChanged(object sender, EventArgs e)
        {
            if (Day7.Checked)
            {
                MessageBox.Show("🏆 Day 7: Congratulations! You’ve completed a full routine week! Your dedication shows.");
                Properties.Settings.Default.Day7Checked = true;
            }
            else
            {
                Properties.Settings.Default.Day7Checked = false;
            }
            Properties.Settings.Default.Save();
        }
    }
}
