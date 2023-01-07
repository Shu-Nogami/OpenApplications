using System;
using System.Diagnostics;

public class ApplicationModel : Object
{
	private readonly char PROCESS_KEY_LINE = 'b';

	private ConsoleView _consoleView;

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
		if(pushedKey.Equals(PROCESS_KEY_LINE)){
	        Process.Start(ApplicationNames.LINE);
		}
		
	}
}

