using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;

public class ARButtonManager : MonoBehaviour
{
    private Camera arCamera;
    private PlaceGameBoard placeGameBoard;
    private float touchTimeStart, touchTimeFinish, timeInterval;
    private Vector2 touchPositionStart, touchPositionEnd, direction;

    void Start()
    {
        // Here we will grab the camera from the AR Session Origin.
        // This camera acts like any other camera in Unity.
        arCamera = GetComponent<ARSessionOrigin>().camera;
        // We will also need the PlaceGameBoard script to know if
        // the game board exists or not.
        placeGameBoard = GetComponent<PlaceGameBoard>();
    }

    void Update()
    {
        // if (placeGameBoard.Placed() && Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
        // {
        //     touchPositionStart = Input.GetTouch(0).position;
        //     // Convert the 2d screen point into a ray.
        //     Ray ray = arCamera.ScreenPointToRay(touchPositionStart);
        //     // Check if this hits an object within 100m of the user.
        //     RaycastHit hit;
        //     if (Physics.Raycast(ray, out hit,100))
        //     {
        //         // Check that the object is interactable.
        //         if(hit.transform.tag=="Interactable") {
        //             touchTimeStart = Time.time;
        //         }
        //     }
        // }

        // if (placeGameBoard.Placed() && Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Ended) 
        // {
        //     Ray ray = arCamera.ScreenPointToRay(touchPositionStart);
        //     RaycastHit hit;
        //     if (Physics.Raycast(ray, out hit,100))
        //     {
        //         // Check that the object is interactable.
        //         if(hit.transform.tag=="Interactable") {
        //             // hit.transform.GetComponent<OnTouch3D>().OnTouch();
        //             touchTimeFinish = Time.time;
        //             timeInterval = touchTimeFinish - touchTimeStart;
        //             touchPositionEnd = Input.GetTouch(0).position;
        //             direction = touchPositionStart - touchPositionEnd;
        //             ball.transform.Translate(new Vector3(0, 0.01f, -0.01f));
        //         }
        //     }
            
        // }
    }
}
