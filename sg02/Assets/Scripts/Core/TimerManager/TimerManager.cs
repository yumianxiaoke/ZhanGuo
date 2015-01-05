using UnityEngine;
using System.Collections;
using System.Collections.Generic;

using System;

public class TimerManager : MonoBehaviour 
{
    private List<Timer> m_listTimer;

    private static TimerManager m_instance;
    public static TimerManager Instance
    {
        get
        {
            if (m_instance == null)
            {
                GameObject go = new GameObject("_TimerManager");
                go.hideFlags = HideFlags.HideInHierarchy;

                m_instance = go.AddComponent<TimerManager>();

                GameObject.DontDestroyOnLoad(go);
            }

            return m_instance;
        }
    }
    

    public void Initialize() 
    {
        m_listTimer = new List<Timer>();
    }

    public void UnInitialize() 
    {
        if (m_listTimer != null)
            m_listTimer.Clear();
    }

    public void Update()
    {
        float fixTime = Time.deltaTime / Time.timeScale;

        for (int i = m_listTimer.Count - 1; i >= 0; i--)
        {
            Timer proc = m_listTimer[i];
            proc.SubTime(Time.deltaTime, fixTime);
            
            if (proc.time <= 0)
            {
                try
                {
                    proc.Call();
                }
                catch (Exception e)
                {
                    m_listTimer.RemoveAt(i);
                    Debugging.LogError("TimerManager proc.Call() Exception; message:" + e.Message);
                }
                

                if (proc.loop > 0)
                {
                    --proc.loop;
                    proc.time += proc.duration;
                }

                if (proc.loop == 0)
                {
                    m_listTimer.RemoveAt(i);
                }
                else if (proc.loop < 0)
                {
                    proc.time += proc.duration;
                }
            }
        }
    }

    #region 等待若干秒
    public Timer WaitForSeconds(float seconds, Callback callback)
    {
        return AddTimer(seconds, 0, false, callback);
    }

    public Timer WaitForSeconds<T>(float seconds, Callback<T> callback, T arg)
    {
        return AddTimer<T>(seconds, 0, false, callback, arg);
    }

    public Timer WaitForSeconds(float seconds, CallbackWithParam callback, params object[] args)
    {
        return AddTimer(seconds, 0, false, callback, args);
    }

    public Timer WaitForSeconds(float seconds, LuaInterface.LuaFunction callback, params object[] args)
    {
        return AddTimer(seconds, 0, false, callback, args);
    }

    #endregion

    #region 等待这一帧结束时加调
    public void WaitForEndOfFrame(Callback callback)
    {
        StartCoroutine(CoWaitEndFrame(callback));
    }

    public void WaitForEndOfFrame<T>(Callback<T> callback, T arg)
    {
        StartCoroutine(CoWaitEndFrame<T>(callback, arg));
    }

    public void WaitForEndOfFrame(CallbackWithParam callback, params object[] args)
    {
        StartCoroutine(CoWaitEndFrame(callback, args));
    }

    public void WaitForEndOfFrame(LuaInterface.LuaFunction callback, params object[] args)
    {
        StartCoroutine(CoWaitEndFrame(callback, args));
    }

    public void WaitEndOfFrame(Action action)
    {
        StartCoroutine(CoWaitEndFrame(action));
    }

    public void Yield(int frame, Action action)
    {
        StartCoroutine(YieldByFrame(frame, action));
    }

    IEnumerator YieldByFrame(int frame, Action call)
    {
        while (frame > 0)
        {
            yield return null;
            --frame;
        }

        call();
    }

    IEnumerator CoWaitEndFrame(Callback callback)
    {
        yield return new WaitForEndOfFrame();
        callback();
    }

    IEnumerator CoWaitEndFrame<T>(Callback<T> callback, T arg)
    {
        yield return new WaitForEndOfFrame();
        callback(arg);
    }

    IEnumerator CoWaitEndFrame(CallbackWithParam callback, params object[] args)
    {
        yield return new WaitForEndOfFrame();
        callback(args);
    }

