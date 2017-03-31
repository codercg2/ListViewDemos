using System;
using System.Windows.Forms;

class ControlFlatStyle
{
	public static void SetFlatStyleSystem(Control parent)
	{
		foreach (Control control in parent.Controls)
		{
			ButtonBase button = control as ButtonBase;
			GroupBox group = control as GroupBox;
			Label label = control as Label;
			if (button!=null) button.FlatStyle = FlatStyle.System;
			else if (group!=null) group.FlatStyle = FlatStyle.System;
			else if (label!=null) label.FlatStyle = FlatStyle.System;

			ControlFlatStyle.SetFlatStyleSystem(control);
		}
	}
}