#if UNITY_EDITOR

using UnityEditor;
using UnityEngine;

public class JTouchEditor : EditorWindow
{
    private const string jTouchName = "JTouch";

    [MenuItem("JLibrary/JTouch")]
    public static void Touch()
    {
        if (FindJTouch == null)
            CreateJTouch();
    }

    private static GameObject FindJTouch { get { return GameObject.Find(jTouchName); } }
    private static void CreateJTouch() => new GameObject(jTouchName).AddComponent<JLibrary.Touch.JController>();
}
#endif