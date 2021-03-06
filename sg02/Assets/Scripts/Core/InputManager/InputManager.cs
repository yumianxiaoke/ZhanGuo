﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;

using LuaInterface;

public class InputManager : Singleton<InputManager> 
{
    private bool enable = true;

    private Camera m_cameraScene;  //场景摄像机
    private Camera m_cameraUI;      //UI摄像机

    private float m_midMouseWheelSensitivity = 2f; //鼠标中间键
	
	private float m_multiTouchDistance; //两点触摸时两点间的X距离

	//鼠标按下的位置;
	private Vector3 m_mouseDownPosition;
    private Vector3 m_posBackup;
	private bool m_isMouseMove;
	private bool m_isMouseDown;
	private bool m_isCancelInput;
    private bool m_isUIObject;

    private Vector3 m_rayDirection; //Ray方向
    private GameObject m_objDragging;
    private GameObject m_objPress;

    /// <summary>
    /// 点击和拖动回调
    /// </summary>
    public delegate void OnClickDelegate(GameObject go);
    public delegate void OnPressDelegate(GameObject go, bool state);
    public delegate void OnToggleDelegate(GameObject go, bool value);
    public delegate void OnDragBeginDelegate(GameObject go);
    public delegate void OnDraggingDelegate(GameObject go, Vector3 delta);
    public delegate void OnDragEndDelegate(GameObject go);
    public delegate void OnMouseHitObjectDelegate(GameObject go);
    public delegate void OnMouseMoveDelegate(Vector3 delta);
    public delegate void OnMouseZoomDelegate(float delta);

    private Dictionary<GameObject, OnClickDelegate> m_dicOnClickDelegate;
    private Dictionary<GameObject, OnPressDelegate> m_dicOnPressDelegate;
    private Dictionary<GameObject, OnToggleDelegate> m_dicOnToggleDelegate;
    private Dictionary<GameObject, OnDragBeginDelegate> m_dicOnDragBeginDelegate;
    private Dictionary<GameObject, OnDraggingDelegate> m_dicOnDraggingDelegate;
    private Dictionary<GameObject, OnDragEndDelegate> m_dicOnDragEndDelegate;
    private List<OnMouseHitObjectDelegate> m_listOnMouseHitObject;
    private List<OnMouseMoveDelegate> m_listOnMouseMove;
    private List<OnMouseZoomDelegate> m_listOnMouseZoom;

    private Dictionary<GameObject, LuaFunction> m_dicOnClickDelegateLua;
    private Dictionary<GameObject, LuaFunction> m_dicOnPressDelegateLua;
    private Dictionary<GameObject, LuaFunction> m_dicOnToggleDelegateLua;
    private Dictionary<GameObject, LuaFunction> m_dicOnDragBeginDelegateLua;
    private Dictionary<GameObject, LuaFunction> m_dicOnDraggingDelegateLua;
    private Dictionary<GameObject, LuaFunction> m_dicOnDragEndDelegateLua;
    private List<LuaFunction> m_listOnMouseHitObjectLua;
    private List<LuaFunction> m_listOnMouseMoveLua;
    private List<LuaFunction> m_listOnMouseZoomLua;

