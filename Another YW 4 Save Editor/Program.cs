using MXQ;

namespace Another_YW_4_Save_Editor
{
	internal static class Program
	{
		[STAThread]
		static void Main()
		{
			ApplicationConfiguration.Initialize();
			Form form1 = new Form1();
			form1.StartPosition = FormStartPosition.CenterScreen;
			Application.Run(form1);
		}
	}
}