using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace JLibrary.Touch
{
    public class JTouchWithRaycast : IJTouchCommand
    {
        private JTouchWithRaycastInfo _touchWithRaycastInfo;
        private Camera _camera = null;

        private LayerMask _layerMask;
        private const float _maxDistance = 3000;

        public static Action<JTouchWithRaycastInfo> TouchDown;
        public static Action<JTouchWithRaycastInfo> TouchSet;
        public static Action<JTouchWithRaycastInfo> TouchUp;

        public JTouchWithRaycast(LayerMask layerMask)
        {
            _layerMask = layerMask;
            _touchWithRaycastInfo = new JTouchWithRaycastInfo();
            FindCamera();
        }
        private void FindCamera() => _camera = JController.Camera == null ? Camera.main : JController.Camera;
        public void Execute()
        {
            if (Input.GetMouseButtonDown(0))
            {
                _touchWithRaycastInfo.FirstPosition = Input.mousePosition;
                AddHit(Raycast());
                TouchDown?.Invoke(_touchWithRaycastInfo);
            }
            else if (Input.GetMouseButton(0))
            {
                _touchWithRaycastInfo.SetPosition = Input.mousePosition;
                AddHit(Raycast());
                TouchDown?.Invoke(_touchWithRaycastInfo);
            }
            else if (Input.GetMouseButtonUp(0))
            {
                _touchWithRaycastInfo.LastPosition = Input.mousePosition;
                AddHit(Raycast());
                TouchDown?.Invoke(_touchWithRaycastInfo);
            }
        }
        private RaycastHit Raycast()
        {
            Ray ray = _camera.ScreenPointToRay(Input.mousePosition);
            Physics.Raycast(ray, out RaycastHit raycast, _maxDistance, _layerMask);
            Debug.DrawLine(ray.origin, raycast.point,Color.red);
            return raycast;
        }
        private void AddHit(RaycastHit raycastHit)
        {
            if (raycastHit.collider != null)
            {
                _touchWithRaycastInfo.HitName = raycastHit.collider.name;
                _touchWithRaycastInfo.HitTag = raycastHit.collider.tag;
                _touchWithRaycastInfo.HitPoint = raycastHit.point;
            }
            else
            {
                _touchWithRaycastInfo.HitName = string.Empty;
                _touchWithRaycastInfo.HitTag = string.Empty;
                _touchWithRaycastInfo.HitPoint = Vector3.zero;
            }
        }
    }
}