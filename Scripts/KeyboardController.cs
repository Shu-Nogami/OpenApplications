using System;
using System.Windows.Forms;

public class KeyboardController : Object
{
	private ApplicationModel _applicationModel;

	public KeyboardController(ApplicationModel applicationModel)
	{
		_applicationModel = applicationModel;
	}

	public void PushKeyAction(object sender, KeyEventArgs pushedKey)
	{

	}

}

