using System;
using LuaInterface;

public class WrapTimerManager
{
	public static LuaMethod[] regs = new LuaMethod[]
	{
		new LuaMethod("UnInitialize", UnInitialize),
		new LuaMethod("Update", Update),
		new LuaMethod("WaitForSeconds", WaitForSeconds),
		new LuaMethod("WaitForEndOfFrame", WaitForEndOfFrame),
		new LuaMethod("WaitEndOfFrame", WaitEndOfFrame),
		new LuaMethod("Yield", Yield),
		new LuaMethod("AddTimer", AddTimer),
		new LuaMethod("Stop", Stop),
		new LuaMethod("New", _CreateTimerManager),
		new LuaMethod("GetClassType", GetClassType),
	};

	static LuaField[] fields = new LuaField[]
	{
		new LuaField("Instance", get_Instance, null),
	};

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreateTimerManager(IntPtr L)
	{
		LuaDLL.luaL_error(L, "TimerManager class does not have a constructor function");
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetClassType(IntPtr L)
	{
		LuaScriptMgr.Push(L, typeof(TimerManager));
		return 1;
	}

	public static void Register(IntPtr L)
	{
		LuaScriptMgr.RegisterLib(L, "TimerManager", typeof(TimerManager), regs, fields, "UnityEngine.MonoBehaviour");
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_Instance(IntPtr L)
	{
		LuaScriptMgr.Push(L, TimerManager.Instance);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int UnInitialize(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 1);
		TimerManager obj = LuaScriptMgr.GetNetObject<TimerManager>(L, 1);
		obj.UnInitialize();
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Update(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 1);
		TimerManager obj = LuaScriptMgr.GetNetObject<TimerManager>(L, 1);
		obj.Update();
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int WaitForSeconds(IntPtr L)
	{
		int count = LuaDLL.lua_gettop(L);

		Type[] types1 = {typeof(TimerManager), typeof(float), typeof(LuaInterface.LuaFunction)};
		Type[] types2 = {typeof(TimerManager), typeof(float), typeof(CallbackWithParam)};

		if (count == 3)
		{
			TimerManager obj = LuaScriptMgr.GetNetObject<TimerManager>(L, 1);
			float arg0 = (float)LuaScriptMgr.GetNumber(L, 2);
			Callback arg1 = LuaScriptMgr.GetNetObject<Callback>(L, 3);
			Timer o = obj.WaitForSeconds(arg0,arg1);
			LuaScriptMgr.PushObject(L, o);
			return 1;
		}
		else if (LuaScriptMgr.CheckTypes(L, types1, 1) && LuaScriptMgr.CheckParamsType(L, typeof(object), 4, count - 3))
		{
			TimerManager obj = LuaScriptMgr.GetNetObject<TimerManager>(L, 1);
			float arg0 = (float)LuaScriptMgr.GetNumber(L, 2);
			LuaFunction arg1 = LuaScriptMgr.GetLuaFunction(L, 3);
			object[] objs2 = LuaScriptMgr.GetParamsObject(L, 4, count - 3);
			Timer o = obj.WaitForSeconds(arg0,arg1,objs2);
			LuaScriptMgr.PushObject(L, o);
			return 1;
		}
		else if (LuaScriptMgr.CheckTypes(L, types2, 1) && LuaScriptMgr.CheckParamsType(L, typeof(object), 4, count - 3))
		{
			TimerManager obj = LuaScriptMgr.GetNetObject<TimerManager>(L, 1);
			float arg0 = (float)LuaScriptMgr.GetNumber(L, 2);
			CallbackWithParam arg1 = LuaScriptMgr.GetNetObject<CallbackWithParam>(L, 3);
			object[] objs2 = LuaScriptMgr.GetParamsObject(L, 4, count - 3);
			Timer o = obj.WaitForSeconds(arg0,arg1,objs2);
			LuaScriptMgr.PushObject(L, o);
			return 1;
		}
		else
		{
			LuaDLL.luaL_error(L, "invalid arguments to method: TimerManager.WaitForSeconds");
		}

		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int WaitForEndOfFrame(IntPtr L)
	{
		int count = LuaDLL.lua_gettop(L);

		Type[] types1 = {typeof(TimerManager), typeof(LuaInterface.LuaFunction)};
		Type[] types2 = {typeof(TimerManager), typeof(CallbackWithParam)};

		if (count == 2)
		{
			TimerManager obj = LuaScriptMgr.GetNetObject<TimerManager>(L, 1);
			Callback arg0 = LuaScriptMgr.GetNetObject<Callback>(L, 2);
			obj.WaitForEndOfFrame(arg0);
			return 0;
		}
		else if (LuaScriptMgr.CheckTypes(L, types1, 1) && LuaScriptMgr.CheckParamsType(L, typeof(object), 3, count - 2))
		{
			TimerManager obj = LuaScriptMgr.GetNetObject<TimerManager>(L, 1);
			LuaFunction arg0 = LuaScriptMgr.GetLuaFunction(L, 2);
			object[] objs1 = LuaScriptMgr.GetParamsObject(L, 3, count - 2);
			obj.WaitForEndOfFrame(arg0,objs1);
			return 0;
		}
		else if (LuaScriptMgr.CheckTypes(L, types2, 1) && LuaScriptMgr.CheckParamsType(L, typeof(object), 3, count - 2))
		{
			TimerManager obj = LuaScriptMgr.GetNetObject<TimerManager>(L, 1);
			CallbackWithParam arg0 = LuaScriptMgr.GetNetObject<CallbackWithParam>(L, 2);
			object[] objs1 = LuaScriptMgr.GetParamsObject(L, 3, count - 2);
			obj.WaitForEndOfFrame(arg0,objs1);
			return 0;
		}
		else
		{
			LuaDLL.luaL_error(L, "invalid arguments to method: TimerManager.WaitForEndOfFrame");
		}

		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int WaitEndOfFrame(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 2);
		TimerManager obj = LuaScriptMgr.GetNetObject<TimerManager>(L, 1);
		Action arg0 = LuaScriptMgr.GetNetObject<Action>(L, 2);
		obj.WaitEndOfFrame(arg0);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Yield(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 3);
		TimerManager obj = LuaScriptMgr.GetNetObject<TimerManager>(L, 1);
		int arg0 = (int)LuaScriptMgr.GetNumber(L, 2);
		Action arg1 = LuaScriptMgr.GetNetObject<Action>(L, 3);
		obj.Yield(arg0,arg1);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int AddTimer(IntPtr L)
	{
		int count = LuaDLL.lua_gettop(L);

		Type[] types0 = {typeof(TimerManager), typeof(float), typeof(int), typeof(bool), typeof(Action)};
		Type[] types1 = {typeof(TimerManager), typeof(float), typeof(int), typeof(bool), typeof(Callback)};
		Type[] types2 = {typeof(TimerManager), typeof(float), typeof(int), typeof(bool), typeof(LuaInterface.LuaFunction)};
		Type[] types3 = {typeof(TimerManager), typeof(float), typeof(int), typeof(bool), typeof(CallbackWithParam), typeof(object[])};

		if (count == 5 && LuaScriptMgr.CheckTypes(L, types0, 1))
		{
			TimerManager obj = LuaScriptMgr.GetNetObject<TimerManager>(L, 1);
			float arg0 = (float)LuaScriptMgr.GetNumber(L, 2);
			int arg1 = (int)LuaScriptMgr.GetNumber(L, 3);
			bool arg2 = LuaScriptMgr.GetBoolean(L, 4);
			Action arg3 = LuaScriptMgr.GetNetObject<Action>(L, 5);
			Timer o = obj.AddTimer(arg0,arg1,arg2,arg3);
			LuaScriptMgr.PushObject(L, o);
			return 1;
		}
		else if (count == 5 && LuaScriptMgr.CheckTypes(L, types1, 1))
		{
			TimerManager obj = LuaScriptMgr.GetNetObject<TimerManager>(L, 1);
			float arg0 = (float)LuaScriptMgr.GetNumber(L, 2);
			int arg1 = (int)LuaScriptMgr.GetNumber(L, 3);
			bool arg2 = LuaScriptMgr.GetBoolean(L, 4);
			Callback arg3 = LuaScriptMgr.GetNetObject<Callback>(L, 5);
			Timer o = obj.AddTimer(arg0,arg1,arg2,arg3);
			LuaScriptMgr.PushObject(L, o);
			return 1;
		}
		else if (LuaScriptMgr.CheckTypes(L, types2, 1) && LuaScriptMgr.CheckParamsType(L, typeof(object), 6, count - 5))
		{
			TimerManager obj = LuaScriptMgr.GetNetObject<TimerManager>(L, 1);
			float arg0 = (float)LuaScriptMgr.GetNumber(L, 2);
			int arg1 = (int)LuaScriptMgr.GetNumber(L, 3);
			bool arg2 = LuaScriptMgr.GetBoolean(L, 4);
			LuaFunction arg3 = LuaScriptMgr.GetLuaFunction(L, 5);
			object[] objs4 = LuaScriptMgr.GetParamsObject(L, 6, count - 5);
			Timer o = obj.AddTimer(arg0,arg1,arg2,arg3,objs4);
			LuaScriptMgr.PushObject(L, o);
			return 1;
		}
		else if (count == 6 && LuaScriptMgr.CheckTypes(L, types3, 1))
		{
			TimerManager obj = LuaScriptMgr.GetNetObject<TimerManager>(L, 1);
			float arg0 = (float)LuaScriptMgr.GetNumber(L, 2);
			int arg1 = (int)LuaScriptMgr.GetNumber(L, 3);
			bool arg2 = LuaScriptMgr.GetBoolean(L, 4);
			CallbackWithParam arg3 = LuaScriptMgr.GetNetObject<CallbackWithParam>(L, 5);
			object[] objs4 = LuaScriptMgr.GetArrayObject<object>(L, 6);
			Timer o = obj.AddTimer(arg0,arg1,arg2,arg3,objs4);
			LuaScriptMgr.PushObject(L, o);
			return 1;
		}
		else
		{
			LuaDLL.luaL_error(L, "invalid arguments to method: TimerManager.AddTimer");
		}

		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Stop(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 2);
		TimerManager obj = LuaScriptMgr.GetNetObject<TimerManager>(L, 1);
		Timer arg0 = LuaScriptMgr.GetNetObject<Timer>(L, 2);
		obj.Stop(arg0);
		return 0;
	}
}

