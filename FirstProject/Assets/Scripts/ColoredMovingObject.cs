using UnityEngine;
using System.Collections;

public class ColoredMovingObject : MovingObject 
{
	private float colorChangeSpeed = 0.2f;

	float T(float time)
	{
		float t = Mathf.Abs(Mathf.Sin(time * colorChangeSpeed * Mathf.PI));	
		return t;
	}
	
	new void Update()
	{
		base.Update();
		MeshRenderer gameObjectRenderer = gameObject.GetComponent<MeshRenderer>();		
		gameObjectRenderer.material.color = Color.Lerp(Color.red, Color.blue, T(Time.time));
		gameObject.GetComponentsInChildren<MeshRenderer>()[1].material.color = gameObjectRenderer.material.color;
	}
}
