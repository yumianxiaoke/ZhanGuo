module(..., package.seeall);

m_ButtonsRoot = nil

function Initialize(viewPanel)

    m_ButtonsRoot = viewPanel.transform:FindChild("UP_Anchor/CityName").gameObject

    m_MajorListRoot = viewPanel.transform:FindChild("Min_Anchor/MajorList").gameObject
    
    m_btMajor = viewPanel.transform:FindChild("Min_Anchor/MajorList/Major").gameObject
    m_btLevel = viewPanel.transform:FindChild("Min_Anchor/MajorList/Level").gameObject
    m_btStr = viewPanel.transform:FindChild("Min_Anchor/MajorList/Str").gameObject
    m_btInt = viewPanel.transform:FindChild("Min_Anchor/MajorList/Int").gameObject
    m_btVit = viewPanel.transform:FindChild("Min_Anchor/MajorList/Vit").gameObject
    m_btSP = viewPanel.transform:FindChild("Min_Anchor/MajorList/SP").gameObject
    m_btMor = viewPanel.transform:FindChild("Min_Anchor/MajorList/Mor").gameObject
    m_btArms = viewPanel.transform:FindChild("Min_Anchor/MajorList/Arms").gameObject
    m_btSoldiers = viewPanel.transform:FindChild("Min_Anchor/MajorList/Soldiers").gameObject

end