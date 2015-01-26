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
   
   -- m_togFormation = viewPanel.transform:FindChild("Formation_Anchor/Formation_Toggle").gameObject

   m_Weapona = viewPanel.transform:FindChild("Item_Anchor/Weapona").gameObject
   m_WeaponaName = viewPanel.transform:FindChild("Item_Anchor/Weapona/WeaponaName").gameObject
   m_Horse = viewPanel.transform:FindChild("Item_Anchor/Horse").gameObject
   m_HorseName = viewPanel.transform:FindChild("Item_Anchor/Horse/HorseName").gameObject
   m_Book = viewPanel.transform:FindChild("Item_Anchor/Book").gameObject
   m_BookName = viewPanel.transform:FindChild("Item_Anchor/Book/BookName").gameObject

   --m_togArms = viewPanel.transform:FindChild("Arms_Anchor/Arms_Toggle").gameObject

   m_togGeneralSkill = viewPanel.transform:FindChild("GeneralSkill_Anchor/GeneralSkill_Toggle").gameObject

   m_togMilitarySkill = viewPanel.transform:FindChild("MilitarySkill_Anchor/MilitarySkill_Toggle").gameObject

   m_ArmsList = viewPanel.transform:FindChild("Arms_Anchor/ArmsList").gameObject
   m_ArmTemp = viewPanel.transform:FindChild("Arms_Anchor/ArmsList/Arm1").gameObject
   m_ArmUsing = viewPanel.transform:FindChild("Arms_Anchor/ArmsList/Using").gameObject

   m_BattleList = viewPanel.transform:FindChild("Formation_Anchor/BattleList").gameObject
   m_BattleTemp = viewPanel.transform:FindChild("Formation_Anchor/BattleList/Battle").gameObject
   m_BattleUsing = viewPanel.transform:FindChild("Formation_Anchor/BattleList/Using").gameObject
end

function InitView(generalID)

   local general = GamePublic.Instance.DataManager:GetGeneralInfo(generalID)

   m_Face = general:SetFace(m_Face)

   local name = Utility.GeneralName(general.Name)
   Utility.SetText(m_GeneralName,name)
   Utility.SetText(m_DPWin,general.DPWin)
   Utility.SetText(m_DPLose,general.DPLose)
   local kingName = XMLManager.Kings:GetInfoById(general.KingID).Name
   kingName = Utility.GeneralName(kingName)
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

   SetArms(general)
   SetBattle(general)

   -- for i=1, general:GetSkills.Count-1 do
   --      local go = Utility.AddChildToggle(m_togFormation, general.BattleArray, true)
   --      print(go)
   -- end

end

--设置兵种信息
function SetArms(general)
   
   local rt = m_ArmsList:GetComponent("RectTransform")
   local rectWidth = rt.rect.width
   local armsNum = XMLManager.Force.Data.Count
   local armWidth = rectWidth / armsNum

   for i = 0, armsNum - 1 do
      local arm = Utility.AddChild(m_ArmsList, m_ArmTemp)
      local rt2 = arm:GetComponent("RectTransform")
      rt2.sizeDelta = UnityEngine.Vector2.New(armWidth, rt2.rect.height)      
      rt2.anchoredPosition3D = Vector3.New(i*armWidth, m_ArmTemp.transform.localPosition.y)
      
      local armID = 2^i
      local armName = XMLManager.Force:GetInfoById(armID).Name                  

      -- 设置兵种文字
      local text = arm:GetComponent("Text")
      local completeName = SetArmsName(armName)
      -- 若不是可用兵种，则令text变暗      
      if Utility.BitTest(general.ForceArray, i) == false then
         --text.mainTexture = UnityEngine.Color.New(0.5, 0.5, 0.5, 1)    
         text.text = "<color=grey>"..completeName.."</color>"
      else
         --设置令牌位置
         if armID == general.UseForce then
            local pos = m_ArmUsing.transform.localPosition
            m_ArmUsing.transform.localPosition = Vector3.New(pos.x + i*armWidth, pos.y)
         end  
         text.text = completeName
      end
   end

   m_ArmTemp:SetActive(false)

end

--补全从配置表里面读出的兵种名字
function SetArmsName(name)
   
   -- 调整从配置表中读取到的兵种名字，两个字的兵种中间加空格
   -- 三个字的兵种后面加个“兵”
   -- 涉及到中文编码问题，下列操作以byte为单位
   local completeName = {}
   for j = 1, #name do
      completeName[#completeName + 1] = string.sub(name, j, j)
   end

   if string.find(name, "兵") ~= nil then   
      local f, _ = string.find(name, "兵")      
      table.insert(completeName, f, "\n\n")        
   else
      table.insert(completeName, "兵")
   end

   return table.concat(completeName)

end

--设置阵型信息
function SetBattle(general)
   
   local rt = m_BattleList:GetComponent("RectTransform")
   local height = rt.rect.height
   local totleBattle = XMLManager.Battle.Data.Count
   local battleHeight = height / totleBattle
   
   for i = 0, totleBattle - 1 do
      local battle = Utility.AddChild(m_BattleList, m_BattleTemp)
      local rt2 = battle:GetComponent("RectTransform")
      rt2.sizeDelta = UnityEngine.Vector2.New(rt2.rect.width, battleHeight)
      rt2.anchoredPosition3D = Vector3.New(m_BattleTemp.transform.localPosition.x, -i*battleHeight)

      local battleID = 2^i
      local battleName = XMLManager.Battle:GetInfoById(battleID).Name.."之阵"

      local text = battle:GetComponent("Text")

      if Utility.BitTest(general.BattleArray, i) == false then
         text.text = "<color=grey>"..battleName.."</color>"
      else
         if battleID == general.UseBattle then
            local pos = m_BattleUsing.transform.localPosition
            m_BattleUsing.transform.localPosition = Vector3.New(pos.x, pos.y - i*battleHeight)
         end
         text.text = battleName
      end
   end

   m_BattleTemp:SetActive(false)

end