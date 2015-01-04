using System;
using LuaInterface;

public class WrapCityInfo
{
	public static LuaMethod[] regs = new LuaMethod[]
	{
		new LuaMethod("AddGeneral", AddGeneral),
		new LuaMethod("RemoveGeneral", RemoveGeneral),
		new LuaMethod("AddPrison", AddPrison),
		new LuaMethod("RemovePrison", RemovePrison),
		new LuaMethod("AddObject", AddObject),
		new LuaMethod("RemoveObject", RemoveObject),
		new LuaMethod("FindMajor", FindMajor),
		new LuaMethod("New", _CreateCityInfo),
		new LuaMethod("GetClassType", GetClassType),
	};

	static LuaField[] fields = new LuaField[]
	{
		new LuaField("ID", get_ID, set_ID),
		new LuaField("Name", get_Name, set_Name),
		new LuaField("KingID", get_KingID, set_KingID),
		new LuaField("Level", get_Level, set_Level),
		new LuaField("Flag", get_Flag, set_Flag),
		new LuaField("GeneralMax", get_GeneralMax, set_GeneralMax),
		new LuaField("Major", get_Major, set_Major),
		new LuaField("Wise", get_Wise, set_Wise),
		new LuaField("Population", get_Population, set_Population),
		new LuaField("Money", get_Money, set_Money),
		new LuaField("Reservist", get_Reservist, set_Reservist),
		new LuaField("ReservistMax", get_ReservistMax, set_ReservistMax),
		new LuaField("Defense", get_Defense, set_Defense),
		new LuaField("Generals", get_Generals, null),
		new LuaField("Prisons", get_Prisons, null),
		new LuaField("Objects", get_Objects, null),
	};

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreateCityInfo(IntPtr L)
	{
		int count = LuaDLL.lua_gettop(L);

		if (count == 0)
		{
			CityInfo obj = new CityInfo();
			LuaScriptMgr.PushObject(L, obj);
			return 1;
		}
		else if (count == 1)
		{
			int arg0 = (int)LuaScriptMgr.GetNumber(L, 1);
			CityInfo obj = new CityInfo(arg0);
			LuaScriptMgr.PushObject(L, obj);
			return 1;
		}
		else
		{
			LuaDLL.luaL_error(L, "invalid arguments to method: CityInfo.New");
		}

		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetClassType(IntPtr L)
	{
		LuaScriptMgr.Push(L, typeof(CityInfo));
		return 1;
	}

	public static void Register(IntPtr L)
	{
		LuaScriptMgr.RegisterLib(L, "CityInfo", typeof(CityInfo), regs, fields, "System.Object");
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

		CityInfo obj = (CityInfo)o;
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

		CityInfo obj = (CityInfo)o;
		LuaScriptMgr.Push(L, obj.Name);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_KingID(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);

		if (o == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name KingID");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index KingID on a nil value");
			}
		}

		CityInfo obj = (CityInfo)o;
		LuaScriptMgr.Push(L, obj.KingID);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_Level(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);

