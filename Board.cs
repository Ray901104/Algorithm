using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm
{
    internal class Board
    {
        // 배열 : 크기 변경 불가
        public int[] _data = new int[25];

        // 동적배열 : 크기 변경 가능(중간 삽입/삭제 불가)
        public List<int> _data2 = new List<int>();

        // 연결리스트 : 크기 변경 및 중간 삽입/삭제 가능
        public LinkedList<int> _data3 = new LinkedList<int>();

        public void Initialize()
        {

        }
    }
}
