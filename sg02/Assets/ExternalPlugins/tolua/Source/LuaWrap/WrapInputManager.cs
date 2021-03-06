﻿using System;
using UnityEngine;
using LuaInterface;
using Object = UnityEngine.Object;

public class WrapInputManager
{
	public static LuaMethod[] regs = new LuaMethod[]
	{
		new LuaMethod("Initialize", Initialize),
		new LuaMethod("UnInitialize", UnInitialize),
		new LuaMethod("SetEnable", SetEnable),
		new LuaMethod("SetSceneCamera", SetSceneCamera),
		new LuaMethod("SetCameraUI", SetCameraUI),
		new LuaMethod("AddOnClickEvent", AddOnClickEvent),
		new LuaMethod("RemoveClickEvent", RemoveClickEvent),
		new LuaMethod("OnClick", OnClick),
		new LuaMethod("AddOnPressEvent", AddOnPressEvent),
		new LuaMethod("RemoveOnPressEvent", RemoveOnPressEvent),
		new LuaMethod("OnPress", OnPress),
		new LuaMethod("AddOnToggleEvent", AddOnToggleEvent),
		new LuaMethod("RemoveOnToggleEvent", RemoveOnToggleEvent),
		new LuaMethod("OnToggle", OnToggle),
		new LuaMethod("AddOnDragEvent", AddOnDragEvent),
		new LuaMethod("RemoveOnDragEvent", RemoveOnDragEvent),
		new LuaMethod("SetDragBegin", SetDragBegin),
		new LuaMethod("AddOnMouseHitObjectEvent", AddOnMouseHitObjectEvent),
		new LuaMethod("AddOnMouseHitObjectEventLua", AddOnMouseHitObjectEventLua),
		new LuaMethod("RemoveOnMouseHitObjectEvent", RemoveOnMouseHitObjectEvent),
		new LuaMethod("AddOnMouseMoveEvent", AddOnMouseMoveEvent),
		new LuaMethod("RemoveOnMouseMoveEvent", RemoveOnMouseMoveEvent),
		new LuaMethod("AddOnMouseZoomEvent", AddOnMouseZoomEvent),
		new LuaMethod("RemoveOnMouseZoomEvent", RemoveOnMouseZoomEvent),
		new LuaMethod("Update", Update),
		new LuaMethod("IsMouseMove", IsMouseMove),
		new LuaMethod("Reset", Reset),
		new LuaMethod("New", _CreateInputManager),
		new LuaMethod("GetClassType", GetClassType),
	};

