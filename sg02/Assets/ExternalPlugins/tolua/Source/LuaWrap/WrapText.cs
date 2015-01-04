﻿using System;
using UnityEngine.UI;
using UnityEngine;
using LuaInterface;

public class WrapText
{
	public static LuaMethod[] regs = new LuaMethod[]
	{
		new LuaMethod("FontTextureChanged", FontTextureChanged),
		new LuaMethod("GetGenerationSettings", GetGenerationSettings),
		new LuaMethod("GetTextAnchorPivot", GetTextAnchorPivot),
		new LuaMethod("CalculateLayoutInputHorizontal", CalculateLayoutInputHorizontal),
		new LuaMethod("CalculateLayoutInputVertical", CalculateLayoutInputVertical),
		new LuaMethod("OnRebuildRequested", OnRebuildRequested),
		new LuaMethod("New", _CreateText),
		new LuaMethod("GetClassType", GetClassType),
	};

	static LuaField[] fields = new LuaField[]
	{
		new LuaField("cachedTextGenerator", get_cachedTextGenerator, null),
		new LuaField("cachedTextGeneratorForLayout", get_cachedTextGeneratorForLayout, null),
		new LuaField("defaultMaterial", get_defaultMaterial, null),
		new LuaField("mainTexture", get_mainTexture, null),
		new LuaField("font", get_font, set_font),
		new LuaField("text", get_text, set_text),
		new LuaField("supportRichText", get_supportRichText, set_supportRichText),
		new LuaField("resizeTextForBestFit", get_resizeTextForBestFit, set_resizeTextForBestFit),
		new LuaField("resizeTextMinSize", get_resizeTextMinSize, set_resizeTextMinSize),
		new LuaField("resizeTextMaxSize", get_resizeTextMaxSize, set_resizeTextMaxSize),
		new LuaField("alignment", get_alignment, set_alignment),
		new LuaField("fontSize", get_fontSize, set_fontSize),
		new LuaField("horizontalOverflow", get_horizontalOverflow, set_horizontalOverflow),
		new LuaField("verticalOverflow", get_verticalOverflow, set_verticalOverflow),
		new LuaField("lineSpacing", get_lineSpacing, set_lineSpacing),
		new LuaField("fontStyle", get_fontStyle, set_fontStyle),
		new LuaField("pixelsPerUnit", get_pixelsPerUnit, null),
		new LuaField("minWidth", get_minWidth, null),
		new LuaField("preferredWidth", get_preferredWidth, null),
		new LuaField("flexibleWidth", get_flexibleWidth, null),
		new LuaField("minHeight", get_minHeight, null),
		new LuaField("preferredHeight", get_preferredHeight, null),
		new LuaField("flexibleHeight", get_flexibleHeight, null),
		new LuaField("layoutPriority", get_layoutPriority, null),
	};

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreateText(IntPtr L)
	{
		LuaDLL.luaL_error(L, "Text class does not have a constructor function");
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetClassType(IntPtr L)
	{
		LuaScriptMgr.Push(L, typeof(Text));
		return 1;
	}

	public static void Register(IntPtr L)
	{
		LuaScriptMgr.RegisterLib(L, "Text", typeof(Text), regs, fields, "UnityEngine.UI.MaskableGraphic");
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_cachedTextGenerator(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);

		if (o == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name cachedTextGenerator");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index cachedTextGenerator on a nil value");
			}
		}

		Text obj = (Text)o;
		LuaScriptMgr.PushObject(L, obj.cachedTextGenerator);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_cachedTextGeneratorForLayout(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);