    /// <summary>
    /// 初始化函数
    /// </summary>
    public override void Initialize()
    {
        m_objDragging = null;
        m_objPress = null;

        m_dicOnClickDelegate = new Dictionary<GameObject, OnClickDelegate>();
        m_dicOnPressDelegate = new Dictionary<GameObject, OnPressDelegate>();
        m_dicOnToggleDelegate = new Dictionary<GameObject, OnToggleDelegate>();

        m_dicOnDragBeginDelegate = new Dictionary<GameObject, OnDragBeginDelegate>();
        m_dicOnDragEndDelegate = new Dictionary<GameObject, OnDragEndDelegate>();
        m_dicOnDraggingDelegate = new Dictionary<GameObject, OnDraggingDelegate>();
        m_listOnMouseHitObject = new List<OnMouseHitObjectDelegate>();
        m_listOnMouseMove = new List<OnMouseMoveDelegate>();
        m_listOnMouseZoom = new List<OnMouseZoomDelegate>();

        m_dicOnClickDelegateLua = new Dictionary<GameObject, LuaFunction>();
        m_dicOnPressDelegateLua = new Dictionary<GameObject, LuaFunction>();
        m_dicOnToggleDelegateLua = new Dictionary<GameObject, LuaFunction>();
        m_dicOnDragBeginDelegateLua = new Dictionary<GameObject, LuaFunction>();
        m_dicOnDragEndDelegateLua = new Dictionary<GameObject, LuaFunction>();
        m_dicOnDraggingDelegateLua = new Dictionary<GameObject, LuaFunction>();
        m_listOnMouseHitObjectLua = new List<LuaFunction>();
        m_listOnMouseMoveLua = new List<LuaFunction>();
        m_listOnMouseZoomLua = new List<LuaFunction>();
    }

    /// <summary>
    /// 卸载函数
    /// </summary>
    public override void UnInitialize() 
    {
        m_objDragging = null;
        m_objPress = null;

        m_dicOnClickDelegate.Clear();
        m_dicOnPressDelegate.Clear();
        m_dicOnToggleDelegate.Clear();
        m_dicOnDragBeginDelegate.Clear();
        m_dicOnDragEndDelegate.Clear();
        m_dicOnDraggingDelegate.Clear();
        m_listOnMouseHitObject.Clear();
        m_listOnMouseMove.Clear();

        m_dicOnClickDelegateLua.Clear();
        m_dicOnPressDelegateLua.Clear();
        m_dicOnToggleDelegateLua.Clear();
        m_dicOnDragBeginDelegateLua.Clear();
        m_dicOnDragEndDelegateLua.Clear();
        m_dicOnDraggingDelegateLua.Clear();
        m_listOnMouseHitObjectLua.Clear();
        m_listOnMouseMoveLua.Clear();
    }

    public void SetEnable(bool enable)
    {
        this.enable = enable;
    }

    /// <summary>
    /// 设置场景摄像机
    /// </summary>
    public void SetSceneCamera(Camera camera)
    {
        m_cameraScene = camera;

        m_rayDirection = m_cameraScene.ScreenPointToRay(Vector3.zero).direction;
    }

    /// <summary>
    /// 设置UI摄像机
    /// </summary>
    public void SetCameraUI(Camera camera)
    {
        m_cameraUI = camera;
    }

    /// <summary>
    /// 添加点击事件
    /// </summary>
    /// <param name="go"></param>
    /// <param name="onClickFunc"></param>
    public void AddOnClickEvent(GameObject go, OnClickDelegate onClickFunc)
    {
        if (go == null)
            return;

        if (m_dicOnClickDelegate.ContainsKey(go))
        {
            m_dicOnClickDelegate[go] = onClickFunc;
        }
        else
        {
            m_dicOnClickDelegate.Add(go, onClickFunc);
        }
    }

    public void AddOnClickEvent(GameObject go, LuaFunction onClickFunc)
    {
        if (go == null)
            return;

        if (m_dicOnClickDelegateLua.ContainsKey(go))
        {
            m_dicOnClickDelegateLua[go] = onClickFunc;
        }
        else
        {
            m_dicOnClickDelegateLua.Add(go, onClickFunc);
        }
    }

    /// <summary>
    /// 删除点击事件
    /// </summary>
    /// <param name="go"></param>
    public void RemoveClickEvent(GameObject go)
    {
        if (go == null)
            return;

        if (m_dicOnClickDelegate.ContainsKey(go))
        {
            m_dicOnClickDelegate.Remove(go);
        }

        if (m_dicOnClickDelegateLua.ContainsKey(go))
        {
            m_dicOnClickDelegateLua.Remove(go);
        }
    }

    /// <summary>
    /// 触发点击事件
    /// </summary>
    public void OnClick(GameObject go)
    {
        if (m_dicOnClickDelegate.ContainsKey(go))
        {
            m_dicOnClickDelegate[go](go);
        }

        if (m_dicOnClickDelegateLua.ContainsKey(go))
        {
            m_dicOnClickDelegateLua[go].Call(go);
        }
    }

