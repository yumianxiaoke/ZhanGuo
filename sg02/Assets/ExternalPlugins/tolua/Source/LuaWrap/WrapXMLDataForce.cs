using System;
using LuaInterface;

public class WrapXMLDataForce
{
	public static LuaMethod[] regs = new LuaMethod[]
	{
		new LuaMethod("New", _CreateXMLDataForce),
		new LuaMethod("GetClassType", GetClassType),
	};

	static LuaField[] fields = new LuaField[]
	{
		new LuaField("ID", get_ID, set_ID),
		new LuaField("Name", get_Name, set_Name),
		new LuaField("ShortName", get_ShortName, set_ShortName),
		new LuaField("Force1", get_Force1, set_Force1),
		new LuaField("Force2", get_Force2, set_Force2),
		new LuaField("Force3", get_Force3, set_Force3),
		new LuaField("Force4", get_Force4, set_Force4),
		new LuaField("Force5", get_Force5, set_Force5),
		new LuaField("Force6", get_Force6, set_Force6),
		new LuaField("Force7", get_Force7, set_Force7),
		new LuaField("Force8", get_Force8, set_Force8),
		new LuaField("Force9", get_Force9, set_Force9),
		new LuaField("Force10", get_Force10, set_Force10),
		new LuaField("Force11", get_Force11, set_Force11),
		new LuaField("Force12", get_Force12, set_Force12),
		new LuaField("Force13", get_Force13, set_Force13),
	};

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreateXMLDataForce(IntPtr L)
	{
		int count = LuaDLL.lua_gettop(L);

		if (count == 0)
		{
			XMLDataForce obj = new XMLDataForce();
			LuaScriptMgr.PushObject(L, obj);
			return 1;
		}
		else
		{
			LuaDLL.luaL_error(L, "invalid arguments to method: XMLDataForce.New");
		}

		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetClassType(IntPtr L)
	{
		LuaScriptMgr.Push(L, typeof(XMLDataForce));
		return 1;
	}

	public static void Register(IntPtr L)
	{
		LuaScriptMgr.RegisterLib(L, "XMLDataForce", typeof(XMLDataForce), regs, fields, "System.Object");
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

		XMLDataForce obj = (XMLDataForce)o;
		LuaScriptMgr.Push(L, obj.ID);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_Name(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);

		if (o == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name Name");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index Name on a nil value");
			}
		}

		XMLDataForce obj = (XMLDataForce)o;
		LuaScriptMgr.Push(L, obj.Name);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_ShortName(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);

