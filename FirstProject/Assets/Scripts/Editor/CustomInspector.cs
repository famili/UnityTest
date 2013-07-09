using UnityEngine;
using UnityEditor;
using System.Collections;

[CustomEditor(typeof(PointCreater))]
public class CustomInspector : Editor 
{
	string x = "0";
	string y = "0";
	string z = "0";
	string number = "0";
	
	
	
	public override void OnInspectorGUI ()
	{
		base.OnInspectorGUI ();
		PointCreater myTarget = (PointCreater)target;
		
		GUILayout.BeginHorizontal();
		GUILayout.Label("number");
		number = GUILayout.TextField(number, 10);
		GUILayout.EndVertical();

		GUILayout.BeginHorizontal();
		GUILayout.Label("x");
		x = GUILayout.TextField(x, 10);
		GUILayout.EndVertical();
		
		GUILayout.Space(2);
		GUILayout.BeginHorizontal();
		GUILayout.Label("y");
		y = GUILayout.TextField(y, 10);
		GUILayout.EndVertical();
		
		GUILayout.Space(2);
		GUILayout.BeginHorizontal();
		GUILayout.Label("z");
		z = GUILayout.TextField(z, 10);
		GUILayout.EndVertical();
		
		GUILayout.Space(2);
		
		if (GUILayout.Button("Add point"))
		{
			Instantiate(myTarget.prefab_WayPoint, new Vector3(int.Parse(x), int.Parse(y), int.Parse(z)), Quaternion.identity);
		}
	}
}
