module(..., package.seeall);

m_ButtonsRoot = nil

function Initialize(viewPanel)

    m_Face = viewPanel.transform:FindChild("UP_Anchor/Face").gameObject
    m_MajorName = viewPanel.transform:FindChild("UP_Anchor/MajorName").gameObject
    m_CityName = viewPanel.transform:FindChild("UP_Anchor/CityName").gameObject
    m_CityDefence = viewPanel.transform:FindChild("UP_Anchor/CityDefence").gameObject
    m_CityDefenceInt = viewPanel.transform:FindChild("UP_Anchor/CityDefenceInt").gameObject
    m_CityMoney = viewPanel.transform:FindChild("UP_Anchor/CityMoney").gameObject
    m_CityMoneyInt = viewPanel.transform:FindChild("UP_Anchor/CityMoneyInt").gameObject
    m_SoldierInt = viewPanel.transform:FindChild("UP_Anchor/SoldierInt").gameObject
    m_Soldier = viewPanel.transform:FindChild("UP_Anchor/Soldier").gameObject
    m_RedifInt = viewPanel.transform:FindChild("UP_Anchor/RedifInt").gameObject
    m_Redif = viewPanel.transform:FindChild("UP_Anchor/Redif").gameObject

    m_MajorListRoot = viewPanel.transform:FindChild("Min_Anchor/MajorList").gameObject
    m_btMajor = viewPanel.transform:FindChild("UP_Anchor/Major").gameObject
    m_btLevel = viewPanel.transform:FindChild("UP_Anchor/Level").gameObject
    m_btStr = viewPanel.transform:FindChild("UP_Anchor/Str").gameObject
    m_btInt = viewPanel.transform:FindChild("UP_Anchor/Int").gameObject
    m_btVit = viewPanel.transform:FindChild("UP_Anchor/Vit").gameObject
    m_btSP = viewPanel.transform:FindChild("UP_Anchor/SP").gameObject
    m_btMor = viewPanel.transform:FindChild("UP_Anchor/Mor").gameObject
    m_btArms = viewPanel.transform:FindChild("UP_Anchor/Arms").gameObject
    m_btSoldiers = viewPanel.transform:FindChild("UP_Anchor/Soldiers").gameObject

    m_btYes = viewPanel.transform:FindChild("Down_Anchor/Yes_bg/Yes").gameObject
    m_btNo = viewPanel.transform:FindChild("Down_Anchor/No/No").gameObject
    m_MoneyIntBar = viewPanel.transform:FindChild("Down_Anchor/MoneyIntBar").gameObject
    m_MoneyInt = viewPanel.transform:FindChild("Down_Anchor/MoneyIntBar/MoneyInt").gameObject

end