    /// <summary>
    /// 添加按下事件
    /// </summary>
    public void AddOnPressEvent(GameObject go, OnPressDelegate onPressFunc)
    {
        if (go == null)
            return;

        if (m_dicOnPressDelegate.ContainsKey(go))
        {
            m_dicOnPressDelegate[go] = onPressFunc;
        }
        else
        {
            m_dicOnPressDelegate.Add(go, onPressFunc);
        }
    }

    public void AddOnPressEvent(GameObject go, LuaFunction onPressFunc)
    {
        if (go == null)
            return;

        if (m_dicOnPressDelegateLua.ContainsKey(go))
        {
            m_dicOnPressDelegateLua[go] = onPressFunc;
        }
        else
        {
            m_dicOnPressDelegateLua.Add(go, onPressFunc);
        }
    }

    /// <summary>
    /// 移除按下事件
    /// </summary>
    public void RemoveOnPressEvent(GameObject go)
    {
        if (go == null)
            return;

        if (m_dicOnPressDelegate.ContainsKey(go))
        {
            m_dicOnPressDelegate.Remove(go);
        }

        if (m_dicOnPressDelegateLua.ContainsKey(go))
        {
            m_dicOnPressDelegateLua.Remove(go);
        }
    }

    /// <summary>
    /// 触发按下事件
    /// </summary>
    public void OnPress(GameObject go, bool state)
    {
        if (state == true)
        {
            m_isMouseDown = true;
            m_mouseDownPosition = Input.mousePosition;

            if (m_objDragging == null
                && (m_dicOnDraggingDelegate.ContainsKey(go)
                || m_dicOnDraggingDelegateLua.ContainsKey(go)))
            {
                m_objDragging = go;
            }
            if (m_objPress == null)
            {
                m_objPress = go;
                if (m_dicOnPressDelegate.ContainsKey(go))
                {
                    m_dicOnPressDelegate[go](go, true);
                }
                if (m_dicOnPressDelegateLua.ContainsKey(go))
                {
                    m_dicOnPressDelegateLua[go].Call(go, true);
                }
            }
        }
        else
        {
            if (m_objPress != null)
            {
                if (m_dicOnPressDelegate.ContainsKey(m_objPress))
                {
                    m_dicOnPressDelegate[m_objPress](m_objPress, false);
                }
                if (m_dicOnPressDelegateLua.ContainsKey(m_objPress))
                {
                    m_dicOnPressDelegateLua[m_objPress].Call(m_objPress, false);
                }
            }

            m_isMouseDown = false;
            m_objPress = null;
        }
    }

    /// <summary>
    /// 添加开关按钮事件
    /// </summary>
    public void AddOnToggleEvent(GameObject go, OnToggleDelegate ontToggleFunc)
    {
        if (go == null)
            return;

        if (m_dicOnToggleDelegate.ContainsKey(go))
        {
            m_dicOnToggleDelegate[go] = ontToggleFunc;
        }
        else
        {
            m_dicOnToggleDelegate.Add(go, ontToggleFunc);
        }
    }

    public void AddOnToggleEvent(GameObject go, LuaFunction onPressFunc)
    {
        if (go == null)
            return;

        if (m_dicOnToggleDelegateLua.ContainsKey(go))
        {
            m_dicOnToggleDelegateLua[go] = onPressFunc;
        }
        else
        {
            m_dicOnToggleDelegateLua.Add(go, onPressFunc);
        }
    }

    /// <summary>
    /// 移除按下事件
    /// </summary>
    public void RemoveOnToggleEvent(GameObject go)
    {
        if (go == null)
            return;

        if (m_dicOnToggleDelegate.ContainsKey(go))
        {
            m_dicOnToggleDelegate.Remove(go);
        }

        if (m_dicOnToggleDelegateLua.ContainsKey(go))
        {
            m_dicOnToggleDelegateLua.Remove(go);
        }
    }

