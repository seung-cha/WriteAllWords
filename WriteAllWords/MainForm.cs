using System.Diagnostics;

namespace WriteAllWords
{
    public partial class MainForm : Form
    {
        int length = 0;
        string containedSequence = null;
        string startsWith = "";
        
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void StartInput_TextChanged(object sender, EventArgs e)
        {
            startsWith = StartInput.Text;
        }

        private void ContainsInput_TextChanged(object sender, EventArgs e)
        {
            containedSequence = ContainsInput.Text;
        }

        private void LengthInput_TextChanged(object sender, EventArgs e)
        {
           int.TryParse(LengthInput.Text, out length);
        }

        private void PrintButton_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Button clicked");
            if (startsWith == null || startsWith.Length == 0 || length <= 0)
            {
                Console.WriteLine("Invalid input provided");
                return;
            }

            var items = Words.GetWords(startsWith[0], containedSequence, length);

            foreach(var i in items)
            {
                Console.WriteLine(i);
            }
            if(items.Count != 0)
            {
                Thread.Sleep(TimeSpan.FromSeconds(2));
                foreach (var i in items)
                {               
                    SendKeys.Send(i);
                    Thread.Sleep(TimeSpan.FromSeconds(0.2));
                    SendKeys.Send("{Enter}");
                }
            }
        }


    }
}