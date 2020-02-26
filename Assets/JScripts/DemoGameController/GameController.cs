using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using JLibrary.Touch;
using System;

public class GameController : MonoBehaviour
{
    void Start()
    {
        JTouch.TouchDown += TouchDown;
        JTouch.TouchSet += TouchSet;
        JTouch.TouchUp += TouchUp;

        JTouchWithRaycast.TouchDown += TouchDownWithRaycast;
        JTouchWithRaycast.TouchSet += TouchSetWithRaycast;
        JTouchWithRaycast.TouchUp += TouchUpWithRaycast;
    }

    private void TouchUpWithRaycast(JTouchWithRaycastInfo obj)
    {
        Debug.Log($"TouchUp First Pos{obj.FirstPosition}");
        Debug.Log($"TouchUp Set Pos{obj.SetPosition}");
        Debug.Log($"TouchUp Last Pos{obj.LastPosition}");
        Debug.Log($"TouchUp Hit Name{obj.HitName}");
        Debug.Log($"TouchUp Hit Tag{obj.HitTag}");
        Debug.Log($"TouchUp Hit Point{obj.HitPoint}");
    }

    private void TouchSetWithRaycast(JTouchWithRaycastInfo obj)
    {
        Debug.Log($"TouchSet First Pos{obj.FirstPosition}");
        Debug.Log($"TouchSet Set Pos{obj.SetPosition}");
        Debug.Log($"TouchSet Last Pos{obj.LastPosition}");
        Debug.Log($"TouchSet Hit Name{obj.HitName}");
        Debug.Log($"TouchSet Hit Tag{obj.HitTag}");
        Debug.Log($"TouchSet Hit Point{obj.HitPoint}");
    }

    private void TouchDownWithRaycast(JTouchWithRaycastInfo obj)
    {
        Debug.Log($"TouchDown First Pos{obj.FirstPosition}");
        Debug.Log($"TouchDown Set Pos{obj.SetPosition}");
        Debug.Log($"TouchDown Last Pos{obj.LastPosition}");
        Debug.Log($"TouchDown Hit Name{obj.HitName}");
        Debug.Log($"TouchDown Hit Tag{obj.HitTag}");
        Debug.Log($"TouchDown Hit Point{obj.HitPoint}");
    }

    private void TouchUp(JTouchInfo obj)
    {
        Debug.Log($"TouchUp First Pos{obj.FirstPosition}");
        Debug.Log($"TouchUp Set Pos{obj.SetPosition}");
        Debug.Log($"TouchUp Last Pos{obj.LastPosition}");
    }

    private void TouchSet(JTouchInfo obj)
    {
        Debug.Log($"TouchSet First Pos{obj.FirstPosition}");
        Debug.Log($"TouchSet Set Pos{obj.SetPosition}");
        Debug.Log($"TouchSet Last Pos{obj.LastPosition}");
    }

    private void TouchDown(JTouchInfo obj)
    {
        Debug.Log($"TouchDown First Pos{obj.FirstPosition}");
        Debug.Log($"TouchDown Set Pos{obj.SetPosition}");
        Debug.Log($"TouchDown Last Pos{obj.LastPosition}");
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            JTouch.DeleteAction();
        }
    }
}
