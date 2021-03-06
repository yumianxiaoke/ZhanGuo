﻿using System;
using System.Collections.Generic;
using LuaInterface;

public class WrapPathFinding
{
	public static LuaMethod[] regs = new LuaMethod[]
	{
		new LuaMethod("GetPath", GetPath),
		new LuaMethod("New", _CreatePathFinding),
		new LuaMethod("GetClassType", GetClassType),
	};


	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreatePathFinding(IntPtr L)
	{
		LuaDLL.luaL_error(L, "PathFinding class does not have a constructor function");
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetClassType(IntPtr L)
	{
		LuaScriptMgr.Push(L, typeof(PathFinding));
		return 1;
	}

	public static void Register(IntPtr L)
	{
		LuaScriptMgr.RegisterLib(L, "PathFinding", regs);
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetPath(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 3);
		int arg0 = (int)LuaScriptMgr.GetNumber(L, 1);
		int arg1 = (int)LuaScriptMgr.GetNumber(L, 2);
		Dictionary<object,object> arg2 = LuaScriptMgr.GetNetObject<Dictionary<object,object>>(L, 3);
		List<int> o = PathFinding.GetPath(arg0,arg1,arg2);
		LuaScriptMgr.PushObject(L, o);
		return 1;
	}
}

