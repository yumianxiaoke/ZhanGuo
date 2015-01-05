using System;
using LuaInterface;

public class WrapGamePublic
{
	public static LuaMethod[] regs = new LuaMethod[]
	{
		new LuaMethod("Initialize", Initialize),
		new LuaMethod("UnInitialize", UnInitialize),
		new LuaMethod("New", _CreateGamePublic),
		new LuaMethod("GetClassType", GetClassType),
	};

	static LuaField[] fields = new LuaField[]
	{
		new LuaField("Instance", get_Instance, null),
		new LuaField("GameStatesManager", get_GameStatesManager, null),
		new LuaField("SceneCamera", get_SceneCamera, null),
		new LuaField("SceneRoot", get_SceneRoot, null),
		new LuaField("UIRoot", get_UIRoot, null),
		new LuaField("LuaManager", get_LuaManager, null),
		new LuaField("LuaFiles", get_LuaFiles, null),
		new LuaField("DataManager", get_DataManager, null),
		new LuaField("ButtonPool", get_ButtonPool, null),
		new LuaField("TogglePool", get_TogglePool, null),
		new LuaField("TimesList", get_TimesList, null),
		new LuaField("CurrentTimes", get_CurrentTimes, set_CurrentTimes),
		new LuaField("CurrentYear", get_CurrentYear, set_CurrentYear),
		new LuaField("CurrentKing", get_CurrentKing, set_CurrentKing),
		new LuaField("CityPoint", get_CityPoint, null),
	};

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreateGamePublic(IntPtr L)
	{
		int count = LuaDLL.lua_gettop(L);

		if (count == 0)
		{
			GamePublic obj = new GamePublic();
			LuaScriptMgr.PushObject(L, obj);
			return 1;
		}
		else
		{
			LuaDLL.luaL_error(L, "invalid arguments to method: GamePublic.New");
		}

		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetClassType(IntPtr L)
	{
		LuaScriptMgr.Push(L, typeof(GamePublic));
		return 1;
	}

	public static void Register(IntPtr L)
	{
		LuaScriptMgr.RegisterLib(L, "GamePublic", typeof(GamePublic), regs, fields, "Singleton`1[GamePublic]");
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_Instance(IntPtr L)
	{
		LuaScriptMgr.PushObject(L, GamePublic.Instance);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_GameStatesManager(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);

		if (o == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name GameStatesManager");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index GameStatesManager on a nil value");
			}
		}

		GamePublic obj = (GamePublic)o;
		LuaScriptMgr.PushObject(L, obj.GameStatesManager);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_SceneCamera(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);

		if (o == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name SceneCamera");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index SceneCamera on a nil value");
			}
		}

		GamePublic obj = (GamePublic)o;
		LuaScriptMgr.Push(L, obj.SceneCamera);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_SceneRoot(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);

		if (o == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name SceneRoot");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index SceneRoot on a nil value");
			}
		}

		GamePublic obj = (GamePublic)o;
		LuaScriptMgr.Push(L, obj.SceneRoot);
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

		GamePublic obj = (GamePublic)o;
		LuaScriptMgr.Push(L, obj.UIRoot);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_LuaManager(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);

		if (o == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name LuaManager");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index LuaManager on a nil value");
			}
		}

		GamePublic obj = (GamePublic)o;
		LuaScriptMgr.PushObject(L, obj.LuaManager);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_LuaFiles(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);

		if (o == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name LuaFiles");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index LuaFiles on a nil value");
			}
		}

		GamePublic obj = (GamePublic)o;
		LuaScriptMgr.PushObject(L, obj.LuaFiles);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_DataManager(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);

		if (o == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name DataManager");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index DataManager on a nil value");
			}
		}

		GamePublic obj = (GamePublic)o;
		LuaScriptMgr.PushObject(L, obj.DataManager);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_ButtonPool(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);

		if (o == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name ButtonPool");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index ButtonPool on a nil value");
			}
		}

		GamePublic obj = (GamePublic)o;
		LuaScriptMgr.PushObject(L, obj.ButtonPool);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_TogglePool(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);

		if (o == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name TogglePool");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index TogglePool on a nil value");
			}
		}

		GamePublic obj = (GamePublic)o;
		LuaScriptMgr.PushObject(L, obj.TogglePool);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_TimesList(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);

		if (o == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name TimesList");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index TimesList on a nil value");
			}
		}

		GamePublic obj = (GamePublic)o;
		LuaScriptMgr.PushObject(L, obj.TimesList);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_CurrentTimes(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);

		if (o == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name CurrentTimes");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index CurrentTimes on a nil value");
			}
		}

		GamePublic obj = (GamePublic)o;
		LuaScriptMgr.Push(L, obj.CurrentTimes);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_CurrentYear(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);

		if (o == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name CurrentYear");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index CurrentYear on a nil value");
			}
		}

		GamePublic obj = (GamePublic)o;
		LuaScriptMgr.Push(L, obj.CurrentYear);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_CurrentKing(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);

		if (o == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name CurrentKing");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index CurrentKing on a nil value");
			}
		}

		GamePublic obj = (GamePublic)o;
		LuaScriptMgr.Push(L, obj.CurrentKing);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_CityPoint(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);

		if (o == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name CityPoint");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index CityPoint on a nil value");
			}
		}

		GamePublic obj = (GamePublic)o;
		LuaScriptMgr.PushObject(L, obj.CityPoint);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_CurrentTimes(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);

		if (o == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name CurrentTimes");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index CurrentTimes on a nil value");
			}
		}

		GamePublic obj = (GamePublic)o;
		obj.CurrentTimes = (int)LuaScriptMgr.GetNumber(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_CurrentYear(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);

		if (o == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name CurrentYear");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index CurrentYear on a nil value");
			}
		}

		GamePublic obj = (GamePublic)o;
		obj.CurrentYear = (int)LuaScriptMgr.GetNumber(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_CurrentKing(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);

		if (o == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name CurrentKing");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index CurrentKing on a nil value");
			}
		}

		GamePublic obj = (GamePublic)o;
		obj.CurrentKing = (int)LuaScriptMgr.GetNumber(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Initialize(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 1);
		GamePublic obj = LuaScriptMgr.GetNetObject<GamePublic>(L, 1);
		obj.Initialize();
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int UnInitialize(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 1);
		GamePublic obj = LuaScriptMgr.GetNetObject<GamePublic>(L, 1);
		obj.UnInitialize();
		return 0;
	}
}

