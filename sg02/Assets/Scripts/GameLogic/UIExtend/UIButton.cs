using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class UIButton : MonoBehaviour 
{
    private Button m_buttonScript;

    void Awake()
    {
        m_buttonScript = GetComponent<Button>();
    }

    public void OnClick()
    {
        InputManager.Instance.OnClick(gameObject);
    }

    public void OnPressDown()
    {
        InputManager.Instance.OnPress(gameObject, true);
    }

    public void SetText(string value)
    {
        name = value;
        GetComponent<Text>().text = value;
    }

    public void SetEnable(bool value)
    {
        m_buttonScript.enabled = value;
    }
}
