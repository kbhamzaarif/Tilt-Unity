using UnityEngine;
using System.Collections;

public class Helpers {

	public static Vector2 GetScreenSize()
	{
		return Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Mathf.Abs(Camera.main.transform.position.z)));
	
	}
}
