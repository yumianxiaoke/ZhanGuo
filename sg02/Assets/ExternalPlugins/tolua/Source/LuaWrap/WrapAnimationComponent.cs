using System;
using LuaInterface;

public class WrapAnimationComponent
{
	public static LuaMethod[] regs = new LuaMethod[]
	{
		new LuaMethod("PlayAnimation", PlayAnimation),
		new LuaMethod("Pause", Pause),
		new LuaMethod("Resume", Resume),
		new LuaMethod("New", _CreateAnimationComponent),
		new LuaMethod("GetClassType", GetClassType),
	};

	static LuaField[] fields = new LuaField[]
	{
		new LuaField("animName", get_animName, null),
		new LuaField("isPlaying", get_isPlaying, null),
		new LuaField("isPause", get_isPause, null),
		new LuaField("animIndex", get_animIndex, null),
	};

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreateAnimationComponent(IntPtr L)
	{
		LuaDLL.luaL_error(L, "AnimationComponent class does not have a constructor function");
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetClassType(IntPtr L)
	{
		LuaScriptMgr.Push(L, typeof(AnimationComponent));
		return 1;
	}

	public static void Register(IntPtr L)
	{
		LuaScriptMgr.RegisterLib(L, "AnimationComponent", typeof(AnimationComponent), regs, fields, "UnityEngine.MonoBehaviour");
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_animName(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);

		if (o == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name animName");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index animName on a nil value");
			}
		}

		AnimationComponent obj = (AnimationComponent)o;
		LuaScriptMgr.Push(L, obj.animName);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_isPlaying(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);

		if (o == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name isPlaying");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index isPlaying on a nil value");
			}
		}

		AnimationComponent obj = (AnimationComponent)o;
		LuaScriptMgr.Push(L, obj.isPlaying);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_isPause(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);

		if (o == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name isPause");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index isPause on a nil value");
			}
		}

		AnimationComponent obj = (AnimationComponent)o;
		LuaScriptMgr.Push(L, obj.isPause);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_animIndex(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);

		if (o == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name animIndex");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index animIndex on a nil value");
			}
		}

		AnimationComponent obj = (AnimationComponent)o;
		LuaScriptMgr.Push(L, obj.animIndex);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int PlayAnimation(IntPtr L)
	{
		int count = LuaDLL.lua_gettop(L);

		Type[] types1 = {typeof(AnimationComponent), typeof(string), typeof(LuaInterface.LuaFunction)};
		Type[] types2 = {typeof(AnimationComponent), typeof(string), typeof(Callback)};

		if (count == 2)
		{
			AnimationComponent obj = LuaScriptMgr.GetNetObject<AnimationComponent>(L, 1);
			string arg0 = LuaScriptMgr.GetLuaString(L, 2);
			obj.PlayAnimation(arg0);
			return 0;
		}
		else if (count == 3 && LuaScriptMgr.CheckTypes(L, types1, 1))
		{
			AnimationComponent obj = LuaScriptMgr.GetNetObject<AnimationComponent>(L, 1);
			string arg0 = LuaScriptMgr.GetString(L, 2);
			LuaFunction arg1 = LuaScriptMgr.GetLuaFunction(L, 3);
			obj.PlayAnimation(arg0,arg1);
			return 0;
		}
		else if (count == 3 && LuaScriptMgr.CheckTypes(L, types2, 1))
		{
			AnimationComponent obj = LuaScriptMgr.GetNetObject<AnimationComponent>(L, 1);
			string arg0 = LuaScriptMgr.GetString(L, 2);
			Callback arg1 = LuaScriptMgr.GetNetObject<Callback>(L, 3);
			obj.PlayAnimation(arg0,arg1);
			return 0;
		}
		else
		{
			LuaDLL.luaL_error(L, "invalid arguments to method: AnimationComponent.PlayAnimation");
		}

		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Pause(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 1);
		AnimationComponent obj = LuaScriptMgr.GetNetObject<AnimationComponent>(L, 1);
		obj.Pause();
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Resume(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 1);
		AnimationComponent obj = LuaScriptMgr.GetNetObject<AnimationComponent>(L, 1);
		obj.Resume();
		return 0;
	}
}

