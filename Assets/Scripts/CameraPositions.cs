using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum CameraPos
{
    riddle,
    zero,
    one,
    two,
    three,
    four,
    five
}

public class CameraPositions : MonoBehaviour{

    private static Vector3 POSITION_RIDDLE;
    private static Vector3 POSITION_ZERO;
    private static Vector3 POSITION_ONE;
    private static Vector3 POSITION_TWO;
    private static Vector3 POSITION_THREE;
    private static Vector3 POSITION_FOUR;
    private static Vector3 POSITION_FIVE;

    private void Start()
    {
        POSITION_RIDDLE = new Vector3(0.0f, 20.0f, -10.0f);
        POSITION_ZERO = new Vector3(0.0f, 0.0f, -10.0f);
        POSITION_ONE = new Vector3(20.0f, 0.0f, -10.0f);
        POSITION_TWO = new Vector3(40.0f, 0.0f, -10.0f);
        POSITION_THREE = new Vector3(60.0f, 0.0f, -10.0f);
        POSITION_FOUR = new Vector3(80.0f, 0.0f, -10.0f);
        POSITION_FIVE = new Vector3(100.0f, 0.0f, -10.0f);
    }

    public void changePosition(CameraPos pos)
    {
        switch (pos)
        {
            case CameraPos.zero:
                transform.position = POSITION_ZERO;
                break;
            case CameraPos.one:
                transform.position = POSITION_ONE;
                break;
            case CameraPos.two:
                transform.position = POSITION_TWO;
                break;
            case CameraPos.three:
                transform.position = POSITION_THREE;
                break;
            case CameraPos.four:
                transform.position = POSITION_FOUR;
                break;
            case CameraPos.five:
                transform.position = POSITION_FIVE;
                break;
        }
    }
}
