using UnityEngine;
using System.Collections;

public class TiltController : MonoBehaviour {

	private Vector3 currentDir;
	private float currentMultiplier;
	private new SpriteRenderer renderer;
	private Vector2 ScreenSize;


	float width;
	float height;

	public float speed;


	// Use this for initialization
	void Start () {
		Vector2 screenBounds = Helpers.GetScreenSize();
		ScreenSize = new Vector2(screenBounds.x, screenBounds.y);

		renderer = this.gameObject.GetComponentInChildren<SpriteRenderer>();

		width = renderer.bounds.size.x / 2;
		height = renderer.bounds.size.y / 2;
	}
	public void moveTo(Vector2 direction)
	{

		currentDir = direction;

	}
	// Update is called once per frame
	void Update () {
		if(this.transform.position.x < -this.ScreenSize.x +width   || this.transform.position.x > this.ScreenSize.x-width)
		{
			Vector2 cP = this.transform.position;
			if(this.transform.position.x < -this.ScreenSize.x + width)
			{
				cP.x = -this.ScreenSize.x +width + 0.00001f ;
			}
			else
			{
				cP.x = this.ScreenSize.x - width -0.00001f;
			}

			this.transform.position = cP;
			currentDir.x = 0;
		}
		if (this.transform.position.y < -this.ScreenSize.y + height || this.transform.position.y > this.ScreenSize.y - height)
		{

			Vector2 cP = this.transform.position;
			if (this.transform.position.y < -this.ScreenSize.y + height)
			{
				cP.y = -this.ScreenSize.y + height + 0.00001f;
			}
			else
			{
				cP.y = this.ScreenSize.y - height -0.00001f;
			}
			this.transform.position = cP;
			currentDir.y = 0;
		}

//		Vector3 dest = this.transform.position + currentDir;
//		dest.z = this.transform.position.z;
//
//		this.transform.position = Vector3.Lerp(this.transform.position, dest, Time.deltaTime*this.speed);
		transform.Translate (Input.acceleration.x,-Input.acceleration.y,0);
	}
}
