using System;
using LuaInterface;

public class WrapXMLDataCityPoints
{
	public static LuaMethod[] regs = new LuaMethod[]
	{
		new LuaMethod("New", _CreateXMLDataCityPoints),
		new LuaMethod("GetClassType", GetClassType),
	};

	static LuaField[] fields = new LuaField[]
	{
		new LuaField("ID", get_ID, set_ID),
		new LuaField("FromCity", get_FromCity, set_FromCity),
		new LuaField("ToCity", get_ToCity, set_ToCity),
		new LuaField("FromPoint", get_FromPoint, set_FromPoint),
		new LuaField("ToPoint", get_ToPoint, set_ToPoint),
		new LuaField("Path", get_Path, set_Path),
	};

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreateXMLDataCityPoints(IntPtr L)
	{
		int count = LuaDLL.lua_gettop(L);

		if (count == 0)
		{
			XMLDataCityPoints obj = new XMLDataCityPoints();
			LuaScriptMgr.PushObject(L, obj);
			return 1;
		}
		else
		{
			LuaDLL.luaL_error(L, "invalid arguments to method: XMLDataCityPoints.New");
		}

		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetClassType(IntPtr L)
	{
		LuaScriptMgr.Push(L, typeof(XMLDataCityPoints));
		return 1;
	}

	public static void Register(IntPtr L)
	{
		LuaScriptMgr.RegisterLib(L, "XMLDataCityPoints", typeof(XMLDataCityPoints), regs, fields, "System.Object");
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_ID(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);

		if (o == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name ID");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index ID on a nil value");
			}
		}

		XMLDataCityPoints obj = (XMLDataCityPoints)o;
		LuaScriptMgr.Push(L, obj.ID);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_FromCity(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);

		if (o == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name FromCity");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index FromCity on a nil value");
			}
		}

		XMLDataCityPoints obj = (XMLDataCityPoints)o;
		LuaScriptMgr.Push(L, obj.FromCity);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_ToCity(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);

		if (o == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name ToCity");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index ToCity on a nil value");
			}
		}

		XMLDataCityPoints obj = (XMLDataCityPoints)o;
		LuaScriptMgr.Push(L, obj.ToCity);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_FromPoint(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);

		if (o == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name FromPoint");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index FromPoint on a nil value");
			}
		}

		XMLDataCityPoints obj = (XMLDataCityPoints)o;
		LuaScriptMgr.Push(L, obj.FromPoint);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_ToPoint(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);

		if (o == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name ToPoint");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index ToPoint on a nil value");
			}
		}

		XMLDataCityPoints obj = (XMLDataCityPoints)o;
		LuaScriptMgr.Push(L, obj.ToPoint);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_Path(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);

		if (o == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name Path");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index Path on a nil value");
			}
		}

		XMLDataCityPoints obj = (XMLDataCityPoints)o;
		LuaScriptMgr.Push(L, obj.Path);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_ID(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);

		if (o == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name ID");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index ID on a nil value");
			}
		}

		XMLDataCityPoints obj = (XMLDataCityPoints)o;
		obj.ID = (int)LuaScriptMgr.GetNumber(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_FromCity(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);

		if (o == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name FromCity");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index FromCity on a nil value");
			}
		}

		XMLDataCityPoints obj = (XMLDataCityPoints)o;
		obj.FromCity = (int)LuaScriptMgr.GetNumber(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_ToCity(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);

		if (o == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name ToCity");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index ToCity on a nil value");
			}
		}

		XMLDataCityPoints obj = (XMLDataCityPoints)o;
		obj.ToCity = (int)LuaScriptMgr.GetNumber(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_FromPoint(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);

		if (o == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name FromPoint");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index FromPoint on a nil value");
			}
		}

		XMLDataCityPoints obj = (XMLDataCityPoints)o;
		obj.FromPoint = (int)LuaScriptMgr.GetNumber(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_ToPoint(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);

		if (o == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name ToPoint");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index ToPoint on a nil value");
			}
		}

		XMLDataCityPoints obj = (XMLDataCityPoints)o;
		obj.ToPoint = (int)LuaScriptMgr.GetNumber(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_Path(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);

		if (o == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name Path");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index Path on a nil value");
			}
		}

		XMLDataCityPoints obj = (XMLDataCityPoints)o;
		obj.Path = LuaScriptMgr.GetString(L, 3);
		return 0;
	}
}

