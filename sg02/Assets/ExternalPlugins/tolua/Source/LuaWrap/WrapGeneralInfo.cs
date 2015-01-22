using System;
using UnityEngine;
using LuaInterface;
using Object = UnityEngine.Object;

public class WrapGeneralInfo
{
	public static LuaMethod[] regs = new LuaMethod[]
	{
		new LuaMethod("SetFace", SetFace),
		new LuaMethod("New", _CreateGeneralInfo),
		new LuaMethod("GetClassType", GetClassType),
	};

	static LuaField[] fields = new LuaField[]
	{
		new LuaField("State", get_State, set_State),
		new LuaField("ID", get_ID, set_ID),
		new LuaField("Name", get_Name, set_Name),
		new LuaField("Face", get_Face, set_Face),
		new LuaField("KingID", get_KingID, set_KingID),
		new LuaField("CityID", get_CityID, set_CityID),
		new LuaField("PrisonerID", get_PrisonerID, set_PrisonerID),
		new LuaField("Loyalty", get_Loyalty, set_Loyalty),
		new LuaField("Skill", get_Skill, set_Skill),
		new LuaField("SkillLevel", get_SkillLevel, set_SkillLevel),
		new LuaField("WiseSkill", get_WiseSkill, set_WiseSkill),
		new LuaField("WiseSkillLevel", get_WiseSkillLevel, set_WiseSkillLevel),
		new LuaField("Title", get_Title, set_Title),
		new LuaField("Strength", get_Strength, set_Strength),
		new LuaField("Intellect", get_Intellect, set_Intellect),
		new LuaField("Experience", get_Experience, set_Experience),
		new LuaField("Level", get_Level, set_Level),
		new LuaField("BaseHP", get_BaseHP, set_BaseHP),
		new LuaField("CurHP", get_CurHP, set_CurHP),
		new LuaField("BaseMP", get_BaseMP, set_BaseMP),
		new LuaField("CurMP", get_CurMP, set_CurMP),
		new LuaField("SoldierMax", get_SoldierMax, set_SoldierMax),
		new LuaField("SoldierCur", get_SoldierCur, set_SoldierCur),
		new LuaField("KnightMax", get_KnightMax, set_KnightMax),
		new LuaField("KnightCur", get_KnightCur, set_KnightCur),
		new LuaField("ForceArray", get_ForceArray, set_ForceArray),
		new LuaField("UseForce", get_UseForce, set_UseForce),
		new LuaField("BattleArray", get_BattleArray, set_BattleArray),
		new LuaField("UseBattle", get_UseBattle, set_UseBattle),
		new LuaField("Weapon", get_Weapon, set_Weapon),
		new LuaField("Horse", get_Horse, set_Horse),
		new LuaField("Thing", get_Thing, set_Thing),
		new LuaField("Escape", get_Escape, set_Escape),
		new LuaField("DPWin", get_DPWin, set_DPWin),
		new LuaField("DPLose", get_DPLose, set_DPLose),
	};

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreateGeneralInfo(IntPtr L)
	{
		int count = LuaDLL.lua_gettop(L);

		if (count == 0)
		{
			GeneralInfo obj = new GeneralInfo();
			LuaScriptMgr.PushObject(L, obj);
			return 1;
		}
		else if (count == 1)
		{
			int arg0 = (int)LuaScriptMgr.GetNumber(L, 1);
			GeneralInfo obj = new GeneralInfo(arg0);
			LuaScriptMgr.PushObject(L, obj);
			return 1;
		}
		else
		{
			LuaDLL.luaL_error(L, "invalid arguments to method: GeneralInfo.New");
		}

		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetClassType(IntPtr L)
	{
		LuaScriptMgr.Push(L, typeof(GeneralInfo));
		return 1;
	}

	public static void Register(IntPtr L)
	{
		LuaScriptMgr.RegisterLib(L, "GeneralInfo", typeof(GeneralInfo), regs, fields, "System.Object");
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_State(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);

		if (o == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name State");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index State on a nil value");
			}
		}

		GeneralInfo obj = (GeneralInfo)o;
		LuaScriptMgr.Push(L, obj.State);
		return 1;
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

		GeneralInfo obj = (GeneralInfo)o;
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

		GeneralInfo obj = (GeneralInfo)o;
		LuaScriptMgr.Push(L, obj.Name);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_Face(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);

