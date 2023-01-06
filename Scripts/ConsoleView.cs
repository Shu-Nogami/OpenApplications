using Syetem;

public class ConsoleView : Object
{
	private ApplicationModel _applicationModel;

	public ConsoleView(ApplicationModel applicationModel)
	{
		_applicationModel = applicationModel;
		new KeyboardController(_applicationModel);
		this.Initialize();
	}

	public void Initialize()
	{

	}

	public void WriteConsole(string keyName)
	{

	}

}

