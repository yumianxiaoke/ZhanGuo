using System;
using LuaInterface;

public class WrapXMLDataThings
{
	public static LuaMethod[] regs = new LuaMethod[]
	{
		new LuaMethod("New", _CreateXMLDataThings),
		new LuaMethod("GetClassType", GetClassType),
	};

	static LuaField[] fields = new LuaField[]
	{
		new LuaField("ID", get_ID, set_ID),
		new LuaField("Name", get_Name, set_Name),
		new LuaField("Attribute", get_Attribute, set_Attribute),
		new LuaField("Type", get_Type, set_Type),
		new LuaField("WeaponType", get_WeaponType, set_WeaponType),
		new LuaField("WeaponObject", get_WeaponObject, set_WeaponObject),
		new LuaField("SearchType", get_SearchType, set_SearchType),
		new LuaField("Sort", get_Sort, set_Sort),
		new LuaField("Level", get_Level, set_Level),
		new LuaField("Sprite", get_Sprite, set_Sprite),
		new LuaField("Rate", get_Rate, set_Rate),
		new LuaField("Strength", get_Strength, set_Strength),
		new LuaField("Intellect", get_Intellect, set_Intellect),
		new LuaField("MaxHP", get_MaxHP, set_MaxHP),
		new LuaField("MaxMP", get_MaxMP, set_MaxMP),
		new LuaField("Force", get_Force, set_Force),
		new LuaField("Battle", get_Battle, set_Battle),
		new LuaField("Skill", get_Skill, set_Skill),
		new LuaField("Spirit", get_Spirit, set_Spirit),
		new LuaField("Speed", get_Speed, set_Speed),
		new LuaField("Loyal", get_Loyal, set_Loyal),
		new LuaField("Descript", get_Descript, set_Descript),
	};

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreateXMLDataThings(IntPtr L)
	{
		int count = LuaDLL.lua_gettop(L);

		if (count == 0)
		{
			XMLDataThings obj = new XMLDataThings();
			LuaScriptMgr.PushObject(L, obj);
			return 1;
		}
		else
		{
			LuaDLL.luaL_error(L, "invalid arguments to method: XMLDataThings.New");
		}

		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetClassType(IntPtr L)
	{
		LuaScriptMgr.Push(L, typeof(XMLDataThings));
		return 1;
	}

	public static void Register(IntPtr L)
	{
		LuaScriptMgr.RegisterLib(L, "XMLDataThings", typeof(XMLDataThings), regs, fields, "System.Object");
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

		XMLDataThings obj = (XMLDataThings)o;
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

		XMLDataThings obj = (XMLDataThings)o;
		LuaScriptMgr.Push(L, obj.Name);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_Attribute(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);

		if (o == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name Attribute");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index Attribute on a nil value");
			}
		}

		XMLDataThings obj = (XMLDataThings)o;
		LuaScriptMgr.Push(L, obj.Attribute);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_Type(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);

