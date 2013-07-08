using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class MovingObject : MonoBehaviour 
{
	public List<GameObject> way;
	public float movingSpeed = 3;
	
	private Transform myTransform;
	private float rotationSpeed = 3;
	private int index = 0;
	
	int ComparePoints(GameObject x, GameObject y)
	{
		int xInt = x.GetComponent<WayPoint>().number;
		int yInt = y.GetComponent<WayPoint>().number;
		
		return xInt.CompareTo(yInt);
	}
	
	void Awake()
	{
		myTransform = transform;
	}
	
	void Start () 
	{
		way = new List<GameObject>(GameObject.FindGameObjectsWithTag("way"));
		way.Sort(ComparePoints);
	}
	
	protected void Update () 
	{
		myTransform.rotation = Quaternion.Slerp(myTransform.rotation, Quaternion.LookRotation(way[index].transform.position - myTransform.position),
			rotationSpeed * Time.deltaTime);
		myTransform.position += myTransform.forward * movingSpeed * Time.deltaTime;	
	}
	
	void OnTriggerEnter(Collider other)
	{
		if(other.gameObject.Equals(way[index]))
		{
			index++;
		}
		if(index >= way.Count)
		{
			Destroy(gameObject);
		}
	}
}