    /// <summary>
    /// 触发按下事件
    /// </summary>
    public void OnToggle(GameObject go, bool state)
    {
        if (m_dicOnToggleDelegate.ContainsKey(go))
        {
            m_dicOnToggleDelegate[go](go, state);
        }
        if (m_dicOnToggleDelegateLua.ContainsKey(go))
        {
            m_dicOnToggleDelegateLua[go].Call(go, state);
        }
    }

    /// <summary>
    /// 添加拖动事件
    /// </summary>
    /// <param name="go"></param>
    /// <param name="onDragging"></param>
    public void AddOnDragEvent(GameObject go, OnDragBeginDelegate onDragBegin, OnDraggingDelegate onDragging, OnDragEndDelegate onDragEnd)
    {
        if (go == null)
            return;

        if (m_dicOnDragBeginDelegate.ContainsKey(go))
        {
            m_dicOnDragBeginDelegate[go] = onDragBegin;
        }
        else
        {
            m_dicOnDragBeginDelegate.Add(go, onDragBegin);
        }
        if (m_dicOnDraggingDelegate.ContainsKey(go))
        {
            m_dicOnDraggingDelegate[go] = onDragging;
        }
        else
        {
            m_dicOnDraggingDelegate.Add(go, onDragging);
        }
        if (m_dicOnDragEndDelegate.ContainsKey(go))
        {
            m_dicOnDragEndDelegate[go] = onDragEnd;
        }
        else
        {
            m_dicOnDragEndDelegate.Add(go, onDragEnd);
        }
    }

    public void AddOnDragEvent(GameObject go, LuaFunction onDragBegin, LuaFunction onDragging, LuaFunction onDragEnd)
    {
        if (go == null)
            return;

        if (m_dicOnDragBeginDelegateLua.ContainsKey(go))
        {
            m_dicOnDragBeginDelegateLua[go] = onDragBegin;
        }
        else
        {
            m_dicOnDragBeginDelegateLua.Add(go, onDragBegin);
        }
        if (m_dicOnDraggingDelegateLua.ContainsKey(go))
        {
            m_dicOnDraggingDelegateLua[go] = onDragging;
        }
        else
        {
            m_dicOnDraggingDelegateLua.Add(go, onDragging);
        }
        if (m_dicOnDragEndDelegateLua.ContainsKey(go))
        {
            m_dicOnDragEndDelegateLua[go] = onDragEnd;
        }
        else
        {
            m_dicOnDragEndDelegateLua.Add(go, onDragEnd);
        }
    }

    /// <summary>
    /// 移除拖动事件
    /// </summary>
    /// <param name="go"></param>
    public void RemoveOnDragEvent(GameObject go)
    {
        if (go == null)
            return;

        if (m_dicOnDragBeginDelegate.ContainsKey(go))
        {
            m_dicOnDragBeginDelegate.Remove(go);
        }
        if (m_dicOnDraggingDelegate.ContainsKey(go))
        {
            m_dicOnDraggingDelegate.Remove(go);
        }
        if (m_dicOnDragEndDelegate.ContainsKey(go))
        {
            m_dicOnDragEndDelegate.Remove(go);
        }

        if (m_dicOnDragBeginDelegateLua.ContainsKey(go))
        {
            m_dicOnDragBeginDelegateLua.Remove(go);
        }
        if (m_dicOnDraggingDelegateLua.ContainsKey(go))
        {
            m_dicOnDraggingDelegateLua.Remove(go);
        }
        if (m_dicOnDragEndDelegateLua.ContainsKey(go))
        {
            m_dicOnDragEndDelegateLua.Remove(go);
        }
    }

    public void SetDragBegin(GameObject go)
    {
        if (Input.GetMouseButtonDown(0) || Input.GetMouseButton(0))
        {
            if (m_dicOnDragBeginDelegate.ContainsKey(go)
                || m_dicOnDragBeginDelegateLua.ContainsKey(go))
            {
                m_objDragging = go;
                m_isMouseDown = true;
                m_isMouseMove = true;
                m_mouseDownPosition = Input.mousePosition;
                m_posBackup = GetScenePosition();

                if (m_dicOnDragBeginDelegate.ContainsKey(go))
                    m_dicOnDragBeginDelegate[go](go);

                if (m_dicOnDragBeginDelegateLua.ContainsKey(go))
                    m_dicOnDragBeginDelegateLua[go].Call(go);
            }
        }
    }

