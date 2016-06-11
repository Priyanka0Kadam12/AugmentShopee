
using UnityEngine;
using System.Collections;

public class TouchLogic : MonoBehaviour
{
	public static int currTouch = 0;
	void Update()
	{
		if (Input.touches.Length <= 0)
		{ //if no touches
			OnNoTouches();
		}
		else 
		{
			for (int i = 0; i < Input.touchCount; i++)
			{// for every touch
				currTouch = i;
				Debug.Log(currTouch);
				if (this.GetComponent<GUITexture>() != null && (this.GetComponent<GUITexture>().HitTest(Input.GetTouch(i).position)))
				{// touch on object
					if (Input.GetTouch(i).phase == TouchPhase.Began)
					{
						this.SendMessage("OnTouchBegan");
					}
					if (Input.GetTouch(i).phase == TouchPhase.Ended)
					{
						this.SendMessage("OnTouchEnded");
					}
					if (Input.GetTouch(i).phase == TouchPhase.Moved)
					{
						this.SendMessage("OnTouchMoved");
					}
					if (Input.GetTouch(i).phase == TouchPhase.Stationary)
					{
						this.SendMessage("OnTouchStayed");
					}
				}//touch anyware on screen
				if (Input.GetTouch(i).phase == TouchPhase.Began)
				{
					this.SendMessage("OnTouchBeganAnywhere");
				}
				if (Input.GetTouch(i).phase == TouchPhase.Ended)
				{
					this.SendMessage("OnTouchEndedAnywhere");
				}
				if (Input.GetTouch(i).phase == TouchPhase.Moved)
				{
					this.SendMessage("OnTouchMovedAnywhere");
				}
				if (Input.GetTouch(i).phase == TouchPhase.Stationary)
				{
					this.SendMessage("OnTouchStayedAnywhere");
				}
			}
		}
	}
	//the default functions, define what will happen if the child doesn't override these functions
	public virtual void OnNoTouches() { }
	public virtual void OnTouchBegan() { print(name + " is not using OnTouchBegan"); }
	public virtual void OnTouchEnded() { }
	public virtual void OnTouchMoved() { }
	public virtual void OnTouchStayed() { }
	public virtual void OnTouchBeganAnywhere() { }
	public virtual void OnTouchEndedAnywhere() { }
	public virtual void OnTouchMovedAnywhere() { }
	public virtual void OnTouchStayedAnywhere() { }
}

