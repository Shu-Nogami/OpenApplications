using System;

public class ConsoleView : Object
{
	private ApplicationModel _applicationModel;

	public ConsoleView(ApplicationModel applicationModel)
	{
		_applicationModel = applicationModel;
		applicationModel.SetColsoleView(this);
		new KeyboardController(_applicationModel);
		this.Initialize();
	}

	public void Initialize()
	{

	}

	public void WriteConsole(char keyName)
	{
		Console.Write("\r\n{0}が入力されました\r\n", keyName);
	}

}

