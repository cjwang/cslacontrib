﻿//-----------------------------------------------------------------------
// <copyright file="OrderMaint2.cs" company="Marimer LLC">
//     Copyright (c) Marimer LLC. All rights reserved.
//     Website: http://www.lhotka.net/cslanet/
// </copyright>
// <summary></summary>
//-----------------------------------------------------------------------
using System;
using ActionExtenderSample.Business;
using CslaContrib.WebGUI;
using Gizmox.WebGUI.Forms;

namespace ActionExtenderSample
{
  public partial class OrderMaint2 : Form
  {
    private Order _order = null;

    private OrderMaint2()
    {
    }

    public OrderMaint2(Guid orderId)
    {
      InitializeComponent();

      _order = Order.GetOrder(orderId);
      BindUI();
    }

    private void BindUI()
    {
      cslaActionExtender1.ResetActionBehaviors(_order);
    }

    private void cslaActionExtender1_SetForNew(object sender, CslaActionEventArgs e)
    {
      _order = Order.NewOrder();
      BindUI();
    }

    private void ToggleImageToolStripButton(object sender, EventArgs e)
    {
      string imageName = string.Format("{0}{1}.Image", ((ToolStripButton) sender).Name, ((ToolStripButton) sender).Enabled ? "" : "Disabled");
      ((ToolStripButton) sender).Image = new Gizmox.WebGUI.Common.Resources.IconResourceHandle(resources.GetString(imageName));
    }

    private void ToggleTextToolStripButton(object sender, EventArgs e)
    {
      ((ToolStripButton)sender).Update();
    }

    private void orderDetailListDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
    {
      e.Cancel = true;
    }

    private void orderDateTextBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
    {
      var textBox = sender as TextBox;
      if (textBox != null && textBox.Name == "orderDateTextBox")
        orderBindingSource.BindingComplete += orderBindingSource_BindingComplete;
    }

    private void orderBindingSource_BindingComplete(object sender, BindingCompleteEventArgs e)
    {
      orderBindingSource.BindingComplete -= orderBindingSource_BindingComplete;
      if (e.BindingCompleteState != BindingCompleteState.Success)
      {
        var textBox = e.Binding.BindableComponent as TextBox;
        if (textBox != null && textBox.Name == "orderDateTextBox")
        {
          textBox.Text = ((sender as BindingSource).Current as Order).OrderDate;
        }
      }
    }
  }
}
