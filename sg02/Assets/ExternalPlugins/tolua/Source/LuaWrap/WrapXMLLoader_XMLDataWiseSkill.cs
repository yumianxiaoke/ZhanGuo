﻿using System;
using System.Reflection;
using System.Collections.Generic;
using LuaInterface;

public class WrapXMLLoader_XMLDataWiseSkill
{
	public static LuaMethod[] regs = new LuaMethod[]
	{
		new LuaMethod("LoadXML", LoadXML),
		new LuaMethod("GetInfoById", GetInfoById),
		new LuaMethod("GetInfoByName", GetInfoByName),
		new LuaMethod("ReflectionFields", ReflectionFields),
		new LuaMethod("New", _CreateXMLLoader_XMLDataWiseSkill),
		new LuaMethod("GetClassType", GetClassType),
	};

	static LuaField[] fields = new LuaField[]
	{
		new LuaField("Data", get_Data, null),
	};

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreateXMLLoader_XMLDataWiseSkill(IntPtr L)
	{
		int count = LuaDLL.lua_gettop(L);

		if (count == 1)
		{
			string arg0 = LuaScriptMgr.GetString(L, 1);
			XMLLoader<XMLDataWiseSkill> obj = new XMLLoader<XMLDataWiseSkill>(arg0);
			LuaScriptMgr.PushObject(L, obj);
			return 1;
		}
		else if (count == 2)
		{
			string arg0 = LuaScriptMgr.GetString(L, 1);
			string arg1 = LuaScriptMgr.GetString(L, 2);
			XMLLoader<XMLDataWiseSkill> obj = new XMLLoader<XMLDataWiseSkill>(arg0,arg1);
			LuaScriptMgr.PushObject(L, obj);
			return 1;
		}
		else
		{
			LuaDLL.luaL_error(L, "invalid arguments to method: XMLLoader<XMLDataWiseSkill>.New");
		}

		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetClassType(IntPtr L)
	{
		LuaScriptMgr.Push(L, typeof(XMLLoader<XMLDataWiseSkill>));
		return 1;
	}

	public static void Register(IntPtr L)
	{
		LuaScriptMgr.RegisterLib(L, "XMLLoader<XMLDataWiseSkill>", typeof(XMLLoader<XMLDataWiseSkill>), regs, fields, "System.Object");
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_Data(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);

		if (o == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name Data");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index Data on a nil value");
			}
		}

		XMLLoader<XMLDataWiseSkill> obj = (XMLLoader<XMLDataWiseSkill>)o;
		LuaScriptMgr.PushObject(L, obj.Data);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int LoadXML(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 2);
		XMLLoader<XMLDataWiseSkill> obj = LuaScriptMgr.GetNetObject<XMLLoader<XMLDataWiseSkill>>(L, 1);
		string arg0 = LuaScriptMgr.GetLuaString(L, 2);
		obj.LoadXML(arg0);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetInfoById(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 2);
		XMLLoader<XMLDataWiseSkill> obj = LuaScriptMgr.GetNetObject<XMLLoader<XMLDataWiseSkill>>(L, 1);
		int arg0 = (int)LuaScriptMgr.GetNumber(L, 2);
		XMLDataWiseSkill o = obj.GetInfoById(arg0);
		LuaScriptMgr.PushObject(L, o);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetInfoByName(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 2);
		XMLLoader<XMLDataWiseSkill> obj = LuaScriptMgr.GetNetObject<XMLLoader<XMLDataWiseSkill>>(L, 1);
		string arg0 = LuaScriptMgr.GetLuaString(L, 2);
		XMLDataWiseSkill o = obj.GetInfoByName(arg0);
		LuaScriptMgr.PushObject(L, o);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int ReflectionFields(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 2);
		XMLLoader<XMLDataWiseSkill> obj = LuaScriptMgr.GetNetObject<XMLLoader<XMLDataWiseSkill>>(L, 1);
		Type arg0 = LuaScriptMgr.GetTypeObject(L, 2);
		IDictionary<string,FieldInfo> o = obj.ReflectionFields(arg0);
		LuaScriptMgr.PushObject(L, o);
		return 1;
	}
}

