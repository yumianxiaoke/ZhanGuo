module(..., package.seeall);

m_ButtonsRoot = nil

function Initialize(viewPanel)
   
    m_UP_Anchor = viewPanel.transform:FindChild("UP_Anchor").gameObject
    m_BtReturn = viewPanel.transform:FindChild("UP_Anchor/return").gameObject


    m_Min_Anchor = viewPanel.transform:FindChild("Min_Anchor").gameObject

    m_MajorListRoot = viewPanel.transform:FindChild("Min_Anchor/MajorList").gameObject
    m_Content = viewPanel.transform:FindChild("Min_Anchor/MajorList/Content").gameObject

    m_Major = viewPanel.transform:FindChild("Min_Anchor/MajorList/Major").gameObject
    
    m_Scrollbar = viewPanel.transform:FindChild("Min_Anchor/ScrollBar_V/Scrollbar").gameObject
    m_SBComponent = m_Scrollbar:GetComponent("Scrollbar")
    m_UP = viewPanel.transform:FindChild("Min_Anchor/ScrollBar_V/UP Button").gameObject
    m_Down = viewPanel.transform:FindChild("Min_Anchor/ScrollBar_V/Down Button").gameObject

end

function InitView()

    local KingID = GamePublic.Instance.CurrentKing
    local KingInfo = GamePublic.Instance.DataManager:GetKingInfo(KingID)

    local  y = 0
    
    for i=0, KingInfo.Generals.Count-1 do    
        local GeneralsID  = KingInfo.Generals:get_Item(i)

        local major = Utility.AddChild(m_Content, m_Major)
        SetGeneralInfo(major, GeneralsID)

        major.transform.localPosition = Vector3.New(0, GlobalConfig.FontButtonsVSpace * i)                      

        y = y + GlobalConfig.FontButtonsVSpace        
    end

    m_Major:SetActive(false)

    local rt = m_Content:GetComponent("RectTransform")
    rt.sizeDelta = UnityEngine.Vector2.New(rt.rect.width, -y)
    
end

function SetGeneralInfo(major, generalID)
        
    local GeneralsInfo = GamePublic.Instance.DataManager:GetGeneralInfo(generalID)

    local m_MajorName = major.transform:FindChild("MajorName").gameObject
    local m_btSelect = major.transform:FindChild("btSelect").gameObject

    local name = Utility.GeneralName(GeneralsInfo.Name)
    Utility.SetText(m_MajorName,name)

    SelectGeneralDataControl.InitButtonEvent(m_btSelect, generalID)    

end