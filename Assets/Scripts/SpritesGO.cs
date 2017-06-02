using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpritesGO : MonoBehaviour
{
	[SerializeField]
	private Sprite[] spriteArrayGO;
	float timerTemp;
	float timerLife;
	SpriteRenderer sprr;

	// Use this for initialization
	void Start ()
	{
		timerTemp = 0;
		timerLife = 0;
		sprr = GetComponent<SpriteRenderer> ();
		insertCowboy ();

	}
	
	// Update is called once per frame
	void Update ()
	{
		timerTemp += Time.deltaTime;
		if (timerTemp > 3) {
			timerTemp = 0;
			timerLife += Time.deltaTime;
			insertCowboy ();
		}
	}

	void insertCowboy ()
	{
		sprr.sprite = spriteArrayGO [Random.Range (0, spriteArrayGO.Length)];

	}

	void OnMouseDown ()
	{
		Destroy (gameObject);
	}

	void OnMouseEnter ()
	{
		sprr.color = new Color (1, 1, 1, 0.2f);
	}

	void OnMouseExit ()
	{
		sprr.color = new Color (1, 1, 1, 1f);

	}
}
