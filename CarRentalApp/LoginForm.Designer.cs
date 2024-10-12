namespace CarRentalApp;

partial class LoginForm
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
        splitContainer1 = new SplitContainer();
        pictureBox1 = new PictureBox();
        chbRememberMe = new CheckBox();
        btnLogin = new Button();
        textBox2 = new TextBox();
        textBox1 = new TextBox();
        label3 = new Label();
        label2 = new Label();
        label1 = new Label();
        ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
        splitContainer1.Panel2.SuspendLayout();
        splitContainer1.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
        SuspendLayout();
        // 
        // splitContainer1
        // 
        splitContainer1.Dock = DockStyle.Fill;
        splitContainer1.Location = new Point(0, 0);
        splitContainer1.Name = "splitContainer1";
        // 
        // splitContainer1.Panel1
        // 
        splitContainer1.Panel1.BackgroundImage = Properties.Resources.download;
        // 
        // splitContainer1.Panel2
        // 
        splitContainer1.Panel2.BackColor = Color.White;
        splitContainer1.Panel2.Controls.Add(pictureBox1);
        splitContainer1.Panel2.Controls.Add(chbRememberMe);
        splitContainer1.Panel2.Controls.Add(btnLogin);
        splitContainer1.Panel2.Controls.Add(textBox2);
        splitContainer1.Panel2.Controls.Add(textBox1);
        splitContainer1.Panel2.Controls.Add(label3);
        splitContainer1.Panel2.Controls.Add(label2);
        splitContainer1.Panel2.Controls.Add(label1);
        splitContainer1.Size = new Size(837, 450);
        splitContainer1.SplitterDistance = 447;
        splitContainer1.TabIndex = 0;
        // 
        // pictureBox1
        // 
        pictureBox1.Image = Properties.Resources.close__4_;
        pictureBox1.Location = new Point(328, 3);
        pictureBox1.Name = "pictureBox1";
        pictureBox1.Size = new Size(52, 54);
        pictureBox1.TabIndex = 7;
        pictureBox1.TabStop = false;
        pictureBox1.Click += pictureBox1_Click;
        // 
        // chbRememberMe
        // 
        chbRememberMe.AutoSize = true;
        chbRememberMe.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
        chbRememberMe.Location = new Point(84, 269);
        chbRememberMe.Name = "chbRememberMe";
        chbRememberMe.Size = new Size(120, 24);
        chbRememberMe.TabIndex = 6;
        chbRememberMe.Text = "Remeber Me";
        chbRememberMe.UseVisualStyleBackColor = true;
        // 
        // btnLogin
        // 
        btnLogin.Font = new Font("Stencil", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
        btnLogin.Image = Properties.Resources.login__1_;
        btnLogin.Location = new Point(137, 363);
        btnLogin.Name = "btnLogin";
        btnLogin.Size = new Size(117, 44);
        btnLogin.TabIndex = 5;
        btnLogin.Text = "Login";
        btnLogin.TextImageRelation = TextImageRelation.ImageBeforeText;
        btnLogin.UseVisualStyleBackColor = true;
        // 
        // textBox2
        // 
        textBox2.Location = new Point(146, 205);
        textBox2.Name = "textBox2";
        textBox2.Size = new Size(234, 27);
        textBox2.TabIndex = 1;
        // 
        // textBox1
        // 
        textBox1.Location = new Point(147, 155);
        textBox1.Name = "textBox1";
        textBox1.Size = new Size(234, 27);
        textBox1.TabIndex = 0;
        textBox1.Text = "\r\n";
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Font = new Font("Stencil", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
        label3.Location = new Point(16, 205);
        label3.Name = "label3";
        label3.Size = new Size(124, 21);
        label3.TabIndex = 2;
        label3.Text = "Password :";
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Font = new Font("Stencil", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
        label2.Location = new Point(16, 158);
        label2.Name = "label2";
        label2.Size = new Size(125, 21);
        label2.TabIndex = 1;
        label2.Text = "Username :";
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Font = new Font("Showcard Gothic", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
        label1.ForeColor = Color.Red;
        label1.Location = new Point(130, 61);
        label1.Name = "label1";
        label1.Size = new Size(124, 43);
        label1.TabIndex = 0;
        label1.Text = "Login";
        // 
        // LoginForm
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        BackgroundImageLayout = ImageLayout.Center;
        ClientSize = new Size(837, 450);
        Controls.Add(splitContainer1);
        FormBorderStyle = FormBorderStyle.None;
        Name = "LoginForm";
        Text = "Form1";
        splitContainer1.Panel2.ResumeLayout(false);
        splitContainer1.Panel2.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
        splitContainer1.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
        ResumeLayout(false);
    }

    #endregion

    private SplitContainer splitContainer1;
    private TextBox textBox1;
    private Label label3;
    private Label label2;
    private Label label1;
    private TextBox textBox2;
    private CheckBox chbRememberMe;
    private Button btnLogin;
    private PictureBox pictureBox1;
}