		if (o == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name Level");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index Level on a nil value");
			}
		}

		CityInfo obj = (CityInfo)o;
		LuaScriptMgr.Push(L, obj.Level);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_Flag(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);

		if (o == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name Flag");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index Flag on a nil value");
			}
		}

		CityInfo obj = (CityInfo)o;
		LuaScriptMgr.Push(L, obj.Flag);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_GeneralMax(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);

		if (o == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name GeneralMax");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index GeneralMax on a nil value");
			}
		}

		CityInfo obj = (CityInfo)o;
		LuaScriptMgr.Push(L, obj.GeneralMax);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_Major(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);

		if (o == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name Major");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index Major on a nil value");
			}
		}

		CityInfo obj = (CityInfo)o;
		LuaScriptMgr.Push(L, obj.Major);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_Wise(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);

		if (o == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name Wise");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index Wise on a nil value");
			}
		}

		CityInfo obj = (CityInfo)o;
		LuaScriptMgr.Push(L, obj.Wise);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_Population(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);

		if (o == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name Population");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index Population on a nil value");
			}
		}

		CityInfo obj = (CityInfo)o;
		LuaScriptMgr.Push(L, obj.Population);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_Money(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);

		if (o == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name Money");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index Money on a nil value");
			}
		}

		CityInfo obj = (CityInfo)o;
		LuaScriptMgr.Push(L, obj.Money);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_Reservist(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);

		if (o == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name Reservist");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index Reservist on a nil value");
			}
		}

		CityInfo obj = (CityInfo)o;
		LuaScriptMgr.Push(L, obj.Reservist);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_ReservistMax(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);

		if (o == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name ReservistMax");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index ReservistMax on a nil value");
			}
		}

		CityInfo obj = (CityInfo)o;
		LuaScriptMgr.Push(L, obj.ReservistMax);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_Defense(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);

		if (o == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name Defense");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index Defense on a nil value");
			}
		}

		CityInfo obj = (CityInfo)o;
		LuaScriptMgr.Push(L, obj.Defense);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_Generals(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);

		if (o == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name Generals");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index Generals on a nil value");
			}
		}

		CityInfo obj = (CityInfo)o;
		LuaScriptMgr.PushObject(L, obj.Generals);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_Prisons(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);

		if (o == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name Prisons");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index Prisons on a nil value");
			}
		}

		CityInfo obj = (CityInfo)o;
		LuaScriptMgr.PushObject(L, obj.Prisons);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_Objects(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);

		if (o == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name Objects");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index Objects on a nil value");
			}
		}

		CityInfo obj = (CityInfo)o;
		LuaScriptMgr.PushObject(L, obj.Objects);
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

		CityInfo obj = (CityInfo)o;
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

		CityInfo obj = (CityInfo)o;
		obj.Name = LuaScriptMgr.GetString(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_KingID(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);

		if (o == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name KingID");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index KingID on a nil value");
			}
		}

		CityInfo obj = (CityInfo)o;
		obj.KingID = (int)LuaScriptMgr.GetNumber(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_Level(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);

		if (o == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name Level");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index Level on a nil value");
			}
		}

		CityInfo obj = (CityInfo)o;
		obj.Level = (int)LuaScriptMgr.GetNumber(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_Flag(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);

		if (o == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name Flag");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index Flag on a nil value");
			}
		}

		CityInfo obj = (CityInfo)o;
		obj.Flag = (int)LuaScriptMgr.GetNumber(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_GeneralMax(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);

		if (o == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name GeneralMax");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index GeneralMax on a nil value");
			}
		}

		CityInfo obj = (CityInfo)o;
		obj.GeneralMax = (int)LuaScriptMgr.GetNumber(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_Major(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);

		if (o == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name Major");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index Major on a nil value");
			}
		}

		CityInfo obj = (CityInfo)o;
		obj.Major = (int)LuaScriptMgr.GetNumber(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_Wise(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);

		if (o == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name Wise");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index Wise on a nil value");
			}
		}

		CityInfo obj = (CityInfo)o;
		obj.Wise = (int)LuaScriptMgr.GetNumber(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_Population(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);

		if (o == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name Population");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index Population on a nil value");
			}
		}

		CityInfo obj = (CityInfo)o;
		obj.Population = (int)LuaScriptMgr.GetNumber(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_Money(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);

		if (o == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name Money");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index Money on a nil value");
			}
		}

		CityInfo obj = (CityInfo)o;
		obj.Money = (int)LuaScriptMgr.GetNumber(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_Reservist(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);

		if (o == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name Reservist");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index Reservist on a nil value");
			}
		}

		CityInfo obj = (CityInfo)o;
		obj.Reservist = (int)LuaScriptMgr.GetNumber(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_ReservistMax(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);

		if (o == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name ReservistMax");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index ReservistMax on a nil value");
			}
		}

		CityInfo obj = (CityInfo)o;
		obj.ReservistMax = (int)LuaScriptMgr.GetNumber(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_Defense(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);

		if (o == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name Defense");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index Defense on a nil value");
			}
		}

		CityInfo obj = (CityInfo)o;
		obj.Defense = (int)LuaScriptMgr.GetNumber(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int AddGeneral(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 2);
		CityInfo obj = LuaScriptMgr.GetNetObject<CityInfo>(L, 1);
		int arg0 = (int)LuaScriptMgr.GetNumber(L, 2);
		obj.AddGeneral(arg0);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int RemoveGeneral(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 2);
		CityInfo obj = LuaScriptMgr.GetNetObject<CityInfo>(L, 1);
		int arg0 = (int)LuaScriptMgr.GetNumber(L, 2);
		obj.RemoveGeneral(arg0);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int AddPrison(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 2);
		CityInfo obj = LuaScriptMgr.GetNetObject<CityInfo>(L, 1);
		int arg0 = (int)LuaScriptMgr.GetNumber(L, 2);
		obj.AddPrison(arg0);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int RemovePrison(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 2);
		CityInfo obj = LuaScriptMgr.GetNetObject<CityInfo>(L, 1);
		int arg0 = (int)LuaScriptMgr.GetNumber(L, 2);
		obj.RemovePrison(arg0);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int AddObject(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 2);
		CityInfo obj = LuaScriptMgr.GetNetObject<CityInfo>(L, 1);
		int arg0 = (int)LuaScriptMgr.GetNumber(L, 2);
		obj.AddObject(arg0);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int RemoveObject(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 2);
		CityInfo obj = LuaScriptMgr.GetNetObject<CityInfo>(L, 1);
		int arg0 = (int)LuaScriptMgr.GetNumber(L, 2);
		obj.RemoveObject(arg0);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int FindMajor(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 1);
		CityInfo obj = LuaScriptMgr.GetNetObject<CityInfo>(L, 1);
		obj.FindMajor();
		return 0;
	}
}

