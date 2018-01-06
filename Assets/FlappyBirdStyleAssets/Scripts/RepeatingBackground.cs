using UnityEngine;
using System.Collections;

public class RepeatingBackground : MonoBehaviour {

	private BoxCollider2D grassCollider;
	private float groundHorizontalLength;

	// Use this for initialization
	void Start () 
	{
		grassCollider = GetComponent<BoxCollider2D> ();
		groundHorizontalLength = grassCollider.size.x; 
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (transform.position.x < -groundHorizontalLength)
			repositionBackground ();
	}

	void repositionBackground()
	{
		Vector2 groundOffset = new Vector2 (groundHorizontalLength * 2f, 0);
		transform.position = (Vector2)transform.position + groundOffset;
	}
}
