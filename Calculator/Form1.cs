namespace Calculator;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();

        button1.Click += button1_Click;
        button2.Click += button2_Click;
        button3.Click += button3_Click;
        button4.Click += button4_Click;
        button5.Click += button5_Click;
        button6.Click += button6_Click;
        button7.Click += button7_Click;
        button8.Click += button8_Click;
        button9.Click += button9_Click;
        button10.Click += button10_Click;
        button11.Click += button11_Click;
        button12.Click += button12_Click;
        button13.Click += button13_Click;
        button14.Click += button14_Click;
        button15.Click += button15_Click;
        button16.Click += button16_Click;
    }

    private string _proses;
    private bool _clear;
    private int _firstNumber;

    private void button1_Click(object sender, EventArgs e)
    {
        if (_clear == true)
        {
            label1.Text = "0";
            _clear = false;
        }
        if (label1.Text == "0")
        {
            label1.Text = " ";
        }
        label1.Text += "1";
    }

    private void button2_Click(object sender, EventArgs e)
    {
        if (_clear == true)
        {
            label1.Text = "0";
            _clear = false;
        }
        if (label1.Text == "0")
        {
            label1.Text = " ";
        }
        label1.Text += "2";
    }

    private void button3_Click(object sender, EventArgs e)
    {
        if (_clear == true)
        {
            label1.Text = "0";
            _clear = false;
        }
        if (label1.Text == "0")
        {
            label1.Text = " ";
        }
        label1.Text += "3";
    }

    private void button5_Click(object sender, EventArgs e)
    {
        if (_clear == true)
        {
            label1.Text = "0";
            _clear = false;
        }
        if (label1.Text == "0")
        {
            label1.Text = " ";
        }
        label1.Text += "4";
    }

    private void button6_Click(object sender, EventArgs e)
    {
        if (_clear == true)
        {
            label1.Text = "0";
            _clear = false;
        }
        if (label1.Text == "0")
        {
            label1.Text = " ";
        }
        label1.Text += "5";
    }

    private void button7_Click(object sender, EventArgs e)
    {
        if (_clear == true)
        {
            label1.Text = "0";
            _clear = false;
        }
        if (label1.Text == "0")
        {
            label1.Text = " ";
        }
        label1.Text += "6";
    }

    private void button9_Click(object sender, EventArgs e)
    {
        if (_clear == true)
        {
            label1.Text = "0";
            _clear = false;
        }
        if (label1.Text == "0")
        {
            label1.Text = " ";
        }
        label1.Text += "7";
    }

    private void button10_Click(object sender, EventArgs e)
    {
        if (_clear == true)
        {
            label1.Text = "0";
            _clear = false;
        }
        if (label1.Text == "0")
        {
            label1.Text = " ";
        }
        label1.Text += "8";
    }

    private void button11_Click(object sender, EventArgs e)
    {
        if (_clear == true)
        {
            label1.Text = "0";
            _clear = false;
        }
        if (label1.Text == "0")
        {
            label1.Text = " ";
        }
        label1.Text += "9";
    }

    private void button14_Click(object sender, EventArgs e)
    {
        if (_clear == true)
        {
            label1.Text = "0";
            _clear = false;
        }
        label1.Text += "0";
    }

    private void button4_Click(object sender, EventArgs e)
    {
        _proses = "+";
        _clear = true;
        _firstNumber = Convert.ToInt32(label1.Text);
    }

    private void button8_Click(object sender, EventArgs e)
    {
        _proses = "-";
        _clear = true;
        _firstNumber = Convert.ToInt32(label1.Text);
    }

    private void button12_Click(object sender, EventArgs e)
    {
        _proses = "*";
        _clear = true;
        _firstNumber = Convert.ToInt32(label1.Text);
    }

    private void button16_Click(object sender, EventArgs e)
    {
        _proses = "/";
        _clear = true;
        _firstNumber = Convert.ToInt32(label1.Text);
    }

    private void button13_Click(object sender, EventArgs e)
    {
        label1.Text = "0";
    }

    private void button15_Click(object sender, EventArgs e)
    {
        int secondNumber = Convert.ToInt32(label1.Text);
        int total;

        switch (_proses)
        {
            case "+":
                total = _firstNumber + secondNumber;
                break;
            case "-":
                total = _firstNumber - secondNumber;
                break;
            case "*":
                total = _firstNumber * secondNumber;
                break;
            case "/":
                total = _firstNumber / secondNumber;
                break;
            default:
                total = 0;
                break;
        }
        label1.Text = total.ToString();
    }
}