	static LuaField[] fields = new LuaField[]
	{
		new LuaField("Instance", get_Instance, null),
	};

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreateInputManager(IntPtr L)
	{
		int count = LuaDLL.lua_gettop(L);

		if (count == 0)
		{
			InputManager obj = new InputManager();
			LuaScriptMgr.PushObject(L, obj);
			return 1;
		}
		else
		{
			LuaDLL.luaL_error(L, "invalid arguments to method: InputManager.New");
		}

		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetClassType(IntPtr L)
	{
		LuaScriptMgr.Push(L, typeof(InputManager));
		return 1;
	}

	public static void Register(IntPtr L)
	{
		LuaScriptMgr.RegisterLib(L, "InputManager", typeof(InputManager), regs, fields, "Singleton`1[InputManager]");
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_Instance(IntPtr L)
	{
		LuaScriptMgr.PushObject(L, InputManager.Instance);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Initialize(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 1);
		InputManager obj = LuaScriptMgr.GetNetObject<InputManager>(L, 1);
		obj.Initialize();
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int UnInitialize(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 1);
		InputManager obj = LuaScriptMgr.GetNetObject<InputManager>(L, 1);
		obj.UnInitialize();
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SetEnable(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 2);
		InputManager obj = LuaScriptMgr.GetNetObject<InputManager>(L, 1);
		bool arg0 = LuaScriptMgr.GetBoolean(L, 2);
		obj.SetEnable(arg0);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SetSceneCamera(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 2);
		InputManager obj = LuaScriptMgr.GetNetObject<InputManager>(L, 1);
		Camera arg0 = LuaScriptMgr.GetNetObject<Camera>(L, 2);
		obj.SetSceneCamera(arg0);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SetCameraUI(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 2);
		InputManager obj = LuaScriptMgr.GetNetObject<InputManager>(L, 1);
		Camera arg0 = LuaScriptMgr.GetNetObject<Camera>(L, 2);
		obj.SetCameraUI(arg0);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int AddOnClickEvent(IntPtr L)
	{
		int count = LuaDLL.lua_gettop(L);

		Type[] types0 = {typeof(InputManager), typeof(GameObject), typeof(LuaInterface.LuaFunction)};
		Type[] types1 = {typeof(InputManager), typeof(GameObject), typeof(InputManager.OnClickDelegate)};

		if (count == 3 && LuaScriptMgr.CheckTypes(L, types0, 1))
		{
			InputManager obj = LuaScriptMgr.GetNetObject<InputManager>(L, 1);
			GameObject arg0 = LuaScriptMgr.GetNetObject<GameObject>(L, 2);
			LuaFunction arg1 = LuaScriptMgr.GetLuaFunction(L, 3);
			obj.AddOnClickEvent(arg0,arg1);
			return 0;
		}
		else if (count == 3 && LuaScriptMgr.CheckTypes(L, types1, 1))
		{
			InputManager obj = LuaScriptMgr.GetNetObject<InputManager>(L, 1);
			GameObject arg0 = LuaScriptMgr.GetNetObject<GameObject>(L, 2);
			InputManager.OnClickDelegate arg1 = LuaScriptMgr.GetNetObject<InputManager.OnClickDelegate>(L, 3);
			obj.AddOnClickEvent(arg0,arg1);
			return 0;
		}
		else
		{
			LuaDLL.luaL_error(L, "invalid arguments to method: InputManager.AddOnClickEvent");
		}

		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int RemoveClickEvent(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 2);
		InputManager obj = LuaScriptMgr.GetNetObject<InputManager>(L, 1);
		GameObject arg0 = LuaScriptMgr.GetNetObject<GameObject>(L, 2);
		obj.RemoveClickEvent(arg0);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int OnClick(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 2);
		InputManager obj = LuaScriptMgr.GetNetObject<InputManager>(L, 1);
		GameObject arg0 = LuaScriptMgr.GetNetObject<GameObject>(L, 2);
		obj.OnClick(arg0);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int AddOnPressEvent(IntPtr L)
	{
		int count = LuaDLL.lua_gettop(L);

		Type[] types0 = {typeof(InputManager), typeof(GameObject), typeof(LuaInterface.LuaFunction)};
		Type[] types1 = {typeof(InputManager), typeof(GameObject), typeof(InputManager.OnPressDelegate)};

		if (count == 3 && LuaScriptMgr.CheckTypes(L, types0, 1))
		{
			InputManager obj = LuaScriptMgr.GetNetObject<InputManager>(L, 1);
			GameObject arg0 = LuaScriptMgr.GetNetObject<GameObject>(L, 2);
			LuaFunction arg1 = LuaScriptMgr.GetLuaFunction(L, 3);
			obj.AddOnPressEvent(arg0,arg1);
			return 0;
		}
		else if (count == 3 && LuaScriptMgr.CheckTypes(L, types1, 1))
		{
			InputManager obj = LuaScriptMgr.GetNetObject<InputManager>(L, 1);
			GameObject arg0 = LuaScriptMgr.GetNetObject<GameObject>(L, 2);
			InputManager.OnPressDelegate arg1 = LuaScriptMgr.GetNetObject<InputManager.OnPressDelegate>(L, 3);
			obj.AddOnPressEvent(arg0,arg1);
			return 0;
		}
		else
		{
			LuaDLL.luaL_error(L, "invalid arguments to method: InputManager.AddOnPressEvent");
		}

		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int RemoveOnPressEvent(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 2);
		InputManager obj = LuaScriptMgr.GetNetObject<InputManager>(L, 1);
		GameObject arg0 = LuaScriptMgr.GetNetObject<GameObject>(L, 2);
		obj.RemoveOnPressEvent(arg0);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int OnPress(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 3);
		InputManager obj = LuaScriptMgr.GetNetObject<InputManager>(L, 1);
		GameObject arg0 = LuaScriptMgr.GetNetObject<GameObject>(L, 2);
		bool arg1 = LuaScriptMgr.GetBoolean(L, 3);
		obj.OnPress(arg0,arg1);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int AddOnToggleEvent(IntPtr L)
	{
		int count = LuaDLL.lua_gettop(L);

		Type[] types0 = {typeof(InputManager), typeof(GameObject), typeof(LuaInterface.LuaFunction)};
		Type[] types1 = {typeof(InputManager), typeof(GameObject), typeof(InputManager.OnToggleDelegate)};

		if (count == 3 && LuaScriptMgr.CheckTypes(L, types0, 1))
		{
			InputManager obj = LuaScriptMgr.GetNetObject<InputManager>(L, 1);
			GameObject arg0 = LuaScriptMgr.GetNetObject<GameObject>(L, 2);
			LuaFunction arg1 = LuaScriptMgr.GetLuaFunction(L, 3);
			obj.AddOnToggleEvent(arg0,arg1);
			return 0;
		}
		else if (count == 3 && LuaScriptMgr.CheckTypes(L, types1, 1))
		{
			InputManager obj = LuaScriptMgr.GetNetObject<InputManager>(L, 1);
			GameObject arg0 = LuaScriptMgr.GetNetObject<GameObject>(L, 2);
			InputManager.OnToggleDelegate arg1 = LuaScriptMgr.GetNetObject<InputManager.OnToggleDelegate>(L, 3);
			obj.AddOnToggleEvent(arg0,arg1);
			return 0;
		}
		else
		{
			LuaDLL.luaL_error(L, "invalid arguments to method: InputManager.AddOnToggleEvent");
		}

		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int RemoveOnToggleEvent(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 2);
		InputManager obj = LuaScriptMgr.GetNetObject<InputManager>(L, 1);
		GameObject arg0 = LuaScriptMgr.GetNetObject<GameObject>(L, 2);
		obj.RemoveOnToggleEvent(arg0);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int OnToggle(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 3);
		InputManager obj = LuaScriptMgr.GetNetObject<InputManager>(L, 1);
		GameObject arg0 = LuaScriptMgr.GetNetObject<GameObject>(L, 2);
		bool arg1 = LuaScriptMgr.GetBoolean(L, 3);
		obj.OnToggle(arg0,arg1);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int AddOnDragEvent(IntPtr L)
	{
		int count = LuaDLL.lua_gettop(L);

		Type[] types0 = {typeof(InputManager), typeof(GameObject), typeof(LuaInterface.LuaFunction), typeof(LuaInterface.LuaFunction), typeof(LuaInterface.LuaFunction)};
		Type[] types1 = {typeof(InputManager), typeof(GameObject), typeof(InputManager.OnDragBeginDelegate), typeof(InputManager.OnDraggingDelegate), typeof(InputManager.OnDragEndDelegate)};

		if (count == 5 && LuaScriptMgr.CheckTypes(L, types0, 1))
		{
			InputManager obj = LuaScriptMgr.GetNetObject<InputManager>(L, 1);
			GameObject arg0 = LuaScriptMgr.GetNetObject<GameObject>(L, 2);
			LuaFunction arg1 = LuaScriptMgr.GetLuaFunction(L, 3);
			LuaFunction arg2 = LuaScriptMgr.GetLuaFunction(L, 4);
			LuaFunction arg3 = LuaScriptMgr.GetLuaFunction(L, 5);
			obj.AddOnDragEvent(arg0,arg1,arg2,arg3);
			return 0;
		}
		else if (count == 5 && LuaScriptMgr.CheckTypes(L, types1, 1))
		{
			InputManager obj = LuaScriptMgr.GetNetObject<InputManager>(L, 1);
			GameObject arg0 = LuaScriptMgr.GetNetObject<GameObject>(L, 2);
			InputManager.OnDragBeginDelegate arg1 = LuaScriptMgr.GetNetObject<InputManager.OnDragBeginDelegate>(L, 3);
			InputManager.OnDraggingDelegate arg2 = LuaScriptMgr.GetNetObject<InputManager.OnDraggingDelegate>(L, 4);
			InputManager.OnDragEndDelegate arg3 = LuaScriptMgr.GetNetObject<InputManager.OnDragEndDelegate>(L, 5);
			obj.AddOnDragEvent(arg0,arg1,arg2,arg3);
			return 0;
		}
		else
		{
			LuaDLL.luaL_error(L, "invalid arguments to method: InputManager.AddOnDragEvent");
		}

		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int RemoveOnDragEvent(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 2);
		InputManager obj = LuaScriptMgr.GetNetObject<InputManager>(L, 1);
		GameObject arg0 = LuaScriptMgr.GetNetObject<GameObject>(L, 2);
		obj.RemoveOnDragEvent(arg0);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SetDragBegin(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 2);
		InputManager obj = LuaScriptMgr.GetNetObject<InputManager>(L, 1);
		GameObject arg0 = LuaScriptMgr.GetNetObject<GameObject>(L, 2);
		obj.SetDragBegin(arg0);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int AddOnMouseHitObjectEvent(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 2);
		InputManager obj = LuaScriptMgr.GetNetObject<InputManager>(L, 1);
		InputManager.OnMouseHitObjectDelegate arg0 = LuaScriptMgr.GetNetObject<InputManager.OnMouseHitObjectDelegate>(L, 2);
		obj.AddOnMouseHitObjectEvent(arg0);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int AddOnMouseHitObjectEventLua(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 2);
		InputManager obj = LuaScriptMgr.GetNetObject<InputManager>(L, 1);
		LuaFunction arg0 = LuaScriptMgr.GetLuaFunction(L, 2);
		obj.AddOnMouseHitObjectEventLua(arg0);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int RemoveOnMouseHitObjectEvent(IntPtr L)
	{
		int count = LuaDLL.lua_gettop(L);

		Type[] types0 = {typeof(InputManager), typeof(LuaInterface.LuaFunction)};
		Type[] types1 = {typeof(InputManager), typeof(InputManager.OnMouseHitObjectDelegate)};

		if (count == 2 && LuaScriptMgr.CheckTypes(L, types0, 1))
		{
			InputManager obj = LuaScriptMgr.GetNetObject<InputManager>(L, 1);
			LuaFunction arg0 = LuaScriptMgr.GetLuaFunction(L, 2);
			obj.RemoveOnMouseHitObjectEvent(arg0);
			return 0;
		}
		else if (count == 2 && LuaScriptMgr.CheckTypes(L, types1, 1))
		{
			InputManager obj = LuaScriptMgr.GetNetObject<InputManager>(L, 1);
			InputManager.OnMouseHitObjectDelegate arg0 = LuaScriptMgr.GetNetObject<InputManager.OnMouseHitObjectDelegate>(L, 2);
			obj.RemoveOnMouseHitObjectEvent(arg0);
			return 0;
		}
		else
		{
			LuaDLL.luaL_error(L, "invalid arguments to method: InputManager.RemoveOnMouseHitObjectEvent");
		}

		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int AddOnMouseMoveEvent(IntPtr L)
	{
		int count = LuaDLL.lua_gettop(L);

		Type[] types0 = {typeof(InputManager), typeof(LuaInterface.LuaFunction)};
		Type[] types1 = {typeof(InputManager), typeof(InputManager.OnMouseMoveDelegate)};

		if (count == 2 && LuaScriptMgr.CheckTypes(L, types0, 1))
		{
			InputManager obj = LuaScriptMgr.GetNetObject<InputManager>(L, 1);
			LuaFunction arg0 = LuaScriptMgr.GetLuaFunction(L, 2);
			obj.AddOnMouseMoveEvent(arg0);
			return 0;
		}
		else if (count == 2 && LuaScriptMgr.CheckTypes(L, types1, 1))
		{
			InputManager obj = LuaScriptMgr.GetNetObject<InputManager>(L, 1);
			InputManager.OnMouseMoveDelegate arg0 = LuaScriptMgr.GetNetObject<InputManager.OnMouseMoveDelegate>(L, 2);
			obj.AddOnMouseMoveEvent(arg0);
			return 0;
		}
		else
		{
			LuaDLL.luaL_error(L, "invalid arguments to method: InputManager.AddOnMouseMoveEvent");
		}

		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int RemoveOnMouseMoveEvent(IntPtr L)
	{
		int count = LuaDLL.lua_gettop(L);

		Type[] types0 = {typeof(InputManager), typeof(LuaInterface.LuaFunction)};
		Type[] types1 = {typeof(InputManager), typeof(InputManager.OnMouseMoveDelegate)};

		if (count == 2 && LuaScriptMgr.CheckTypes(L, types0, 1))
		{
			InputManager obj = LuaScriptMgr.GetNetObject<InputManager>(L, 1);
			LuaFunction arg0 = LuaScriptMgr.GetLuaFunction(L, 2);
			obj.RemoveOnMouseMoveEvent(arg0);
			return 0;
		}
		else if (count == 2 && LuaScriptMgr.CheckTypes(L, types1, 1))
		{
			InputManager obj = LuaScriptMgr.GetNetObject<InputManager>(L, 1);
			InputManager.OnMouseMoveDelegate arg0 = LuaScriptMgr.GetNetObject<InputManager.OnMouseMoveDelegate>(L, 2);
			obj.RemoveOnMouseMoveEvent(arg0);
			return 0;
		}
		else
		{
			LuaDLL.luaL_error(L, "invalid arguments to method: InputManager.RemoveOnMouseMoveEvent");
		}

		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int AddOnMouseZoomEvent(IntPtr L)
	{
		int count = LuaDLL.lua_gettop(L);

		Type[] types0 = {typeof(InputManager), typeof(LuaInterface.LuaFunction)};
		Type[] types1 = {typeof(InputManager), typeof(InputManager.OnMouseZoomDelegate)};

		if (count == 2 && LuaScriptMgr.CheckTypes(L, types0, 1))
		{
			InputManager obj = LuaScriptMgr.GetNetObject<InputManager>(L, 1);
			LuaFunction arg0 = LuaScriptMgr.GetLuaFunction(L, 2);
			obj.AddOnMouseZoomEvent(arg0);
			return 0;
		}
		else if (count == 2 && LuaScriptMgr.CheckTypes(L, types1, 1))
		{
			InputManager obj = LuaScriptMgr.GetNetObject<InputManager>(L, 1);
			InputManager.OnMouseZoomDelegate arg0 = LuaScriptMgr.GetNetObject<InputManager.OnMouseZoomDelegate>(L, 2);
			obj.AddOnMouseZoomEvent(arg0);
			return 0;
		}
		else
		{
			LuaDLL.luaL_error(L, "invalid arguments to method: InputManager.AddOnMouseZoomEvent");
		}

		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int RemoveOnMouseZoomEvent(IntPtr L)
	{
		int count = LuaDLL.lua_gettop(L);

		Type[] types0 = {typeof(InputManager), typeof(LuaInterface.LuaFunction)};
		Type[] types1 = {typeof(InputManager), typeof(InputManager.OnMouseZoomDelegate)};

		if (count == 2 && LuaScriptMgr.CheckTypes(L, types0, 1))
		{
			InputManager obj = LuaScriptMgr.GetNetObject<InputManager>(L, 1);
			LuaFunction arg0 = LuaScriptMgr.GetLuaFunction(L, 2);
			obj.RemoveOnMouseZoomEvent(arg0);
			return 0;
		}
		else if (count == 2 && LuaScriptMgr.CheckTypes(L, types1, 1))
		{
			InputManager obj = LuaScriptMgr.GetNetObject<InputManager>(L, 1);
			InputManager.OnMouseZoomDelegate arg0 = LuaScriptMgr.GetNetObject<InputManager.OnMouseZoomDelegate>(L, 2);
			obj.RemoveOnMouseZoomEvent(arg0);
			return 0;
		}
		else
		{
			LuaDLL.luaL_error(L, "invalid arguments to method: InputManager.RemoveOnMouseZoomEvent");
		}

		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Update(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 1);
		InputManager obj = LuaScriptMgr.GetNetObject<InputManager>(L, 1);
		obj.Update();
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int IsMouseMove(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 1);
		InputManager obj = LuaScriptMgr.GetNetObject<InputManager>(L, 1);
		bool o = obj.IsMouseMove();
		LuaScriptMgr.Push(L, o);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Reset(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 1);
		InputManager obj = LuaScriptMgr.GetNetObject<InputManager>(L, 1);
		obj.Reset();
		return 0;
	}
}

