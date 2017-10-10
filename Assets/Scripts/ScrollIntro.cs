using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Timers;
using UnityEngine.UI;

public class ScrollIntro : MonoBehaviour {

    public float speed;

    private bool move = true;
    Vector3 startPosition;
    
    IEnumerator LoadLevel()
    {
        yield return new WaitForSeconds(20F);
        //GameObject.Find("Story").SetActive(false);
        move = false;

        GameObject panel = GameObject.Find("IntroPanel");
        panel.GetComponent<Image>().enabled = true;

        GameObject camera = GameObject.Find("Camera");
        camera.GetComponent<Camera>().enabled = false;

        

    }
    private void Start()
    {
        startPosition = transform.position;
        StartCoroutine(LoadLevel());
    }

    void Update()
    {
        if (move)
        {
             Vector3 position = transform.position;

             Vector3 localVectorUp = transform.TransformDirection(0, 1, 0);

             position += localVectorUp * speed * Time.deltaTime;
             transform.position = position;
        }

        
    }
    
    public void repeatIntro()
    {
        transform.position = startPosition;
        GameObject camera = GameObject.Find("Camera");
        camera.GetComponent<Camera>().enabled = true;
        move = true;
        StartCoroutine(LoadLevel());
    }

    public void exitIntro()
    {
        //Destroy Camera, IntroPanel and Story after use
        GameObject camera = GameObject.Find("Camera");
        GameObject panel = GameObject.Find("IntroPanel");
        Destroy(camera);
        Destroy(panel);

        GameObject.Find("DataStorage").GetComponent<Storyflow>().talkTo(Character.Fox_Child);

        Destroy(gameObject);
    }

    
}
