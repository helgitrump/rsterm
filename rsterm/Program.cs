/*
 * Oleg Kozyr
 * Created by SharpDevelop.
 * Date: 09.07.2017
 * 
 */
 
using System;
using System.Windows.Forms;

namespace rsterm
{
	/// <summary>
	/// Class with program entry point.
	/// </summary>
	internal sealed class Program
	{
		/// <summary>
		/// Program entry point.
		/// </summary>
		[STAThread]
		private static void Main(string[] args)
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new MainForm());
		}
		
	}
}