    IEnumerator CoWaitEndFrame(LuaInterface.LuaFunction action, params object[] args)
    {
        yield return new WaitForEndOfFrame();
        action.Call(args);
    }

    IEnumerator CoWaitEndFrame(Action action)
    {
        yield return new WaitForEndOfFrame();
        action();
    }

    #endregion

    #region Timer操作

    /// <summary>
    /// 添加一个计时器
    /// </summary>
    /// <param name="duration">间隔时间</param>
    /// <param name="loop">循环次数, 0:不循环, -1:无限循环, </param>
    /// <param name="call">回调函数</param>
    /// <param name="beScale">是否受到 Time.scale 的影响</param>
    /// <returns></returns>
    public Timer AddTimer(float duration, int loop, bool beScale, Callback call)
    {
        TimerCall proc = new TimerCall();
        proc.duration = duration;
        proc.time = duration;
        proc.loop = loop;
        proc.beScale = beScale;
        proc.call = call;
        m_listTimer.Add(proc);

        return proc;
    }

    public Timer AddTimer<T>(float duration, int loop, bool beScale, Callback<T> call, T param)
    {
        TimerCall<T> proc = new TimerCall<T>();
        proc.duration = duration;
        proc.time = duration;
        proc.loop = loop;
        proc.beScale = beScale;
        proc.call = call;
        proc.param = param;
        m_listTimer.Add(proc);

        return proc;
    }

    public Timer AddTimer(float duration, int loop, bool beScale, CallbackWithParam call, object[] args)
    {
        TimerCallWithParam proc = new TimerCallWithParam();
        proc.duration = duration;
        proc.time = duration;
        proc.loop = loop;
        proc.beScale = beScale;
        proc.call = call;
        proc.args = args;
        m_listTimer.Add(proc);

        return proc;
    }

    public Timer AddTimer(float duration, int loop, bool beScale, LuaInterface.LuaFunction call, params object[] args)
    {
        TimerCallLuaFunction proc = new TimerCallLuaFunction();
        proc.duration = duration;
        proc.time = duration;
        proc.loop = loop;
        proc.beScale = beScale;
        proc.call = call;
        proc.args = args;
        m_listTimer.Add(proc);

        return proc;
    }

    public Timer AddTimer(float duration, int loop, bool beScale, Action call)
    {
        TimerCallAction proc = new TimerCallAction();
        proc.duration = duration;
        proc.time = duration;
        proc.loop = loop;
        proc.beScale = beScale;
        proc.call = call;
        m_listTimer.Add(proc);

        return proc;
    }

    public void Stop(Timer timer)
    {
        if (timer != null && m_listTimer.Contains(timer))
            m_listTimer.Remove(timer);
    }

    #endregion

    public class TimerCall : Timer
    {
        public Callback call = null;

        public override void Call()
        {
            if (call != null)
                call();
        }
    }

    public class TimerCall<T> : Timer
    {
        public Callback<T> call = null;
        public T param;

        public override void Call()
        {
            if (call != null)
                call(param);
        }
    }

    public class TimerCallWithParam : Timer
    {
        public CallbackWithParam call = null;
        public object[] args;

        public override void Call()
        {
            if (call != null)
                call(args);
        }
    }

    public class TimerCallLuaFunction : Timer
    {
        public LuaInterface.LuaFunction call = null;
        public object[] args;

        public override void Call()
        {
            if (call != null)
                call.Call(args);
        }
    }

    public class TimerCallAction : Timer
    {
        public Action call = null;
        public override void Call()
        {
            if (call != null)
                call();
        }
    }
}

public class Timer
{
    public float duration;
    public float time;
    public int loop = -1;
    //后面加上是否受timescale影响
    public bool beScale = true;

    public void SubTime(float deltaTime, float noScaleTime)
    {
        float t = beScale ? deltaTime : noScaleTime;
        this.time -= t;
    }

    public virtual void Call()
    {

    }
}