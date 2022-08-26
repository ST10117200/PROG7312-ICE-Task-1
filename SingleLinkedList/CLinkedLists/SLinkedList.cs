using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleLinkedList.CLinkedLists
{
    class SLinkedList
    {
       CustomNode head;
        CustomNode current;
        public string data;
        int nodeCount;
        List<string> nextlist;

        public void appendNode(string data)
        {
            //If the list is empty, make a node, call it head
            if(head == null)
            {
                head = new CustomNode(data);
                nodeCount++;
                return;
            }

            current = head;

            while (current.Next!=null)
            {
                    current = current.Next;   
            }

            current.Next = new CustomNode(data);

        }

        public void prepend(string data)
        {
            if (head == null)
            {
                head=new CustomNode(data);
                nodeCount++;
            }

            else
            {
                CustomNode newHead = new CustomNode(data);
                nodeCount++;
                newHead.Next = head;
                head = newHead;
            }
        }

        public void deteleWithData(string data)
        {
            //Check if the list exists 
            if (head==null)
            {
                MessageBox.Show("Cannot delete a value from an empty list");
                return;
            }

            //What if the head contains the data we need to delete

            if (head.data.Equals(data))
            {
                head = head.Next;
            }

            //If the node we want to delete is not the head, we need to walk the list
            
            //Set the head to current walk the list
            current=head;

            while (current.Next!=null)
            {
                if (current.data.Equals(data))
                {
                    current.Next = current.Next.Next;
                    MessageBox.Show("Node with data" + data + " deleted");
                }

                current = current.Next;
            }

            MessageBox.Show("Could not delete data , data not present in list");
            //If the data does not match - check the next element

        }

        public void applyProfanityFilter(string data)
        {

            if (head == null)
            {
                MessageBox.Show("No list to clean ");
                return;
            }

            
            if (head.data.Contains(data))
            {
                string replaceString = head.data.Replace(data,"*****");
                head.data = replaceString;
                MessageBox.Show(head.data);             
            }

            current =head;

            while (current.Next!=null)
            {
                current = current.Next;
                if (current.data.Contains(data))
                {
                    string replaceString = current.data.Replace(data, "*****");
                    current.data = replaceString;
                    MessageBox.Show(current.data);              
                }
            }

            MessageBox.Show("No swear words in here!");
        }

        public void insertAfter(string nodeData,string searchData)
        {
            if (head == null)
            {
                MessageBox.Show("There is no linked list");
            }

            if(head.data.Contains(searchData))
            {
                CustomNode insertNode = new CustomNode(nodeData);
                insertNode.Next = head.Next;
                head.Next = insertNode;               
            }
        }

        public List<string> showNext()
        {
            nextlist = new List<string>();
            current = head;

            nextlist.Add(current.data);

            while (current.Next != null)
            {
                nextlist.Add(current.Next.data);
                current = current.Next;
            }

            return nextlist;
        }
    }
}