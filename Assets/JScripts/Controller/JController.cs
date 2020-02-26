
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace JLibrary.Touch
{
    public class JController : MonoBehaviour
    {
        public TouchController _touchController = TouchController.Touch;

        public Camera MainCamera;
        public static Camera Camera;

        [SerializeField] private LayerMask _layerWithRaycast;

        private List<IJTouchCommand> _jTouchList = new List<IJTouchCommand>();

        private void Awake()
        {
            Camera = MainCamera;
        }
        private void Start()
        {
            AddExecute();
        }

        private void AddExecute()
        {
            IJTouchCommand jtouch = new JTouch();
            _jTouchList.Add(jtouch);
            IJTouchCommand jTouchWithRaycast = new JTouchWithRaycast(_layerWithRaycast);
            _jTouchList.Add(jTouchWithRaycast);
        }
        private void Update()
        {
            switch (_touchController)
            {
                case TouchController.Touch:
                    _jTouchList[(int)TouchController.Touch].Execute();
                    break;
                case TouchController.TouchWithRaycast:
                    _jTouchList[(int)TouchController.TouchWithRaycast].Execute();
                    break;
                default:
                    break;
            }
        }

    }
}