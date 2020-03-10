namespace CustomDoublyLinkedList
{
    using System;
    using System.Linq;
    public class DoublyLinkedList
    {
        private ListNode head;
        private ListNode tail;

        public int Count { get; private set; }

        public void AddFirst(int element)
        {
            if (this.Count == 0)
            {
                this.head = this.tail = new ListNode(element);

            }
            else
            {
                ListNode newHead = new ListNode(element);
                ListNode oldHead = this.head;

                this.head = newHead;
                oldHead.PreviousNode = newHead;
                newHead.NextNode = oldHead;
            }

            this.Count++;
        }
        public void AddLast(int element)
        {
            if (this.Count==0)
            {
                this.head = this.tail = new ListNode(element);
            }
            else
            {
                ListNode newTail = new ListNode(element);
                ListNode oldtail = this.tail;

                this.tail = newTail;
                oldtail.NextNode = newTail;
                newTail.PreviousNode = oldtail;
            }

            this.Count++;
        }
        public int RemoveFirst()
        {
            int? removedEl = this.head?.Value;

            if (this.Count==0)
            {
                throw new InvalidOperationException("List is empty!");
            }
            else if (this.Count==1)
            {
                this.head = null;
                this.tail = null;
            }
            else
            {
                ListNode newHead = this.head.NextNode;
                newHead.PreviousNode = null;
                this.head = newHead;
            }

            this.Count--;

            return removedEl.Value;
        }
        public int RemoveLast()
        {
            int? removedEl = this.tail?.Value;
            if (this.Count==0 || !removedEl.HasValue)
            {
                throw new InvalidOperationException("List is empty!");

            }
            else if (this.Count==1)
            {
                this.head = null;
                this.tail = null;

            }
            else
            {
                ListNode newTail = this.tail.PreviousNode;
                newTail.NextNode = null;
                this.tail = newTail;

            }

            this.Count--;

            return removedEl.Value;
        }
        public void ForEach(Action<int> action)
        {
            ListNode currentEl = this.head;
            while (currentEl!=null)
            {
                action(currentEl.Value);
                currentEl = currentEl.NextNode;
            }
        }
        public int[] ToArray()
        {
            int[] arr = new int [this.Count];
            int cnt = 0;
            ListNode currentEl = this.head;
            while (currentEl!=null)
            {
                arr[cnt++] = currentEl.Value;
                currentEl = currentEl.NextNode;
            }
            return arr;
        }
    }

}
