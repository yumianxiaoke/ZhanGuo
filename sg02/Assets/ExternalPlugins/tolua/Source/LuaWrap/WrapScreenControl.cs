using System;
using LuaInterface;

public class WrapScreenControl
{
	public static LuaMethod[] regs = new LuaMethod[]
	{
		new LuaMethod("Initialize", Initialize),
		new LuaMethod("New", _CreateScreenControl),
		new LuaMethod("GetClassType", GetClassType),
	};

	static LuaField[] fields = new LuaField[]
	{
		new LuaField("Instance", get_Instance, null),
		new LuaField("ScreenAspectRatio", get_ScreenAspectRatio, null),
		new LuaField("DesignAspect", get_DesignAspect, null),
		new LuaField("ScaleRatio", get_ScaleRatio, null),
		new LuaField("FunctionRatio", get_FunctionRatio, null),
	};

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreateScreenControl(IntPtr L)
	{
		int count = LuaDLL.lua_gettop(L);

		if (count == 0)
		{
			ScreenControl obj = new ScreenControl();
			LuaScriptMgr.PushObject(L, obj);
			return 1;
		}
		else
		{
			LuaDLL.luaL_error(L, "invalid arguments to method: ScreenControl.New");
		}

		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetClassType(IntPtr L)
	{
		LuaScriptMgr.Push(L, typeof(ScreenControl));
		return 1;
	}

	public static void Register(IntPtr L)
	{
		LuaScriptMgr.RegisterLib(L, "ScreenControl", typeof(ScreenControl), regs, fields, "Singleton`1[ScreenControl]");
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_Instance(IntPtr L)
	{
		LuaScriptMgr.PushObject(L, ScreenControl.Instance);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_ScreenAspectRatio(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);

		if (o == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name ScreenAspectRatio");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index ScreenAspectRatio on a nil value");
			}
		}

		ScreenControl obj = (ScreenControl)o;
		LuaScriptMgr.Push(L, obj.ScreenAspectRatio);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_DesignAspect(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);

		if (o == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name DesignAspect");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index DesignAspect on a nil value");
			}
		}

		ScreenControl obj = (ScreenControl)o;
		LuaScriptMgr.Push(L, obj.DesignAspect);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_ScaleRatio(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);

		if (o == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name ScaleRatio");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index ScaleRatio on a nil value");
			}
		}

		ScreenControl obj = (ScreenControl)o;
		LuaScriptMgr.Push(L, obj.ScaleRatio);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_FunctionRatio(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);

		if (o == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name FunctionRatio");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index FunctionRatio on a nil value");
			}
		}

		ScreenControl obj = (ScreenControl)o;
		LuaScriptMgr.Push(L, obj.FunctionRatio);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Initialize(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 3);
		ScreenControl obj = LuaScriptMgr.GetNetObject<ScreenControl>(L, 1);
		float arg0 = (float)LuaScriptMgr.GetNumber(L, 2);
		float arg1 = (float)LuaScriptMgr.GetNumber(L, 3);
		obj.Initialize(arg0,arg1);
		return 0;
	}
}

