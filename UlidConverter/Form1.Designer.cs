namespace Converter;

partial class Form1
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        textBox1 = new TextBox();
        button1 = new Button();
        textBox2 = new TextBox();
        button2 = new Button();
        label1 = new Label();
        label2 = new Label();
        textBox3 = new TextBox();
        textBox4 = new TextBox();
        button3 = new Button();
        button4 = new Button();
        SuspendLayout();
        // 
        // textBox1
        // 
        textBox1.Location = new Point(255, 70);
        textBox1.Name = "textBox1";
        textBox1.Size = new Size(263, 31);
        textBox1.TabIndex = 0;
        textBox1.TextChanged += textBox1_TextChanged;
        // 
        // button1
        // 
        button1.Location = new Point(538, 70);
        button1.Name = "button1";
        button1.Size = new Size(112, 34);
        button1.TabIndex = 1;
        button1.Text = "Convert";
        button1.UseVisualStyleBackColor = true;
        button1.Click += button1_Click;
        // 
        // textBox2
        // 
        textBox2.Location = new Point(255, 128);
        textBox2.Name = "textBox2";
        textBox2.Size = new Size(263, 31);
        textBox2.TabIndex = 2;
        textBox2.TextChanged += textBox2_TextChanged;
        // 
        // button2
        // 
        button2.Location = new Point(538, 125);
        button2.Name = "button2";
        button2.Size = new Size(112, 34);
        button2.TabIndex = 3;
        button2.Text = "Copy";
        button2.UseVisualStyleBackColor = true;
        button2.Click += button2_Click;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.BackColor = SystemColors.ActiveCaption;
        label1.BorderStyle = BorderStyle.FixedSingle;
        label1.Location = new Point(23, 100);
        label1.Name = "label1";
        label1.Size = new Size(148, 27);
        label1.TabIndex = 4;
        label1.Text = "Byte db to String";
        label1.Click += label1_Click;
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.BackColor = SystemColors.ActiveCaption;
        label2.BorderStyle = BorderStyle.FixedSingle;
        label2.Location = new Point(12, 294);
        label2.Name = "label2";
        label2.Size = new Size(169, 27);
        label2.TabIndex = 5;
        label2.Text = "String to byte Array";
        label2.Click += label2_Click;
        // 
        // textBox3
        // 
        textBox3.Location = new Point(255, 249);
        textBox3.Name = "textBox3";
        textBox3.Size = new Size(263, 31);
        textBox3.TabIndex = 6;
        textBox3.TextChanged += textBox3_TextChanged;
        // 
        // textBox4
        // 
        textBox4.Location = new Point(255, 312);
        textBox4.Name = "textBox4";
        textBox4.Size = new Size(263, 31);
        textBox4.TabIndex = 7;
        // 
        // button3
        // 
        button3.Location = new Point(548, 249);
        button3.Name = "button3";
        button3.Size = new Size(112, 34);
        button3.TabIndex = 8;
        button3.Text = "Convert";
        button3.UseVisualStyleBackColor = true;
        button3.Click += button3_Click;
        // 
        // button4
        // 
        button4.Location = new Point(548, 312);
        button4.Name = "button4";
        button4.Size = new Size(112, 34);
        button4.TabIndex = 9;
        button4.Text = "Copy";
        button4.UseVisualStyleBackColor = true;
        button4.Click += button4_Click;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(10F, 25F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(800, 450);
        Controls.Add(button4);
        Controls.Add(button3);
        Controls.Add(textBox4);
        Controls.Add(textBox3);
        Controls.Add(label2);
        Controls.Add(label1);
        Controls.Add(button2);
        Controls.Add(textBox2);
        Controls.Add(button1);
        Controls.Add(textBox1);
        Name = "Form1";
        Text = "Form1";
        Load += Form1_Load;
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private TextBox textBox1;
    private Button button1;
    private TextBox textBox2;
    private Button button2;
    private Label label1;
    private Label label2;
    private TextBox textBox3;
    private TextBox textBox4;
    private Button button3;
    private Button button4;
}
