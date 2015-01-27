module(..., package.seeall);

m_ButtonsRoot = nil
CN_LENGTH = #"国"

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

   m_Weapona = viewPanel.transform:FindChild("Item_Anchor/Weapona").gameObject
   m_WeaponaName = viewPanel.transform:FindChild("Item_Anchor/Weapona/WeaponaName").gameObject
   m_Horse = viewPanel.transform:FindChild("Item_Anchor/Horse").gameObject
   m_HorseName = viewPanel.transform:FindChild("Item_Anchor/Horse/HorseName").gameObject
   m_Thing = viewPanel.transform:FindChild("Item_Anchor/Thing").gameObject
   m_ThingName = viewPanel.transform:FindChild("Item_Anchor/Thing/ThingName").gameObject

   m_ArmsList = viewPanel.transform:FindChild("Arms_Anchor/ArmsList").gameObject

   m_BattleList = viewPanel.transform:FindChild("Formation_Anchor/BattleList").gameObject

   m_GeneralSkillList = viewPanel.transform:FindChild("GeneralSkill_Anchor/SkillList").gameObject
   m_WiseSkillList = viewPanel.transform:FindChild("WiseSkill_Anchor/SkillList").gameObject

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
   Utility.SetText(m_StrInt,general.Strength)
   Utility.SetText(m_IntInt,general.Intellect)
   Utility.SetText(m_MorInt,general.KnightCur)
   Utility.SetText(m_SPInt,general.CurMP)
   Utility.SetText(m_SPIntMax,general.BaseMP)
   Utility.SetText(m_VitInt,general.CurHP)
   Utility.SetText(m_VitIntMax,general.BaseHP)
   Utility.SetText(m_SoldiersInt,general.SoldierCur)
   Utility.SetText(m_SoldiersInttMax,general.SoldierMax)

   SetThings(general)

   local forceCount = XMLManager.Force.Data.Count
   local battleCount = XMLManager.Battle.Data.Count
   local generalInfo = XMLManager.Generals:GetInfoById(general.ID)
   local skillCount = generalInfo.Skill.Length
   local wiseSkillCount = generalInfo.WiseSkill.Length

   SetViewDatas(general, m_ArmsList, forceCount, SetArms)   
   SetViewDatas(general, m_BattleList, battleCount, SetBattle)
   SetViewDatas(general, m_GeneralSkillList, skillCount, SetGeneralSkill)
   SetViewDatas(general, m_WiseSkillList, wiseSkillCount, SetWiseSkill)

end

function SetThings(general)   

   if general.Weapon ~= 0 then      
      local weaponInfo = XMLManager.Things:GetInfoById(general.Weapon)
      Utility.SetText(m_WeaponaName, weaponInfo.Name)
      --Set Sprite Here
   else
      Utility.SetText(m_WeaponaName, " ")
   end

   if general.Horse ~= 0 then
      local horseInfo = XMLManager.Things:GetInfoById(general.Horse)
      Utility.SetText(m_HorseName, horseInfo.Name)
      --Set Sprite Here
   else
      Utility.SetText(m_HorseName, " ")
   end

   if general.Thing ~= 0 then
      local thingInfo = XMLManager.Things:GetInfoById(general.Thing)
      Utility.SetText(m_ThingName, thingInfo.Name)     
      --Set Sprite Here
   else
      Utility.SetText(m_ThingName, " ") 
   end

end

function SetViewDatas(general, parent, count, handler)
   
   local prefab = parent.transform:FindChild("Prefab").gameObject
   local rt = parent:GetComponent("RectTransform")
   local cellOffest = 0

   -- 判断当前是否为阵型列表
   if parent == m_BattleList then
      cellOffest = rt.rect.height / count
   else
      cellOffest = rt.rect.width / count      
   end
   
   for i = 0, count - 1 do

      local child = Utility.AddChild(parent, prefab)
      local rt2 = child:GetComponent("RectTransform")

      if parent == m_BattleList then
         rt2.sizeDelta = UnityEngine.Vector2.New(rt2.rect.width, cellOffest)
         rt2.anchoredPosition3D = Vector3.New(prefab.transform.localPosition.x, -i*cellOffest)
      else
         rt2.sizeDelta = UnityEngine.Vector2.New(cellOffest, rt2.rect.height)      
         rt2.anchoredPosition3D = Vector3.New(i*cellOffest, prefab.transform.localPosition.y)
      end

      handler(general, i, child, parent, cellOffest)

   end

   prefab:SetActive(false)

end

