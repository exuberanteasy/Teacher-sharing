using System;
namespace Umep {
// fix #1 觀察下一行
  delegate void DLG();
  class Publisher {
    public void A方法() {
// fix #4 觀察下面if 為 true 所做的事情
      if (T != null)
      {
                // 會引發事件
                T();
      }
    }
// fix #2 觀察下一行
//   定義 event
    public event DLG T ;
  }
  class Program {
    static void Main(string[] args) {
      Console.WriteLine();
      Publisher 發行者物件 = new Publisher();
      Console.WriteLine("下面  練習 5-1 及 5-2 為 訂閱 event");
      Console.WriteLine("$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$");
      // fix #5-2 再在 練習5-1下一行的+   右邊打個=
//  再按 tab 鍵,由 Visual Studio自動建立事件處理方法 發行者物件_T
//   再將方法身體中的   throw new NotImplementedException(); 註解
//   再加入下六行程式
      //ConsoleColor ori = Console.ForegroundColor;
      //Console.ForegroundColor = ConsoleColor.Yellow;
      //Console.WriteLine("%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%");
      //Console.WriteLine("    事件處理程序, 用黃色印出來");
      //Console.WriteLine("&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&");
      //Console.ForegroundColor = ori;
      Console.WriteLine("!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!");
// fix  練習5-1 #5-1 將下一行註解取消
      // 發行者物件.T +
      Console.WriteLine("#############################################");
      Console.WriteLine("去引發事件");
      Console.WriteLine("?????????????????????????????????????????????");
// fix #3 執行此程式, 下面會如何?
      發行者物件.A方法();
      Console.WriteLine("@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@");
      Console.WriteLine();
      Console.WriteLine(); 
    }
  }
}
