using UnityEngine;
using System.Collections;


public static class LuaScriptsLoader {

    /// <summary>
    /// 加载所有的LUA文件
    /// </summary>
	public static void Load()
    {
        IEnumerator enumerator = XMLManager.LuaScripts.Data.Keys.GetEnumerator();
        while (enumerator.MoveNext())
        {
            string path = (string)enumerator.Current;
            if (path.EndsWith(".lua") == false)
                path += ".lua";

            GamePublic.Instance.LuaManager.DoFile(path);
        }
    }
}
