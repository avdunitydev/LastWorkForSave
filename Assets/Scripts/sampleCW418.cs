/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxObj : MonoBehaviour
{
	[Tooltip("Рівень гравця")]
	[ContextMenuItem("Скинути", "levelReset")]
	public int level;
	//public GameObject gameObj;
	public Transform donkey;

	public Vector3 moveCube;
	float timer;
	Vector3 startPos;

	void levelReset()
	{
		level = 1;
		print("levelReset");
	}

	// Use this for initialization
	void Start()
	{
		timer = 0;
		startPos = transform.position;

	}


	// Update is called once per frame
	void Update()
	{
		transform.position += moveCube;

		timer += Time.deltaTime;
		if (timer > 3)
		{
			timer = 0;
			transform.position = startPos;
			Transform obj = Instantiate(donkey, new Vector3(Random.Range(-3f, 4), Random.Range(-4f, 3), 0), Quaternion.identity, transform);
			//obj.GetComponent<SpriteRenderer>().color = new Color(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f));
			//obj.parent = transform;
		}
	}
}


//--------------------------------

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteRandom : MonoBehaviour
{
	public Sprite[] arraySprites;
	float timer;
	float timeLife;
	SpriteRenderer spriteRen;

	// Use this for initialization
	void Start()
	{
		timer = 0;
		timeLife = 0;
		spriteRen = GetComponent<SpriteRenderer>();
		ChangePic();
	}

	// Update is called once per frame
	void Update()
	{
		timer += Time.deltaTime;
		timeLife += Time.deltaTime;
		if (timer > 3)
		{
			timer = 0;
			ChangePic();
		}
		if (timeLife > 10)
		{
			Destroy(gameObject);
		}

	}

	void ChangePic()
	{
		spriteRen.sprite = arraySprites [Random.Range(0, arraySprites.Length)];
	}

	void OnMouseDown()
	{
		Destroy(gameObject);
	}

	void OnMouseEnter()
	{
		spriteRen.color = new Color(1, 1, 1, 0.2f);
	}

	void OnMouseExit()
	{
		spriteRen.color = new Color(1, 1, 1, 1f);

	}
}
*/