		if (o == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name Face");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index Face on a nil value");
			}
		}

		GeneralInfo obj = (GeneralInfo)o;
		LuaScriptMgr.Push(L, obj.Face);
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

		GeneralInfo obj = (GeneralInfo)o;
		LuaScriptMgr.Push(L, obj.KingID);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_CityID(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);

		if (o == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name CityID");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index CityID on a nil value");
			}
		}

		GeneralInfo obj = (GeneralInfo)o;
		LuaScriptMgr.Push(L, obj.CityID);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_PrisonerID(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);

		if (o == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name PrisonerID");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index PrisonerID on a nil value");
			}
		}

		GeneralInfo obj = (GeneralInfo)o;
		LuaScriptMgr.Push(L, obj.PrisonerID);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_Loyalty(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);

		if (o == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name Loyalty");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index Loyalty on a nil value");
			}
		}

		GeneralInfo obj = (GeneralInfo)o;
		LuaScriptMgr.Push(L, obj.Loyalty);
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

		GeneralInfo obj = (GeneralInfo)o;
		LuaScriptMgr.PushArray(L, obj.Skill);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_SkillLevel(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);

		if (o == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name SkillLevel");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index SkillLevel on a nil value");
			}
		}

		GeneralInfo obj = (GeneralInfo)o;
		LuaScriptMgr.PushArray(L, obj.SkillLevel);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_WiseSkill(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);

		if (o == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name WiseSkill");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index WiseSkill on a nil value");
			}
		}

		GeneralInfo obj = (GeneralInfo)o;
		LuaScriptMgr.PushArray(L, obj.WiseSkill);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_WiseSkillLevel(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);

		if (o == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name WiseSkillLevel");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index WiseSkillLevel on a nil value");
			}
		}

		GeneralInfo obj = (GeneralInfo)o;
		LuaScriptMgr.PushArray(L, obj.WiseSkillLevel);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_Title(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);

		if (o == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name Title");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index Title on a nil value");
			}
		}

		GeneralInfo obj = (GeneralInfo)o;
		LuaScriptMgr.Push(L, obj.Title);
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

		GeneralInfo obj = (GeneralInfo)o;
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

		GeneralInfo obj = (GeneralInfo)o;
		LuaScriptMgr.Push(L, obj.Intellect);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_Experience(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);

		if (o == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name Experience");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index Experience on a nil value");
			}
		}

		GeneralInfo obj = (GeneralInfo)o;
		LuaScriptMgr.Push(L, obj.Experience);
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

		GeneralInfo obj = (GeneralInfo)o;
		LuaScriptMgr.Push(L, obj.Level);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_BaseHP(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);

		if (o == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name BaseHP");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index BaseHP on a nil value");
			}
		}

		GeneralInfo obj = (GeneralInfo)o;
		LuaScriptMgr.Push(L, obj.BaseHP);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_CurHP(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);

		if (o == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name CurHP");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index CurHP on a nil value");
			}
		}

		GeneralInfo obj = (GeneralInfo)o;
		LuaScriptMgr.Push(L, obj.CurHP);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_BaseMP(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);

		if (o == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name BaseMP");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index BaseMP on a nil value");
			}
		}

		GeneralInfo obj = (GeneralInfo)o;
		LuaScriptMgr.Push(L, obj.BaseMP);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_CurMP(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);

		if (o == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name CurMP");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index CurMP on a nil value");
			}
		}

		GeneralInfo obj = (GeneralInfo)o;
		LuaScriptMgr.Push(L, obj.CurMP);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_SoldierMax(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);

		if (o == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name SoldierMax");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index SoldierMax on a nil value");
			}
		}

		GeneralInfo obj = (GeneralInfo)o;
		LuaScriptMgr.Push(L, obj.SoldierMax);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_SoldierCur(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);

		if (o == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name SoldierCur");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index SoldierCur on a nil value");
			}
		}

		GeneralInfo obj = (GeneralInfo)o;
		LuaScriptMgr.Push(L, obj.SoldierCur);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_KnightMax(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);

		if (o == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name KnightMax");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index KnightMax on a nil value");
			}
		}

		GeneralInfo obj = (GeneralInfo)o;
		LuaScriptMgr.Push(L, obj.KnightMax);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_KnightCur(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);

		if (o == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name KnightCur");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index KnightCur on a nil value");
			}
		}

		GeneralInfo obj = (GeneralInfo)o;
		LuaScriptMgr.Push(L, obj.KnightCur);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_ForceArray(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);

		if (o == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name ForceArray");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index ForceArray on a nil value");
			}
		}

		GeneralInfo obj = (GeneralInfo)o;
		LuaScriptMgr.Push(L, obj.ForceArray);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_UseForce(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);

		if (o == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name UseForce");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index UseForce on a nil value");
			}
		}

		GeneralInfo obj = (GeneralInfo)o;
		LuaScriptMgr.Push(L, obj.UseForce);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_BattleArray(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);

		if (o == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name BattleArray");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index BattleArray on a nil value");
			}
		}

		GeneralInfo obj = (GeneralInfo)o;
		LuaScriptMgr.Push(L, obj.BattleArray);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_UseBattle(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);

		if (o == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name UseBattle");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index UseBattle on a nil value");
			}
		}

		GeneralInfo obj = (GeneralInfo)o;
		LuaScriptMgr.Push(L, obj.UseBattle);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_Weapon(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);

		if (o == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name Weapon");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index Weapon on a nil value");
			}
		}

		GeneralInfo obj = (GeneralInfo)o;
		LuaScriptMgr.Push(L, obj.Weapon);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_Horse(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);

		if (o == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name Horse");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index Horse on a nil value");
			}
		}

		GeneralInfo obj = (GeneralInfo)o;
		LuaScriptMgr.Push(L, obj.Horse);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_Thing(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);

		if (o == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name Thing");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index Thing on a nil value");
			}
		}

		GeneralInfo obj = (GeneralInfo)o;
		LuaScriptMgr.Push(L, obj.Thing);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_Escape(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);

		if (o == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name Escape");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index Escape on a nil value");
			}
		}

		GeneralInfo obj = (GeneralInfo)o;
		LuaScriptMgr.Push(L, obj.Escape);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_DPWin(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);

		if (o == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name DPWin");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index DPWin on a nil value");
			}
		}

		GeneralInfo obj = (GeneralInfo)o;
		LuaScriptMgr.Push(L, obj.DPWin);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_DPLose(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);

		if (o == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name DPLose");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index DPLose on a nil value");
			}
		}

		GeneralInfo obj = (GeneralInfo)o;
		LuaScriptMgr.Push(L, obj.DPLose);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_State(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);

		if (o == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name State");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index State on a nil value");
			}
		}

		GeneralInfo obj = (GeneralInfo)o;
		obj.State = (int)LuaScriptMgr.GetNumber(L, 3);
		return 0;
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

		GeneralInfo obj = (GeneralInfo)o;
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

		GeneralInfo obj = (GeneralInfo)o;
		obj.Name = LuaScriptMgr.GetString(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_Face(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);

		if (o == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name Face");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index Face on a nil value");
			}
		}

		GeneralInfo obj = (GeneralInfo)o;
		obj.Face = LuaScriptMgr.GetString(L, 3);
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

		GeneralInfo obj = (GeneralInfo)o;
		obj.KingID = (int)LuaScriptMgr.GetNumber(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_CityID(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);

		if (o == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name CityID");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index CityID on a nil value");
			}
		}

		GeneralInfo obj = (GeneralInfo)o;
		obj.CityID = (int)LuaScriptMgr.GetNumber(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_PrisonerID(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);

		if (o == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name PrisonerID");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index PrisonerID on a nil value");
			}
		}

		GeneralInfo obj = (GeneralInfo)o;
		obj.PrisonerID = (int)LuaScriptMgr.GetNumber(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_Loyalty(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);

		if (o == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name Loyalty");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index Loyalty on a nil value");
			}
		}

		GeneralInfo obj = (GeneralInfo)o;
		obj.Loyalty = (int)LuaScriptMgr.GetNumber(L, 3);
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

		GeneralInfo obj = (GeneralInfo)o;
		obj.Skill = LuaScriptMgr.GetNetObject<Int32[]>(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_SkillLevel(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);

		if (o == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name SkillLevel");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index SkillLevel on a nil value");
			}
		}

		GeneralInfo obj = (GeneralInfo)o;
		obj.SkillLevel = LuaScriptMgr.GetNetObject<Int32[]>(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_WiseSkill(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);

		if (o == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name WiseSkill");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index WiseSkill on a nil value");
			}
		}

		GeneralInfo obj = (GeneralInfo)o;
		obj.WiseSkill = LuaScriptMgr.GetNetObject<Int32[]>(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_WiseSkillLevel(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);

		if (o == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name WiseSkillLevel");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index WiseSkillLevel on a nil value");
			}
		}

		GeneralInfo obj = (GeneralInfo)o;
		obj.WiseSkillLevel = LuaScriptMgr.GetNetObject<Int32[]>(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_Title(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);

		if (o == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name Title");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index Title on a nil value");
			}
		}

		GeneralInfo obj = (GeneralInfo)o;
		obj.Title = (int)LuaScriptMgr.GetNumber(L, 3);
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

		GeneralInfo obj = (GeneralInfo)o;
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

		GeneralInfo obj = (GeneralInfo)o;
		obj.Intellect = (int)LuaScriptMgr.GetNumber(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_Experience(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);

		if (o == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name Experience");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index Experience on a nil value");
			}
		}

		GeneralInfo obj = (GeneralInfo)o;
		obj.Experience = (int)LuaScriptMgr.GetNumber(L, 3);
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

		GeneralInfo obj = (GeneralInfo)o;
		obj.Level = (int)LuaScriptMgr.GetNumber(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_BaseHP(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);

		if (o == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name BaseHP");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index BaseHP on a nil value");
			}
		}

		GeneralInfo obj = (GeneralInfo)o;
		obj.BaseHP = (int)LuaScriptMgr.GetNumber(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_CurHP(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);

		if (o == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name CurHP");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index CurHP on a nil value");
			}
		}

		GeneralInfo obj = (GeneralInfo)o;
		obj.CurHP = (int)LuaScriptMgr.GetNumber(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_BaseMP(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);

		if (o == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name BaseMP");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index BaseMP on a nil value");
			}
		}

		GeneralInfo obj = (GeneralInfo)o;
		obj.BaseMP = (int)LuaScriptMgr.GetNumber(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_CurMP(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);

		if (o == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name CurMP");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index CurMP on a nil value");
			}
		}

		GeneralInfo obj = (GeneralInfo)o;
		obj.CurMP = (int)LuaScriptMgr.GetNumber(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_SoldierMax(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);

		if (o == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name SoldierMax");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index SoldierMax on a nil value");
			}
		}

		GeneralInfo obj = (GeneralInfo)o;
		obj.SoldierMax = (int)LuaScriptMgr.GetNumber(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_SoldierCur(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);

		if (o == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name SoldierCur");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index SoldierCur on a nil value");
			}
		}

		GeneralInfo obj = (GeneralInfo)o;
		obj.SoldierCur = (int)LuaScriptMgr.GetNumber(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_KnightMax(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);

		if (o == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name KnightMax");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index KnightMax on a nil value");
			}
		}

		GeneralInfo obj = (GeneralInfo)o;
		obj.KnightMax = (int)LuaScriptMgr.GetNumber(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_KnightCur(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);

		if (o == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name KnightCur");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index KnightCur on a nil value");
			}
		}

		GeneralInfo obj = (GeneralInfo)o;
		obj.KnightCur = (int)LuaScriptMgr.GetNumber(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_ForceArray(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);

		if (o == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name ForceArray");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index ForceArray on a nil value");
			}
		}

		GeneralInfo obj = (GeneralInfo)o;
		obj.ForceArray = (int)LuaScriptMgr.GetNumber(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_UseForce(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);

		if (o == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name UseForce");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index UseForce on a nil value");
			}
		}

		GeneralInfo obj = (GeneralInfo)o;
		obj.UseForce = (int)LuaScriptMgr.GetNumber(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_BattleArray(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);

		if (o == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name BattleArray");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index BattleArray on a nil value");
			}
		}

		GeneralInfo obj = (GeneralInfo)o;
		obj.BattleArray = (int)LuaScriptMgr.GetNumber(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_UseBattle(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);

		if (o == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name UseBattle");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index UseBattle on a nil value");
			}
		}

		GeneralInfo obj = (GeneralInfo)o;
		obj.UseBattle = (int)LuaScriptMgr.GetNumber(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_Weapon(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);

		if (o == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name Weapon");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index Weapon on a nil value");
			}
		}

		GeneralInfo obj = (GeneralInfo)o;
		obj.Weapon = (int)LuaScriptMgr.GetNumber(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_Horse(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);

		if (o == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name Horse");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index Horse on a nil value");
			}
		}

		GeneralInfo obj = (GeneralInfo)o;
		obj.Horse = (int)LuaScriptMgr.GetNumber(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_Thing(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);

		if (o == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name Thing");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index Thing on a nil value");
			}
		}

		GeneralInfo obj = (GeneralInfo)o;
		obj.Thing = (int)LuaScriptMgr.GetNumber(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_Escape(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);

		if (o == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name Escape");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index Escape on a nil value");
			}
		}

		GeneralInfo obj = (GeneralInfo)o;
		obj.Escape = (int)LuaScriptMgr.GetNumber(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_DPWin(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);

		if (o == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name DPWin");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index DPWin on a nil value");
			}
		}

		GeneralInfo obj = (GeneralInfo)o;
		obj.DPWin = (int)LuaScriptMgr.GetNumber(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_DPLose(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);

		if (o == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name DPLose");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index DPLose on a nil value");
			}
		}

		GeneralInfo obj = (GeneralInfo)o;
		obj.DPLose = (int)LuaScriptMgr.GetNumber(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SetFace(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 2);
		GeneralInfo obj = LuaScriptMgr.GetNetObject<GeneralInfo>(L, 1);
		GameObject arg0 = LuaScriptMgr.GetNetObject<GameObject>(L, 2);
		obj.SetFace(arg0);
		return 0;
	}
}

