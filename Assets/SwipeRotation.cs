using UnityEngine;
using System.Collections;

public class SwipeRotation : TouchLogic
{
	public float rotateSpeed = 100.0f;
	public int invertPitch = 1;
	private float pitch=0.0f,yaw=0.0f;

	public  void OnTouchMovedAnywhere()
	{//on every motion this code is executed
		pitch -= Input.GetTouch(0).deltaPosition.y * rotateSpeed * invertPitch * Time.deltaTime;
		yaw += Input.GetTouch(0).deltaPosition.x * rotateSpeed * invertPitch * Time.deltaTime;
		pitch = Mathf.Clamp(pitch, -80, 80);
		this.transform.eulerAngles = new Vector3(pitch, yaw, 0.0f);
	}
}
