using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Timers;


public class ScrollIntro : MonoBehaviour {

    public float speed;
    /*
    public float speed;


         // Update is called once per frame
         void Update () {
             Vector3 position = transform.position;

             Vector3 localVectorUp = transform.TransformDirection(0, 1, 0);

             position += localVectorUp * speed * Time.deltaTime;
             transform.position = position;

    }
    */

   IEnumerator LoadLevel()
    {
        yield return new WaitForSeconds(20F);
        GameObject.Find("Story").SetActive(false);
        GameObject maincamera = GameObject.Find("Main Camera");
            
        maincamera.GetComponent<CameraPositions>().changePosition(CameraPos.one_zero);

        GameObject camera = GameObject.Find("Camera");
        //camera.GetComponent<Camera>().depth = -2;
        camera.GetComponent<Camera>().enabled = false;

    }
    void Update()
    {

        Vector3 position = transform.position;

        Vector3 localVectorUp = transform.TransformDirection(0, 1, 0);

        position += localVectorUp * speed * Time.deltaTime;
        transform.position = position;
        StartCoroutine(LoadLevel());
            

        

    }
        

    
}
