using System;
using System.Diagnostics;

public class ApplicationModel : Object
{
	private readonly char PROCESS_KEY_LINE = 'b';

	private ConsoleView _consoleView;
	private bool _isOpenLINE;

	public ApplicationModel()
	{
		this.Initialize();
		new ConsoleView(this);
	}

	public void SetConsoleView(ConsoleView consoleView){
		_consoleView = consoleView;
	}

	public void CloseApplications()
	{

	}

	public void Initialize()
	{

	}

	public void OpenApplication(char pushedKey)
	{
		_consoleView.WriteConsole(pushedKey);
		if(pushedKey.Equals(PROCESS_KEY_LINE) && _isOpenLINE == false){
			_isOpenLINE = true;
	        Process.Start(ApplicationNames.LINE);
		}
		
	}
}

