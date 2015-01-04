using UnityEngine;
using System.Collections;

    public delegate void CallBackDelegate();

    public delegate void Callback();
    public delegate void Callback<T>(T arg);
    public delegate void CallbackWithParam(params object[] args);

    public delegate void VoidDelegate(GameObject go);
    public delegate void BoolDelegate(GameObject go, bool state);
    public delegate void FloatDelegate(GameObject go, float delta);
    public delegate void VectorDelegate(GameObject go, Vector2 delta);
    public delegate void StringDelegate(GameObject go, string text);
    public delegate void ObjectDelegate(GameObject go, GameObject draggedObject);
    public delegate void KeyCodeDelegate(GameObject go, KeyCode key);
