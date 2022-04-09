using UnityEngine;
using System.Collections;

[AddComponentMenu("Playground/Movement/Move With Arrows")]
[RequireComponent(typeof(Rigidbody2D))]
public class Move : Physics2DObject
{
	[Header("Input keys")]
	public Enums.KeyGroups typeOfControl = Enums.KeyGroups.ArrowKeys;

	[Header("Movement")]
	[Tooltip("Speed of movement")]
	public float speed = 5f;
	public Enums.MovementType movementType = Enums.MovementType.AllDirections;

	[Header("Orientation")]
	public bool orientToDirection = false;
	// The direction that will face the player
	public Enums.Directions lookAxis = Enums.Directions.Up;

	private Vector2 movement, cachedDirection;
	private float moveHorizontal;
	private float moveVertical;


	// Update gets called every frame
	void Update ()
	{
		movement = new Vector2(Input.GetAxis("Horizontal"), 0);
		
		if(movement.sqrMagnitude >= 0.01f)
		{
			cachedDirection = movement;
		}
		Utils.SetAxisTowards(lookAxis, transform, cachedDirection);
	}

	// FixedUpdate is called every frame when the physics are calculated
	void FixedUpdate ()
	{
		// Apply the force to the Rigidbody2d
		rigidbody2D.AddForce(movement * speed * 10f);
	}
}