--设置兵种信息
function SetArms(general, index, child, parent, cellOffest)
   
   local armID = 2^index
   local armName = XMLManager.Force:GetInfoById(armID).Name                  

   -- 设置兵种文字和颜色
   local text = child:GetComponent("Text")
   local completeName = HandleArmsName(armName)

   -- 若不是可用兵种，则令text变暗      
   if Utility.BitTest(general.ForceArray, index) == false then  
      completeName = "<color=grey>"..completeName.."</color>"
   else
      --设置令牌位置
      if armID == general.UseForce then
         local goUsing = parent.transform:FindChild("Using")
         local pos = goUsing.transform.localPosition
         goUsing.transform.localPosition = Vector3.New(pos.x + index*cellOffest, pos.y)
      end        
   end

   text.text = completeName

end

--设置阵型信息
function SetBattle(general, index, child, parent, cellOffest)

   local battleID = 2^index
   local battleName = XMLManager.Battle:GetInfoById(battleID).Name.."之阵"

   local text = child:GetComponent("Text")

   if Utility.BitTest(general.BattleArray, index) == false then
      battleNamet = "<color=grey>"..battleName.."</color>"
   else
      if battleID == general.UseBattle then
         local goUsing = parent.transform:FindChild("Using")
         local pos = goUsing.transform.localPosition
         goUsing.transform.localPosition = Vector3.New(pos.x, pos.y - index*cellOffest)
      end      
   end

   text.text = battleName

end

function SetGeneralSkill(general, index, child)   

   local generalInfo = XMLManager.Generals:GetInfoById(general.ID)

   if general.Level >= generalInfo.SkillLevel[index] then
      local text = child:GetComponent("Text")
      text.text = SpliteIntoLines(generalInfo.Skill[index])
   end

end

function SetWiseSkill(general, index, child)

   local generalInfo = XMLManager.Generals:GetInfoById(general.ID)
   
   if general.Level >= generalInfo.WiseSkillLevel[index] then
      local text = child:GetComponent("Text")
      local str1, str2 = HandleLastWord(generalInfo.WiseSkill[index])         

      if #str1 / CN_LENGTH == 4 then
         str1 = SpliteIntoLines(str1).."\n\n"
      elseif #str1 / CN_LENGTH == 3 then
         str1 = SpliteIntoLines(str1).."\n\n\n"
      elseif #str1 / CN_LENGTH == 2 then
         str1 = SpliteIntoLines(str1).."\n\n\n\n"
      end

      if str2 == nil then
         str2 = ""
      else
         str2 = "<color=green>"..str2.."</color>"
      end

      text.text = str1..str2
   end

end

--补全从配置表里面读出的兵种名字
function HandleArmsName(name)
   
   -- 调整从配置表中读取到的兵种名字，两个字的兵种中间加空格
   -- 三个字的兵种后面加个“兵”
   -- 涉及到中文编码问题，下列操作以byte为单位
   local completeName = {}
   for j = 1, #name do
      completeName[#completeName + 1] = string.sub(name, j, j)
   end

   local f, _ = string.find(name, "兵") 
   if f ~= nil then     
      table.insert(completeName, f, "\n\n")        
   else
      table.insert(completeName, "兵")
   end

   return table.concat(completeName)

end

--将字符串逐字分割成行，以便于纵向显示
function SpliteIntoLines(name)
   
   if #name == 0 then
      return ""
   end

   local temp = {}
   local cnLength = #"国"         --中文编码字节数

   for i = 1, #name do
      temp[#temp+1] = string.sub(name, i, i)
   end

   for i = cnLength+1, #temp,  cnLength+1 do
      table.insert(temp, i, "\n")
   end

   return table.concat(temp)

end

--去除军师技名字中的括号并得到括号中的等级汉字
--return: 军师技名称 [, 军师技等级]
function HandleLastWord(name)
   
   if #name == 0 then
      return ""
   end

   --Lua中 "(" 和 ")" 是 Pattern字符，要用%进行转义
   local s, e = string.find(name, "%(")
   if s ~= nil then
      local temp = {}

      for i = 1, #name do
         temp[#temp+1] = string.sub(name, i, i)
      end

      --先去除右括号，以免影响前面字符的索引
      local ss, ee= string.find(name, "%)")
      table.remove(temp, ss, ee)

      --去除左括号
      table.remove(temp, s, e)

      local str = table.concat(temp)

      return string.sub(str, 1, #str-CN_LENGTH), string.sub(str, #str-CN_LENGTH+1, -1)
   end

   return name

end