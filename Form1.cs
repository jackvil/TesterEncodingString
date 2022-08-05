using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TesterEncodingString
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtResult.Text = EncodingText(txtSource.Text);
            lblLongSource.Text = $"{txtSource.Text.Length} chars";
            lblLongResult.Text = $"{txtResult.Text.Length} chars";
        }

        public string EncodingText(string source)
        {
            var resConvert = Encoding.Convert(
                Encoding.UTF8,
                Encoding.GetEncoding(
                    Encoding.ASCII.EncodingName,
                    new EncoderReplacementFallback(" "),
                    new DecoderExceptionFallback()
                    ),
                Encoding.UTF8.GetBytes(source));
            string strResult = Encoding.ASCII.GetString(resConvert);

            return strResult;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtResult.Text = EncodingTextSpecialChars(txtSource.Text);
            lblLongSource.Text = $"{txtSource.Text.Length} chars";
            lblLongResult.Text = $"{txtResult.Text.Length} chars";
        }

        public string EncodingTextSpecialChars(string source)
        {

            //source = Regex.Replace(source, "[éèëêð]", "e");
            //source = Regex.Replace(source, "[ÉÈËÊ]", "E");
            //source = Regex.Replace(source, "[àâä]", "a");
            //source = Regex.Replace(source, "[ÀÁÂÃÄÅ]", "A");
            //source = Regex.Replace(source, "[àáâãäå]", "a");
            //source = Regex.Replace(source, "[ÙÚÛÜ]", "U");
            //source = Regex.Replace(source, "[ùúûüµ]", "u");
            //source = Regex.Replace(source, "[òóôõöø]", "o");
            //source = Regex.Replace(source, "[ÒÓÔÕÖØ]", "O");
            //source = Regex.Replace(source, "[ìíîï]", "i");
            //source = Regex.Replace(source, "[ÌÍÎÏ]", "I");
            source = Regex.Replace(source, "[š]", "s");
            source = Regex.Replace(source, "[Š]", "S");
            source = Regex.Replace(source, "[ñ]", "n");
            source = Regex.Replace(source, "[Ñ]", "N");
            source = Regex.Replace(source, "[ç]", "c");
            source = Regex.Replace(source, "[Ç]", "C");
            source = Regex.Replace(source, "[ÿ]", "y");
            source = Regex.Replace(source, "[Ÿ]", "Y");
            source = Regex.Replace(source, "[ž]", "z");
            source = Regex.Replace(source, "[Ž]", "Z");
            source = Regex.Replace(source, "[Ð]", "D");
            source = Regex.Replace(source, "[œ]", "oe");
            source = Regex.Replace(source, "[Œ]", "Oe");
            source = Regex.Replace(source, "[«»\u201C\u201D\u201E\u201F\u2033\u2036]", "\"");
            source = Regex.Replace(source, "[\u2026]", "...");
            source = source.Replace("<", string.Empty);
            source = source.Replace(">", string.Empty);
            source = source.Replace("´", string.Empty);
            source = source.Replace("`", string.Empty);
            source = source.Replace("^", string.Empty);
            source = source.Replace("°", string.Empty);
            source = source.Replace("/", string.Empty);
            source = source.Replace("|", string.Empty);
            source = source.Replace("\u00021", string.Empty);
            source = source.Replace("\x02", " ");
            source = source.Replace("\x03", " ");
            return source;
        }

        public string EncodingTextUTF8(string source)
        {
            Encoding enc = new UTF8Encoding(true, true);
            string strResult = string.Empty;
            try
            {
                byte[] resConvert = enc.GetBytes(source);
                strResult = Encoding.ASCII.GetString(resConvert);

            }
            catch (Exception ex)
            {

            }
            return strResult;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtResult.Text = EncodingTextUTF8(txtSource.Text);
            lblLongSource.Text = $"{txtSource.Text.Length} chars";
            lblLongResult.Text = $"{txtResult.Text.Length} chars";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtResult.Text = EncodingNonPrintableChars(txtSource.Text);
            lblLongSource.Text = $"{txtSource.Text.Length} chars";
            lblLongResult.Text = $"{txtResult.Text.Length} chars";
        }

        public string EncodingNonPrintableChars(string source)
        {
            return Regex.Replace(source, @"\p{C}+", String.Empty);
        }
    }
}
