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
            if(StartInput.Text == null || StartInput.Text.Length == 0)
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

            if(!Words.fileRead)
            {
                Console.WriteLine("Make sure there's a words_alpha.txt file in the folder.");
                return;
            }
            Console.WriteLine("Button clicked");

            if(!intParsed)
            {
                Console.WriteLine("Length is undefined.");
                return;
            }

            var items = Words.GetWords(startsWith, containedSequence, length);

            if(items == null || items.Count == 0)
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


            int i = 0;
            await Task.Run(() =>
            {
                Thread.Sleep(TimeSpan.FromSeconds(2));

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