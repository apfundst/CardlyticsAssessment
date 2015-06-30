using System;
using System.Collections.Generic;

namespace linkedlist
{
//	public class Node
//	{
//		public int val;
//		public Node next;
//		public Node(int n){
//			val = n;
//			next = null;
//		}
//
//	}
//	public class LinkedList
//	{
//		Node root;
//		Node cur;
//		public LinkedList(int n){
//			root = new Node(n);
//			cur = root;
//		}
//		public void push(Node n){
//			cur.next = new Node(n.val);
//		}
//		public Node getNthFromEnd(int n){
//			Node itr = root;
//			List<Node> list = new List<Node>();
//			while (itr.next != null) {
//				list.Add (itr);
//				itr = itr.next;
//			}
//			int length = list.Count;
//
//			return list [length - n];
//		
//		}
//	}
	class MainClass
	{
		public static void Main (string[] args)
		{
			List<int> l = new List<int>();
			for (int i = 1; i <= 25; i++)
				l.Add (i);

			int nth = MainClass.getNthFromEnd (5, l);
			Console.WriteLine ("The 5th from the end of a list 1-25 is: {0}", nth);
		}
		public static int getNthFromEnd(int n, List<int> list){
			int i = 0;
			int one = 0;
			int res = 0;
			//this most likely isn't the solution you want but doing this problem in c# instead of c++ irks me.

			while (i < list.Count) { //main change would be to have this loop run while next!=null
				if (i <= n){
					one = list [i];
				} else {

					one = list [i];
					res = list [i - n];

				}
				i++;
			}
			return res;

		}
	}
}
