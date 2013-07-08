using UnityEngine;
using System.Collections;

public class ColoredMovingObject : MovingObject 
{
	void Update()
	{
		base.Update();
		MeshRenderer gameObjectRenderer = gameObject.GetComponent<MeshRenderer>();
		gameObjectRenderer.material.color = Color.Lerp(Color.red, Color.blue, Time.time);
	}
}
