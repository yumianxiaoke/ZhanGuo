using System;
using System.Diagnostics;
using System.Threading;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;

public class Debugging
{
    public static List<string> m_line = new List<string>();
    public static List<string> m_writeTxt = new List<string>();
    private static string m_outPath;

    private static string _filterWords = string.Empty;
    private static int g_level = 0;
    private static string[] g_level_title = new string[] { "debug", "info", "waring", "error" };
    public const int LV_DEBUG = 0;
    public const int LV_ERROR = 3;
    public const int LV_INFO = 1;
    public const int LV_NONE = 4;
    public const int LV_WARING = 2;

    public static void Init(int level)
    {
        if (!IsValid(level))
        {
            level = 4;
        }
        g_level = level;

        InitLogsText();
    }

    //初始化log文件
    private static void InitLogsText()
    {
        if (Application.platform == RuntimePlatform.WindowsEditor)
        {
            m_outPath = Application.dataPath + "outlogs.txt";
        }
        else if (Application.platform == RuntimePlatform.Android || Application.platform == RuntimePlatform.IPhonePlayer)
        {
            m_outPath = Application.persistentDataPath + "/" + "outlogs.txt";
        }
        //m_outPath = Application.dataPath + "outlogs.txt";

        if (System.IO.File.Exists(m_outPath))
        {
            File.Delete(m_outPath);
            File.WriteAllText(m_outPath, m_outPath + "\n");
        }

        //监听log
        //Application.RegisterLogCallback(Handlelog);
        m_writeTxt.Add("m_outPath:" + m_outPath);
        //UnityEngine.Debug.Log("m_outPath:" + m_outPath);
        //Debugging.Log("m_outPath:" + m_outPath);
    }
    /// <summary>
    /// 提交log
    /// </summary>
    static void Handlelog(string logString, string stackTrace, LogType type)
    {
        Log(logString, 2);
        //m_writeTxt.Add(logString);
        if (type == LogType.Error || type == LogType.Exception)
        {
            Log(logString);
            Log(stackTrace);
        }
    }
    /// <summary>
    /// log写入TXT中
    /// </summary>
    public static void WriteInTxt()
    {
        if (m_writeTxt.Count > 0)
        {
            string[] temp = m_writeTxt.ToArray();

            for (int i = 0; i < m_writeTxt.Count; i++)
            {
                m_line.Add(temp[i]);
                using(StreamWriter writer = new StreamWriter(m_outPath, true, Encoding.UTF8))
                {
                    writer.WriteLine(temp[i]);
                }
                m_writeTxt.Remove(temp[i]);
            }
        }
    }
    private static bool IsValid(int level)
    {
        return ((level <= 4) && (level >= 0));
    }

    public static void Log(int _log)
    {
        Log(_log, 0);
    }

    public static void Log(float _log)
    {
        Log(_log, 0);
    }

    public static void Log(string log)
    {
        Log(log, 0);
    }

    public static void Log(int _log, int level)
    {
        Log(_log.ToString(), level);
    }

    public static void Log(float _log, int level)
    {
        Log(_log.ToString(), level);
    }

    public static void Log(string log, int level)
    {
        if (!GlobalConfig.IsDebuggingOpen)
            return;

        if ((Application.platform == RuntimePlatform.WindowsEditor) && !string.IsNullOrEmpty(_filterWords))
        {
            char[] separator = new char[] { '&' };
            foreach (string str in _filterWords.Split(separator))
            {
                if (!log.ToLower().Contains(str))
                {
                    return;
                }
            }
        }
        if (IsValid(level) && (level >= g_level))
        {
            string currTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            string currThread = Thread.CurrentThread.ManagedThreadId.ToString();
            StackTrace trace = new StackTrace(true);
            string str4 = string.Empty;
            for (int i = trace.FrameCount - 1; i >= 0; i--)
            {
                StackFrame frame = trace.GetFrame(i);
                str4 = str4 + frame.GetMethod().Name + ".";
            }
            string[] textArray1 = new string[] { currTime, " [logs]-[", g_level_title[level], "]  [Thread:", currThread, "]  ", log, "\ncall stack: [", str4, "]\ntime(ms): [", DateTime.Now.ToShortTimeString(), "]" };
            string message = string.Concat(textArray1);
            if (level == 3)
            {
                UnityEngine.Debug.LogError(message);
            }
            else if (level == 2)
            {
                UnityEngine.Debug.LogWarning(message);
            }
            else
            {
                UnityEngine.Debug.Log(message);
            }
            //Debugging.Log();
            m_writeTxt.Add(message);

            using (StreamWriter writer = new StreamWriter(m_outPath, true, Encoding.UTF8))
            {
                writer.Write(message);
                writer.WriteLine();
                writer.Flush();
                writer.Close();
            }
        }
    }

    public static void Log(Vector3 _log, int level)
    {
        Log("x=" + _log.x.ToString() + ",y=" + _log.y.ToString() + ",z=" + _log.z.ToString(), level);
    }

    public static void Log(string str, params object[] args)
    {
        str = string.Format(str, args);
        Log(str, 3);
    }

    public static void LogError(string log)
    {
        Log(log, 3);
    }

    public static void LogError(string str, params object[] args)
    {
        str = string.Format(str, args);
        Log(str, 3);
    }

    public static void LogWarning(string log)
    {
        Log(log, 2);
    }

    public static void LogWarning(string str, params object[] args)
    {
        str = string.Format(str, args);
        Log(str, 2);
    }

    public static void SetFilterWords(string filterWords)
    {
        _filterWords = filterWords;
    }

    public static int CurrentDebugLevel
    {
        get
        {
            return g_level;
        }
    }
}

