﻿//-----------------------------------------------------------------------
// <copyright file="Form1.Designer.cs" company="Marimer LLC">
//     Copyright (c) Marimer LLC. All rights reserved.
//     Website: http://www.lhotka.net/cslanet/
// </copyright>
// <summary></summary>
//-----------------------------------------------------------------------

namespace ActionExtenderSample
{
  partial class Page1
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
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
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.button1 = new Wisej.Web.Button();
      this.button2 = new Wisej.Web.Button();
      this.button3 = new Wisej.Web.Button();
      this.label1 = new Wisej.Web.Label();
      this.label2 = new Wisej.Web.Label();
      this.label3 = new Wisej.Web.Label();
      this.SuspendLayout();
      // 
      // button1
      // 
      this.button1.Location = new System.Drawing.Point(359, 23);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(75, 23);
      this.button1.TabIndex = 0;
      this.button1.Text = "Button";
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // button2
      // 
      this.button2.Location = new System.Drawing.Point(359, 75);
      this.button2.Name = "button2";
      this.button2.Size = new System.Drawing.Size(75, 23);
      this.button2.TabIndex = 1;
      this.button2.Text = "ToolBar";
      this.button2.Click += new System.EventHandler(this.button2_Click);
      // 
      // button3
      // 
      this.button3.Location = new System.Drawing.Point(359, 127);
      this.button3.Name = "button3";
      this.button3.Size = new System.Drawing.Size(75, 23);
      this.button3.TabIndex = 2;
      this.button3.Text = "Helper";
      this.button3.Click += new System.EventHandler(this.button3_Click);
      // 
      // label1
      // 
      this.label1.Location = new System.Drawing.Point(12, 23);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(341, 42);
      this.label1.TabIndex = 3;
      this.label1.Text = "Sample usage of CSLA Action Extender, demonstrating how buttons can be extended to automate CSLA actions.";
      // 
      // label2
      // 
      this.label2.Location = new System.Drawing.Point(12, 75);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(341, 42);
      this.label2.TabIndex = 4;
      this.label2.Text = "Sample usage of CSLA Action Extender, demonstrating how toolbar buttons can be extended to automate CSLA actions.";
      // 
      // label3
      // 
      this.label3.Location = new System.Drawing.Point(12, 127);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(341, 42);
      this.label3.TabIndex = 5;
      this.label3.Text = "Sample usage of BindingSourceHelper and BindingSourceNode components, demonstrating how toolbar buttons can incorporate functionality.";
      // 
      // Page1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = Wisej.Web.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(451, 189);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.button3);
      this.Controls.Add(this.button2);
      this.Controls.Add(this.button1);
      this.Name = "Page1";
      this.Text = "Main Page";
      this.ResumeLayout(false);

    }

    #endregion

    private Wisej.Web.Button button1;
    private Wisej.Web.Button button2;
    private Wisej.Web.Button button3;
    private Wisej.Web.Label label1;
    private Wisej.Web.Label label2;
    private Wisej.Web.Label label3;
  }
}