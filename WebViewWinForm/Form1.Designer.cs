namespace WebViewWinForm;

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
        webView21 = new Microsoft.Web.WebView2.WinForms.WebView2();
        button1 = new Button();
        button2 = new Button();
        panel1 = new Panel();
        panel2 = new Panel();
        ((System.ComponentModel.ISupportInitialize)webView21).BeginInit();
        panel1.SuspendLayout();
        panel2.SuspendLayout();
        SuspendLayout();
        // 
        // webView21
        // 
        webView21.AllowExternalDrop = true;
        webView21.CreationProperties = null;
        webView21.DefaultBackgroundColor = Color.White;
        webView21.Dock = DockStyle.Fill;
        webView21.Location = new Point(0, 0);
        webView21.Name = "webView21";
        webView21.Size = new Size(800, 381);
        webView21.Source = new Uri("http://localhost:8080/video", UriKind.Absolute);
        webView21.TabIndex = 0;
        webView21.ZoomFactor = 1D;
        // 
        // button1
        // 
        button1.Location = new Point(22, 19);
        button1.Name = "button1";
        button1.Size = new Size(209, 29);
        button1.TabIndex = 1;
        button1.Text = "Navigate to localhost";
        button1.UseVisualStyleBackColor = true;
        button1.Click += button1_Click;
        // 
        // button2
        // 
        button2.Location = new Point(260, 19);
        button2.Name = "button2";
        button2.Size = new Size(209, 29);
        button2.TabIndex = 1;
        button2.Text = "Navigate using raw HTML";
        button2.UseVisualStyleBackColor = true;
        button2.Click += button2_Click;
        // 
        // panel1
        // 
        panel1.Controls.Add(button2);
        panel1.Controls.Add(button1);
        panel1.Dock = DockStyle.Top;
        panel1.Location = new Point(0, 0);
        panel1.Name = "panel1";
        panel1.Size = new Size(800, 69);
        panel1.TabIndex = 2;
        // 
        // panel2
        // 
        panel2.Controls.Add(webView21);
        panel2.Dock = DockStyle.Fill;
        panel2.Location = new Point(0, 69);
        panel2.Name = "panel2";
        panel2.Size = new Size(800, 381);
        panel2.TabIndex = 3;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(800, 450);
        Controls.Add(panel2);
        Controls.Add(panel1);
        Name = "Form1";
        Text = "Form1";
        Load += Form1_Load;
        ((System.ComponentModel.ISupportInitialize)webView21).EndInit();
        panel1.ResumeLayout(false);
        panel2.ResumeLayout(false);
        ResumeLayout(false);
    }

    #endregion

    private Microsoft.Web.WebView2.WinForms.WebView2 webView21;
    private Button button1;
    private Button button2;
    private Panel panel1;
    private Panel panel2;
}