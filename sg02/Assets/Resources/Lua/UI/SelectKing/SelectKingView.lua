module(..., package.seeall);

m_kingListRoot = nil

m_buttonsRoot = nil

m_buttonConfirm = nil
m_buttonCancel = nil

m_imageFace = nil

function Initialize(viewPanel)

    m_kingListRoot = viewPanel.transform:FindChild("Left Anchor/KingsList").gameObject
    m_buttonsRoot = viewPanel.transform:FindChild("Left Anchor/Buttons").gameObject

    m_buttonConfirm = viewPanel.transform:FindChild("Left Anchor/Buttons/ButtonsConfirm").gameObject
    m_buttonCancel = viewPanel.transform:FindChild("Left Anchor/Buttons/ButtonsCancel").gameObject

    m_imageFace = viewPanel.transform:FindChild("Down Anchor/Face").gameObject

    m_totalCitys = viewPanel.transform:FindChild("Down Anchor/totalCitys").gameObject
    m_totalLevel = viewPanel.transform:FindChild("Down Anchor/totalLevel").gameObject
    m_totalGenerals = viewPanel.transform:FindChild("Down Anchor/totalGenerals").gameObject
    m_totalSoldier = viewPanel.transform:FindChild("Down Anchor/totalSoldier").gameObject
    m_totalMoney = viewPanel.transform:FindChild("Down Anchor/totalMoney").gameObject
    m_totalPopulation = viewPanel.transform:FindChild("Down Anchor/totalPopulation").gameObject

end

function SetCurrentKing(kingID)
    local king = GamePublic.Instance.DataManager:GetKingInfo(kingID)
    local generalID = king.GeneralID        

    local general = GamePublic.Instance.DataManager:GetGeneralInfo(generalID)
    general:SetFace(m_imageFace)

  --  local KingID = GamePublic.Instance.CurrentKing
  --  local KingInfo = GamePublic.Instance.DataManager:GetKingInfo(KingID)

    Utility.SetText(m_totalCitys,king.totalCitys)
    Utility.SetText(m_totalLevel, tostring(king.totalLevel))
    Utility.SetText(m_totalGenerals,tostring(king.Generals.Count))
    Utility.SetText(m_totalSoldier,tostring(king.totalSoldier))
    Utility.SetText(m_totalMoney,tostring(king.totalMoney))
    Utility.SetText(m_totalPopulation,tostring(king.totalPopulation))
end