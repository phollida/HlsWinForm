namespace HlsWinForm;

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
        blazorWebView = new Microsoft.AspNetCore.Components.WebView.WindowsForms.BlazorWebView();
        SuspendLayout();
        // 
        // blazorWebView
        // 
        blazorWebView.Dock = DockStyle.Fill;
        blazorWebView.Location = new Point(0, 0);
        blazorWebView.Name = "blazorWebView";
        blazorWebView.Size = new Size(640, 450);
        blazorWebView.TabIndex = 0;
        blazorWebView.Text = "blazorWebView1";
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(800, 600);
        Controls.Add(blazorWebView);
        Name = "Form1";
        Text = "Form1";
        Width = 1024;
        Height =768;
        ResumeLayout(false);
        
    }

    #endregion

    private Microsoft.AspNetCore.Components.WebView.WindowsForms.BlazorWebView blazorWebView;
}