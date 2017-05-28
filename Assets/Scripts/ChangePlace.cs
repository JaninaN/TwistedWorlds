using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangePlace : MonoBehaviour {

    public CameraPos targetPlace;

	public void goTo()
    {
        GameObject.Find("Main Camera").GetComponent<CameraPositions>().changePosition(targetPlace);
    }
}
