﻿//-----------------------------------------------------------------------
// <copyright file="OrderMaint.Designer.cs" company="Marimer LLC">
//     Copyright (c) Marimer LLC. All rights reserved.
//     Website: http://www.lhotka.net/cslanet/
// </copyright>
// <summary></summary>
//-----------------------------------------------------------------------

namespace ActionExtenderSample
{
  partial class OrderMaint
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
      this.components = new System.ComponentModel.Container();
      Wisej.Web.Label cardHolderLabel;
      Wisej.Web.Label cardTypeLabel;
      Wisej.Web.Label creditCardLabel;
      Wisej.Web.Label expDateLabel;
      Wisej.Web.Label orderIDLabel;
      Wisej.Web.Label orderNumberLabel;
      Wisej.Web.Label userNameLabel;
      Wisej.Web.Label textLabel;
      Wisej.Web.DataGridViewCellStyle dataGridViewCellStyle1 = new Wisej.Web.DataGridViewCellStyle();
      Wisej.Web.DataGridViewCellStyle dataGridViewCellStyle2 = new Wisej.Web.DataGridViewCellStyle();
      this.cardHolderTextBox = new Wisej.Web.TextBox();
      this.orderBindingSource = new Wisej.Web.BindingSource(this.components);
      this.cardTypeTextBox = new Wisej.Web.TextBox();
      this.creditCardTextBox = new Wisej.Web.TextBox();
      this.expDateTextBox = new Wisej.Web.TextBox();
      this.orderIDLabel1 = new Wisej.Web.Label();
      this.orderNumberTextBox = new Wisej.Web.TextBox();
      this.userNameTextBox = new Wisej.Web.TextBox();
      this.orderDateTextBox = new Wisej.Web.TextBox();
      this.orderDetailListBindingSource = new Wisej.Web.BindingSource(this.components);
      this.orderDetailListDataGridView = new Wisej.Web.DataGridView();
      this.btnForceSave = new Wisej.Web.Button();
      this.btnValidate = new Wisej.Web.Button();
      this.btnClose = new Wisej.Web.Button();
      this.btnCancel = new Wisej.Web.Button();
      this.btnSaveClose = new Wisej.Web.Button();
      this.btnSaveNew = new Wisej.Web.Button();
      this.btnSave = new Wisej.Web.Button();
      this.cslaActionExtender1 = new CslaContrib.WisejWeb.CslaActionExtender(this.components);
      this.errorProvider1 = new Wisej.Web.ErrorProvider(this.components);
      this.dataGridViewTextBoxColumn1 = new Wisej.Web.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn3 = new Wisej.Web.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn4 = new Wisej.Web.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn5 = new Wisej.Web.DataGridViewTextBoxColumn();
      cardHolderLabel = new Wisej.Web.Label();
      cardTypeLabel = new Wisej.Web.Label();
      creditCardLabel = new Wisej.Web.Label();
      expDateLabel = new Wisej.Web.Label();
      orderIDLabel = new Wisej.Web.Label();
      orderNumberLabel = new Wisej.Web.Label();
      userNameLabel = new Wisej.Web.Label();
      textLabel = new Wisej.Web.Label();
      ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.orderDetailListBindingSource)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.orderDetailListDataGridView)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
      this.SuspendLayout();
      // 
      // cardHolderLabel
      // 
      cardHolderLabel.AutoSize = true;
      cardHolderLabel.Location = new System.Drawing.Point(36, 59);
      cardHolderLabel.Name = "cardHolderLabel";
      cardHolderLabel.Size = new System.Drawing.Size(66, 13);
      cardHolderLabel.TabIndex = 1;
      cardHolderLabel.Text = "Card Holder:";
      // 
      // cardTypeLabel
      // 
      cardTypeLabel.AutoSize = true;
      cardTypeLabel.Location = new System.Drawing.Point(36, 85);
      cardTypeLabel.Name = "cardTypeLabel";
      cardTypeLabel.Size = new System.Drawing.Size(59, 13);
      cardTypeLabel.TabIndex = 3;
      cardTypeLabel.Text = "Card Type:";
      // 
      // creditCardLabel
      // 
      creditCardLabel.AutoSize = true;
      creditCardLabel.Location = new System.Drawing.Point(36, 111);
      creditCardLabel.Name = "creditCardLabel";
      creditCardLabel.Size = new System.Drawing.Size(62, 13);
      creditCardLabel.TabIndex = 5;
      creditCardLabel.Text = "Credit Card:";
      // 
      // expDateLabel
      // 
      expDateLabel.AutoSize = true;
      expDateLabel.Location = new System.Drawing.Point(36, 137);
      expDateLabel.Name = "expDateLabel";
      expDateLabel.Size = new System.Drawing.Size(54, 13);
      expDateLabel.TabIndex = 7;
      expDateLabel.Text = "Exp Date:";
      // 
      // orderIDLabel
      // 
      orderIDLabel.AutoSize = true;
      orderIDLabel.Location = new System.Drawing.Point(36, 163);
      orderIDLabel.Name = "orderIDLabel";
      orderIDLabel.Size = new System.Drawing.Size(50, 13);
      orderIDLabel.TabIndex = 9;
      orderIDLabel.Text = "Order ID:";
      // 
      // orderNumberLabel
      // 
      orderNumberLabel.AutoSize = true;
      orderNumberLabel.Location = new System.Drawing.Point(36, 189);
      orderNumberLabel.Name = "orderNumberLabel";
      orderNumberLabel.Size = new System.Drawing.Size(76, 13);
      orderNumberLabel.TabIndex = 11;
      orderNumberLabel.Text = "Order Number:";
      // 
      // userNameLabel
      // 
      userNameLabel.AutoSize = true;
      userNameLabel.Location = new System.Drawing.Point(36, 215);
      userNameLabel.Name = "userNameLabel";
      userNameLabel.Size = new System.Drawing.Size(63, 13);
      userNameLabel.TabIndex = 13;
      userNameLabel.Text = "User Name:";
      // 
      // textLabel
      // 
      textLabel.AutoSize = true;
      textLabel.Location = new System.Drawing.Point(37, 241);
      textLabel.Name = "textLabel";
      textLabel.Size = new System.Drawing.Size(62, 13);
      textLabel.TabIndex = 15;
      textLabel.Text = "Order Date:";
      // 
      // cardHolderTextBox
      // 
      this.cardHolderTextBox.DataBindings.Add(new Wisej.Web.Binding("Text", this.orderBindingSource, "CardHolder", true));
      this.cardHolderTextBox.Location = new System.Drawing.Point(118, 56);
      this.cardHolderTextBox.Name = "cardHolderTextBox";
      this.cardHolderTextBox.Size = new System.Drawing.Size(292, 20);
      this.cardHolderTextBox.TabIndex = 2;
      // 
      // orderBindingSource
      // 
      this.orderBindingSource.DataSource = typeof(ActionExtenderSample.Business.Order);
      this.orderBindingSource.RefreshValueOnChange = true;
      // 
      // cardTypeTextBox
      // 
      this.cardTypeTextBox.DataBindings.Add(new Wisej.Web.Binding("Text", this.orderBindingSource, "CardType", true));
      this.cardTypeTextBox.Location = new System.Drawing.Point(118, 82);
      this.cardTypeTextBox.Name = "cardTypeTextBox";
      this.cardTypeTextBox.Size = new System.Drawing.Size(77, 20);
      this.cardTypeTextBox.TabIndex = 4;
      // 
      // creditCardTextBox
      // 
      this.creditCardTextBox.DataBindings.Add(new Wisej.Web.Binding("Text", this.orderBindingSource, "CreditCard", true));
      this.creditCardTextBox.Location = new System.Drawing.Point(118, 108);
      this.creditCardTextBox.MaxLength = 20;
      this.creditCardTextBox.Name = "creditCardTextBox";
      this.creditCardTextBox.Size = new System.Drawing.Size(140, 20);
      this.creditCardTextBox.TabIndex = 6;
      // 
      // expDateTextBox
      // 
      this.expDateTextBox.DataBindings.Add(new Wisej.Web.Binding("Text", this.orderBindingSource, "ExpDate", true));
      this.expDateTextBox.Location = new System.Drawing.Point(118, 134);
      this.expDateTextBox.Name = "expDateTextBox";
      this.expDateTextBox.Size = new System.Drawing.Size(77, 20);
      this.expDateTextBox.TabIndex = 8;
      // 
      // orderIDLabel1
      // 
      this.orderIDLabel1.DataBindings.Add(new Wisej.Web.Binding("Text", this.orderBindingSource, "OrderID", true));
      this.orderIDLabel1.Location = new System.Drawing.Point(118, 163);
      this.orderIDLabel1.Name = "orderIDLabel1";
      this.orderIDLabel1.Size = new System.Drawing.Size(289, 13);
      this.orderIDLabel1.TabIndex = 10;
      this.orderIDLabel1.Text = "label1";
      // 
      // orderNumberTextBox
      // 
      this.orderNumberTextBox.DataBindings.Add(new Wisej.Web.Binding("Text", this.orderBindingSource, "OrderNumber", true));
      this.orderNumberTextBox.Location = new System.Drawing.Point(118, 186);
      this.orderNumberTextBox.MaxLength = 20;
      this.orderNumberTextBox.Name = "orderNumberTextBox";
      this.orderNumberTextBox.Size = new System.Drawing.Size(140, 20);
      this.orderNumberTextBox.TabIndex = 12;
      // 
      // userNameTextBox
      // 
      this.userNameTextBox.DataBindings.Add(new Wisej.Web.Binding("Text", this.orderBindingSource, "UserName", true));
      this.userNameTextBox.Location = new System.Drawing.Point(118, 212);
      this.userNameTextBox.MaxLength = 50;
      this.userNameTextBox.Name = "userNameTextBox";
      this.userNameTextBox.Size = new System.Drawing.Size(292, 20);
      this.userNameTextBox.TabIndex = 14;
      // 
      // orderDateTextBox
      // 
      this.orderDateTextBox.DataBindings.Add(new Wisej.Web.Binding("Text", this.orderBindingSource, "OrderDate", true));
      this.orderDateTextBox.Location = new System.Drawing.Point(118, 238);
      this.orderDateTextBox.Name = "orderDateTextBox";
      this.orderDateTextBox.Size = new System.Drawing.Size(77, 20);
      this.orderDateTextBox.TabIndex = 16;
      this.orderDateTextBox.Validating += new System.ComponentModel.CancelEventHandler(orderDateTextBox_Validating);
      // 
      // orderDetailListBindingSource
      // 
      this.orderDetailListBindingSource.DataMember = "OrderDetailList";
      this.orderDetailListBindingSource.DataSource = this.orderBindingSource;
      this.orderDetailListBindingSource.RefreshValueOnChange = true;
      // 
      // orderDetailListDataGridView
      // 
      this.orderDetailListDataGridView.AutoGenerateColumns = false;
      this.orderDetailListDataGridView.ColumnHeadersHeightSizeMode = Wisej.Web.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.orderDetailListDataGridView.Columns.AddRange(new Wisej.Web.DataGridViewColumn[] {
      this.dataGridViewTextBoxColumn1,
      this.dataGridViewTextBoxColumn3,
      this.dataGridViewTextBoxColumn4,
      this.dataGridViewTextBoxColumn5});
      this.orderDetailListDataGridView.DataSource = this.orderDetailListBindingSource;
      this.orderDetailListDataGridView.Location = new System.Drawing.Point(76, 284);
      this.orderDetailListDataGridView.Name = "orderDetailListDataGridView";
      this.orderDetailListDataGridView.Size = new System.Drawing.Size(600, 220);
      this.orderDetailListDataGridView.TabIndex = 16;
      this.orderDetailListDataGridView.DataError += new Wisej.Web.DataGridViewDataErrorEventHandler(orderDetailListDataGridView_DataError);
      // 
      // btnForceSave
      // 
      this.cslaActionExtender1.SetActionType(this.btnForceSave, CslaContrib.WisejWeb.CslaFormAction.Save);
      this.btnForceSave.Location = new System.Drawing.Point(518, 238);
      this.btnForceSave.Name = "btnForceSave";
      this.btnForceSave.Size = new System.Drawing.Size(117, 23);
      this.btnForceSave.TabIndex = 22;
      this.btnForceSave.Text = "Force Save";
      // 
      // btnValidate
      // 
      this.cslaActionExtender1.SetActionType(this.btnValidate, CslaContrib.WisejWeb.CslaFormAction.Validate);
      this.btnValidate.Location = new System.Drawing.Point(518, 208);
      this.btnValidate.Name = "btnValidate";
      this.btnValidate.Size = new System.Drawing.Size(117, 23);
      this.btnValidate.TabIndex = 22;
      this.btnValidate.Text = "Validate";
      // 
      // btnClose
      // 
      this.cslaActionExtender1.SetActionType(this.btnClose, CslaContrib.WisejWeb.CslaFormAction.Close);
      this.btnClose.Location = new System.Drawing.Point(518, 158);
      this.btnClose.Name = "btnClose";
      this.btnClose.Size = new System.Drawing.Size(117, 23);
      this.btnClose.TabIndex = 21;
      this.btnClose.Text = "Close";
      // 
      // btnCancel
      // 
      this.cslaActionExtender1.SetActionType(this.btnCancel, CslaContrib.WisejWeb.CslaFormAction.Cancel);
      this.cslaActionExtender1.SetCommandName(this.btnCancel, "Undo");
      this.cslaActionExtender1.SetDisableWhenUseless(this.btnCancel, true);
      this.btnCancel.Location = new System.Drawing.Point(518, 128);
      this.btnCancel.Name = "btnCancel";
      this.btnCancel.Size = new System.Drawing.Size(117, 23);
      this.btnCancel.TabIndex = 20;
      this.btnCancel.Text = "Cancel";
      // 
      // btnSaveClose
      // 
      this.cslaActionExtender1.SetActionType(this.btnSaveClose, CslaContrib.WisejWeb.CslaFormAction.Save);
      this.cslaActionExtender1.SetDisableWhenUseless(this.btnSaveClose, true);
      this.btnSaveClose.Location = new System.Drawing.Point(518, 98);
      this.btnSaveClose.Name = "btnSaveClose";
      this.cslaActionExtender1.SetPostSaveAction(this.btnSaveClose, CslaContrib.WisejWeb.PostSaveActionType.AndClose);
      this.cslaActionExtender1.SetRebindAfterSave(this.btnSaveClose, false);
      this.btnSaveClose.Size = new System.Drawing.Size(117, 23);
      this.btnSaveClose.TabIndex = 19;
      this.btnSaveClose.Text = "Save/Close";
      // 
      // btnSaveNew
      // 
      this.cslaActionExtender1.SetActionType(this.btnSaveNew, CslaContrib.WisejWeb.CslaFormAction.Save);
      this.cslaActionExtender1.SetDisableWhenUseless(this.btnSaveNew, true);
      this.btnSaveNew.Location = new System.Drawing.Point(518, 68);
      this.btnSaveNew.Name = "btnSaveNew";
      this.cslaActionExtender1.SetPostSaveAction(this.btnSaveNew, CslaContrib.WisejWeb.PostSaveActionType.AndNew);
      this.btnSaveNew.Size = new System.Drawing.Size(117, 23);
      this.btnSaveNew.TabIndex = 18;
      this.btnSaveNew.Text = "Save/New";
      // 
      // btnSave
      // 
      this.cslaActionExtender1.SetActionType(this.btnSave, CslaContrib.WisejWeb.CslaFormAction.Save);
      this.cslaActionExtender1.SetDisableWhenUseless(this.btnSave, true);
      this.btnSave.Location = new System.Drawing.Point(518, 38);
      this.btnSave.Name = "btnSave";
      this.btnSave.Size = new System.Drawing.Size(117, 23);
      this.btnSave.TabIndex = 17;
      this.btnSave.Text = "Save";
      // 
      // cslaActionExtender1
      // 
      this.cslaActionExtender1.DataSource = this.orderBindingSource;
      this.cslaActionExtender1.ObjectIsValidMessage = "Order is valid";
      this.cslaActionExtender1.SetForNew += new System.EventHandler<CslaContrib.WisejWeb.CslaActionEventArgs>(this.cslaActionExtender1_SetForNew);
      // 
      // errorProvider1
      // 
      this.errorProvider1.ContainerControl = this;
      this.errorProvider1.DataSource = this.orderBindingSource;
      // 
      // dataGridViewTextBoxColumn1
      // 
      this.dataGridViewTextBoxColumn1.DataPropertyName = "OrderDetailID";
      this.dataGridViewTextBoxColumn1.HeaderText = "Order Detail ID";
      this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
      this.dataGridViewTextBoxColumn1.ReadOnly = true;
      this.dataGridViewTextBoxColumn1.Width = 185;
      // 
      // dataGridViewTextBoxColumn3
      // 
      this.dataGridViewTextBoxColumn3.DataPropertyName = "ProductID";
      this.dataGridViewTextBoxColumn3.HeaderText = "Product ID";
      this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
      this.dataGridViewTextBoxColumn3.Width = 185;
      // 
      // dataGridViewTextBoxColumn4
      // 
      this.dataGridViewTextBoxColumn4.DataPropertyName = "PurchaseUnitPrice";
      dataGridViewCellStyle1.Alignment = Wisej.Web.DataGridViewContentAlignment.MiddleRight;
      this.dataGridViewTextBoxColumn4.DefaultCellStyle = dataGridViewCellStyle1;
      this.dataGridViewTextBoxColumn4.HeaderText = "Purchase Unit Price";
      this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
      this.dataGridViewTextBoxColumn4.Width = 130;
      // 
      // dataGridViewTextBoxColumn5
      // 
      this.dataGridViewTextBoxColumn5.AutoSizeMode = Wisej.Web.DataGridViewAutoSizeColumnMode.Fill;
      this.dataGridViewTextBoxColumn5.DataPropertyName = "Quantity";
      dataGridViewCellStyle2.Alignment = Wisej.Web.DataGridViewContentAlignment.MiddleRight;
      this.dataGridViewTextBoxColumn5.DefaultCellStyle = dataGridViewCellStyle2;
      this.dataGridViewTextBoxColumn5.HeaderText = "Quantity";
      this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
      // 
      // OrderMaint
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = Wisej.Web.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(791, 571);
      this.Controls.Add(this.btnForceSave);
      this.Controls.Add(this.btnValidate);
      this.Controls.Add(this.btnClose);
      this.Controls.Add(this.btnCancel);
      this.Controls.Add(this.btnSaveClose);
      this.Controls.Add(this.btnSaveNew);
      this.Controls.Add(this.btnSave);
      this.Controls.Add(this.orderDetailListDataGridView);
      this.Controls.Add(textLabel);
      this.Controls.Add(this.orderDateTextBox);
      this.Controls.Add(cardHolderLabel);
      this.Controls.Add(this.cardHolderTextBox);
      this.Controls.Add(cardTypeLabel);
      this.Controls.Add(this.cardTypeTextBox);
      this.Controls.Add(creditCardLabel);
      this.Controls.Add(this.creditCardTextBox);
      this.Controls.Add(expDateLabel);
      this.Controls.Add(this.expDateTextBox);
      this.Controls.Add(orderIDLabel);
      this.Controls.Add(this.orderIDLabel1);
      this.Controls.Add(orderNumberLabel);
      this.Controls.Add(this.orderNumberTextBox);
      this.Controls.Add(userNameLabel);
      this.Controls.Add(this.userNameTextBox);
      this.Name = "OrderMaint";
      this.Text = "Order Maintenance - Button";
      ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.orderDetailListBindingSource)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.orderDetailListDataGridView)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private Wisej.Web.BindingSource orderBindingSource;
    private Wisej.Web.TextBox cardHolderTextBox;
    private Wisej.Web.TextBox cardTypeTextBox;
    private Wisej.Web.TextBox creditCardTextBox;
    private Wisej.Web.TextBox expDateTextBox;
    private Wisej.Web.Label orderIDLabel1;
    private Wisej.Web.TextBox orderNumberTextBox;
    private Wisej.Web.TextBox userNameTextBox;
    private Wisej.Web.TextBox orderDateTextBox;
    private Wisej.Web.BindingSource orderDetailListBindingSource;
    private Wisej.Web.DataGridView orderDetailListDataGridView;
    private CslaContrib.WisejWeb.CslaActionExtender cslaActionExtender1;
    private Wisej.Web.Button btnSave;
    private Wisej.Web.Button btnSaveNew;
    private Wisej.Web.Button btnSaveClose;
    private Wisej.Web.Button btnCancel;
    private Wisej.Web.Button btnClose;
    private Wisej.Web.Button btnForceSave;
    private Wisej.Web.Button btnValidate;
    private Wisej.Web.ErrorProvider errorProvider1;
    private Wisej.Web.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
    private Wisej.Web.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    private Wisej.Web.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    private Wisej.Web.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
  }
}