    /// <summary>
    /// 增加鼠标点击到物体事件
    /// </summary>
    public void AddOnMouseHitObjectEvent(OnMouseHitObjectDelegate delegateFunc)
    {
        if (!m_listOnMouseHitObject.Contains(delegateFunc))
        {
            m_listOnMouseHitObject.Add(delegateFunc);
        }
    }

    public void AddOnMouseHitObjectEventLua(LuaFunction delegateFunc)
    {
        if (!m_listOnMouseHitObjectLua.Contains(delegateFunc))
        {
            m_listOnMouseHitObjectLua.Add(delegateFunc);
        }
    }

    /// <summary>
    /// 移除鼠标点击到物体事件
    /// </summary>
    public void RemoveOnMouseHitObjectEvent(OnMouseHitObjectDelegate delegateFunc)
    {
        if (m_listOnMouseHitObject.Contains(delegateFunc))
        {
            m_listOnMouseHitObject.Remove(delegateFunc);
        }
    }

    public void RemoveOnMouseHitObjectEvent(LuaFunction delegateFunc)
    {
        if (m_listOnMouseHitObjectLua.Contains(delegateFunc))
        {
            m_listOnMouseHitObjectLua.Remove(delegateFunc);
        }
    }

    /// <summary>
    /// 增加鼠标移动事件
    /// </summary>
    public void AddOnMouseMoveEvent(OnMouseMoveDelegate delegateFunc)
    {
        if (!m_listOnMouseMove.Contains(delegateFunc))
        {
            m_listOnMouseMove.Add(delegateFunc);
        }
    }

    public void AddOnMouseMoveEvent(LuaFunction delegateFunc)
    {
        if (!m_listOnMouseMoveLua.Contains(delegateFunc))
        {
            m_listOnMouseMoveLua.Add(delegateFunc);
        }
    }

    /// <summary>
    /// 移除鼠标移动事件
    /// </summary>
    public void RemoveOnMouseMoveEvent(OnMouseMoveDelegate delegateFunc)
    {
        if (m_listOnMouseMove.Contains(delegateFunc))
        {
            m_listOnMouseMove.Remove(delegateFunc);
        }
    }

    public void RemoveOnMouseMoveEvent(LuaFunction delegateFunc)
    {
        if (m_listOnMouseMoveLua.Contains(delegateFunc))
        {
            m_listOnMouseMoveLua.Remove(delegateFunc);
        }
    }

    /// <summary>
    /// 增加鼠标缩放事件
    /// </summary>
    public void AddOnMouseZoomEvent(OnMouseZoomDelegate delegateFunc)
    {
        if (!m_listOnMouseZoom.Contains(delegateFunc))
        {
            m_listOnMouseZoom.Add(delegateFunc);
        }
    }

    public void AddOnMouseZoomEvent(LuaFunction delegateFunc)
    {
        if (!m_listOnMouseZoomLua.Contains(delegateFunc))
        {
            m_listOnMouseZoomLua.Add(delegateFunc);
        }
    }

    /// <summary>
    /// 移除鼠标缩放事件
    /// </summary>
    public void RemoveOnMouseZoomEvent(OnMouseZoomDelegate delegateFunc)
    {
        if (m_listOnMouseZoom.Contains(delegateFunc))
        {
            m_listOnMouseZoom.Remove(delegateFunc);
        }
    }

    public void RemoveOnMouseZoomEvent(LuaFunction delegateFunc)
    {
        if (m_listOnMouseZoomLua.Contains(delegateFunc))
        {
            m_listOnMouseZoomLua.Remove(delegateFunc);
        }
    }

	// Update is called once per frame
	public void Update () 
	{
        if (!enable) return;

        if (m_cameraScene == null) return;

        // test
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
        
		InputHandle();
	}