		if (o == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name cachedTextGeneratorForLayout");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index cachedTextGeneratorForLayout on a nil value");
			}
		}

		Text obj = (Text)o;
		LuaScriptMgr.PushObject(L, obj.cachedTextGeneratorForLayout);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_defaultMaterial(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);

		if (o == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name defaultMaterial");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index defaultMaterial on a nil value");
			}
		}

		Text obj = (Text)o;
		LuaScriptMgr.Push(L, obj.defaultMaterial);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_mainTexture(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);

		if (o == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name mainTexture");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index mainTexture on a nil value");
			}
		}

		Text obj = (Text)o;
		LuaScriptMgr.Push(L, obj.mainTexture);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_font(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);

		if (o == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name font");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index font on a nil value");
			}
		}

		Text obj = (Text)o;
		LuaScriptMgr.Push(L, obj.font);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_text(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);

		if (o == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name text");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index text on a nil value");
			}
		}

		Text obj = (Text)o;
		LuaScriptMgr.Push(L, obj.text);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_supportRichText(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);

		if (o == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name supportRichText");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index supportRichText on a nil value");
			}
		}

		Text obj = (Text)o;
		LuaScriptMgr.Push(L, obj.supportRichText);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_resizeTextForBestFit(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);

		if (o == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name resizeTextForBestFit");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index resizeTextForBestFit on a nil value");
			}
		}

		Text obj = (Text)o;
		LuaScriptMgr.Push(L, obj.resizeTextForBestFit);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_resizeTextMinSize(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);

		if (o == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name resizeTextMinSize");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index resizeTextMinSize on a nil value");
			}
		}

		Text obj = (Text)o;
		LuaScriptMgr.Push(L, obj.resizeTextMinSize);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_resizeTextMaxSize(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);

		if (o == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name resizeTextMaxSize");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index resizeTextMaxSize on a nil value");
			}
		}

		Text obj = (Text)o;
		LuaScriptMgr.Push(L, obj.resizeTextMaxSize);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_alignment(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);

		if (o == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name alignment");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index alignment on a nil value");
			}
		}

		Text obj = (Text)o;
		LuaScriptMgr.PushEnum(L, obj.alignment);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_fontSize(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);

		if (o == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name fontSize");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index fontSize on a nil value");
			}
		}

		Text obj = (Text)o;
		LuaScriptMgr.Push(L, obj.fontSize);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_horizontalOverflow(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);

		if (o == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name horizontalOverflow");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index horizontalOverflow on a nil value");
			}
		}

		Text obj = (Text)o;
		LuaScriptMgr.PushEnum(L, obj.horizontalOverflow);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_verticalOverflow(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);

		if (o == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name verticalOverflow");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index verticalOverflow on a nil value");
			}
		}

		Text obj = (Text)o;
		LuaScriptMgr.PushEnum(L, obj.verticalOverflow);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_lineSpacing(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);

		if (o == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name lineSpacing");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index lineSpacing on a nil value");
			}
		}

		Text obj = (Text)o;
		LuaScriptMgr.Push(L, obj.lineSpacing);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_fontStyle(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);

		if (o == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name fontStyle");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index fontStyle on a nil value");
			}
		}

		Text obj = (Text)o;
		LuaScriptMgr.PushEnum(L, obj.fontStyle);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_pixelsPerUnit(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);

		if (o == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name pixelsPerUnit");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index pixelsPerUnit on a nil value");
			}
		}

		Text obj = (Text)o;
		LuaScriptMgr.Push(L, obj.pixelsPerUnit);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_minWidth(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);

		if (o == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name minWidth");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index minWidth on a nil value");
			}
		}

		Text obj = (Text)o;
		LuaScriptMgr.Push(L, obj.minWidth);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_preferredWidth(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);

		if (o == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name preferredWidth");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index preferredWidth on a nil value");
			}
		}

		Text obj = (Text)o;
		LuaScriptMgr.Push(L, obj.preferredWidth);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_flexibleWidth(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);

		if (o == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name flexibleWidth");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index flexibleWidth on a nil value");
			}
		}

		Text obj = (Text)o;
		LuaScriptMgr.Push(L, obj.flexibleWidth);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_minHeight(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);

		if (o == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name minHeight");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index minHeight on a nil value");
			}
		}

		Text obj = (Text)o;
		LuaScriptMgr.Push(L, obj.minHeight);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_preferredHeight(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);

		if (o == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name preferredHeight");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index preferredHeight on a nil value");
			}
		}

		Text obj = (Text)o;
		LuaScriptMgr.Push(L, obj.preferredHeight);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_flexibleHeight(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);

		if (o == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name flexibleHeight");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index flexibleHeight on a nil value");
			}
		}

		Text obj = (Text)o;
		LuaScriptMgr.Push(L, obj.flexibleHeight);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_layoutPriority(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);

		if (o == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name layoutPriority");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index layoutPriority on a nil value");
			}
		}

		Text obj = (Text)o;
		LuaScriptMgr.Push(L, obj.layoutPriority);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_font(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);

		if (o == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name font");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index font on a nil value");
			}
		}

		Text obj = (Text)o;
		obj.font = LuaScriptMgr.GetNetObject<Font>(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_text(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);

		if (o == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name text");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index text on a nil value");
			}
		}

		Text obj = (Text)o;
		obj.text = LuaScriptMgr.GetString(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_supportRichText(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);

		if (o == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name supportRichText");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index supportRichText on a nil value");
			}
		}

		Text obj = (Text)o;
		obj.supportRichText = LuaScriptMgr.GetBoolean(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_resizeTextForBestFit(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);

		if (o == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name resizeTextForBestFit");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index resizeTextForBestFit on a nil value");
			}
		}

		Text obj = (Text)o;
		obj.resizeTextForBestFit = LuaScriptMgr.GetBoolean(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_resizeTextMinSize(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);

		if (o == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name resizeTextMinSize");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index resizeTextMinSize on a nil value");
			}
		}

		Text obj = (Text)o;
		obj.resizeTextMinSize = (int)LuaScriptMgr.GetNumber(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_resizeTextMaxSize(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);

		if (o == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name resizeTextMaxSize");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index resizeTextMaxSize on a nil value");
			}
		}

		Text obj = (Text)o;
		obj.resizeTextMaxSize = (int)LuaScriptMgr.GetNumber(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_alignment(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);

		if (o == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name alignment");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index alignment on a nil value");
			}
		}

		Text obj = (Text)o;
		obj.alignment = LuaScriptMgr.GetNetObject<TextAnchor>(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_fontSize(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);

		if (o == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name fontSize");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index fontSize on a nil value");
			}
		}

		Text obj = (Text)o;
		obj.fontSize = (int)LuaScriptMgr.GetNumber(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_horizontalOverflow(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);

		if (o == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name horizontalOverflow");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index horizontalOverflow on a nil value");
			}
		}

		Text obj = (Text)o;
		obj.horizontalOverflow = LuaScriptMgr.GetNetObject<HorizontalWrapMode>(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_verticalOverflow(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);

		if (o == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name verticalOverflow");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index verticalOverflow on a nil value");
			}
		}

		Text obj = (Text)o;
		obj.verticalOverflow = LuaScriptMgr.GetNetObject<VerticalWrapMode>(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_lineSpacing(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);

		if (o == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name lineSpacing");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index lineSpacing on a nil value");
			}
		}

		Text obj = (Text)o;
		obj.lineSpacing = (float)LuaScriptMgr.GetNumber(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_fontStyle(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);

		if (o == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name fontStyle");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index fontStyle on a nil value");
			}
		}

		Text obj = (Text)o;
		obj.fontStyle = LuaScriptMgr.GetNetObject<FontStyle>(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int FontTextureChanged(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 1);
		Text obj = LuaScriptMgr.GetNetObject<Text>(L, 1);
		obj.FontTextureChanged();
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetGenerationSettings(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 2);
		Text obj = LuaScriptMgr.GetNetObject<Text>(L, 1);
		Vector2 arg0 = LuaScriptMgr.GetNetObject<Vector2>(L, 2);
		TextGenerationSettings o = obj.GetGenerationSettings(arg0);
		LuaScriptMgr.PushValue(L, o);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetTextAnchorPivot(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 1);
		TextAnchor arg0 = LuaScriptMgr.GetNetObject<TextAnchor>(L, 1);
		Vector2 o = Text.GetTextAnchorPivot(arg0);
		LuaScriptMgr.PushValue(L, o);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int CalculateLayoutInputHorizontal(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 1);
		Text obj = LuaScriptMgr.GetNetObject<Text>(L, 1);
		obj.CalculateLayoutInputHorizontal();
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int CalculateLayoutInputVertical(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 1);
		Text obj = LuaScriptMgr.GetNetObject<Text>(L, 1);
		obj.CalculateLayoutInputVertical();
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int OnRebuildRequested(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 1);
		Text obj = LuaScriptMgr.GetNetObject<Text>(L, 1);
		obj.OnRebuildRequested();
		return 0;
	}
}

