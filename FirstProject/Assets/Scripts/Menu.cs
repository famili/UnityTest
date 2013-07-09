using UnityEngine;
using System.Collections;

public class Menu : MonoBehaviour 
{
	
	bool isPause = false;
	public GameObject prefab_MovingObject;
	public GameObject prefab_ColoredMovingObject;
	
	void Start () 
	{
		
	}
	
	void Update () 
	{
	
	}
	
	void OnGUI()
	{
		if (GUILayout.Button("Pause"))
		{
			if(!isPause)
			{
				isPause = true;
				Time.timeScale = 0;
			}
		}
		
		if (GUILayout.Button("Start"))
		{
			if(isPause)
			{
				isPause = false;
				Time.timeScale = 1;
			}
		}
		
		if (GUILayout.Button("Add Moving Object"))
		{
			Instantiate(prefab_MovingObject);
		}
		
		if (GUILayout.Button("Add Colored Moving Object"))
		{
			Instantiate(prefab_ColoredMovingObject);
		}
		
		if (GUILayout.Button("Delete all objects"))
		{
			GameObject[] movingObjects = GameObject.FindGameObjectsWithTag("moving");
			foreach(GameObject moving in movingObjects)
			{
				Destroy(moving);
			}
		}
	}
}
