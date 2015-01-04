using System;
using LuaInterface;

public class WrapMovmentComponent
{
	public static LuaMethod[] regs = new LuaMethod[]
	{
		new LuaMethod("New", _CreateMovmentComponent),
		new LuaMethod("GetClassType", GetClassType),
	};

	static LuaField[] fields = new LuaField[]
	{
	};

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreateMovmentComponent(IntPtr L)
	{
		LuaDLL.luaL_error(L, "MovmentComponent class does not have a constructor function");
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetClassType(IntPtr L)
	{
		LuaScriptMgr.Push(L, typeof(MovmentComponent));
		return 1;
	}

	public static void Register(IntPtr L)
	{
		LuaScriptMgr.RegisterLib(L, "MovmentComponent", typeof(MovmentComponent), regs, fields, "UnityEngine.MonoBehaviour");
	}
}

