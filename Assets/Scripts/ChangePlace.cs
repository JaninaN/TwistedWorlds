using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangePlace : MonoBehaviour {

    public CameraPos targetPlace;

	public void goTo()
    {
        GameObject camera = GameObject.Find("Main Camera");
        camera.GetComponent<CameraPositions>().changePosition(targetPlace);
    }
}
