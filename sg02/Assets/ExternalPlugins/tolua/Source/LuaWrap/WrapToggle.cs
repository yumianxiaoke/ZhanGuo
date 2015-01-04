﻿using System;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using LuaInterface;

public class WrapToggle
{
	public static LuaMethod[] regs = new LuaMethod[]
	{
		new LuaMethod("Rebuild", Rebuild),
		new LuaMethod("OnPointerClick", OnPointerClick),
		new LuaMethod("OnSubmit", OnSubmit),
		new LuaMethod("New", _CreateToggle),
		new LuaMethod("GetClassType", GetClassType),
	};

	static LuaField[] fields = new LuaField[]
	{
		new LuaField("toggleTransition", get_toggleTransition, set_toggleTransition),
		new LuaField("graphic", get_graphic, set_graphic),
		new LuaField("onValueChanged", get_onValueChanged, set_onValueChanged),
		new LuaField("group", get_group, set_group),
		new LuaField("isOn", get_isOn, set_isOn),
	};

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreateToggle(IntPtr L)
	{
		LuaDLL.luaL_error(L, "Toggle class does not have a constructor function");
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetClassType(IntPtr L)
	{
		LuaScriptMgr.Push(L, typeof(Toggle));
		return 1;
	}

	public static void Register(IntPtr L)
	{
		LuaScriptMgr.RegisterLib(L, "Toggle", typeof(Toggle), regs, fields, "UnityEngine.UI.Selectable");
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_toggleTransition(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);

		if (o == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name toggleTransition");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index toggleTransition on a nil value");
			}
		}

		Toggle obj = (Toggle)o;
		LuaScriptMgr.PushEnum(L, obj.toggleTransition);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_graphic(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);

		if (o == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name graphic");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index graphic on a nil value");
			}
		}

		Toggle obj = (Toggle)o;
		LuaScriptMgr.Push(L, obj.graphic);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_onValueChanged(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);

		if (o == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name onValueChanged");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index onValueChanged on a nil value");
			}
		}

		Toggle obj = (Toggle)o;
		LuaScriptMgr.PushObject(L, obj.onValueChanged);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_group(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);

		if (o == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name group");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index group on a nil value");
			}
		}

		Toggle obj = (Toggle)o;
		LuaScriptMgr.Push(L, obj.group);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_isOn(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);

		if (o == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name isOn");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index isOn on a nil value");
			}
		}

		Toggle obj = (Toggle)o;
		LuaScriptMgr.Push(L, obj.isOn);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_toggleTransition(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);

		if (o == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name toggleTransition");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index toggleTransition on a nil value");
			}
		}

		Toggle obj = (Toggle)o;
		obj.toggleTransition = LuaScriptMgr.GetNetObject<UnityEngine.UI.Toggle.ToggleTransition>(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_graphic(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);

		if (o == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name graphic");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index graphic on a nil value");
			}
		}

		Toggle obj = (Toggle)o;
		obj.graphic = LuaScriptMgr.GetNetObject<Graphic>(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_onValueChanged(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);

		if (o == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name onValueChanged");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index onValueChanged on a nil value");
			}
		}

		Toggle obj = (Toggle)o;
		obj.onValueChanged = LuaScriptMgr.GetNetObject<UnityEngine.UI.Toggle.ToggleEvent>(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_group(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);

		if (o == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name group");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index group on a nil value");
			}
		}

		Toggle obj = (Toggle)o;
		obj.group = LuaScriptMgr.GetNetObject<ToggleGroup>(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_isOn(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);

		if (o == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name isOn");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index isOn on a nil value");
			}
		}

		Toggle obj = (Toggle)o;
		obj.isOn = LuaScriptMgr.GetBoolean(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Rebuild(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 2);
		Toggle obj = LuaScriptMgr.GetNetObject<Toggle>(L, 1);
		CanvasUpdate arg0 = LuaScriptMgr.GetNetObject<CanvasUpdate>(L, 2);
		obj.Rebuild(arg0);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int OnPointerClick(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 2);
		Toggle obj = LuaScriptMgr.GetNetObject<Toggle>(L, 1);
		PointerEventData arg0 = LuaScriptMgr.GetNetObject<PointerEventData>(L, 2);
		obj.OnPointerClick(arg0);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int OnSubmit(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 2);
		Toggle obj = LuaScriptMgr.GetNetObject<Toggle>(L, 1);
		BaseEventData arg0 = LuaScriptMgr.GetNetObject<BaseEventData>(L, 2);
		obj.OnSubmit(arg0);
		return 0;
	}
}

