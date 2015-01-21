using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GeneralInfo 
{
    public int State { get; set; } //-1:不登场 0 :在野 1:登庸
    public int ID { get; set; } //ID
    public string Name { get; set; } //名字
    public string Face { get; set; }//大头照档名
    public int KingID { get; set; }//所属君主
    public int CityID { get; set; }//所在城市
    public int PrisonerID { get; set; }//俘虏ID
    public int Loyalty { get; set; }//忠
    public int[] Skill { get; set; }//技能列表ID int
    public int[] SkillLevel { get; set; }//技能等级列表int
    public int[] WiseSkill { get; set; }//军师技列表ID
    public int[] WiseSkillLevel { get; set; }//军师技等级列表int
    public int Title { get; set; }//官职
    public int Strength { get; set; }//武力
    public int Intellect { get; set; }//智力
    public int Experience { get; set; }//经验
    public int Level { get; set; }//等级
    public int BaseHP { get; set; }//基础体力
    public int CurHP { get; set; }//实际体力
    public int BaseMP { get; set; }//基础技力
    public int CurMP { get; set; }//实际技力
    public int SoldierMax { get; set; }//总兵数
    public int SoldierCur { get; set; }//实际兵数
    public int KnightMax { get; set; }//最高士气
    public int KnightCur { get; set; }//实际士气
    public int ForceArray { get; set; }//可选兵种
    public int UseForce { get; set; }//使用兵种
    public int BattleArray { get; set; }//可选阵型
    public int UseBattle { get; set; }//使用阵型
    public int Weapon { get; set; }//武器
    public int Horse { get; set; }//马
    public int Thing { get; set; }//物品

    public int Escape { get; set; }//逃亡几率

    public GeneralInfo()
    {

    }

    public GeneralInfo(int id)
    {
        ID = id;

        XMLDataGenerals data = XMLManager.Generals.GetInfoById(ID);

        string stateValue = data.TimesState[GamePublic.Instance.CurrentTimes];
        switch (stateValue)
        {
            case "":
                State = -1;
                break;
            case "野":
                State = 0;
                break;
            case "登":
                State = 1;
                break;
            default:
                Debugging.LogError("Function:GeneralInfo; stateValue = " + stateValue);
                break;
        }

        Name = data.Name;
        Face = data.Face;
        CityID = DataManager.FindCityID(data.Times[GamePublic.Instance.CurrentTimes]);
        if (CityID > 0 && State == 1)
        {
            KingID = GamePublic.Instance.DataManager.GetCityInfo(CityID).KingID;
        }
        else
        {
            KingID = 0;
        }
        
        PrisonerID = 0;
        Loyalty = data.Loyalty;

        GetSkills(data.Skill, data.SkillLevel);
        GetWiseSkills(data.WiseSkill, data.WiseSkillLevel);

        Title = 0;
        Strength = data.Strength;
        Intellect = data.Intellect;
        Experience = 200;
        Level = 1;
        BaseHP = data.BaseHP;
        CurHP = BaseHP;
        BaseMP = data.BaseMP;
        CurMP = BaseMP;
        SoldierMax = 10;
        SoldierCur = 10;
        KnightMax = 0;
        KnightCur = 0;
        ForceArray = DataManager.FindForceID(data.Force);
        UseForce = DataManager.FindForceID(data.UseForce);
        BattleArray = DataManager.FindBattleID(data.BattleArray);
        Weapon = DataManager.FindThingsID(data.Weapon);
        Horse = DataManager.FindThingsID(data.Horse);
        Thing = DataManager.FindThingsID(data.Thing);
        Escape = 0;
    }

    private void GetSkills(string[] skillsName, int[] skillsLevel)
    {
        List<int> listSkills = new List<int>();
        List<int> listSkillsLevel = new List<int>();
        for (int i = 0; i < skillsName.Length; i++)
        {
            if (string.IsNullOrEmpty(skillsName[i]) == false)
            {
                int skillID = DataManager.FindSkillID(skillsName[i]);
                if (skillID > 0)
                {
                    listSkills.Add(skillID);
                    if (skillsLevel[i] <= 0)
                    {
                        listSkillsLevel.Add(1);
                        Debugging.LogError("Function:GeneralInfo; skillsLevel :" + skillsLevel[i]);
                    }
                    else
                    {
                        listSkillsLevel.Add(skillsLevel[i]);
                    }
                }
                else
                {
                    Debugging.LogError("Function:GeneralInfo; skill name:" + skillsName[i]);
                }
            }
        }

        Skill = listSkills.ToArray();
        SkillLevel = listSkillsLevel.ToArray();
    }

    private void GetWiseSkills(string[] wiseName, int[] wiseLevel)
    {
        List<int> listWise = new List<int>();
        List<int> listWiseLevel = new List<int>();
        for (int i = 0; i < wiseName.Length; i++)
        {
            if (string.IsNullOrEmpty(wiseName[i]) == false)
            {
                int wiseID = DataManager.FindWiseSkillID(wiseName[i]);
                if (wiseID > 0)
                {
                    listWise.Add(wiseID);
                    if (wiseLevel[i] <= 0)
                    {
                        listWiseLevel.Add(1);
                        Debugging.LogError("Function:GeneralInfo; skillsLevel :" + wiseLevel[i]);
                    }
                    else
                    {
                        listWiseLevel.Add(wiseLevel[i]);
                    }
                }
                else
                {
                    Debugging.LogError("Function:GeneralInfo; skill name:" + wiseName[i]);
                }
            }
        }

        WiseSkill = listWise.ToArray();
        WiseSkillLevel = listWiseLevel.ToArray();
    }

    public void SetFace(GameObject sprite)
    {
        UnityEngine.UI.Image image = sprite.GetComponent<UnityEngine.UI.Image>();
        if (image == null)
        {
            Debugging.LogError("Function:SetFace; sr == null");
            return;
        }

        string facePath = GlobalConfig.PathShapeFace + Face;
        image.sprite = ResourcesManager.Instance.Load<Sprite>(facePath);
    }
}
