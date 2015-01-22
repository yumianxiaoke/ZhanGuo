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
    m_VitIntMAX = viewPanel.transform:FindChild("Min_Anchor/MajorList/Major/VitIntMAX").gameObject
    m_SPInt = viewPanel.transform:FindChild("Min_Anchor/MajorList/Major/SPInt").gameObject
    m_SPIntMAX = viewPanel.transform:FindChild("Min_Anchor/MajorList/Major/SPIntMAX").gameObject
    m_MorInt = viewPanel.transform:FindChild("Min_Anchor/MajorList/Major/MorInt").gameObject
    m_ArmsStr = viewPanel.transform:FindChild("Min_Anchor/MajorList/Major/ArmsStr").gameObject
    m_SoldiersInt = viewPanel.transform:FindChild("Min_Anchor/MajorList/Major/SoldiersInt").gameObject
    m_SoldiersIntMAX = viewPanel.transform:FindChild("Min_Anchor/MajorList/Major/SoldiersIntMAX").gameObject
    m_SiteStr = viewPanel.transform:FindChild("Min_Anchor/MajorList/Major/SiteStr").gameObject
    
    
end

function InitView()

    local KingID = GamePublic.Instance.CurrentKing
    local KingInfo = GamePublic.Instance.DataManager:GetKingInfo(KingID)

    for i=0, KingInfo.Generals.Count-1 do
        local GeneralsID  = KingInfo.Generals:get_Item(i)
        
        local major = Utility.AddChild(m_MajorListRoot, m_Major)
        SetGeneralInfo(major, GeneralsID)

       --InputManager.Instance:AddOnClickEvent(m_btSelect,BtSelect)
        --btSelect(GeneralsID)
      



        major.transform.localPosition = Vector3.New(0, GlobalConfig.FontButtonsVSpace * i)
    end

    m_Major:SetActive(false)


end


function BtSelect(generalID)
    local selectgeneralID = generalID
    print(selectgeneralID)
    return selectgeneralID

end

function SetGeneralInfo(major, generalID)
    
    local GeneralsInfo = GamePublic.Instance.DataManager:GetGeneralInfo(generalID)

    m_MajorName = major.transform:FindChild("MajorName").gameObject
    m_LevelInt = major.transform:FindChild("LevelInt").gameObject
    m_StrInt = major.transform:FindChild("StrInt").gameObject
    m_IntInt = major.transform:FindChild("IntInt").gameObject
    m_VitInt = major.transform:FindChild("VitInt").gameObject
    m_VitIntMAX = major.transform:FindChild("VitIntMAX").gameObject
    m_SPInt = major.transform:FindChild("SPInt").gameObject
    m_SPIntMAX = major.transform:FindChild("SPIntMAX").gameObject
    m_MorInt = major.transform:FindChild("MorInt").gameObject
    m_ArmsStr = major.transform:FindChild("ArmsStr").gameObject
    m_SoldiersInt = major.transform:FindChild("SoldiersInt").gameObject
    m_SoldiersIntMAX = major.transform:FindChild("SoldiersIntMAX").gameObject
    m_SiteStr = major.transform:FindChild("SiteStr").gameObject
    m_btSelect = major.transform:FindChild("btSelect").gameObject

   -- Utility.SetText(MajorID,GeneralsInfo.ID)
   local name = Utility.GeneralName(GeneralsInfo.Name)
    Utility.SetText(m_MajorName,name)
    Utility.SetText(m_LevelInt,GeneralsInfo.Level)
    Utility.SetText(m_StrInt,GeneralsInfo.Strength)
    Utility.SetText(m_IntInt,GeneralsInfo.Intellect)
    Utility.SetText(m_VitInt,GeneralsInfo.CurHP)
    Utility.SetText(m_VitIntMAX,GeneralsInfo.BaseHP)
    Utility.SetText(m_SPInt,GeneralsInfo.CurMP)
    Utility.SetText(m_SPIntMAX,GeneralsInfo.BaseMP)
    Utility.SetText(m_MorInt,GeneralsInfo.KnightCur)
    Utility.SetText(m_ArmsStr,GeneralsInfo.UseForce)
    Utility.SetText(m_SoldiersInt,GeneralsInfo.SoldierCur)
    Utility.SetText(m_SoldiersIntMAX,GeneralsInfo.SoldierMax)
    Utility.SetText(m_SiteStr,GeneralsInfo.CityID)

    SelectGeneralDataControl.InitButtonEvent(m_btSelect, generalID)

end
  --  local GeneralsID = KingInfo.Generals

  --[[ 
    local king = GamePublic.Instance.CurrentKing
    local GeneralsInfo_ = GamePublic.Instance.DataManager:GetKingInfo(king)

    --for i=0, king.Generals.Count - 1 do
    local GeneralsInfo = GeneralsInfo_.Generals:get_Item(1)

    --    king.Generals
]]--
    
  --  end
--[[
    local king = GamePublic.Instance.DataManager:GetKingInfo(GamePublic.Instance.CurrentKing)
    local general = GamePublic.Instance.DataManager:GetGeneralInfo(king.GeneralID)
    general:SetFace(m_imageFace)
]]--

--[[
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
]]