	/// <summary>
	/// 是否有相机移动;
	/// </summary>
	public bool IsMouseMove()
	{
		return m_isMouseMove;
	}

	/// <summary>
	/// 重置,取消点击/移动状态;
	/// </summary>
	public void Reset()
	{
		if (m_isMouseDown)
		{
			m_isMouseDown = false;
		}
		else
		{
			m_isCancelInput = true;
		}

        if (m_isMouseMove && m_objDragging != null)
        {
            if (m_dicOnDragEndDelegate.ContainsKey(m_objDragging))
                m_dicOnDragEndDelegate[m_objDragging](m_objDragging);

            if (m_dicOnDragEndDelegateLua.ContainsKey(m_objDragging))
                m_dicOnDragEndDelegateLua[m_objDragging].Call(m_objDragging);
        }
        m_isMouseMove = false;
        m_objDragging = null;

        if (m_objPress != null)
        {
            if (m_dicOnPressDelegate.ContainsKey(m_objPress))
                m_dicOnPressDelegate[m_objPress](m_objPress, false);

            if (m_dicOnPressDelegateLua.ContainsKey(m_objPress))
                m_dicOnPressDelegateLua[m_objPress].Call(m_objPress, false);
        }
	}

    // 缩放
    void OnZoom(float delta)
    {
        for (int i = 0; i < m_listOnMouseZoom.Count; i++)
        {
            m_listOnMouseZoom[i](delta);
        }

        for (int i = 0; i < m_listOnMouseZoomLua.Count; i++)
        {
            m_listOnMouseZoomLua[i].Call(delta);
        }
    }

    //移动
    void OnMove(Vector3 delta)
    {
        for (int i = 0; i < m_listOnMouseMove.Count; i++)
        {
            m_listOnMouseMove[i](delta);
        }

        for (int i = 0; i < m_listOnMouseMoveLua.Count; i++)
        {
            m_listOnMouseMoveLua[i].Call(delta);
        }
    }

