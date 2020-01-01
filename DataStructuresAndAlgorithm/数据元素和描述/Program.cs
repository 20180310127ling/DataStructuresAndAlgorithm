using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 数据元素和描述
{
    class Program
    {
        public class Text
        {
            public string tit { get; set; }

        }
        static void Main(string[] args)
        {
            List<Text> text = new List<Text>()
            {
                new Text {tit="1.以你生活的某个场景，用课程内容描述其整体的数据元素及其关系。"},
                 new Text {tit="答：一个教室有人有电脑有桌子有灯，人，电脑，桌子，灯都是元素，而他们都是一个教室里的。"},
                  new Text {tit="----------------------------------------------------------------------------------------"},
                   new Text {tit="2.结合你的生活环境，举例那些数据元素集合可以用线性表，栈，队列，树，图描述，并说明理由。"},
                    new Text {tit="  "},
                    new Text {tit="线性表： 例如软件技术2班的每个同学，理由：里面的每个同学都是属于软件技术2班的。"},
                    new Text {tit="  "},
                   new Text {tit="栈： 吃过罐装的薯片吧，薯片一片一片的放到罐里面去，想想，最先放进去的是不是放在罐的最底部。 现在一片片把薯片取出来，是不是要从最顶部开始去，也就是最后放进去的，最先取出来。 这个薯片放进去和取出来的这个过程，就是栈的工作原理啦."},
                 new Text {tit="  "},
                new Text {tit="队列： 排队买东西的人们，人往后排队但是往前出去。"},
                 new Text {tit="  "},
                new Text {tit="树： 一个学校有很多个年级而年级里又有很多个班级而班级里面又有多个学生。"},
                  new Text {tit="  "},
                new Text {tit="图： 有五个地方它们之间相互只有一条路相连，但是从一个地方到另一个地方并不止一条路。"},
            };
            foreach (var i in text)
            {
                Console.WriteLine(i.tit);
            }
            Console.ReadLine();
        }
    }
}
