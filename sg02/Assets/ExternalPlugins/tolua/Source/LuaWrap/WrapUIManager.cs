﻿using System;
using UnityEngine;
using System.Collections.Generic;
using LuaInterface;
using Object = UnityEngine.Object;

public class WrapUIManager
{
	public static LuaMethod[] regs = new LuaMethod[]
	{
		new LuaMethod("ShowView", ShowView),
		new LuaMethod("HideView", HideView),
		new LuaMethod("DestroyView", DestroyView),
		new LuaMethod("DestroyAllView", DestroyAllView),
		new LuaMethod("New", _CreateUIManager),
		new LuaMethod("GetClassType", GetClassType),
	};

	static LuaField[] fields = new LuaField[]
	{
		new LuaField("Instance", get_Instance, null),
		new LuaField("m_dicUIView", get_m_dicUIView, set_m_dicUIView),
		new LuaField("UIRoot", get_UIRoot, null),
	};

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreateUIManager(IntPtr L)
	{
		int count = LuaDLL.lua_gettop(L);

		if (count == 0)
		{
			UIManager obj = new UIManager();
			LuaScriptMgr.PushObject(L, obj);
			return 1;
		}
		else
		{
			LuaDLL.luaL_error(L, "invalid arguments to method: UIManager.New");
		}

		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetClassType(IntPtr L)
	{
		LuaScriptMgr.Push(L, typeof(UIManager));
		return 1;
	}

	public static void Register(IntPtr L)
	{
		LuaScriptMgr.RegisterLib(L, "UIManager", typeof(UIManager), regs, fields, "Singleton`1[UIManager]");
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_Instance(IntPtr L)
	{
		LuaScriptMgr.PushObject(L, UIManager.Instance);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_m_dicUIView(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);

		if (o == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name m_dicUIView");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index m_dicUIView on a nil value");
			}
		}

		UIManager obj = (UIManager)o;
		LuaScriptMgr.PushObject(L, obj.m_dicUIView);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_UIRoot(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);

		if (o == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name UIRoot");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index UIRoot on a nil value");
			}
		}

		UIManager obj = (UIManager)o;
		LuaScriptMgr.Push(L, obj.UIRoot);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_m_dicUIView(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);

		if (o == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name m_dicUIView");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index m_dicUIView on a nil value");
			}
		}

		UIManager obj = (UIManager)o;
		obj.m_dicUIView = LuaScriptMgr.GetNetObject<Dictionary<string,GameObject>>(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int ShowView(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 2);
		UIManager obj = LuaScriptMgr.GetNetObject<UIManager>(L, 1);
		string arg0 = LuaScriptMgr.GetLuaString(L, 2);
		GameObject o = obj.ShowView(arg0);
		LuaScriptMgr.Push(L, o);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int HideView(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 2);
		UIManager obj = LuaScriptMgr.GetNetObject<UIManager>(L, 1);
		string arg0 = LuaScriptMgr.GetLuaString(L, 2);
		obj.HideView(arg0);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int DestroyView(IntPtr L)
	{
		int count = LuaDLL.lua_gettop(L);

		Type[] types0 = {typeof(UIManager), typeof(GameObject)};
		Type[] types1 = {typeof(UIManager), typeof(string)};

		if (count == 2 && LuaScriptMgr.CheckTypes(L, types0, 1))
		{
			UIManager obj = LuaScriptMgr.GetNetObject<UIManager>(L, 1);
			GameObject arg0 = LuaScriptMgr.GetNetObject<GameObject>(L, 2);
			obj.DestroyView(arg0);
			return 0;
		}
		else if (count == 2 && LuaScriptMgr.CheckTypes(L, types1, 1))
		{
			UIManager obj = LuaScriptMgr.GetNetObject<UIManager>(L, 1);
			string arg0 = LuaScriptMgr.GetString(L, 2);
			obj.DestroyView(arg0);
			return 0;
		}
		else
		{
			LuaDLL.luaL_error(L, "invalid arguments to method: UIManager.DestroyView");
		}

		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int DestroyAllView(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 1);
		UIManager obj = LuaScriptMgr.GetNetObject<UIManager>(L, 1);
		obj.DestroyAllView();
		return 0;
	}
}

