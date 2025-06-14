using UnityEngine;

[CreateAssetMenu(fileName = "studentinfo", menuName = "S1/S2", order = 1)]
public class info2 : ScriptableObject
{
    public int ID;
    public string Name;
    public string Logo;    //Logo图片的文件名，正好不会用unity加载图片具体之后再说
    public int  Active;        //存一下状态
}
[CreateAssetMenu(fileName = "studentinfo", menuName = "S1/S2", order = 1)]
public class info3 : ScriptableObject
{
    public int ID;
    public string Name;
    public string Logo;    //Logo图片的文件名，正好不会用unity加载图片具体之后再说
    public int  Active;        //存一下状态
}