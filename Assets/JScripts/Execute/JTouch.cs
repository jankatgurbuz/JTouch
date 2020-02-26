using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace JLibrary.Touch
{
    public class JTouch : IJTouchCommand
    {
        private JTouchInfo _touchInfo;
        public static Action<JTouchInfo> TouchDown;
        public static Action<JTouchInfo> TouchSet;
        public static Action<JTouchInfo> TouchUp;
        public JTouch() 
        {
            _touchInfo = new JTouchInfo();
        }
        public void Execute()
        {
            if (Input.GetMouseButtonDown(0))
            {
                _touchInfo.FirstPosition = Input.mousePosition;
                TouchDown?.Invoke(_touchInfo);
            }
            else if (Input.GetMouseButton(0))
            {
                _touchInfo.SetPosition = Input.mousePosition;
                TouchSet?.Invoke(_touchInfo);
            }
            else if (Input.GetMouseButtonUp(0))
            {
                _touchInfo.LastPosition = Input.mousePosition;
                TouchUp?.Invoke(_touchInfo);
            }
        }
        public static void DeleteAction()
        {
            TouchDown = null;
            TouchSet = null;
            TouchUp = null;
        }
    }
}