using System;
namespace Umep {
// fix #1 觀察下一行
  delegate void DLG();
  class Publisher {
    public void 此方法會引發事件() {
// fix #4 觀察下面if 為true 所做的事情
      if (T != null)
      {
// 引發事件
        T();
      }
    }
// fix #2 觀察下一行
//   定義event
    public event DLG  T;
  }
  class Program {
    static void Main(string[] args) {
      Console.WriteLine();
      Publisher 發行者物件 = new Publisher();
      Console.WriteLine("下面  練習 5-1 及 5-2 為 訂閱event");
      // fix #5-2 再在 練習5-1下一行的+   右邊打個=
      //  再用 anonymous method 建立事件處理程序
      //   再加入下四行
      //ConsoleColor ori = Console.ForegroundColor;
      //Console.ForegroundColor = ConsoleColor.Yellow;
      //Console.WriteLine("    事件處理程序, 用黃色印出來");
      //Console.ForegroundColor = ori;
      // fix  練習5-1 #5-1 將下一行註解取消
      //發行者物件.T +
        
      Console.WriteLine("#############################################");
      Console.WriteLine("去引發事件");
      Console.WriteLine("?????????????????????????????????????????????");
// fix #3 執行此程式, 下面會如何?
      發行者物件.此方法會引發事件();
      Console.WriteLine("@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@");
      Console.WriteLine(); Console.WriteLine(); Console.WriteLine();
      Console.WriteLine(); Console.WriteLine();
    }

    
  }
}
