namespace LAB03
{
    public partial class Form1 : Form
    {
        List<Student> _students = new List<Student>();
        //Max mix number of student
        double maxGrade = 0;
        double minGrade = int.MaxValue;
        int num_Student = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxID_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            //get value from textbox
            String name = this.textBoxName.Text;
            String id = this.textBoxID.Text;
            String year = this.textBox1.Text;
            String height = this.textBox2.Text;
            String grade = this.textBox3.Text;
            String major = this.textBox4.Text;

            //convert string to in
            int iYear = Int32.Parse(year);
            double iHeight = Double.Parse(height);
            double iGrade = Double.Parse(grade);

            //create obj from Student
            Student newStudent = new Student(name, id, iYear, iHeight, iGrade, major);

            //Add new student to list
            this._students.Add(newStudent);

            //Clear textbox
            this.textBoxName.Text = "";
            this.textBoxID.Text = "";
            this.textBox1.Text = "";
            this.textBox2.Text = "";
            this.textBox3.Text = "";
            this.textBox4.Text = "";
            this.textBoxMaxGrade.Text = "";
            this.textBoxMinGrade.Text = "";
            this.textBoxNamstu.Text = "";

            // add data to DataGridView
            BindingSource source = new BindingSource();
            source.DataSource = this._students;
            this.dataGridView1.DataSource = source;

            //max min of Grade
            if (iGrade > maxGrade)
            {
                maxGrade = iGrade;
            }
            if (iGrade < minGrade)
            {
                minGrade = iGrade;
            }
            //Number of student
            num_Student = num_Student + 1;

            //Show min max
            this.textBoxMaxGrade.Text = this.textBoxMaxGrade.Text + maxGrade;
            this.textBoxMinGrade.Text = this.textBoxMinGrade.Text + minGrade;

            //show num Stdent
            this.textBoxNamstu.Text = this.textBoxNamstu.Text + num_Student;

        }
    }
}