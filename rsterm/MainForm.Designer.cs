/*
 * Oleg Kozyr
 * Created by SharpDevelop.
 * Date: 09.07.2017
 * 
 */
 
namespace rsterm
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.ComboBox cmb_RS_PortName;
		private System.Windows.Forms.Label lbl_RS_PortName;
		private System.Windows.Forms.NumericUpDown numUD_RS_BaudRate;
		private System.Windows.Forms.Label lbl_RS_BaudRate;
		private System.Windows.Forms.ComboBox cmb_RS_Parity;
		private System.Windows.Forms.Label lbl_RS_Parity;
		private System.Windows.Forms.NumericUpDown numUD_RS_DataBits;
		private System.Windows.Forms.Label lbl_RS_DataBits;
		private System.Windows.Forms.ComboBox cmb_RS_StopBits;
		private System.Windows.Forms.Label lbl_RS_StopBits;
		private System.Windows.Forms.CheckBox ckb_RS_RTS_Enable;
		private System.Windows.Forms.CheckBox ckb_RS_DTR_Enable;
		private System.Windows.Forms.Button btn_RS_OpenPort;
		private System.Windows.Forms.Button btn_RS_ClosePort;
		private System.Windows.Forms.TextBox txb_Data2Send;
		private System.Windows.Forms.Button btn_RS_SendData;
		private System.Windows.Forms.Label lbl_Data2Send;
		private System.Windows.Forms.TextBox txb__ReceivedData;
		private System.Windows.Forms.Label lbl_ReceivedData;
		private System.Windows.Forms.Button btn_ReceiveData;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.cmb_RS_PortName = new System.Windows.Forms.ComboBox();
			this.lbl_RS_PortName = new System.Windows.Forms.Label();
			this.numUD_RS_BaudRate = new System.Windows.Forms.NumericUpDown();
			this.lbl_RS_BaudRate = new System.Windows.Forms.Label();
			this.cmb_RS_Parity = new System.Windows.Forms.ComboBox();
			this.lbl_RS_Parity = new System.Windows.Forms.Label();
			this.numUD_RS_DataBits = new System.Windows.Forms.NumericUpDown();
			this.lbl_RS_DataBits = new System.Windows.Forms.Label();
			this.cmb_RS_StopBits = new System.Windows.Forms.ComboBox();
			this.lbl_RS_StopBits = new System.Windows.Forms.Label();
			this.ckb_RS_RTS_Enable = new System.Windows.Forms.CheckBox();
			this.ckb_RS_DTR_Enable = new System.Windows.Forms.CheckBox();
			this.btn_RS_OpenPort = new System.Windows.Forms.Button();
			this.btn_RS_ClosePort = new System.Windows.Forms.Button();
			this.txb_Data2Send = new System.Windows.Forms.TextBox();
			this.btn_RS_SendData = new System.Windows.Forms.Button();
			this.lbl_Data2Send = new System.Windows.Forms.Label();
			this.txb__ReceivedData = new System.Windows.Forms.TextBox();
			this.lbl_ReceivedData = new System.Windows.Forms.Label();
			this.btn_ReceiveData = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.numUD_RS_BaudRate)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numUD_RS_DataBits)).BeginInit();
			this.SuspendLayout();
			// 
			// cmb_RS_PortName
			// 
			this.cmb_RS_PortName.FormattingEnabled = true;
			this.cmb_RS_PortName.Location = new System.Drawing.Point(12, 29);
			this.cmb_RS_PortName.Name = "cmb_RS_PortName";
			this.cmb_RS_PortName.Size = new System.Drawing.Size(80, 21);
			this.cmb_RS_PortName.TabIndex = 0;
			// 
			// lbl_RS_PortName
			// 
			this.lbl_RS_PortName.Location = new System.Drawing.Point(12, 9);
			this.lbl_RS_PortName.Name = "lbl_RS_PortName";
			this.lbl_RS_PortName.Size = new System.Drawing.Size(80, 17);
			this.lbl_RS_PortName.TabIndex = 1;
			this.lbl_RS_PortName.Text = "Port name";
			// 
			// numUD_RS_BaudRate
			// 
			this.numUD_RS_BaudRate.Location = new System.Drawing.Point(108, 29);
			this.numUD_RS_BaudRate.Name = "numUD_RS_BaudRate";
			this.numUD_RS_BaudRate.Size = new System.Drawing.Size(79, 20);
			this.numUD_RS_BaudRate.TabIndex = 2;
			// 
			// lbl_RS_BaudRate
			// 
			this.lbl_RS_BaudRate.Location = new System.Drawing.Point(108, 9);
			this.lbl_RS_BaudRate.Name = "lbl_RS_BaudRate";
			this.lbl_RS_BaudRate.Size = new System.Drawing.Size(91, 17);
			this.lbl_RS_BaudRate.TabIndex = 1;
			this.lbl_RS_BaudRate.Text = "Baud rate";
			// 
			// cmb_RS_Parity
			// 
			this.cmb_RS_Parity.FormattingEnabled = true;
			this.cmb_RS_Parity.Location = new System.Drawing.Point(206, 28);
			this.cmb_RS_Parity.Name = "cmb_RS_Parity";
			this.cmb_RS_Parity.Size = new System.Drawing.Size(80, 21);
			this.cmb_RS_Parity.TabIndex = 0;
			// 
			// lbl_RS_Parity
			// 
			this.lbl_RS_Parity.Location = new System.Drawing.Point(206, 8);
			this.lbl_RS_Parity.Name = "lbl_RS_Parity";
			this.lbl_RS_Parity.Size = new System.Drawing.Size(80, 17);
			this.lbl_RS_Parity.TabIndex = 1;
			this.lbl_RS_Parity.Text = "Parity";
			// 
			// numUD_RS_DataBits
			// 
			this.numUD_RS_DataBits.Location = new System.Drawing.Point(304, 28);
			this.numUD_RS_DataBits.Name = "numUD_RS_DataBits";
			this.numUD_RS_DataBits.Size = new System.Drawing.Size(79, 20);
			this.numUD_RS_DataBits.TabIndex = 2;
			// 
			// lbl_RS_DataBits
			// 
			this.lbl_RS_DataBits.Location = new System.Drawing.Point(304, 8);
			this.lbl_RS_DataBits.Name = "lbl_RS_DataBits";
			this.lbl_RS_DataBits.Size = new System.Drawing.Size(80, 17);
			this.lbl_RS_DataBits.TabIndex = 1;
			this.lbl_RS_DataBits.Text = "Data bits";
			// 
			// cmb_RS_StopBits
			// 
			this.cmb_RS_StopBits.FormattingEnabled = true;
			this.cmb_RS_StopBits.Location = new System.Drawing.Point(400, 27);
			this.cmb_RS_StopBits.Name = "cmb_RS_StopBits";
			this.cmb_RS_StopBits.Size = new System.Drawing.Size(80, 21);
			this.cmb_RS_StopBits.TabIndex = 0;
			// 
			// lbl_RS_StopBits
			// 
			this.lbl_RS_StopBits.Location = new System.Drawing.Point(400, 9);
			this.lbl_RS_StopBits.Name = "lbl_RS_StopBits";
			this.lbl_RS_StopBits.Size = new System.Drawing.Size(80, 17);
			this.lbl_RS_StopBits.TabIndex = 1;
			this.lbl_RS_StopBits.Text = "Stop bits";
			// 
			// ckb_RS_RTS_Enable
			// 
			this.ckb_RS_RTS_Enable.Appearance = System.Windows.Forms.Appearance.Button;
			this.ckb_RS_RTS_Enable.Location = new System.Drawing.Point(304, 66);
			this.ckb_RS_RTS_Enable.Name = "ckb_RS_RTS_Enable";
			this.ckb_RS_RTS_Enable.Size = new System.Drawing.Size(80, 24);
			this.ckb_RS_RTS_Enable.TabIndex = 3;
			this.ckb_RS_RTS_Enable.Text = "RTS enable";
			this.ckb_RS_RTS_Enable.UseVisualStyleBackColor = true;
			// 
			// ckb_RS_DTR_Enable
			// 
			this.ckb_RS_DTR_Enable.Appearance = System.Windows.Forms.Appearance.Button;
			this.ckb_RS_DTR_Enable.Location = new System.Drawing.Point(400, 66);
			this.ckb_RS_DTR_Enable.Name = "ckb_RS_DTR_Enable";
			this.ckb_RS_DTR_Enable.Size = new System.Drawing.Size(80, 24);
			this.ckb_RS_DTR_Enable.TabIndex = 3;
			this.ckb_RS_DTR_Enable.Text = "DTR enable";
			this.ckb_RS_DTR_Enable.UseVisualStyleBackColor = true;
			// 
			// btn_RS_OpenPort
			// 
			this.btn_RS_OpenPort.Location = new System.Drawing.Point(12, 67);
			this.btn_RS_OpenPort.Name = "btn_RS_OpenPort";
			this.btn_RS_OpenPort.Size = new System.Drawing.Size(75, 23);
			this.btn_RS_OpenPort.TabIndex = 4;
			this.btn_RS_OpenPort.Text = "Open";
			this.btn_RS_OpenPort.UseVisualStyleBackColor = true;
			// 
			// btn_RS_ClosePort
			// 
			this.btn_RS_ClosePort.Location = new System.Drawing.Point(108, 66);
			this.btn_RS_ClosePort.Name = "btn_RS_ClosePort";
			this.btn_RS_ClosePort.Size = new System.Drawing.Size(75, 23);
			this.btn_RS_ClosePort.TabIndex = 4;
			this.btn_RS_ClosePort.Text = "Close";
			this.btn_RS_ClosePort.UseVisualStyleBackColor = true;
			// 
			// txb_Data2Send
			// 
			this.txb_Data2Send.Location = new System.Drawing.Point(12, 131);
			this.txb_Data2Send.Name = "txb_Data2Send";
			this.txb_Data2Send.Size = new System.Drawing.Size(398, 20);
			this.txb_Data2Send.TabIndex = 5;
			// 
			// btn_RS_SendData
			// 
			this.btn_RS_SendData.Location = new System.Drawing.Point(428, 131);
			this.btn_RS_SendData.Name = "btn_RS_SendData";
			this.btn_RS_SendData.Size = new System.Drawing.Size(75, 23);
			this.btn_RS_SendData.TabIndex = 4;
			this.btn_RS_SendData.Text = "Send";
			this.btn_RS_SendData.UseVisualStyleBackColor = true;
			// 
			// lbl_Data2Send
			// 
			this.lbl_Data2Send.Location = new System.Drawing.Point(12, 111);
			this.lbl_Data2Send.Name = "lbl_Data2Send";
			this.lbl_Data2Send.Size = new System.Drawing.Size(80, 17);
			this.lbl_Data2Send.TabIndex = 1;
			this.lbl_Data2Send.Text = "Data to send";
			// 
			// txb__ReceivedData
			// 
			this.txb__ReceivedData.Location = new System.Drawing.Point(12, 183);
			this.txb__ReceivedData.Multiline = true;
			this.txb__ReceivedData.Name = "txb__ReceivedData";
			this.txb__ReceivedData.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.txb__ReceivedData.Size = new System.Drawing.Size(398, 143);
			this.txb__ReceivedData.TabIndex = 5;
			// 
			// lbl_ReceivedData
			// 
			this.lbl_ReceivedData.Location = new System.Drawing.Point(12, 163);
			this.lbl_ReceivedData.Name = "lbl_ReceivedData";
			this.lbl_ReceivedData.Size = new System.Drawing.Size(80, 17);
			this.lbl_ReceivedData.TabIndex = 1;
			this.lbl_ReceivedData.Text = "Received data";
			// 
			// btn_ReceiveData
			// 
			this.btn_ReceiveData.Location = new System.Drawing.Point(428, 183);
			this.btn_ReceiveData.Name = "btn_ReceiveData";
			this.btn_ReceiveData.Size = new System.Drawing.Size(75, 23);
			this.btn_ReceiveData.TabIndex = 4;
			this.btn_ReceiveData.Text = "Send";
			this.btn_ReceiveData.UseVisualStyleBackColor = true;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(515, 338);
			this.Controls.Add(this.txb__ReceivedData);
			this.Controls.Add(this.txb_Data2Send);
			this.Controls.Add(this.btn_RS_ClosePort);
			this.Controls.Add(this.btn_ReceiveData);
			this.Controls.Add(this.btn_RS_SendData);
			this.Controls.Add(this.btn_RS_OpenPort);
			this.Controls.Add(this.ckb_RS_DTR_Enable);
			this.Controls.Add(this.ckb_RS_RTS_Enable);
			this.Controls.Add(this.numUD_RS_DataBits);
			this.Controls.Add(this.numUD_RS_BaudRate);
			this.Controls.Add(this.lbl_RS_StopBits);
			this.Controls.Add(this.lbl_RS_DataBits);
			this.Controls.Add(this.lbl_RS_Parity);
			this.Controls.Add(this.lbl_RS_BaudRate);
			this.Controls.Add(this.lbl_ReceivedData);
			this.Controls.Add(this.lbl_Data2Send);
			this.Controls.Add(this.lbl_RS_PortName);
			this.Controls.Add(this.cmb_RS_StopBits);
			this.Controls.Add(this.cmb_RS_Parity);
			this.Controls.Add(this.cmb_RS_PortName);
			this.Name = "MainForm";
			this.Text = "rsterm";
			((System.ComponentModel.ISupportInitialize)(this.numUD_RS_BaudRate)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numUD_RS_DataBits)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
