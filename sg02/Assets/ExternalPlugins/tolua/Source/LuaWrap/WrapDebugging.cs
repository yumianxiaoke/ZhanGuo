using System;
using System.Collections.Generic;
using UnityEngine;
using LuaInterface;

public class WrapDebugging
{
	public static LuaMethod[] regs = new LuaMethod[]
	{
		new LuaMethod("Init", Init),
		new LuaMethod("WriteInTxt", WriteInTxt),
		new LuaMethod("Log", Log),
		new LuaMethod("LogError", LogError),
		new LuaMethod("LogWarning", LogWarning),
		new LuaMethod("SetFilterWords", SetFilterWords),
		new LuaMethod("New", _CreateDebugging),
		new LuaMethod("GetClassType", GetClassType),
	};

	static LuaField[] fields = new LuaField[]
	{
		new LuaField("LV_DEBUG", get_LV_DEBUG, null),
		new LuaField("LV_ERROR", get_LV_ERROR, null),
		new LuaField("LV_INFO", get_LV_INFO, null),
		new LuaField("LV_NONE", get_LV_NONE, null),
		new LuaField("LV_WARING", get_LV_WARING, null),
		new LuaField("m_line", get_m_line, set_m_line),
		new LuaField("m_writeTxt", get_m_writeTxt, set_m_writeTxt),
		new LuaField("CurrentDebugLevel", get_CurrentDebugLevel, null),
	};

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreateDebugging(IntPtr L)
	{
		int count = LuaDLL.lua_gettop(L);

		if (count == 0)
		{
			Debugging obj = new Debugging();
			LuaScriptMgr.PushObject(L, obj);
			return 1;
		}
		else
		{
			LuaDLL.luaL_error(L, "invalid arguments to method: Debugging.New");
		}

		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetClassType(IntPtr L)
	{
		LuaScriptMgr.Push(L, typeof(Debugging));
		return 1;
	}

	public static void Register(IntPtr L)
	{
		LuaScriptMgr.RegisterLib(L, "Debugging", typeof(Debugging), regs, fields, "System.Object");
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_LV_DEBUG(IntPtr L)
	{
		LuaScriptMgr.Push(L, Debugging.LV_DEBUG);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_LV_ERROR(IntPtr L)
	{
		LuaScriptMgr.Push(L, Debugging.LV_ERROR);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_LV_INFO(IntPtr L)
	{
		LuaScriptMgr.Push(L, Debugging.LV_INFO);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_LV_NONE(IntPtr L)
	{
		LuaScriptMgr.Push(L, Debugging.LV_NONE);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_LV_WARING(IntPtr L)
	{
		LuaScriptMgr.Push(L, Debugging.LV_WARING);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_m_line(IntPtr L)
	{
		LuaScriptMgr.PushObject(L, Debugging.m_line);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_m_writeTxt(IntPtr L)
	{
		LuaScriptMgr.PushObject(L, Debugging.m_writeTxt);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_CurrentDebugLevel(IntPtr L)
	{
		LuaScriptMgr.Push(L, Debugging.CurrentDebugLevel);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_m_line(IntPtr L)
	{
		Debugging.m_line = LuaScriptMgr.GetNetObject<List<string>>(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_m_writeTxt(IntPtr L)
	{
		Debugging.m_writeTxt = LuaScriptMgr.GetNetObject<List<string>>(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Init(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 1);
		int arg0 = (int)LuaScriptMgr.GetNumber(L, 1);
		Debugging.Init(arg0);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int WriteInTxt(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 0);
		Debugging.WriteInTxt();
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Log(IntPtr L)
	{
		int count = LuaDLL.lua_gettop(L);

		Type[] types0 = {typeof(string)};
		Type[] types1 = {typeof(float)};
		Type[] types2 = {typeof(Vector3), typeof(int)};
		Type[] types3 = {typeof(string)};
		Type[] types4 = {typeof(float), typeof(int)};
		Type[] types5 = {typeof(string), typeof(int)};

		if (count == 1 && LuaScriptMgr.CheckTypes(L, types0, 1))
		{
			string arg0 = LuaScriptMgr.GetString(L, 1);
			Debugging.Log(arg0);
			return 0;
		}
		else if (count == 1 && LuaScriptMgr.CheckTypes(L, types1, 1))
		{
			float arg0 = (float)LuaScriptMgr.GetNumber(L, 1);
			Debugging.Log(arg0);
			return 0;
		}
		else if (count == 2 && LuaScriptMgr.CheckTypes(L, types2, 1))
		{
			Vector3 arg0 = LuaScriptMgr.GetNetObject<Vector3>(L, 1);
			int arg1 = (int)LuaScriptMgr.GetNumber(L, 2);
			Debugging.Log(arg0,arg1);
			return 0;
		}
		else if (LuaScriptMgr.CheckTypes(L, types3, 1) && LuaScriptMgr.CheckParamsType(L, typeof(object), 2, count - 1))
		{
			string arg0 = LuaScriptMgr.GetString(L, 1);
			object[] objs1 = LuaScriptMgr.GetParamsObject(L, 2, count - 1);
			Debugging.Log(arg0,objs1);
			return 0;
		}
		else if (count == 2 && LuaScriptMgr.CheckTypes(L, types4, 1))
		{
			float arg0 = (float)LuaScriptMgr.GetNumber(L, 1);
			int arg1 = (int)LuaScriptMgr.GetNumber(L, 2);
			Debugging.Log(arg0,arg1);
			return 0;
		}
		else if (count == 2 && LuaScriptMgr.CheckTypes(L, types5, 1))
		{
			string arg0 = LuaScriptMgr.GetString(L, 1);
			int arg1 = (int)LuaScriptMgr.GetNumber(L, 2);
			Debugging.Log(arg0,arg1);
			return 0;
		}
		else
		{
			LuaDLL.luaL_error(L, "invalid arguments to method: Debugging.Log");
		}

		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int LogError(IntPtr L)
	{
		int count = LuaDLL.lua_gettop(L);

		Type[] types1 = {typeof(string)};

		if (count == 1)
		{
			string arg0 = LuaScriptMgr.GetLuaString(L, 1);
			Debugging.LogError(arg0);
			return 0;
		}
		else if (LuaScriptMgr.CheckTypes(L, types1, 1) && LuaScriptMgr.CheckParamsType(L, typeof(object), 2, count - 1))
		{
			string arg0 = LuaScriptMgr.GetString(L, 1);
			object[] objs1 = LuaScriptMgr.GetParamsObject(L, 2, count - 1);
			Debugging.LogError(arg0,objs1);
			return 0;
		}
		else
		{
			LuaDLL.luaL_error(L, "invalid arguments to method: Debugging.LogError");
		}

		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int LogWarning(IntPtr L)
	{
		int count = LuaDLL.lua_gettop(L);

		Type[] types1 = {typeof(string)};

		if (count == 1)
		{
			string arg0 = LuaScriptMgr.GetLuaString(L, 1);
			Debugging.LogWarning(arg0);
			return 0;
		}
		else if (LuaScriptMgr.CheckTypes(L, types1, 1) && LuaScriptMgr.CheckParamsType(L, typeof(object), 2, count - 1))
		{
			string arg0 = LuaScriptMgr.GetString(L, 1);
			object[] objs1 = LuaScriptMgr.GetParamsObject(L, 2, count - 1);
			Debugging.LogWarning(arg0,objs1);
			return 0;
		}
		else
		{
			LuaDLL.luaL_error(L, "invalid arguments to method: Debugging.LogWarning");
		}

		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SetFilterWords(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 1);
		string arg0 = LuaScriptMgr.GetLuaString(L, 1);
		Debugging.SetFilterWords(arg0);
		return 0;
	}
}

