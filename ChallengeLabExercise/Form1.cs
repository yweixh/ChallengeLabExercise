using System.IO;

namespace ChallengeLabExercise
{
    public partial class Form1 : Form
    {
        public static string SetFileName;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] ProgramList = new string[]
            {
                "BS Computer Science",
                "BS Architecture",
                "BS Electrical Engineering",
                "BS Psychology",
                "BS Business Accountancy",
                "BS Multi-Media Arts"
            };
            for (int i = 0; i < 6; i++)
            {
                cmbProgram.Items.Add(ProgramList[i].ToString());
            }

            string[] Gender = new string[]
            {
                "Female", "Male", "Others"
            };
            for (int j = 0; j < 3; j++)
            {
                cmbGender.Items.Add(Gender[j].ToString());
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            int StudentNo = Convert.ToInt32(txtStudentNo.Text);
            string Program = cmbProgram.Text;
            string LName = txtLastName.Text;
            string FName = txtFirstName.Text;
            string MI = txtMI.Text;
            int Age = Convert.ToInt32(txtAge.Text);
            string Gender = cmbGender.Text;
            string Birthday = dateTimePicker1.Value.ToString("MMM-dd-yyyy");
            long Number = Convert.ToInt64(txtContact.Text);

            SetFileName = txtLastName.Text + txtFirstName.Text + ".txt";
            string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            using (StreamWriter outputFile = new StreamWriter(Path.Combine(docPath, Form1.SetFileName)))
            {
                string[] registration = { "Student No. : " + StudentNo,
                    "Program : " + Program,
                    "Last Name: " + LName,
                    "First Name: " + FName,
                    "Middle Initial : " + MI,
                    "Age : " + Age,
                    "Gender : " + Gender,
                    "Birthday : " + Birthday,
                    "Contact No. : " + Number, };
                foreach (string register in registration)
                {
                    outputFile.WriteLine(register);
                }
            }
        }
    }
}