		if (o == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name Type");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index Type on a nil value");
			}
		}

		XMLDataThings obj = (XMLDataThings)o;
		LuaScriptMgr.Push(L, obj.Type);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_WeaponType(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);

		if (o == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name WeaponType");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index WeaponType on a nil value");
			}
		}

		XMLDataThings obj = (XMLDataThings)o;
		LuaScriptMgr.Push(L, obj.WeaponType);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_WeaponObject(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);

		if (o == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name WeaponObject");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index WeaponObject on a nil value");
			}
		}

		XMLDataThings obj = (XMLDataThings)o;
		LuaScriptMgr.Push(L, obj.WeaponObject);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_SearchType(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);

		if (o == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name SearchType");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index SearchType on a nil value");
			}
		}

		XMLDataThings obj = (XMLDataThings)o;
		LuaScriptMgr.Push(L, obj.SearchType);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_Sort(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);

		if (o == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name Sort");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index Sort on a nil value");
			}
		}

		XMLDataThings obj = (XMLDataThings)o;
		LuaScriptMgr.Push(L, obj.Sort);
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

		XMLDataThings obj = (XMLDataThings)o;
		LuaScriptMgr.Push(L, obj.Level);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_Sprite(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);

		if (o == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name Sprite");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index Sprite on a nil value");
			}
		}

		XMLDataThings obj = (XMLDataThings)o;
		LuaScriptMgr.Push(L, obj.Sprite);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_Rate(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);

		if (o == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name Rate");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index Rate on a nil value");
			}
		}

		XMLDataThings obj = (XMLDataThings)o;
		LuaScriptMgr.Push(L, obj.Rate);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_Strength(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);

		if (o == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name Strength");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index Strength on a nil value");
			}
		}

		XMLDataThings obj = (XMLDataThings)o;
		LuaScriptMgr.Push(L, obj.Strength);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_Intellect(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);

		if (o == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name Intellect");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index Intellect on a nil value");
			}
		}

		XMLDataThings obj = (XMLDataThings)o;
		LuaScriptMgr.Push(L, obj.Intellect);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_MaxHP(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);

		if (o == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name MaxHP");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index MaxHP on a nil value");
			}
		}

		XMLDataThings obj = (XMLDataThings)o;
		LuaScriptMgr.Push(L, obj.MaxHP);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_MaxMP(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);

		if (o == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name MaxMP");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index MaxMP on a nil value");
			}
		}

		XMLDataThings obj = (XMLDataThings)o;
		LuaScriptMgr.Push(L, obj.MaxMP);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_Force(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);

		if (o == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name Force");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index Force on a nil value");
			}
		}

		XMLDataThings obj = (XMLDataThings)o;
		LuaScriptMgr.Push(L, obj.Force);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_Battle(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);

		if (o == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name Battle");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index Battle on a nil value");
			}
		}

		XMLDataThings obj = (XMLDataThings)o;
		LuaScriptMgr.Push(L, obj.Battle);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_Skill(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);

		if (o == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name Skill");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index Skill on a nil value");
			}
		}

		XMLDataThings obj = (XMLDataThings)o;
		LuaScriptMgr.Push(L, obj.Skill);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_Spirit(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);

		if (o == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name Spirit");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index Spirit on a nil value");
			}
		}

		XMLDataThings obj = (XMLDataThings)o;
		LuaScriptMgr.Push(L, obj.Spirit);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_Speed(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);

		if (o == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name Speed");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index Speed on a nil value");
			}
		}

		XMLDataThings obj = (XMLDataThings)o;
		LuaScriptMgr.Push(L, obj.Speed);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_Loyal(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);

		if (o == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name Loyal");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index Loyal on a nil value");
			}
		}

		XMLDataThings obj = (XMLDataThings)o;
		LuaScriptMgr.Push(L, obj.Loyal);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_Descript(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);

		if (o == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name Descript");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index Descript on a nil value");
			}
		}

		XMLDataThings obj = (XMLDataThings)o;
		LuaScriptMgr.Push(L, obj.Descript);
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

		XMLDataThings obj = (XMLDataThings)o;
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

		XMLDataThings obj = (XMLDataThings)o;
		obj.Name = LuaScriptMgr.GetString(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_Attribute(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);

		if (o == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name Attribute");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index Attribute on a nil value");
			}
		}

		XMLDataThings obj = (XMLDataThings)o;
		obj.Attribute = LuaScriptMgr.GetString(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_Type(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);

		if (o == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name Type");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index Type on a nil value");
			}
		}

		XMLDataThings obj = (XMLDataThings)o;
		obj.Type = LuaScriptMgr.GetString(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_WeaponType(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);

		if (o == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name WeaponType");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index WeaponType on a nil value");
			}
		}

		XMLDataThings obj = (XMLDataThings)o;
		obj.WeaponType = (int)LuaScriptMgr.GetNumber(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_WeaponObject(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);

		if (o == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name WeaponObject");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index WeaponObject on a nil value");
			}
		}

		XMLDataThings obj = (XMLDataThings)o;
		obj.WeaponObject = (int)LuaScriptMgr.GetNumber(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_SearchType(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);

		if (o == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name SearchType");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index SearchType on a nil value");
			}
		}

		XMLDataThings obj = (XMLDataThings)o;
		obj.SearchType = (int)LuaScriptMgr.GetNumber(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_Sort(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);

		if (o == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name Sort");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index Sort on a nil value");
			}
		}

		XMLDataThings obj = (XMLDataThings)o;
		obj.Sort = (int)LuaScriptMgr.GetNumber(L, 3);
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

		XMLDataThings obj = (XMLDataThings)o;
		obj.Level = (int)LuaScriptMgr.GetNumber(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_Sprite(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);

		if (o == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name Sprite");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index Sprite on a nil value");
			}
		}

		XMLDataThings obj = (XMLDataThings)o;
		obj.Sprite = LuaScriptMgr.GetString(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_Rate(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);

		if (o == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name Rate");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index Rate on a nil value");
			}
		}

		XMLDataThings obj = (XMLDataThings)o;
		obj.Rate = (int)LuaScriptMgr.GetNumber(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_Strength(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);

		if (o == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name Strength");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index Strength on a nil value");
			}
		}

		XMLDataThings obj = (XMLDataThings)o;
		obj.Strength = (int)LuaScriptMgr.GetNumber(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_Intellect(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);

		if (o == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name Intellect");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index Intellect on a nil value");
			}
		}

		XMLDataThings obj = (XMLDataThings)o;
		obj.Intellect = (int)LuaScriptMgr.GetNumber(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_MaxHP(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);

		if (o == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name MaxHP");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index MaxHP on a nil value");
			}
		}

		XMLDataThings obj = (XMLDataThings)o;
		obj.MaxHP = (int)LuaScriptMgr.GetNumber(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_MaxMP(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);

		if (o == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name MaxMP");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index MaxMP on a nil value");
			}
		}

		XMLDataThings obj = (XMLDataThings)o;
		obj.MaxMP = (int)LuaScriptMgr.GetNumber(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_Force(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);

		if (o == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name Force");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index Force on a nil value");
			}
		}

		XMLDataThings obj = (XMLDataThings)o;
		obj.Force = (int)LuaScriptMgr.GetNumber(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_Battle(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);

		if (o == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name Battle");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index Battle on a nil value");
			}
		}

		XMLDataThings obj = (XMLDataThings)o;
		obj.Battle = (int)LuaScriptMgr.GetNumber(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_Skill(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);

		if (o == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name Skill");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index Skill on a nil value");
			}
		}

		XMLDataThings obj = (XMLDataThings)o;
		obj.Skill = (int)LuaScriptMgr.GetNumber(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_Spirit(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);

		if (o == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name Spirit");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index Spirit on a nil value");
			}
		}

		XMLDataThings obj = (XMLDataThings)o;
		obj.Spirit = (int)LuaScriptMgr.GetNumber(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_Speed(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);

		if (o == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name Speed");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index Speed on a nil value");
			}
		}

		XMLDataThings obj = (XMLDataThings)o;
		obj.Speed = (int)LuaScriptMgr.GetNumber(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_Loyal(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);

		if (o == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name Loyal");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index Loyal on a nil value");
			}
		}

		XMLDataThings obj = (XMLDataThings)o;
		obj.Loyal = (int)LuaScriptMgr.GetNumber(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_Descript(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);

		if (o == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name Descript");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index Descript on a nil value");
			}
		}

		XMLDataThings obj = (XMLDataThings)o;
		obj.Descript = LuaScriptMgr.GetString(L, 3);
		return 0;
	}
}

