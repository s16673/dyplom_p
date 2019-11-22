using UnityEngine;
using System.Collections;


public class CameraFollow : MonoBehaviour {

    public float shift;

	private Vector3 velocity;

	public float smoothTimeY;
	public float smoothTimeX;
    public float smoothTimeZ;

	public GameObject player;

	public bool bounds;

	public Vector3 minCameraPos;
	public Vector3 maxCameraPos;

	void Start () 
	{
		player = GameObject.FindGameObjectWithTag("Player");
	}
	

	void FixedUpdate () 
	{
		//Camera foloows the player
		float posX = Mathf.SmoothDamp (transform.position.x, player.transform.position.x+shift, ref velocity.x, smoothTimeX);
		float posY = Mathf.SmoothDamp (transform.position.y, player.transform.position.y+shift, ref velocity.y, smoothTimeY);
        float posZ = Mathf.SmoothDamp(transform.position.z, player.transform.position.z+shift, ref velocity.z, smoothTimeZ);

		transform.position = new Vector3 (posX, posY, posZ);

		//reduce camera movement range
		if (bounds) 
		{
			transform.position = new Vector3(Mathf.Clamp(transform.position.x, minCameraPos.x, maxCameraPos.x),
				Mathf.Clamp(transform.position.y, minCameraPos.y, maxCameraPos.y),
				Mathf.Clamp(transform.position.z, minCameraPos.z, maxCameraPos.z));

		
		}
	
	}

	public void SetMinCamPosition()
	{
		minCameraPos = gameObject.transform.position;
	}


	public void SetMaxCamPosition()
	{
		maxCameraPos = gameObject.transform.position;
	}




}
