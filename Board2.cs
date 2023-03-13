namespace Algorithm
{
    class MyLinkedListNode<T>
    {
        public T Data;
        public MyLinkedListNode<T> Next;
        public MyLinkedListNode<T> Prev;
    }

    class MyLinkedList<T>
    {
        public MyLinkedListNode<T> FirstRoom = null; // 첫번째 방
        public MyLinkedListNode<T> LastRoom = null; // 두번째 방
        public int Count = 0;

        // O(1)
        public MyLinkedListNode<T> AddLast(T data)
        {
            MyLinkedListNode<T> newRoom = new MyLinkedListNode<T>();
            newRoom.Data = data;

            // 아직 방이 아예 없으면, 새로 추가한 첫번째 방이 곧 FirstRoom 
            if(FirstRoom == null)
            {
                FirstRoom = newRoom;
            }

            // 현재의 마지막 방과 새로운 마지막 방 연결
            if(LastRoom != null)
            {
                LastRoom.Next = newRoom;
                newRoom.Prev = LastRoom;
            }

            // [새로 추가되는 방]을 [마지막 방]으로 인정한다.
            LastRoom = newRoom;
            Count++;
            return newRoom;
        }

        // O(1)
        public void Remove(MyLinkedListNode<T> room)
        {
            // [기존의 첫번째 방의 다음 방]을 [첫번째 방]으로 인정한다.
            if(FirstRoom == room)
                FirstRoom = FirstRoom.Next;

            // [기존의 마지막 방의 이전 방]을 [마지막 방]으로 인정한다.
            if(LastRoom == room)
                LastRoom = LastRoom.Prev;

            if (room.Prev != null)
                room.Prev.Next = room.Next;

            if (room.Next != null)
                room.Next.Prev = room.Prev;

            Count--;
        }
    }

    internal class Board2
    {
        // 배열 : 크기 변경 불가
        public int[] _data = new int[25];

        // 연결리스트 : 크기 변경 및 중간 삽입/삭제 가능, index 지원안함
        public MyLinkedList<int> _data3 = new MyLinkedList<int>();

        public void Initialize()
        {
            _data3.AddLast(101);
            _data3.AddLast(102);
            MyLinkedListNode<int> node = _data3.AddLast(103);
            _data3.AddLast(104);
            _data3.AddLast(105);

            _data3.Remove(node);
        }
    }
}
