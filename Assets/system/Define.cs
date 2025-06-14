using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//上面那些完全不知道该不该删
//在这定义各种初始状态用的类和其他初始值

public class School {
    public int ID;
    public string Name;
    public string Logo;    //Logo图片的文件名，正好不会用unity加载图片具体之后再说
    public int  Active;        //存一下状态
} 

public class Club{
    public int ID;
    public string Name;
    public string Logo;     //虽然理论上来说社团有个Logo比较好但BA里没有现成的图片可用...再说吧
    public int SchoolID;     //学院的的解散不意味着社团的解散，BA背景里也是这么说的
}

public class Character{
    public int ID;
    public string Name;
    public string Portraits;     //一张标准头像
    public int Level;            //说好不用的，还是用把，最近玩兰斯7感觉个人战和国战分开挺好的
    public int[] Sats;
    public int SchoolID;
}

public class State{
    public int ID;
    public string Name;
    public int[] SateInfo;
}

public class Equipment{
    public int ID;
    public string Name;
    protected void equip(){
    }
    protected void unequip(){
    }
}

public class GameEvent{
    public int ID;
    public string Name;
    public string EventInfo;
    protected void action(){
    }
}

public class GameEventCheck{
    protected int[] ActiveList;
    public void check(){
            
    }
}
