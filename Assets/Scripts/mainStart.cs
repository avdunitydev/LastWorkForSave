using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mainStart : MonoBehaviour
{
	public Transform unit;
	public Vector3 moveGO;
	public Vector3 startPositionGO;

	float timerTmp;

	// Use this for initialization
	void Start ()
	{
		startPositionGO = transform.position;
		timerTmp = 0;
	}
	
	// Update is called once per frame
	void Update ()
	{
		transform.position += moveGO;
		timerTmp += Time.deltaTime;

		if (timerTmp > 3) {
			timerTmp = 0;
			transform.position = startPositionGO;
			Transform GO = Instantiate (unit, 
				               new Vector3 (
					               Random.Range (-3f, 4), 
					               Random.Range (-4f, 3), 
					               0), 
				               Quaternion.identity, transform);
		}
	}
}
