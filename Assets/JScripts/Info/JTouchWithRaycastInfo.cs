using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace JLibrary.Touch
{
    public class JTouchWithRaycastInfo
    {
        public Vector3 FirstPosition;
        public Vector3 LastPosition;
        public Vector3 SetPosition;
        public RaycastHit RaycastHit;
        public string HitName;
        public string HitTag;
        public Vector3 HitPoint;
    }
}