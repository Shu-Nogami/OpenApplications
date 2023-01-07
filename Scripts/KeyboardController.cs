using System;

public class KeyboardController : Object
{
	private ApplicationModel _applicationModel;

	public KeyboardController(ApplicationModel applicationModel)
	{
		_applicationModel = applicationModel;
		this.PushKeyAction();
	}

	private void PushKeyAction()
	{
		while(true){
		    int pushedKey;
		    pushedKey = Console.Read();
		    _applicationModel.OpenApplication((char)pushedKey);
		}
		
	}

}

