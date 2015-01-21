module(..., package.seeall);

m_ButtonsRoot = nil

function Initialize(viewPanel)

    m_MajorListRoot = viewPanel.transform:FindChild("Min_Anchor/MajorList").gameObject

    m_Major = viewPanel.transform:FindChild("Min_Anchor/MajorList/Major").gameObject
    m_MajorName = viewPanel.transform:FindChild("Min_Anchor/MajorList/Major/MajorName").gameObject
    m_LevelInt = viewPanel.transform:FindChild("Min_Anchor/MajorList/Major/LevelInt").gameObject
    m_StrInt = viewPanel.transform:FindChild("Min_Anchor/MajorList/Major/StrInt").gameObject
    m_IntInt = viewPanel.transform:FindChild("Min_Anchor/MajorList/Major/IntInt").gameObject
    m_VitInt = viewPanel.transform:FindChild("Min_Anchor/MajorList/Major/VitInt").gameObject
    m_SPInt = viewPanel.transform:FindChild("Min_Anchor/MajorList/Major/SPInt").gameObject
    m_MorInt = viewPanel.transform:FindChild("Min_Anchor/MajorList/Major/MorInt").gameObject
    m_ArmsStr = viewPanel.transform:FindChild("Min_Anchor/MajorList/Major/ArmsStr").gameObject
    m_SoldiersInt = viewPanel.transform:FindChild("Min_Anchor/MajorList/Major/SoldiersInt").gameObject
    m_SiteStr = viewPanel.transform:FindChild("Min_Anchor/MajorList/Major/SiteStr").gameObject
    
    
    m_btMajor = viewPanel.transform:FindChild("Min_Anchor/Major").gameObject
    m_btLevel = viewPanel.transform:FindChild("Min_Anchor/Level").gameObject
    m_btStr = viewPanel.transform:FindChild("Min_Anchor/Str").gameObject
    m_btInt = viewPanel.transform:FindChild("Min_Anchor/Int").gameObject
    m_btVit = viewPanel.transform:FindChild("Min_Anchor/Vit").gameObject
    m_btSP = viewPanel.transform:FindChild("Min_Anchor/SP").gameObject
    m_btMor = viewPanel.transform:FindChild("Min_Anchor/Mor").gameObject
    m_btArms = viewPanel.transform:FindChild("Min_Anchor/Arms").gameObject
    m_btSoldiers = viewPanel.transform:FindChild("Min_Anchor/Soldiers").gameObject
    m_btSite = viewPanel.transform:FindChild("Min_Anchor/Site").gameObject

end