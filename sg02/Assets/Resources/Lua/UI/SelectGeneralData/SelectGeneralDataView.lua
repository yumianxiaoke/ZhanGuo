module(..., package.seeall);

m_ButtonsRoot = nil

function Initialize(viewPanel)

    m_MajorListRoot = viewPanel.transform:FindChild("Min_Anchor/MajorList").gameObject
    
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