using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "NPC資料", menuName ="zhen/NPC 資料")]
public class NPCDate : ScriptableObject
{
    [Header("第一段對話"),TextArea]
    public string dialougA;
    [Header("第二段對話")]
    public string dialougB;
    [Header("第三段對話")]
    public string dialougC;
    [Header("任務項目需求")]
    public string count;
    [Header("已取得項目數量")]
    public string countCurrent;
}
