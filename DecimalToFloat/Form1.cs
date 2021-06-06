/// <summary>
/// Our working namespace.
/// </summary>
namespace DecimalToFloat
{
    using System;
    using System.Windows.Forms;

    /// <summary>
    /// Definition of our forms methods and events.
    /// </summary>
    public partial class MainForm : Form
    {
        /// <summary>
        /// Start the form.
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
        }


        /// <summary>
        /// Convert the data within the RGBA text feild values to float, then display as hexadecimal.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void convertButton_Click(object sender, EventArgs e)
        {
            // Try to parse the user input data as a float.
            if (float.TryParse(redText.Text, out float r) 
                && float.TryParse(greenText.Text, out float g) 
                && float.TryParse(blueText.Text, out float b)
                && float.TryParse(alphaText.Text, out float a))
            {
                // Conver float to byte array.
                byte[] rByte = BitConverter.GetBytes(r);
                byte[] gByte = BitConverter.GetBytes(g);
                byte[] bByte = BitConverter.GetBytes(b);
                byte[] aByte = BitConverter.GetBytes(a);

                // Convert byte array to big endian for PS3 PPC
                Array.Reverse(rByte, 0, rByte.Length);
                Array.Reverse(gByte, 0, gByte.Length);
                Array.Reverse(bByte, 0, bByte.Length);
                Array.Reverse(aByte, 0, aByte.Length);

                // Print as a string representation of hexidecimal.
                MessageBox.Show(ByteArrayToString(rByte) + ByteArrayToString(gByte) + ByteArrayToString(bByte) + ByteArrayToString(aByte));
            }

            else
            {
                MessageBox.Show("You must input float value number you fucking dumbass!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Convert a byte array to its hexidecimal version of a string....
        /// </summary>
        /// <param name="ba"></param>
        /// <returns></returns>
        public static string ByteArrayToString(byte[] ba)
        {
            return BitConverter.ToString(ba).Replace("-", "");
        }
    }
}
