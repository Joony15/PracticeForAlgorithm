using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 
 *  Design and implement a data structure for Least Recently Used (LRU) cache.
 *  It should support the following operations: get and set.
 *  get(key) - Get the value (will always be positive) of the key 
 *  if the key exists in the cache, otherwise return -1.
 *  set(key, value) - Set or insert the value if the key is 
 *  not already present. When the cache reached its capacity, 
 *  it should invalidate the least recently used item 
 *  before inserting a new item. 
 * 
 */

namespace practice3
{
    public class LRUCache
    {
        class ListNode
        {
            public int key, value;
            public ListNode prev, next; 

            public ListNode(int k, int v)
            {
                key = k;
                value = v;
                prev = null;
                next = null;
            }
        }

        private int capacity, size;
        private ListNode dummyHead, dummyTail;
        private Dictionary<int, ListNode> map;
        public bool flagment = true;

        public LRUCache (int capacity)
        {
            if ( capacity <= 0)
            {
                flagment = false;
                return;
            }

            this.capacity = capacity;
            size = 0;
            dummyHead = new ListNode(0, 0);
            dummyTail = new ListNode(0, 0);
            dummyHead.next = dummyTail;
            dummyTail.prev = dummyHead;
            map = new Dictionary<int, ListNode>();

        }
        public int Get (int Key)
        {
            if (!map.ContainsKey(Key))
                return -1;

            ListNode target= map[Key];
            remove(target);
            addToLast(target);
            return target.value;
        }
        public void Set(int key, int value)
        {
            if (map.ContainsKey(key))
            { 
                ListNode target = map[key];
                target.value = value;
                remove(target);
                addToLast(target);
            }
            else
            { 
                if (size == capacity)
                {
                    map.Remove(dummyHead.next.key);
                    remove(dummyHead.next);
                    --size;
                }

                ListNode newNode = new ListNode(key, value);
                map.Add(key, newNode);
                addToLast(newNode);
                ++size;
            }
        }

        /// <summary>
        /// two thing bleow this is for checking out beging least
        /// </summary>
        /// <param name="target"></param>
        private void addToLast(ListNode target)
        {
            target.next = dummyTail;
            target.prev = dummyTail.prev;
            dummyTail.prev.next = target;
            dummyTail.prev = target; 
        }
        private void remove(ListNode target)
        {
            target.prev.next = target.next;
            target.next.prev = target.prev;
        }
        
    }
}
