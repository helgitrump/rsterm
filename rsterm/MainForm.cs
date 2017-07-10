/*
 * Oleg Kozyr
 * Created by SharpDevelop.
 * Date: 09.07.2017
 * 
 */
 
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO.Ports;

namespace rsterm
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
        #region Filds
        private SerialPort rsPort;
        private const string _RS_Init_PortName = "COM1";
        private const int _RS_Init_BaudRate = 9600;
        private const Parity _RS_Init_Parity = Parity.None;
        private const int _RS_Init_DataBits = 8;
        private const StopBits _RS_Init_StopBits = StopBits.One;
        private const bool _RS_Init_RST_Enable = false;
        private const bool _RS_Init_DSR_Enable = false;
        #endregion Filds		
		
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		private void InitRS_Port()
        {// Initialize rsPort field
            rsPort = new SerialPort(
                _RS_Init_PortName, 
                _RS_Init_BaudRate,
                _RS_Init_Parity,
                _RS_Init_DataBits,
                _RS_Init_StopBits);
            rsPort.RtsEnable = _RS_Init_RST_Enable;
            rsPort.DtrEnable = _RS_Init_DSR_Enable;
            rsPort.ReadTimeout = 2000;
            rsPort.WriteTimeout = 2000;
        }
		
	}
}
