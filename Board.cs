﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm
{
    class MyList<T>
    {
        const int DEFAULT_SIZE = 1;
        T[] _data = new T[DEFAULT_SIZE];
        public int Count; // 실제로 사용중인 데이터 개수
        public int Capacity {get {return _data.Length;} } // 예약된 데이터 개수

        // O(1) 예외 케이스 : 이사 비용은 무시한다.
        public void Add(T item)
        {
            // 1. 공간이 충분히 남아 있는지 확인한다.
            if(Count >= Capacity)
            {
                // 공간을 늘려서 확보한다.
                T[] newArray = new T[Count * 2];
                for (int i = 0; i < Count; i++)
                    newArray[i] = _data[i];
                _data = newArray;
            }
            
            // 2. 데이터를 넣어준다.
            _data[Count] = item;
            Count++;
        }

        // O(1)
        public T this[int index]
        {
            get { return _data[index]; }
            set { _data[index] = value; }
        }
        
        // O(N)
        public void RemoveAt(int index)
        {
            // 101 102 103 104 105
            for (int i = index; i < Count - 1; i++)
                _data[i] = _data[i + 1];
            _data[Count - 1] = default(T); // 마지막 남은 부분 제거

            Count--;
        }
    }

    internal class Board
    {
        // 배열 : 크기 변경 불가
        public int[] _data = new int[25];

        // 동적배열 : 크기 변경 가능(중간 삽입/삭제 불가)
        public MyList<int> _data2 = new MyList<int>();

        // 연결리스트 : 크기 변경 및 중간 삽입/삭제 가능, index 지원안함
        public LinkedList<int> _data3 = new LinkedList<int>();

        public void Initialize()
        {
            _data2.Add(101);
            _data2.Add(102);
            _data2.Add(103);
            _data2.Add(104);
            _data2.Add(105);

            int temp = _data2[2];

            _data2.RemoveAt(2);
        }
    }
}
