using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gameController : MonoBehaviour
{
    public Text messageText;
    public Text ballCount;
    public Button spawnBall;
    bool win = false;

    void Update()
    {
    	if (win) {
    		messageText.gameObject.SetActive(true);
    		messageText.text = "You Win! Go Bears!";
            spawnBall.interactable = false;
    	}
        int cnt = int.Parse(ballCount.text);	
        if (cnt == 0) {
            messageText.gameObject.SetActive(true);
            messageText.text = "You Lose";   
            spawnBall.interactable = false; 
        }
    }

    void OnCollisionEnter (Collision collision)
    {
    	if (collision.collider.tag == "bear") {
    		win = true;	
    		collision.collider.tag = "Untagged";	
    	}
    }
}
