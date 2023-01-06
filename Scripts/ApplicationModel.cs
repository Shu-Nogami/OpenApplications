using System;
using System.Windows.Forms;

public class ApplicationModel : Object
{
	private ConsoleView _consoleView;

	public ApplicationModel()
	{
		this.Initialize();
		_consoleView = new ConsoleView(this);
	}

	public void CloseApplications()
	{

	}

	public void Initialize()
	{

	}

	public void OpenApplication(KeyEventArgs pushedKey)
	{

	}

}

