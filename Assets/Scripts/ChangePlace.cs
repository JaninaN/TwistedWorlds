using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangePlace : MonoBehaviour {

    public CameraPos targetPlace;
    public RiddleCameraPos targetRiddle;
    public CameraPos afterRiddle;

    public void goTo()
    {
        GameObject camera = GameObject.Find("Main Camera");
        if(targetPlace == CameraPos.riddle)
        {
            camera.GetComponent<CameraPositions>().goToRiddle(targetRiddle);
            targetPlace = afterRiddle;
        }
        else
        {
            camera.GetComponent<CameraPositions>().changePosition(targetPlace);
        }
        
    }
}
