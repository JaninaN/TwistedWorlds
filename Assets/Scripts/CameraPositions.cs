using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum CameraPos
{
    riddle,

    zero_zero,
    one_zero,
    two_zero,
    three_zero,
    four_zero,
    five_zero,

    zero_one,
    one_one,
    two_one,
    three_one,
    four_one,
    five_one,
}

public enum RiddleCameraPos
{
    riddle
}

public class CameraPositions : MonoBehaviour{

    private bool move = false;
    private Vector3 currentPosition;
    private Vector3 nextCameraPos;

    private static Vector3 POSITION_RIDDLE;
    // Positions set as Grid: (0,0) is in the top left corner, x goes right, y goes down
    // y = 0
    private static Vector3 POSITION_ZERO_ZERO;
    private static Vector3 POSITION_ONE_ZERO;
    private static Vector3 POSITION_TWO_ZERO;
    private static Vector3 POSITION_THREE_ZERO;
    private static Vector3 POSITION_FOUR_ZERO;
    private static Vector3 POSITION_FIVE_ZERO;
    //y = 1
    private static Vector3 POSITION_ZERO_ONE;
    private static Vector3 POSITION_ONE_ONE;
    private static Vector3 POSITION_TWO_ONE;
    private static Vector3 POSITION_THREE_ONE;
    private static Vector3 POSITION_FOUR_ONE;
    private static Vector3 POSITION_FIVE_ONE;

    private void Start()
    {
        currentPosition = POSITION_ZERO_ZERO;

        POSITION_RIDDLE = new Vector3(0.0f, 20.0f, -10.0f);

        POSITION_ZERO_ZERO = new Vector3(0.0f, 0.0f, -10.0f);
        POSITION_ONE_ZERO = new Vector3(20.0f, 0.0f, -10.0f);
        POSITION_TWO_ZERO = new Vector3(40.0f, 0.0f, -10.0f);
        POSITION_THREE_ZERO = new Vector3(60.0f, 0.0f, -10.0f);
        POSITION_FOUR_ZERO = new Vector3(80.0f, 0.0f, -10.0f);
        POSITION_FIVE_ZERO = new Vector3(100.0f, 0.0f, -10.0f);

        POSITION_ZERO_ONE = new Vector3(0.0f, -20.0f, -10.0f);
        POSITION_ONE_ONE = new Vector3(20.0f, -20.0f, -10.0f);
        POSITION_TWO_ONE = new Vector3(40.0f, -20.0f, -10.0f);
        POSITION_THREE_ONE = new Vector3(60.0f, -20.0f, -10.0f);
        POSITION_FOUR_ONE = new Vector3(80.0f, -20.0f, -10.0f);
        POSITION_FIVE_ONE = new Vector3(100.0f, -20.0f, -10.0f);
    }

    private void Update()
    {
        if (move)
        {
            Vector3 distance = new Vector3(nextCameraPos.x - currentPosition.x, nextCameraPos.y - currentPosition.y, 0f);
            float step = Time.deltaTime ;
            if( (distance.x > 0) || (distance.y > 0))
            {
                float x = transform.position.x + (distance.x * step);
                float y = transform.position.y + (distance.y * step);
                transform.position = new Vector3(x, y, transform.position.z);
                // check if final position is reached
                if (x >= nextCameraPos.x && y >= nextCameraPos.y)
                {
                    move = false;
                }
            }else if ((distance.x < 0) || (distance.y < 0))
            {
                float x = transform.position.x + (distance.x * step);
                float y = transform.position.y + (distance.y * step);
                transform.position = new Vector3(x, y, transform.position.z);
                // check if final position is reached
                if (x <= nextCameraPos.x && y <= nextCameraPos.y)
                {
                    move = false;
                }
            }else
            {
                // all values of distance are 0
                Debug.Log("Check Camera positions, there is no distance between them.");
                move = false;
            }
        }
    }

    public void changePosition(CameraPos pos)
    {
        switch (pos)
        {
            case CameraPos.zero_zero:
                nextCameraPos = POSITION_ZERO_ZERO;
                move = true;
                break;
            case CameraPos.one_zero:
                nextCameraPos = POSITION_ONE_ZERO;
                move = true;
                break;
            case CameraPos.two_zero:
                nextCameraPos = POSITION_TWO_ZERO;
                move = true;
                break;
            case CameraPos.three_zero:
                nextCameraPos = POSITION_THREE_ZERO;
                move = true;
                break;
            case CameraPos.four_zero:
                nextCameraPos = POSITION_FOUR_ZERO;
                move = true;
                break;
            case CameraPos.five_zero:
                nextCameraPos = POSITION_FIVE_ZERO;
                move = true;
                break;
            case CameraPos.zero_one:
                nextCameraPos = POSITION_ZERO_ONE;
                move = true;
                break;
            case CameraPos.one_one:
                nextCameraPos = POSITION_ONE_ONE;
                move = true;
                break;
            case CameraPos.two_one:
                nextCameraPos = POSITION_TWO_ONE;
                move = true;
                break;
            case CameraPos.three_one:
                nextCameraPos = POSITION_THREE_ONE;
                move = true;
                break;
            case CameraPos.four_one:
                nextCameraPos = POSITION_FOUR_ONE;
                move = true;
                break;
            case CameraPos.five_one:
                nextCameraPos = POSITION_FIVE_ONE;
                move = true;
                break;
        }
    }

    public void goToRiddle(RiddleCameraPos pos)
    {
        switch (pos)
        {
            case RiddleCameraPos.riddle:
                transform.position = POSITION_RIDDLE;
                break;
        }
    }

    public void returnFromRiddle()
    {
        transform.position = currentPosition;
    }
}
