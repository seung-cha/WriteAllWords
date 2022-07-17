using System.Diagnostics;

namespace WriteAllWords
{
    public partial class MainForm : Form
    {
        int length = 0;
        string containedSequence = "";
        char startsWith = '.';

        bool intParsed = false;

        bool startTyping = false;
        
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void StartInput_TextChanged(object sender, EventArgs e)
        {
            if(StartInput.Text == null)
            {
                startsWith = '.';
                return;
            }

            startsWith = char.ToLower(StartInput.Text[0]);
        }

        private void ContainsInput_TextChanged(object sender, EventArgs e)
        {
            containedSequence = ContainsInput.Text;
        }

        private void LengthInput_TextChanged(object sender, EventArgs e)
        {
          intParsed = int.TryParse(LengthInput.Text, out length);
        }

        private void PrintButton_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Button clicked");

            if(!intParsed)
            {
                Console.WriteLine("Length is undefined.");
                return;
            }

            var items = Words.GetWords(startsWith, containedSequence, length);

            if(items == null)
            {
                return;
            }

            startTyping = true;
            StopButton.Select();
            WriteSolutions(items);
        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            startTyping = false;
        }



        async void WriteSolutions(List<string> words)
        {
            foreach (var x in words)
            {
                Console.WriteLine(x);
            }

            Thread.Sleep(TimeSpan.FromSeconds(2));

            int i = 0;
            await Task.Run(() =>
            {
                while (startTyping && i < words.Count)
                {
                    SendKeys.SendWait(words[i]);
                    Thread.Sleep(TimeSpan.FromSeconds(0.5f));
                    SendKeys.SendWait("{Enter}");
                    i++;
                }

            });
            
        }

    }
}