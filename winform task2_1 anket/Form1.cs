using winform_task2_1_anket.Database;
using winform_task2_1_anket.File_works;

namespace winform_task2_1_anket
{
    public partial class Form1 : Form
    {
        public static bool check_load = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            if (soyad_txtbx.Text != "" && ad_txtbx.Text != "" && ataadi_txtbx.Text != "" && leqeb_txtbx.Text != ""
                && olke_txtbx.Text != "" && seher_txtbx.Text != "" && nomre_txtbx.Text != ""
                && (kisi_rb.Checked == true || qadin_rb.Checked == true || diger_rb.Checked == true))
            {
                if (error_lbl.Text != "")
                {
                    error_lbl.Text = "";
                }
                string cinsiyyet = "";
                if (kisi_rb.Checked == true)
                {
                    cinsiyyet = kisi_rb.Text;
                }
                else if (qadin_rb.Checked == true)
                {
                    cinsiyyet = qadin_rb.Text;
                }
                else if (diger_rb.Checked == true)
                {
                    cinsiyyet = diger_rb.Text;
                }

                if (check_load == false)
                {

                    string jsonFilePath = $"{leqeb_txtbx.Text}.json";
                    bool check_file = false;
                    if (File.Exists(jsonFilePath)) { check_file = true; }
                    else { check_file = false; }

                    if (check_file == false)
                    {

                        Human human = new Human(ad_txtbx.Text, soyad_txtbx.Text, ataadi_txtbx.Text, leqeb_txtbx.Text, olke_txtbx.Text, seher_txtbx.Text, nomre_txtbx.Text, dateTimePicker1.Value, cinsiyyet);
                        File_works.File_class.WriteHumanToFile(human);
                        error_lbl.ForeColor = Color.Green;
                        error_lbl.Text = " Elave edildi . ";
                        error_lbl.ForeColor = Color.Red;
                    }
                    else
                    {
                        error_lbl.Text = " Bu leqebde istifadeci var . ";
                    }
                }
                else
                {
                    string jsonFilePath = $"{leqeb_txtbx.Text}.json";
                    File.Delete(jsonFilePath);
                    bool check_file = false;
                    if (File.Exists(jsonFilePath)) { check_file = true; }
                    else { check_file = false; }

                    if (check_file == false)
                    {

                        Human human = new Human(ad_txtbx.Text, soyad_txtbx.Text, ataadi_txtbx.Text, leqeb_txtbx.Text, olke_txtbx.Text, seher_txtbx.Text, nomre_txtbx.Text, dateTimePicker1.Value, cinsiyyet);
                        File_works.File_class.WriteHumanToFile(human);
                        error_lbl.ForeColor = Color.Green;
                        error_lbl.Text = " Elave edildi . ";
                        error_lbl.ForeColor = Color.Red;
                    }
                    else
                    {
                        error_lbl.Text = " Bu leqebde istifadeci var . ";
                    }
                    check_load = false;
                }
            }
            else
            {
                error_lbl.Text = " Xanalar tam doldurulmayib .";
            }
        }

        private void load_btn_Click(object sender, EventArgs e)
        {
            string jsonFilePath = $"{textBox1.Text}.json";
            bool check_file = false;
            if (File.Exists(jsonFilePath)) { check_file = true; }
            else { check_file = false; }
            if (check_file == false)
            {
                error_lbl.Text = " Bu leqebde istifadeci yoxdur . ";
            }
            else
            {
                check_load = true;
                Human human = File_class.ReadHumanToFile(textBox1.Text);
                if (human.Sex == "Kisi")
                {
                    kisi_rb.Checked = true;
                }
                else if (human.Sex == "Qadin")
                {
                    qadin_rb.Checked = true;
                }
                else
                {
                    diger_rb.Checked = true;
                }
                ad_txtbx.Text = human.Name;
                soyad_txtbx.Text = human.Surname;
                ataadi_txtbx.Text = human.Father_name;
                nomre_txtbx.Text = human.Number;
                leqeb_txtbx.Text = human.Nickname;
                olke_txtbx.Text = human.Country;
                seher_txtbx.Text = human.City;
                dateTimePicker1.Text = human.DateTime.ToString();
            }
        }


    }
}
