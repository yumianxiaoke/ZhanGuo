module(..., package.seeall);

m_ButtonsRoot = nil

function Initialize(viewPanel)

   m_Face = viewPanel.transform:FindChild("General_Anchor/Face").gameObject
   m_GeneralName = viewPanel.transform:FindChild("General_Anchor/GeneralName").gameObject
   m_DPWin = viewPanel.transform:FindChild("General_Anchor/DPWin").gameObject
   m_DPLose = viewPanel.transform:FindChild("General_Anchor/DPLose").gameObject
   m_KingNameStr = viewPanel.transform:FindChild("General_Anchor/KingNameStr").gameObject
   m_LoyStr = viewPanel.transform:FindChild("General_Anchor/LoyStr").gameObject
   m_LevelInt = viewPanel.transform:FindChild("General_Anchor/LevelInt").gameObject
   m_EXPInt = viewPanel.transform:FindChild("General_Anchor/EXPInt").gameObject
   m_EXPIntMax = viewPanel.transform:FindChild("General_Anchor/EXPIntMax").gameObject
   m_StrInt = viewPanel.transform:FindChild("General_Anchor/StrInt").gameObject
   m_IntInt = viewPanel.transform:FindChild("General_Anchor/IntInt").gameObject
   m_MorInt = viewPanel.transform:FindChild("General_Anchor/MorInt").gameObject
   m_SPInt = viewPanel.transform:FindChild("General_Anchor/SPInt").gameObject
   m_SPIntMax = viewPanel.transform:FindChild("General_Anchor/SPIntMax").gameObject
   m_VitInt = viewPanel.transform:FindChild("General_Anchor/VitInt").gameObject
   m_VitIntMax = viewPanel.transform:FindChild("General_Anchor/VitIntMax").gameObject
   m_SoldiersInt = viewPanel.transform:FindChild("General_Anchor/SoldiersInt").gameObject
   m_SoldiersInttMax = viewPanel.transform:FindChild("General_Anchor/SoldiersIntMax").gameObject
  
   m_BtReturn = viewPanel.transform:FindChild("General_Anchor/Return").gameObject
   
   m_togFormation = viewPanel.transform:FindChild("Formation_Anchor/Formation_Toggle").gameObject

   m_Weapona = viewPanel.transform:FindChild("Item_Anchor/Weapona").gameObject
   m_WeaponaName = viewPanel.transform:FindChild("Item_Anchor/Weapona/WeaponaName").gameObject
   m_Horse = viewPanel.transform:FindChild("Item_Anchor/Horse").gameObject
   m_HorseName = viewPanel.transform:FindChild("Item_Anchor/Horse/HorseName").gameObject
   m_Book = viewPanel.transform:FindChild("Item_Anchor/Book").gameObject
   m_BookName = viewPanel.transform:FindChild("Item_Anchor/Book/BookName").gameObject

   m_togArms = viewPanel.transform:FindChild("Arms_Anchor/Arms_Toggle").gameObject

   m_togGeneralSkill = viewPanel.transform:FindChild("GeneralSkill_Anchor/GeneralSkill_Toggle").gameObject

   m_togMilitarySkill = viewPanel.transform:FindChild("MilitarySkill_Anchor/MilitarySkill_Toggle").gameObject
end

function InitView(generalID)

   local general = GamePublic.Instance.DataManager:GetGeneralInfo(generalID)

   m_Face = general:SetFace(m_Face)

   local name = Utility.GeneralName(general.Name)
   Utility.SetText(m_GeneralName,name)
   Utility.SetText(m_DPWin,general.DPWin)
   Utility.SetText(m_DPLose,general.DPLose)
   local kingName = XMLManager.Kings:GetInfoById(general.KingID).Name
   Utility.SetText(m_KingNameStr, kingName)
   Utility.SetText(m_LoyStr,general.Loyalty)
   Utility.SetText(m_LevelInt,general.Level)
   Utility.SetText(m_EXPInt,general.Experience)
-- Utility.SetText(m_EXPIntMax,general.m_EXPIntMax)
   Utility.SetText(m_StrInt,general.Strength)
   Utility.SetText(m_IntInt,general.Intellect)
   Utility.SetText(m_MorInt,general.KnightCur)
   Utility.SetText(m_SPInt,general.CurMP)
   Utility.SetText(m_SPIntMax,general.BaseMP)
   Utility.SetText(m_VitInt,general.CurHP)
   Utility.SetText(m_VitIntMax,general.BaseHP)
   Utility.SetText(m_SoldiersInt,general.SoldierCur)
   Utility.SetText(m_SoldiersInttMax,general.SoldierMax)

   Utility.SetText(m_WeaponaName,general.Weapon)
   Utility.SetText(m_HorseName,general.Horse)
   Utility.SetText(m_Book,general.Thing)

   -- for i=1, general:GetSkills.Count-1 do
   --      local go = Utility.AddChildToggle(m_togFormation, general.BattleArray, true)
   --      print(go)
   -- end

end