		if (o == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name ShortName");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index ShortName on a nil value");
			}
		}

		XMLDataForce obj = (XMLDataForce)o;
		LuaScriptMgr.Push(L, obj.ShortName);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_Force1(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);

		if (o == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name Force1");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index Force1 on a nil value");
			}
		}

		XMLDataForce obj = (XMLDataForce)o;
		LuaScriptMgr.Push(L, obj.Force1);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_Force2(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);

		if (o == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name Force2");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index Force2 on a nil value");
			}
		}

		XMLDataForce obj = (XMLDataForce)o;
		LuaScriptMgr.Push(L, obj.Force2);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_Force3(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);

		if (o == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name Force3");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index Force3 on a nil value");
			}
		}

		XMLDataForce obj = (XMLDataForce)o;
		LuaScriptMgr.Push(L, obj.Force3);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_Force4(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);

		if (o == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name Force4");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index Force4 on a nil value");
			}
		}

		XMLDataForce obj = (XMLDataForce)o;
		LuaScriptMgr.Push(L, obj.Force4);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_Force5(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);

		if (o == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name Force5");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index Force5 on a nil value");
			}
		}

		XMLDataForce obj = (XMLDataForce)o;
		LuaScriptMgr.Push(L, obj.Force5);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_Force6(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);

		if (o == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name Force6");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index Force6 on a nil value");
			}
		}

		XMLDataForce obj = (XMLDataForce)o;
		LuaScriptMgr.Push(L, obj.Force6);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_Force7(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);

		if (o == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name Force7");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index Force7 on a nil value");
			}
		}

		XMLDataForce obj = (XMLDataForce)o;
		LuaScriptMgr.Push(L, obj.Force7);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_Force8(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);

		if (o == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name Force8");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index Force8 on a nil value");
			}
		}

		XMLDataForce obj = (XMLDataForce)o;
		LuaScriptMgr.Push(L, obj.Force8);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_Force9(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);

		if (o == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name Force9");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index Force9 on a nil value");
			}
		}

		XMLDataForce obj = (XMLDataForce)o;
		LuaScriptMgr.Push(L, obj.Force9);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_Force10(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);

		if (o == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name Force10");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index Force10 on a nil value");
			}
		}

		XMLDataForce obj = (XMLDataForce)o;
		LuaScriptMgr.Push(L, obj.Force10);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_Force11(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);

		if (o == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name Force11");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index Force11 on a nil value");
			}
		}

		XMLDataForce obj = (XMLDataForce)o;
		LuaScriptMgr.Push(L, obj.Force11);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_Force12(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);

		if (o == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name Force12");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index Force12 on a nil value");
			}
		}

		XMLDataForce obj = (XMLDataForce)o;
		LuaScriptMgr.Push(L, obj.Force12);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_Force13(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);

		if (o == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name Force13");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index Force13 on a nil value");
			}
		}

		XMLDataForce obj = (XMLDataForce)o;
		LuaScriptMgr.Push(L, obj.Force13);
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

		XMLDataForce obj = (XMLDataForce)o;
		obj.ID = (int)LuaScriptMgr.GetNumber(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_Name(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);

		if (o == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name Name");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index Name on a nil value");
			}
		}

		XMLDataForce obj = (XMLDataForce)o;
		obj.Name = LuaScriptMgr.GetString(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_ShortName(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);

		if (o == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name ShortName");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index ShortName on a nil value");
			}
		}

		XMLDataForce obj = (XMLDataForce)o;
		obj.ShortName = LuaScriptMgr.GetString(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_Force1(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);

		if (o == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name Force1");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index Force1 on a nil value");
			}
		}

		XMLDataForce obj = (XMLDataForce)o;
		obj.Force1 = (int)LuaScriptMgr.GetNumber(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_Force2(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);

		if (o == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name Force2");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index Force2 on a nil value");
			}
		}

		XMLDataForce obj = (XMLDataForce)o;
		obj.Force2 = (int)LuaScriptMgr.GetNumber(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_Force3(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);

		if (o == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name Force3");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index Force3 on a nil value");
			}
		}

		XMLDataForce obj = (XMLDataForce)o;
		obj.Force3 = (int)LuaScriptMgr.GetNumber(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_Force4(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);

		if (o == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name Force4");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index Force4 on a nil value");
			}
		}

		XMLDataForce obj = (XMLDataForce)o;
		obj.Force4 = (int)LuaScriptMgr.GetNumber(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_Force5(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);

		if (o == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name Force5");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index Force5 on a nil value");
			}
		}

		XMLDataForce obj = (XMLDataForce)o;
		obj.Force5 = (int)LuaScriptMgr.GetNumber(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_Force6(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);

		if (o == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name Force6");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index Force6 on a nil value");
			}
		}

		XMLDataForce obj = (XMLDataForce)o;
		obj.Force6 = (int)LuaScriptMgr.GetNumber(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_Force7(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);

		if (o == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name Force7");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index Force7 on a nil value");
			}
		}

		XMLDataForce obj = (XMLDataForce)o;
		obj.Force7 = (int)LuaScriptMgr.GetNumber(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_Force8(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);

		if (o == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name Force8");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index Force8 on a nil value");
			}
		}

		XMLDataForce obj = (XMLDataForce)o;
		obj.Force8 = (int)LuaScriptMgr.GetNumber(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_Force9(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);

		if (o == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name Force9");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index Force9 on a nil value");
			}
		}

		XMLDataForce obj = (XMLDataForce)o;
		obj.Force9 = (int)LuaScriptMgr.GetNumber(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_Force10(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);

		if (o == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name Force10");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index Force10 on a nil value");
			}
		}

		XMLDataForce obj = (XMLDataForce)o;
		obj.Force10 = (int)LuaScriptMgr.GetNumber(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_Force11(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);

		if (o == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name Force11");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index Force11 on a nil value");
			}
		}

		XMLDataForce obj = (XMLDataForce)o;
		obj.Force11 = (int)LuaScriptMgr.GetNumber(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_Force12(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);

		if (o == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name Force12");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index Force12 on a nil value");
			}
		}

		XMLDataForce obj = (XMLDataForce)o;
		obj.Force12 = (int)LuaScriptMgr.GetNumber(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_Force13(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);

		if (o == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name Force13");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index Force13 on a nil value");
			}
		}

		XMLDataForce obj = (XMLDataForce)o;
		obj.Force13 = (int)LuaScriptMgr.GetNumber(L, 3);
		return 0;
	}
}