	/// <summary>
	/// 用户输入处理;
	/// </summary>
	void InputHandle()
	{
#if UNITY_EDITOR
		//鼠标中间滑轮，控制缩放;
		if (Input.GetAxis("Mouse ScrollWheel") != 0)
		{
            float zoom = -Input.GetAxis("Mouse ScrollWheel") * m_midMouseWheelSensitivity;
            OnZoom(zoom);
		}
#else
        if (Input.touchCount >= 2) return;

        /*
		//双指缩放;
		if (Input.touchCount == 2)
		{
			if ((Input.touches[0].phase == TouchPhase.Began || Input.touches[1].phase == TouchPhase.Began))
			{
                OnPress(null, false);
                
                if (m_isMouseMove && m_objDragging != null)
                {
                    m_dicOnDragEndDelegate[m_objDragging](m_objDragging);
                }
                m_isMouseMove = false;
                m_objDragging = null;

                Vector3 v0 = GamePublic.Instance.UICamera.ScreenToViewportPoint(Input.touches[0].position);
                Vector3 v1 = GamePublic.Instance.UICamera.ScreenToViewportPoint(Input.touches[1].position);
				m_multiTouchDistance = Vector3.Distance(v0, v1);
			}
			else 
			{
                Vector3 v0 = GamePublic.Instance.UICamera.ScreenToViewportPoint(Input.touches[0].position);
                Vector3 v1 = GamePublic.Instance.UICamera.ScreenToViewportPoint(Input.touches[1].position);
				float distance = Vector3.Distance(v0, v1);

				float offset = m_multiTouchDistance - distance;
				m_multiTouchDistance = distance;
                
                OnZoom(offset * m_midMouseWheelSensitivity * 2);
			}
            return;
		}
        else if (Input.touchCount > 2)
        {
            return;
        }
        */
#endif

        if (Input.GetMouseButtonDown(0))
		{
			if (m_isCancelInput)
			{
				m_isCancelInput = false;
				return;
			}

            if (m_isMouseDown) return;
            m_isMouseDown = true;

            // 判断是否点到了需要拖动的物体
            GameObject go = GetMouseHit();
            if (go != null)
            {
                OnPress(go, true);
            }
		}
		else if (m_isMouseDown && Input.GetMouseButton(0))
		{
			if (!m_isMouseMove)
			{
				if ((Input.mousePosition - m_mouseDownPosition).magnitude > 5)
				{
					m_isMouseMove = true;
					m_mouseDownPosition = Input.mousePosition;
                    m_posBackup = GetScenePosition();

                    if (m_objDragging != null)
                    {
                        if (m_dicOnDragBeginDelegate.ContainsKey(m_objDragging))
                            m_dicOnDragBeginDelegate[m_objDragging](m_objDragging);

                        if (m_dicOnDragBeginDelegateLua.ContainsKey(m_objDragging))
                            m_dicOnDragBeginDelegateLua[m_objDragging].Call(m_objDragging);
                    }
				}
				return;
			}

            Vector3 posScene = GetScenePosition();
            Vector3 offset = m_posBackup - posScene;
            
            if (m_objDragging == null)
            {
                OnMove(offset);
            }
            else
            {
                if (m_dicOnDraggingDelegate.ContainsKey(m_objDragging))
                    m_dicOnDraggingDelegate[m_objDragging](m_objDragging, -offset);

                if (m_dicOnDraggingDelegateLua.ContainsKey(m_objDragging))
                    m_dicOnDraggingDelegateLua[m_objDragging].Call(m_objDragging, -offset);
            }

            m_posBackup = GetScenePosition();
		}
        else if (m_isMouseDown && Input.GetMouseButtonUp(0))
		{
            OnPress(null, false);

            if (m_isMouseMove == false)
            {
                // 判断是否点到了需要点击事件的物体
                GameObject go = GetMouseHit();
                if (go != null)
                {
                    OnClick(go);

                    for (int i = 0; i < m_listOnMouseHitObject.Count; i++)
                    {
                        m_listOnMouseHitObject[i](go);
                    }

                    for (int i = 0; i < m_listOnMouseHitObjectLua.Count; i++)
                    {
                        m_listOnMouseHitObjectLua[i].Call(go);
                    }
                }
            }
            else
            {
                if (m_objDragging != null)
                {
                    if (m_dicOnDragEndDelegate.ContainsKey(m_objDragging))
                        m_dicOnDragEndDelegate[m_objDragging](m_objDragging);

                    if (m_dicOnDragEndDelegateLua.ContainsKey(m_objDragging))
                        m_dicOnDragEndDelegateLua[m_objDragging].Call(m_objDragging);
                }
            }

            m_objDragging = null;
            m_isMouseMove = false;
		}

        //重置移动的标志
        if (!Input.GetMouseButton(0) && m_isMouseMove)
        {
            Reset();
        }
        else
        {
            m_isCancelInput = false;
        }
	}

    private GameObject GetMouseHit()
    {
        if (m_cameraUI != null)
        {
            RaycastHit2D hit = Physics2D.Raycast(m_cameraUI.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);
            if (hit.transform != null)
            {
                return hit.transform.gameObject;
            }
        }

        if (m_cameraScene != null)
        {
            RaycastHit2D hit = Physics2D.Raycast(m_cameraScene.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);
            if (hit.transform != null)
            {
                return hit.transform.gameObject;
            }
        }

        return null;
    }

    /// <summary>
    /// 计算从屏幕坐标到本地坐标的转换
    /// </summary>
    private Vector3 GetScenePosition()
    {
        Vector3 pos = Vector3.zero;

        Vector3 mousePos = m_cameraScene.ScreenToWorldPoint(Input.mousePosition);
        
        if (m_rayDirection.y != 0)
        {
            pos.x = mousePos.x - m_rayDirection.x * mousePos.y / m_rayDirection.y;
            pos.z = mousePos.z - m_rayDirection.z * mousePos.y / m_rayDirection.y;
        }
        else
        {
            pos = mousePos;
        }

        return pos;
    }
}
