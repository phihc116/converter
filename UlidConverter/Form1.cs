namespace Converter;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {

    }

    private void button1_Click(object sender, EventArgs e)
    {

        try
        {
            var valueConverter = textBox1.Text;
            if (valueConverter.StartsWith("0x", StringComparison.OrdinalIgnoreCase))
            {
                valueConverter = valueConverter.Substring(2);
            }

            byte[] byteArray = HexStringToByteArray(valueConverter);
            var ulid = new Ulid(byteArray);
            string ulidString = ulid.ToString();

            textBox2.Text = ulidString;
        }
        catch (FormatException)
        {
            MessageBox.Show("Value not valid");
        }
    }

    private void textBox1_TextChanged(object sender, EventArgs e)
    {

    }

    private void textBox2_TextChanged(object sender, EventArgs e)
    {

    }

    private void button2_Click(object sender, EventArgs e)
    {
        if (!string.IsNullOrEmpty(textBox2.Text))
        {
            Clipboard.SetText(textBox2.Text);
            MessageBox.Show("Copy success!");
        }
        else
        {
            MessageBox.Show("No value to copy");
        }
    }

    private static byte[] HexStringToByteArray(string hex)
    {
        if (hex.Length % 2 != 0)
            throw new FormatException("Hex string must have an even length.");

        byte[] bytes = new byte[hex.Length / 2];

        for (int i = 0; i < hex.Length; i += 2)
        {
            bytes[i / 2] = Convert.ToByte(hex.Substring(i, 2), 16);
        }

        return bytes;
    }

    private void label1_Click(object sender, EventArgs e)
    {

    }

    private void label2_Click(object sender, EventArgs e)
    {

    }

    private void button3_Click(object sender, EventArgs e)
    {
        var result = Ulid.Parse(textBox3.Text);
        var byteArray = result.ToByteArray();
        textBox4.Text = $"0x{BitConverter.ToString(byteArray).Replace("-", "")}";
    }

    private void textBox3_TextChanged(object sender, EventArgs e)
    {

    }

    private void button4_Click(object sender, EventArgs e)
    {
        if (!string.IsNullOrEmpty(textBox4.Text))
        {
            Clipboard.SetText(textBox4.Text);
            MessageBox.Show("Copy success!");
        }
        else
        {
            MessageBox.Show("No value to copy");
        }
    }
}
