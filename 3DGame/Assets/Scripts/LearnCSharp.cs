//Unity Engine API (窗口:開發人員用的倉庫)
using UnityEngine;
//類別 腳本名稱
public class LearnCSharp : MonoBehaviour
{
    //C#內的括號一定成對 () [] {} " "  ' '

    //類別:成員
    //1.屬性(欄位、屬性Prop)
    //2.方法(功能)
    //3.事件(Unity) - 特定時間執行的方法

    //開始事件 : 播放遊戲時執行一次

    private void Start()
    {
        print("嗨");
    }

    //更新事件:每一秒執行約60次
    private void Update()
    {
        print("哈哈哈~");
    }
}
