using UnityEngine;
using System.Collections;

public class Pinchzoom : TouchLogic
{
	public float zoomSpeed = 5.0f;

	private Vector2 currTouch1 = Vector2.zero,
	lastTouch1 = Vector2.zero,
	currTouch2 = Vector2.zero,
	lastTouch2 = Vector2.zero;

	private float currDist = 0.0f,
	lastDist = 0.0f,
	zoomFactor = 0.0f;
	public override void OnTouchMovedAnywhere()
	{//executed  after any movement 
		Zoom();
	}
	public override void OnTouchStayedAnywhere()
	{//execute when movement stop
		Zoom();
	}
	void Zoom()
	{

		switch(TouchLogic.currTouch)
		{
		case 0://first touch
			currTouch1 = Input.GetTouch(0).position;
			lastTouch1 = currTouch1 - Input.GetTouch(0).deltaPosition;
			break;
		case 1://second touch
			currTouch2 = Input.GetTouch(1).position;
			lastTouch2 = currTouch2 - Input.GetTouch(1).deltaPosition;
			break;
		}
		//finds the distance between your moved touches

		if(TouchLogic.currTouch >= 1)
		{
			currDist = Vector2.Distance(currTouch1, currTouch2);
			lastDist = Vector2.Distance(lastTouch1, lastTouch2);
		}
		else
		{
			currDist = 0.0f;
			lastDist = 0.0f;
		}
		//Calculate the zoom magnitude
		zoomFactor = Mathf.Clamp(lastDist - currDist, -30.0f, 30.0f);
		//apply zoom to our camera
		Camera.main.transform.Translate(Vector3.forward * zoomFactor * zoomSpeed * Time.deltaTime);
	}
}