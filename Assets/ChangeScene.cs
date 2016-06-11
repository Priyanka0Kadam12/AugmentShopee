using UnityEngine;
using System.Collections;

public class ChangeScene : MonoBehaviour {


	public void ChangeToScene (string sceneToChangeTo)
	{
		Application.LoadLevel (sceneToChangeTo );
	}

	public void Update()
	{
		if (Input.GetKeyDown(KeyCode.Escape)&& (Application.loadedLevelName)=="Second") 
			Application.LoadLevel(0);
		else if(Input.GetKeyDown(KeyCode.Escape)&& (Application.loadedLevelName)=="Third")
			Application.LoadLevel(1);
		else if(Input.GetKeyDown(KeyCode.Escape)&& (Application.loadedLevelName)=="Forth")
			Application.LoadLevel(2);
		else if(Input.GetKeyDown(KeyCode.Escape)&& (Application.loadedLevelName)=="Fifth")
			Application.LoadLevel(2);
		else if(Input.GetKeyDown(KeyCode.Escape)&& (Application.loadedLevelName)=="Sixth")
			Application.LoadLevel(2);
		else if(Input.GetKeyDown(KeyCode.Escape)&& (Application.loadedLevelName)=="Seventh")
			Application.LoadLevel(2);
		else if(Input.GetKeyDown(KeyCode.Escape)&& (Application.loadedLevelName)=="Eight")
			Application.LoadLevel(1);
		else if(Input.GetKeyDown(KeyCode.Escape)&& (Application.loadedLevelName)=="Nine")
			Application.LoadLevel(7);
		else if(Input.GetKeyDown(KeyCode.Escape)&& (Application.loadedLevelName)=="Ten")
			Application.LoadLevel(7);
		else if(Input.GetKeyDown(KeyCode.Escape)&& (Application.loadedLevelName)=="Eleven")
			Application.LoadLevel(7);
		else if(Input.GetKeyDown(KeyCode.Escape)&& (Application.loadedLevelName)=="Twelve")
			Application.LoadLevel(1);
		else if(Input.GetKeyDown(KeyCode.Escape)&& (Application.loadedLevelName)=="Thirteen")
			Application.LoadLevel(11);
		else if(Input.GetKeyDown(KeyCode.Escape)&& (Application.loadedLevelName)=="Forteen")
			Application.LoadLevel(11);
		else if(Input.GetKeyDown(KeyCode.Escape)&& (Application.loadedLevelName)=="Fifteen")
			Application.LoadLevel(11);
		else if(Input.GetKeyDown(KeyCode.Escape)&& (Application.loadedLevelName)=="Sixteen")
			Application.LoadLevel(11);
		else if(Input.GetKeyDown(KeyCode.Escape)&& (Application.loadedLevelName)=="Seventeen")
			Application.LoadLevel(1);
		else if(Input.GetKeyDown(KeyCode.Escape)&& (Application.loadedLevelName)=="Eighteen")
			Application.LoadLevel(16);
		else if(Input.GetKeyDown(KeyCode.Escape)&& (Application.loadedLevelName)=="Nineteen")
			Application.LoadLevel(16);
		else if(Input.GetKeyDown(KeyCode.Escape)&& (Application.loadedLevelName)=="Twenty")
			Application.LoadLevel(16);
		else if(Input.GetKeyDown(KeyCode.Escape)&& (Application.loadedLevelName)=="Twentyone")
			Application.LoadLevel(16);
		else if(Input.GetKeyDown(KeyCode.Escape)&& (Application.loadedLevelName)=="Twentytwo")
			Application.LoadLevel(0);

		else if(Input.GetKeyDown(KeyCode.Escape)&& (Application.loadedLevelName)=="First") 
			Application.Quit();

	}
}
