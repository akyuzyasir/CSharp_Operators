namespace CSharp_13_AccessMethodsThroughObjects
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Mathematics mathematics = new Mathematics();
            //int result = mathematics.Sum(5, 10); // we can access the public method
            ////int result = mathematics.Divide(10, 2); // we can't access the private method
            //MessageBox.Show(result.ToString());

            Mathematics mathematics = null; 
            string x = mathematics.Sum(314, 159).ToString(); // It will throw a NullReferenceException because mathematics is null.
            MessageBox.Show(x);
            
        }
    }
}
