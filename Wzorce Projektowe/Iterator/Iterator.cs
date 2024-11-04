using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wzorce_Projektowe.Iterator
{

    //class BinaryTree
    //{
    //    public List<TreeNode> Nodes { get; set; }
    //    public BinaryTreeIterator<TreeNode> iterator;

    //    public BinaryTree(List<TreeNode> nodes)
    //    {
    //        Nodes = nodes;
    //        CreateIterator();

    //    }
    //    void CreateIterator() { iterator = new BinaryTreeIterator<TreeNode>(Nodes); }
    //}
    class TreeNode
    {
        public int Val { get; set; }
        public TreeNode? Left { get; set; }
        public TreeNode? Right { get; set; }

        public TreeNode() { }
        public TreeNode(int val) { Val = val; }
    }

    interface IIterator<T>
    {
        bool HasMore();
        T GetNext();
    }

    class BinaryTreeIterator : IIterator<TreeNode>
    {
        readonly Queue<TreeNode> queue = new();
        public BinaryTreeIterator(List<TreeNode> tree)
        {
            queue.Enqueue(tree.First());
        }
        public bool HasMore() { return queue.Count > 0; }
        public TreeNode GetNext()
        {
            if (HasMore())
            {
                TreeNode temp = queue.Dequeue();
                if (temp.Left != null)
                    queue.Enqueue(temp.Left);
                if (temp.Right != null)
                    queue.Enqueue(temp.Right);
                return temp;
            }
            else throw new InvalidOperationException();
        }
    }

    public interface IBinaryTreeIterable
    {
        void CreateIterator();
    }

    class BinaryTree : IBinaryTreeIterable
    {
        List<TreeNode> _tree;
        BinaryTreeIterator _iterator;

        public BinaryTree(List<TreeNode> tree)
        {
            _tree = tree;
            CreateIterator();
        }

        public void CreateIterator() { _iterator = new(_tree); }

        public BinaryTreeIterator GetIterator() { return _iterator; }

        public bool HasMore() { return _iterator.HasMore(); }
        public TreeNode GetNext() { return _iterator.GetNext(); }
    }

    class BinaryTree2 : IBinaryTreeIterable
    {
        List<TreeNode> _tree;
        BinaryTreeIterator<TreeNode> _iterator;

        public BinaryTree2(List<TreeNode> tree)
        {
            _tree = tree;
            CreateIterator();
        }
        public IEnumerator GetEnumerator() { return _iterator.GetEnumerator(); }
        //public TreeNode GetNext()
        //{
        //    IEnumerator temp = _iterator.GetEnumerator();
        //    temp.MoveNext();
        //    return (TreeNode)temp.Current;
        //}

        public void CreateIterator() { _iterator = new(_tree); }

    }

    class BinaryTreeIterator<TreeNode> : IEnumerable<Iterator.TreeNode>
    {
        readonly List<Iterator.TreeNode> _tree;

        public BinaryTreeIterator(List<Iterator.TreeNode> nodes)
        {
            _tree = nodes;
        }
        public IEnumerator<Iterator.TreeNode> GetEnumerator()
        {
            Queue<Iterator.TreeNode> bfs = new();
            bfs.Enqueue(_tree[0]);
            while (bfs.Count > 0)
            {
                Iterator.TreeNode node = bfs.Dequeue();
                if (node.Left != null)
                    bfs.Enqueue(node.Left);
                if (node.Right != null)
                    bfs.Enqueue(node.Right);
                Console.WriteLine("About to return");
                yield return node;
                Console.WriteLine("Returned");
            }
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}


