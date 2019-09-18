using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpawnBall : MonoBehaviour {

	[SerializeField]
	GameObject ball;
	public GameObject instantiate;
	public Text ballCount;
	int cnt;

	void Start()
	{
		ballCount.text = "-";
		cnt = 6;
	}

	public void Spawn()
	{
		Debug.Log("spawn ball");
		Instantiate (ball, instantiate.transform.position, Quaternion.identity, this.transform);
		cnt = cnt - 1;
		ballCount.text = cnt.ToString();
	}
}
