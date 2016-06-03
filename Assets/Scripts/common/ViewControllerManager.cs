using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class ViewControllerManager{
	private static ViewControllerManager _instance = null;
	private ViewControllerManager(){}
	public static ViewControllerManager getInstance()
	{
		if(_instance == null)
		{
			_instance = new ViewControllerManager();
		}
		return _instance;
	}

	public void goTo(string viewControllerName)
	{
		SceneManager.LoadScene (viewControllerName);
	}
}